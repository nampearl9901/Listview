using BLL;
using DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listview
{
    public partial class thongtinnhap : Form
    {
        public thongtinnhap()
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

        private void thongtinnhap_Load(object sender, EventArgs e)
        {
           ChitietnhapBLL nvbl = new ChitietnhapBLL();
            List<Chitietnhap> listnv = nvbl.laytoanbochitetnhap();
            guna2DataGridView1.DataSource = listnv;
           
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            NhapBLL xbll = new NhapBLL();
            List<Nhap> dsxGUI = xbll.laytoanbonhap();

            listView1.Items.Clear();
            foreach (Nhap x in dsxGUI)
            {
                ListViewItem lvi = new ListViewItem(x.Manhap + "");
                lvi.SubItems.Add(x.Ngaynhap + " ");
                lvi.SubItems.Add(x.Manv + " ");
                lvi.SubItems.Add(x.Mancc + " ");

                listView1.Items.Add(lvi);
                lvi.Tag = x;

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Nhap sp = new Nhap();
            sp.Manhap = int.Parse(textBox1.Text);
            sp.Ngaynhap = dtnhap.Value;
            sp.Manv = int.Parse(textBox3.Text);
            sp.Mancc = int.Parse(guna2TextBox1.Text);
        
            NhapBLL spbl = new NhapBLL();
            bool kq = spbl.Themnhap(sp);
            if (kq)
            {
                MessageBox.Show("Bạn Có muốn thêm sản phẩm mới Không?", "Cảnh Báo!!");
                guna2Button6.PerformClick();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem liv = listView1.SelectedItems[0];
                Nhap sp = liv.Tag as Nhap;
                NhapBLL spbl = new NhapBLL();
                bool kq = spbl.xoanhap(sp.Manhap);
                if (kq)
                {
                    MessageBox.Show("Bạn Có muốn xóa sản phẩm này Không?", "Cảnh Báo!!");
                    guna2Button6.PerformClick();
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
