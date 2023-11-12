using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Measure.CSSeries
{
    internal class VB01Adapter : ICSSeries
    {
        private VB.VB01 _vb01 = new VB.VB01();

        public int GetMeasure()
        {
            return _vb01.GetValue();
        }
    }
}
