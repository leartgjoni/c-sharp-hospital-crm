using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using EPatient.Models;
using EPatient.Models.Auth;
using MetroFramework;

namespace EPatient.Views.Staff
{
    public partial class FolderForm : MetroFramework.Forms.MetroForm
    {
        private Patient _currentPatient;
        private EPatientContext _context;

        public FolderForm(int patientId)
        {
            _context = new EPatientContext();
            _currentPatient = _context.Patients.FirstOrDefault(p => p.Id == patientId);

            InitializeComponent();

            textName.Text = _currentPatient.Name;
            textSurname.Text = _currentPatient.Surname;
            textBirthday.Text = _currentPatient.Birthday.ToShortDateString();
            textGender.Text = (_currentPatient.Gender) ? "Mashkull" : "Femer";
            textPhone.Text = _currentPatient.Phone;
            textEmail.Text = _currentPatient.Email;
            textBoxAllergies.Text = _currentPatient.Allergies;
            
            gridViewFolder.DataSource = FillTable();
            StyleGrid();
            
            if (AuthUser.Model.RoleId == Role.Operator)
                btnPrint.Enabled = true;
            else
                btnPrint.Enabled = false;
        }

        private void StyleGrid()
        {
            gridViewFolder.Columns[0].Width = 50;
            gridViewFolder.Columns[1].Width = 130;
            gridViewFolder.Columns[2].Width = 130;
            gridViewFolder.Columns[3].Width = 130;
            gridViewFolder.Columns[4].Width = 130;
            gridViewFolder.Columns[5].Width = 130;
            gridViewFolder.Columns[5].Width = 130;
            
        }

        private DataTable FillTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Date");
            dataTable.Columns.Add("StartTime");
            dataTable.Columns.Add("EndTime");
            dataTable.Columns.Add("Doctor");
            dataTable.Columns.Add("Service");
            dataTable.Columns.Add("Done");

            var query = from r in _context.Reservations
                join u in _context.Users on r.UserId equals u.Id
                join s in _context.Services on r.ServiceId equals s.Id
                where r.PatientId == _currentPatient.Id
                orderby r.StartTime descending 
                select new {u, s, r};


            var reservations = query.Select(t => new
            {
                Id = t.r.Id,
                StartTime = t.r.StartTime,
                EndTime = t.r.EndTime,
                DoctorName =  t.u.Name,
                DoctorSurname = t.u.Surname,
                ServiceName = t.s.Name,
                Done = t.r.Done
            });

            foreach (var reservation in reservations)
            {
                DataRow row = dataTable.NewRow();
                row["Id"] = reservation.Id;
                row["Date"] = reservation.StartTime.ToShortDateString();
                row["StartTime"] = reservation.StartTime.ToString("H:mm");
                row["EndTime"] = reservation.EndTime.ToString("H:mm");
                row["Doctor"] = reservation.DoctorName + " " + reservation.DoctorSurname;
                row["Service"] = reservation.ServiceName;
                row["Done"] = (reservation.Done) ? "Yes" : "No";
                dataTable.Rows.Add(row);

            }

            return dataTable;
        }

