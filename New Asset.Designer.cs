namespace Asset_Mng
{
    partial class New_Asset
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.contact = new System.Windows.Forms.TextBox();
            this.Company = new System.Windows.Forms.ComboBox();
            this.فروشندهBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asset_MngDataSet = new Asset_Mng.Asset_MngDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.Vadd = new System.Windows.Forms.TextBox();
            this.Vweb = new System.Windows.Forms.TextBox();
            this.Vemail = new System.Windows.Forms.TextBox();
            this.Vtel = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Asset_ID = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.Type_ = new System.Windows.Forms.ComboBox();
            this.نوعBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.status = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.sub_type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.فروشندهTableAdapter = new Asset_Mng.Asset_MngDataSetTableAdapters.فروشندهTableAdapter();
            this.نوعTableAdapter = new Asset_Mng.Asset_MngDataSetTableAdapters.نوعTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.فروشندهBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asset_MngDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.نوعBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.contact);
            this.groupBox2.Controls.Add(this.Company);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.linkLabel2);
            this.groupBox2.Controls.Add(this.Vadd);
            this.groupBox2.Controls.Add(this.Vweb);
            this.groupBox2.Controls.Add(this.Vemail);
            this.groupBox2.Controls.Add(this.Vtel);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(9, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(405, 307);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "مشخصات فروشنده\\ Vendor detail";
            // 
            // contact
            // 
            this.contact.Location = new System.Drawing.Point(161, 81);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(130, 20);
            this.contact.TabIndex = 34;
            // 
            // Company
            // 
            this.Company.DataSource = this.فروشندهBindingSource;
            this.Company.DisplayMember = "نام_شرکت";
            this.Company.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Company.FormattingEnabled = true;
            this.Company.Location = new System.Drawing.Point(161, 36);
            this.Company.Name = "Company";
            this.Company.Size = new System.Drawing.Size(130, 21);
            this.Company.TabIndex = 33;
            this.Company.SelectedIndexChanged += new System.EventHandler(this.Company_SelectedIndexChanged);
            // 
            // فروشندهBindingSource
            // 
            this.فروشندهBindingSource.DataMember = "فروشنده";
            this.فروشندهBindingSource.DataSource = this.asset_MngDataSet;
            // 
            // asset_MngDataSet
            // 
            this.asset_MngDataSet.DataSetName = "Asset_MngDataSet";
            this.asset_MngDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 39);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "نام شرکت \\Company:";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(6, 39);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(147, 13);
            this.linkLabel2.TabIndex = 14;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "شرکت جدید \\ New Company؟";
            // 
            // Vadd
            // 
            this.Vadd.BackColor = System.Drawing.SystemColors.Info;
            this.Vadd.Location = new System.Drawing.Point(40, 210);
            this.Vadd.Multiline = true;
            this.Vadd.Name = "Vadd";
            this.Vadd.ReadOnly = true;
            this.Vadd.Size = new System.Drawing.Size(251, 65);
            this.Vadd.TabIndex = 13;
            // 
            // Vweb
            // 
            this.Vweb.BackColor = System.Drawing.SystemColors.Info;
            this.Vweb.Location = new System.Drawing.Point(121, 179);
            this.Vweb.Name = "Vweb";
            this.Vweb.ReadOnly = true;
            this.Vweb.Size = new System.Drawing.Size(170, 20);
            this.Vweb.TabIndex = 12;
            // 
            // Vemail
            // 
            this.Vemail.BackColor = System.Drawing.SystemColors.Info;
            this.Vemail.Location = new System.Drawing.Point(121, 150);
            this.Vemail.Name = "Vemail";
            this.Vemail.ReadOnly = true;
            this.Vemail.Size = new System.Drawing.Size(170, 20);
            this.Vemail.TabIndex = 11;
            // 
            // Vtel
            // 
            this.Vtel.BackColor = System.Drawing.SystemColors.Info;
            this.Vtel.Location = new System.Drawing.Point(161, 122);
            this.Vtel.Name = "Vtel";
            this.Vtel.ReadOnly = true;
            this.Vtel.Size = new System.Drawing.Size(130, 20);
            this.Vtel.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(314, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "آدرس \\ Address:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(300, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "وب سایت \\ website:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "ایمیل \\ email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(312, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "شماره تلفن:\\ Tel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 81);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "نام رابط \\Dealer:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Asset_ID);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Location = new System.Drawing.Point(531, 386);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(346, 76);
            this.panel1.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Asset_ID
            // 
            this.Asset_ID.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Asset_ID.Location = new System.Drawing.Point(102, 30);
            this.Asset_ID.Name = "Asset_ID";
            this.Asset_ID.Size = new System.Drawing.Size(121, 20);
            this.Asset_ID.TabIndex = 10;
            this.Asset_ID.Text = "1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(229, 33);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "شناسه کالا \\ AssetID:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.model);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.monthCalendar1);
            this.groupBox3.Controls.Add(this.Type_);
            this.groupBox3.Controls.Add(this.monthCalendar2);
            this.groupBox3.Controls.Add(this.status);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.sub_type);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(428, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(504, 340);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "مشخصات کالا\\ Asset details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "مالکیت\\ Owenership:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "عمومی",
            "خصوصی"});
            this.comboBox1.Location = new System.Drawing.Point(41, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(118, 21);
            this.comboBox1.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "مدل\\ type :";
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(41, 54);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(118, 20);
            this.model.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "تاریخ اتمام گارانتی \\ Guarantee expires on";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.Khaki;
            this.monthCalendar1.Location = new System.Drawing.Point(265, 166);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 31;
            // 
            // Type_
            // 
            this.Type_.DataSource = this.نوعBindingSource;
            this.Type_.DisplayMember = "نام";
            this.Type_.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type_.FormattingEnabled = true;
            this.Type_.Location = new System.Drawing.Point(292, 39);
            this.Type_.Name = "Type_";
            this.Type_.Size = new System.Drawing.Size(113, 21);
            this.Type_.TabIndex = 30;
            this.Type_.SelectedIndexChanged += new System.EventHandler(this.Type__SelectedIndexChanged);
            // 
            // نوعBindingSource
            // 
            this.نوعBindingSource.DataMember = "نوع";
            this.نوعBindingSource.DataSource = this.asset_MngDataSet;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(18, 166);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2013, 9, 2, 0, 0, 0, 0), new System.DateTime(2013, 9, 8, 0, 0, 0, 0));
            this.monthCalendar2.TabIndex = 29;
            // 
            // status
            // 
            this.status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "در حال استفاده",
            "در دست تعمیر",
            "در انبار",
            "خروج موقت",
            ""});
            this.status.Location = new System.Drawing.Point(41, 19);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(118, 21);
            this.status.TabIndex = 21;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(169, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 13);
            this.label17.TabIndex = 20;
            this.label17.Text = "وضعیت \\condition:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(309, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "تاریخ خرید \\ Purchased on";
            // 
            // sub_type
            // 
            this.sub_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sub_type.FormattingEnabled = true;
            this.sub_type.Location = new System.Drawing.Point(292, 73);
            this.sub_type.Name = "sub_type";
            this.sub_type.Size = new System.Drawing.Size(113, 21);
            this.sub_type.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 42);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "نوع \\type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 81);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "زیر_نوع \\subtype:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(57, 413);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Enter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // فروشندهTableAdapter
            // 
            this.فروشندهTableAdapter.ClearBeforeFill = true;
            // 
            // نوعTableAdapter
            // 
            this.نوعTableAdapter.ClearBeforeFill = true;
            // 
            // New_Asset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 474);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Name = "New_Asset";
            this.Text = "New_Asset";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.New_Asset_FormClosed);
            this.Load += new System.EventHandler(this.New_Asset_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.فروشندهBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asset_MngDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.نوعBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.ComboBox Company;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.TextBox Vadd;
        private System.Windows.Forms.TextBox Vweb;
        private System.Windows.Forms.TextBox Vemail;
        private System.Windows.Forms.TextBox Vtel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Asset_ID;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox Type_;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox sub_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private Asset_MngDataSet asset_MngDataSet;
        private System.Windows.Forms.BindingSource فروشندهBindingSource;
        private Asset_Mng.Asset_MngDataSetTableAdapters.فروشندهTableAdapter فروشندهTableAdapter;
        private System.Windows.Forms.BindingSource نوعBindingSource;
        private Asset_Mng.Asset_MngDataSetTableAdapters.نوعTableAdapter نوعTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}