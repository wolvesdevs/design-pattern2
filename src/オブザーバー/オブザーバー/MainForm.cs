﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace オブザーバー
{
    public partial class MainForm : Form, INotify
    {
        public MainForm()
        {
            InitializeComponent();

            this.Disposed += MainForm_Disposed;
            StartPosition = FormStartPosition.CenterScreen;
            //WarningTimer.WarningAction += WarningTimer_WarningAction;
            WarningTimer.Add(this);
        }

        public void Update(bool isWarning)
        {
            this.Invoke((Action)delegate ()
            {
                if (isWarning)
                {
                    WarningLabel.Text = "警報";
                    WarningLabel.BackColor = Color.Red;
                }
                else
                {
                    WarningLabel.Text = "正常";
                    WarningLabel.BackColor = Color.Lime;
                }
            });
        }

        private void MainForm_Disposed(object sender, EventArgs e)
        {
            //WarningTimer.WarningAction -= WarningTimer_WarningAction;
            WarningTimer.Remove(this);
        }

        private void SubButton_Click(object sender, EventArgs e)
        {
            var f = new SubForm();
            f.Show();
        }
    }
}
