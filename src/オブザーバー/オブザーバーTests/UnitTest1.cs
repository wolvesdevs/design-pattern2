using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using オブザーバー;

namespace オブザーバーTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mock = new WarningTimerMock();
            var vm = new MainViewModel(null, mock);
            Assert.AreEqual("AAA", vm.WarningLabelText);

            mock.Change(true);
            Assert.AreEqual("警報", vm.WarningLabelText);
            mock.Change(false);
            Assert.AreEqual("正常", vm.WarningLabelText);
        }
    }

    internal class WarningTimerMock : WarningTimerBase
    {
        internal void Change(bool isWarning)
        {
            this.IsWarning = isWarning;
        }
    }
}
