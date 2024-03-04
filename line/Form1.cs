using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace line
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                int a = Convert.ToInt32(boxX1.Text);
                int b = Convert.ToInt32(boxX2.Text);
                int c = Convert.ToInt32(boxY1.Text);
                int d = Convert.ToInt32(boxY2.Text);
            DrawingForm n = new DrawingForm(a,b,c,d);
            DDAAlgorithm m = new DDAAlgorithm(a, b, c, d);
            n.ShowDialog();
            m.ShowDialog();
        }
    }
}