        private void gridViewFolder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(gridViewFolder.SelectedRows[0].Cells[0].Value.ToString());
            if (id != 0)
            {
                var reservation = _context.Reservations.FirstOrDefault(r => r.Id == id);
                if (reservation.UserId == AuthUser.Model.Id)
                {
                    btnDiagnose.Enabled = true;
                    btnDone.Enabled = true;
                }
                else
                {
                    btnDiagnose.Enabled = false;
                    btnDone.Enabled = false;
                }
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            int id = int.Parse(gridViewFolder.SelectedRows[0].Cells[0].Value.ToString());
            if (id != 0)
            {
                var reservation = _context.Reservations.FirstOrDefault(r => r.Id == id);
                if (reservation.Done != true)
                {
                    reservation.Done = true;
                    _context.SaveChanges();
                    gridViewFolder.DataSource = FillTable();
                    MetroMessageBox.Show(this, "Rezervimi u plotesua!", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (_context.Reservations.ToList().Count == 0)
            {
                MetroMessageBox.Show(this, "Nuk ka asnje rezervim", "Info", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                return;
            }
            int id = int.Parse(gridViewFolder.SelectedRows[0].Cells[0].Value.ToString());
            if (id != 0)
            {
                using (ReservationShow frm = new ReservationShow(id))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            MetroMessageBox.Show(this, "Success", "Message", MessageBoxButtons.OK,
                                MessageBoxIcon.Question);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnDiagnose_Click(object sender, EventArgs e)
        {
            int id = int.Parse(gridViewFolder.SelectedRows[0].Cells[0].Value.ToString());
            if (id != 0)
            {
                using (ReservationDiagnose frm = new ReservationDiagnose(id))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            MetroMessageBox.Show(this, "Success", "Message", MessageBoxButtons.OK,
                                MessageBoxIcon.Question);
                            gridViewFolder.DataSource = FillTable();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private WebBrowser myWebBrowser = new WebBrowser();

        private void btnPrint_Click(object sender, EventArgs e)
        {
            myWebBrowser.DocumentCompleted += myWebBrowser_DocumentCompleted;
            string patientName = _currentPatient.Name;
            string patientSurname = _currentPatient.Surname;
            string patientGender = (_currentPatient.Gender) ? "Mashkull" : "Femer";
            string patientBirthday = _currentPatient.Birthday.ToShortDateString();
            string patientEmail = _currentPatient.Email;
            string patientPhone = _currentPatient.Phone;
            string patientAllergies = _currentPatient.Allergies;
            string head = $"<!DOCTYPE html> <html> <body> <h1 style = \'text-align: center;\'>Patient Folder</h1> <br/><br/> <h2 style = \'text-align : center;\'>Patient Info</h2> <table style= \'margin-left: 50px; margin-right: 50px;\'> <tr> <td>Name: </td> <td>{patientName}</td> <td style = \'padding-left:100px;\'>Surname: </td> <td>{patientSurname}</td> </tr> <tr> <td>Gender: </td> <td>{patientGender}</td> <td style = \'padding-left:100px;\'>Birthday: </td> <td>{patientBirthday}</td> </tr> <tr> <td>Email: </td> <td>{patientEmail}</td> <td style = \'padding-left:100px;\'>Phone: </td> <td>{patientPhone}</td> </tr> </table> <br> <p style = \'margin-left: 60px; margin-right: 60px;text-align: justify;\'>Allergies: {patientAllergies}</p> <br><br><br>";

            var reservations = _context.Reservations.Include("Service").Include("User").Where(r => r.PatientId == _currentPatient.Id).ToList();

            string body = "";

            foreach (var reservation in reservations)
            {
                string reservationDate = reservation.StartTime.ToShortDateString();
                string reservationHour = reservation.StartTime.ToString("H:mm");
                string reservationUserNameSurname = reservation.User.Name + " " + reservation.User.Surname;
                string reservationServiceName = reservation.Service.Name;
                string reservationRecipe = reservation.Recipe;
                string reservationString =
                    $"<div style = \'border: 1px solid black;margin-left:50px; margin-right: 50px;\'> <h2 style = \'text-align : center;\'>Reservation Info</h2> <table style= \'margin-left: 10px; margin-right: 10px;\'> <tr> <td>Date:</td> <td>{reservationDate}</td> <td style = \'padding-left:100px;\'>Hour: </td> <td>{reservationHour}</td> </tr> <tr> <td>Doctor: </td> <td>{reservationUserNameSurname}</td> <td style = \'padding-left:100px;\'>Service </td> <td>{reservationServiceName}</td> </tr> </table> <br> <p style = \'margin-left: 10px; margin-right: 10px;\'>Recipe: {reservationRecipe}</p> </div> <br><br><br>";
                body += reservationString;
            }

            string footer = "</body></html>";
            string html = head + body + footer;
            myWebBrowser.DocumentText = html;
        }

        private void myWebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            myWebBrowser.ShowPageSetupDialog();
            myWebBrowser.ShowPrintDialog();
        }

    }
}
