using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BackgroundWorker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        private void BTNStart_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true)
            {
                backgroundWorker1.RunWorkerAsync();
                LBLResult.Text = "실행";
            }
        }

        private void BTNCancel_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                backgroundWorker1.CancelAsync();
                LBLResult.Text = "실행 취소";
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as System.ComponentModel.BackgroundWorker; // 네임스페이스랑 이름이 겹쳐서 정확하게 지정해야함

            for (int i = 1; i <= 100; i++)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    System.Threading.Thread.Sleep(30);
                    worker.ReportProgress(i);
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            LBLResult.Text = (e.ProgressPercentage.ToString() + "%");
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                LBLResult.Text = "Canceled!";
            }
            else if (e.Error != null)
            {
                LBLResult.Text = "Error: " + e.Error.Message;
            }
            else
            {
                LBLResult.Text = "Done!";
            }
        }


    }
}
