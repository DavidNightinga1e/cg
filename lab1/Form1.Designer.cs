namespace lab1
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
            this.components = new System.ComponentModel.Container();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.AngleSetupUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.RotateRightButton = new System.Windows.Forms.Button();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.RotateLeftButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.AngleSetupUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(12, 12);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(360, 360);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            this.PictureBox.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // AngleSetupUpDown
            // 
            this.AngleSetupUpDown.Location = new System.Drawing.Point(484, 36);
            this.AngleSetupUpDown.Maximum = new decimal(new int[] {360, 0, 0, 0});
            this.AngleSetupUpDown.Name = "AngleSetupUpDown";
            this.AngleSetupUpDown.Size = new System.Drawing.Size(48, 23);
            this.AngleSetupUpDown.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(378, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Угол:";
            // 
            // RotateRightButton
            // 
            this.RotateRightButton.Location = new System.Drawing.Point(465, 63);
            this.RotateRightButton.Name = "RotateRightButton";
            this.RotateRightButton.Size = new System.Drawing.Size(66, 23);
            this.RotateRightButton.TabIndex = 3;
            this.RotateRightButton.Text = "->";
            this.RotateRightButton.UseVisualStyleBackColor = true;
            this.RotateRightButton.Click += new System.EventHandler(this.RotateRightButton_Click);
            // 
            // MainTimer
            // 
            this.MainTimer.Enabled = true;
            this.MainTimer.Interval = 32;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // RotateLeftButton
            // 
            this.RotateLeftButton.Location = new System.Drawing.Point(392, 63);
            this.RotateLeftButton.Name = "RotateLeftButton";
            this.RotateLeftButton.Size = new System.Drawing.Size(66, 23);
            this.RotateLeftButton.TabIndex = 4;
            this.RotateLeftButton.Text = "<-";
            this.RotateLeftButton.UseVisualStyleBackColor = true;
            this.RotateLeftButton.Click += new System.EventHandler(this.RotateLeftButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 383);
            this.Controls.Add(this.RotateLeftButton);
            this.Controls.Add(this.RotateRightButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AngleSetupUpDown);
            this.Controls.Add(this.PictureBox);
            this.Name = "Form1";
            this.Text = "Поворот плоского объекта";
            ((System.ComponentModel.ISupportInitialize) (this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.AngleSetupUpDown)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown AngleSetupUpDown;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button RotateLeftButton;
        private System.Windows.Forms.Button RotateRightButton;
    }
}