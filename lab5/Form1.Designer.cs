namespace lab5
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
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.ButtonGeneratePoly = new System.Windows.Forms.Button();
            this.NumericPolyCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize) (this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.NumericPolyCount)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(12, 12);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(400, 400);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 500;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // ButtonGeneratePoly
            // 
            this.ButtonGeneratePoly.Location = new System.Drawing.Point(418, 41);
            this.ButtonGeneratePoly.Name = "ButtonGeneratePoly";
            this.ButtonGeneratePoly.Size = new System.Drawing.Size(121, 23);
            this.ButtonGeneratePoly.TabIndex = 1;
            this.ButtonGeneratePoly.Text = "Отрисовать";
            this.ButtonGeneratePoly.UseVisualStyleBackColor = true;
            this.ButtonGeneratePoly.Click += new System.EventHandler(this.ButtonGeneratePoly_Click);
            // 
            // NumericPolyCount
            // 
            this.NumericPolyCount.Location = new System.Drawing.Point(418, 12);
            this.NumericPolyCount.Name = "NumericPolyCount";
            this.NumericPolyCount.Size = new System.Drawing.Size(121, 23);
            this.NumericPolyCount.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 423);
            this.Controls.Add(this.NumericPolyCount);
            this.Controls.Add(this.ButtonGeneratePoly);
            this.Controls.Add(this.PictureBox);
            this.Name = "Form1";
            this.Text = "Алгоритм с использованием Z-буфера";
            ((System.ComponentModel.ISupportInitialize) (this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.NumericPolyCount)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.NumericUpDown NumericPolyCount;
        private System.Windows.Forms.Button ButtonGeneratePoly;
    }
}