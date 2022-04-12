namespace IMM_Events_GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblResult = new System.Windows.Forms.Label();
            this.nudN = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 110);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 15);
            this.lblResult.TabIndex = 0;
            // 
            // nudN
            // 
            this.nudN.Location = new System.Drawing.Point(12, 12);
            this.nudN.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudN.Name = "nudN";
            this.nudN.Size = new System.Drawing.Size(439, 23);
            this.nudN.TabIndex = 1;
            this.nudN.Value = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.nudN.ValueChanged += new System.EventHandler(this.nudN_ValueChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 72);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(439, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(194, 41);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 134);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.nudN);
            this.Controls.Add(this.lblResult);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblResult;
        private NumericUpDown nudN;
        private ProgressBar progressBar1;
        private Button btnStart;
    }
}