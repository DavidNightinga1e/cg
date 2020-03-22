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
            this.NumericSurfacePointTLX = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NumericSurfacePointTRX = new System.Windows.Forms.NumericUpDown();
            this.NumericSurfacePointBLX = new System.Windows.Forms.NumericUpDown();
            this.NumericSurfacePointBRX = new System.Windows.Forms.NumericUpDown();
            this.NumericSurfacePointBRY = new System.Windows.Forms.NumericUpDown();
            this.NumericSurfacePointBLY = new System.Windows.Forms.NumericUpDown();
            this.NumericSurfacePointTRY = new System.Windows.Forms.NumericUpDown();
            this.NumericSurfacePointTLY = new System.Windows.Forms.NumericUpDown();
            this.NumericSurfacePointBRZ = new System.Windows.Forms.NumericUpDown();
            this.NumericSurfacePointBLZ = new System.Windows.Forms.NumericUpDown();
            this.NumericSurfacePointTRZ = new System.Windows.Forms.NumericUpDown();
            this.NumericSurfacePointTLZ = new System.Windows.Forms.NumericUpDown();
            this.ButtonAccept = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.NumericSurfacePointTLX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.NumericSurfacePointTRX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.NumericSurfacePointBLX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.NumericSurfacePointBRX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.NumericSurfacePointBRY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.NumericSurfacePointBLY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.NumericSurfacePointTRY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.NumericSurfacePointTLY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.NumericSurfacePointBRZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.NumericSurfacePointBLZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.NumericSurfacePointTRZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.NumericSurfacePointTLZ)).BeginInit();
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
            this.ButtonRotateUp.Location = new System.Drawing.Point(500, 53);
            this.ButtonRotateUp.Name = "ButtonRotateUp";
            this.ButtonRotateUp.Size = new System.Drawing.Size(23, 23);
            this.ButtonRotateUp.TabIndex = 1;
            this.ButtonRotateUp.Text = "↑";
            this.ButtonRotateUp.UseVisualStyleBackColor = true;
            this.ButtonRotateUp.Click += new System.EventHandler(this.ButtonRotateUp_Click);
            // 
            // ButtonRotateReset
            // 
            this.ButtonRotateReset.Location = new System.Drawing.Point(500, 82);
            this.ButtonRotateReset.Name = "ButtonRotateReset";
            this.ButtonRotateReset.Size = new System.Drawing.Size(23, 23);
            this.ButtonRotateReset.TabIndex = 2;
            this.ButtonRotateReset.Text = "⥀";
            this.ButtonRotateReset.UseVisualStyleBackColor = true;
            this.ButtonRotateReset.Click += new System.EventHandler(this.ButtonRotateReset_Click);
            // 
            // ButtonRotateDown
            // 
            this.ButtonRotateDown.Location = new System.Drawing.Point(500, 111);
            this.ButtonRotateDown.Name = "ButtonRotateDown";
            this.ButtonRotateDown.Size = new System.Drawing.Size(23, 23);
            this.ButtonRotateDown.TabIndex = 3;
            this.ButtonRotateDown.Text = "↓";
            this.ButtonRotateDown.UseVisualStyleBackColor = true;
            this.ButtonRotateDown.Click += new System.EventHandler(this.ButtonRotateDown_Click);
            // 
            // ButtonRotateLeft
            // 
            this.ButtonRotateLeft.Location = new System.Drawing.Point(472, 82);
            this.ButtonRotateLeft.Name = "ButtonRotateLeft";
            this.ButtonRotateLeft.Size = new System.Drawing.Size(23, 23);
            this.ButtonRotateLeft.TabIndex = 4;
            this.ButtonRotateLeft.Text = "←";
            this.ButtonRotateLeft.UseVisualStyleBackColor = true;
            this.ButtonRotateLeft.Click += new System.EventHandler(this.ButtonRotateLeft_Click);
            // 
            // ButtonRotateRight
            // 
            this.ButtonRotateRight.Location = new System.Drawing.Point(528, 82);
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
            this.label1.Location = new System.Drawing.Point(462, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Вращение";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumericSurfacePointTLX
            // 
            this.NumericSurfacePointTLX.Location = new System.Drawing.Point(470, 192);
            this.NumericSurfacePointTLX.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.NumericSurfacePointTLX.Minimum = new decimal(new int[] {1000, 0, 0, -2147483648});
            this.NumericSurfacePointTLX.Name = "NumericSurfacePointTLX";
            this.NumericSurfacePointTLX.Size = new System.Drawing.Size(54, 23);
            this.NumericSurfacePointTLX.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(485, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(545, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(608, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Z";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(378, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Top Left";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(378, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Top Right";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(378, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Bottom left";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(378, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Bottom right";
            // 
            // NumericSurfacePointTRX
            // 
            this.NumericSurfacePointTRX.Location = new System.Drawing.Point(470, 220);
            this.NumericSurfacePointTRX.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.NumericSurfacePointTRX.Minimum = new decimal(new int[] {1000, 0, 0, -2147483648});
            this.NumericSurfacePointTRX.Name = "NumericSurfacePointTRX";
            this.NumericSurfacePointTRX.Size = new System.Drawing.Size(54, 23);
            this.NumericSurfacePointTRX.TabIndex = 15;
            // 
            // NumericSurfacePointBLX
            // 
            this.NumericSurfacePointBLX.Location = new System.Drawing.Point(470, 249);
            this.NumericSurfacePointBLX.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.NumericSurfacePointBLX.Minimum = new decimal(new int[] {1000, 0, 0, -2147483648});
            this.NumericSurfacePointBLX.Name = "NumericSurfacePointBLX";
            this.NumericSurfacePointBLX.Size = new System.Drawing.Size(54, 23);
            this.NumericSurfacePointBLX.TabIndex = 16;
            // 
            // NumericSurfacePointBRX
            // 
            this.NumericSurfacePointBRX.Location = new System.Drawing.Point(470, 278);
            this.NumericSurfacePointBRX.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.NumericSurfacePointBRX.Minimum = new decimal(new int[] {1000, 0, 0, -2147483648});
            this.NumericSurfacePointBRX.Name = "NumericSurfacePointBRX";
            this.NumericSurfacePointBRX.Size = new System.Drawing.Size(54, 23);
            this.NumericSurfacePointBRX.TabIndex = 17;
            // 
            // NumericSurfacePointBRY
            // 
            this.NumericSurfacePointBRY.Location = new System.Drawing.Point(530, 278);
            this.NumericSurfacePointBRY.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.NumericSurfacePointBRY.Minimum = new decimal(new int[] {1000, 0, 0, -2147483648});
            this.NumericSurfacePointBRY.Name = "NumericSurfacePointBRY";
            this.NumericSurfacePointBRY.Size = new System.Drawing.Size(54, 23);
            this.NumericSurfacePointBRY.TabIndex = 21;
            // 
            // NumericSurfacePointBLY
            // 
            this.NumericSurfacePointBLY.Location = new System.Drawing.Point(530, 249);
            this.NumericSurfacePointBLY.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.NumericSurfacePointBLY.Minimum = new decimal(new int[] {1000, 0, 0, -2147483648});
            this.NumericSurfacePointBLY.Name = "NumericSurfacePointBLY";
            this.NumericSurfacePointBLY.Size = new System.Drawing.Size(54, 23);
            this.NumericSurfacePointBLY.TabIndex = 20;
            // 
            // NumericSurfacePointTRY
            // 
            this.NumericSurfacePointTRY.Location = new System.Drawing.Point(530, 220);
            this.NumericSurfacePointTRY.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.NumericSurfacePointTRY.Minimum = new decimal(new int[] {1000, 0, 0, -2147483648});
            this.NumericSurfacePointTRY.Name = "NumericSurfacePointTRY";
            this.NumericSurfacePointTRY.Size = new System.Drawing.Size(54, 23);
            this.NumericSurfacePointTRY.TabIndex = 19;
            // 
            // NumericSurfacePointTLY
            // 
            this.NumericSurfacePointTLY.Location = new System.Drawing.Point(530, 192);
            this.NumericSurfacePointTLY.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.NumericSurfacePointTLY.Minimum = new decimal(new int[] {1000, 0, 0, -2147483648});
            this.NumericSurfacePointTLY.Name = "NumericSurfacePointTLY";
            this.NumericSurfacePointTLY.Size = new System.Drawing.Size(54, 23);
            this.NumericSurfacePointTLY.TabIndex = 18;
            // 
            // NumericSurfacePointBRZ
            // 
            this.NumericSurfacePointBRZ.Location = new System.Drawing.Point(593, 278);
            this.NumericSurfacePointBRZ.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.NumericSurfacePointBRZ.Minimum = new decimal(new int[] {1000, 0, 0, -2147483648});
            this.NumericSurfacePointBRZ.Name = "NumericSurfacePointBRZ";
            this.NumericSurfacePointBRZ.Size = new System.Drawing.Size(54, 23);
            this.NumericSurfacePointBRZ.TabIndex = 25;
            // 
            // NumericSurfacePointBLZ
            // 
            this.NumericSurfacePointBLZ.Location = new System.Drawing.Point(593, 249);
            this.NumericSurfacePointBLZ.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.NumericSurfacePointBLZ.Minimum = new decimal(new int[] {1000, 0, 0, -2147483648});
            this.NumericSurfacePointBLZ.Name = "NumericSurfacePointBLZ";
            this.NumericSurfacePointBLZ.Size = new System.Drawing.Size(54, 23);
            this.NumericSurfacePointBLZ.TabIndex = 24;
            // 
            // NumericSurfacePointTRZ
            // 
            this.NumericSurfacePointTRZ.Location = new System.Drawing.Point(593, 220);
            this.NumericSurfacePointTRZ.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.NumericSurfacePointTRZ.Minimum = new decimal(new int[] {1000, 0, 0, -2147483648});
            this.NumericSurfacePointTRZ.Name = "NumericSurfacePointTRZ";
            this.NumericSurfacePointTRZ.Size = new System.Drawing.Size(54, 23);
            this.NumericSurfacePointTRZ.TabIndex = 23;
            // 
            // NumericSurfacePointTLZ
            // 
            this.NumericSurfacePointTLZ.Location = new System.Drawing.Point(593, 192);
            this.NumericSurfacePointTLZ.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.NumericSurfacePointTLZ.Minimum = new decimal(new int[] {1000, 0, 0, -2147483648});
            this.NumericSurfacePointTLZ.Name = "NumericSurfacePointTLZ";
            this.NumericSurfacePointTLZ.Size = new System.Drawing.Size(54, 23);
            this.NumericSurfacePointTLZ.TabIndex = 22;
            // 
            // ButtonAccept
            // 
            this.ButtonAccept.Location = new System.Drawing.Point(470, 307);
            this.ButtonAccept.Name = "ButtonAccept";
            this.ButtonAccept.Size = new System.Drawing.Size(177, 27);
            this.ButtonAccept.TabIndex = 26;
            this.ButtonAccept.Text = "Применить";
            this.ButtonAccept.UseVisualStyleBackColor = true;
            this.ButtonAccept.Click += new System.EventHandler(this.ButtonAccept_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(378, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 27);
            this.button1.TabIndex = 27;
            this.button1.Text = "Случайно";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 383);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonAccept);
            this.Controls.Add(this.NumericSurfacePointBRZ);
            this.Controls.Add(this.NumericSurfacePointBLZ);
            this.Controls.Add(this.NumericSurfacePointTRZ);
            this.Controls.Add(this.NumericSurfacePointTLZ);
            this.Controls.Add(this.NumericSurfacePointBRY);
            this.Controls.Add(this.NumericSurfacePointBLY);
            this.Controls.Add(this.NumericSurfacePointTRY);
            this.Controls.Add(this.NumericSurfacePointTLY);
            this.Controls.Add(this.NumericSurfacePointBRX);
            this.Controls.Add(this.NumericSurfacePointBLX);
            this.Controls.Add(this.NumericSurfacePointTRX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumericSurfacePointTLX);
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
            ((System.ComponentModel.ISupportInitialize) (this.NumericSurfacePointTLX)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.NumericSurfacePointTRX)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.NumericSurfacePointBLX)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.NumericSurfacePointBRX)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.NumericSurfacePointBRY)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.NumericSurfacePointBLY)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.NumericSurfacePointTRY)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.NumericSurfacePointTLY)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.NumericSurfacePointBRZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.NumericSurfacePointBLZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.NumericSurfacePointTRZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.NumericSurfacePointTLZ)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumericSurfacePointTLX;
        private System.Windows.Forms.Button ButtonAccept;
        private System.Windows.Forms.NumericUpDown NumericSurfacePointTLZ;
        private System.Windows.Forms.NumericUpDown NumericSurfacePointTRZ;
        private System.Windows.Forms.NumericUpDown NumericSurfacePointBLZ;
        private System.Windows.Forms.NumericUpDown NumericSurfacePointTLY;
        private System.Windows.Forms.NumericUpDown NumericSurfacePointTRY;
        private System.Windows.Forms.NumericUpDown NumericSurfacePointBLY;
        private System.Windows.Forms.NumericUpDown NumericSurfacePointBLX;
        private System.Windows.Forms.NumericUpDown NumericSurfacePointTRX;
        private System.Windows.Forms.NumericUpDown NumericSurfacePointBRZ;
        private System.Windows.Forms.NumericUpDown NumericSurfacePointBRY;
        private System.Windows.Forms.NumericUpDown NumericSurfacePointBRX;
        private System.Windows.Forms.Button button1;
    }
}