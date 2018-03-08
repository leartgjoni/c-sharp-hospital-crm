using System;
using System.Drawing;
using System.Windows.Forms;
using EPatient.Models.Auth;
using EPatient.Views.Admin;

namespace EPatient.Views
{
    public partial class AdminForm : MetroFramework.Forms.MetroForm
    {
        private Button[] _menuButtons;
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            labelName.Text = AuthUser.Model.Name + " " + AuthUser.Model.Surname;

            _menuButtons = new[]
            {
                usersMenuButton,
                workingHoursMenuButton,
                emergencyDoctorMenuButton,
                servicesMenuButton,
                pavilionsMenuButton,
                basicReportsMenuButton,
                advancedReportsMenuButton
            };
            
            
            UsersControl usersControl = new UsersControl {Dock = DockStyle.Fill};
            mainPanel.Controls.Add(usersControl);
            UnderlineMenuButton(usersMenuButton);
        }

        private void usersMenuButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            UsersControl usersControl = new UsersControl { Dock = DockStyle.Fill };
            mainPanel.Controls.Add(usersControl);
            UnderlineMenuButton(usersMenuButton);
        }

        private void WorkingHoursMenuButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            TimetablesControl timetablesControl = new TimetablesControl { Dock = DockStyle.Fill };
            mainPanel.Controls.Add(timetablesControl);
            UnderlineMenuButton(workingHoursMenuButton);
        }

        private void EmergencyDoctorMenuButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            EmergencyDoctorControl emergencyDoctorControl = new EmergencyDoctorControl { Dock = DockStyle.Fill };
            mainPanel.Controls.Add(emergencyDoctorControl);
            UnderlineMenuButton(emergencyDoctorMenuButton);
        }

        private void ServicesMenuButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            ServicesControl servicesControl = new ServicesControl { Dock = DockStyle.Fill };
            mainPanel.Controls.Add(servicesControl);
            UnderlineMenuButton(servicesMenuButton);
        }

        private void basicReportsMenuButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            BasicReportsControl basicReportsControl = new BasicReportsControl { Dock = DockStyle.Fill };
            mainPanel.Controls.Add(basicReportsControl);
            UnderlineMenuButton(basicReportsMenuButton);
        }

        private void advancedReportsMenuButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            AdvancedReportsControl advancedReportsControl = new AdvancedReportsControl { Dock = DockStyle.Fill };
            mainPanel.Controls.Add(advancedReportsControl);
            UnderlineMenuButton(advancedReportsMenuButton);
        }

        private void pavilionsMenuButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            PavilionsControl pavilionsControl = new PavilionsControl { Dock = DockStyle.Fill };
            mainPanel.Controls.Add(pavilionsControl);
            UnderlineMenuButton(pavilionsMenuButton);
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void UnderlineMenuButton(Button b)
        {
            foreach(Button currentButton in _menuButtons)
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            AuthUser.Model = null;
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

       
    }
}
