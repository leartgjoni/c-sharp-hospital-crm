using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using EPatient.Models;

namespace EPatient.Views.Admin
{
    public partial class PavilionsControl : MetroFramework.Controls.MetroUserControl
    {
        private EPatientContext _context;
        private Pavilion _currentPavilion = null;

        public PavilionsControl()
        {
            InitializeComponent();
        }

        private void PavilionsControl_Load(object sender, EventArgs e)
        {
            _context = new EPatientContext();
            pavilionsBindingSource.DataSource = _context.Pavilions.ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Jeni te sigurt per fshirjen e ketij rekordi?", "Message",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    if (pavilionsBindingSource.Current is Pavilion selectedPavilion)
                    {
                        pavilionsBindingSource.Remove(selectedPavilion);
                        _context.Pavilions.Remove(selectedPavilion);
                        pavilionsBindingSource.EndEdit();
                        _context.SaveChanges();
                    }
                }
            }
            
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    if (_currentPavilion == null)
                    {
                        _currentPavilion = new Pavilion { Name = textName.Text };
                        pavilionsBindingSource.Add(_currentPavilion);
                        _context.Pavilions.Add(_currentPavilion);
                    }
                    else
                    {
                        _currentPavilion.Name = textName.Text;
                        pavilionsBindingSource.EndEdit();
                    }


                    _context.SaveChanges();
                    pavilionsBindingSource.ResetBindings(true);
                    _currentPavilion = null;
                    textName.Text = "";

                    MetroFramework.MetroMessageBox.Show(this, "Success", "Message", MessageBoxButtons.OK,
                        MessageBoxIcon.Question);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (pavilionsBindingSource.Current is Pavilion selectedPavilion)
            {
                _currentPavilion = selectedPavilion;
                textName.Text = _currentPavilion.Name;
            }
        }

        private void textName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textName.Text) || textName.Text.Length > 255)
            {
                e.Cancel = true;
                textName.Focus();
                errorProvider.SetError(textName, "Ju lutemi vendosni emrin e pavionit (Max 255 karaktere)");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textName, null);
            }
        }
    }
}

