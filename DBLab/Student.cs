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
        String zipcode;
        String address;
        List<String> phonenumbers;
        List<String> phonetypes;

        /*Constructor initializes all the instance variables*/
        public Student() 
        {
            /*   ID = sID;
            firstname = fName;
            lastname = lName;
            gender = sGender;
            city = sCity;
            country = sCountry;
            birthdate = date;
            type = sType;*/
        
            phonenumbers = new List<String>();
            phonetypes = new List<String>();
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

        public String getStreetAddress()
        {
            return address;
        }

        public String getBirthDate()
        {
            return birthdate;
        }

        public String getType()
        {
            return type;
        }

        public String getZipcode()
        {
           return zipcode;
           
           
        }

        public List<String> getPhoneType() 
        {
            return phonetypes;
        }
        public List<String> getPhoneNumbers() 
        {
            return phonenumbers;
        }

        public void setPhoneNumber(List<String> numbers) 
        {
            if (numbers != null) 
            {
                phonenumbers = numbers;
            }
           
        }

        public void setPhoneTypes(List<String> phtypes)
        {
            if (phtypes != null)
            {
                phonetypes = phtypes;
            }
            
        }

        public void setID(String id) 
        {
            if (id != null) 
            {
                ID = id;
            }
            
        }
        public void Setfirstname(string fname) 
        {
            if(fname != null)
            {
                firstname = fname;
            }
           
        }
        public void setLastname(String lname) 
        {
            if(lname != null)
            {
                lastname = lname;
            }
            
        }

        public void setGender(String sGender) 
        {
            if(sGender != null)
            {
                gender = sGender;
            }
            
        }

        public void setCity(String sCity) 
        {
            if(sCity != null)
            {
                city = sCity;
            }
            
        }

        public void setCountry(String sCountry) 
        {
            if(sCountry != null)
            {
                country = sCountry;
            }
           
        }

        public void setStreetAddress(String sAddress)
        {
            if(sAddress != null)
            {
                address = sAddress;
            }
        }

        public void Setbirthdate(string bday)
        {
            if(bday != null) 
            {
                birthdate = bday;
            }
            
        }
        public void setType(string typ)
        {
            if(typ != null)
            {
                type = typ;
            }
            
        }

        public void setZipcode(String zip)
        {
            if(zip != null)
            {
                zipcode = zip;
            }       
        }

        public void clearPhlist() 
        {

            phonenumbers.Clear();
                   
       
        }

        public void clearPhTypelist()
        {
            phonetypes.Clear();
        }
    }
}
