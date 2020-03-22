namespace lab4
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
            this.ButtonGenerate = new System.Windows.Forms.Button();
            this.ButtonProcess = new System.Windows.Forms.Button();
            this.NumericLinesCount = new System.Windows.Forms.NumericUpDown();
            this.ButtonGenerateAndClip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.NumericLinesCount)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(12, 12);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(420, 420);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 32;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // ButtonGenerate
            // 
            this.ButtonGenerate.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonGenerate.Location = new System.Drawing.Point(441, 42);
            this.ButtonGenerate.Name = "ButtonGenerate";
            this.ButtonGenerate.Size = new System.Drawing.Size(201, 28);
            this.ButtonGenerate.TabIndex = 1;
            this.ButtonGenerate.Text = "Сгенерировать отрезки";
            this.ButtonGenerate.UseVisualStyleBackColor = true;
            this.ButtonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
            // 
            // ButtonProcess
            // 
            this.ButtonProcess.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonProcess.Location = new System.Drawing.Point(441, 75);
            this.ButtonProcess.Name = "ButtonProcess";
            this.ButtonProcess.Size = new System.Drawing.Size(201, 28);
            this.ButtonProcess.TabIndex = 2;
            this.ButtonProcess.Text = "Отсечь";
            this.ButtonProcess.UseVisualStyleBackColor = true;
            this.ButtonProcess.Click += new System.EventHandler(this.ButtonProcess_Click);
            // 
            // NumericLinesCount
            // 
            this.NumericLinesCount.Location = new System.Drawing.Point(441, 12);
            this.NumericLinesCount.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.NumericLinesCount.Name = "NumericLinesCount";
            this.NumericLinesCount.Size = new System.Drawing.Size(201, 23);
            this.NumericLinesCount.TabIndex = 3;
            this.NumericLinesCount.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // ButtonGenerateAndClip
            // 
            this.ButtonGenerateAndClip.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonGenerateAndClip.BackColor = System.Drawing.Color.Honeydew;
            this.ButtonGenerateAndClip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonGenerateAndClip.Location = new System.Drawing.Point(441, 143);
            this.ButtonGenerateAndClip.Name = "ButtonGenerateAndClip";
            this.ButtonGenerateAndClip.Size = new System.Drawing.Size(201, 28);
            this.ButtonGenerateAndClip.TabIndex = 5;
            this.ButtonGenerateAndClip.Text = "Сгенерировать и отсечь";
            this.ButtonGenerateAndClip.UseVisualStyleBackColor = false;
            this.ButtonGenerateAndClip.Click += new System.EventHandler(this.ButtonGenerateAndClip_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 449);
            this.Controls.Add(this.ButtonGenerateAndClip);
            this.Controls.Add(this.NumericLinesCount);
            this.Controls.Add(this.ButtonProcess);
            this.Controls.Add(this.ButtonGenerate);
            this.Controls.Add(this.PictureBox);
            this.Name = "Form1";
            this.Text = "Алгоритм Коэна-Сазерленда";
            ((System.ComponentModel.ISupportInitialize) (this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.NumericLinesCount)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button ButtonProcess;
        private System.Windows.Forms.Button ButtonGenerate;
        private System.Windows.Forms.NumericUpDown NumericLinesCount;
        private System.Windows.Forms.Button ButtonGenerateAndClip;
    }
}