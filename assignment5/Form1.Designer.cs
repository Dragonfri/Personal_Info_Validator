namespace assignment5
{
    partial class frmInformation
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblCanadaPostal = new System.Windows.Forms.Label();
            this.txtCanadaPostal = new System.Windows.Forms.TextBox();
            this.lblUSPostal = new System.Windows.Forms.Label();
            this.txtUSPostal = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCorrect = new System.Windows.Forms.Button();
            this.btnWrong = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblCanadaPostal_result = new System.Windows.Forms.Label();
            this.lblUSPostal_result = new System.Windows.Forms.Label();
            this.lblPhoneNumber_result = new System.Windows.Forms.Label();
            this.gbxAge = new System.Windows.Forms.GroupBox();
            this.rbtInt = new System.Windows.Forms.RadioButton();
            this.rbtString = new System.Windows.Forms.RadioButton();
            this.gbxAge.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(78, 54);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(247, 54);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(78, 97);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(54, 13);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Full Name";
            // 
            // txtFullName
            // 
            this.txtFullName.AutoSize = true;
            this.txtFullName.Location = new System.Drawing.Point(141, 97);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(0, 13);
            this.txtFullName.TabIndex = 3;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(105, 179);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Age";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(145, 47);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(86, 20);
            this.txtFirstName.TabIndex = 5;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(310, 47);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(86, 20);
            this.txtLastName.TabIndex = 6;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(146, 176);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(86, 20);
            this.txtAge.TabIndex = 7;
            // 
            // lblCanadaPostal
            // 
            this.lblCanadaPostal.AutoSize = true;
            this.lblCanadaPostal.Location = new System.Drawing.Point(25, 219);
            this.lblCanadaPostal.Name = "lblCanadaPostal";
            this.lblCanadaPostal.Size = new System.Drawing.Size(104, 13);
            this.lblCanadaPostal.TabIndex = 8;
            this.lblCanadaPostal.Text = "Canada Postal Code";
            // 
            // txtCanadaPostal
            // 
            this.txtCanadaPostal.Location = new System.Drawing.Point(146, 214);
            this.txtCanadaPostal.Name = "txtCanadaPostal";
            this.txtCanadaPostal.Size = new System.Drawing.Size(86, 20);
            this.txtCanadaPostal.TabIndex = 9;
            // 
            // lblUSPostal
            // 
            this.lblUSPostal.AutoSize = true;
            this.lblUSPostal.Location = new System.Drawing.Point(48, 264);
            this.lblUSPostal.Name = "lblUSPostal";
            this.lblUSPostal.Size = new System.Drawing.Size(82, 13);
            this.lblUSPostal.TabIndex = 10;
            this.lblUSPostal.Text = "US Postal Code";
            // 
            // txtUSPostal
            // 
            this.txtUSPostal.Location = new System.Drawing.Point(146, 261);
            this.txtUSPostal.Name = "txtUSPostal";
            this.txtUSPostal.Size = new System.Drawing.Size(86, 20);
            this.txtUSPostal.TabIndex = 11;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(51, 310);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneNumber.TabIndex = 12;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(146, 307);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(86, 20);
            this.txtPhoneNumber.TabIndex = 13;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(148, 373);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(93, 25);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCorrect
            // 
            this.btnCorrect.Location = new System.Drawing.Point(264, 373);
            this.btnCorrect.Name = "btnCorrect";
            this.btnCorrect.Size = new System.Drawing.Size(90, 25);
            this.btnCorrect.TabIndex = 15;
            this.btnCorrect.Text = "Correct(Debug)";
            this.btnCorrect.UseVisualStyleBackColor = true;
            this.btnCorrect.Click += new System.EventHandler(this.btnCorrect_Click);
            // 
            // btnWrong
            // 
            this.btnWrong.Location = new System.Drawing.Point(377, 373);
            this.btnWrong.Name = "btnWrong";
            this.btnWrong.Size = new System.Drawing.Size(95, 25);
            this.btnWrong.TabIndex = 16;
            this.btnWrong.Text = "Wrong(Debug)";
            this.btnWrong.UseVisualStyleBackColor = true;
            this.btnWrong.Click += new System.EventHandler(this.btnWrong_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(368, 139);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 17;
            // 
            // lblCanadaPostal_result
            // 
            this.lblCanadaPostal_result.AutoSize = true;
            this.lblCanadaPostal_result.Location = new System.Drawing.Point(247, 221);
            this.lblCanadaPostal_result.Name = "lblCanadaPostal_result";
            this.lblCanadaPostal_result.Size = new System.Drawing.Size(0, 13);
            this.lblCanadaPostal_result.TabIndex = 19;
            // 
            // lblUSPostal_result
            // 
            this.lblUSPostal_result.AutoSize = true;
            this.lblUSPostal_result.Location = new System.Drawing.Point(247, 261);
            this.lblUSPostal_result.Name = "lblUSPostal_result";
            this.lblUSPostal_result.Size = new System.Drawing.Size(0, 13);
            this.lblUSPostal_result.TabIndex = 20;
            // 
            // lblPhoneNumber_result
            // 
            this.lblPhoneNumber_result.AutoSize = true;
            this.lblPhoneNumber_result.Location = new System.Drawing.Point(247, 310);
            this.lblPhoneNumber_result.Name = "lblPhoneNumber_result";
            this.lblPhoneNumber_result.Size = new System.Drawing.Size(0, 13);
            this.lblPhoneNumber_result.TabIndex = 21;
            // 
            // gbxAge
            // 
            this.gbxAge.Controls.Add(this.rbtString);
            this.gbxAge.Controls.Add(this.rbtInt);
            this.gbxAge.Location = new System.Drawing.Point(72, 127);
            this.gbxAge.Name = "gbxAge";
            this.gbxAge.Size = new System.Drawing.Size(160, 43);
            this.gbxAge.TabIndex = 22;
            this.gbxAge.TabStop = false;
            this.gbxAge.Text = "Datatype";
            // 
            // rbtInt
            // 
            this.rbtInt.AutoSize = true;
            this.rbtInt.Location = new System.Drawing.Point(9, 20);
            this.rbtInt.Name = "rbtInt";
            this.rbtInt.Size = new System.Drawing.Size(58, 17);
            this.rbtInt.TabIndex = 0;
            this.rbtInt.TabStop = true;
            this.rbtInt.Text = "Integer";
            this.rbtInt.UseVisualStyleBackColor = true;
            // 
            // rbtString
            // 
            this.rbtString.AutoSize = true;
            this.rbtString.Location = new System.Drawing.Point(101, 20);
            this.rbtString.Name = "rbtString";
            this.rbtString.Size = new System.Drawing.Size(52, 17);
            this.rbtString.TabIndex = 1;
            this.rbtString.TabStop = true;
            this.rbtString.Text = "String";
            this.rbtString.UseVisualStyleBackColor = true;
            // 
            // frmInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 439);
            this.Controls.Add(this.gbxAge);
            this.Controls.Add(this.lblPhoneNumber_result);
            this.Controls.Add(this.lblUSPostal_result);
            this.Controls.Add(this.lblCanadaPostal_result);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnWrong);
            this.Controls.Add(this.btnCorrect);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtUSPostal);
            this.Controls.Add(this.lblUSPostal);
            this.Controls.Add(this.txtCanadaPostal);
            this.Controls.Add(this.lblCanadaPostal);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "frmInformation";
            this.Text = "Personal Information";
            this.gbxAge.ResumeLayout(false);
            this.gbxAge.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label txtFullName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblCanadaPostal;
        private System.Windows.Forms.TextBox txtCanadaPostal;
        private System.Windows.Forms.Label lblUSPostal;
        private System.Windows.Forms.TextBox txtUSPostal;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCorrect;
        private System.Windows.Forms.Button btnWrong;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblCanadaPostal_result;
        private System.Windows.Forms.Label lblUSPostal_result;
        private System.Windows.Forms.Label lblPhoneNumber_result;
        private System.Windows.Forms.GroupBox gbxAge;
        private System.Windows.Forms.RadioButton rbtString;
        private System.Windows.Forms.RadioButton rbtInt;
    }
}

