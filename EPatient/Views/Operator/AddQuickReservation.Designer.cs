namespace EPatient.Views.Operator
{
    partial class AddQuickReservation
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
            this.listBoxPatient = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textSearchPatient = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxPavilion = new MetroFramework.Controls.MetroComboBox();
            this.listBoxService = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxPatient
            // 
            this.listBoxPatient.FormattingEnabled = true;
            this.listBoxPatient.Location = new System.Drawing.Point(6, 59);
            this.listBoxPatient.Name = "listBoxPatient";
            this.listBoxPatient.Size = new System.Drawing.Size(254, 147);
            this.listBoxPatient.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textSearchPatient);
            this.groupBox1.Controls.Add(this.listBoxPatient);
            this.groupBox1.Location = new System.Drawing.Point(24, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 219);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pacienti";
            // 
            // textSearchPatient
            // 
            // 
            // 
            // 
            this.textSearchPatient.CustomButton.Image = null;
            this.textSearchPatient.CustomButton.Location = new System.Drawing.Point(232, 1);
            this.textSearchPatient.CustomButton.Name = "";
            this.textSearchPatient.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textSearchPatient.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textSearchPatient.CustomButton.TabIndex = 1;
            this.textSearchPatient.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textSearchPatient.CustomButton.UseSelectable = true;
            this.textSearchPatient.CustomButton.Visible = false;
            this.textSearchPatient.Lines = new string[0];
            this.textSearchPatient.Location = new System.Drawing.Point(6, 20);
            this.textSearchPatient.MaxLength = 32767;
            this.textSearchPatient.Name = "textSearchPatient";
            this.textSearchPatient.PasswordChar = '\0';
            this.textSearchPatient.PromptText = "Kerko Pacient";
            this.textSearchPatient.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textSearchPatient.SelectedText = "";
            this.textSearchPatient.SelectionLength = 0;
            this.textSearchPatient.SelectionStart = 0;
            this.textSearchPatient.ShortcutsEnabled = true;
            this.textSearchPatient.Size = new System.Drawing.Size(254, 23);
            this.textSearchPatient.TabIndex = 1;
            this.textSearchPatient.UseSelectable = true;
            this.textSearchPatient.WaterMark = "Kerko Pacient";
            this.textSearchPatient.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textSearchPatient.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textSearchPatient.TextChanged += new System.EventHandler(this.textSearchPatient_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxPavilion);
            this.groupBox2.Controls.Add(this.listBoxService);
            this.groupBox2.Location = new System.Drawing.Point(316, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 219);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sherbime";
            // 
            // comboBoxPavilion
            // 
            this.comboBoxPavilion.FormattingEnabled = true;
            this.comboBoxPavilion.ItemHeight = 23;
            this.comboBoxPavilion.Location = new System.Drawing.Point(6, 20);
            this.comboBoxPavilion.Name = "comboBoxPavilion";
            this.comboBoxPavilion.Size = new System.Drawing.Size(254, 29);
            this.comboBoxPavilion.TabIndex = 1;
            this.comboBoxPavilion.UseSelectable = true;
            this.comboBoxPavilion.SelectedIndexChanged += new System.EventHandler(this.comboBoxPavilion_SelectedIndexChanged);
            // 
            // listBoxService
            // 
            this.listBoxService.FormattingEnabled = true;
            this.listBoxService.Location = new System.Drawing.Point(6, 59);
            this.listBoxService.Name = "listBoxService";
            this.listBoxService.Size = new System.Drawing.Size(254, 147);
            this.listBoxService.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnSave.Location = new System.Drawing.Point(492, 288);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Ruaj";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddQuickReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 341);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddQuickReservation";
            this.Text = "Shto Rezervim Urgjence";
            this.Load += new System.EventHandler(this.AddQuickReservation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPatient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxService;
        private MetroFramework.Controls.MetroTextBox textSearchPatient;
        private MetroFramework.Controls.MetroComboBox comboBoxPavilion;
        private System.Windows.Forms.Button btnSave;
    }
}