using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listview
{
    public partial class cungcapsp : Form
    {
        public cungcapsp()
        {
            InitializeComponent();
        }

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

        private void cungcapsp_Load(object sender, EventArgs e)
        {
            NhacungcapBLL nvbl = new NhacungcapBLL();
            List<Nhacungcap> listnv = nvbl.laytoanbonhacungcap();
            listView1.Items.Clear();
            foreach (Nhacungcap nv in listnv)
            {
                ListViewItem lvi = new ListViewItem(nv.MaNCC + "");
                lvi.SubItems.Add(nv.TenNCC);
                lvi.SubItems.Add(nv.DiaChi);
                lvi.SubItems.Add(nv.Sodienthoai+ " ");
                
             
                lvi.SubItems.Add(nv.SoFax + "  ");
                listView1.Items.Add(lvi);
                lvi.Tag = nv;
            }


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Nhacungcap ncc = new Nhacungcap();
            ncc.MaNCC = int.Parse(guna2TextBox1.Text);
            ncc.TenNCC = guna2TextBox2.Text;
            ncc.DiaChi = guna2TextBox3.Text;
            ncc.Sodienthoai = int.Parse(guna2TextBox4.Text);
            ncc.SoFax = int.Parse(guna2TextBox5.Text);

            NhacungcapBLL nvbl = new NhacungcapBLL();
            bool kq = nvbl.suanhacungcap(ncc);
            if (kq)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Sửa thông tin không ", "Thông Báo!!", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    this.Close();


                }
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Nhacungcap ncc = new Nhacungcap();
            ncc.MaNCC = int.Parse(guna2TextBox1.Text);
            ncc.TenNCC = guna2TextBox2.Text;
            ncc.DiaChi = guna2TextBox3.Text;
            ncc.Sodienthoai = int.Parse(guna2TextBox4.Text);
            ncc.SoFax = int.Parse(guna2TextBox5.Text);
           
          NhacungcapBLL nvbl = new NhacungcapBLL();
            bool kq = nvbl.Themnhacungcap(ncc);
            if (kq)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Thêm không ", "Thông Báo!!", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    this.Close();


                }
            }
        }
    }
}
