using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using EPatient.Models;

namespace EPatient.Views.Admin
{
    public partial class BasicReportsControl : MetroFramework.Controls.MetroUserControl
    {
        private EPatientContext _context;
        private WebBrowser myWebBrowser = new WebBrowser();
        private List<DoctorReport> _doctorReports;
        private List<ServiceReport> _serviceReports;
        private List<PatientReport> _patientReports;

        private DateTime _reservationsStartFilter;
        private DateTime _reservationsEndFilter;
        private int _reservationsCount;

        public BasicReportsControl()
        {
            _context = new EPatientContext();
            myWebBrowser.DocumentCompleted += myWebBrowser_DocumentCompleted;
            InitializeComponent();
            FillGrids();
        }

        public void FillGrids()
        {
            var reservations = _context.Reservations.Where(r => !checkBoxEnable.Checked ||
                                                                DbFunctions.TruncateTime(r.StartTime) >=
                                                                DbFunctions.TruncateTime(dateTimePicker1.Value) &&
                                                                DbFunctions.TruncateTime(r.StartTime) <=
                                                                DbFunctions.TruncateTime(dateTimePicker2.Value));
            if (checkBoxEnable.Checked)
            {
                textStartDate.Text = dateTimePicker1.Value.ToShortDateString();
                textEndDate.Text = dateTimePicker2.Value.ToShortDateString();
            }
            else
            {
                var firstReservation = reservations.FirstOrDefault();
                var lastReservation = reservations.OrderByDescending(r => r.Id).FirstOrDefault();
                textStartDate.Text = firstReservation != null ? firstReservation.StartTime.ToShortDateString() : "";
                textEndDate.Text = lastReservation != null ? lastReservation.StartTime.ToShortDateString() : "";

                if (firstReservation != null)
                    _reservationsStartFilter = firstReservation.StartTime;
                if (lastReservation != null)
                    _reservationsEndFilter = lastReservation.StartTime;
            }

            textTotReservations.Text = reservations.Count().ToString();
            _reservationsCount = reservations.Count();

            FillDoctorsGrid();
            FillServicesGrid();
            FillPatientsGrid();
        }

        public void FillDoctorsGrid()
        {
            var query = _context.Reservations
                .Where(r => !checkBoxEnable.Checked ||
                            DbFunctions.TruncateTime(r.StartTime) >= DbFunctions.TruncateTime(dateTimePicker1.Value) && DbFunctions.TruncateTime(r.StartTime) <= DbFunctions.TruncateTime(dateTimePicker2.Value))
                .Include("User")
                .Include("Service")
                .GroupBy(t => t.UserId)
                .Select(t => new DoctorReport()
                {
                    UserNameSurname = t.Select(r => r.User.Name + " " + r.User.Surname).FirstOrDefault(),
                    TotalReservations = t.Count(r => r.Id != 0),
                    TotalPrice = t.Sum(r => r.Service.Price)
                })
                .OrderByDescending(t => t.TotalReservations)
                .ToList();

            _doctorReports = query;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Staff");
            dataTable.Columns.Add("Total Reservation");
            dataTable.Columns.Add("Total Income");

            foreach (var doctorReport in query)
            {
                DataRow row = dataTable.NewRow();
                row["Staff"] = doctorReport.UserNameSurname;
                row["Total Reservation"] = doctorReport.TotalReservations;
                row["Total Income"] = doctorReport.TotalPrice + " LEK";
                dataTable.Rows.Add(row);
            }

            metroGridDoctor.DataSource = dataTable;
        }

