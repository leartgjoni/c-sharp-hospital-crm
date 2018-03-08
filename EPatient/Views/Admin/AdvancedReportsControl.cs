using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using EPatient.Models;
using LiveCharts;
using LiveCharts.Wpf;
using Brushes = System.Windows.Media.Brushes;

namespace EPatient.Views.Admin
{
    public partial class AdvancedReportsControl : MetroFramework.Controls.MetroUserControl
    {
        private EPatientContext _context;
        private WebBrowser myWebBrowser = new WebBrowser();
        private User _selectedDoctor;
        private int _selectedDoctorId;
        private List<DateReport> _dateReports;
        private List<HourReport> _hourReports;


        public AdvancedReportsControl()
        {
            _context = new EPatientContext();
            myWebBrowser.DocumentCompleted += myWebBrowser_DocumentCompleted;
            InitializeComponent();

            listBoxSearchDoctor.DisplayMember = "NameSurname";
            listBoxSearchDoctor.ValueMember = "Id";
            var doctors = _context.Users.Where(d => d.RoleId == Role.Doctor || d.RoleId == Role.Nurse).Select(t => new
            {
                Id = t.Id,
                NameSurname = t.Name + " " + t.Surname
            }).ToList();

            doctors.Insert(0, new { Id = 0, NameSurname = "All Doctors" });
            listBoxSearchDoctor.DataSource = doctors;
  
        }

