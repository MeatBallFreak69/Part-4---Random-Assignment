using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_4___Random_Assignment
{
    public partial class RandomNumbers : Form
    {
        Random generator = new Random();
        string strMin;
        string strMax;
        int intDecimals;
        public RandomNumbers()
        {
            InitializeComponent();
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            int intMin;
            int intMax;
            int.TryParse(strMin, out intMin);
            int.TryParse(strMax, out intMax);
            lblResults.Text = Convert.ToString(generator.Next(intMin, intMax));
            
        }

        private void btnDbl_Click(object sender, EventArgs e)
        {
            double dblMin;
            double dblMax;
            double dblResults;
            double.TryParse(strMin, out dblMin);
            double.TryParse(strMax, out dblMax);
            dblResults = (generator.NextDouble() * (dblMax - dblMin) + dblMin);
            dblResults = Math.Round(dblResults, intDecimals);
            lblResults.Text = Convert.ToString(dblResults);

        }

        private void txtMin_TextChanged(object sender, EventArgs e)
        {
            strMin = txtMin.Text;
        }

        private void txtMax_TextChanged(object sender, EventArgs e)
        {
            strMax = txtMax.Text;
        }

        private void nudDecimal_ValueChanged(object sender, EventArgs e)
        {
            intDecimals = Convert.ToInt32(nudDecimal.Value);
            if (intDecimals > 15) { 
                intDecimals = 2;
            }
        }
    }
}
