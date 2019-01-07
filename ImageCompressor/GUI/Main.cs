using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageCompressor.Logics;
using ImageCompressor.Logics.Helper;

namespace ImageCompressor
{
    public partial class Main : Form
    {
        #region[PrivateData]
        public string currentPath = "";
        public List<string> images = new List<string>();
        CancellationTokenSource tokenSource;
        CancellationToken token;
        #endregion[Privatedata]

        #region[Constructor]
        public Main()
        {
            InitializeComponent();
        }
        #endregion[Constructor]

        #region[ButtonFunctions]
        private void btn_LoadFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                currentPath = dialog.SelectedPath;
                int filecount = 0;
                ProcessImage.LoadFolder(currentPath,out filecount, out images);
                lbl_info.Text = "There are " + filecount + " image(s) in folder";
                progress.Value = 0;
                lbl_progess.Text = 0 + " / " + filecount;
            }
        }

        private void btn_ProcessImages_Click(object sender, EventArgs e)
        {
            if (images.Count < 1)
            {
                MessageBox.Show("There is no image to compress", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BeginProcessImage();
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            tokenSource.Cancel();
        }
        #endregion

        private void BeginProcessImage()
        {
            tokenSource = new CancellationTokenSource();
            token = tokenSource.Token;
            progress.Maximum = images.Count;
            progress.Value = 0;
            progress.Minimum = 0;
            int qual = int.Parse(txt_quality.Text);
            int divider = int.Parse(cmb_divider.Text);
            Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < images.Count && !token.IsCancellationRequested; i++)
                {
                    ProcessImage.CompressTask(qual, divider, currentPath, images[i]);
                    SetLabels("Processing image " + images[i].Split(new string[] { "\\" }, StringSplitOptions.None).Last(), i + 1, i + 1 + " / " + images.Count);
                }
                lbl_Processing.Invoke((MethodInvoker)delegate () { lbl_Processing.Text = "Done !"; });
                MessageBox.Show("Done!");
            }, token);
        }

        #region [Labels]
        private void sliderQuality_Scroll(object sender, EventArgs e)
        {
            txt_quality.Text = sliderQuality.Value.ToString();
        }
        delegate void SetLabelsCallback(string processingText,int progress, string progressText);
        private void SetLabels(string processingText,int progress,string progressText)
        {
            if (this.lbl_Processing.InvokeRequired || this.progress.InvokeRequired || (this.lbl_progess.InvokeRequired))
            {
                SetLabelsCallback d = new SetLabelsCallback(SetLabels);
                this.Invoke(d, new object[] { processingText, progress, progressText });
            }
            else
            {
                this.lbl_Processing.Text = "Compressing " + processingText + " ";
                this.progress.Value = progress;
                this.lbl_progess.Text = progressText;
            }
        }
        private void txt_quality_TextChanged(object sender, EventArgs e)
        {
            try
            {
                sliderQuality.Value = int.Parse(txt_quality.Text);
            }
            catch { }
        }
        #endregion
    }
}
