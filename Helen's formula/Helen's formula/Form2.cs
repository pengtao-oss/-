using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helen_s_formula
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            try
            {
                var a = textBoxFirstEdge.Text;
                var b = textBoxSecondEdge.Text;
                var c = textBoxThirdEdge.Text;
                var x = double.Parse(a);
                var y = double.Parse(b);
                var z = double.Parse(c);
                if(x + y > z && x + z > y && y + z > x)
                {
                    var p = (x + y + z) / 2;
                    var s = System.Math.Sqrt(p * (p - x) * (p - y) * (p - z));
                    this.labelResult.Text = s.ToString();
                }
                else
                {
                    this.labelResult.Text = "这三边不能构成三角形!!!";
                }
            }
            catch(Exception ex)
            {
                this.labelResult.Text = "输入有误!!!";
            }
        }
    }
}
