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

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //initialize height and weight, check if valid using TryParse
            double height;
            double weight;

            Boolean validHeight = double.TryParse(userHeight.Text, out height) && height > 0;
            Boolean validWeight = double.TryParse(userWeight.Text, out weight) && weight > 0;

            //if height and weight valid, bmi is calculated, error messages stay blank and unshown (prevents error from staying up after fixing errors)
            if(validHeight && validWeight)
            {
                double bmi = weight / (height *= height);
                bmi = Math.Round(bmi, 3);
                heightErrorMessage.Text = " ";
                weightErrorMessage.Text = " ";
                calculatedBMI.Text = bmi.ToString();
            }
            //invalid height, height error message and BMI is not calculated
            if(!validHeight)
            {
                heightErrorMessage.Text = "ERROR: Please enter a valid height in meters";
                calculatedBMI.Text = " ";
                if (validWeight) weightErrorMessage.Text = " ";
            }
            //invalid height, weight error message and BMI is not calculated

            if (!validWeight)
            {
                weightErrorMessage.Text = "ERROR: Please enter a valid weight in kilograms";
                calculatedBMI.Text = " ";
                if (validHeight) weightErrorMessage.Text = " ";
            }
        }
    }
}
