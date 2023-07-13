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

namespace listview
{
    public partial class Nhaphang : Form
    {
        public Nhaphang()
        {
            InitializeComponent();
        }

        private void Nhaphang_Load(object sender, EventArgs e)
        {
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            thongtinnhap f = new thongtinnhap();
            f.Show();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

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

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFileDialog.FileName);
                writer.Write(richTextBox1.Text);
                writer.Close();

            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            ChitietnhapBLL xbll = new ChitietnhapBLL();
            List<Chitietnhap> dsxGUI = xbll.laytoanbochitetnhap();

            listView1.Items.Clear();
            foreach (Chitietnhap x in dsxGUI)
            {
                ListViewItem lvi = new ListViewItem(x.Manhap + "");
                lvi.SubItems.Add(x.Masp + " ");
                lvi.SubItems.Add(x.Soluong + " ");
                lvi.SubItems.Add(x.Dongianhap + " ");
                lvi.SubItems.Add(x.Lydonhap);

                listView1.Items.Add(lvi);
                lvi.Tag = x;

            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem liv = listView1.SelectedItems[0];
                Chitietnhap sp = liv.Tag as Chitietnhap;
                ChitietnhapBLL spbl = new ChitietnhapBLL();
                bool kq = spbl.xoachitietnhap(sp.Manhap);
                if (kq)
                {
                    MessageBox.Show("Bạn Có muốn xóa sản phẩm này Không?", "Cảnh Báo!!");
                    guna2Button6.PerformClick();
                }
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Chitietnhap sp = new Chitietnhap();
            sp.Manhap = int.Parse(textBox1.Text);
            sp.Masp = int.Parse(textBox3.Text); ;
            sp.Dongianhap = int.Parse(guna2TextBox2.Text);
            sp.Soluong = int.Parse(textBox4.Text);
            sp.Lydonhap = guna2TextBox1.Text;
            ChitietnhapBLL spbl = new ChitietnhapBLL();
            bool kq = spbl.Themchitietnhap(sp);
            if (kq)
            {
                MessageBox.Show("Bạn Có muốn thêm sản phẩm mới Không?", "Cảnh Báo!!");
                guna2Button6.PerformClick();
            }
        }

       
    }
}
