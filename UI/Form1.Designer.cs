namespace PromoFinal_CarmellWasserman
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
            this.textBox_FilterCell = new System.Windows.Forms.TextBox();
            this.textBox_FilterLastName = new System.Windows.Forms.TextBox();
            this.textBox_FilterId = new System.Windows.Forms.TextBox();
            this.label_City = new System.Windows.Forms.Label();
            this.comboBox_City = new System.Windows.Forms.ComboBox();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_AddCity = new System.Windows.Forms.Button();
            this.Filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(271, 40);
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
            this.label_FirstName.Location = new System.Drawing.Point(12, 34);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(184, 37);
            this.label_FirstName.TabIndex = 1;
            this.label_FirstName.Text = " First Name";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_LastName.Location = new System.Drawing.Point(12, 92);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(182, 37);
            this.label_LastName.TabIndex = 2;
            this.label_LastName.Text = " Last Name";
            // 
            // label_PhoneNumber
            // 
            this.label_PhoneNumber.AutoSize = true;
            this.label_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_PhoneNumber.Location = new System.Drawing.Point(22, 147);
            this.label_PhoneNumber.Name = "label_PhoneNumber";
            this.label_PhoneNumber.Size = new System.Drawing.Size(233, 37);
            this.label_PhoneNumber.TabIndex = 3;
            this.label_PhoneNumber.Text = "Phone Number";
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(271, 98);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(214, 31);
            this.textBox_LastName.TabIndex = 4;
            this.textBox_LastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Heb_KeyPress);
            // 
            // textBox_PhoneNumber
            // 
            this.textBox_PhoneNumber.Location = new System.Drawing.Point(271, 153);
            this.textBox_PhoneNumber.MaxLength = 10;
            this.textBox_PhoneNumber.Name = "textBox_PhoneNumber";
            this.textBox_PhoneNumber.Size = new System.Drawing.Size(214, 31);
            this.textBox_PhoneNumber.TabIndex = 5;
            this.textBox_PhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            // 
            // label_ZipCode
            // 
            this.label_ZipCode.AutoSize = true;
            this.label_ZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_ZipCode.Location = new System.Drawing.Point(22, 203);
            this.label_ZipCode.Name = "label_ZipCode";
            this.label_ZipCode.Size = new System.Drawing.Size(147, 37);
            this.label_ZipCode.TabIndex = 8;
            this.label_ZipCode.Text = "Zip Code";
            // 
            // textBox_ZipCode
            // 
            this.textBox_ZipCode.Location = new System.Drawing.Point(271, 209);
            this.textBox_ZipCode.MaxLength = 7;
            this.textBox_ZipCode.Name = "textBox_ZipCode";
            this.textBox_ZipCode.Size = new System.Drawing.Size(214, 31);
            this.textBox_ZipCode.TabIndex = 7;
            this.textBox_ZipCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(191, 367);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(94, 47);
            this.save.TabIndex = 9;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // listBox_Clients
            // 
            this.listBox_Clients.FormattingEnabled = true;
            this.listBox_Clients.ItemHeight = 25;
            this.listBox_Clients.Location = new System.Drawing.Point(574, 40);
            this.listBox_Clients.Name = "listBox_Clients";
            this.listBox_Clients.Size = new System.Drawing.Size(298, 204);
            this.listBox_Clients.TabIndex = 10;
            this.listBox_Clients.DoubleClick += new System.EventHandler(this.listBox_Clients_DoubleClick);
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Location = new System.Drawing.Point(266, 9);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(24, 25);
            this.label_Id.TabIndex = 12;
            this.label_Id.Text = "0";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(291, 367);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(94, 47);
            this.clear.TabIndex = 13;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(391, 367);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(94, 47);
            this.delete.TabIndex = 14;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // Filter
            // 
            this.Filter.Controls.Add(this.textBox_FilterCell);
            this.Filter.Controls.Add(this.textBox_FilterLastName);
            this.Filter.Controls.Add(this.textBox_FilterId);
            this.Filter.Location = new System.Drawing.Point(574, 261);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(298, 153);
            this.Filter.TabIndex = 15;
            this.Filter.TabStop = false;
            this.Filter.Text = "Filter";
            // 
            // textBox_FilterCell
            // 
            this.textBox_FilterCell.Location = new System.Drawing.Point(6, 106);
            this.textBox_FilterCell.MaxLength = 10;
            this.textBox_FilterCell.Name = "textBox_FilterCell";
            this.textBox_FilterCell.Size = new System.Drawing.Size(214, 31);
            this.textBox_FilterCell.TabIndex = 16;
            this.textBox_FilterCell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            this.textBox_FilterCell.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // textBox_FilterLastName
            // 
            this.textBox_FilterLastName.Location = new System.Drawing.Point(6, 69);
            this.textBox_FilterLastName.Name = "textBox_FilterLastName";
            this.textBox_FilterLastName.Size = new System.Drawing.Size(214, 31);
            this.textBox_FilterLastName.TabIndex = 16;
            this.textBox_FilterLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Heb_KeyPress);
            this.textBox_FilterLastName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // textBox_FilterId
            // 
            this.textBox_FilterId.Location = new System.Drawing.Point(6, 30);
            this.textBox_FilterId.MaxLength = 7;
            this.textBox_FilterId.Name = "textBox_FilterId";
            this.textBox_FilterId.Size = new System.Drawing.Size(214, 31);
            this.textBox_FilterId.TabIndex = 16;
            this.textBox_FilterId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            this.textBox_FilterId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // label_City
            // 
            this.label_City.AutoSize = true;
            this.label_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_City.Location = new System.Drawing.Point(12, 261);
            this.label_City.Name = "label_City";
            this.label_City.Size = new System.Drawing.Size(80, 37);
            this.label_City.TabIndex = 16;
            this.label_City.Text = " City";
            // 
            // comboBox_City
            // 
            this.comboBox_City.FormattingEnabled = true;
            this.comboBox_City.Location = new System.Drawing.Point(271, 261);
            this.comboBox_City.Name = "comboBox_City";
            this.comboBox_City.Size = new System.Drawing.Size(171, 33);
            this.comboBox_City.TabIndex = 17;
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(91, 367);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(94, 47);
            this.button_Update.TabIndex = 18;
            this.button_Update.Text = " update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_AddCity
            // 
            this.button_AddCity.Location = new System.Drawing.Point(448, 261);
            this.button_AddCity.Name = "button_AddCity";
            this.button_AddCity.Size = new System.Drawing.Size(40, 40);
            this.button_AddCity.TabIndex = 19;
            this.button_AddCity.Text = "+";
            this.button_AddCity.UseVisualStyleBackColor = true;
            this.button_AddCity.Click += new System.EventHandler(this.button_AddCity_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 436);
            this.Controls.Add(this.button_AddCity);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.comboBox_City);
            this.Controls.Add(this.label_City);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label_Id);
            this.Controls.Add(this.listBox_Clients);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label_ZipCode);
            this.Controls.Add(this.textBox_ZipCode);
            this.Controls.Add(this.textBox_PhoneNumber);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.label_PhoneNumber);
            this.Controls.Add(this.label_LastName);
            this.Controls.Add(this.label_FirstName);
            this.Controls.Add(this.textBox_FirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Filter.ResumeLayout(false);
            this.Filter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_AddCity;
    }
}

