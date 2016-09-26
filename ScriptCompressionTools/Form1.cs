using ScriptCompressionTools.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScriptCompressionTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void txtOld_DoubleClick(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (Directory.Exists(this.txtOld.Text))
                dialog.SelectedPath = this.txtOld.Text;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.txtOld.Text = dialog.SelectedPath;

                string newFolder = Path.Combine(this.txtOld.Text, "Scripts_" + DateTime.Now.ToString("yyyyMMddhhmmss"));
                this.txtNew.Text = newFolder;

                this.btnStart.Text = "开       始";
            }
        }

        private void txtOld_TextChanged(object sender, EventArgs e)
        {
            string newFolder = Path.Combine(this.txtOld.Text, "Scripts_" + DateTime.Now.ToString("yyyyMMddhhmmss"));
            this.txtNew.Text = newFolder;

            this.btnStart.Text = "开       始";
        }

        private void txtNew_DoubleClick(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.txtNew.Text = dialog.SelectedPath;
                this.btnStart.Text = "开       始";
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtOld.Text))
                this.txtOld_DoubleClick(sender, e);

            if (!File.Exists(Common.JSMinPath))
            {
                MessageBox.Show("文件丢失！未找到jsmin.exe");
                return;
            }

            this.btnStart.Text = "正在压缩...";
            this.btnStart.Enabled = false;
            this.txtOld.Enabled = false;
            this.txtNew.Enabled = false;

            if (!Directory.Exists(this.txtNew.Text))
                Directory.CreateDirectory(this.txtNew.Text);

            int count = 0;
            string[] files = Directory.GetFiles(this.txtOld.Text);
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            foreach (var item in files)
            {
                FileInfo file = new FileInfo(item);
                if (Common.ScriptFiles.Contains(file.Extension))
                {
                    count++;
                    string cmd = Common.JSMinPath + " <" + item + "> " + Path.Combine(this.txtNew.Text, file.Name);
                    p.StandardInput.WriteLine(cmd);
                }
            }
            p.StandardInput.WriteLine("exit");
            p.Close();

            this.btnStart.Text = "压缩完成！(" + count + ")";
            this.btnStart.Enabled = true;
            this.txtOld.Enabled = true;
            this.txtNew.Enabled = true;
        }
    }
}
