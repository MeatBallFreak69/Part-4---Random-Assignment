
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
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.btnInt = new System.Windows.Forms.Button();
            this.btnDbl = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.nudDecimal = new System.Windows.Forms.NumericUpDown();
            this.lblDecimals = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(13, 13);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(368, 13);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Enter a minimum and maximum value to get your random number";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(13, 44);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(55, 13);
            this.lblMin.TabIndex = 1;
            this.lblMin.Text = "Minimum";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.Location = new System.Drawing.Point(13, 67);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(58, 13);
            this.lblMax.TabIndex = 2;
            this.lblMax.Text = "Maximum";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(74, 41);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(119, 20);
            this.txtMin.TabIndex = 3;
            this.txtMin.TextChanged += new System.EventHandler(this.txtMin_TextChanged);
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(74, 64);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(119, 20);
            this.txtMax.TabIndex = 4;
            this.txtMax.TextChanged += new System.EventHandler(this.txtMax_TextChanged);
            // 
            // btnInt
            // 
            this.btnInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInt.Location = new System.Drawing.Point(16, 90);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(84, 23);
            this.btnInt.TabIndex = 5;
            this.btnInt.Text = "Get Integer";
            this.btnInt.UseVisualStyleBackColor = true;
            this.btnInt.Click += new System.EventHandler(this.btnInt_Click);
            // 
            // btnDbl
            // 
            this.btnDbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDbl.Location = new System.Drawing.Point(109, 90);
            this.btnDbl.Name = "btnDbl";
            this.btnDbl.Size = new System.Drawing.Size(84, 23);
            this.btnDbl.TabIndex = 6;
            this.btnDbl.Text = "Get Double";
            this.btnDbl.UseVisualStyleBackColor = true;
            this.btnDbl.Click += new System.EventHandler(this.btnDbl_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(13, 129);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(11, 13);
            this.lblResults.TabIndex = 7;
            this.lblResults.Text = ":";
            // 
            // nudDecimal
            // 
            this.nudDecimal.Location = new System.Drawing.Point(199, 93);
            this.nudDecimal.Name = "nudDecimal";
            this.nudDecimal.Size = new System.Drawing.Size(38, 20);
            this.nudDecimal.TabIndex = 8;
            this.nudDecimal.ValueChanged += new System.EventHandler(this.nudDecimal_ValueChanged);
            // 
            // lblDecimals
            // 
            this.lblDecimals.AutoSize = true;
            this.lblDecimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecimals.Location = new System.Drawing.Point(243, 90);
            this.lblDecimals.Name = "lblDecimals";
            this.lblDecimals.Size = new System.Drawing.Size(114, 26);
            this.lblDecimals.TabIndex = 9;
            this.lblDecimals.Text = "Change number of \r\ndecimals here";
            // 
            // RandomNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(391, 174);
            this.Controls.Add(this.lblDecimals);
            this.Controls.Add(this.nudDecimal);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnDbl);
            this.Controls.Add(this.btnInt);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblInstructions);
            this.Name = "RandomNumbers";
            this.Text = "Random Numbers";
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button btnDbl;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.NumericUpDown nudDecimal;
        private System.Windows.Forms.Label lblDecimals;
    }
}

