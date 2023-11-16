using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace シングルトン
{
    public static class CheckTimer
    {
        private static System.Threading.Timer _timer;

        static CheckTimer()
        {
            _timer = new System.Threading.Timer(TimerCallback);
        }

        //public static CheckTimer Instance { get; } = new CheckTimer();
        public static bool IsError { get; private set; }

        public static void Start()
        {
            _timer.Change(0, 5000);
        }

        private static void TimerCallback(object state)
        {
            Console.WriteLine("timer:" + DateTime.Now);
        }
    } 
}