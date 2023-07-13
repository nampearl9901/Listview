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
using BLL;
using DTO;

namespace listview
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        //
        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("chức Năng Tìm kiếm chưa hoàn thiện??", "Xin Lỗi!!");
        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("chức Năng Tư Vấn chưa hoàn thiện??", "Xin Lỗi!!");
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("chức Năng chỉnh sửa chưa hoàn thiện??", "Xin Lỗi!!");
        }

        private void zoomsize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;

            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void minisize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Maximized;
            }

        }
        bool mouseDown;
        private Point offset;
        private void MouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }
        private void MouseUp_event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void MouseMove_event(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //

        private void button1_Click(object sender, EventArgs e)
        {
            sanphamBLL spbll = new sanphamBLL();
            List<Sanpham> dsspGUI = spbll.laytoanbosanpham();

            listView1.Items.Clear();
            foreach (Sanpham sp in dsspGUI)
            {
                ListViewItem lvi = new ListViewItem(sp.Masp + "");
                lvi.SubItems.Add(sp.Tensp);
                lvi.SubItems.Add(sp.Loai);
                lvi.SubItems.Add(sp.Hangsx);
                listView1.Items.Add(lvi);
                lvi.Tag = sp;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                ListViewItem liv = listView1.SelectedItems[0];
                Sanpham sp = liv.Tag as Sanpham;
                sanphamBLL spbl = new sanphamBLL();
                bool kq = spbl.xoasanpham(sp.Masp);
                if(kq)
                {
                    MessageBox.Show("Bạn Có muốn xóa sản phẩm này Không?", "Cảnh Báo!!");
                    button1.PerformClick();
                }    
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sanpham sp = new Sanpham();
            sp.Masp = int.Parse(textBox1.Text);
            sp.Tensp = textBox3.Text;
            sp.Loai = textBox2.Text;
            sp.Hangsx = textBox4.Text;
            sanphamBLL spbl = new sanphamBLL();
            bool kq = spbl.Themsanpham(sp);
            if (kq)
            {
                MessageBox.Show("Bạn Có muốn thêm sản phẩm mới Không?", "Cảnh Báo!!");
                button1.PerformClick();
            }


          

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sanpham sp = new Sanpham();
            sp.Masp = int.Parse(textBox1.Text);
            sp.Tensp = textBox3.Text;
            sp.Loai = textBox2.Text;
            sp.Hangsx = textBox4.Text;
            sanphamBLL spbl = new sanphamBLL();
            bool kq = spbl.suasanpham(sp);
            if (kq)
            {
                MessageBox.Show("Bạn Có muốn Sửa thông tin sản phẩm này Không?","Cảnh Báo!!");
                button1.PerformClick();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void exit_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
