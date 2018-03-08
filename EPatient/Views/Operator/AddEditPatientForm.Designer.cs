namespace EPatient.Views.Operator
{
    partial class AddEditPatientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.textName = new MetroFramework.Controls.MetroTextBox();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textSurname = new MetroFramework.Controls.MetroTextBox();
            this.textEmail = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.dateBirthday = new System.Windows.Forms.DateTimePicker();
            this.textPhone = new MetroFramework.Controls.MetroTextBox();
            this.textAllergies = new MetroFramework.Controls.MetroTextBox();
            this.checkBoxGender = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mbiemer:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(48, 170);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(44, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Email:";
            // 
            // textName
            // 
            // 
            // 
            // 
            this.textName.CustomButton.Image = null;
            this.textName.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.textName.CustomButton.Name = "";
            this.textName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textName.CustomButton.TabIndex = 1;
            this.textName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textName.CustomButton.UseSelectable = true;
            this.textName.CustomButton.Visible = false;
            this.textName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Name", true));
            this.textName.Lines = new string[0];
            this.textName.Location = new System.Drawing.Point(156, 80);
            this.textName.MaxLength = 255;
            this.textName.Name = "textName";
            this.textName.PasswordChar = '\0';
            this.textName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textName.SelectedText = "";
            this.textName.SelectionLength = 0;
            this.textName.SelectionStart = 0;
            this.textName.ShortcutsEnabled = true;
            this.textName.Size = new System.Drawing.Size(153, 23);
            this.textName.TabIndex = 4;
            this.textName.UseSelectable = true;
            this.textName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textName.Validating += new System.ComponentModel.CancelEventHandler(this.textName_Validating);
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(EPatient.Models.Patient);
            // 
            // textSurname
            // 
            // 
            // 
            // 
            this.textSurname.CustomButton.Image = null;
            this.textSurname.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.textSurname.CustomButton.Name = "";
            this.textSurname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textSurname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textSurname.CustomButton.TabIndex = 1;
            this.textSurname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textSurname.CustomButton.UseSelectable = true;
            this.textSurname.CustomButton.Visible = false;
            this.textSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Surname", true));
            this.textSurname.Lines = new string[0];
            this.textSurname.Location = new System.Drawing.Point(156, 124);
            this.textSurname.MaxLength = 255;
            this.textSurname.Name = "textSurname";
            this.textSurname.PasswordChar = '\0';
            this.textSurname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textSurname.SelectedText = "";
            this.textSurname.SelectionLength = 0;
            this.textSurname.SelectionStart = 0;
            this.textSurname.ShortcutsEnabled = true;
            this.textSurname.Size = new System.Drawing.Size(153, 23);
            this.textSurname.TabIndex = 5;
            this.textSurname.UseSelectable = true;
            this.textSurname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textSurname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textSurname.Validating += new System.ComponentModel.CancelEventHandler(this.textSurname_Validating);
            // 
            // textEmail
            // 
            // 
            // 
            // 
            this.textEmail.CustomButton.Image = null;
            this.textEmail.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.textEmail.CustomButton.Name = "";
            this.textEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textEmail.CustomButton.TabIndex = 1;
            this.textEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textEmail.CustomButton.UseSelectable = true;
            this.textEmail.CustomButton.Visible = false;
            this.textEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Email", true));
            this.textEmail.Lines = new string[0];
            this.textEmail.Location = new System.Drawing.Point(156, 166);
            this.textEmail.MaxLength = 255;
            this.textEmail.Name = "textEmail";
            this.textEmail.PasswordChar = '\0';
            this.textEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textEmail.SelectedText = "";
            this.textEmail.SelectionLength = 0;
            this.textEmail.SelectionStart = 0;
            this.textEmail.ShortcutsEnabled = true;
            this.textEmail.Size = new System.Drawing.Size(153, 23);
            this.textEmail.TabIndex = 6;
            this.textEmail.UseSelectable = true;
            this.textEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textEmail_Validating);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnSave.Location = new System.Drawing.Point(174, 442);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 32);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Ruaj";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(52, 208);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Ditelindja:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(52, 247);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(44, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Gjinia:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(52, 285);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(27, 19);
            this.metroLabel4.TabIndex = 15;
            this.metroLabel4.Text = "Tel:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(52, 317);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(61, 19);
            this.metroLabel5.TabIndex = 16;
            this.metroLabel5.Text = "Alergjite:";
            // 
            // dateBirthday
            // 
            this.dateBirthday.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientBindingSource, "Birthday", true));
            this.dateBirthday.Location = new System.Drawing.Point(156, 208);
            this.dateBirthday.Name = "dateBirthday";
            this.dateBirthday.Size = new System.Drawing.Size(185, 20);
            this.dateBirthday.TabIndex = 17;
            this.dateBirthday.Validating += new System.ComponentModel.CancelEventHandler(this.dateBirthday_Validating);
            // 
            // textPhone
            // 
            // 
            // 
            // 
            this.textPhone.CustomButton.Image = null;
            this.textPhone.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.textPhone.CustomButton.Name = "";
            this.textPhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textPhone.CustomButton.TabIndex = 1;
            this.textPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textPhone.CustomButton.UseSelectable = true;
            this.textPhone.CustomButton.Visible = false;
            this.textPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Phone", true));
            this.textPhone.Lines = new string[0];
            this.textPhone.Location = new System.Drawing.Point(156, 281);
            this.textPhone.MaxLength = 50;
            this.textPhone.Name = "textPhone";
            this.textPhone.PasswordChar = '\0';
            this.textPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textPhone.SelectedText = "";
            this.textPhone.SelectionLength = 0;
            this.textPhone.SelectionStart = 0;
            this.textPhone.ShortcutsEnabled = true;
            this.textPhone.Size = new System.Drawing.Size(153, 23);
            this.textPhone.TabIndex = 18;
            this.textPhone.UseSelectable = true;
            this.textPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textPhone.Validating += new System.ComponentModel.CancelEventHandler(this.textPhone_Validating);
            // 
            // textAllergies
            // 
            // 
            // 
            // 
            this.textAllergies.CustomButton.Image = null;
            this.textAllergies.CustomButton.Location = new System.Drawing.Point(69, 1);
            this.textAllergies.CustomButton.Name = "";
            this.textAllergies.CustomButton.Size = new System.Drawing.Size(83, 83);
            this.textAllergies.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textAllergies.CustomButton.TabIndex = 1;
            this.textAllergies.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textAllergies.CustomButton.UseSelectable = true;
            this.textAllergies.CustomButton.Visible = false;
            this.textAllergies.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Allergies", true));
            this.textAllergies.Lines = new string[0];
            this.textAllergies.Location = new System.Drawing.Point(156, 317);
            this.textAllergies.MaxLength = 32767;
            this.textAllergies.Multiline = true;
            this.textAllergies.Name = "textAllergies";
            this.textAllergies.PasswordChar = '\0';
            this.textAllergies.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textAllergies.SelectedText = "";
            this.textAllergies.SelectionLength = 0;
            this.textAllergies.SelectionStart = 0;
            this.textAllergies.ShortcutsEnabled = true;
            this.textAllergies.Size = new System.Drawing.Size(153, 85);
            this.textAllergies.TabIndex = 19;
            this.textAllergies.UseSelectable = true;
            this.textAllergies.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textAllergies.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // checkBoxGender
            // 
            this.checkBoxGender.AutoSize = true;
            this.checkBoxGender.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.patientBindingSource, "Gender", true));
            this.checkBoxGender.Location = new System.Drawing.Point(156, 247);
            this.checkBoxGender.Name = "checkBoxGender";
            this.checkBoxGender.Size = new System.Drawing.Size(38, 17);
            this.checkBoxGender.TabIndex = 20;
            this.checkBoxGender.Text = "??";
            this.checkBoxGender.UseVisualStyleBackColor = true;
            this.checkBoxGender.CheckStateChanged += new System.EventHandler(this.checkBoxGender_CheckStateChanged);
            // 
            // AddEditPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 524);
            this.Controls.Add(this.checkBoxGender);
            this.Controls.Add(this.textAllergies);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.dateBirthday);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEditPatientForm";
            this.Text = "Perdorues";
            this.Load += new System.EventHandler(this.AddEditPatientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox textName;
        private MetroFramework.Controls.MetroTextBox textSurname;
        private MetroFramework.Controls.MetroTextBox textEmail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private MetroFramework.Controls.MetroTextBox textAllergies;
        private MetroFramework.Controls.MetroTextBox textPhone;
        private System.Windows.Forms.DateTimePicker dateBirthday;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.CheckBox checkBoxGender;
        private System.Windows.Forms.BindingSource patientBindingSource;
    }
}