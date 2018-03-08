using System;
using System.Drawing;
using System.Data;
using System.Data.Entity;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using EPatient.Models;
using MetroFramework;

namespace EPatient.Views.Operator
{
    public partial class ReservationsControl : MetroFramework.Controls.MetroUserControl
    {
        private EPatientContext _context;

        public ReservationsControl()
        {
            InitializeComponent();
            _context = new EPatientContext();
        }

        private void ReservationsControl_Load(object sender, EventArgs e)
        {
            gridView.DataSource = FillTable();
            gridView.Columns[0].Width = 30;
            gridView.Columns[1].Width = 170;
            gridView.Columns[2].Width = 150;
            gridView.Columns[3].Width = 170;
            gridView.Columns[4].Width = 170;
            gridView.Columns[5].Width = 50;
            gridView.Columns[6].Width = 50;
            gridView.Columns[7].Width = 100;

        }

        private DataTable FillTable(String search = null, DateTime? date = null)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Patient");
            dataTable.Columns.Add("Service");
            dataTable.Columns.Add("Date");
            dataTable.Columns.Add("Doctor/Nurse");
            dataTable.Columns.Add("Paid");
            dataTable.Columns.Add("Done");
            dataTable.Columns.Add("Price");
           
            var query = from r in _context.Reservations
                join u in _context.Users on r.UserId equals u.Id
                join p in _context.Patients on r.PatientId equals p.Id
                join s in _context.Services on r.ServiceId equals s.Id
                orderby r.StartTime descending
                select new {u, p, s, r};

            if (!String.IsNullOrEmpty(search))
                query = query.Where(t => t.p.Name.Contains(search) ||
                                         t.p.Surname.Contains(search) ||
                                         t.p.Email.Contains(search));

            if(date != null)
                query = query.Where(t => DbFunctions.TruncateTime(t.r.StartTime) == DbFunctions.TruncateTime(date));

            var reservations = query.Select(t => new
            {
                Id = t.r.Id,
                PatientName = t.p.Name,
                PatientSurname = t.p.Surname,
                ServiceName = t.s.Name,
                StartTime = t.r.StartTime,
                UserName = t.u.Name,
                UserSurname = t.u.Surname,
                Paid = t.r.Paid,
                Done = t.r.Done,
                Price = t.s.Price
            });


            foreach (var reservation in reservations)
            {
                DataRow row = dataTable.NewRow();
                row["Id"] = reservation.Id;
                row["Patient"] = reservation.PatientName + " " + reservation.PatientSurname;
                row["Service"] = reservation.ServiceName;
                row["Date"] = reservation.StartTime;
                row["Doctor/Nurse"] = reservation.UserName + " " + reservation.UserSurname;
                row["Paid"] = reservation.Paid ? "Yes" : "No";
                row["Done"] = reservation.Done ? "Yes" : "No";
                row["Price"] = reservation.Price + "lek";
                dataTable.Rows.Add(row);

            }

            return dataTable;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MetroMessageBox.Show(this, "Jeni te sigurt per fshirjen e ketij rekordi?", "Message",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    int id = int.Parse(gridView.SelectedRows[0].Cells[0].Value.ToString());
                    if (id != 0)
                    {
                        var reservation = _context.Reservations.SingleOrDefault(r => r.Id == id);
                        _context.Reservations.Remove(reservation);
                        _context.SaveChanges();
                        gridView.DataSource = FillTable();
                    }
                }
            }

            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                dateTimePicker1.Enabled = true;
            else
            {
                dateTimePicker1.Enabled = false;
                gridView.DataSource = FillTable();
            }
                
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            gridView.DataSource = FillTable(searchTextBox.Text, dateTimePicker1.Value);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Enabled)
                gridView.DataSource = FillTable(searchTextBox.Text, dateTimePicker1.Value);
            else
                gridView.DataSource = FillTable(searchTextBox.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (AddReservationForm frm = new AddReservationForm())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        MetroMessageBox.Show(this, "Success", "Message", MessageBoxButtons.OK,
                            MessageBoxIcon.Question);
                        gridView.DataSource = FillTable();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnQuick_Click(object sender, EventArgs e)
        {
            using (AddQuickReservation frm = new AddQuickReservation())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        MetroMessageBox.Show(this, "Success", "Message", MessageBoxButtons.OK,
                            MessageBoxIcon.Question);
                        gridView.DataSource = FillTable();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (gridView.RowCount == 0)
            {
                MetroMessageBox.Show(this, "Nuk ka asnje rezervim!", "Info", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
            }
            else
            {
                int id = int.Parse(gridView.SelectedRows[0].Cells[0].Value.ToString());
                if (id != 0)
                {
                    var reservation = _context.Reservations.SingleOrDefault(r => r.Id == id);
                    if (reservation.Paid)
                    {
                        MetroMessageBox.Show(this, "Rezervimi sapo u pagua", "Warning", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    if (MetroMessageBox.Show(this, "Doni te printoni faturen?", "Pay", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    {
                        reservation.Paid = true;
                        _context.SaveChanges();
                        gridView.DataSource = FillTable();
                        PrintReservation();
                        MetroMessageBox.Show(this, "E paguar me sukses!", "Success", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (gridView.RowCount == 0)
            {
                MetroMessageBox.Show(this, "There is no reservation", "Info", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                return;
            }
            PrintReservation();
        }

        private void PrintReservation()
        {
            using (PrintDialog printDialog = new PrintDialog())
            {
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    PrintDocument printDocument = new PrintDocument();
                    printDocument.PrintPage += printDocument1_PrintPage;
                    printDocument.Print();
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (gridView.RowCount == 0)
            {
                MetroMessageBox.Show(this, "There is no reservation", "Info", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                return;
            }
            int id = int.Parse(gridView.SelectedRows[0].Cells[0].Value.ToString());
            if (id != 0)
            {
                var reservation = _context.Reservations.Include("Service").Include("User").Include("Patient").SingleOrDefault(r => r.Id == id);
                e.Graphics.DrawString("EPatient - Reservation", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new PointF(300, 100));
                e.Graphics.DrawString("Patient: " + reservation.Patient.Name + " " + reservation.Patient.Surname, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(80, 150));
                e.Graphics.DrawString("Data: " + reservation.StartTime.Date.ToShortDateString(), new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(600, 150));
                e.Graphics.DrawString("Doctor: " + reservation.User.Name + " " + reservation.User.Surname, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(80, 200));
                e.Graphics.DrawString("Ora: " + reservation.StartTime.ToString("H:mm"), new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(600, 200));
                e.Graphics.DrawString("Service: " + reservation.Service.Name, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(80, 250));
                e.Graphics.DrawString("Price: " + reservation.Service.Price + "Lek", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(600, 250));
                e.Graphics.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(50, 80, 730, 250));
            }
        }
    }
}
