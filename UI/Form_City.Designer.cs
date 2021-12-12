
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
            this.Filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // Filter
            // 
            this.Filter.Controls.Add(this.textBox_FilterName);
            this.Filter.Controls.Add(this.textBox_FilterId);
            this.Filter.Location = new System.Drawing.Point(573, 250);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(298, 153);
            this.Filter.TabIndex = 30;
            this.Filter.TabStop = false;
            this.Filter.Text = "Filter";
            // 
            // textBox_FilterName
            // 
            this.textBox_FilterName.Location = new System.Drawing.Point(6, 69);
            this.textBox_FilterName.Name = "textBox_FilterName";
            this.textBox_FilterName.Size = new System.Drawing.Size(214, 31);
            this.textBox_FilterName.TabIndex = 16;
            // 
            // textBox_FilterId
            // 
            this.textBox_FilterId.Location = new System.Drawing.Point(6, 30);
            this.textBox_FilterId.MaxLength = 7;
            this.textBox_FilterId.Name = "textBox_FilterId";
            this.textBox_FilterId.Size = new System.Drawing.Size(214, 31);
            this.textBox_FilterId.TabIndex = 16;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(390, 356);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(94, 47);
            this.delete.TabIndex = 29;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(390, 303);
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
            this.label_Id.Location = new System.Drawing.Point(265, -2);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(24, 25);
            this.label_Id.TabIndex = 27;
            this.label_Id.Text = "0";
            // 
            // listBox_Cities
            // 
            this.listBox_Cities.FormattingEnabled = true;
            this.listBox_Cities.ItemHeight = 25;
            this.listBox_Cities.Location = new System.Drawing.Point(573, 29);
            this.listBox_Cities.Name = "listBox_Cities";
            this.listBox_Cities.Size = new System.Drawing.Size(298, 204);
            this.listBox_Cities.TabIndex = 25;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(390, 250);
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
            this.label_Name.Location = new System.Drawing.Point(11, 23);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(112, 37);
            this.label_Name.TabIndex = 17;
            this.label_Name.Text = " Name";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(270, 29);
            this.textBox_Name.MaxLength = 4000;
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(214, 31);
            this.textBox_Name.TabIndex = 16;
            // 
            // Form_City
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 450);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label_Id);
            this.Controls.Add(this.listBox_Cities);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.textBox_Name);
            this.Name = "Form_City";
            this.Text = "Form_City";
            this.Filter.ResumeLayout(false);
            this.Filter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}