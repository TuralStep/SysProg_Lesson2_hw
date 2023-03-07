using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SysProg_Lesson2_hw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            thread = new(CopyMethod);
            FromPath = "";
            ToPath = "";
        }

        private Thread thread;
        public string FromPath { get; set; }
        public string ToPath { get; set; }

        private void btn_from_Click(object sender, EventArgs e)
        {
            FileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text Files |*.txt";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txt_from.Text = dialog.FileName;
                FromPath = dialog.FileName;
                return;
            }
        }

        private void btn_to_Click(object sender, EventArgs e)
        {
            FileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text Files |*.txt";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txt_to.Text = dialog.FileName;
                ToPath = dialog.FileName;
                return;
            }
        }

        private void CopyMethod()
        {
            progBar.Value = 0;

            using FileStream fsRead = new(FromPath, FileMode.Open, FileAccess.Read, FileShare.None, 4096, true);
            using FileStream fsWrite = new(ToPath, FileMode.Create, FileAccess.Write, FileShare.None, 4096, true);

            var fileSize = fsRead.Length;
            byte[] buffer = new byte[70];
            var copiedBytes = 0L;

            do
            {
                var bytesToCopy = Math.Min(buffer.Length, (int)(fileSize - copiedBytes));

                fsRead.Read(buffer, 0, bytesToCopy);
                fsWrite.Write(buffer, 0, bytesToCopy);
                copiedBytes += bytesToCopy;

                IDisposable unsubscribe = Disposables.DoNothing;
                EventHandler handler = (ss, ee) =>
                {
                    Control.Invoke(() => { progBar.Value += 10; });
                    unsubscribe.Dispose();
                };

                //progBar.Value += 10;

                Thread.Sleep(300 + Random.Shared.Next(30, 200));
            } while (copiedBytes < fileSize);

            btn_copy.Enabled = true;
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FromPath) || string.IsNullOrWhiteSpace(ToPath))
            {
                MessageBox.Show("Please enter all information");
                return;
            }

            if (!File.Exists(FromPath))
            {
                MessageBox.Show("Entered wrong file or folder path");
                return;
            }

            if (!ToPath.Contains(".txt"))
                ToPath += ".txt";


            btn_copy.Enabled = false;
            thread.Start();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (thread.ThreadState == ThreadState.Unstarted)
                return;

            try
            {
                thread.Abort();
            }
            catch (Exception ex) { }

            if (File.Exists(ToPath))
                File.Delete(FromPath);

            btn_copy.Enabled = true;
            progBar.Value = 0;
        }
    }
}