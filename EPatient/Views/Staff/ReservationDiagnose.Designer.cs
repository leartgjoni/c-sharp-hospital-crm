namespace EPatient.Views.Staff
{
    partial class ReservationDiagnose
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
            this.textRecipe = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.textBoxAllergies = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textRecipe
            // 
            // 
            // 
            // 
            this.textRecipe.CustomButton.Image = null;
            this.textRecipe.CustomButton.Location = new System.Drawing.Point(74, 1);
            this.textRecipe.CustomButton.Name = "";
            this.textRecipe.CustomButton.Size = new System.Drawing.Size(169, 169);
            this.textRecipe.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textRecipe.CustomButton.TabIndex = 1;
            this.textRecipe.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textRecipe.CustomButton.UseSelectable = true;
            this.textRecipe.CustomButton.Visible = false;
            this.textRecipe.Lines = new string[0];
            this.textRecipe.Location = new System.Drawing.Point(91, 222);
            this.textRecipe.MaxLength = 32767;
            this.textRecipe.Multiline = true;
            this.textRecipe.Name = "textRecipe";
            this.textRecipe.PasswordChar = '\0';
            this.textRecipe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textRecipe.SelectedText = "";
            this.textRecipe.SelectionLength = 0;
            this.textRecipe.SelectionStart = 0;
            this.textRecipe.ShortcutsEnabled = true;
            this.textRecipe.Size = new System.Drawing.Size(252, 171);
            this.textRecipe.TabIndex = 0;
            this.textRecipe.UseSelectable = true;
            this.textRecipe.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textRecipe.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(34, 222);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Receta:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(12, 414);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(72, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Dokument:";
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.White;
            this.btnUpload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnUpload.Location = new System.Drawing.Point(91, 414);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(90, 30);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "Ngarko";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.White;
            this.btnDownload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnDownload.Location = new System.Drawing.Point(187, 414);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(156, 30);
            this.btnDownload.TabIndex = 4;
            this.btnDownload.Text = "Shkarko Filen e Vjeter";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.Color.Red;
            this.metroLabel3.Location = new System.Drawing.Point(23, 95);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(61, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Alergjite:";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // textBoxAllergies
            // 
            // 
            // 
            // 
            this.textBoxAllergies.CustomButton.Image = null;
            this.textBoxAllergies.CustomButton.Location = new System.Drawing.Point(142, 2);
            this.textBoxAllergies.CustomButton.Name = "";
            this.textBoxAllergies.CustomButton.Size = new System.Drawing.Size(99, 99);
            this.textBoxAllergies.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxAllergies.CustomButton.TabIndex = 1;
            this.textBoxAllergies.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxAllergies.CustomButton.UseSelectable = true;
            this.textBoxAllergies.CustomButton.Visible = false;
            this.textBoxAllergies.Lines = new string[0];
            this.textBoxAllergies.Location = new System.Drawing.Point(91, 95);
            this.textBoxAllergies.MaxLength = 32767;
            this.textBoxAllergies.Multiline = true;
            this.textBoxAllergies.Name = "textBoxAllergies";
            this.textBoxAllergies.PasswordChar = '\0';
            this.textBoxAllergies.ReadOnly = true;
            this.textBoxAllergies.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAllergies.SelectedText = "";
            this.textBoxAllergies.SelectionLength = 0;
            this.textBoxAllergies.SelectionStart = 0;
            this.textBoxAllergies.ShortcutsEnabled = true;
            this.textBoxAllergies.Size = new System.Drawing.Size(252, 104);
            this.textBoxAllergies.TabIndex = 5;
            this.textBoxAllergies.UseSelectable = true;
            this.textBoxAllergies.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxAllergies.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnSave.Location = new System.Drawing.Point(328, 467);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Ruaj";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ReservationDiagnose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 520);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.textBoxAllergies);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.textRecipe);
            this.Name = "ReservationDiagnose";
            this.Text = "Diagnoza";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.ReservationDiagnose_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox textRecipe;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnDownload;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox textBoxAllergies;
        private System.Windows.Forms.Button btnSave;
    }
}