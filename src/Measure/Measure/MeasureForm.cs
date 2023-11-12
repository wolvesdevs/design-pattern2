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
    public partial class MeasureForm : Form
    {
        private ICSSeries _csSeries;
        public MeasureForm(ICSSeries csSeries)
        {
            _csSeries = csSeries;
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }

        private void MeasureButton_Click(object sender, EventArgs e)
        {
           MeasureLabel.Text =  _csSeries.GetMeasure() + "m/s2";
        }
    }
}
