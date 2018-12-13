using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DecimalConversionsDLL;

namespace BlakesCertTestingArea
{
    public partial class btnDecimalToBinary : Form
    {
        public btnDecimalToBinary()
        {
            InitializeComponent();
        }
        //Example of delegate void
        //public delegate void DecimalConvert(DecimalConvert convert);

        DecimalConvert Convert = new DecimalConvert();
        Object ob; // See line 34

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 10;
            int y = ++x;
            int z = y++;

            MessageBox.Show(z.ToString());

            Rectangle r = ob as Rectangle;
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            try
            {
                int i = int.Parse(textBox1.Text);
                switch (i)
                {
                    case 0:
                    case 1:
                    case 2:
                        {
                            listBox1.Items.Add(i + " / Low number");
                            break;
                        }
                    case 3:
                    case 4:
                    case 5:
                        {
                            listBox1.Items.Add(i + " / Medium number");
                            break;
                        }
                    default:
                        {
                            listBox1.Items.Add(i + " / Other number");
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnWhileLoop_Click(object sender, EventArgs e)
        {
            int count = 1;
            while (count <=5)
            {
                listBox1.Items.Add("The value of count = {0} / " +  count);
                ++count;
            }
        }

        private void btnQuestion9_Click(object sender, EventArgs e)
        {
            int x = 6 + 4 * 4 / 2 - 1;
            MessageBox.Show(x.ToString(), "6 + ((4 * 4) / 2) – 1 == ");
        }

        private void btnQuestion10_Click(object sender, EventArgs e)
        {
            long maxLong = long.MaxValue;
            double maxDoubl = double.MaxValue;
            float maxFloat = float.MaxValue;
            int maxInt = int.MaxValue;

            listBox1.Items.Add("Max Long: " + maxLong);
            listBox1.Items.Add("Max Double: " + maxDoubl);
            listBox1.Items.Add("Max Float: " + maxFloat);
            listBox1.Items.Add("Max Int: " + maxInt);
        }

        private void btnToBinary_Click(object sender, EventArgs e)
        {
            long var = long.Parse(textBox1.Text);
            long returnVal = Convert.BinaryCalculator(var);
            listBox1.Items.Add(returnVal);
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnQThirteen_Click(object sender, EventArgs e)
        {

            Rectangle r1, r2;
            r1 = new Rectangle { Length = 10.00, Width = 20.00 };
            r2 = r1;
            r2.Length = 30;

            string p1 = "Rectangle r1, r2;"; string p2 = "r1 = new Rectangle { Length = 10.00, Width = 20.00 };"; string p3 = "r2 = r1;"; string p4 = "r2.Length = 30;";

            listBox1.Items.Add(p1); listBox1.Items.Add(p2); listBox1.Items.Add(p3); listBox1.Items.Add(p4);
            listBox1.Items.Add("r1.Length = " + r1.Length);
        }
    }
}
