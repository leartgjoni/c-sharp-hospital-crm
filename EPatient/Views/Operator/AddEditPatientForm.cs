using System;
using System.ComponentModel;
using System.Windows.Forms;
using EPatient.Models;

namespace EPatient.Views.Operator
{
    public partial class AddEditPatientForm : MetroFramework.Forms.MetroForm
    {
        public Patient PatientInfo => patientBindingSource.Current as Patient;

        public AddEditPatientForm(Patient obj)
        {
            InitializeComponent();
            patientBindingSource.DataSource = obj;
        }

        private void AddEditPatientForm_Load(object sender, EventArgs e)
        {
            if (checkBoxGender.CheckState == CheckState.Checked)
                checkBoxGender.Text = "Mashkull";
            else if (checkBoxGender.CheckState == CheckState.Unchecked)
                checkBoxGender.Text = "Femer";
            else
                checkBoxGender.Text = "??";
        }

        private void checkBoxGender_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxGender.CheckState == CheckState.Checked)
                checkBoxGender.Text = "Mashkull";
            else if (checkBoxGender.CheckState == CheckState.Unchecked)
                checkBoxGender.Text = "Femer";
            else
                checkBoxGender.Text = "??";
        }

        private void textName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textName.Text) || textName.Text.Length > 255)
            {
                e.Cancel = true;
                textName.Focus();
                errorProvider.SetError(textName, "Ju lutemi selektoni emrin e pacientit (Max 255 karaktere)");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textName, null);
            }
        }

        private void textSurname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textSurname.Text) || textSurname.Text.Length > 255)
            {
                e.Cancel = true;
                textSurname.Focus();
                errorProvider.SetError(textSurname, "Ju lutemi vendosni mbiemrin e pacientit (Max 255 karaktere)");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textSurname, null);
            }
        }

        private void textEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textEmail.Text) || textEmail.Text.Length > 50)
            {
                e.Cancel = true;
                textEmail.Focus();
                errorProvider.SetError(textEmail, "Ju lutemi vendosni email-in e pacientit (Max 50 karaktere)");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textEmail, null);
            }
        }

        private void dateBirthday_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(dateBirthday.Text))
            {
                e.Cancel = true;
                dateBirthday.Focus();
                errorProvider.SetError(dateBirthday, "Ju lutemi vendosni ditelindjen e pacientit");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(dateBirthday, null);
            }
        }

        private void textPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textPhone.Text) || textPhone.Text.Length > 255)
            {
                e.Cancel = true;
                textPhone.Focus();
                errorProvider.SetError(textPhone, "Ju lutemi vendosni nr e telefonit te pacientit (Max 255 karaktere)");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textPhone, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                patientBindingSource.EndEdit();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
