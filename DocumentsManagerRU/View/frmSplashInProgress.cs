using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Timer = System.Timers.Timer;
using System.Windows.Forms;
using System.Timers;

namespace DocumentsManagerRU
{
    public partial class frmSplashInProgress : Form 
    {
        private Thread thread;

        public frmSplashInProgress()
        {
            InitializeComponent();
        }

        public void StartSplash()
        {
            thread = new Thread(new ThreadStart(ShowSplash));
            thread.Start();
        }

        private void ShowSplash()
        {
            try
            {
                Thread.Sleep(1000 * 2);
                this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (this.Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - (this.Height / 2));
                //this.BackColor = Data.COLOR_OBJECTS;
                TopLevel = true;
                TopMost = true;
                this.ShowDialog();
            }
            catch (Exception)
            {
            }
        }

        public void StopSplash()
        {
            try
            {
                thread.Abort();
            }
            catch (Exception)
            {
                       
            }
            finally
            {
                thread.Interrupt();
            }
        }
    }
}
