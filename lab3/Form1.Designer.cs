namespace lab3
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
            this.ButtonRotateUp = new System.Windows.Forms.Button();
            this.ButtonRotateReset = new System.Windows.Forms.Button();
            this.ButtonRotateDown = new System.Windows.Forms.Button();
            this.ButtonRotateLeft = new System.Windows.Forms.Button();
            this.ButtonRotateRight = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
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
            // 
            // ButtonRotateUp
            // 
            this.ButtonRotateUp.Location = new System.Drawing.Point(444, 157);
            this.ButtonRotateUp.Name = "ButtonRotateUp";
            this.ButtonRotateUp.Size = new System.Drawing.Size(23, 23);
            this.ButtonRotateUp.TabIndex = 1;
            this.ButtonRotateUp.Text = "↑";
            this.ButtonRotateUp.UseVisualStyleBackColor = true;
            this.ButtonRotateUp.Click += new System.EventHandler(this.ButtonRotateUp_Click);
            // 
            // ButtonRotateReset
            // 
            this.ButtonRotateReset.Location = new System.Drawing.Point(444, 186);
            this.ButtonRotateReset.Name = "ButtonRotateReset";
            this.ButtonRotateReset.Size = new System.Drawing.Size(23, 23);
            this.ButtonRotateReset.TabIndex = 2;
            this.ButtonRotateReset.Text = "⥀";
            this.ButtonRotateReset.UseVisualStyleBackColor = true;
            this.ButtonRotateReset.Click += new System.EventHandler(this.ButtonRotateReset_Click);
            // 
            // ButtonRotateDown
            // 
            this.ButtonRotateDown.Location = new System.Drawing.Point(444, 215);
            this.ButtonRotateDown.Name = "ButtonRotateDown";
            this.ButtonRotateDown.Size = new System.Drawing.Size(23, 23);
            this.ButtonRotateDown.TabIndex = 3;
            this.ButtonRotateDown.Text = "↓";
            this.ButtonRotateDown.UseVisualStyleBackColor = true;
            this.ButtonRotateDown.Click += new System.EventHandler(this.ButtonRotateDown_Click);
            // 
            // ButtonRotateLeft
            // 
            this.ButtonRotateLeft.Location = new System.Drawing.Point(415, 186);
            this.ButtonRotateLeft.Name = "ButtonRotateLeft";
            this.ButtonRotateLeft.Size = new System.Drawing.Size(23, 23);
            this.ButtonRotateLeft.TabIndex = 4;
            this.ButtonRotateLeft.Text = "←";
            this.ButtonRotateLeft.UseVisualStyleBackColor = true;
            this.ButtonRotateLeft.Click += new System.EventHandler(this.ButtonRotateLeft_Click);
            // 
            // ButtonRotateRight
            // 
            this.ButtonRotateRight.Location = new System.Drawing.Point(472, 186);
            this.ButtonRotateRight.Name = "ButtonRotateRight";
            this.ButtonRotateRight.Size = new System.Drawing.Size(23, 23);
            this.ButtonRotateRight.TabIndex = 5;
            this.ButtonRotateRight.Text = "→";
            this.ButtonRotateRight.UseVisualStyleBackColor = true;
            this.ButtonRotateRight.Click += new System.EventHandler(this.ButtonRotateRight_Click);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 32;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(405, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Вращение";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 383);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonRotateRight);
            this.Controls.Add(this.ButtonRotateLeft);
            this.Controls.Add(this.ButtonRotateDown);
            this.Controls.Add(this.ButtonRotateReset);
            this.Controls.Add(this.ButtonRotateUp);
            this.Controls.Add(this.PictureBox);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Билинейная поверхность";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize) (this.PictureBox)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonRotateRight;
        private System.Windows.Forms.Button ButtonRotateLeft;
        private System.Windows.Forms.Button ButtonRotateUp;
        private System.Windows.Forms.Button ButtonRotateDown;
        private System.Windows.Forms.Button ButtonRotateReset;
    }
}