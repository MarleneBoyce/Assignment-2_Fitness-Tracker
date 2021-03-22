namespace FitnessTracker
{
    partial class frmMain
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
            this.panelHome = new System.Windows.Forms.Panel();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbRating = new System.Windows.Forms.ComboBox();
            this.txtEquipment = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnHomeFromAdd = new System.Windows.Forms.Button();
            this.txtCal = new System.Windows.Forms.TextBox();
            this.panelView = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbRatingView = new System.Windows.Forms.ComboBox();
            this.txtCalView = new System.Windows.Forms.TextBox();
            this.txtTimeView = new System.Windows.Forms.TextBox();
            this.txtNameView = new System.Windows.Forms.TextBox();
            this.txtIdView = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnHomeFromView = new System.Windows.Forms.Button();
            this.txtEquipmentView = new System.Windows.Forms.TextBox();
            this.panelReport = new System.Windows.Forms.Panel();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.btnHomeFromReport = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelHome.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.panelView.SuspendLayout();
            this.panelReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.btnModify);
            this.panelHome.Controls.Add(this.btnAdd);
            this.panelHome.Controls.Add(this.label2);
            this.panelHome.Controls.Add(this.label1);
            this.panelHome.Controls.Add(this.btnReport);
            this.panelHome.Location = new System.Drawing.Point(40, 29);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(423, 496);
            this.panelHome.TabIndex = 0;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(131, 298);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(161, 33);
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "Modify Workout";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(131, 237);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(161, 33);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Workout";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select the following options";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fitness Tracker";
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(131, 359);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(161, 33);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Report Statistics";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.btnSave);
            this.panelAdd.Controls.Add(this.cmbRating);
            this.panelAdd.Controls.Add(this.txtEquipment);
            this.panelAdd.Controls.Add(this.txtTime);
            this.panelAdd.Controls.Add(this.txtName);
            this.panelAdd.Controls.Add(this.txtID);
            this.panelAdd.Controls.Add(this.label6);
            this.panelAdd.Controls.Add(this.label5);
            this.panelAdd.Controls.Add(this.label7);
            this.panelAdd.Controls.Add(this.label4);
            this.panelAdd.Controls.Add(this.label3);
            this.panelAdd.Controls.Add(this.label8);
            this.panelAdd.Controls.Add(this.label9);
            this.panelAdd.Controls.Add(this.btnHomeFromAdd);
            this.panelAdd.Controls.Add(this.txtCal);
            this.panelAdd.Location = new System.Drawing.Point(40, 29);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(423, 496);
            this.panelAdd.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(28, 450);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(154, 43);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbRating
            // 
            this.cmbRating.FormattingEnabled = true;
            this.cmbRating.Items.AddRange(new object[] {
            "Easy",
            "Moderate",
            "Hard",
            "Extreme"});
            this.cmbRating.Location = new System.Drawing.Point(193, 87);
            this.cmbRating.Name = "cmbRating";
            this.cmbRating.Size = new System.Drawing.Size(133, 33);
            this.cmbRating.TabIndex = 2;
            // 
            // txtEquipment
            // 
            this.txtEquipment.Location = new System.Drawing.Point(38, 245);
            this.txtEquipment.Multiline = true;
            this.txtEquipment.Name = "txtEquipment";
            this.txtEquipment.Size = new System.Drawing.Size(334, 162);
            this.txtEquipment.TabIndex = 5;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(193, 130);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(133, 32);
            this.txtTime.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(193, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 32);
            this.txtName.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(193, 3);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(133, 32);
            this.txtID.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total Calories Burned:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(319, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Equipment Used (separate by comma):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(333, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "minutes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total Workout Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Difficulty:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Workout Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "Workout ID:";
            // 
            // btnHomeFromAdd
            // 
            this.btnHomeFromAdd.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeFromAdd.Location = new System.Drawing.Point(241, 450);
            this.btnHomeFromAdd.Name = "btnHomeFromAdd";
            this.btnHomeFromAdd.Size = new System.Drawing.Size(154, 43);
            this.btnHomeFromAdd.TabIndex = 7;
            this.btnHomeFromAdd.Text = "Home";
            this.btnHomeFromAdd.UseVisualStyleBackColor = true;
            this.btnHomeFromAdd.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtCal
            // 
            this.txtCal.Location = new System.Drawing.Point(193, 172);
            this.txtCal.Name = "txtCal";
            this.txtCal.Size = new System.Drawing.Size(133, 32);
            this.txtCal.TabIndex = 4;
            // 
            // panelView
            // 
            this.panelView.Controls.Add(this.label10);
            this.panelView.Controls.Add(this.btnNext);
            this.panelView.Controls.Add(this.btnBack);
            this.panelView.Controls.Add(this.cmbRatingView);
            this.panelView.Controls.Add(this.txtCalView);
            this.panelView.Controls.Add(this.txtTimeView);
            this.panelView.Controls.Add(this.txtNameView);
            this.panelView.Controls.Add(this.txtIdView);
            this.panelView.Controls.Add(this.label11);
            this.panelView.Controls.Add(this.label12);
            this.panelView.Controls.Add(this.label13);
            this.panelView.Controls.Add(this.label14);
            this.panelView.Controls.Add(this.label15);
            this.panelView.Controls.Add(this.label16);
            this.panelView.Controls.Add(this.btnHomeFromView);
            this.panelView.Controls.Add(this.txtEquipmentView);
            this.panelView.Location = new System.Drawing.Point(41, 29);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(423, 496);
            this.panelView.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(333, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 25);
            this.label10.TabIndex = 35;
            this.label10.Text = "minutes";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(154, 450);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(118, 43);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(11, 450);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 43);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbRatingView
            // 
            this.cmbRatingView.FormattingEnabled = true;
            this.cmbRatingView.Items.AddRange(new object[] {
            "Easy",
            "Moderate",
            "Hard",
            "Extreme"});
            this.cmbRatingView.Location = new System.Drawing.Point(194, 87);
            this.cmbRatingView.Name = "cmbRatingView";
            this.cmbRatingView.Size = new System.Drawing.Size(133, 33);
            this.cmbRatingView.TabIndex = 31;
            // 
            // txtCalView
            // 
            this.txtCalView.Location = new System.Drawing.Point(194, 172);
            this.txtCalView.Name = "txtCalView";
            this.txtCalView.Size = new System.Drawing.Size(133, 32);
            this.txtCalView.TabIndex = 27;
            // 
            // txtTimeView
            // 
            this.txtTimeView.Location = new System.Drawing.Point(194, 130);
            this.txtTimeView.Name = "txtTimeView";
            this.txtTimeView.Size = new System.Drawing.Size(133, 32);
            this.txtTimeView.TabIndex = 28;
            // 
            // txtNameView
            // 
            this.txtNameView.Location = new System.Drawing.Point(194, 45);
            this.txtNameView.Name = "txtNameView";
            this.txtNameView.Size = new System.Drawing.Size(180, 32);
            this.txtNameView.TabIndex = 29;
            // 
            // txtIdView
            // 
            this.txtIdView.Location = new System.Drawing.Point(194, 3);
            this.txtIdView.Name = "txtIdView";
            this.txtIdView.Size = new System.Drawing.Size(133, 32);
            this.txtIdView.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(189, 25);
            this.label11.TabIndex = 20;
            this.label11.Text = "Total Calories Burned:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 217);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(338, 25);
            this.label12.TabIndex = 21;
            this.label12.Text = "Equipment Used (separated by commas):";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(39, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(172, 25);
            this.label13.TabIndex = 22;
            this.label13.Text = "Total Workout Time:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(39, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 25);
            this.label14.TabIndex = 23;
            this.label14.Text = "Difficulty:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(39, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 25);
            this.label15.TabIndex = 24;
            this.label15.Text = "Workout Name:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(39, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 25);
            this.label16.TabIndex = 25;
            this.label16.Text = "Workout ID:";
            // 
            // btnHomeFromView
            // 
            this.btnHomeFromView.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeFromView.Location = new System.Drawing.Point(294, 450);
            this.btnHomeFromView.Name = "btnHomeFromView";
            this.btnHomeFromView.Size = new System.Drawing.Size(118, 43);
            this.btnHomeFromView.TabIndex = 2;
            this.btnHomeFromView.Text = "Home";
            this.btnHomeFromView.UseVisualStyleBackColor = true;
            this.btnHomeFromView.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtEquipmentView
            // 
            this.txtEquipmentView.Location = new System.Drawing.Point(39, 245);
            this.txtEquipmentView.Multiline = true;
            this.txtEquipmentView.Name = "txtEquipmentView";
            this.txtEquipmentView.Size = new System.Drawing.Size(334, 162);
            this.txtEquipmentView.TabIndex = 26;
            // 
            // panelReport
            // 
            this.panelReport.Controls.Add(this.txtEnd);
            this.panelReport.Controls.Add(this.txtStart);
            this.panelReport.Controls.Add(this.btnHomeFromReport);
            this.panelReport.Controls.Add(this.label17);
            this.panelReport.Controls.Add(this.label18);
            this.panelReport.Controls.Add(this.label19);
            this.panelReport.Controls.Add(this.btnSearch);
            this.panelReport.Controls.Add(this.txtOutput);
            this.panelReport.Location = new System.Drawing.Point(40, 29);
            this.panelReport.Name = "panelReport";
            this.panelReport.Size = new System.Drawing.Size(423, 496);
            this.panelReport.TabIndex = 3;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 78);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(401, 364);
            this.txtOutput.TabIndex = 17;
          
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(243, 14);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(51, 32);
            this.txtEnd.TabIndex = 1;
            this.txtEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(134, 14);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(51, 32);
            this.txtStart.TabIndex = 0;
            this.txtStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnHomeFromReport
            // 
            this.btnHomeFromReport.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeFromReport.Location = new System.Drawing.Point(134, 448);
            this.btnHomeFromReport.Name = "btnHomeFromReport";
            this.btnHomeFromReport.Size = new System.Drawing.Size(154, 43);
            this.btnHomeFromReport.TabIndex = 3;
            this.btnHomeFromReport.Text = "Home";
            this.btnHomeFromReport.UseVisualStyleBackColor = true;
            this.btnHomeFromReport.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(200, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 25);
            this.label17.TabIndex = 18;
            this.label17.Text = "to";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 55);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 25);
            this.label18.TabIndex = 19;
            this.label18.Text = "Output";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(42, 17);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(106, 25);
            this.label19.TabIndex = 20;
            this.label19.Text = "Workout ID:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(306, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 32);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 570);
            this.Controls.Add(this.panelReport);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.panelHome);
            this.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "Fitness Tracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHome_FromClosing);
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panelView.ResumeLayout(false);
            this.panelView.PerformLayout();
            this.panelReport.ResumeLayout(false);
            this.panelReport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Button btnHomeFromAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbRating;
        private System.Windows.Forms.TextBox txtEquipment;
        private System.Windows.Forms.TextBox txtCal;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnHomeFromView;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbRatingView;
        private System.Windows.Forms.TextBox txtEquipmentView;
        private System.Windows.Forms.TextBox txtCalView;
        private System.Windows.Forms.TextBox txtTimeView;
        private System.Windows.Forms.TextBox txtNameView;
        private System.Windows.Forms.TextBox txtIdView;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panelReport;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Button btnHomeFromReport;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

