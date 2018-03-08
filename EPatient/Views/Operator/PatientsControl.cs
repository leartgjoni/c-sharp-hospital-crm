using System;
using System.Linq;
using System.Windows.Forms;
using EPatient.Models;
using EPatient.Views.Staff;

namespace EPatient.Views.Operator
{
    public partial class PatientsControl : MetroFramework.Controls.MetroUserControl
    {
        private EPatientContext _context;
        public PatientsControl()
        {
            InitializeComponent();
        }

        private void PatientsControl_Load(object sender, EventArgs e)
        {
            _context = new EPatientContext();
            patientBindingSource.DataSource = _context.Patients.ToList();
        }

        private void gridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                if (e.Value is bool)
                {
                    bool value = (bool)e.Value;
                    e.Value = (value) ? "Mashkull" : "Femer";
                    e.FormattingApplied = true;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (AddEditPatientForm frm = new AddEditPatientForm(new Patient()))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        patientBindingSource.Add(frm.PatientInfo);
                        _context.Patients.Add(frm.PatientInfo);
                        _context.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Success", "Message", MessageBoxButtons.OK,
                            MessageBoxIcon.Question);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Patient obj = patientBindingSource.Current as Patient;
            if (obj != null)
            {
                using (AddEditPatientForm frm = new AddEditPatientForm(obj))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            patientBindingSource.EndEdit();
                            _context.SaveChanges();
                            MetroFramework.MetroMessageBox.Show(this, "Success", "Message", MessageBoxButtons.OK,
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Jeni te sigurt per fshirjen e ketij rekordi?", "Message",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    if (patientBindingSource.Current is Patient selectedPatient)
                    {
                        patientBindingSource.Remove(selectedPatient);
                        _context.Patients.Remove(selectedPatient);
                        patientBindingSource.EndEdit();
                        _context.SaveChanges();
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            patientBindingSource.DataSource = _context.Patients.Where(p => p.Name.Contains(searchTextBox.Text) || p.Surname.Contains(searchTextBox.Text) || p.Email.Contains(searchTextBox.Text)).ToList();
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            Patient obj = patientBindingSource.Current as Patient;
            if (obj != null)
            {
                using (FolderForm frm = new FolderForm(obj.Id))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("Cancel", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
