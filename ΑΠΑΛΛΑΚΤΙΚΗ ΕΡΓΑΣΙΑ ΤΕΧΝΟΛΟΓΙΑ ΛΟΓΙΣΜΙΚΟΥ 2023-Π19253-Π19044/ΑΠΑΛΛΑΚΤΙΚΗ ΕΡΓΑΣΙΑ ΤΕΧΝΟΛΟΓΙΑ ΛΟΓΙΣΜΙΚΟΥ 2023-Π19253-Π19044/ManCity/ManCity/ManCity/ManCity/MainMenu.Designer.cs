namespace ManCity
{
    partial class MainForm
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
            this.ShopBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ShopBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ShopBox
            // 
            this.ShopBox.BackColor = System.Drawing.Color.Transparent;
            this.ShopBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShopBox.Image = global::ManCity.Properties.Resources.ShopButton;
            this.ShopBox.Location = new System.Drawing.Point(777, 731);
            this.ShopBox.Margin = new System.Windows.Forms.Padding(4);
            this.ShopBox.Name = "ShopBox";
            this.ShopBox.Size = new System.Drawing.Size(324, 164);
            this.ShopBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShopBox.TabIndex = 0;
            this.ShopBox.TabStop = false;
            this.ShopBox.Click += new System.EventHandler(this.ShopBox_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ManCity.Properties.Resources.CloseButton;
            this.pictureBox1.Location = new System.Drawing.Point(1749, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ManCity.Properties.Resources.stadium2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1867, 983);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ShopBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShopBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ShopBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

