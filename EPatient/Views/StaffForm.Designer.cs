namespace EPatient.Views
{
    partial class StaffForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timetablesMenuButton = new System.Windows.Forms.Button();
            this.reservationsMenuButton = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.mainPanel = new MetroFramework.Controls.MetroPanel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.timetablesMenuButton);
            this.panel2.Controls.Add(this.reservationsMenuButton);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.labelName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(20, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 620);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Paneli Stafit";
            // 
            // timetablesMenuButton
            // 
            this.timetablesMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.timetablesMenuButton.FlatAppearance.BorderSize = 0;
            this.timetablesMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timetablesMenuButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timetablesMenuButton.ForeColor = System.Drawing.Color.White;
            this.timetablesMenuButton.Image = global::EPatient.Properties.Resources.calendar_icon;
            this.timetablesMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.timetablesMenuButton.Location = new System.Drawing.Point(3, 170);
            this.timetablesMenuButton.Name = "timetablesMenuButton";
            this.timetablesMenuButton.Size = new System.Drawing.Size(228, 54);
            this.timetablesMenuButton.TabIndex = 1;
            this.timetablesMenuButton.Text = "Orare";
            this.timetablesMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.timetablesMenuButton.UseVisualStyleBackColor = false;
            this.timetablesMenuButton.Click += new System.EventHandler(this.timetablesMenuButton_Click);
            // 
            // reservationsMenuButton
            // 
            this.reservationsMenuButton.FlatAppearance.BorderSize = 0;
            this.reservationsMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservationsMenuButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationsMenuButton.ForeColor = System.Drawing.Color.White;
            this.reservationsMenuButton.Image = global::EPatient.Properties.Resources.addressbook_icon;
            this.reservationsMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reservationsMenuButton.Location = new System.Drawing.Point(3, 110);
            this.reservationsMenuButton.Name = "reservationsMenuButton";
            this.reservationsMenuButton.Size = new System.Drawing.Size(228, 54);
            this.reservationsMenuButton.TabIndex = 0;
            this.reservationsMenuButton.Text = "Rezervime";
            this.reservationsMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reservationsMenuButton.UseVisualStyleBackColor = true;
            this.reservationsMenuButton.Click += new System.EventHandler(this.reservationMenuButton_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 589);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(231, 31);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelName.Location = new System.Drawing.Point(3, 578);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 25);
            this.labelName.TabIndex = 8;
            // 
            // mainPanel
            // 
            this.mainPanel.HorizontalScrollbarBarColor = true;
            this.mainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mainPanel.HorizontalScrollbarSize = 10;
            this.mainPanel.Location = new System.Drawing.Point(251, 63);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(929, 614);
            this.mainPanel.TabIndex = 5;
            this.mainPanel.VerticalScrollbarBarColor = true;
            this.mainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mainPanel.VerticalScrollbarSize = 10;
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "StaffForm";
            this.Resizable = false;
            this.Text = "Paneli Stafit";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StaffForm_FormClosing);
            this.Load += new System.EventHandler(this.StaffForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button reservationsMenuButton;
        private System.Windows.Forms.Button timetablesMenuButton;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroPanel mainPanel;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label labelName;
    }
}