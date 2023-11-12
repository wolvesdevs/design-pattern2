using Measure.CSSeries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Measure
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VB.VB01 vb01 = new VB.VB01();
            vb01.GetValue();

            using (var f = new MeasureForm(new CS01()))
            {
                f.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var f = new MeasureForm(new CS02()))
            {
                f.ShowDialog();
            }
        }
    }
}
