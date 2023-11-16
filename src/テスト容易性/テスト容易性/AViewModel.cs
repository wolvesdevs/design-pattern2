using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace テスト容易性
{
    public class AViewModel
    {
        public int GetValue()
        {
            if (SettingA.PowerMode)
            {
                return 100;
            }

            return 50;
        }
    }
}
