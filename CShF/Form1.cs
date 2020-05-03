using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CShF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void rez_button_Click(object sender, EventArgs e)
        {
            double X1, Y1, X2, Y2, X3, Y3, re, AB, AC, BC;

            X1 = Convert.ToDouble(x1.Text);
            Y1 = Convert.ToDouble(y1.Text);

            X2 = Convert.ToDouble(x2.Text);
            Y2 = Convert.ToDouble(y2.Text);

            X3 = Convert.ToDouble(x3.Text);
            Y3 = Convert.ToDouble(y3.Text);

            AB = Math.Sqrt(((X2 - X1) * (X2 - X1)) + ((Y2 - Y1) * (Y2 - Y1)));
            AC = Math.Sqrt(((X3 - X1) * (X3 - X1)) + ((Y3 - Y1) * (Y3 - Y1)));
            BC = Math.Sqrt(((X3 - X2) * (X3 - X2)) + ((Y3 - Y2) * (Y3 - Y2)));

            re = AB + BC + AC;

            rez.Text = Convert.ToString(re);
        }
    }
}
