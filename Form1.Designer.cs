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
            this.pictureBox_CapsLock = new System.Windows.Forms.PictureBox();
            this.label_Id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CapsLock)).BeginInit();
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
            this.save.Location = new System.Drawing.Point(406, 261);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(79, 47);
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
            // pictureBox_CapsLock
            // 
            this.pictureBox_CapsLock.Enabled = false;
            this.pictureBox_CapsLock.Image = global::PromoFinal_CarmellWasserman.Properties.Resources.caps_lock_icon;
            this.pictureBox_CapsLock.Location = new System.Drawing.Point(491, 49);
            this.pictureBox_CapsLock.Name = "pictureBox_CapsLock";
            this.pictureBox_CapsLock.Size = new System.Drawing.Size(77, 70);
            this.pictureBox_CapsLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_CapsLock.TabIndex = 11;
            this.pictureBox_CapsLock.TabStop = false;
            this.pictureBox_CapsLock.Visible = false;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.label_Id);
            this.Controls.Add(this.pictureBox_CapsLock);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CapsLock)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox_CapsLock;
        private System.Windows.Forms.Label label_Id;
    }
}

