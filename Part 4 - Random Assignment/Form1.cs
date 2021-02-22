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
        double dblMin;
        double dblMax;
        int intMin;
        int intMax;
        
        public RandomNumbers()
        {
            InitializeComponent();
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            intMin = Convert.ToInt32(txtMin.Text);
            intMax = Convert.ToInt32(txtMax.Text);
            lblResults.Text = Convert.ToString(generator.Next(intMin, intMax));
            
        }

        private void btnDbl_Click(object sender, EventArgs e)
        {
            dblMin = Convert.ToDouble(txtMin.Text);
            dblMax = Convert.ToDouble(txtMax.Text);
            lblResults.Text = Convert.ToString(generator.NextDouble() * (dblMax - dblMin) + dblMin);
        }
    }
}
