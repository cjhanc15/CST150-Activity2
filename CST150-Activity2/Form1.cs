using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST150_Activity2
{
    public partial class BMICalculator : Form
    {
        public BMICalculator()
        {
            InitializeComponent();
        }

        private void BMICalculator_Load(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double height = double.Parse(userHeight.Text);
            double weight = double.Parse(userWeight.Text);
            height *= height;
            double bmi = weight / height;
            bmiLabel.Text = "Your BMI is: " + bmi;
        }
    }
}
