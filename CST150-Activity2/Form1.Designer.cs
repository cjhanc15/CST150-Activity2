namespace CST150_Activity2
{
    partial class BMICalculator
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.userHeight = new System.Windows.Forms.TextBox();
            this.userWeight = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.bmiLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(222, 248);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(229, 56);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // userHeight
            // 
            this.userHeight.Location = new System.Drawing.Point(286, 90);
            this.userHeight.Name = "userHeight";
            this.userHeight.Size = new System.Drawing.Size(165, 20);
            this.userHeight.TabIndex = 1;
            // 
            // userWeight
            // 
            this.userWeight.Location = new System.Drawing.Point(286, 166);
            this.userWeight.Name = "userWeight";
            this.userWeight.Size = new System.Drawing.Size(165, 20);
            this.userWeight.TabIndex = 2;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(222, 96);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(41, 13);
            this.heightLabel.TabIndex = 3;
            this.heightLabel.Text = "Height:";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(222, 173);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(44, 13);
            this.weightLabel.TabIndex = 4;
            this.weightLabel.Text = "Weight:";
            // 
            // bmiLabel
            // 
            this.bmiLabel.AutoSize = true;
            this.bmiLabel.Location = new System.Drawing.Point(283, 328);
            this.bmiLabel.Name = "bmiLabel";
            this.bmiLabel.Size = new System.Drawing.Size(64, 13);
            this.bmiLabel.TabIndex = 5;
            this.bmiLabel.Text = "Your BMI is:";
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 455);
            this.Controls.Add(this.bmiLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.userWeight);
            this.Controls.Add(this.userHeight);
            this.Controls.Add(this.calculateButton);
            this.Name = "BMICalculator";
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.BMICalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox userHeight;
        private System.Windows.Forms.TextBox userWeight;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label bmiLabel;
    }
}

