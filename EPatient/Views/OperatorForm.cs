using System;
using System.Drawing;
using System.Windows.Forms;
using EPatient.Models.Auth;
using EPatient.Views.Operator;

namespace EPatient.Views
{
    public partial class OperatorForm : MetroFramework.Forms.MetroForm
    {
        private Button[] _menuButtons;
        public OperatorForm()
        {
            InitializeComponent();
        }

        private void OperatorForm_Load(object sender, EventArgs e)
        {
            labelName.Text = AuthUser.Model.Name + " " + AuthUser.Model.Surname;

            _menuButtons = new[]
            {
                patientsMenuButton,
                reservationsMenuButton
            };

            PatientsControl patientsControl = new PatientsControl { Dock = DockStyle.Fill };
            mainPanel.Controls.Add(patientsControl);

            UnderlineMenuButton(patientsMenuButton);
        }

        private void patientsMenuButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            PatientsControl patientsControl = new PatientsControl { Dock = DockStyle.Fill };
            mainPanel.Controls.Add(patientsControl);
            UnderlineMenuButton(patientsMenuButton);
        }

        private void reservationsMenuButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            ReservationsControl reservationsControl = new ReservationsControl { Dock = DockStyle.Fill };
            mainPanel.Controls.Add(reservationsControl);
            UnderlineMenuButton(reservationsMenuButton);
        }

        private void timetablesMenuButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            TimetablesControl timetablesControl = new TimetablesControl { Dock = DockStyle.Fill };
            mainPanel.Controls.Add(timetablesControl);
            UnderlineMenuButton(timetablesMenuButton);
        }

        private void OperatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
