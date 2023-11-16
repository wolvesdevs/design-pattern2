using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace シングルトン
//{
//    public class CheckTimer
//    {
//        private System.Threading.Timer _timer;
//        private static readonly object _lock = new object();
//        private static CheckTimer _instance;

//        private CheckTimer()
//        {
//            _timer = new System.Threading.Timer(TimerCallback);
//        }

//        public static CheckTimer GetInstance()
//        {
//            lock (_lock)
//            {
//                if (_instance == null)
//                {
//                    _instance = new CheckTimer();
//                }
//            }

//            return _instance;
//        }

//        public bool IsError { get; private set; }

//        public void Start()
//        {
//            _timer.Change(0, 5000);
//        }

//        private void TimerCallback(object state)
//        {
//            Console.WriteLine("timer:" + DateTime.Now);
//        }
//    }
//}

namespace シングルトン
{
    public class CheckTimer
    {
        private System.Threading.Timer _timer;
        //private static CheckTimer _instance;

        private CheckTimer()
        {
            _timer = new System.Threading.Timer(TimerCallback);
        }

        public static CheckTimer Instance { get; } = new CheckTimer();

        //public static CheckTimer GetInstance()
        //{
        //    lock (_lock)
        //    {
        //        if (_instance == null)
        //        {
        //            _instance = new CheckTimer();
        //        }
        //    }

        //    return _instance;
        //}

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