using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using テスト容易性;

namespace テスト容易性Tests
{
    [TestClass]
    public abstract class TestBase
    {
        [TestInitialize]
        public void TestInitialize()
        {
            SettingA.PowerMode = false;
        }
    }
}
