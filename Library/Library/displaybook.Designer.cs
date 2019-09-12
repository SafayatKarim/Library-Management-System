namespace Library
{
    partial class displaybook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bookadmin = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tbid = new System.Windows.Forms.TextBox();
            this.lblqun = new System.Windows.Forms.Label();
            this.lbldept = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblauthor = new System.Windows.Forms.Label();
            this.lbledition = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbqun = new System.Windows.Forms.TextBox();
            this.tbdept = new System.Windows.Forms.TextBox();
            this.tbtile = new System.Windows.Forms.TextBox();
            this.tbauthor = new System.Windows.Forms.TextBox();
            this.tbedition = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnfilter = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblbn = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bookadmin)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookadmin
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bookadmin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bookadmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookadmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookadmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookadmin.Location = new System.Drawing.Point(549, 12);
            this.bookadmin.Name = "bookadmin";
            this.bookadmin.RowTemplate.Height = 28;
            this.bookadmin.Size = new System.Drawing.Size(759, 654);
            this.bookadmin.TabIndex = 0;
            this.bookadmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookadmin_CellClick);
            this.bookadmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookadmin_CellContentClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(460, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Fixed";
            // 
            // tbid
            // 
            this.tbid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbid.Location = new System.Drawing.Point(336, 97);
            this.tbid.Name = "tbid";
            this.tbid.ReadOnly = true;
            this.tbid.Size = new System.Drawing.Size(100, 26);
            this.tbid.TabIndex = 28;
            // 
            // lblqun
            // 
            this.lblqun.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblqun.AutoSize = true;
            this.lblqun.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblqun.Location = new System.Drawing.Point(206, 468);
            this.lblqun.Name = "lblqun";
            this.lblqun.Size = new System.Drawing.Size(68, 20);
            this.lblqun.TabIndex = 27;
            this.lblqun.Text = "Quantity";
            // 
            // lbldept
            // 
            this.lbldept.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbldept.AutoSize = true;
            this.lbldept.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbldept.Location = new System.Drawing.Point(206, 401);
            this.lbldept.Name = "lbldept";
            this.lbldept.Size = new System.Drawing.Size(91, 20);
            this.lbldept.TabIndex = 26;
            this.lbldept.Text = "department";
            // 
            // lbltitle
            // 
            this.lbltitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbltitle.AutoSize = true;
            this.lbltitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbltitle.Location = new System.Drawing.Point(206, 350);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(38, 20);
            this.lbltitle.TabIndex = 25;
            this.lbltitle.Text = "Title";
            // 
            // lblauthor
            // 
            this.lblauthor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblauthor.AutoSize = true;
            this.lblauthor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblauthor.Location = new System.Drawing.Point(206, 288);
            this.lblauthor.Name = "lblauthor";
            this.lblauthor.Size = new System.Drawing.Size(57, 20);
            this.lblauthor.TabIndex = 24;
            this.lblauthor.Text = "Author";
            // 
            // lbledition
            // 
            this.lbledition.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbledition.AutoSize = true;
            this.lbledition.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbledition.Location = new System.Drawing.Point(206, 211);
            this.lbledition.Name = "lbledition";
            this.lbledition.Size = new System.Drawing.Size(58, 20);
            this.lbledition.TabIndex = 23;
            this.lbledition.Text = "Edition";
            // 
            // lblname
            // 
            this.lblname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblname.AutoSize = true;
            this.lblname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblname.Location = new System.Drawing.Point(206, 153);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(51, 20);
            this.lblname.TabIndex = 22;
            this.lblname.Text = "Name";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(206, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Book ID";
            // 
            // tbqun
            // 
            this.tbqun.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbqun.Location = new System.Drawing.Point(336, 468);
            this.tbqun.Name = "tbqun";
            this.tbqun.Size = new System.Drawing.Size(100, 26);
            this.tbqun.TabIndex = 20;
            // 
            // tbdept
            // 
            this.tbdept.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbdept.Location = new System.Drawing.Point(336, 408);
            this.tbdept.Name = "tbdept";
            this.tbdept.Size = new System.Drawing.Size(100, 26);
            this.tbdept.TabIndex = 19;
            // 
            // tbtile
            // 
            this.tbtile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbtile.Location = new System.Drawing.Point(336, 344);
            this.tbtile.Name = "tbtile";
            this.tbtile.Size = new System.Drawing.Size(100, 26);
            this.tbtile.TabIndex = 18;
            // 
            // tbauthor
            // 
            this.tbauthor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbauthor.Location = new System.Drawing.Point(336, 282);
            this.tbauthor.Name = "tbauthor";
            this.tbauthor.Size = new System.Drawing.Size(100, 26);
            this.tbauthor.TabIndex = 17;
            // 
            // tbedition
            // 
            this.tbedition.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbedition.Location = new System.Drawing.Point(336, 208);
            this.tbedition.Name = "tbedition";
            this.tbedition.Size = new System.Drawing.Size(100, 26);
            this.tbedition.TabIndex = 16;
            // 
            // tbname
            // 
            this.tbname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbname.Location = new System.Drawing.Point(336, 147);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(100, 26);
            this.tbname.TabIndex = 15;
            // 
            // btnupdate
            // 
            this.btnupdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnupdate.BackColor = System.Drawing.Color.Lime;
            this.btnupdate.Location = new System.Drawing.Point(348, 577);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(150, 51);
            this.btnupdate.TabIndex = 14;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.Location = new System.Drawing.Point(29, 580);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 48);
            this.button2.TabIndex = 13;
            this.button2.Text = "View Books";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btndelete
            // 
            this.btndelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btndelete.BackColor = System.Drawing.Color.CadetBlue;
            this.btndelete.Location = new System.Drawing.Point(210, 589);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(113, 39);
            this.btndelete.TabIndex = 12;
            this.btndelete.Text = "Delete Book";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnfilter
            // 
            this.btnfilter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnfilter.BackColor = System.Drawing.Color.Aqua;
            this.btnfilter.Location = new System.Drawing.Point(23, 382);
            this.btnfilter.Name = "btnfilter";
            this.btnfilter.Size = new System.Drawing.Size(113, 39);
            this.btnfilter.TabIndex = 11;
            this.btnfilter.Text = "Filter book";
            this.btnfilter.UseVisualStyleBackColor = false;
            this.btnfilter.Click += new System.EventHandler(this.btnfilter_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CS",
            "EEE",
            "BBA",
            "LAW",
            "Arch",
            "Math",
            "Science"});
            this.comboBox1.Location = new System.Drawing.Point(23, 441);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 28);
            this.comboBox1.TabIndex = 8;
            // 
            // lblbn
            // 
            this.lblbn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblbn.AutoSize = true;
            this.lblbn.BackColor = System.Drawing.Color.White;
            this.lblbn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblbn.Location = new System.Drawing.Point(25, 260);
            this.lblbn.Name = "lblbn";
            this.lblbn.Size = new System.Drawing.Size(114, 20);
            this.lblbn.TabIndex = 5;
            this.lblbn.Text = "By Book Name";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.Location = new System.Drawing.Point(26, 214);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 26);
            this.textBox1.TabIndex = 4;
            // 
            // btnsearch
            // 
            this.btnsearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnsearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnsearch.Location = new System.Drawing.Point(26, 164);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(113, 39);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(419, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Blue;
            this.btnBack.Location = new System.Drawing.Point(11, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(79, 39);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lblqun);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.tbid);
            this.panel1.Controls.Add(this.tbqun);
            this.panel1.Controls.Add(this.lbldept);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.lbltitle);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.lblauthor);
            this.panel1.Controls.Add(this.btnsearch);
            this.panel1.Controls.Add(this.lbledition);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Controls.Add(this.lblbn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.tbdept);
            this.panel1.Controls.Add(this.tbtile);
            this.panel1.Controls.Add(this.btnfilter);
            this.panel1.Controls.Add(this.tbauthor);
            this.panel1.Controls.Add(this.tbname);
            this.panel1.Controls.Add(this.tbedition);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 686);
            this.panel1.TabIndex = 30;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // displaybook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1320, 690);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bookadmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "displaybook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book";
            this.Load += new System.EventHandler(this.displaybook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookadmin)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bookadmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.Label lblqun;
        private System.Windows.Forms.Label lbldept;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblauthor;
        private System.Windows.Forms.Label lbledition;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbqun;
        private System.Windows.Forms.TextBox tbdept;
        private System.Windows.Forms.TextBox tbtile;
        private System.Windows.Forms.TextBox tbauthor;
        private System.Windows.Forms.TextBox tbedition;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnfilter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblbn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
    }
}