        public void FillChart1()
        {
            cartesianChart1.Series = new SeriesCollection();
            cartesianChart1.AxisX = new AxesCollection();
            cartesianChart1.AxisY = new AxesCollection();

            var seriesValue = new ChartValues<double>();
            List<string> labelsValue = new List<string>();

            foreach (var dateReport in _dateReports.OrderBy(t => t.Date))
            {
                labelsValue.Add(dateReport.Date.Value.ToShortDateString());
                seriesValue.Add(dateReport.TotalReservations);
            }
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Reservations",
                    Values = seriesValue,
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 8
                }
            };

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Date",
                Labels = labelsValue
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Reservation",
                Separator = new Separator
                {
                    Step = 1
                },
                MinValue = 0
            });

            cartesianChart1.LegendLocation = LegendLocation.Right;
            cartesianChart1.Background = Brushes.White;
        }

        public void FillChart2()
        {
            cartesianChart2.Series = new SeriesCollection();
            cartesianChart2.AxisX = new AxesCollection();
            cartesianChart2.AxisY = new AxesCollection();

            var seriesValue = new ChartValues<double>();
            List<string> labelsValue = new List<string>();
            
            foreach (var hourReport in _hourReports)
            {
                labelsValue.Add(hourReport.Hour + ":00 - " + hourReport.Hour + ":59");
                seriesValue.Add(hourReport.TotalReservations);
            }
          
            cartesianChart2.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Rezervime",
                    Values = seriesValue,
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 8
                }
            };

            cartesianChart2.AxisX.Add(new Axis
            {
                Title = "Oret",
                Labels = labelsValue
            });

            cartesianChart2.AxisY.Add(new Axis
            {
                Title = "Rezervime",
                Separator = new Separator
                {
                    Step = 1
                },
                MinValue =  0
            });

            cartesianChart2.LegendLocation = LegendLocation.Right;
            cartesianChart2.Background = Brushes.White;
        }

        private void textSearchDoctor_TextChanged(object sender, EventArgs e)
        {
            var search = textSearchDoctor.Text;
            listBoxSearchDoctor.DataSource = _context.Users
                .Where(t => t.Name.Contains(search) || t.Surname.Contains(search))
                .Select(t => new
                {
                    Id = t.Id,
                    NameSurname = t.Name + " " + t.Surname
                }).ToList();
        }

        private void checkBoxDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDate.Checked)
            {
                dateTimePickerStartDate.Enabled = true;
                dateTimePickerEndDate.Enabled = true;
                FillControls();
            }
            else
            {
                dateTimePickerStartDate.Enabled = false;
                dateTimePickerEndDate.Enabled = false;
                FillControls();
            }

        }

        private void listBoxSearchDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            var doctorId = (int)listBoxSearchDoctor.SelectedValue;
            _selectedDoctorId = doctorId;
            _selectedDoctor = _context.Users.SingleOrDefault(d => d.Id == doctorId);
            FillControls();
        }

        private void FillControls()
        {
            FillDateGrid();
            FillHourGrid();
            FillChart1();
            FillChart2();
        }

        public void FillDateGrid()
        {
            var dates = _context.Reservations
                .Where(t => _selectedDoctorId == 0 || t.UserId == _selectedDoctorId)
                .Where(t => !checkBoxDate.Checked ||
                            DbFunctions.TruncateTime(t.StartTime) >= DbFunctions.TruncateTime(dateTimePickerStartDate.Value) && DbFunctions.TruncateTime(t.StartTime) <= DbFunctions.TruncateTime(dateTimePickerEndDate.Value))
                .Select(t => new
                {
                    Date = DbFunctions.TruncateTime(t.StartTime),
                    ReservationId = t.Id
                }).GroupBy(t => t.Date)
                .Select(t => new DateReport()
                {
                    Date = t.Select(r => r.Date).FirstOrDefault(),
                    TotalReservations = t.Count(r => r.ReservationId != 0)
                })
                .OrderByDescending(t => t.TotalReservations)
                .ToList();

            _dateReports = dates;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Date");
            dataTable.Columns.Add("Total Reservation");

            foreach (var date in dates)
            {
                DataRow row = dataTable.NewRow();
                row["Date"] = date.Date;
                row["Total Reservation"] = date.TotalReservations;
                dataTable.Rows.Add(row);
            }

            metroGrid.DataSource = dataTable;

        }

        public void FillHourGrid()
        {
            List<HourReport> hourReports = new List<HourReport>();
            for (int i = 0; i < 24; i++)
            {
                var hourStart = (DateTime.Now.Date + new TimeSpan(i, 00, 00)).TimeOfDay;
                var hourEnd = (DateTime.Now.Date + new TimeSpan(i, 59, 00)).TimeOfDay;
                
                int count = _context.Reservations
                    .Where(t => _selectedDoctorId == 0 || t.UserId == _selectedDoctorId)
                    .Where(t => !checkBoxDate.Checked ||
                                DbFunctions.TruncateTime(t.StartTime) >= DbFunctions.TruncateTime(dateTimePickerStartDate.Value) && DbFunctions.TruncateTime(t.StartTime) <= DbFunctions.TruncateTime(dateTimePickerEndDate.Value))
                    .Count(t => hourStart <= DbFunctions.CreateTime(t.StartTime.Hour, t.StartTime.Minute, t.StartTime.Second) &&
                                hourEnd >= DbFunctions.CreateTime(t.StartTime.Hour, t.StartTime.Minute, t.StartTime.Second));
                hourReports.Add(new HourReport(){Hour = i, TotalReservations = count});
            }

            _hourReports = hourReports;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Hour");
            dataTable.Columns.Add("Total Reservations");

            foreach (var hourReport in hourReports)
            {
                DataRow row = dataTable.NewRow();
                row["Hour"] = hourReport.Hour + ":00 - " + hourReport.Hour + ":59";
                row["Total Reservations"] = hourReport.TotalReservations;
                dataTable.Rows.Add(row);
            }

            metroGrid1.DataSource = dataTable;
        }

        private void btnPrintTable_Click(object sender, EventArgs e)
        {
            string DoctorName;
            if (_selectedDoctorId == 0)
                 DoctorName = "All Doctors";
            else
                DoctorName = _selectedDoctor.Name;
            string startDate = checkBoxDate.Checked ? dateTimePickerStartDate.Value.ToShortDateString() : "beginning";
            string endDate = checkBoxDate.Checked ? dateTimePickerEndDate.Value.ToShortDateString() : "Now";
            string head = $"<!DOCTYPE html> <html> <body> <h2 style = \'text-align: center;\'>Report for {DoctorName}</h2> <br><br> <h3 style = \'text-align:center;\'>Report from {startDate} to {endDate}</h3><br><br> <table style = \'border: 1px solid black; border-collapse: collapse; width: 100%;\'> <tr style = \'text-align: center;\'> <th style = \'border: 1px solid black; border-collapse: collapse;\'>Date</th> <th style = \'border: 1px solid black; border-collapse: collapse;\'>Total Reservation</th> </tr>";

            string body = "";

            foreach (var dateReport in _dateReports)
            {
                string date = dateReport.Date.Value.ToShortDateString();
                string totalReservations = dateReport.TotalReservations.ToString();
                string reservationString = $"<tr style = \'text-align: center;\'> <td style = \'border: 1px solid black; border-collapse: collapse;\'>{date}</td> <td style = \'border: 1px solid black; border-collapse: collapse;\'>{totalReservations}</td> </tr>";
                body += reservationString;
            }

            string footer = "</table></body></html>";
            string html = head + body + footer;
            myWebBrowser.DocumentText = html;
        }

        private void myWebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            myWebBrowser.ShowPageSetupDialog();
            myWebBrowser.ShowPrintDialog();
        }

        private void btnPrintTable2_Click(object sender, EventArgs e)
        {
            string DoctorName;
            if (_selectedDoctorId == 0)
                DoctorName = "All Doctors";
            else
                DoctorName = _selectedDoctor.Name;
            string startDate = checkBoxDate.Checked ? dateTimePickerStartDate.Value.ToShortDateString() : "beginning";
            string endDate = checkBoxDate.Checked ? dateTimePickerEndDate.Value.ToShortDateString() : "Now";
            string head = $"<!DOCTYPE html> <html> <body> <h2 style = \'text-align: center;\'>Report for {DoctorName}</h2> <br><br> <h3 style = \'text-align:center;\'>Report from {startDate} to {endDate}</h3><br><br> <table style = \'border: 1px solid black; border-collapse: collapse; width: 100%;\'> <tr style = \'text-align: center;\'> <th style = \'border: 1px solid black; border-collapse: collapse;\'>Hour</th> <th style = \'border: 1px solid black; border-collapse: collapse;\'>Total Reservation</th> </tr>";

            string body = "";

            foreach (var hourReport in _hourReports)
            {
                string hour = hourReport.Hour + ":00 - " + hourReport.Hour + ":59";
                string totalReservations = hourReport.TotalReservations.ToString();
                string reservationString = $"<tr style = \'text-align: center;\'> <td style = \'border: 1px solid black; border-collapse: collapse;\'>{hour}</td> <td style = \'border: 1px solid black; border-collapse: collapse;\'>{totalReservations}</td> </tr>";
                body += reservationString;
            }

            string footer = "</table></body></html>";
            string html = head + body + footer;
            myWebBrowser.DocumentText = html;
        }

        private void dateTimePickerStartDate_ValueChanged(object sender, EventArgs e)
        {
            FillControls();
        }

        private void dateTimePickerEndDate_ValueChanged(object sender, EventArgs e)
        {
            FillControls();
        }

        private void btnPrintChart1_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += this.Doc_PrintPage1;
            PrintDialog dlgSettings = new PrintDialog();
            dlgSettings.Document = doc;
            if (dlgSettings.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }

        private void Doc_PrintPage1(object sender, PrintPageEventArgs e)
        {
            string DoctorName;
            if (_selectedDoctorId == 0)
                DoctorName = "All Doctors";
            else
                DoctorName = _selectedDoctor.Name;
            string startDate = checkBoxDate.Checked ? dateTimePickerStartDate.Value.ToShortDateString() : "fillimi";
            string endDate = checkBoxDate.Checked ? dateTimePickerEndDate.Value.ToShortDateString() : "Tani";

            Bitmap bmp = new Bitmap(this.cartesianChart1.Width, this.cartesianChart1.Height);
            this.cartesianChart1.DrawToBitmap(bmp, new Rectangle(0, 0, this.cartesianChart1.Width, this.cartesianChart1.Height));
            e.Graphics.DrawString($"Raport nga {DoctorName}", new Font("Times New Roman", 18, FontStyle.Bold), System.Drawing.Brushes.Black, new PointF(300, 100));
            e.Graphics.DrawString($"Raport nga {startDate} Ne {endDate}", new Font("Times New Roman", 18, FontStyle.Bold), System.Drawing.Brushes.Black, new PointF(250, 200));
            e.Graphics.DrawImage((Image)bmp, 100, 300);
        }

        private void btnPrintChart2_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += this.Doc_PrintPage2;
            PrintDialog dlgSettings = new PrintDialog();
            dlgSettings.Document = doc;
            if (dlgSettings.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }

        private void Doc_PrintPage2(object sender, PrintPageEventArgs e)
        {
            string DoctorName;
            if (_selectedDoctorId == 0)
                DoctorName = "All Doctors";
            else
                DoctorName = _selectedDoctor.Name;
            string startDate = checkBoxDate.Checked ? dateTimePickerStartDate.Value.ToShortDateString() : "fillimi";
            string endDate = checkBoxDate.Checked ? dateTimePickerEndDate.Value.ToShortDateString() : "Tani";


            Bitmap bmp = new Bitmap(this.cartesianChart2.Width, this.cartesianChart2.Height);
            this.cartesianChart2.DrawToBitmap(bmp, new Rectangle(0, 0, this.cartesianChart2.Width, this.cartesianChart2.Height));

            e.Graphics.DrawString($"Raporte nga {DoctorName}", new Font("Times New Roman", 18, FontStyle.Bold), System.Drawing.Brushes.Black, new PointF(300, 100));
            e.Graphics.DrawString($"Raporte nga {startDate} Ne {endDate}", new Font("Times New Roman", 18, FontStyle.Bold), System.Drawing.Brushes.Black, new PointF(250, 200));
            e.Graphics.DrawImage((Image)bmp, 100, 300);
        }
    }

    class HourReport
    {
        public int Hour;
        public int TotalReservations;
    }

    class DateReport
    {
        public DateTime? Date;
        public int TotalReservations;
    }
}
