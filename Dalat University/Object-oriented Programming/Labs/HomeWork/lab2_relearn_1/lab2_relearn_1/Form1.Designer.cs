namespace lab2_relearn_1
{
    partial class Form1
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
            this.comboBoxhoTen = new System.Windows.Forms.ComboBox();
            this.textBoxhoTen = new System.Windows.Forms.TextBox();
            this.dateTimePickermngaySinh = new System.Windows.Forms.DateTimePicker();
            this.radioButtonnam = new System.Windows.Forms.RadioButton();
            this.radioButtonnu = new System.Windows.Forms.RadioButton();
            this.textBoxmail = new System.Windows.Forms.TextBox();
            this.maskedTextBoxsoDT = new System.Windows.Forms.MaskedTextBox();
            this.checkedListBoxngoaiNgu = new System.Windows.Forms.CheckedListBox();
            this.listBoxdsmh = new System.Windows.Forms.ListBox();
            this.listBoxmonDay = new System.Windows.Forms.ListBox();
            this.buttonchon = new System.Windows.Forms.Button();
            this.buttonbochon = new System.Windows.Forms.Button();
            this.linkLabellienhe = new System.Windows.Forms.LinkLabel();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.buttonsave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxhoTen
            // 
            this.comboBoxhoTen.FormattingEnabled = true;
            this.comboBoxhoTen.Items.AddRange(new object[] {
            "001",
            "002",
            "003",
            "004"});
            this.comboBoxhoTen.Location = new System.Drawing.Point(42, 46);
            this.comboBoxhoTen.Name = "comboBoxhoTen";
            this.comboBoxhoTen.Size = new System.Drawing.Size(171, 24);
            this.comboBoxhoTen.TabIndex = 0;
            // 
            // textBoxhoTen
            // 
            this.textBoxhoTen.Location = new System.Drawing.Point(42, 91);
            this.textBoxhoTen.Name = "textBoxhoTen";
            this.textBoxhoTen.Size = new System.Drawing.Size(171, 23);
            this.textBoxhoTen.TabIndex = 1;
            // 
            // dateTimePickermngaySinh
            // 
            this.dateTimePickermngaySinh.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickermngaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickermngaySinh.Location = new System.Drawing.Point(42, 138);
            this.dateTimePickermngaySinh.Name = "dateTimePickermngaySinh";
            this.dateTimePickermngaySinh.Size = new System.Drawing.Size(171, 23);
            this.dateTimePickermngaySinh.TabIndex = 2;
            // 
            // radioButtonnam
            // 
            this.radioButtonnam.AutoSize = true;
            this.radioButtonnam.Checked = true;
            this.radioButtonnam.Location = new System.Drawing.Point(286, 46);
            this.radioButtonnam.Name = "radioButtonnam";
            this.radioButtonnam.Size = new System.Drawing.Size(52, 20);
            this.radioButtonnam.TabIndex = 3;
            this.radioButtonnam.TabStop = true;
            this.radioButtonnam.Text = "Nam";
            this.radioButtonnam.UseVisualStyleBackColor = true;
            // 
            // radioButtonnu
            // 
            this.radioButtonnu.AutoSize = true;
            this.radioButtonnu.Location = new System.Drawing.Point(370, 46);
            this.radioButtonnu.Name = "radioButtonnu";
            this.radioButtonnu.Size = new System.Drawing.Size(42, 20);
            this.radioButtonnu.TabIndex = 3;
            this.radioButtonnu.TabStop = true;
            this.radioButtonnu.Text = "Nữ";
            this.radioButtonnu.UseVisualStyleBackColor = true;
            // 
            // textBoxmail
            // 
            this.textBoxmail.Location = new System.Drawing.Point(286, 140);
            this.textBoxmail.Name = "textBoxmail";
            this.textBoxmail.Size = new System.Drawing.Size(140, 23);
            this.textBoxmail.TabIndex = 4;
            // 
            // maskedTextBoxsoDT
            // 
            this.maskedTextBoxsoDT.Location = new System.Drawing.Point(286, 93);
            this.maskedTextBoxsoDT.Mask = "(\\0632).000.000";
            this.maskedTextBoxsoDT.Name = "maskedTextBoxsoDT";
            this.maskedTextBoxsoDT.Size = new System.Drawing.Size(140, 23);
            this.maskedTextBoxsoDT.TabIndex = 5;
            // 
            // checkedListBoxngoaiNgu
            // 
            this.checkedListBoxngoaiNgu.CheckOnClick = true;
            this.checkedListBoxngoaiNgu.FormattingEnabled = true;
            this.checkedListBoxngoaiNgu.Items.AddRange(new object[] {
            "Tiếng Anh",
            "Tiếng Nhật",
            "Tiếng Pháp",
            "Tiếng Trung"});
            this.checkedListBoxngoaiNgu.Location = new System.Drawing.Point(42, 184);
            this.checkedListBoxngoaiNgu.Name = "checkedListBoxngoaiNgu";
            this.checkedListBoxngoaiNgu.Size = new System.Drawing.Size(171, 76);
            this.checkedListBoxngoaiNgu.TabIndex = 6;
            // 
            // listBoxdsmh
            // 
            this.listBoxdsmh.FormattingEnabled = true;
            this.listBoxdsmh.ItemHeight = 16;
            this.listBoxdsmh.Items.AddRange(new object[] {
            "Cấu trúc dữ liệu",
            "Tiếng Anh B1",
            "Mạng Máy Tính",
            "Lập Trình Hướng Đối Tượng",
            "Cơ Sở Dữ Liệu",
            "Winform",
            "HTML",
            "SQL"});
            this.listBoxdsmh.Location = new System.Drawing.Point(42, 280);
            this.listBoxdsmh.Name = "listBoxdsmh";
            this.listBoxdsmh.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxdsmh.Size = new System.Drawing.Size(171, 132);
            this.listBoxdsmh.TabIndex = 7;
            // 
            // listBoxmonDay
            // 
            this.listBoxmonDay.FormattingEnabled = true;
            this.listBoxmonDay.ItemHeight = 16;
            this.listBoxmonDay.Location = new System.Drawing.Point(318, 280);
            this.listBoxmonDay.Name = "listBoxmonDay";
            this.listBoxmonDay.Size = new System.Drawing.Size(156, 132);
            this.listBoxmonDay.TabIndex = 8;
            // 
            // buttonchon
            // 
            this.buttonchon.Location = new System.Drawing.Point(244, 316);
            this.buttonchon.Name = "buttonchon";
            this.buttonchon.Size = new System.Drawing.Size(54, 23);
            this.buttonchon.TabIndex = 9;
            this.buttonchon.Text = ">>";
            this.buttonchon.UseVisualStyleBackColor = true;
            this.buttonchon.Click += new System.EventHandler(this.buttonchon_Click);
            // 
            // buttonbochon
            // 
            this.buttonbochon.Location = new System.Drawing.Point(244, 361);
            this.buttonbochon.Name = "buttonbochon";
            this.buttonbochon.Size = new System.Drawing.Size(54, 23);
            this.buttonbochon.TabIndex = 9;
            this.buttonbochon.Text = "<<";
            this.buttonbochon.UseVisualStyleBackColor = true;
            this.buttonbochon.Click += new System.EventHandler(this.buttonbochon_Click);
            // 
            // linkLabellienhe
            // 
            this.linkLabellienhe.AutoSize = true;
            this.linkLabellienhe.Location = new System.Drawing.Point(425, 495);
            this.linkLabellienhe.Name = "linkLabellienhe";
            this.linkLabellienhe.Size = new System.Drawing.Size(49, 16);
            this.linkLabellienhe.TabIndex = 10;
            this.linkLabellienhe.TabStop = true;
            this.linkLabellienhe.Text = "Liên hệ";
            this.linkLabellienhe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabellienhe_LinkClicked);
            // 
            // buttoncancel
            // 
            this.buttoncancel.Location = new System.Drawing.Point(42, 443);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(97, 36);
            this.buttoncancel.TabIndex = 11;
            this.buttoncancel.Text = "Cancel";
            this.buttoncancel.UseVisualStyleBackColor = true;
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // buttonsave
            // 
            this.buttonsave.Location = new System.Drawing.Point(161, 443);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(76, 36);
            this.buttonsave.TabIndex = 12;
            this.buttonsave.Text = "Save";
            this.buttonsave.UseVisualStyleBackColor = true;
            this.buttonsave.Click += new System.EventHandler(this.buttonsave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "Them";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 520);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonsave);
            this.Controls.Add(this.buttoncancel);
            this.Controls.Add(this.linkLabellienhe);
            this.Controls.Add(this.buttonbochon);
            this.Controls.Add(this.buttonchon);
            this.Controls.Add(this.listBoxmonDay);
            this.Controls.Add(this.listBoxdsmh);
            this.Controls.Add(this.checkedListBoxngoaiNgu);
            this.Controls.Add(this.maskedTextBoxsoDT);
            this.Controls.Add(this.textBoxmail);
            this.Controls.Add(this.radioButtonnu);
            this.Controls.Add(this.radioButtonnam);
            this.Controls.Add(this.dateTimePickermngaySinh);
            this.Controls.Add(this.textBoxhoTen);
            this.Controls.Add(this.comboBoxhoTen);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Thông tin giáo viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxhoTen;
        private System.Windows.Forms.TextBox textBoxhoTen;
        private System.Windows.Forms.DateTimePicker dateTimePickermngaySinh;
        private System.Windows.Forms.RadioButton radioButtonnam;
        private System.Windows.Forms.RadioButton radioButtonnu;
        private System.Windows.Forms.TextBox textBoxmail;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxsoDT;
        private System.Windows.Forms.CheckedListBox checkedListBoxngoaiNgu;
        private System.Windows.Forms.ListBox listBoxdsmh;
        private System.Windows.Forms.ListBox listBoxmonDay;
        private System.Windows.Forms.Button buttonchon;
        private System.Windows.Forms.Button buttonbochon;
        private System.Windows.Forms.LinkLabel linkLabellienhe;
        private System.Windows.Forms.Button buttoncancel;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Button button1;
    }
}

