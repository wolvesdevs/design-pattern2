using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace シングルトン
{
    public class CheckTimer
    {
        private System.Threading.Timer _timer;

        public CheckTimer()
        {
            _timer = new System.Threading.Timer(TimerCallback);
        }

        public bool IsError { get; private set; }

        public void Start()
        {
            _timer.Change(0, 5000);
        }

        private void TimerCallback(object state)
        {
            Console.WriteLine("timer:" + DateTime.Now);
        }
    }
}
