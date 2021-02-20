
namespace Part_4___Random_Assignment
{
    partial class RandomNumbers
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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnInt = new System.Windows.Forms.Button();
            this.btnDbl = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(13, 13);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(180, 13);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Enter a minimum and maximum value";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(13, 44);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(48, 13);
            this.lblMin.TabIndex = 1;
            this.lblMin.Text = "Minimum";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(13, 67);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(51, 13);
            this.lblMax.TabIndex = 2;
            this.lblMax.Text = "Maximum";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(67, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(126, 20);
            this.textBox2.TabIndex = 4;
            // 
            // btnInt
            // 
            this.btnInt.Location = new System.Drawing.Point(16, 90);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(84, 23);
            this.btnInt.TabIndex = 5;
            this.btnInt.Text = "Get Integer";
            this.btnInt.UseVisualStyleBackColor = true;
            // 
            // btnDbl
            // 
            this.btnDbl.Location = new System.Drawing.Point(109, 90);
            this.btnDbl.Name = "btnDbl";
            this.btnDbl.Size = new System.Drawing.Size(84, 23);
            this.btnDbl.TabIndex = 6;
            this.btnDbl.Text = "Get Double";
            this.btnDbl.UseVisualStyleBackColor = true;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(16, 120);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(10, 13);
            this.lblResults.TabIndex = 7;
            this.lblResults.Text = ":";
            // 
            // RandomNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 176);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnDbl);
            this.Controls.Add(this.btnInt);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblInstructions);
            this.Name = "RandomNumbers";
            this.Text = "Random Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button btnDbl;
        private System.Windows.Forms.Label lblResults;
    }
}

