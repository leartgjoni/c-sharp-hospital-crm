using System;
using System.Linq;
using System.Windows.Forms;
using EPatient.Models;
using EPatient.Models.Auth;

namespace EPatient.Views.Staff
{
    public partial class TimetableControl : MetroFramework.Controls.MetroUserControl
    {
        private EPatientContext _context;

        public TimetableControl()
        {
            InitializeComponent();
            _context = new EPatientContext();
        }

        private void TimetableControl_Load(object sender, EventArgs e)
        {
            if (AuthUser.Model.RoleId == Role.Doctor)
            {
                var query = _context.EmergencyDoctors.Where(d => d.UserId == AuthUser.Model.Id).ToList();
                emergencyDoctorBindingSource.DataSource = query;
            }
            else if (AuthUser.Model.RoleId == Role.Nurse)
            {
                label1.Hide();
                metroGridTimetable.Hide();
            }
            FillTimetable();
        }

        public void FillTimetable()
        {

            for (int i = 1; i <= 7; i++)
            {
                Timetable timetable = AuthUser.Model.Timetables.First(t => t.DayOfTheWeek == i);
                Label time = (Label)this.Controls.Find("time" + i, true)[0];
                time.Text = (timetable.DayOff == true)
                    ? "Pushim"
                    : timetable.StartTime.Value.TimeOfDay + " - " + timetable.EndTime.Value.TimeOfDay;
            }
        }
    }
}
