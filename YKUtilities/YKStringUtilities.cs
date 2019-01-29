/*
 Class Name: YKStringUtilities
 Purpose: Manipulate String
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
    public static class YKStringUtilities
    {
        public static string YKCapitalize(string sentence)
        {
            bool SpaceRemain = true;
            if (sentence != "")
            {
                sentence = sentence.Trim().ToLower();
                StringBuilder text = new StringBuilder(sentence);
                text[0] = char.ToUpper(text[0]);
                int space = 0;
                do
                {
                    space = sentence.IndexOf(" ", space + 1);
                    if (space > 0)
                    {
                        text[space + 1] = char.ToUpper(text[space + 1]);
                    }
                    else
                        SpaceRemain = false;
                } while (SpaceRemain);
                sentence = text.ToString();
            }
            return sentence;
        }
        public static string YKOnlyDigits(string sentence)
        {
            if (sentence != "")
            {
                sentence = sentence.Replace(" ","");
                StringBuilder text = new StringBuilder(sentence);

                for (int i = 0; i < sentence.Length; i++)
                {
                    if (!YKNumericUtilities.IsNumeric(text[i].ToString()))
                    {
                        text.Remove(i, 1);
                    }
                }
                sentence = text.ToString();
            }
            return sentence;
        }
        public static string YKReFormat(string number)
        {
            number = YKOnlyDigits(number);
            if (number != "")
            {
                StringBuilder text = new StringBuilder(number);
                if (number.Length == 7 || number.Length == 10)
                {
                    if (number.Length == 7)
                    {
                        text.Insert(4, "-");
                    }
                    else if (number.Length == 10)
                    {
                        text.Insert(3, "-");
                        text.Insert(7, "-");
                    }
                }
                else if (number.Length == 5 || number.Length == 9)
                {
                    if (number.Length == 9)
                    {
                        text.Insert(5, "-");
                    }
                }
                else
                {
                    number = null;
                }
                number = text.ToString();
            }
           
            return number;
        }
        public static string YKFormatPostal(string postal)
        {
            postal = postal.Replace(" ", "");
            postal = postal.ToUpper();

            if (postal!="")
            {
                StringBuilder text = new StringBuilder(postal);
                text.Insert(3, " ");
                postal = text.ToString();
            }
            else
            {
                postal = null;
            }
            return postal;
        }
        public static string YKFullName(string firstName, string lastName)
        {
            string name;
            if(firstName == "" && lastName == "")
            {
                name = null;
            }
            else if (firstName != "" && lastName != "")
            {
                firstName = YKCapitalize(firstName);
                lastName = YKCapitalize(lastName);

                name = firstName + ", " + lastName;
            }
            else
            {
                firstName = YKCapitalize(firstName);
                lastName = YKCapitalize(lastName);

                name = firstName + lastName;
            }
            return name;
        }
        
    }
}
