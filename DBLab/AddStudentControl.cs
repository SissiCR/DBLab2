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
        DBLab.Student student;
        List<TextBox> textBoxes;
        List<ComboBox> comboBoxes;
        

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

        private void LoadAddStudentControl(object sender, EventArgs e)
        {
            /*
             * This function contains all code that needs to be executed when the control is first loaded
             * 
             * You need to edit this code. 
             * Example: Population of Comboboxes and gridviews etc.
             *hämta student types and phone types från databasen och addera i listorna.
             * 
             */

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
        }
        public void ResetAddStudentControl()
        {
            /*
             * This function contains all code that needs to be executed when the control is reloaded
             * 
             * You need to edit this code. 
             * Example: Emptying textboxes and gridviews
             * 
             */
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
         //the sumit button
        private void Button_Click(object sender, EventArgs e)
        {

            /*if(dbconn.addStudentControl(student)) 
            {
                //show message that student was succesfully uplodaded
            }*/
        }

        private void fillStudent(DBLab.Student student, DBLab.PhoneNumbers phNumbers) 
        {
           //fill student from  the list
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

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            phoneNrListView.FullRowSelect = true;
            phoneNrListView.GridLines = true;
        }
        //the add button to phone number
        private void Button1_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(phoneNumberBox.Text);
            item.SubItems.Add(phoneTypeComboBox.Text);
            phoneNrListView.Items.Add(item);
            phoneNumberBox.Clear();
        }

        private void PhoneTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
