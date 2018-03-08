namespace EPatient.Views.Admin
{
    partial class AddEditUserForm
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
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.textName = new MetroFramework.Controls.MetroTextBox();
            this.bindingSourceUser = new System.Windows.Forms.BindingSource(this.components);
            this.textSurname = new MetroFramework.Controls.MetroTextBox();
            this.textUsername = new MetroFramework.Controls.MetroTextBox();
            this.textPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cboRole = new MetroFramework.Controls.MetroComboBox();
            this.cboPavilion = new MetroFramework.Controls.MetroComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.chkBoxEditPassword = new MetroFramework.Controls.MetroCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUser)).BeginInit();
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
            this.metroLabel3.Size = new System.Drawing.Size(71, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Username:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(48, 213);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(66, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Password:";
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
            this.textName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceUser, "Name", true));
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
            // bindingSourceUser
            // 
            this.bindingSourceUser.DataSource = typeof(EPatient.Models.User);
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
            this.textSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceUser, "Surname", true));
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
            // textUsername
            // 
            // 
            // 
            // 
            this.textUsername.CustomButton.Image = null;
            this.textUsername.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.textUsername.CustomButton.Name = "";
            this.textUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textUsername.CustomButton.TabIndex = 1;
            this.textUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textUsername.CustomButton.UseSelectable = true;
            this.textUsername.CustomButton.Visible = false;
            this.textUsername.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceUser, "Username", true));
            this.textUsername.Lines = new string[0];
            this.textUsername.Location = new System.Drawing.Point(156, 166);
            this.textUsername.MaxLength = 255;
            this.textUsername.Name = "textUsername";
            this.textUsername.PasswordChar = '\0';
            this.textUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textUsername.SelectedText = "";
            this.textUsername.SelectionLength = 0;
            this.textUsername.SelectionStart = 0;
            this.textUsername.ShortcutsEnabled = true;
            this.textUsername.Size = new System.Drawing.Size(153, 23);
            this.textUsername.TabIndex = 6;
            this.textUsername.UseSelectable = true;
            this.textUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textUsername.Validating += new System.ComponentModel.CancelEventHandler(this.textUsername_Validating);
            // 
            // textPassword
            // 
            // 
            // 
            // 
            this.textPassword.CustomButton.Image = null;
            this.textPassword.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.textPassword.CustomButton.Name = "";
            this.textPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textPassword.CustomButton.TabIndex = 1;
            this.textPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textPassword.CustomButton.UseSelectable = true;
            this.textPassword.CustomButton.Visible = false;
            this.textPassword.Enabled = false;
            this.textPassword.Lines = new string[0];
            this.textPassword.Location = new System.Drawing.Point(156, 209);
            this.textPassword.MaxLength = 255;
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textPassword.SelectedText = "";
            this.textPassword.SelectionLength = 0;
            this.textPassword.SelectionStart = 0;
            this.textPassword.ShortcutsEnabled = true;
            this.textPassword.Size = new System.Drawing.Size(153, 23);
            this.textPassword.TabIndex = 7;
            this.textPassword.UseSelectable = true;
            this.textPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(48, 255);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(34, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Roli:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(48, 297);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(53, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Pavioni:";
            // 
            // cboRole
            // 
            this.cboRole.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceUser, "RoleId", true));
            this.cboRole.FormattingEnabled = true;
            this.cboRole.ItemHeight = 23;
            this.cboRole.Location = new System.Drawing.Point(156, 255);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(121, 29);
            this.cboRole.TabIndex = 10;
            this.cboRole.UseSelectable = true;
            this.cboRole.Validating += new System.ComponentModel.CancelEventHandler(this.cboRole_Validating);
            // 
            // cboPavilion
            // 
            this.cboPavilion.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceUser, "PavilionId", true));
            this.cboPavilion.FormattingEnabled = true;
            this.cboPavilion.ItemHeight = 23;
            this.cboPavilion.Location = new System.Drawing.Point(156, 297);
            this.cboPavilion.Name = "cboPavilion";
            this.cboPavilion.Size = new System.Drawing.Size(121, 29);
            this.cboPavilion.TabIndex = 11;
            this.cboPavilion.UseSelectable = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnSave.Location = new System.Drawing.Point(175, 358);
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
            // chkBoxEditPassword
            // 
            this.chkBoxEditPassword.AutoSize = true;
            this.chkBoxEditPassword.Location = new System.Drawing.Point(316, 213);
            this.chkBoxEditPassword.Name = "chkBoxEditPassword";
            this.chkBoxEditPassword.Size = new System.Drawing.Size(123, 15);
            this.chkBoxEditPassword.TabIndex = 13;
            this.chkBoxEditPassword.Text = "edito password-in?";
            this.chkBoxEditPassword.UseSelectable = true;
            this.chkBoxEditPassword.CheckedChanged += new System.EventHandler(this.chkBoxEditPassword_CheckedChanged);
            // 
            // AddEditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 427);
            this.Controls.Add(this.chkBoxEditPassword);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboPavilion);
            this.Controls.Add(this.cboRole);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEditUserForm";
            this.Text = "Perdoruesi";
            this.Load += new System.EventHandler(this.AddEditUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSourceUser;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox textName;
        private MetroFramework.Controls.MetroTextBox textSurname;
        private MetroFramework.Controls.MetroTextBox textUsername;
        private MetroFramework.Controls.MetroTextBox textPassword;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cboRole;
        private MetroFramework.Controls.MetroComboBox cboPavilion;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private MetroFramework.Controls.MetroCheckBox chkBoxEditPassword;
    }
}