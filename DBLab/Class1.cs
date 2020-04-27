using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBLab
{
    class PhoneNumbers
    {
        String type;
        int number;
        public PhoneNumbers(String pType, int pNumber) 
        {
            type = pType;
            number = pNumber;
        }

        public String getType()
        {
            return type;
        }

        public int getNumber()
        {
            return number;
        }
    }
}
