using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;




namespace DBLabs
{
    // här ska connection startas och det här sidan är den som körs inte dbconnection. kalla metoder i dbconnection här.
    public partial class AddStudentControl : UserControl
    {
        private DBConnection dbconn;
        private DBLab.Student student;
        private List<String> phoneNumbers;
        private List<String> phoneTypes;
        private List<TextBox> textBoxes;
        private List<ComboBox> comboBoxes;
        

        public AddStudentControl()
        {
            /*
             * Constructor the control
             * 
             * You DONT need to edit this constructor.
             * 
             */
            InitializeComponent();
        }

        public void AddStudentControlSettings(ref DBConnection dbconn)
        {
            /*
             * Since UserControls cannot take arguments to the constructor 
             * this function is called after the constructor to perform this.
             * 
             * You DONT need to edit this function.
             * 
             */
            this.dbconn = dbconn; 
        }

        /* Adds all the boxes into lists. Fills the comboboxes with information.
         * This function contains all code that needs to be executed when the control is first loaded
         */
        private void LoadAddStudentControl(object sender, EventArgs e)
        {
            phoneNumbers = new List<String>();
            phoneTypes = new List<String>();

            textBoxes = new List<TextBox>()
            {
                studentIDBox,
                firstnameBox,
                lastnameBox,
                streetAdressBox,
                zipcodeBox,
                cityBox,
                countryBox,
                phoneNumberBox,
            };

            comboBoxes = new List<ComboBox>()
            {
                genderComboBox,
                phoneTypeComboBox,
                StudentTypeComboBox,
            };

                     
                DataTable phTable = dbconn.getPhTypesFromDB();
                phTable = dbconn.getPhTypesFromDB();
                phoneTypeComboBox.DataSource = phTable;
                phoneTypeComboBox.DisplayMember = "PhoneType";
                   
                DataTable studentTypeTb = dbconn.getStTypesFromDB();
                StudentTypeComboBox.DataSource = studentTypeTb;
                StudentTypeComboBox.DisplayMember = "_Type";     
        }

        /*Creates a student and sets all the instance variables in Student*/
        private void createStudent() 
        {
            student = new DBLab.Student();

            student.Setfirstname(firstnameBox.Text);
            student.setLastname(lastnameBox.Text);
            student.setID(studentIDBox.Text);
            student.setGender(genderComboBox.Text);
            student.setCity(cityBox.Text);
            student.Setbirthdate(dateTimePicker1.Value.ToString());
            student.setType(StudentTypeComboBox.Text);
            student.setStreetAddress(streetAdressBox.Text);
            student.setCountry(countryBox.Text);
            student.setZipcode(zipcodeBox.Text);
            student.setPhoneNumber(phoneNumbers);
            student.setPhoneTypes(phoneTypes);
        }

        /* This function contains all code that needs to be executed when the control is reloaded
         * You need to edit this code. 
         * Example: Emptying textboxes and gridviews
         */
        public void ResetAddStudentControl()
        {

            foreach (var type in textBoxes)
            {
                type.Text = string.Empty;
            }

            foreach (var item in comboBoxes)
            {
                item.Text = string.Empty;
            }

            phoneNrListView.Items.Clear();
            phoneNrListView.Refresh();

            dateTimePicker1.ResetText();

            if (student != null)
            {
                student.clearPhlist();
                student.clearPhTypelist();
            }
        }
        /*SumitButton - when it is click the stundent information is added to the database and the form is reset*/
        private void Button_Click(object sender, EventArgs e)
        {
            createStudent();
           
            int stRowNr = dbconn.addStudentControl(student);
            int phRowNr = dbconn.addPhoneControl(student);
            if (stRowNr == 1) 
            {               
               if(phRowNr > 0)
                {
                    MessageBox.Show("Student Succesfully added!\nAffected rows in Students table:" + " " + stRowNr.ToString() + "\n" + "Affected rows in StudentPhonenumber table: " + " " + phRowNr.ToString());
                }
            }
          
            ResetAddStudentControl();
           
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            phoneNrListView.FullRowSelect = true;
            phoneNrListView.GridLines = true;
        }

        /* The addButton - Adds the number and type of the phonenumber into the phoneNrListView. 
         * list with phonenumbers and photypes are fill.
         * Then clears the phoneNumberBox
         */
        private void Button1_Click(object sender, EventArgs e)
        {

            ListViewItem item = new ListViewItem(phoneNumberBox.Text);
            item.SubItems.Add(phoneTypeComboBox.Text);
            phoneNrListView.Items.Add(item);
            
            phoneNumbers.Add(phoneNumberBox.Text);         
            phoneTypes.Add(phoneTypeComboBox.Text);

            phoneNumberBox.Clear();
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void streetlbl_Click(object sender, EventArgs e)
        {

        }

        public void birthdatelbl_Click(object sender, EventArgs e)
        {

        }

        public void genderlbl_Click(object sender, EventArgs e)
        {

        }

        public void studentIDBox_TextChanged(object sender, EventArgs e)
        {
            
        }
         
        private void GenderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddStudentGB_Enter(object sender, EventArgs e)
        {

        }
    }
}
