/*
 Class Name: YKValidations
 Purpose: Validate Data
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
    public static class YKValidations
    {
        public static bool YKCanadaPostal(string postal)
        {
            bool isValid;
            Regex regPostal = new Regex("[ABCEGHJKLMNPRSTVXY][0-9]" +
                "[ABCEGHJKLMNPRSTVWXYZ] ?[0-9][ABCEGHJKLMNPRSTVWXYZ][0-9]");

            postal=postal.Replace(" ","");
            isValid = regPostal.IsMatch(postal);

            return isValid;
        }
        public static bool YKUSPostal(string postal)
        {
            return YKStringUtilities.YKOnlyDigits(postal).Length == 5 || 
                YKStringUtilities.YKOnlyDigits(postal).Length == 9;
        }
        public static bool YKPhoneNumber(string phoneNumber)
        {
            return YKStringUtilities.YKOnlyDigits(phoneNumber).Length == 10;
        }
    }
}
