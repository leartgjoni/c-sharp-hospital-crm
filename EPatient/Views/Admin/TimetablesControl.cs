using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using EPatient.Models;
using MetroFramework;
using MetroFramework.Controls;

namespace EPatient.Views.Admin
{
    public partial class TimetablesControl : MetroUserControl
    {
        private EPatientContext _context;
        private User _currentUser = null;

        public TimetablesControl()
        {
            InitializeComponent();
        }

        private void TimetablesControl_Load(object sender, EventArgs e)
        {
            _context = new EPatientContext();
            usersBindingSource.DataSource = _context.Users.Where(u => u.RoleId == Role.Doctor || u.RoleId == Role.Nurse).Include(u => u.Timetables).ToList();
            rolesBindingSource.DataSource = _context.Roles.ToList();
            pavilionsBindingSource.DataSource = _context.Pavilions.ToList();
            timetablePanel.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (usersBindingSource.Current is User selectedUser)
            {
                _currentUser = selectedUser;
                userLabel.Text = "Axhenda e " + _currentUser.Name;
                timetablePanel.Show();
                FillTimetable();
            }
        }

        public void FillTimetable()
        {
            for (int i = 1; i <= 7; i++)
            {
                Timetable timetable = _currentUser.Timetables.First(t => t.DayOfTheWeek == i);
                DateTimePicker startTimePicker = (DateTimePicker) this.Controls.Find("startTimePicker" + i, true)[0];
                DateTimePicker endTimePicker = (DateTimePicker)this.Controls.Find("endTimePicker" + i, true)[0];
                MetroCheckBox checkDayOff = (MetroCheckBox)this.Controls.Find("checkDayOff" + i, true)[0];


                startTimePicker.Value =  (timetable.StartTime == null) ? DateTime.Today : (DateTime) timetable.StartTime;
                endTimePicker.Value = (timetable.EndTime == null) ? DateTime.Today : (DateTime) timetable.EndTime;
                checkDayOff.Checked = timetable.DayOff;
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            MetroCheckBox cb = sender as MetroCheckBox;

            string cbName = cb.Name;
            int index = int.Parse(cbName.Substring(cbName.Length - 1));

            DateTimePicker startTimePicker = (DateTimePicker)this.Controls.Find("startTimePicker" + index, true)[0];
            DateTimePicker endTimePicker = (DateTimePicker)this.Controls.Find("endTimePicker" + index, true)[0];

            startTimePicker.Enabled = !cb.Checked;
            endTimePicker.Enabled = !cb.Checked;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateStartTime())
            {
                for (int i = 1; i <= 7; i++)
                {
                    Timetable timetable = _currentUser.Timetables.First(t => t.DayOfTheWeek == i);
                    DateTimePicker startTimePicker = (DateTimePicker)this.Controls.Find("startTimePicker" + i, true)[0];
                    DateTimePicker endTimePicker = (DateTimePicker)this.Controls.Find("endTimePicker" + i, true)[0];
                    MetroCheckBox checkDayOff = (MetroCheckBox)this.Controls.Find("checkDayOff" + i, true)[0];

                    timetable.DayOff = checkDayOff.Checked;

                    if (checkDayOff.Checked)
                    {
                        timetable.StartTime = null;
                        timetable.EndTime = null;
                    }
                    else
                    {
                        timetable.StartTime = startTimePicker.Value;
                        timetable.EndTime = endTimePicker.Value;
                    }

                    timetablePanel.Hide();
                }

                usersBindingSource.EndEdit();
                _context.SaveChanges();
                MetroMessageBox.Show(this, "Ruajtja u be me sukses", "Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Question);
            }
            else
            {
                MetroMessageBox.Show(this, "Koha e fillimit duhet te jete me e vogel se koha e mbarimit", "Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            timetablePanel.Hide();
        }

        public bool ValidateStartTime()
        {
            for (int i = 1; i <= 7; i++)
            {
                DateTimePicker startTimePicker = (DateTimePicker)this.Controls.Find("startTimePicker" + i, true)[0];
                DateTimePicker endTimePicker = (DateTimePicker)this.Controls.Find("endTimePicker" + i, true)[0];
                if (startTimePicker.Value > endTimePicker.Value)
                    return false;
                
            }

            return true;
        }
        

    }
}
