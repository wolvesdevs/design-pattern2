using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using テスト容易性;

namespace テスト容易性Tests
{
    [TestClass]
    public class UnitTest2 : TestBase
    {
        [TestMethod]
        public void TestMethod3()
        {
            var vm = new AViewModel();
            Assert.AreEqual(50, vm.GetValue());

            SettingA.PowerMode = true;
            Assert.AreEqual(100, vm.GetValue());
        }

        [TestMethod]
        public void TestMethod4()
        {
            var vm = new BViewModel();
            Assert.AreEqual(50, vm.GetValue());

            SettingA.PowerMode = true;
            Assert.AreEqual(100, vm.GetValue());
        }
    }
}
