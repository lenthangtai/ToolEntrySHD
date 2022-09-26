using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolEntrySHD
{
    public partial class frmToolEntrySHD : Form
    {
        public frmToolEntrySHD()
        {
            InitializeComponent();
        }
        List<string> locFile = new List<string>();
        List<string> FileResult = new List<string>();
        FolderBrowserDialog fd = new FolderBrowserDialog();
        //string[] filterFile = { "*.png", "*.jpg", "*.gif" };
        int counter = 0;
        private void showImage()
        {
            counter = FileResult.Count();
            ImageView.Image = Image.FromFile(locFile[counter]);
            lblValueIndex.Text = Convert.ToInt32(counter + 1) + "/" + locFile.Count.ToString();
            txtEntry.Clear();
        }
        private void frmToolEntrySHD_Load(object sender, EventArgs e)
        {
            try
            {
                fd.ShowDialog();
                locFile = Directory.GetFiles(fd.SelectedPath, "*.jpg", SearchOption.TopDirectoryOnly).ToList();
                txtPathHidden.Text = fd.SelectedPath.ToString();
                txtPath.Text = fd.SelectedPath.ToString();
                if (locFile.Count() == 0)
                {
                    MessageBox.Show("This Folder Don't Have A Picture!!!\nPlease, Pick Folder Another.", "Alert Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DirectoryInfo dir = new DirectoryInfo(fd.SelectedPath + "\\result");
                    if (!dir.Exists)
                    {
                        dir.Create();
                        FileResult = Directory.GetFiles(fd.SelectedPath + "\\result", "*.jpg", SearchOption.TopDirectoryOnly).ToList();
                        showImage();
                    }
                    else
                    {
                        FileResult = Directory.GetFiles(fd.SelectedPath + "\\result", "*.jpg", SearchOption.TopDirectoryOnly).ToList();
                        showImage();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnInputPath_Click(object sender, EventArgs e)
        {

            try
            {
                fd.ShowDialog();
                locFile = Directory.GetFiles(fd.SelectedPath, "*.jpg", SearchOption.TopDirectoryOnly).ToList();
                txtPath.Text = fd.SelectedPath.ToString();
                if (locFile.Count() == 0)
                {
                    MessageBox.Show("This Folder Don't Have A Picture!!!\nPlease, Pick Folder Another.", "Alert Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    showImage();
                    txtEntry.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtEntry_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    counter = FileResult.Count();
                    ImageView.Image.Save(txtPathHidden.Text + "\\result\\" + (counter + 1).ToString().PadLeft(6, '0') + "_" + txtEntry.Text.Trim() + ".jpg");
                    counter += 1;
                    if (counter == locFile.Count)
                    {
                        DialogResult drs = MessageBox.Show("Complete!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (drs == DialogResult.OK)
                        {
                            this.Close();
                        }
                        return;
                    }
                    else
                    {
                        FileResult = Directory.GetFiles(txtPathHidden.Text + "\\result\\", "*.jpg", SearchOption.TopDirectoryOnly).ToList();
                        showImage();

                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void frmToolEntrySHD_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyData)
                {
                    case Keys.Escape:
                        DialogResult dg = MessageBox.Show("Bạn muốn thoát hệ thống.!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (dg == DialogResult.OK)
                        {
                            this.Close();
                        }
                        break;
                    case Keys.Delete:
                        counter += 1;
                        if (counter == locFile.Count)
                        {
                            ImageView.Image.Dispose();
                            ImageView.Dispose();
                            File.Delete(locFile[counter - 1]);
                            MessageBox.Show("Complete!!", "Thông báo", MessageBoxButtons.OK);
                            this.Close();
                        }
                        else
                        {
                            ImageView.Image.Dispose();
                            File.Delete(locFile[counter - 1]);
                            showImage();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
