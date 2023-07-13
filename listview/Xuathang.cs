using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace listview
{
    public partial class Xuathang : Form
    {
        public Xuathang()
        {
            InitializeComponent();
        }

        private void Xuathang_Load(object sender, EventArgs e)
        {
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            thongtinxuat f = new thongtinxuat();
            f.Show();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            ChitietxuatBLL xbll = new ChitietxuatBLL();
            List<Chitietxuat> dsxGUI = xbll.laytoanbochitetxuat();

            listView1.Items.Clear();
            foreach (Chitietxuat x in dsxGUI)
            {
                ListViewItem lvi = new ListViewItem(x.Maxuat + "");
                lvi.SubItems.Add(x.Masp + " ");
                lvi.SubItems.Add(x.Soluong + " " );
                lvi.SubItems.Add(x.Dongiaxuat + " ");
                lvi.SubItems.Add(x.Baohanh);

                listView1.Items.Add(lvi);
                lvi.Tag = x;

            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.txt)|*.txt|(*.docx)|*.docx|(*.xlsx)|*.xlsx";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //foreach(var file in ofd.FileNames)
                //{
                //richTextBox1.Text += file + "\r\n";
                //}   
                //pictureBox1.Image=Image.FromFile(ofd.FileName);
                Stream fileStream = ofd.OpenFile();
                StreamReader reader = new StreamReader(fileStream);
                richTextBox1.Text = reader.ReadToEnd();
                reader.Close();
                fileStream.Close();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFileDialog.FileName);
                writer.Write(richTextBox1.Text);
                writer.Close();

            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem liv = listView1.SelectedItems[0];
                Chitietxuat sp = liv.Tag as Chitietxuat;
               ChitietxuatBLL spbl = new ChitietxuatBLL();
                bool kq = spbl.xoachitietxuat(sp.Maxuat);
                if (kq)
                {
                    MessageBox.Show("Bạn Có muốn xóa sản phẩm này Không?", "Cảnh Báo!!");
                    guna2Button6.PerformClick();
                }
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Chitietxuat sp = new Chitietxuat();
            sp.Maxuat = int.Parse(textBox1.Text);
            sp.Masp = int.Parse(textBox3.Text); ;
            sp.Dongiaxuat= int.Parse(guna2TextBox2.Text);
            sp.Soluong = int.Parse(textBox4.Text);
            sp.Baohanh = guna2TextBox1.Text;
            ChitietxuatBLL spbl = new ChitietxuatBLL();
            bool kq = spbl.Themchitietxuat(sp);
            if (kq)
            {
                MessageBox.Show("Bạn Có muốn thêm sản phẩm mới Không?", "Cảnh Báo!!");
                guna2Button6.PerformClick();
            }
        }

       
    }
}
