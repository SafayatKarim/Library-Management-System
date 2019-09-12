namespace Library
{
    partial class fineshow
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
            this.showfine = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbfid = new System.Windows.Forms.TextBox();
            this.tbstdid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbstdname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbbookqn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbbookname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbbid = new System.Windows.Forms.TextBox();
            this.tbbookid = new System.Windows.Forms.Label();
            this.tbfine = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rbyes = new System.Windows.Forms.RadioButton();
            this.rbno = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.showfine)).BeginInit();
            this.SuspendLayout();
            // 
            // showfine
            // 
            this.showfine.AllowUserToAddRows = false;
            this.showfine.AllowUserToDeleteRows = false;
            this.showfine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showfine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.showfine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showfine.Location = new System.Drawing.Point(426, 63);
            this.showfine.Name = "showfine";
            this.showfine.ReadOnly = true;
            this.showfine.RowTemplate.Height = 28;
            this.showfine.Size = new System.Drawing.Size(620, 565);
            this.showfine.TabIndex = 0;
            this.showfine.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showfine_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(21, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Aqua;
            this.button2.Location = new System.Drawing.Point(175, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fine Id";
            // 
            // tbfid
            // 
            this.tbfid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbfid.Location = new System.Drawing.Point(144, 92);
            this.tbfid.Name = "tbfid";
            this.tbfid.ReadOnly = true;
            this.tbfid.Size = new System.Drawing.Size(123, 26);
            this.tbfid.TabIndex = 4;
            // 
            // tbstdid
            // 
            this.tbstdid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbstdid.Location = new System.Drawing.Point(144, 136);
            this.tbstdid.Name = "tbstdid";
            this.tbstdid.ReadOnly = true;
            this.tbstdid.Size = new System.Drawing.Size(123, 26);
            this.tbstdid.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Student id";
            // 
            // tbstdname
            // 
            this.tbstdname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbstdname.Location = new System.Drawing.Point(144, 182);
            this.tbstdname.Name = "tbstdname";
            this.tbstdname.ReadOnly = true;
            this.tbstdname.Size = new System.Drawing.Size(123, 26);
            this.tbstdname.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Student Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbbookqn
            // 
            this.tbbookqn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbbookqn.Location = new System.Drawing.Point(144, 331);
            this.tbbookqn.Name = "tbbookqn";
            this.tbbookqn.ReadOnly = true;
            this.tbbookqn.Size = new System.Drawing.Size(123, 26);
            this.tbbookqn.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Book Quantity";
            // 
            // tbbookname
            // 
            this.tbbookname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbbookname.Location = new System.Drawing.Point(144, 280);
            this.tbbookname.Name = "tbbookname";
            this.tbbookname.ReadOnly = true;
            this.tbbookname.Size = new System.Drawing.Size(123, 26);
            this.tbbookname.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Book Name";
            // 
            // tbbid
            // 
            this.tbbid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbbid.Location = new System.Drawing.Point(144, 228);
            this.tbbid.Name = "tbbid";
            this.tbbid.ReadOnly = true;
            this.tbbid.Size = new System.Drawing.Size(123, 26);
            this.tbbid.TabIndex = 10;
            // 
            // tbbookid
            // 
            this.tbbookid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbbookid.AutoSize = true;
            this.tbbookid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbbookid.Location = new System.Drawing.Point(17, 232);
            this.tbbookid.Name = "tbbookid";
            this.tbbookid.Size = new System.Drawing.Size(70, 22);
            this.tbbookid.TabIndex = 9;
            this.tbbookid.Text = "Book id";
            // 
            // tbfine
            // 
            this.tbfine.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbfine.Location = new System.Drawing.Point(144, 378);
            this.tbfine.Name = "tbfine";
            this.tbfine.ReadOnly = true;
            this.tbfine.Size = new System.Drawing.Size(123, 26);
            this.tbfine.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fine";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(270, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 22);
            this.label7.TabIndex = 17;
            this.label7.Text = "BDT";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 432);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 22);
            this.label9.TabIndex = 18;
            this.label9.Text = "Paid";
            // 
            // rbyes
            // 
            this.rbyes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbyes.AutoSize = true;
            this.rbyes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbyes.Location = new System.Drawing.Point(131, 430);
            this.rbyes.Name = "rbyes";
            this.rbyes.Size = new System.Drawing.Size(62, 24);
            this.rbyes.TabIndex = 19;
            this.rbyes.TabStop = true;
            this.rbyes.Text = "Yes";
            this.rbyes.UseVisualStyleBackColor = true;
            // 
            // rbno
            // 
            this.rbno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbno.AutoSize = true;
            this.rbno.ForeColor = System.Drawing.Color.Red;
            this.rbno.Location = new System.Drawing.Point(213, 432);
            this.rbno.Name = "rbno";
            this.rbno.Size = new System.Drawing.Size(54, 24);
            this.rbno.TabIndex = 20;
            this.rbno.TabStop = true;
            this.rbno.Text = "No";
            this.rbno.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(131, 492);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 57);
            this.button3.TabIndex = 21;
            this.button3.Text = "Confirm";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(899, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 39);
            this.button4.TabIndex = 22;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // fineshow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1058, 640);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.rbno);
            this.Controls.Add(this.rbyes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbfine);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbbookqn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbbookname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbbid);
            this.Controls.Add(this.tbbookid);
            this.Controls.Add(this.tbstdname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbstdid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbfid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showfine);
            this.Name = "fineshow";
            this.Text = "Fine Home";
            ((System.ComponentModel.ISupportInitialize)(this.showfine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView showfine;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbfid;
        private System.Windows.Forms.TextBox tbstdid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbstdname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbbookqn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbbookname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbbid;
        private System.Windows.Forms.Label tbbookid;
        private System.Windows.Forms.TextBox tbfine;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbyes;
        private System.Windows.Forms.RadioButton rbno;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}