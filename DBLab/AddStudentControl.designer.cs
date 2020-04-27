namespace DBLabs
{
    partial class AddStudentControl
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
            this.AddStudentGB = new System.Windows.Forms.GroupBox();
            this.AddToListViewBtn = new System.Windows.Forms.Button();
            this.phoneNrListView = new System.Windows.Forms.ListView();
            this.phoneNumberBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.submitButtton = new System.Windows.Forms.Button();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.phoneTypeComboBox = new System.Windows.Forms.ComboBox();
            this.phoneTypelbl = new System.Windows.Forms.Label();
            this.StudentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.studentTypelbl = new System.Windows.Forms.Label();
            this.birthdatelbl = new System.Windows.Forms.Label();
            this.countryBox = new System.Windows.Forms.TextBox();
            this.countrylbl = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.citylbl = new System.Windows.Forms.Label();
            this.zipcodeBox = new System.Windows.Forms.TextBox();
            this.zipcodelbl = new System.Windows.Forms.Label();
            this.streetAdressBox = new System.Windows.Forms.TextBox();
            this.streetAdresslbl = new System.Windows.Forms.Label();
            this.genderlbl = new System.Windows.Forms.Label();
            this.lastnameBox = new System.Windows.Forms.TextBox();
            this.lastnamelbl = new System.Windows.Forms.Label();
            this.firstnameBox = new System.Windows.Forms.TextBox();
            this.firstnamelbl = new System.Windows.Forms.Label();
            this.studentIDBox = new System.Windows.Forms.TextBox();
            this.studentIDlbl = new System.Windows.Forms.Label();
            this.AddStudentGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddStudentGB
            // 
            this.AddStudentGB.Controls.Add(this.AddToListViewBtn);
            this.AddStudentGB.Controls.Add(this.phoneNrListView);
            this.AddStudentGB.Controls.Add(this.phoneNumberBox);
            this.AddStudentGB.Controls.Add(this.label1);
            this.AddStudentGB.Controls.Add(this.dateTimePicker1);
            this.AddStudentGB.Controls.Add(this.submitButtton);
            this.AddStudentGB.Controls.Add(this.genderComboBox);
            this.AddStudentGB.Controls.Add(this.phoneTypeComboBox);
            this.AddStudentGB.Controls.Add(this.phoneTypelbl);
            this.AddStudentGB.Controls.Add(this.StudentTypeComboBox);
            this.AddStudentGB.Controls.Add(this.studentTypelbl);
            this.AddStudentGB.Controls.Add(this.birthdatelbl);
            this.AddStudentGB.Controls.Add(this.countryBox);
            this.AddStudentGB.Controls.Add(this.countrylbl);
            this.AddStudentGB.Controls.Add(this.cityBox);
            this.AddStudentGB.Controls.Add(this.citylbl);
            this.AddStudentGB.Controls.Add(this.zipcodeBox);
            this.AddStudentGB.Controls.Add(this.zipcodelbl);
            this.AddStudentGB.Controls.Add(this.streetAdressBox);
            this.AddStudentGB.Controls.Add(this.streetAdresslbl);
            this.AddStudentGB.Controls.Add(this.genderlbl);
            this.AddStudentGB.Controls.Add(this.lastnameBox);
            this.AddStudentGB.Controls.Add(this.lastnamelbl);
            this.AddStudentGB.Controls.Add(this.firstnameBox);
            this.AddStudentGB.Controls.Add(this.firstnamelbl);
            this.AddStudentGB.Controls.Add(this.studentIDBox);
            this.AddStudentGB.Controls.Add(this.studentIDlbl);
            this.AddStudentGB.Location = new System.Drawing.Point(21, 18);
            this.AddStudentGB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddStudentGB.Name = "AddStudentGB";
            this.AddStudentGB.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddStudentGB.Size = new System.Drawing.Size(1576, 780);
            this.AddStudentGB.TabIndex = 54;
            this.AddStudentGB.TabStop = false;
            this.AddStudentGB.Text = "Add Student";
            // 
            // AddToListViewBtn
            // 
            this.AddToListViewBtn.Location = new System.Drawing.Point(899, 397);
            this.AddToListViewBtn.Name = "AddToListViewBtn";
            this.AddToListViewBtn.Size = new System.Drawing.Size(81, 28);
            this.AddToListViewBtn.TabIndex = 28;
            this.AddToListViewBtn.Text = "Add";
            this.AddToListViewBtn.UseVisualStyleBackColor = true;
            this.AddToListViewBtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // phoneNrListView
            // 
            this.phoneNrListView.HideSelection = false;
            this.phoneNrListView.Location = new System.Drawing.Point(875, 270);
            this.phoneNrListView.Name = "phoneNrListView";
            this.phoneNrListView.Size = new System.Drawing.Size(121, 108);
            this.phoneNrListView.TabIndex = 27;
            this.phoneNrListView.UseCompatibleStateImageBehavior = false;
            this.phoneNrListView.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // phoneNumberBox
            // 
            this.phoneNumberBox.Location = new System.Drawing.Point(875, 207);
            this.phoneNumberBox.Name = "phoneNumberBox";
            this.phoneNumberBox.Size = new System.Drawing.Size(121, 26);
            this.phoneNumberBox.TabIndex = 26;
            this.phoneNumberBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(742, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Number";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(538, 254);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 24;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // submitButtton
            // 
            this.submitButtton.Location = new System.Drawing.Point(159, 466);
            this.submitButtton.Name = "submitButtton";
            this.submitButtton.Size = new System.Drawing.Size(81, 30);
            this.submitButtton.TabIndex = 23;
            this.submitButtton.Text = "Submit";
            this.submitButtton.UseVisualStyleBackColor = true;
            this.submitButtton.Click += new System.EventHandler(this.Button_Click);
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(172, 251);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(121, 28);
            this.genderComboBox.TabIndex = 22;
            this.genderComboBox.SelectedIndexChanged += new System.EventHandler(this.GenderComboBox_SelectedIndexChanged);
            // 
            // phoneTypeComboBox
            // 
            this.phoneTypeComboBox.FormattingEnabled = true;
            this.phoneTypeComboBox.Items.AddRange(new object[] {
            "Mobil",
            "Arbete",
            "Hem"});
            this.phoneTypeComboBox.Location = new System.Drawing.Point(875, 155);
            this.phoneTypeComboBox.Name = "phoneTypeComboBox";
            this.phoneTypeComboBox.Size = new System.Drawing.Size(121, 28);
            this.phoneTypeComboBox.TabIndex = 21;
            this.phoneTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.PhoneTypeComboBox_SelectedIndexChanged);
            // 
            // phoneTypelbl
            // 
            this.phoneTypelbl.AutoSize = true;
            this.phoneTypelbl.Location = new System.Drawing.Point(738, 161);
            this.phoneTypelbl.Name = "phoneTypelbl";
            this.phoneTypelbl.Size = new System.Drawing.Size(89, 20);
            this.phoneTypelbl.TabIndex = 20;
            this.phoneTypelbl.Text = "PhoneType";
            // 
            // StudentTypeComboBox
            // 
            this.StudentTypeComboBox.FormattingEnabled = true;
            this.StudentTypeComboBox.Items.AddRange(new object[] {
            "Programstudent",
            "Fristående student",
            "Exchange-student"});
            this.StudentTypeComboBox.Location = new System.Drawing.Point(875, 97);
            this.StudentTypeComboBox.Name = "StudentTypeComboBox";
            this.StudentTypeComboBox.Size = new System.Drawing.Size(121, 28);
            this.StudentTypeComboBox.TabIndex = 19;
            // 
            // studentTypelbl
            // 
            this.studentTypelbl.AutoSize = true;
            this.studentTypelbl.Location = new System.Drawing.Point(738, 105);
            this.studentTypelbl.Name = "studentTypelbl";
            this.studentTypelbl.Size = new System.Drawing.Size(100, 20);
            this.studentTypelbl.TabIndex = 18;
            this.studentTypelbl.Text = "StudentType";
            // 
            // birthdatelbl
            // 
            this.birthdatelbl.AutoSize = true;
            this.birthdatelbl.Location = new System.Drawing.Point(416, 254);
            this.birthdatelbl.Name = "birthdatelbl";
            this.birthdatelbl.Size = new System.Drawing.Size(74, 20);
            this.birthdatelbl.TabIndex = 16;
            this.birthdatelbl.Text = "Birthdate";
            this.birthdatelbl.Click += new System.EventHandler(this.birthdatelbl_Click);
            // 
            // countryBox
            // 
            this.countryBox.Location = new System.Drawing.Point(538, 204);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(100, 26);
            this.countryBox.TabIndex = 15;
            // 
            // countrylbl
            // 
            this.countrylbl.AutoSize = true;
            this.countrylbl.Location = new System.Drawing.Point(416, 204);
            this.countrylbl.Name = "countrylbl";
            this.countrylbl.Size = new System.Drawing.Size(64, 20);
            this.countrylbl.TabIndex = 14;
            this.countrylbl.Text = "Country";
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(538, 155);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(100, 26);
            this.cityBox.TabIndex = 13;
            // 
            // citylbl
            // 
            this.citylbl.AutoSize = true;
            this.citylbl.Location = new System.Drawing.Point(416, 155);
            this.citylbl.Name = "citylbl";
            this.citylbl.Size = new System.Drawing.Size(35, 20);
            this.citylbl.TabIndex = 12;
            this.citylbl.Text = "City";
            // 
            // zipcodeBox
            // 
            this.zipcodeBox.Location = new System.Drawing.Point(538, 99);
            this.zipcodeBox.Name = "zipcodeBox";
            this.zipcodeBox.Size = new System.Drawing.Size(100, 26);
            this.zipcodeBox.TabIndex = 11;
            // 
            // zipcodelbl
            // 
            this.zipcodelbl.AutoSize = true;
            this.zipcodelbl.Location = new System.Drawing.Point(416, 105);
            this.zipcodelbl.Name = "zipcodelbl";
            this.zipcodelbl.Size = new System.Drawing.Size(66, 20);
            this.zipcodelbl.TabIndex = 10;
            this.zipcodelbl.Text = "Zipcode";
            // 
            // streetAdressBox
            // 
            this.streetAdressBox.Location = new System.Drawing.Point(172, 301);
            this.streetAdressBox.Name = "streetAdressBox";
            this.streetAdressBox.Size = new System.Drawing.Size(100, 26);
            this.streetAdressBox.TabIndex = 9;
            // 
            // streetAdresslbl
            // 
            this.streetAdresslbl.AutoSize = true;
            this.streetAdresslbl.Location = new System.Drawing.Point(25, 307);
            this.streetAdresslbl.Name = "streetAdresslbl";
            this.streetAdresslbl.Size = new System.Drawing.Size(107, 20);
            this.streetAdresslbl.TabIndex = 8;
            this.streetAdresslbl.Text = " StreetAdress";
            this.streetAdresslbl.Click += new System.EventHandler(this.streetlbl_Click);
            // 
            // genderlbl
            // 
            this.genderlbl.AutoSize = true;
            this.genderlbl.Location = new System.Drawing.Point(34, 254);
            this.genderlbl.Name = "genderlbl";
            this.genderlbl.Size = new System.Drawing.Size(63, 20);
            this.genderlbl.TabIndex = 6;
            this.genderlbl.Text = "Gender";
            this.genderlbl.Click += new System.EventHandler(this.genderlbl_Click);
            // 
            // lastnameBox
            // 
            this.lastnameBox.Location = new System.Drawing.Point(172, 204);
            this.lastnameBox.Name = "lastnameBox";
            this.lastnameBox.Size = new System.Drawing.Size(100, 26);
            this.lastnameBox.TabIndex = 5;
            // 
            // lastnamelbl
            // 
            this.lastnamelbl.AutoSize = true;
            this.lastnamelbl.Location = new System.Drawing.Point(34, 207);
            this.lastnamelbl.Name = "lastnamelbl";
            this.lastnamelbl.Size = new System.Drawing.Size(80, 20);
            this.lastnamelbl.TabIndex = 4;
            this.lastnamelbl.Text = "Lastname";
            // 
            // firstnameBox
            // 
            this.firstnameBox.Location = new System.Drawing.Point(172, 155);
            this.firstnameBox.Name = "firstnameBox";
            this.firstnameBox.Size = new System.Drawing.Size(100, 26);
            this.firstnameBox.TabIndex = 3;
            // 
            // firstnamelbl
            // 
            this.firstnamelbl.AutoSize = true;
            this.firstnamelbl.Location = new System.Drawing.Point(34, 161);
            this.firstnamelbl.Name = "firstnamelbl";
            this.firstnamelbl.Size = new System.Drawing.Size(80, 20);
            this.firstnamelbl.TabIndex = 2;
            this.firstnamelbl.Text = "Firstname";
            // 
            // studentIDBox
            // 
            this.studentIDBox.Location = new System.Drawing.Point(172, 99);
            this.studentIDBox.Name = "studentIDBox";
            this.studentIDBox.Size = new System.Drawing.Size(100, 26);
            this.studentIDBox.TabIndex = 1;
            this.studentIDBox.TextChanged += new System.EventHandler(this.studentIDBox_TextChanged);
            // 
            // studentIDlbl
            // 
            this.studentIDlbl.AutoSize = true;
            this.studentIDlbl.Location = new System.Drawing.Point(31, 105);
            this.studentIDlbl.Name = "studentIDlbl";
            this.studentIDlbl.Size = new System.Drawing.Size(83, 20);
            this.studentIDlbl.TabIndex = 0;
            this.studentIDlbl.Text = "StudentID";
            this.studentIDlbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddStudentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddStudentGB);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddStudentControl";
            this.Size = new System.Drawing.Size(1630, 820);
            this.Load += new System.EventHandler(this.LoadAddStudentControl);
            this.AddStudentGB.ResumeLayout(false);
            this.AddStudentGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox AddStudentGB;
        public System.Windows.Forms.Label studentIDlbl;
        public System.Windows.Forms.Label lastnamelbl;
        public System.Windows.Forms.TextBox firstnameBox;
        public System.Windows.Forms.Label firstnamelbl;
        public System.Windows.Forms.TextBox studentIDBox;
        public System.Windows.Forms.Label genderlbl;
        public System.Windows.Forms.TextBox lastnameBox;
        public System.Windows.Forms.TextBox streetAdressBox;
        public System.Windows.Forms.Label streetAdresslbl;
        public System.Windows.Forms.Label citylbl;
        public System.Windows.Forms.TextBox zipcodeBox;
        public System.Windows.Forms.Label zipcodelbl;
        public System.Windows.Forms.Label birthdatelbl;
        public System.Windows.Forms.TextBox countryBox;
        public System.Windows.Forms.Label countrylbl;
        public System.Windows.Forms.TextBox cityBox;
        public System.Windows.Forms.Label studentTypelbl;
        public System.Windows.Forms.ComboBox phoneTypeComboBox;
        public System.Windows.Forms.Label phoneTypelbl;
        public System.Windows.Forms.ComboBox StudentTypeComboBox;
        public System.Windows.Forms.ComboBox genderComboBox;
        public System.Windows.Forms.Button submitButtton;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.TextBox phoneNumberBox;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button AddToListViewBtn;
        public System.Windows.Forms.ListView phoneNrListView;
    }
}
