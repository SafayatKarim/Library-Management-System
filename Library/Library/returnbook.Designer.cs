﻿namespace Library
{
    partial class returnbook
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tbbnrb = new System.Windows.Forms.Label();
            this.tbunamerb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbbookid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbbbbb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbbnissue = new System.Windows.Forms.TextBox();
            this.dcjnkjcnjc = new System.Windows.Forms.Label();
            this.tbsidrb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.stdnamerb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbqunrb = new System.Windows.Forms.TextBox();
            this.tttttttttt = new System.Windows.Forms.TextBox();
            this.View = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtgvissue = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbrbookqn = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbreturn = new System.Windows.Forms.DateTimePicker();
            this.tbtoday = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvissue)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.SlateBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gold;
            this.button1.Location = new System.Drawing.Point(523, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(768, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 32);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.Location = new System.Drawing.Point(1101, 7);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 38);
            this.textBox2.TabIndex = 4;
            // 
            // tbbnrb
            // 
            this.tbbnrb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbbnrb.AutoSize = true;
            this.tbbnrb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbbnrb.ForeColor = System.Drawing.Color.DarkRed;
            this.tbbnrb.Location = new System.Drawing.Point(648, 6);
            this.tbbnrb.Name = "tbbnrb";
            this.tbbnrb.Size = new System.Drawing.Size(114, 25);
            this.tbbnrb.TabIndex = 5;
            this.tbbnrb.Text = "Book Name";
            // 
            // tbunamerb
            // 
            this.tbunamerb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbunamerb.AutoSize = true;
            this.tbunamerb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbunamerb.ForeColor = System.Drawing.Color.DarkBlue;
            this.tbunamerb.Location = new System.Drawing.Point(961, 12);
            this.tbunamerb.Name = "tbunamerb";
            this.tbunamerb.Size = new System.Drawing.Size(110, 25);
            this.tbunamerb.TabIndex = 6;
            this.tbunamerb.Text = "User Name";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(55, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Book ID";
            // 
            // tbbookid
            // 
            this.tbbookid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbbookid.Location = new System.Drawing.Point(242, 57);
            this.tbbookid.Multiline = true;
            this.tbbookid.Name = "tbbookid";
            this.tbbookid.ReadOnly = true;
            this.tbbookid.Size = new System.Drawing.Size(188, 30);
            this.tbbookid.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(53, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Issue ID";
            // 
            // tbbbbb
            // 
            this.tbbbbb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbbbbb.Location = new System.Drawing.Point(242, 13);
            this.tbbbbb.Multiline = true;
            this.tbbbbb.Name = "tbbbbb";
            this.tbbbbb.ReadOnly = true;
            this.tbbbbb.Size = new System.Drawing.Size(188, 29);
            this.tbbbbb.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(53, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Book Name";
            // 
            // tbbnissue
            // 
            this.tbbnissue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbbnissue.Location = new System.Drawing.Point(242, 102);
            this.tbbnissue.Multiline = true;
            this.tbbnissue.Name = "tbbnissue";
            this.tbbnissue.ReadOnly = true;
            this.tbbnissue.Size = new System.Drawing.Size(188, 29);
            this.tbbnissue.TabIndex = 13;
            // 
            // dcjnkjcnjc
            // 
            this.dcjnkjcnjc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dcjnkjcnjc.AutoSize = true;
            this.dcjnkjcnjc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dcjnkjcnjc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dcjnkjcnjc.Location = new System.Drawing.Point(53, 149);
            this.dcjnkjcnjc.Name = "dcjnkjcnjc";
            this.dcjnkjcnjc.Size = new System.Drawing.Size(94, 22);
            this.dcjnkjcnjc.TabIndex = 12;
            this.dcjnkjcnjc.Text = "Student ID";
            // 
            // tbsidrb
            // 
            this.tbsidrb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbsidrb.Location = new System.Drawing.Point(242, 149);
            this.tbsidrb.Multiline = true;
            this.tbsidrb.Name = "tbsidrb";
            this.tbsidrb.ReadOnly = true;
            this.tbsidrb.Size = new System.Drawing.Size(188, 29);
            this.tbsidrb.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(53, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 22);
            this.label5.TabIndex = 22;
            this.label5.Text = "Return Date";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(54, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 22);
            this.label6.TabIndex = 20;
            this.label6.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(53, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 22);
            this.label7.TabIndex = 18;
            this.label7.Text = "Student Name";
            // 
            // stdnamerb
            // 
            this.stdnamerb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.stdnamerb.Location = new System.Drawing.Point(242, 197);
            this.stdnamerb.Multiline = true;
            this.stdnamerb.Name = "stdnamerb";
            this.stdnamerb.ReadOnly = true;
            this.stdnamerb.Size = new System.Drawing.Size(188, 29);
            this.stdnamerb.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(53, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "Issue Date";
            // 
            // tbqunrb
            // 
            this.tbqunrb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbqunrb.Location = new System.Drawing.Point(242, 244);
            this.tbqunrb.Multiline = true;
            this.tbqunrb.Name = "tbqunrb";
            this.tbqunrb.ReadOnly = true;
            this.tbqunrb.Size = new System.Drawing.Size(188, 29);
            this.tbqunrb.TabIndex = 15;
            // 
            // tttttttttt
            // 
            this.tttttttttt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tttttttttt.Location = new System.Drawing.Point(242, 339);
            this.tttttttttt.Multiline = true;
            this.tttttttttt.Name = "tttttttttt";
            this.tttttttttt.ReadOnly = true;
            this.tttttttttt.Size = new System.Drawing.Size(271, 32);
            this.tttttttttt.TabIndex = 24;
            // 
            // View
            // 
            this.View.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.View.BackColor = System.Drawing.Color.DimGray;
            this.View.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View.ForeColor = System.Drawing.Color.Chartreuse;
            this.View.Location = new System.Drawing.Point(126, 2);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(149, 50);
            this.View.TabIndex = 25;
            this.View.Text = "View Issues";
            this.View.UseVisualStyleBackColor = false;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(297, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 52);
            this.button2.TabIndex = 26;
            this.button2.Text = "Return";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtgvissue
            // 
            this.dtgvissue.AllowUserToAddRows = false;
            this.dtgvissue.AllowUserToDeleteRows = false;
            this.dtgvissue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvissue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvissue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvissue.Location = new System.Drawing.Point(539, 66);
            this.dtgvissue.Name = "dtgvissue";
            this.dtgvissue.ReadOnly = true;
            this.dtgvissue.RowTemplate.Height = 28;
            this.dtgvissue.Size = new System.Drawing.Size(747, 561);
            this.dtgvissue.TabIndex = 27;
            this.dtgvissue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvissue_CellClick);
            this.dtgvissue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvissue_CellContentClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Blue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Yellow;
            this.button3.Location = new System.Drawing.Point(-1, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 49);
            this.button3.TabIndex = 28;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(53, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 22);
            this.label4.TabIndex = 30;
            this.label4.Text = "Returned Book";
            // 
            // tbrbookqn
            // 
            this.tbrbookqn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbrbookqn.Location = new System.Drawing.Point(242, 290);
            this.tbrbookqn.Multiline = true;
            this.tbrbookqn.Name = "tbrbookqn";
            this.tbrbookqn.Size = new System.Drawing.Size(188, 29);
            this.tbrbookqn.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.tbreturn);
            this.panel1.Controls.Add(this.tbtoday);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tbbbbb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbbookid);
            this.panel1.Controls.Add(this.tbrbookqn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbsidrb);
            this.panel1.Controls.Add(this.dcjnkjcnjc);
            this.panel1.Controls.Add(this.tbbnissue);
            this.panel1.Controls.Add(this.tttttttttt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbqunrb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.stdnamerb);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(-1, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 575);
            this.panel1.TabIndex = 31;
            // 
            // tbreturn
            // 
            this.tbreturn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbreturn.Location = new System.Drawing.Point(242, 388);
            this.tbreturn.Name = "tbreturn";
            this.tbreturn.Size = new System.Drawing.Size(271, 26);
            this.tbreturn.TabIndex = 33;
            // 
            // tbtoday
            // 
            this.tbtoday.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbtoday.Location = new System.Drawing.Point(242, 438);
            this.tbtoday.Name = "tbtoday";
            this.tbtoday.Size = new System.Drawing.Size(271, 26);
            this.tbtoday.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(54, 444);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 22);
            this.label9.TabIndex = 31;
            this.label9.Text = "Today";
            // 
            // returnbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1298, 634);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvissue);
            this.Controls.Add(this.View);
            this.Controls.Add(this.tbunamerb);
            this.Controls.Add(this.tbbnrb);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "returnbook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retun Book HomePage";
            this.Load += new System.EventHandler(this.returnbook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvissue)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label tbbnrb;
        private System.Windows.Forms.Label tbunamerb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbbookid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbbbbb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbbnissue;
        private System.Windows.Forms.Label dcjnkjcnjc;
        private System.Windows.Forms.TextBox tbsidrb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox stdnamerb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbqunrb;
        private System.Windows.Forms.TextBox tttttttttt;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dtgvissue;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbrbookqn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker tbtoday;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker tbreturn;
    }
}