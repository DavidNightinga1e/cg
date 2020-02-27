namespace lab2
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
            this.ButtonClearScreen = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize) (this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(12, 12);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(360, 360);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            this.PictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ButtonClearScreen
            // 
            this.ButtonClearScreen.Location = new System.Drawing.Point(378, 12);
            this.ButtonClearScreen.Name = "ButtonClearScreen";
            this.ButtonClearScreen.Size = new System.Drawing.Size(154, 23);
            this.ButtonClearScreen.TabIndex = 1;
            this.ButtonClearScreen.Text = "Очистить";
            this.ButtonClearScreen.UseVisualStyleBackColor = true;
            this.ButtonClearScreen.Click += new System.EventHandler(this.ButtonClearScreen_Click);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 32;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 383);
            this.Controls.Add(this.ButtonClearScreen);
            this.Controls.Add(this.PictureBox);
            this.Name = "Form1";
            this.Text = "Кривая Безье";
            ((System.ComponentModel.ISupportInitialize) (this.PictureBox)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button ButtonClearScreen;
    }
}