        public void FillServicesGrid()
        {
            var query = _context.Reservations
                .Where(r => !checkBoxEnable.Checked ||
                            DbFunctions.TruncateTime(r.StartTime) >= DbFunctions.TruncateTime(dateTimePicker1.Value) && DbFunctions.TruncateTime(r.StartTime) <= DbFunctions.TruncateTime(dateTimePicker2.Value))
                .Include("Service")
                .GroupBy(t => t.ServiceId)
                .Select(t => new ServiceReport()
                {
                    ServiceName = t.Select(r => r.Service.Name).FirstOrDefault(),
                    TotalReservations = t.Count(r => r.Id != 0),
                    TotalPrice = t.Sum(r => r.Service.Price)
                })
                .OrderByDescending(t => t.TotalReservations)
                .ToList();

            _serviceReports = query;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Service");
            dataTable.Columns.Add("Total Reservation");
            dataTable.Columns.Add("Total Income");

            foreach (var doctorReport in query)
            {
                DataRow row = dataTable.NewRow();
                row["Service"] = doctorReport.ServiceName;
                row["Total Reservation"] = doctorReport.TotalReservations;
                row["Total Income"] = doctorReport.TotalPrice + " LEK";
                dataTable.Rows.Add(row);
            }

            metroGridService.DataSource = dataTable;
        }

        public void FillPatientsGrid()
        {
            var query = _context.Reservations
                .Where(r => !checkBoxEnable.Checked ||
                            DbFunctions.TruncateTime(r.StartTime) >= DbFunctions.TruncateTime(dateTimePicker1.Value) && DbFunctions.TruncateTime(r.StartTime) <= DbFunctions.TruncateTime(dateTimePicker2.Value))
                .Include("Patient")
                .Include("Service")
                .GroupBy(t => t.PatientId)
                .Select(t => new PatientReport()
                {
                    PatientNameSurname = t.Select(r => r.Patient.Name + " " + r.Patient.Surname).FirstOrDefault(),
                    TotalReservations = t.Count(r => r.Id != 0), 
                    TotalPrice = t.Sum(r => r.Service.Price)
                })
                .OrderByDescending(t => t.TotalReservations)
                .ToList();

            _patientReports = query;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Patient");
            dataTable.Columns.Add("Total Reservation");
            dataTable.Columns.Add("Total Income");

            foreach (var doctorReport in query)
            {
                DataRow row = dataTable.NewRow();
                row["Patient"] = doctorReport.PatientNameSurname;
                row["Total Reservation"] = doctorReport.TotalReservations;
                row["Total Income"] = doctorReport.TotalPrice + " LEK";
                dataTable.Rows.Add(row);
            }

            metroGridPatient.DataSource = dataTable;
        }

