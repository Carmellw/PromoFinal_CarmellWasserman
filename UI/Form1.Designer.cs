namespace PromoFinal_CarmellWasserman
{
    partial class Form_Client
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
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.label_PhoneNumber = new System.Windows.Forms.Label();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_PhoneNumber = new System.Windows.Forms.TextBox();
            this.label_ZipCode = new System.Windows.Forms.Label();
            this.textBox_ZipCode = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.listBox_Clients = new System.Windows.Forms.ListBox();
            this.label_Id = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.Filter = new System.Windows.Forms.GroupBox();
            this.label_PhoneNumberFilter = new System.Windows.Forms.Label();
            this.label_IdFilter = new System.Windows.Forms.Label();
            this.label_NameFilter = new System.Windows.Forms.Label();
            this.textBox_FilterCell = new System.Windows.Forms.TextBox();
            this.textBox_FilterLastName = new System.Windows.Forms.TextBox();
            this.textBox_FilterId = new System.Windows.Forms.TextBox();
            this.label_City = new System.Windows.Forms.Label();
            this.comboBox_City = new System.Windows.Forms.ComboBox();
            this.button_AddCity = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Filter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(267, 95);
            this.textBox_FirstName.MaxLength = 4000;
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(214, 31);
            this.textBox_FirstName.TabIndex = 0;
            this.textBox_FirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Heb_KeyPress);
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_FirstName.Location = new System.Drawing.Point(8, 89);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(184, 37);
            this.label_FirstName.TabIndex = 1;
            this.label_FirstName.Text = " First Name";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_LastName.Location = new System.Drawing.Point(8, 147);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(182, 37);
            this.label_LastName.TabIndex = 2;
            this.label_LastName.Text = " Last Name";
            // 
            // label_PhoneNumber
            // 
            this.label_PhoneNumber.AutoSize = true;
            this.label_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_PhoneNumber.Location = new System.Drawing.Point(18, 202);
            this.label_PhoneNumber.Name = "label_PhoneNumber";
            this.label_PhoneNumber.Size = new System.Drawing.Size(233, 37);
            this.label_PhoneNumber.TabIndex = 3;
            this.label_PhoneNumber.Text = "Phone Number";
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(267, 153);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(214, 31);
            this.textBox_LastName.TabIndex = 2;
            this.textBox_LastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Heb_KeyPress);
            // 
            // textBox_PhoneNumber
            // 
            this.textBox_PhoneNumber.Location = new System.Drawing.Point(267, 208);
            this.textBox_PhoneNumber.MaxLength = 10;
            this.textBox_PhoneNumber.Name = "textBox_PhoneNumber";
            this.textBox_PhoneNumber.Size = new System.Drawing.Size(214, 31);
            this.textBox_PhoneNumber.TabIndex = 3;
            this.textBox_PhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            // 
            // label_ZipCode
            // 
            this.label_ZipCode.AutoSize = true;
            this.label_ZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_ZipCode.Location = new System.Drawing.Point(18, 258);
            this.label_ZipCode.Name = "label_ZipCode";
            this.label_ZipCode.Size = new System.Drawing.Size(147, 37);
            this.label_ZipCode.TabIndex = 8;
            this.label_ZipCode.Text = "Zip Code";
            // 
            // textBox_ZipCode
            // 
            this.textBox_ZipCode.Location = new System.Drawing.Point(267, 264);
            this.textBox_ZipCode.MaxLength = 7;
            this.textBox_ZipCode.Name = "textBox_ZipCode";
            this.textBox_ZipCode.Size = new System.Drawing.Size(214, 31);
            this.textBox_ZipCode.TabIndex = 4;
            this.textBox_ZipCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(195, 416);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(94, 47);
            this.save.TabIndex = 7;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // listBox_Clients
            // 
            this.listBox_Clients.FormattingEnabled = true;
            this.listBox_Clients.ItemHeight = 25;
            this.listBox_Clients.Location = new System.Drawing.Point(555, 207);
            this.listBox_Clients.Name = "listBox_Clients";
            this.listBox_Clients.Size = new System.Drawing.Size(356, 554);
            this.listBox_Clients.TabIndex = 13;
            this.listBox_Clients.DoubleClick += new System.EventHandler(this.listBox_Clients_DoubleClick);
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_Id.Location = new System.Drawing.Point(261, 37);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(29, 31);
            this.label_Id.TabIndex = 12;
            this.label_Id.Text = "0";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(295, 416);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(94, 47);
            this.clear.TabIndex = 8;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(395, 416);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(94, 47);
            this.delete.TabIndex = 9;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // Filter
            // 
            this.Filter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Filter.Controls.Add(this.label_PhoneNumberFilter);
            this.Filter.Controls.Add(this.label_IdFilter);
            this.Filter.Controls.Add(this.label_NameFilter);
            this.Filter.Controls.Add(this.textBox_FilterCell);
            this.Filter.Controls.Add(this.textBox_FilterLastName);
            this.Filter.Controls.Add(this.textBox_FilterId);
            this.Filter.Location = new System.Drawing.Point(555, 22);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(356, 169);
            this.Filter.TabIndex = 15;
            this.Filter.TabStop = false;
            this.Filter.Text = "Filter";
            // 
            // label_PhoneNumberFilter
            // 
            this.label_PhoneNumberFilter.AutoSize = true;
            this.label_PhoneNumberFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label_PhoneNumberFilter.Location = new System.Drawing.Point(6, 124);
            this.label_PhoneNumberFilter.Name = "label_PhoneNumberFilter";
            this.label_PhoneNumberFilter.Size = new System.Drawing.Size(140, 24);
            this.label_PhoneNumberFilter.TabIndex = 22;
            this.label_PhoneNumberFilter.Text = "Phone Number";
            // 
            // label_IdFilter
            // 
            this.label_IdFilter.AutoSize = true;
            this.label_IdFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label_IdFilter.Location = new System.Drawing.Point(6, 34);
            this.label_IdFilter.Name = "label_IdFilter";
            this.label_IdFilter.Size = new System.Drawing.Size(25, 24);
            this.label_IdFilter.TabIndex = 21;
            this.label_IdFilter.Text = "Id";
            // 
            // label_NameFilter
            // 
            this.label_NameFilter.AutoSize = true;
            this.label_NameFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label_NameFilter.Location = new System.Drawing.Point(6, 78);
            this.label_NameFilter.Name = "label_NameFilter";
            this.label_NameFilter.Size = new System.Drawing.Size(99, 24);
            this.label_NameFilter.TabIndex = 20;
            this.label_NameFilter.Text = "Last Name";
            // 
            // textBox_FilterCell
            // 
            this.textBox_FilterCell.Location = new System.Drawing.Point(168, 120);
            this.textBox_FilterCell.MaxLength = 10;
            this.textBox_FilterCell.Name = "textBox_FilterCell";
            this.textBox_FilterCell.Size = new System.Drawing.Size(172, 31);
            this.textBox_FilterCell.TabIndex = 12;
            this.textBox_FilterCell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            this.textBox_FilterCell.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // textBox_FilterLastName
            // 
            this.textBox_FilterLastName.Location = new System.Drawing.Point(168, 74);
            this.textBox_FilterLastName.Name = "textBox_FilterLastName";
            this.textBox_FilterLastName.Size = new System.Drawing.Size(172, 31);
            this.textBox_FilterLastName.TabIndex = 11;
            this.textBox_FilterLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Heb_KeyPress);
            this.textBox_FilterLastName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // textBox_FilterId
            // 
            this.textBox_FilterId.Location = new System.Drawing.Point(168, 30);
            this.textBox_FilterId.MaxLength = 7;
            this.textBox_FilterId.Name = "textBox_FilterId";
            this.textBox_FilterId.Size = new System.Drawing.Size(172, 31);
            this.textBox_FilterId.TabIndex = 10;
            this.textBox_FilterId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            this.textBox_FilterId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // label_City
            // 
            this.label_City.AutoSize = true;
            this.label_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_City.Location = new System.Drawing.Point(8, 316);
            this.label_City.Name = "label_City";
            this.label_City.Size = new System.Drawing.Size(80, 37);
            this.label_City.TabIndex = 16;
            this.label_City.Text = " City";
            // 
            // comboBox_City
            // 
            this.comboBox_City.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_City.FormattingEnabled = true;
            this.comboBox_City.Location = new System.Drawing.Point(267, 316);
            this.comboBox_City.Name = "comboBox_City";
            this.comboBox_City.Size = new System.Drawing.Size(171, 33);
            this.comboBox_City.TabIndex = 5;
            // 
            // button_AddCity
            // 
            this.button_AddCity.Location = new System.Drawing.Point(444, 314);
            this.button_AddCity.Name = "button_AddCity";
            this.button_AddCity.Size = new System.Drawing.Size(45, 45);
            this.button_AddCity.TabIndex = 6;
            this.button_AddCity.Text = "+";
            this.button_AddCity.UseVisualStyleBackColor = true;
            this.button_AddCity.Click += new System.EventHandler(this.button_AddCity_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(18, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 37);
            this.label4.TabIndex = 20;
            this.label4.Text = "Id";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.textBox_PhoneNumber);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_FirstName);
            this.groupBox1.Controls.Add(this.button_AddCity);
            this.groupBox1.Controls.Add(this.label_FirstName);
            this.groupBox1.Controls.Add(this.comboBox_City);
            this.groupBox1.Controls.Add(this.label_LastName);
            this.groupBox1.Controls.Add(this.label_City);
            this.groupBox1.Controls.Add(this.label_PhoneNumber);
            this.groupBox1.Controls.Add(this.textBox_LastName);
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.textBox_ZipCode);
            this.groupBox1.Controls.Add(this.clear);
            this.groupBox1.Controls.Add(this.label_ZipCode);
            this.groupBox1.Controls.Add(this.label_Id);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Location = new System.Drawing.Point(24, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 481);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Update";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PromoFinal_CarmellWasserman.Properties.Resources.chunk_the_groundhog_chunk2;
            this.pictureBox1.Location = new System.Drawing.Point(24, 522);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(513, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(932, 805);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.listBox_Clients);
            this.Name = "Form_Client";
            this.Text = "Form_Client";
            this.Filter.ResumeLayout(false);
            this.Filter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Label label_PhoneNumber;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_PhoneNumber;
        private System.Windows.Forms.Label label_ZipCode;
        private System.Windows.Forms.TextBox textBox_ZipCode;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ListBox listBox_Clients;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.GroupBox Filter;
        private System.Windows.Forms.TextBox textBox_FilterId;
        private System.Windows.Forms.TextBox textBox_FilterCell;
        private System.Windows.Forms.TextBox textBox_FilterLastName;
        private System.Windows.Forms.Label label_City;
        private System.Windows.Forms.ComboBox comboBox_City;
        private System.Windows.Forms.Button button_AddCity;
        private System.Windows.Forms.Label label_NameFilter;
        private System.Windows.Forms.Label label_PhoneNumberFilter;
        private System.Windows.Forms.Label label_IdFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

