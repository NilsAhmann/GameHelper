using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using GameHelper.Games.Sims;

namespace GameHelper
{
    public partial class formGameHelper : Form
    {
        Thread _backgroundWorker;
        public formGameHelper()
        {
            InitializeComponent();
        }

        private void tp1_btnMove_Click(object sender, EventArgs e)
        {
            List<ISims> _simList = new List<ISims>();

            _simList.Add(new Sims3());
            _simList.Add(new Sims4());

            foreach(var sims in _simList)
            {
                Action test = delegate () { sims.MoveModsToFolder(Global.Common.GetDownloadFolder); };
                Process(test);
            }
        }

        private void Process(Action action)
        {
            if (_backgroundWorker != null && _backgroundWorker.IsAlive)
                _backgroundWorker.Abort();

            _backgroundWorker = new Thread(new ThreadStart(action));
            _backgroundWorker.IsBackground = true;
            _backgroundWorker.Start();
        }
    }
}
