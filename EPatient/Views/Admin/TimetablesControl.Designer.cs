using System.Drawing;
using System.Windows.Forms;

namespace EPatient.Views.Admin
{
    partial class TimetablesControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.endTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.startTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkDayOff1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.timetablePanel = new MetroFramework.Controls.MetroPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.userLabel = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.endTimePicker7 = new System.Windows.Forms.DateTimePicker();
            this.checkDayOff7 = new MetroFramework.Controls.MetroCheckBox();
            this.startTimePicker7 = new System.Windows.Forms.DateTimePicker();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.endTimePicker6 = new System.Windows.Forms.DateTimePicker();
            this.checkDayOff6 = new MetroFramework.Controls.MetroCheckBox();
            this.startTimePicker6 = new System.Windows.Forms.DateTimePicker();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.endTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.checkDayOff5 = new MetroFramework.Controls.MetroCheckBox();
            this.startTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.endTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.startTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.checkDayOff4 = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.endTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.startTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.checkDayOff3 = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.endTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.startTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.checkDayOff2 = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pavilionDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pavilionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.timetablePanel.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pavilionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.endTimePicker1);
            this.groupBox1.Controls.Add(this.startTimePicker1);
            this.groupBox1.Controls.Add(this.checkDayOff1);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Location = new System.Drawing.Point(14, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 77);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "E Hene";
            // 
            // endTimePicker1
            // 
            this.endTimePicker1.CustomFormat = "HH:mm";
            this.endTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimePicker1.Location = new System.Drawing.Point(87, 49);
            this.endTimePicker1.Name = "endTimePicker1";
            this.endTimePicker1.ShowUpDown = true;
            this.endTimePicker1.Size = new System.Drawing.Size(94, 20);
            this.endTimePicker1.TabIndex = 6;
            this.endTimePicker1.Value = new System.DateTime(2018, 1, 17, 0, 0, 0, 0);
            // 
            // startTimePicker1
            // 
            this.startTimePicker1.CustomFormat = "HH:mm";
            this.startTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimePicker1.Location = new System.Drawing.Point(87, 23);
            this.startTimePicker1.Name = "startTimePicker1";
            this.startTimePicker1.ShowUpDown = true;
            this.startTimePicker1.Size = new System.Drawing.Size(94, 20);
            this.startTimePicker1.TabIndex = 5;
            this.startTimePicker1.Value = new System.DateTime(2018, 1, 17, 0, 0, 0, 0);
            // 
            // checkDayOff1
            // 
            this.checkDayOff1.AutoSize = true;
            this.checkDayOff1.Location = new System.Drawing.Point(200, 24);
            this.checkDayOff1.Name = "checkDayOff1";
            this.checkDayOff1.Size = new System.Drawing.Size(63, 15);
            this.checkDayOff1.TabIndex = 2;
            this.checkDayOff1.Text = "Pushim";
            this.checkDayOff1.UseSelectable = true;
            this.checkDayOff1.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(7, 39);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(72, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Perfundim:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(7, 20);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(43, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Fillim:";
            // 
            // timetablePanel
            // 
            this.timetablePanel.Controls.Add(this.btnCancel);
            this.timetablePanel.Controls.Add(this.userLabel);
            this.timetablePanel.Controls.Add(this.btnSave);
            this.timetablePanel.Controls.Add(this.groupBox7);
            this.timetablePanel.Controls.Add(this.groupBox6);
            this.timetablePanel.Controls.Add(this.groupBox5);
            this.timetablePanel.Controls.Add(this.groupBox4);
            this.timetablePanel.Controls.Add(this.groupBox3);
            this.timetablePanel.Controls.Add(this.groupBox2);
            this.timetablePanel.Controls.Add(this.groupBox1);
            this.timetablePanel.HorizontalScrollbarBarColor = true;
            this.timetablePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.timetablePanel.HorizontalScrollbarSize = 10;
            this.timetablePanel.Location = new System.Drawing.Point(750, 3);
            this.timetablePanel.Name = "timetablePanel";
            this.timetablePanel.Size = new System.Drawing.Size(299, 648);
            this.timetablePanel.TabIndex = 2;
            this.timetablePanel.VerticalScrollbarBarColor = true;
            this.timetablePanel.VerticalScrollbarHighlightOnWheel = false;
            this.timetablePanel.VerticalScrollbarSize = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(98, 610);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Anullo";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(101, 7);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(60, 19);
            this.userLabel.TabIndex = 11;
            this.userLabel.Text = "Axhenda";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnSave.Location = new System.Drawing.Point(194, 610);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Ruaj";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.White;
            this.groupBox7.Controls.Add(this.endTimePicker7);
            this.groupBox7.Controls.Add(this.checkDayOff7);
            this.groupBox7.Controls.Add(this.startTimePicker7);
            this.groupBox7.Controls.Add(this.metroLabel14);
            this.groupBox7.Controls.Add(this.metroLabel15);
            this.groupBox7.Location = new System.Drawing.Point(14, 527);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(270, 77);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "E Diele";
            // 
            // endTimePicker7
            // 
            this.endTimePicker7.CustomFormat = "HH:mm";
            this.endTimePicker7.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimePicker7.Location = new System.Drawing.Point(87, 45);
            this.endTimePicker7.Name = "endTimePicker7";
            this.endTimePicker7.ShowUpDown = true;
            this.endTimePicker7.Size = new System.Drawing.Size(94, 20);
            this.endTimePicker7.TabIndex = 18;
            this.endTimePicker7.Value = new System.DateTime(2018, 1, 17, 0, 0, 0, 0);
            // 
            // checkDayOff7
            // 
            this.checkDayOff7.AutoSize = true;
            this.checkDayOff7.Location = new System.Drawing.Point(200, 24);
            this.checkDayOff7.Name = "checkDayOff7";
            this.checkDayOff7.Size = new System.Drawing.Size(63, 15);
            this.checkDayOff7.TabIndex = 2;
            this.checkDayOff7.Text = "Pushim";
            this.checkDayOff7.UseSelectable = true;
            this.checkDayOff7.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // startTimePicker7
            // 
            this.startTimePicker7.CustomFormat = "HH:mm";
            this.startTimePicker7.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimePicker7.Location = new System.Drawing.Point(87, 19);
            this.startTimePicker7.Name = "startTimePicker7";
            this.startTimePicker7.ShowUpDown = true;
            this.startTimePicker7.Size = new System.Drawing.Size(94, 20);
            this.startTimePicker7.TabIndex = 17;
            this.startTimePicker7.Value = new System.DateTime(2018, 1, 17, 0, 0, 0, 0);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(7, 39);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(72, 19);
            this.metroLabel14.TabIndex = 1;
            this.metroLabel14.Text = "Perfundim:";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(7, 20);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(43, 19);
            this.metroLabel15.TabIndex = 0;
            this.metroLabel15.Text = "Fillim:";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.White;
            this.groupBox6.Controls.Add(this.endTimePicker6);
            this.groupBox6.Controls.Add(this.checkDayOff6);
            this.groupBox6.Controls.Add(this.startTimePicker6);
            this.groupBox6.Controls.Add(this.metroLabel12);
            this.groupBox6.Controls.Add(this.metroLabel13);
            this.groupBox6.Location = new System.Drawing.Point(14, 444);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(270, 77);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "E Shtune";
            // 
            // endTimePicker6
            // 
            this.endTimePicker6.CustomFormat = "HH:mm";
            this.endTimePicker6.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimePicker6.Location = new System.Drawing.Point(87, 45);
            this.endTimePicker6.Name = "endTimePicker6";
            this.endTimePicker6.ShowUpDown = true;
            this.endTimePicker6.Size = new System.Drawing.Size(94, 20);
            this.endTimePicker6.TabIndex = 16;
            this.endTimePicker6.Value = new System.DateTime(2018, 1, 17, 0, 0, 0, 0);
            // 
            // checkDayOff6
            // 
            this.checkDayOff6.AutoSize = true;
            this.checkDayOff6.Location = new System.Drawing.Point(200, 24);
            this.checkDayOff6.Name = "checkDayOff6";
            this.checkDayOff6.Size = new System.Drawing.Size(63, 15);
            this.checkDayOff6.TabIndex = 2;
            this.checkDayOff6.Text = "Pushim";
            this.checkDayOff6.UseSelectable = true;
            this.checkDayOff6.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // startTimePicker6
            // 
            this.startTimePicker6.CustomFormat = "HH:mm";
            this.startTimePicker6.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimePicker6.Location = new System.Drawing.Point(87, 19);
            this.startTimePicker6.Name = "startTimePicker6";
            this.startTimePicker6.ShowUpDown = true;
            this.startTimePicker6.Size = new System.Drawing.Size(94, 20);
            this.startTimePicker6.TabIndex = 15;
            this.startTimePicker6.Value = new System.DateTime(2018, 1, 17, 0, 0, 0, 0);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(7, 39);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(72, 19);
            this.metroLabel12.TabIndex = 1;
            this.metroLabel12.Text = "Perfundim:";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(7, 20);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(43, 19);
            this.metroLabel13.TabIndex = 0;
            this.metroLabel13.Text = "Fillim:";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.endTimePicker5);
            this.groupBox5.Controls.Add(this.checkDayOff5);
            this.groupBox5.Controls.Add(this.startTimePicker5);
            this.groupBox5.Controls.Add(this.metroLabel10);
            this.groupBox5.Controls.Add(this.metroLabel11);
            this.groupBox5.Location = new System.Drawing.Point(14, 361);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(270, 77);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "E Premte:";
            // 
            // endTimePicker5
            // 
            this.endTimePicker5.CustomFormat = "HH:mm";
            this.endTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimePicker5.Location = new System.Drawing.Point(87, 45);
            this.endTimePicker5.Name = "endTimePicker5";
            this.endTimePicker5.ShowUpDown = true;
            this.endTimePicker5.Size = new System.Drawing.Size(94, 20);
            this.endTimePicker5.TabIndex = 14;
            this.endTimePicker5.Value = new System.DateTime(2018, 1, 17, 0, 0, 0, 0);
            // 
            // checkDayOff5
            // 
            this.checkDayOff5.AutoSize = true;
            this.checkDayOff5.Location = new System.Drawing.Point(200, 24);
            this.checkDayOff5.Name = "checkDayOff5";
            this.checkDayOff5.Size = new System.Drawing.Size(63, 15);
            this.checkDayOff5.TabIndex = 2;
            this.checkDayOff5.Text = "Pushim";
            this.checkDayOff5.UseSelectable = true;
            this.checkDayOff5.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // startTimePicker5
            // 
            this.startTimePicker5.CustomFormat = "HH:mm";
            this.startTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimePicker5.Location = new System.Drawing.Point(87, 19);
            this.startTimePicker5.Name = "startTimePicker5";
            this.startTimePicker5.ShowUpDown = true;
            this.startTimePicker5.Size = new System.Drawing.Size(94, 20);
            this.startTimePicker5.TabIndex = 13;
            this.startTimePicker5.Value = new System.DateTime(2018, 1, 17, 0, 0, 0, 0);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(7, 39);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(72, 19);
            this.metroLabel10.TabIndex = 1;
            this.metroLabel10.Text = "Perfundim:";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(7, 20);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(43, 19);
            this.metroLabel11.TabIndex = 0;
            this.metroLabel11.Text = "Fillim:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.endTimePicker4);
            this.groupBox4.Controls.Add(this.startTimePicker4);
            this.groupBox4.Controls.Add(this.checkDayOff4);
            this.groupBox4.Controls.Add(this.metroLabel8);
            this.groupBox4.Controls.Add(this.metroLabel9);
            this.groupBox4.Location = new System.Drawing.Point(14, 278);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(270, 77);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "E Enjte:";
            // 
            // endTimePicker4
            // 
            this.endTimePicker4.CustomFormat = "HH:mm";
            this.endTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimePicker4.Location = new System.Drawing.Point(87, 45);
            this.endTimePicker4.Name = "endTimePicker4";
            this.endTimePicker4.ShowUpDown = true;
            this.endTimePicker4.Size = new System.Drawing.Size(94, 20);
            this.endTimePicker4.TabIndex = 12;
            this.endTimePicker4.Value = new System.DateTime(2018, 1, 17, 0, 0, 0, 0);
            // 
            // startTimePicker4
            // 
            this.startTimePicker4.CustomFormat = "HH:mm";
            this.startTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimePicker4.Location = new System.Drawing.Point(87, 19);
            this.startTimePicker4.Name = "startTimePicker4";
            this.startTimePicker4.ShowUpDown = true;
            this.startTimePicker4.Size = new System.Drawing.Size(94, 20);
            this.startTimePicker4.TabIndex = 11;
            this.startTimePicker4.Value = new System.DateTime(2018, 1, 17, 0, 0, 0, 0);
            // 
            // checkDayOff4
            // 
            this.checkDayOff4.AutoSize = true;
            this.checkDayOff4.Location = new System.Drawing.Point(200, 24);
            this.checkDayOff4.Name = "checkDayOff4";
            this.checkDayOff4.Size = new System.Drawing.Size(63, 15);
            this.checkDayOff4.TabIndex = 2;
            this.checkDayOff4.Text = "Pushim";
            this.checkDayOff4.UseSelectable = true;
            this.checkDayOff4.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(7, 39);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(72, 19);
            this.metroLabel8.TabIndex = 1;
            this.metroLabel8.Text = "Perfundim:";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(7, 20);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(43, 19);
            this.metroLabel9.TabIndex = 0;
            this.metroLabel9.Text = "Fillim:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.endTimePicker3);
            this.groupBox3.Controls.Add(this.startTimePicker3);
            this.groupBox3.Controls.Add(this.checkDayOff3);
            this.groupBox3.Controls.Add(this.metroLabel6);
            this.groupBox3.Controls.Add(this.metroLabel7);
            this.groupBox3.Location = new System.Drawing.Point(14, 195);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 77);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "E Merkure:";
            // 
            // endTimePicker3
            // 
            this.endTimePicker3.CustomFormat = "HH:mm";
            this.endTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimePicker3.Location = new System.Drawing.Point(87, 46);
            this.endTimePicker3.Name = "endTimePicker3";
            this.endTimePicker3.ShowUpDown = true;
            this.endTimePicker3.Size = new System.Drawing.Size(94, 20);
            this.endTimePicker3.TabIndex = 10;
            this.endTimePicker3.Value = new System.DateTime(2018, 1, 17, 0, 0, 0, 0);
            // 
            // startTimePicker3
            // 
            this.startTimePicker3.CustomFormat = "HH:mm";
            this.startTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimePicker3.Location = new System.Drawing.Point(87, 20);
            this.startTimePicker3.Name = "startTimePicker3";
            this.startTimePicker3.ShowUpDown = true;
            this.startTimePicker3.Size = new System.Drawing.Size(94, 20);
            this.startTimePicker3.TabIndex = 9;
            this.startTimePicker3.Value = new System.DateTime(2018, 1, 17, 0, 0, 0, 0);
            // 
            // checkDayOff3
            // 
            this.checkDayOff3.AutoSize = true;
            this.checkDayOff3.Location = new System.Drawing.Point(200, 24);
            this.checkDayOff3.Name = "checkDayOff3";
            this.checkDayOff3.Size = new System.Drawing.Size(63, 15);
            this.checkDayOff3.TabIndex = 2;
            this.checkDayOff3.Text = "Pushim";
            this.checkDayOff3.UseSelectable = true;
            this.checkDayOff3.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(7, 39);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(72, 19);
            this.metroLabel6.TabIndex = 1;
            this.metroLabel6.Text = "Perfundim:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(7, 20);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(43, 19);
            this.metroLabel7.TabIndex = 0;
            this.metroLabel7.Text = "Fillim:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.endTimePicker2);
            this.groupBox2.Controls.Add(this.startTimePicker2);
            this.groupBox2.Controls.Add(this.checkDayOff2);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Location = new System.Drawing.Point(14, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 77);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "E Marte:";
            // 
            // endTimePicker2
            // 
            this.endTimePicker2.CustomFormat = "HH:mm";
            this.endTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimePicker2.Location = new System.Drawing.Point(87, 39);
            this.endTimePicker2.Name = "endTimePicker2";
            this.endTimePicker2.ShowUpDown = true;
            this.endTimePicker2.Size = new System.Drawing.Size(94, 20);
            this.endTimePicker2.TabIndex = 8;
            this.endTimePicker2.Value = new System.DateTime(2018, 1, 17, 0, 0, 0, 0);
            // 
            // startTimePicker2
            // 
            this.startTimePicker2.CustomFormat = "HH:mm";
            this.startTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimePicker2.Location = new System.Drawing.Point(87, 13);
            this.startTimePicker2.Name = "startTimePicker2";
            this.startTimePicker2.ShowUpDown = true;
            this.startTimePicker2.Size = new System.Drawing.Size(94, 20);
            this.startTimePicker2.TabIndex = 7;
            this.startTimePicker2.Value = new System.DateTime(2018, 1, 17, 0, 0, 0, 0);
            // 
            // checkDayOff2
            // 
            this.checkDayOff2.AutoSize = true;
            this.checkDayOff2.Location = new System.Drawing.Point(200, 24);
            this.checkDayOff2.Name = "checkDayOff2";
            this.checkDayOff2.Size = new System.Drawing.Size(63, 15);
            this.checkDayOff2.TabIndex = 2;
            this.checkDayOff2.Text = "Pushim";
            this.checkDayOff2.UseSelectable = true;
            this.checkDayOff2.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(7, 39);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(72, 19);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "Perfundim:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(7, 20);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(43, 19);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Fillim:";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroGrid1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(15, 75);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(701, 544);
            this.metroPanel2.TabIndex = 3;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.metroGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.White;
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.roleDataGridViewComboBoxColumn,
            this.pavilionDataGridViewComboBoxColumn});
            this.metroGrid1.DataSource = this.usersBindingSource;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle27;
            this.metroGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(0, 0);
            this.metroGrid1.MultiSelect = false;
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Century Gothic", 48F);
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle28.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.metroGrid1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.metroGrid1.RowTemplate.Height = 30;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(701, 544);
            this.metroGrid1.TabIndex = 2;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 160;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.surnameDataGridViewTextBoxColumn.Width = 160;
            // 
            // roleDataGridViewComboBoxColumn
            // 
            this.roleDataGridViewComboBoxColumn.DataPropertyName = "RoleId";
            this.roleDataGridViewComboBoxColumn.DataSource = this.rolesBindingSource;
            this.roleDataGridViewComboBoxColumn.DisplayMember = "Name";
            this.roleDataGridViewComboBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roleDataGridViewComboBoxColumn.HeaderText = "Role";
            this.roleDataGridViewComboBoxColumn.Name = "roleDataGridViewComboBoxColumn";
            this.roleDataGridViewComboBoxColumn.ReadOnly = true;
            this.roleDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.roleDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.roleDataGridViewComboBoxColumn.ValueMember = "Id";
            this.roleDataGridViewComboBoxColumn.Width = 160;
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataSource = typeof(EPatient.Models.Role);
            // 
            // pavilionDataGridViewComboBoxColumn
            // 
            this.pavilionDataGridViewComboBoxColumn.DataPropertyName = "PavilionId";
            this.pavilionDataGridViewComboBoxColumn.DataSource = this.pavilionsBindingSource;
            this.pavilionDataGridViewComboBoxColumn.DisplayMember = "Name";
            this.pavilionDataGridViewComboBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pavilionDataGridViewComboBoxColumn.HeaderText = "Pavilion";
            this.pavilionDataGridViewComboBoxColumn.Name = "pavilionDataGridViewComboBoxColumn";
            this.pavilionDataGridViewComboBoxColumn.ReadOnly = true;
            this.pavilionDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pavilionDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pavilionDataGridViewComboBoxColumn.ValueMember = "Id";
            this.pavilionDataGridViewComboBoxColumn.Width = 160;
            // 
            // pavilionsBindingSource
            // 
            this.pavilionsBindingSource.DataSource = typeof(EPatient.Models.Pavilion);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(EPatient.Models.User);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnEdit.Location = new System.Drawing.Point(15, 29);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 30);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Modifiko";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // TimetablesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.timetablePanel);
            this.Name = "TimetablesControl";
            this.Size = new System.Drawing.Size(1049, 654);
            this.Load += new System.EventHandler(this.TimetablesControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.timetablePanel.ResumeLayout(false);
            this.timetablePanel.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pavilionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroCheckBox checkDayOff1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel timetablePanel;
        private System.Windows.Forms.GroupBox groupBox7;
        private MetroFramework.Controls.MetroCheckBox checkDayOff7;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private System.Windows.Forms.GroupBox groupBox6;
        private MetroFramework.Controls.MetroCheckBox checkDayOff6;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private System.Windows.Forms.GroupBox groupBox5;
        private MetroFramework.Controls.MetroCheckBox checkDayOff5;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroCheckBox checkDayOff4;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroCheckBox checkDayOff3;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroCheckBox checkDayOff2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private System.Windows.Forms.BindingSource pavilionsBindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DateTimePicker startTimePicker1;
        private System.Windows.Forms.DateTimePicker endTimePicker1;
        private System.Windows.Forms.DateTimePicker endTimePicker7;
        private System.Windows.Forms.DateTimePicker startTimePicker7;
        private System.Windows.Forms.DateTimePicker endTimePicker6;
        private System.Windows.Forms.DateTimePicker startTimePicker6;
        private System.Windows.Forms.DateTimePicker endTimePicker5;
        private System.Windows.Forms.DateTimePicker startTimePicker5;
        private System.Windows.Forms.DateTimePicker endTimePicker4;
        private System.Windows.Forms.DateTimePicker startTimePicker4;
        private System.Windows.Forms.DateTimePicker endTimePicker3;
        private System.Windows.Forms.DateTimePicker startTimePicker3;
        private System.Windows.Forms.DateTimePicker endTimePicker2;
        private System.Windows.Forms.DateTimePicker startTimePicker2;
        private MetroFramework.Controls.MetroLabel userLabel;
        private System.Windows.Forms.Button btnCancel;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn roleDataGridViewComboBoxColumn;
        private DataGridViewComboBoxColumn pavilionDataGridViewComboBoxColumn;
    }
}
