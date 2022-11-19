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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMICalculator));
            this.calculateButton = new System.Windows.Forms.Button();
            this.userHeight = new System.Windows.Forms.TextBox();
            this.userWeight = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.bmiLabel = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.heightErrorMessage = new System.Windows.Forms.Label();
            this.weightErrorMessage = new System.Windows.Forms.Label();
            this.calculatedBMI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.calculateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculateButton.Font = new System.Drawing.Font("Verdana", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(56)))), ((int)(((byte)(121)))));
            this.calculateButton.Location = new System.Drawing.Point(533, 602);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(6);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(458, 108);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "CALCULATE";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // userHeight
            // 
            this.userHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.userHeight.Font = new System.Drawing.Font("MS PGothic", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(56)))), ((int)(((byte)(121)))));
            this.userHeight.Location = new System.Drawing.Point(795, 289);
            this.userHeight.Margin = new System.Windows.Forms.Padding(6);
            this.userHeight.Name = "userHeight";
            this.userHeight.Size = new System.Drawing.Size(326, 50);
            this.userHeight.TabIndex = 1;
            // 
            // userWeight
            // 
            this.userWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.userWeight.Font = new System.Drawing.Font("MS Gothic", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(56)))), ((int)(((byte)(121)))));
            this.userWeight.Location = new System.Drawing.Point(795, 430);
            this.userWeight.Margin = new System.Windows.Forms.Padding(6);
            this.userWeight.Name = "userWeight";
            this.userWeight.Size = new System.Drawing.Size(326, 50);
            this.userWeight.TabIndex = 2;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("MS Gothic", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(56)))), ((int)(((byte)(121)))));
            this.heightLabel.Location = new System.Drawing.Point(438, 296);
            this.heightLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(349, 43);
            this.heightLabel.TabIndex = 3;
            this.heightLabel.Text = "Height(meters):";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("MS Gothic", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(56)))), ((int)(((byte)(121)))));
            this.weightLabel.Location = new System.Drawing.Point(372, 437);
            this.weightLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(415, 43);
            this.weightLabel.TabIndex = 4;
            this.weightLabel.Text = "Weight(kilograms):";
            // 
            // bmiLabel
            // 
            this.bmiLabel.Font = new System.Drawing.Font("MS Gothic", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmiLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(56)))), ((int)(((byte)(121)))));
            this.bmiLabel.Location = new System.Drawing.Point(0, 801);
            this.bmiLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.bmiLabel.Name = "bmiLabel";
            this.bmiLabel.Size = new System.Drawing.Size(787, 48);
            this.bmiLabel.TabIndex = 5;
            this.bmiLabel.Text = "Your BMI is:";
            this.bmiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.title.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(1505, 217);
            this.title.TabIndex = 6;
            this.title.Text = "BMI Calculator";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heightErrorMessage
            // 
            this.heightErrorMessage.AutoSize = true;
            this.heightErrorMessage.ForeColor = System.Drawing.Color.DarkRed;
            this.heightErrorMessage.Location = new System.Drawing.Point(794, 351);
            this.heightErrorMessage.Name = "heightErrorMessage";
            this.heightErrorMessage.Size = new System.Drawing.Size(18, 25);
            this.heightErrorMessage.TabIndex = 7;
            this.heightErrorMessage.Text = " ";
            // 
            // weightErrorMessage
            // 
            this.weightErrorMessage.AutoSize = true;
            this.weightErrorMessage.ForeColor = System.Drawing.Color.DarkRed;
            this.weightErrorMessage.Location = new System.Drawing.Point(794, 492);
            this.weightErrorMessage.Name = "weightErrorMessage";
            this.weightErrorMessage.Size = new System.Drawing.Size(18, 25);
            this.weightErrorMessage.TabIndex = 8;
            this.weightErrorMessage.Text = " ";
            // 
            // calculatedBMI
            // 
            this.calculatedBMI.Font = new System.Drawing.Font("MS Gothic", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatedBMI.ForeColor = System.Drawing.Color.DarkRed;
            this.calculatedBMI.Location = new System.Drawing.Point(786, 801);
            this.calculatedBMI.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.calculatedBMI.Name = "calculatedBMI";
            this.calculatedBMI.Size = new System.Drawing.Size(719, 48);
            this.calculatedBMI.TabIndex = 9;
            this.calculatedBMI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(227)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(1506, 976);
            this.Controls.Add(this.calculatedBMI);
            this.Controls.Add(this.weightErrorMessage);
            this.Controls.Add(this.heightErrorMessage);
            this.Controls.Add(this.title);
            this.Controls.Add(this.bmiLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.userWeight);
            this.Controls.Add(this.userHeight);
            this.Controls.Add(this.calculateButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "BMICalculator";
            this.Text = "BMI Calculator";
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
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label heightErrorMessage;
        private System.Windows.Forms.Label weightErrorMessage;
        private System.Windows.Forms.Label calculatedBMI;
    }
}

