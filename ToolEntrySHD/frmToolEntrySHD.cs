using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using File = System.IO.File;

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
        int counter = 0;


        private void showImage()
        {
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
                        counter = FileResult.Count();
                        showImage();

                    }
                    else
                    {
                        FileResult = Directory.GetFiles(fd.SelectedPath + "\\result", "*.jpg", SearchOption.TopDirectoryOnly).ToList();
                        counter = FileResult.Count();
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
                       if (counter == locFile.Count()-1 )
                        {
                            ImageView.Image.Dispose();
                            File.Delete(locFile[counter]);
                            locFile.RemoveAt(counter);
                            DialogResult dr = MessageBox.Show("Last Image Delete!!", "ALERT", MessageBoxButtons.OKCancel);
                            if(dr == DialogResult.OK)
                            {
                                this.Close();
                            }    
                            return;
                        }
                        else
                        {
                                ImageView.Image.Dispose();
                                File.Delete(locFile[counter]);
                                locFile.RemoveAt(counter);
                                ImageView.Image = Image.FromFile(locFile[counter]);
                                lblValueIndex.Text = Convert.ToInt32(counter + 1) + "/" + locFile.Count.ToString();
                                txtEntry.Clear();
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
