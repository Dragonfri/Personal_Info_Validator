/*
 Class Name: YKNumericUtilities
 Purpose: Manipulate Number
 Written by Young Geun, Kim(Andrew) April 20, 2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace YKUtilities
{
    public static class YKNumericUtilities
    {
        public static bool IsNumeric(string number)
        {
            bool chkNumber;
            Regex regNumber = new Regex (@"^[0-9]+$");
            chkNumber = regNumber.IsMatch(number);
            return chkNumber;
        }
        public static bool IsInteger(string number)
        {
            bool chkInteger;
            Regex regInteger = new Regex(@"^(\+|-)?\d+$");

            chkInteger = regInteger.IsMatch(number);
           
            return chkInteger;
        }
        public static bool IsInteger(double number)
        {
            bool chkInteger = true;
            Regex regInteger = new Regex(@"^(\+|-)?\d+$");

            chkInteger = regInteger.IsMatch(number.ToString());

            return chkInteger;
        }
        
    }
    
}
