namespace Resturant_App
{
    partial class UpdateItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateItemForm));
            this.button2 = new System.Windows.Forms.Button();
            this.Iprice = new System.Windows.Forms.TextBox();
            this.Iname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Buxton Sketch", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(296, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 48);
            this.button2.TabIndex = 13;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Iprice
            // 
            this.Iprice.Font = new System.Drawing.Font("Buxton Sketch", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Iprice.Location = new System.Drawing.Point(253, 188);
            this.Iprice.Name = "Iprice";
            this.Iprice.Size = new System.Drawing.Size(259, 48);
            this.Iprice.TabIndex = 12;
            // 
            // Iname
            // 
            this.Iname.Font = new System.Drawing.Font("Buxton Sketch", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Iname.Location = new System.Drawing.Point(253, 83);
            this.Iname.Name = "Iname";
            this.Iname.Size = new System.Drawing.Size(259, 48);
            this.Iname.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Buxton Sketch", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(87, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 41);
            this.label3.TabIndex = 10;
            this.label3.Text = "Item price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Buxton Sketch", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(87, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 41);
            this.label2.TabIndex = 9;
            this.label2.Text = "Item name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Buxton Sketch", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(443, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "Back to dashboard";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Buxton Sketch", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(276, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 41);
            this.label1.TabIndex = 7;
            this.label1.Text = "Update item";
            // 
            // UpdateItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(703, 363);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Iprice);
            this.Controls.Add(this.Iname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "UpdateItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateItemForm";
            this.Load += new System.EventHandler(this.UpdateItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button2;
        private TextBox Iprice;
        private TextBox Iname;
        private Label label3;
        private Label label2;
        private Button button1;
        private Label label1;
    }
}