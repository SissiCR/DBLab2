using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBLab
{
    public class Student
    {
        String ID;
        String firstname;
        String lastname;
        String gender;
        String city;
        String country;
        String birthdate;
        String type;
        int zipcode;
        List<String> phonenumbers;

        /*Constructor initializes all the instance variables*/
        public Student(String sID, String fName, String lName, String sGender, String sCity, String date, String sType, String sCountry, int zip) 
        {
            ID = sID;
            firstname = fName;
            lastname = lName;
            gender = sGender;
            city = sCity;
            country = sCountry;
            birthdate = date;
            type = sType;
            zipcode = zip;
            phonenumbers = new List<String>();
        }


        // All get metods to retrieve all the values of all instace variables

        public String getID() 
        {
            return ID;
        }

        public String getFirstname()
        {
            return firstname;
        }

        public String getLastname()
        {
            return lastname;
        }

        public String getGender()
        {
            return gender;
        }

        public String getCity()
        {
            return city;
        }

        public String getCountry()
        {
            return country;
        }

        public String getBirthDate()
        {
            return birthdate;
        }

        public String getType()
        {
            return type;
        }

        public int getZipcode()
        {
            return zipcode;
        }

        public List<String> getPhoneNumbers() 
        {
            return phonenumbers;
        }
    }
}