        private void checkBoxEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEnable.Checked)
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
            else
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                FillGrids();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            FillGrids();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            FillGrids();
        }
        

        private void btnPrintDoctor_Click(object sender, EventArgs e)
        {
            string ModelName = "Doctor";
            string startDate = checkBoxEnable.Checked ? dateTimePicker1.Value.ToShortDateString() : _reservationsStartFilter.ToShortDateString();
            string endDate = checkBoxEnable.Checked ? dateTimePicker2.Value.ToShortDateString() : _reservationsEndFilter.ToShortDateString();
            string reservationsCount = _reservationsCount.ToString();
            string head = $"<!DOCTYPE html> <html> <body> <h2 style = \'text-align: center;\'>{ModelName} Report</h2> <br><br> <h3 style = \'text-align:center;\'>Report from {startDate} to {endDate}</h3> <h3 style = \'text-align:center;\'>Total Reservations: {reservationsCount}</h3> <br><br> <table style = \'border: 1px solid black; border-collapse: collapse; width: 100%;\'> <tr style = \'text-align: center;\'> <th style = \'border: 1px solid black; border-collapse: collapse;\'>{ModelName}</th> <th style = \'border: 1px solid black; border-collapse: collapse;\'>Total Reservation</th> <th style = \'border: 1px solid black; border-collapse: collapse;\'>Total Income</th> </tr>";
            
            string body = "";

            foreach (var doctor in _doctorReports)
            {
                string name = doctor.UserNameSurname;
                string totalReservations = doctor.TotalReservations.ToString();
                string totalIncome = doctor.TotalPrice.ToString();
                string reservationString = $"<tr style = \'text-align: center;\'> <td style = \'border: 1px solid black; border-collapse: collapse;\'>{name}</td> <td style = \'border: 1px solid black; border-collapse: collapse;\'>{totalReservations}</td> <td style = \'border: 1px solid black; border-collapse: collapse;\'>{totalIncome}</td> </tr>";
                body += reservationString;
            }

            string footer = "</table></body></html>";
            string html = head + body + footer;
            myWebBrowser.DocumentText = html;
        }

        private void btnPrintService_Click(object sender, EventArgs e)
        {
            string ModelName = "Service";
            string startDate = checkBoxEnable.Checked ? dateTimePicker1.Value.ToShortDateString() : _reservationsStartFilter.ToShortDateString();
            string endDate = checkBoxEnable.Checked ? dateTimePicker2.Value.ToShortDateString() : _reservationsEndFilter.ToShortDateString();
            string reservationsCount = _reservationsCount.ToString();
            string head = $"<!DOCTYPE html> <html> <body> <h2 style = \'text-align: center;\'>{ModelName} Report</h2> <br><br> <h3 style = \'text-align:center;\'>Report from {startDate} to {endDate}</h3> <h3 style = \'text-align:center;\'>Total Reservations: {reservationsCount}</h3> <br><br> <table style = \'border: 1px solid black; border-collapse: collapse; width: 100%;\'> <tr style = \'text-align: center;\'> <th style = \'border: 1px solid black; border-collapse: collapse;\'>{ModelName}</th> <th style = \'border: 1px solid black; border-collapse: collapse;\'>Total Reservation</th> <th style = \'border: 1px solid black; border-collapse: collapse;\'>Total Income</th> </tr>";

            string body = "";

            foreach (var service in _serviceReports)
            {
                string name = service.ServiceName;
                string totalReservations = service.TotalReservations.ToString();
                string totalIncome = service.TotalPrice.ToString();
                string reservationString = $"<tr style = \'text-align: center;\'> <td style = \'border: 1px solid black; border-collapse: collapse;\'>{name}</td> <td style = \'border: 1px solid black; border-collapse: collapse;\'>{totalReservations}</td> <td style = \'border: 1px solid black; border-collapse: collapse;\'>{totalIncome}</td> </tr>";
                body += reservationString;
            }

            string footer = "</table></body></html>";
            string html = head + body + footer;
            myWebBrowser.DocumentText = html;
        }

        private void btnPrintPatient_Click(object sender, EventArgs e)
        {
            string ModelName = "Patient";
            string startDate = checkBoxEnable.Checked ? dateTimePicker1.Value.ToShortDateString() : _reservationsStartFilter.ToShortDateString();
            string endDate = checkBoxEnable.Checked ? dateTimePicker2.Value.ToShortDateString() : _reservationsEndFilter.ToShortDateString();
            string reservationsCount = _reservationsCount.ToString();
            string head = $"<!DOCTYPE html> <html> <body> <h2 style = \'text-align: center;\'>{ModelName} Report</h2> <br><br> <h3 style = \'text-align:center;\'>Report from {startDate} to {endDate}</h3> <h3 style = \'text-align:center;\'>Total Reservations: {reservationsCount}</h3> <br><br> <table style = \'border: 1px solid black; border-collapse: collapse; width: 100%;\'> <tr style = \'text-align: center;\'> <th style = \'border: 1px solid black; border-collapse: collapse;\'>{ModelName}</th> <th style = \'border: 1px solid black; border-collapse: collapse;\'>Total Reservation</th> <th style = \'border: 1px solid black; border-collapse: collapse;\'>Total Income</th> </tr>";

            string body = "";

            foreach (var patient in _patientReports)
            {
                string name = patient.PatientNameSurname;
                string totalReservations = patient.TotalReservations.ToString();
                string totalIncome = patient.TotalPrice.ToString();
                string reservationString = $"<tr style = \'text-align: center;\'> <td style = \'border: 1px solid black; border-collapse: collapse;\'>{name}</td> <td style = \'border: 1px solid black; border-collapse: collapse;\'>{totalReservations}</td> <td style = \'border: 1px solid black; border-collapse: collapse;\'>{totalIncome}</td> </tr>";
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
    }

    class DoctorReport
    {
        public string UserNameSurname;
        public int TotalReservations;
        public float TotalPrice;
    }

    class ServiceReport
    {
        public string ServiceName;
        public int TotalReservations;
        public float TotalPrice;
    }

    class PatientReport
    {
        public string PatientNameSurname;
        public int TotalReservations;
        public float TotalPrice;
    }
}
