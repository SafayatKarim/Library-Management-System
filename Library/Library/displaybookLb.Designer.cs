namespace Library
{
    partial class disbooklib
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.disbooklibbb = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnfilter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblbn = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
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
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.disbooklibbb)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // disbooklibbb
            // 
            this.disbooklibbb.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.disbooklibbb.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.disbooklibbb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.disbooklibbb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.disbooklibbb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disbooklibbb.Location = new System.Drawing.Point(462, 12);
            this.disbooklibbb.Name = "disbooklibbb";
            this.disbooklibbb.RowTemplate.Height = 28;
            this.disbooklibbb.Size = new System.Drawing.Size(835, 610);
            this.disbooklibbb.TabIndex = 1;
            this.disbooklibbb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.disbooklibbb_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Lime;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(79, 39);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.Location = new System.Drawing.Point(2, 530);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 52);
            this.button2.TabIndex = 22;
            this.button2.Text = "View Books";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btndelete
            // 
            this.btndelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btndelete.BackColor = System.Drawing.Color.Yellow;
            this.btndelete.Location = new System.Drawing.Point(148, 530);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(125, 51);
            this.btndelete.TabIndex = 21;
            this.btndelete.Text = "Delete Book";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnfilter
            // 
            this.btnfilter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnfilter.BackColor = System.Drawing.Color.Aqua;
            this.btnfilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfilter.Location = new System.Drawing.Point(2, 343);
            this.btnfilter.Name = "btnfilter";
            this.btnfilter.Size = new System.Drawing.Size(113, 39);
            this.btnfilter.TabIndex = 20;
            this.btnfilter.Text = "Filter book";
            this.btnfilter.UseVisualStyleBackColor = false;
            this.btnfilter.Click += new System.EventHandler(this.btnfilter_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(-4, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "By Book Name";
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
            this.comboBox1.Location = new System.Drawing.Point(2, 401);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(127, 28);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblbn
            // 
            this.lblbn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblbn.AutoSize = true;
            this.lblbn.BackColor = System.Drawing.Color.White;
            this.lblbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbn.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblbn.Location = new System.Drawing.Point(3, 233);
            this.lblbn.Name = "lblbn";
            this.lblbn.Size = new System.Drawing.Size(141, 22);
            this.lblbn.TabIndex = 16;
            this.lblbn.Text = "By Book Name";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.Location = new System.Drawing.Point(0, 198);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 26);
            this.textBox1.TabIndex = 15;
            // 
            // btnsearch
            // 
            this.btnsearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnsearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(3, 146);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(104, 39);
            this.btnsearch.TabIndex = 14;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(376, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 39);
            this.button1.TabIndex = 23;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnupdate.BackColor = System.Drawing.Color.Lime;
            this.btnupdate.Location = new System.Drawing.Point(279, 530);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(150, 51);
            this.btnupdate.TabIndex = 24;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // tbid
            // 
            this.tbid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbid.Location = new System.Drawing.Point(318, 90);
            this.tbid.Name = "tbid";
            this.tbid.ReadOnly = true;
            this.tbid.Size = new System.Drawing.Size(100, 26);
            this.tbid.TabIndex = 42;
            // 
            // lblqun
            // 
            this.lblqun.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblqun.AutoSize = true;
            this.lblqun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqun.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblqun.Location = new System.Drawing.Point(188, 471);
            this.lblqun.Name = "lblqun";
            this.lblqun.Size = new System.Drawing.Size(77, 22);
            this.lblqun.TabIndex = 41;
            this.lblqun.Text = "Quantity";
            // 
            // lbldept
            // 
            this.lbldept.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbldept.AutoSize = true;
            this.lbldept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldept.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbldept.Location = new System.Drawing.Point(188, 401);
            this.lbldept.Name = "lbldept";
            this.lbldept.Size = new System.Drawing.Size(103, 22);
            this.lbldept.TabIndex = 40;
            this.lbldept.Text = "Department";
            // 
            // lbltitle
            // 
            this.lbltitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbltitle.Location = new System.Drawing.Point(188, 343);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(45, 22);
            this.lbltitle.TabIndex = 39;
            this.lbltitle.Text = "Title";
            // 
            // lblauthor
            // 
            this.lblauthor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblauthor.AutoSize = true;
            this.lblauthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblauthor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblauthor.Location = new System.Drawing.Point(188, 269);
            this.lblauthor.Name = "lblauthor";
            this.lblauthor.Size = new System.Drawing.Size(63, 22);
            this.lblauthor.TabIndex = 38;
            this.lblauthor.Text = "Author";
            // 
            // lbledition
            // 
            this.lbledition.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbledition.AutoSize = true;
            this.lbledition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledition.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbledition.Location = new System.Drawing.Point(188, 204);
            this.lbledition.Name = "lbledition";
            this.lbledition.Size = new System.Drawing.Size(65, 22);
            this.lbledition.TabIndex = 37;
            this.lbledition.Text = "Edition";
            // 
            // lblname
            // 
            this.lblname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblname.Location = new System.Drawing.Point(188, 146);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(57, 22);
            this.lblname.TabIndex = 36;
            this.lblname.Text = "Name";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(188, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 35;
            this.label1.Text = "Book ID";
            // 
            // tbqun
            // 
            this.tbqun.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbqun.Location = new System.Drawing.Point(318, 471);
            this.tbqun.Name = "tbqun";
            this.tbqun.Size = new System.Drawing.Size(100, 26);
            this.tbqun.TabIndex = 34;
            // 
            // tbdept
            // 
            this.tbdept.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbdept.Location = new System.Drawing.Point(318, 401);
            this.tbdept.Name = "tbdept";
            this.tbdept.Size = new System.Drawing.Size(100, 26);
            this.tbdept.TabIndex = 33;
            // 
            // tbtile
            // 
            this.tbtile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbtile.Location = new System.Drawing.Point(318, 337);
            this.tbtile.Name = "tbtile";
            this.tbtile.Size = new System.Drawing.Size(100, 26);
            this.tbtile.TabIndex = 32;
            // 
            // tbauthor
            // 
            this.tbauthor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbauthor.Location = new System.Drawing.Point(318, 265);
            this.tbauthor.Name = "tbauthor";
            this.tbauthor.Size = new System.Drawing.Size(100, 26);
            this.tbauthor.TabIndex = 31;
            // 
            // tbedition
            // 
            this.tbedition.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbedition.Location = new System.Drawing.Point(318, 201);
            this.tbedition.Name = "tbedition";
            this.tbedition.Size = new System.Drawing.Size(100, 26);
            this.tbedition.TabIndex = 30;
            // 
            // tbname
            // 
            this.tbname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbname.Location = new System.Drawing.Point(318, 140);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(100, 26);
            this.tbname.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.tbid);
            this.panel1.Controls.Add(this.btnsearch);
            this.panel1.Controls.Add(this.lblqun);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lbldept);
            this.panel1.Controls.Add(this.lblbn);
            this.panel1.Controls.Add(this.lbltitle);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.lblauthor);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbledition);
            this.panel1.Controls.Add(this.btnfilter);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.tbqun);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tbdept);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.tbtile);
            this.panel1.Controls.Add(this.tbname);
            this.panel1.Controls.Add(this.tbauthor);
            this.panel1.Controls.Add(this.tbedition);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 632);
            this.panel1.TabIndex = 43;
            // 
            // disbooklib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 634);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.disbooklibbb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "disbooklib";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book";
            this.Load += new System.EventHandler(this.displaybookLb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.disbooklibbb)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView disbooklibbb;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnfilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblbn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnupdate;
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
        private System.Windows.Forms.Panel panel1;
    }
}