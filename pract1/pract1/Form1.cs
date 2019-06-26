using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] x = new double[11];
            double[] y = new double[11];
            double x1=0, y1=0, xy=0, xx=0,a,b;
            x[0] = Convert.ToDouble(textX1.Text);
            x[1] = Convert.ToDouble(textX2.Text);
            x[2] = Convert.ToDouble(textX3.Text);
            x[3] = Convert.ToDouble(textX4.Text);
            x[4] = Convert.ToDouble(textX5.Text);
            x[5] = Convert.ToDouble(textX6.Text);
            x[6] = Convert.ToDouble(textX7.Text);
            x[7] = Convert.ToDouble(textX8.Text);
            x[8] = Convert.ToDouble(textX9.Text);
            x[9] = Convert.ToDouble(textX10.Text);
            x[10] = Convert.ToDouble(textX11.Text);

            y[0] = Convert.ToDouble(textY1.Text);
            y[1] = Convert.ToDouble(textY2.Text);
            y[2] = Convert.ToDouble(textY3.Text);
            y[3] = Convert.ToDouble(textY4.Text);
            y[4] = Convert.ToDouble(textY5.Text);
            y[5] = Convert.ToDouble(textY6.Text);
            y[6] = Convert.ToDouble(textY7.Text);
            y[7] = Convert.ToDouble(textY8.Text);
            y[8] = Convert.ToDouble(textY9.Text);
            y[9] = Convert.ToDouble(textY10.Text);
            y[10] = Convert.ToDouble(textY11.Text);

            for(int i = 0; i < 11; i++)
            {
                x1 += x[i];
                y1 += y[i];
                xy += x[i] * y[i];
                xx += x[i] * x[i];

            }
            a = (11 * xy - (x1 * y1)) / (11 * xx - (x1 * x1));
            b = (y1 - a * x1) / 11;
            textA.Text = Convert.ToString(a);
            textB.Text = Convert.ToString(b);
        }
    }
}
