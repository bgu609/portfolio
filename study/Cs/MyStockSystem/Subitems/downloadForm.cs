using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace MyStockSystem.Subitems
{
    public partial class downloadForm : MetroForm
    {
        public string ParentUrl { get; set; }

        WebClient client;

        public downloadForm()
        {
            InitializeComponent();
        }

        private void downloadForm_Load(object sender, EventArgs e)
        {
            metroLabel1.Text = ParentUrl;

            client = new WebClient();
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadFileCompleted += Client_DownloadFileCompleted;
        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            string fileName = ParentUrl.Substring(ParentUrl.IndexOf('=') + 1);
            pictureBox1.Load(Environment.CurrentDirectory + $"\\{fileName}");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                metroProgressBar1.Value = e.ProgressPercentage;
                /*
                if(e.BytesReceived == e.TotalBytesToReceive)
                {
                    Client_DownloadFileCompleted(sender, null);
                }*/
            }));
        }

        private void downloadForm_Shown(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(StartDownload));
            thread.Start();
        }

        private void StartDownload()
        {
            Uri uri = new Uri(ParentUrl);
            string fileName = ParentUrl.Substring(ParentUrl.IndexOf('=') + 1);
            client.DownloadFileAsync(uri, Environment.CurrentDirectory + $"\\{fileName}");
        }
    }
}
