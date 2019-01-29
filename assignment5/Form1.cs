/*
 Form Name: Personal Information
 Purpose: Validate and manipulate input strings
 Written by Young Geun, Kim(Andrew) April 20, 2018
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YKUtilities;

namespace assignment5
{
    public partial class frmInformation : Form
    {
        public frmInformation()
        {
            InitializeComponent();
        }
        private void ClearFields()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAge.Text = "";
            txtCanadaPostal.Text = "";
            txtUSPostal.Text = "";
            txtPhoneNumber.Text = "";
            txtFullName.Text = "";
            lblError.Text = "";
            lblCanadaPostal_result.Text = "";
            lblUSPostal_result.Text = "";
            lblPhoneNumber_result.Text = "";
        }
        private void btnCorrect_Click(object sender, EventArgs e)
        {
            ClearFields();
            txtFirstName.Text = "andrew";
            txtLastName.Text = "kim";
            txtAge.Text = "23";
            txtCanadaPostal.Text = "N0P0C7";
            txtUSPostal.Text = "123456789";
            txtPhoneNumber.Text = "6418914004";
        }

        private void btnWrong_Click(object sender, EventArgs e)
        {
            ClearFields();
            txtFirstName.Text = "andrew";
            txtLastName.Text = "kim";
            txtAge.Text = "2c";
            txtCanadaPostal.Text = "n2p0o7";
            txtUSPostal.Text = "12345678";
            txtPhoneNumber.Text = "641891400";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string errorMessage="";

            /*
             YKFullName(string1, string2) return string
                combine firstname and lastname then makes it to full name format
             */
            txtFullName.Text=YKStringUtilities.YKFullName
                (txtFirstName.Text, txtLastName.Text);
            if (txtFullName.Text == "")
            {
                errorMessage += "Please input FirstName, LastName or Both\n";
            }
            /*
             IsInteger(string) return bool
                Check the string is Integer or not, by regex

             IsInteger(int) return bool
                Check the string is Integer or not, by regex
             */

            if (rbtInt.Checked)
            {
                int age;
                if (int.TryParse(txtAge.Text, out age))
                {
                    if (!YKNumericUtilities.IsInteger(age))
                    {
                        errorMessage += "Age is Invalid\n";
                    }
                }
                else if (!YKNumericUtilities.IsInteger(txtAge.Text))
                {
                    errorMessage += "Age is Invalid\n";
                }
            }
            else if(rbtString.Checked)
            {
                if (!YKNumericUtilities.IsInteger(txtAge.Text))
                {
                    errorMessage += "Age is Invalid\n";
                }
            }
            else
            {
                errorMessage += "Choose the radio button for Age DataType\n";
            }


            /*
                YKCanadaPostal(string) return bool
                    Check the string is CanadaPostal Code format or not, by regex

                YKFormatPostal(string) return string
                    Reformat string to CanadaPostal Code format.
             */
            if (!YKValidations.YKCanadaPostal(txtCanadaPostal.Text))
            {
                errorMessage += "Canada Postal Code is Invalid\n";
            }
            else
            {
                lblCanadaPostal_result.Text = YKStringUtilities.YKFormatPostal
                    (txtCanadaPostal.Text);
            }


            /*YKUSPostal(string) return bool
                Extract digits by YKOnlyDigits then chech the length is 5 or 9

              YKOnlyDigits(string) return string
                Extract digits from string*/
            if (!YKValidations.YKUSPostal(txtUSPostal.Text))
            {
                errorMessage += "US Postal Code is Invalid\n";
            }
            else
            {
                lblUSPostal_result.Text = YKStringUtilities.YKOnlyDigits
                    (txtUSPostal.Text);
                lblUSPostal_result.Text = YKStringUtilities.YKReFormat
                    (lblUSPostal_result.Text);
            }


            /*YKPhoneNumber(string) return bool 
                Extract digits by YKOnlyDigits then chech the length is 10 or not

              YKOnlyDigits(string) return string
                Extract digits from string

              YKReFormat(string) return string
                if the string is length of 10, reformat it to PhoneNumber format*/
            if (!YKValidations.YKPhoneNumber(txtPhoneNumber.Text))
            {
                errorMessage += "Phone Number is Invalid\n";
            }
            else
            {
                lblPhoneNumber_result.Text = YKStringUtilities.YKOnlyDigits
                    (txtPhoneNumber.Text);
                lblPhoneNumber_result.Text = YKStringUtilities.YKReFormat
                    (txtPhoneNumber.Text);
            }


            /*Print ERROR MESSAGE when the errorMessage is not empty*/
            if (errorMessage == "")
            {
                lblError.Text = "Successfully Submitted!\n";
            }
            else
            {
                lblError.Text = errorMessage;
            }
        }


    }
}
