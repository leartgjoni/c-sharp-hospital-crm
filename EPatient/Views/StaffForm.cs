using System;
using System.Drawing;
using System.Windows.Forms;
using EPatient.Models.Auth;
using EPatient.Views.Staff;

namespace EPatient.Views
{
    public partial class StaffForm : MetroFramework.Forms.MetroForm
    {
        private Button[] _menuButtons;

        public StaffForm()
        {
            InitializeComponent();
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            _menuButtons = new[]
            {
                reservationsMenuButton,
                timetablesMenuButton
            };

            labelName.Text = AuthUser.Model.Name + " " + AuthUser.Model.Surname;
            
            ReservationControl reservationControl = new ReservationControl { Dock = DockStyle.Fill };
            mainPanel.Controls.Add(reservationControl);

            UnderlineMenuButton(reservationsMenuButton);
        }

        private void reservationMenuButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            ReservationControl reservationControl = new ReservationControl { Dock = DockStyle.Fill };
            mainPanel.Controls.Add(reservationControl);
            UnderlineMenuButton(reservationsMenuButton);
        }

        private void timetablesMenuButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            TimetableControl timetableControl = new TimetableControl { Dock = DockStyle.Fill };
            mainPanel.Controls.Add(timetableControl);
            UnderlineMenuButton(timetablesMenuButton);
        }


        private void StaffForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            AuthUser.Model = null;
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void UnderlineMenuButton(Button b)
        {
            foreach (Button currentButton in _menuButtons)
            {
                if (currentButton == b)
                {
                    currentButton.Font = new Font(currentButton.Font, FontStyle.Underline);
                }
                else
                {
                    currentButton.Font = new Font(currentButton.Font, FontStyle.Regular);
                }
            }
        }
    }
}
