using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace オブザーバー
{
    public class MainViewModel : INotifyPropertyChanged, INotify, IDisposable
    {
        Dispatcher _dispatcher;

        public MainViewModel(Dispatcher dispatcher)
        {
            _dispatcher = dispatcher;
            WarningTimer.Add(this);
        }

        public void Dispose()
        {
            WarningTimer.Remove(this);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private string _warningLabelText = "AAA";

        public string WarningLabelText
        {
            get { return _warningLabelText; }
            set
            {
                if (_warningLabelText != value)
                {
                    _warningLabelText = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(WarningLabelText)));
                }
            }
        }

        public void Update(bool isWarning)
        {
            _dispatcher.Invoke((Action)delegate ()
            {
                if (isWarning)
                {
                    WarningLabelText = "警報";
                    //WarningLabel.BackColor = Color.Red;
                }
                else
                {
                    WarningLabelText = "正常";
                    //WarningLabel.BackColor = Color.Lime;
                }
            });
        }
    }
}
