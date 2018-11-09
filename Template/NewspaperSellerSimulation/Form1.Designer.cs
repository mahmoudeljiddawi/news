namespace NewspaperSellerSimulation
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
            this.read_data = new System.Windows.Forms.Button();
            this.simulate = new System.Windows.Forms.Button();
            this.testcase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // read_data
            // 
            this.read_data.Location = new System.Drawing.Point(15, 202);
            this.read_data.Name = "read_data";
            this.read_data.Size = new System.Drawing.Size(113, 36);
            this.read_data.TabIndex = 0;
            this.read_data.Text = "Read Data";
            this.read_data.UseVisualStyleBackColor = true;
            this.read_data.Click += new System.EventHandler(this.read_data_Click);
            // 
            // simulate
            // 
            this.simulate.Location = new System.Drawing.Point(145, 202);
            this.simulate.Name = "simulate";
            this.simulate.Size = new System.Drawing.Size(113, 36);
            this.simulate.TabIndex = 1;
            this.simulate.Text = "Simulate";
            this.simulate.UseVisualStyleBackColor = true;
            this.simulate.Click += new System.EventHandler(this.simulate_Click);
            // 
            // testcase
            // 
            this.testcase.Location = new System.Drawing.Point(145, 122);
            this.testcase.Name = "testcase";
            this.testcase.Size = new System.Drawing.Size(100, 20);
            this.testcase.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Test Case Number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.testcase);
            this.Controls.Add(this.simulate);
            this.Controls.Add(this.read_data);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button read_data;
        private System.Windows.Forms.Button simulate;
        private System.Windows.Forms.TextBox testcase;
        private System.Windows.Forms.Label label1;
    }
}