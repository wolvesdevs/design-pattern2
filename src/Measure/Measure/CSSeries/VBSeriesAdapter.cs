using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measure.CSSeries
{
    internal class VBSeriesAdapter : ICSSeries
    {
        private VB.IVBSeries _vbSeries;

        public VBSeriesAdapter(VB.IVBSeries vBSeries)
        {
            _vbSeries = vBSeries;
        }

        public int GetMeasure()
        {
            return _vbSeries.GetValue();
        }
    }
}
