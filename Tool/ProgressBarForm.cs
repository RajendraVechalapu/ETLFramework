﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Perf_Light
{
    public partial class ProgressBarForm : Form
    {
        public ProgressBarForm(Action worker)
        {
            InitializeComponent();
            //if (worker == null)
            //    throw new ArgumentNullException();
            //    Worker = worker;
            
        }

        //public Action Worker { get; set; }

        //protected override void OnLoad(EventArgs e)
        //{
        //    base.OnLoad(e);
        //    Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        //}

        private void ProgressBarForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }
    }
}
