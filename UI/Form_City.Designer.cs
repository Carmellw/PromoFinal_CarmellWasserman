
namespace PromoFinal_CarmellWasserman
{
    partial class Form_City
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
            this.Filter = new System.Windows.Forms.GroupBox();
            this.textBox_FilterName = new System.Windows.Forms.TextBox();
            this.textBox_FilterId = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.label_Id = new System.Windows.Forms.Label();
            this.listBox_Cities = new System.Windows.Forms.ListBox();
            this.save = new System.Windows.Forms.Button();
            this.label_Name = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_IdFilter = new System.Windows.Forms.Label();
            this.label_NameFilter = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_IdCity = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Filter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Filter
            // 
            this.Filter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Filter.Controls.Add(this.label_IdFilter);
            this.Filter.Controls.Add(this.label_NameFilter);
            this.Filter.Controls.Add(this.textBox_FilterName);
            this.Filter.Controls.Add(this.textBox_FilterId);
            this.Filter.Location = new System.Drawing.Point(462, 23);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(307, 129);
            this.Filter.TabIndex = 30;
            this.Filter.TabStop = false;
            this.Filter.Text = "Filter";
            // 
            // textBox_FilterName
            // 
            this.textBox_FilterName.Location = new System.Drawing.Point(88, 76);
            this.textBox_FilterName.Name = "textBox_FilterName";
            this.textBox_FilterName.Size = new System.Drawing.Size(203, 31);
            this.textBox_FilterName.TabIndex = 16;
            // 
            // textBox_FilterId
            // 
            this.textBox_FilterId.Location = new System.Drawing.Point(88, 30);
            this.textBox_FilterId.MaxLength = 7;
            this.textBox_FilterId.Name = "textBox_FilterId";
            this.textBox_FilterId.Size = new System.Drawing.Size(204, 31);
            this.textBox_FilterId.TabIndex = 16;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(296, 150);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(94, 47);
            this.delete.TabIndex = 29;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(196, 149);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(94, 47);
            this.clear.TabIndex = 28;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_Id.Location = new System.Drawing.Point(146, 39);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(29, 31);
            this.label_Id.TabIndex = 27;
            this.label_Id.Text = "0";
            // 
            // listBox_Cities
            // 
            this.listBox_Cities.FormattingEnabled = true;
            this.listBox_Cities.ItemHeight = 25;
            this.listBox_Cities.Location = new System.Drawing.Point(462, 173);
            this.listBox_Cities.Name = "listBox_Cities";
            this.listBox_Cities.Size = new System.Drawing.Size(307, 304);
            this.listBox_Cities.TabIndex = 25;
            this.listBox_Cities.DoubleClick += new System.EventHandler(this.listBox_Cities_DoubleClick);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(96, 149);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(94, 47);
            this.save.TabIndex = 24;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_Name.Location = new System.Drawing.Point(6, 80);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(112, 37);
            this.label_Name.TabIndex = 17;
            this.label_Name.Text = " Name";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(152, 86);
            this.textBox_Name.MaxLength = 4000;
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(238, 31);
            this.textBox_Name.TabIndex = 16;
            // 
            // label_IdFilter
            // 
            this.label_IdFilter.AutoSize = true;
            this.label_IdFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label_IdFilter.Location = new System.Drawing.Point(6, 36);
            this.label_IdFilter.Name = "label_IdFilter";
            this.label_IdFilter.Size = new System.Drawing.Size(25, 24);
            this.label_IdFilter.TabIndex = 23;
            this.label_IdFilter.Text = "Id";
            // 
            // label_NameFilter
            // 
            this.label_NameFilter.AutoSize = true;
            this.label_NameFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label_NameFilter.Location = new System.Drawing.Point(6, 80);
            this.label_NameFilter.Name = "label_NameFilter";
            this.label_NameFilter.Size = new System.Drawing.Size(61, 24);
            this.label_NameFilter.TabIndex = 22;
            this.label_NameFilter.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.label_IdCity);
            this.groupBox1.Controls.Add(this.label_Name);
            this.groupBox1.Controls.Add(this.textBox_Name);
            this.groupBox1.Controls.Add(this.label_Id);
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.clear);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Location = new System.Drawing.Point(22, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 221);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Update";
            // 
            // label_IdCity
            // 
            this.label_IdCity.AutoSize = true;
            this.label_IdCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_IdCity.Location = new System.Drawing.Point(6, 36);
            this.label_IdCity.Name = "label_IdCity";
            this.label_IdCity.Size = new System.Drawing.Size(52, 37);
            this.label_IdCity.TabIndex = 30;
            this.label_IdCity.Text = " Id";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PromoFinal_CarmellWasserman.Properties.Resources.chunk_the_groundhog_chunk3;
            this.pictureBox1.Location = new System.Drawing.Point(22, 272);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(416, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // Form_City
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(796, 498);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.listBox_Cities);
            this.Name = "Form_City";
            this.Text = "Form_City";
            this.Filter.ResumeLayout(false);
            this.Filter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Filter;
        private System.Windows.Forms.TextBox textBox_FilterName;
        private System.Windows.Forms.TextBox textBox_FilterId;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.ListBox listBox_Cities;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_IdFilter;
        private System.Windows.Forms.Label label_NameFilter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_IdCity;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}