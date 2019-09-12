namespace Library
{
    partial class DisStdLibrarian
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
            this.tbname = new System.Windows.Forms.TextBox();
            this.bsearch = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbsearch = new System.Windows.Forms.TextBox();
            this.tbdob = new System.Windows.Forms.TextBox();
            this.lblsrch = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.tbid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbldept = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnview = new System.Windows.Forms.Button();
            this.lblauthor = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.lbledition = new System.Windows.Forms.Label();
            this.tbgender = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.tbaddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbgamil = new System.Windows.Forms.TextBox();
            this.dgvdisplay = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdisplay)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbname
            // 
            this.tbname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbname.Location = new System.Drawing.Point(337, 164);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(120, 26);
            this.tbname.TabIndex = 102;
            // 
            // bsearch
            // 
            this.bsearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bsearch.Location = new System.Drawing.Point(3, 98);
            this.bsearch.Name = "bsearch";
            this.bsearch.Size = new System.Drawing.Size(129, 41);
            this.bsearch.TabIndex = 94;
            this.bsearch.Text = "Search";
            this.bsearch.UseVisualStyleBackColor = false;
            this.bsearch.Click += new System.EventHandler(this.bsearch_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(409, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 40);
            this.button2.TabIndex = 115;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbsearch
            // 
            this.tbsearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbsearch.Location = new System.Drawing.Point(3, 145);
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(150, 26);
            this.tbsearch.TabIndex = 95;
            // 
            // tbdob
            // 
            this.tbdob.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbdob.Location = new System.Drawing.Point(325, 276);
            this.tbdob.Name = "tbdob";
            this.tbdob.ReadOnly = true;
            this.tbdob.Size = new System.Drawing.Size(180, 26);
            this.tbdob.TabIndex = 114;
            // 
            // lblsrch
            // 
            this.lblsrch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblsrch.AutoSize = true;
            this.lblsrch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsrch.ForeColor = System.Drawing.Color.Red;
            this.lblsrch.Location = new System.Drawing.Point(3, 183);
            this.lblsrch.Name = "lblsrch";
            this.lblsrch.Size = new System.Drawing.Size(142, 22);
            this.lblsrch.TabIndex = 96;
            this.lblsrch.Text = "Give User Name";
            this.lblsrch.Visible = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(379, 516);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 55);
            this.button3.TabIndex = 113;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmb
            // 
            this.cmb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmb.FormattingEnabled = true;
            this.cmb.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Valid",
            "Invalid"});
            this.cmb.Location = new System.Drawing.Point(7, 329);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(121, 28);
            this.cmb.TabIndex = 97;
            // 
            // tbid
            // 
            this.tbid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbid.Location = new System.Drawing.Point(337, 114);
            this.tbid.Name = "tbid";
            this.tbid.ReadOnly = true;
            this.tbid.Size = new System.Drawing.Size(120, 26);
            this.tbid.TabIndex = 112;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(3, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 41);
            this.button1.TabIndex = 98;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbldept
            // 
            this.lbldept.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbldept.AutoSize = true;
            this.lbldept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldept.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbldept.Location = new System.Drawing.Point(195, 412);
            this.lbldept.Name = "lbldept";
            this.lbldept.Size = new System.Drawing.Size(56, 22);
            this.lbldept.TabIndex = 111;
            this.lbldept.Text = "Gmail";
            // 
            // delete
            // 
            this.delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.delete.BackColor = System.Drawing.Color.Yellow;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(210, 516);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(126, 55);
            this.delete.TabIndex = 99;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // lbltitle
            // 
            this.lbltitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbltitle.Location = new System.Drawing.Point(195, 335);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(76, 22);
            this.lbltitle.TabIndex = 110;
            this.lbltitle.Text = "Address";
            // 
            // btnview
            // 
            this.btnview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.Location = new System.Drawing.Point(55, 516);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(126, 55);
            this.btnview.TabIndex = 100;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // lblauthor
            // 
            this.lblauthor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblauthor.AutoSize = true;
            this.lblauthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblauthor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblauthor.Location = new System.Drawing.Point(195, 276);
            this.lblauthor.Name = "lblauthor";
            this.lblauthor.Size = new System.Drawing.Size(114, 22);
            this.lblauthor.TabIndex = 109;
            this.lblauthor.Text = "Date Of Birth";
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.LawnGreen;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(19, 11);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(76, 42);
            this.btnback.TabIndex = 101;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // lbledition
            // 
            this.lbledition.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbledition.AutoSize = true;
            this.lbledition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledition.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbledition.Location = new System.Drawing.Point(195, 222);
            this.lbledition.Name = "lbledition";
            this.lbledition.Size = new System.Drawing.Size(70, 22);
            this.lbledition.TabIndex = 108;
            this.lbledition.Text = "Gender";
            // 
            // tbgender
            // 
            this.tbgender.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbgender.Location = new System.Drawing.Point(337, 216);
            this.tbgender.Name = "tbgender";
            this.tbgender.Size = new System.Drawing.Size(120, 26);
            this.tbgender.TabIndex = 103;
            // 
            // lblname
            // 
            this.lblname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblname.Location = new System.Drawing.Point(195, 164);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(124, 22);
            this.lblname.TabIndex = 107;
            this.lblname.Text = "Student Name";
            // 
            // tbaddress
            // 
            this.tbaddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbaddress.Location = new System.Drawing.Point(333, 332);
            this.tbaddress.Multiline = true;
            this.tbaddress.Name = "tbaddress";
            this.tbaddress.Size = new System.Drawing.Size(150, 61);
            this.tbaddress.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(195, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 106;
            this.label3.Text = "Student Id";
            // 
            // tbgamil
            // 
            this.tbgamil.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbgamil.Location = new System.Drawing.Point(333, 412);
            this.tbgamil.Name = "tbgamil";
            this.tbgamil.Size = new System.Drawing.Size(150, 26);
            this.tbgamil.TabIndex = 105;
            // 
            // dgvdisplay
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvdisplay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdisplay.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvdisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvdisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdisplay.Location = new System.Drawing.Point(521, 10);
            this.dgvdisplay.Name = "dgvdisplay";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdisplay.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdisplay.RowTemplate.Height = 28;
            this.dgvdisplay.Size = new System.Drawing.Size(765, 594);
            this.dgvdisplay.TabIndex = 116;
            this.dgvdisplay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdisplay_CellClick);
            this.dgvdisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdisplay_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Controls.Add(this.tbgamil);
            this.panel1.Controls.Add(this.tbname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.bsearch);
            this.panel1.Controls.Add(this.tbaddress);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.tbgender);
            this.panel1.Controls.Add(this.tbsearch);
            this.panel1.Controls.Add(this.lbledition);
            this.panel1.Controls.Add(this.tbdob);
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Controls.Add(this.lblsrch);
            this.panel1.Controls.Add(this.lblauthor);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnview);
            this.panel1.Controls.Add(this.cmb);
            this.panel1.Controls.Add(this.lbltitle);
            this.panel1.Controls.Add(this.tbid);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbldept);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 701);
            this.panel1.TabIndex = 117;
            // 
            // DisStdLibrarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1298, 634);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvdisplay);
            this.Name = "DisStdLibrarian";
            this.Text = "Student Information";
            ((System.ComponentModel.ISupportInitialize)(this.dgvdisplay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Button bsearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbsearch;
        private System.Windows.Forms.TextBox tbdob;
        private System.Windows.Forms.Label lblsrch;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbldept;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Label lblauthor;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label lbledition;
        private System.Windows.Forms.TextBox tbgender;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox tbaddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbgamil;
        private System.Windows.Forms.DataGridView dgvdisplay;
        private System.Windows.Forms.Panel panel1;
    }
}