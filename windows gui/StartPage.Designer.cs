namespace windows_gui
{
    partial class startPage
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
            this.creatorName = new System.Windows.Forms.Label();
            this.createdBy = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.userageSpin = new System.Windows.Forms.NumericUpDown();
            this.ageLbl = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.birthdayLbl = new System.Windows.Forms.Label();
            this.genderMaleRB = new System.Windows.Forms.RadioButton();
            this.genderFemaleRB = new System.Windows.Forms.RadioButton();
            this.familyListbx = new System.Windows.Forms.ListBox();
            this.exampleCmbox = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.submissionSpin = new System.Windows.Forms.NumericUpDown();
            this.statusBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.userageSpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.submissionSpin)).BeginInit();
            this.SuspendLayout();
            // 
            // creatorName
            // 
            this.creatorName.AutoSize = true;
            this.creatorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.creatorName.Location = new System.Drawing.Point(707, 439);
            this.creatorName.Name = "creatorName";
            this.creatorName.Size = new System.Drawing.Size(69, 9);
            this.creatorName.TabIndex = 0;
            this.creatorName.Text = "Anthony R Garrard";
            this.creatorName.Click += new System.EventHandler(this.label1_Click);
            // 
            // createdBy
            // 
            this.createdBy.AutoSize = true;
            this.createdBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.createdBy.Location = new System.Drawing.Point(670, 439);
            this.createdBy.Name = "createdBy";
            this.createdBy.Size = new System.Drawing.Size(40, 9);
            this.createdBy.TabIndex = 1;
            this.createdBy.Text = "created by";
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(13, 13);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(100, 13);
            this.usernameLbl.TabIndex = 2;
            this.usernameLbl.Text = "Enter your full name";
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(119, 10);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(223, 20);
            this.usernameText.TabIndex = 3;
            this.usernameText.Text = "enter name";
            this.usernameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // userageSpin
            // 
            this.userageSpin.Location = new System.Drawing.Point(119, 36);
            this.userageSpin.Maximum = new decimal(new int[] {
            132,
            0,
            0,
            0});
            this.userageSpin.Name = "userageSpin";
            this.userageSpin.Size = new System.Drawing.Size(41, 20);
            this.userageSpin.TabIndex = 4;
            this.userageSpin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userageSpin.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // ageLbl
            // 
            this.ageLbl.AutoSize = true;
            this.ageLbl.Location = new System.Drawing.Point(16, 42);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(54, 13);
            this.ageLbl.TabIndex = 5;
            this.ageLbl.Text = "Enter Age";
            // 
            // submitButton
            // 
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitButton.Location = new System.Drawing.Point(221, 425);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(347, 23);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(119, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(92, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // birthdayLbl
            // 
            this.birthdayLbl.AutoSize = true;
            this.birthdayLbl.Location = new System.Drawing.Point(16, 69);
            this.birthdayLbl.Name = "birthdayLbl";
            this.birthdayLbl.Size = new System.Drawing.Size(45, 13);
            this.birthdayLbl.TabIndex = 8;
            this.birthdayLbl.Text = "Birthday";
            // 
            // genderMaleRB
            // 
            this.genderMaleRB.AutoSize = true;
            this.genderMaleRB.Location = new System.Drawing.Point(378, 11);
            this.genderMaleRB.Name = "genderMaleRB";
            this.genderMaleRB.Size = new System.Drawing.Size(48, 17);
            this.genderMaleRB.TabIndex = 9;
            this.genderMaleRB.TabStop = true;
            this.genderMaleRB.Text = "Male";
            this.genderMaleRB.UseVisualStyleBackColor = true;
            // 
            // genderFemaleRB
            // 
            this.genderFemaleRB.AutoSize = true;
            this.genderFemaleRB.Location = new System.Drawing.Point(378, 34);
            this.genderFemaleRB.Name = "genderFemaleRB";
            this.genderFemaleRB.Size = new System.Drawing.Size(59, 17);
            this.genderFemaleRB.TabIndex = 10;
            this.genderFemaleRB.TabStop = true;
            this.genderFemaleRB.Text = "Female";
            this.genderFemaleRB.UseVisualStyleBackColor = true;
            // 
            // familyListbx
            // 
            this.familyListbx.FormattingEnabled = true;
            this.familyListbx.Items.AddRange(new object[] {
            "Brother 1",
            "Brother 2",
            "Brother 3",
            "Brother 4",
            "Brother 5"});
            this.familyListbx.Location = new System.Drawing.Point(119, 89);
            this.familyListbx.Name = "familyListbx";
            this.familyListbx.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.familyListbx.Size = new System.Drawing.Size(120, 95);
            this.familyListbx.TabIndex = 11;
            // 
            // exampleCmbox
            // 
            this.exampleCmbox.FormattingEnabled = true;
            this.exampleCmbox.Items.AddRange(new object[] {
            "Item 1",
            "Thing 2",
            "Object 3",
            "Posecesion 4"});
            this.exampleCmbox.Location = new System.Drawing.Point(245, 89);
            this.exampleCmbox.Name = "exampleCmbox";
            this.exampleCmbox.Size = new System.Drawing.Size(121, 21);
            this.exampleCmbox.TabIndex = 12;
            this.exampleCmbox.Text = "pick";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(246, 117);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(246, 141);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(246, 167);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 15;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // submissionSpin
            // 
            this.submissionSpin.Location = new System.Drawing.Point(3, 425);
            this.submissionSpin.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.submissionSpin.Name = "submissionSpin";
            this.submissionSpin.ReadOnly = true;
            this.submissionSpin.Size = new System.Drawing.Size(48, 20);
            this.submissionSpin.TabIndex = 16;
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(57, 422);
            this.statusBar.Maximum = 101;
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(154, 23);
            this.statusBar.TabIndex = 17;
            // 
            // startPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 457);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.submissionSpin);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.exampleCmbox);
            this.Controls.Add(this.familyListbx);
            this.Controls.Add(this.genderFemaleRB);
            this.Controls.Add(this.genderMaleRB);
            this.Controls.Add(this.birthdayLbl);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.creatorName);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.ageLbl);
            this.Controls.Add(this.userageSpin);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.createdBy);
            this.Name = "startPage";
            this.Text = "Start Page";
            this.Load += new System.EventHandler(this.StartPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userageSpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.submissionSpin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label creatorName;
        private System.Windows.Forms.Label createdBy;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.NumericUpDown userageSpin;
        private System.Windows.Forms.Label ageLbl;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label birthdayLbl;
        private System.Windows.Forms.RadioButton genderMaleRB;
        private System.Windows.Forms.RadioButton genderFemaleRB;
        private System.Windows.Forms.ListBox familyListbx;
        private System.Windows.Forms.ComboBox exampleCmbox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.NumericUpDown submissionSpin;
        private System.Windows.Forms.ProgressBar statusBar;
    }
}

