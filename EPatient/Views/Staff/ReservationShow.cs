using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using EPatient.Models;

namespace EPatient.Views.Staff
{
    public partial class ReservationShow : MetroFramework.Forms.MetroForm
    {
        private Reservation _currentReservation;
        private EPatientContext _context;

        public ReservationShow(int reservationId)
        {
            _context = new EPatientContext();
            _currentReservation = _context.Reservations.Include("User").Include("Service").Include("Patient").FirstOrDefault(r => r.Id == reservationId);
            InitializeComponent();

            textPatient.Text = _currentReservation.Patient.Name;
            textDoctor.Text = _currentReservation.User.Name;
            textService.Text = _currentReservation.Service.Name;
            textPaid.Text = _currentReservation.Paid ? "Po" : "Jo";
            textDate.Text = _currentReservation.StartTime.ToShortDateString();
            textDuration.Text = _currentReservation.StartTime.ToString("H:mm") + " - " + _currentReservation.EndTime.ToString("H:mm");
            textRecipe.Text = _currentReservation.Recipe;


            if (_currentReservation.File == null)
                btnDownload.Enabled = false;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            var extension = Path.GetExtension(_currentReservation.FileName);
            var filterExtension = "(*" + extension + ")|*" + extension;
            using (SaveFileDialog sfd = new SaveFileDialog() { FileName = _currentReservation.FileName, DefaultExt = extension, Filter = filterExtension })
            {
                byte[] file = (byte[])_currentReservation.File;

                if (sfd.ShowDialog() != DialogResult.Cancel)
                {
                    string strFileToSave = sfd.FileName;
                    FileStream objFileStream = new FileStream(strFileToSave, FileMode.Create, FileAccess.Write);
                    objFileStream.Write(file, 0, file.Length);
                    objFileStream.Close();
                }
            }
        }
    }
}
