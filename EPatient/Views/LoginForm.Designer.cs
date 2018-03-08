using System.Windows.Forms;

namespace EPatient
{
    partial class LoginForm
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
            this.textUsername = new MetroFramework.Controls.MetroTextBox();
            this.textPassword = new MetroFramework.Controls.MetroTextBox();
            this.checkBoxRememberMe = new MetroFramework.Controls.MetroCheckBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelUsername = new MetroFramework.Controls.MetroLabel();
            this.labelPassword = new MetroFramework.Controls.MetroLabel();
            this.loginErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.loginErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // textUsername
            // 
            // 
            // 
            // 
            this.textUsername.CustomButton.Image = null;
            this.textUsername.CustomButton.Location = new System.Drawing.Point(227, 1);
            this.textUsername.CustomButton.Name = "";
            this.textUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textUsername.CustomButton.TabIndex = 1;
            this.textUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textUsername.CustomButton.UseSelectable = true;
            this.textUsername.CustomButton.Visible = false;
            this.textUsername.Lines = new string[0];
            this.textUsername.Location = new System.Drawing.Point(266, 76);
            this.textUsername.MaxLength = 255;
            this.textUsername.Name = "textUsername";
            this.textUsername.PasswordChar = '\0';
            this.textUsername.PromptText = "Vendos username";
            this.textUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textUsername.SelectedText = "";
            this.textUsername.SelectionLength = 0;
            this.textUsername.SelectionStart = 0;
            this.textUsername.ShortcutsEnabled = true;
            this.textUsername.Size = new System.Drawing.Size(249, 23);
            this.textUsername.TabIndex = 0;
            this.textUsername.UseSelectable = true;
            this.textUsername.WaterMark = "Vendos username";
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
            this.textPassword.CustomButton.Location = new System.Drawing.Point(227, 1);
            this.textPassword.CustomButton.Name = "";
            this.textPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textPassword.CustomButton.TabIndex = 1;
            this.textPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textPassword.CustomButton.UseSelectable = true;
            this.textPassword.CustomButton.Visible = false;
            this.textPassword.Lines = new string[0];
            this.textPassword.Location = new System.Drawing.Point(266, 114);
            this.textPassword.MaxLength = 255;
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.PromptText = "Vendos password";
            this.textPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textPassword.SelectedText = "";
            this.textPassword.SelectionLength = 0;
            this.textPassword.SelectionStart = 0;
            this.textPassword.ShortcutsEnabled = true;
            this.textPassword.Size = new System.Drawing.Size(249, 23);
            this.textPassword.TabIndex = 1;
            this.textPassword.UseSelectable = true;
            this.textPassword.WaterMark = "Vendos password";
            this.textPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(266, 158);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(104, 15);
            this.checkBoxRememberMe.TabIndex = 2;
            this.checkBoxRememberMe.Text = "Me mbaj mend";
            this.checkBoxRememberMe.UseSelectable = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.White;
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.buttonLogin.Location = new System.Drawing.Point(425, 208);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(90, 30);
            this.buttonLogin.TabIndex = 21;
            this.buttonLogin.Text = "Hyr";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(88, 80);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(71, 19);
            this.labelUsername.TabIndex = 4;
            this.labelUsername.Text = "Username:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(88, 118);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(66, 19);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Password:";
            // 
            // loginErrorProvider
            // 
            this.loginErrorProvider.ContainerControl = this;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 261);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.checkBoxRememberMe);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUsername);
            this.Name = "LoginForm";
            this.Resizable = false;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox textUsername;
        private MetroFramework.Controls.MetroTextBox textPassword;
        private MetroFramework.Controls.MetroCheckBox checkBoxRememberMe;
        private Button buttonLogin;
        private MetroFramework.Controls.MetroLabel labelUsername;
        private MetroFramework.Controls.MetroLabel labelPassword;
        private System.Windows.Forms.ErrorProvider loginErrorProvider;
    }
}

