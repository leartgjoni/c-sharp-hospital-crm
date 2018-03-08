using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using EPatient.Models;
using MetroFramework;

namespace EPatient.Views.Operator
{
    public partial class AddQuickReservation : MetroFramework.Forms.MetroForm
    {
        private EPatientContext _context;

        public AddQuickReservation()
        {
            _context = new EPatientContext();
            InitializeComponent();
        }

        private void AddQuickReservation_Load(object sender, EventArgs e)
        {
            listBoxPatient.DisplayMember = "NameSurname";
            listBoxPatient.ValueMember = "Id";
            listBoxPatient.DataSource = _context.Patients.Select(t => new
            {
                Id = t.Id,
                NameSurname = t.Name + " " + t.Surname
            }).ToList();

            comboBoxPavilion.DisplayMember = "Name";
            comboBoxPavilion.ValueMember = "Id";
            comboBoxPavilion.DataSource = _context.Pavilions.ToList();
        }

        private void comboBoxPavilion_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pavilionId = (int)comboBoxPavilion.SelectedValue;
            var services = _context.Services.Where(s => s.PavilionId == pavilionId).ToList();
            listBoxService.DisplayMember = "Name";
            listBoxService.ValueMember = "Id";
            listBoxService.DataSource = services;
        }

        private void textSearchPatient_TextChanged(object sender, EventArgs e)
        {
            var search = textSearchPatient.Text;
            listBoxPatient.DataSource = _context.Patients
                .Where(t => t.Name.Contains(search) || t.Surname.Contains(search))
                .Select(t => new
                {
                    Id = t.Id,
                    NameSurname = t.Name + " " + t.Surname
                }).ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var selectedServiceId = (listBoxService.SelectedValue != null) ? (int)listBoxService.SelectedValue : 0;
            var selectedPatientId = (listBoxPatient.SelectedValue != null) ? (int)listBoxPatient.SelectedValue : 0;


            if (selectedServiceId == 0 || selectedPatientId == 0)
            {
                MetroMessageBox.Show(this, "Ju duhet te selektoni pacientin dhe sherbimin", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;

            }

            var service = _context.Services.SingleOrDefault(s => s.Id == selectedServiceId);


            DateTime dateTime = DateTime.Now;
            DateTime endTime = dateTime.AddMinutes(service.Duration);

            var doctorId = (from em in _context.EmergencyDoctors
                join u in _context.Users on em.UserId equals u.Id
                join p in _context.Pavilions on u.PavilionId equals p.Id
                where DbFunctions.TruncateTime(em.Date) == DbFunctions.TruncateTime(dateTime)
                where service.PavilionId == p.Id
                select em.UserId).FirstOrDefault();

            if (doctorId == 0)
            {
                MetroMessageBox.Show(this, "Nuk ka mjek roje per diten e sotme! Kontaktoni me administratorin!", "error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Reservation reservation = new Reservation();
            reservation.StartTime = dateTime;
            reservation.EndTime = endTime;
            reservation.UserId = doctorId;
            reservation.PatientId = selectedPatientId;
            reservation.ServiceId = service.Id;
            _context.Reservations.Add(reservation);
            _context.SaveChanges();

            DialogResult = DialogResult.OK;

        }
    }
}
