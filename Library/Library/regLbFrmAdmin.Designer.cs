namespace Library
{
    partial class regstdadmin
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblregister = new System.Windows.Forms.Button();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.tbretype = new System.Windows.Forms.TextBox();
            this.lblretype = new System.Windows.Forms.Label();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.tbuser = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.tbadd = new System.Windows.Forms.TextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.LBLdob = new System.Windows.Forms.Label();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.lblgender = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Location = new System.Drawing.Point(95, 557);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 54);
            this.button1.TabIndex = 39;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblregister
            // 
            this.lblregister.BackColor = System.Drawing.Color.LightGreen;
            this.lblregister.Location = new System.Drawing.Point(350, 557);
            this.lblregister.Name = "lblregister";
            this.lblregister.Size = new System.Drawing.Size(144, 54);
            this.lblregister.TabIndex = 38;
            this.lblregister.Text = "Register";
            this.lblregister.UseVisualStyleBackColor = false;
            this.lblregister.Click += new System.EventHandler(this.lblregister_Click);
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(190, 328);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(281, 26);
            this.tbemail.TabIndex = 37;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(104, 334);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(51, 20);
            this.lblemail.TabIndex = 36;
            this.lblemail.Text = "email";
            // 
            // tbretype
            // 
            this.tbretype.Location = new System.Drawing.Point(187, 468);
            this.tbretype.Name = "tbretype";
            this.tbretype.PasswordChar = '#';
            this.tbretype.Size = new System.Drawing.Size(284, 26);
            this.tbretype.TabIndex = 35;
            // 
            // lblretype
            // 
            this.lblretype.AutoSize = true;
            this.lblretype.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblretype.Location = new System.Drawing.Point(54, 468);
            this.lblretype.Name = "lblretype";
            this.lblretype.Size = new System.Drawing.Size(110, 20);
            this.lblretype.TabIndex = 34;
            this.lblretype.Text = "Retype Pass";
            // 
            // tbpassword
            // 
            this.tbpassword.Location = new System.Drawing.Point(190, 401);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.PasswordChar = '#';
            this.tbpassword.Size = new System.Drawing.Size(281, 26);
            this.tbpassword.TabIndex = 33;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(78, 407);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(86, 20);
            this.lblpassword.TabIndex = 32;
            this.lblpassword.Text = "Password";
            // 
            // tbuser
            // 
            this.tbuser.Location = new System.Drawing.Point(193, 276);
            this.tbuser.Name = "tbuser";
            this.tbuser.Size = new System.Drawing.Size(281, 26);
            this.tbuser.TabIndex = 31;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(66, 282);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(98, 20);
            this.username.TabIndex = 30;
            this.username.Text = "User Name";
            // 
            // tbadd
            // 
            this.tbadd.Location = new System.Drawing.Point(193, 173);
            this.tbadd.Multiline = true;
            this.tbadd.Name = "tbadd";
            this.tbadd.Size = new System.Drawing.Size(281, 86);
            this.tbadd.TabIndex = 29;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(80, 198);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(75, 20);
            this.lbladdress.TabIndex = 28;
            this.lbladdress.Text = "Address";
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(190, 129);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(284, 26);
            this.dtp.TabIndex = 27;
            // 
            // LBLdob
            // 
            this.LBLdob.AutoSize = true;
            this.LBLdob.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLdob.Location = new System.Drawing.Point(80, 135);
            this.LBLdob.Name = "LBLdob";
            this.LBLdob.Size = new System.Drawing.Size(57, 20);
            this.LBLdob.TabIndex = 26;
            this.LBLdob.Text = "D.O.B";
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Location = new System.Drawing.Point(387, 83);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(87, 24);
            this.rbfemale.TabIndex = 25;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "Female";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.Location = new System.Drawing.Point(193, 79);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(68, 24);
            this.rbmale.TabIndex = 24;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "Male";
            this.rbmale.UseVisualStyleBackColor = true;
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(66, 83);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(69, 20);
            this.lblgender.TabIndex = 23;
            this.lblgender.Text = "Gender";
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(190, 29);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(284, 26);
            this.tbname.TabIndex = 22;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(80, 29);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(55, 20);
            this.lblname.TabIndex = 21;
            this.lblname.Text = "Name";
            // 
            // regstdadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(605, 648);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblregister);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.tbretype);
            this.Controls.Add(this.lblretype);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.tbuser);
            this.Controls.Add(this.username);
            this.Controls.Add(this.tbadd);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.LBLdob);
            this.Controls.Add(this.rbfemale);
            this.Controls.Add(this.rbmale);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.lblname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "regstdadmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button lblregister;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox tbretype;
        private System.Windows.Forms.Label lblretype;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox tbuser;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox tbadd;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label LBLdob;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label lblname;
    }
}