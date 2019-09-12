namespace Library
{
    partial class disstdfrmLib
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button2 = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.tbdelete = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbsearch = new System.Windows.Forms.TextBox();
            this.bsearch = new System.Windows.Forms.Button();
            this.dgvstdfrmadmin = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tbdob = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tbid = new System.Windows.Forms.TextBox();
            this.lbldept = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblauthor = new System.Windows.Forms.Label();
            this.lbledition = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbgamil = new System.Windows.Forms.TextBox();
            this.tbaddress = new System.Windows.Forms.TextBox();
            this.tbgender = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstdfrmadmin)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Purple;
            this.button2.Location = new System.Drawing.Point(167, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 40);
            this.button2.TabIndex = 32;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnback.Location = new System.Drawing.Point(4, 12);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(78, 35);
            this.btnback.TabIndex = 31;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnview.Location = new System.Drawing.Point(12, 550);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(126, 51);
            this.btnview.TabIndex = 30;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // tbdelete
            // 
            this.tbdelete.Location = new System.Drawing.Point(1, 452);
            this.tbdelete.Name = "tbdelete";
            this.tbdelete.Size = new System.Drawing.Size(129, 26);
            this.tbdelete.TabIndex = 29;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.delete.Location = new System.Drawing.Point(4, 398);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(126, 38);
            this.delete.TabIndex = 28;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(12, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 53);
            this.button1.TabIndex = 27;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb
            // 
            this.cmb.FormattingEnabled = true;
            this.cmb.Items.AddRange(new object[] {
            "Male",
            "Female",
            "invalid",
            "valid"});
            this.cmb.Location = new System.Drawing.Point(1, 197);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(140, 28);
            this.cmb.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "By User Name";
            // 
            // tbsearch
            // 
            this.tbsearch.Location = new System.Drawing.Point(1, 322);
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(129, 26);
            this.tbsearch.TabIndex = 24;
            // 
            // bsearch
            // 
            this.bsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bsearch.Location = new System.Drawing.Point(1, 259);
            this.bsearch.Name = "bsearch";
            this.bsearch.Size = new System.Drawing.Size(129, 44);
            this.bsearch.TabIndex = 23;
            this.bsearch.Text = "Search";
            this.bsearch.UseVisualStyleBackColor = false;
            this.bsearch.Click += new System.EventHandler(this.bsearch_Click);
            // 
            // dgvstdfrmadmin
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvstdfrmadmin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvstdfrmadmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvstdfrmadmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvstdfrmadmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstdfrmadmin.Location = new System.Drawing.Point(492, 24);
            this.dgvstdfrmadmin.Name = "dgvstdfrmadmin";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvstdfrmadmin.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvstdfrmadmin.RowTemplate.Height = 28;
            this.dgvstdfrmadmin.Size = new System.Drawing.Size(784, 577);
            this.dgvstdfrmadmin.TabIndex = 22;
            this.dgvstdfrmadmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvstdfrmadmin_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "By User Name";
            // 
            // tbdob
            // 
            this.tbdob.Location = new System.Drawing.Point(282, 290);
            this.tbdob.Name = "tbdob";
            this.tbdob.ReadOnly = true;
            this.tbdob.Size = new System.Drawing.Size(180, 26);
            this.tbdob.TabIndex = 57;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.Location = new System.Drawing.Point(277, 538);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 63);
            this.button3.TabIndex = 56;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(280, 131);
            this.tbid.Name = "tbid";
            this.tbid.ReadOnly = true;
            this.tbid.Size = new System.Drawing.Size(100, 26);
            this.tbid.TabIndex = 55;
            // 
            // lbldept
            // 
            this.lbldept.AutoSize = true;
            this.lbldept.Location = new System.Drawing.Point(186, 429);
            this.lbldept.Name = "lbldept";
            this.lbldept.Size = new System.Drawing.Size(50, 20);
            this.lbldept.TabIndex = 54;
            this.lbldept.Text = "Gmail";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Location = new System.Drawing.Point(202, 353);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(68, 20);
            this.lbltitle.TabIndex = 53;
            this.lbltitle.Text = "Address";
            // 
            // lblauthor
            // 
            this.lblauthor.AutoSize = true;
            this.lblauthor.Location = new System.Drawing.Point(157, 290);
            this.lblauthor.Name = "lblauthor";
            this.lblauthor.Size = new System.Drawing.Size(102, 20);
            this.lblauthor.TabIndex = 52;
            this.lblauthor.Text = "Date Of Birth";
            // 
            // lbledition
            // 
            this.lbledition.AutoSize = true;
            this.lbledition.Location = new System.Drawing.Point(207, 239);
            this.lbledition.Name = "lbledition";
            this.lbledition.Size = new System.Drawing.Size(63, 20);
            this.lbledition.TabIndex = 51;
            this.lbledition.Text = "Gender";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(162, 178);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(112, 20);
            this.lblname.TabIndex = 50;
            this.lblname.Text = "Student Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Student Id";
            // 
            // tbgamil
            // 
            this.tbgamil.Location = new System.Drawing.Point(282, 426);
            this.tbgamil.Name = "tbgamil";
            this.tbgamil.Size = new System.Drawing.Size(157, 26);
            this.tbgamil.TabIndex = 48;
            // 
            // tbaddress
            // 
            this.tbaddress.Location = new System.Drawing.Point(282, 353);
            this.tbaddress.Multiline = true;
            this.tbaddress.Name = "tbaddress";
            this.tbaddress.Size = new System.Drawing.Size(150, 61);
            this.tbaddress.TabIndex = 47;
            // 
            // tbgender
            // 
            this.tbgender.Location = new System.Drawing.Point(282, 236);
            this.tbgender.Name = "tbgender";
            this.tbgender.Size = new System.Drawing.Size(100, 26);
            this.tbgender.TabIndex = 46;
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(280, 178);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(100, 26);
            this.tbname.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 59;
            this.label4.Text = "Status";
            // 
            // cmb2
            // 
            this.cmb2.FormattingEnabled = true;
            this.cmb2.Location = new System.Drawing.Point(282, 470);
            this.cmb2.Name = "cmb2";
            this.cmb2.Size = new System.Drawing.Size(121, 28);
            this.cmb2.TabIndex = 60;
            // 
            // disstdfrmLib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 634);
            this.Controls.Add(this.cmb2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbdob);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.lbldept);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.lblauthor);
            this.Controls.Add(this.lbledition);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbgamil);
            this.Controls.Add(this.tbaddress);
            this.Controls.Add(this.tbgender);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.tbdelete);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbsearch);
            this.Controls.Add(this.bsearch);
            this.Controls.Add(this.dgvstdfrmadmin);
            this.Name = "disstdfrmLib";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "disstdfrmLib";
            this.Load += new System.EventHandler(this.disstdfrmLib_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvstdfrmadmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.TextBox tbdelete;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbsearch;
        private System.Windows.Forms.Button bsearch;
        private System.Windows.Forms.DataGridView dgvstdfrmadmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbdob;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.Label lbldept;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblauthor;
        private System.Windows.Forms.Label lbledition;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbgamil;
        private System.Windows.Forms.TextBox tbaddress;
        private System.Windows.Forms.TextBox tbgender;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb2;
    }
}