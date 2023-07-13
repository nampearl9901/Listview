using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace listview
{
    public partial class Thongtinnhanvien : Form
    {
        public Thongtinnhanvien()
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

        private void them_Click(object sender, EventArgs e)
        {
            DTO.Nhanvien nv = new DTO.Nhanvien();
            nv.Manv = int.Parse(txtmanv.Text);
            nv.Tennv = txttnv.Text;
            nv.Ngaysinh = dtns.Value;
            nv.Diachi = txtdc.Text;
            nv.Sodienthoai = int.Parse(txtsdt.Text);
            nv.SoCMTND = int.Parse(txtcmnd.Text);
            nv.Nguyenquan = txtnq.Text;
            nv.Ngayvao = dtnv.Value;
            nv.Gioitinh = cbgt.Text;
            nv.Chucvu = cbgt.Text;
            NhanvienBLL nvbl = new NhanvienBLL();
            bool kq = nvbl.Themnhanvien(nv);
            if (kq)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Thêm thông tin nhân viên không ", "Thông Báo!!", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    this.Close();


                }
            }
        }

        private void suavn_Click(object sender, EventArgs e)
        {
            
            DTO.Nhanvien nv = new DTO.Nhanvien();
            nv.Manv = int.Parse(txtmanv.Text);
            nv.Tennv = txttnv.Text;
            nv.Ngaysinh = dtns.Value;
            nv.Diachi = txtdc.Text;
            nv.Sodienthoai = int.Parse(txtsdt.Text);
            nv.SoCMTND = int.Parse(txtcmnd.Text);
            nv.Nguyenquan = txtnq.Text;
            nv.Ngayvao = dtnv.Value;
            nv.Gioitinh = cbgt.Text;
            nv.Chucvu = cbgt.Text;
            NhanvienBLL nvbl = new NhanvienBLL();
            bool kq = nvbl.suanhanvien(nv);
            if (kq)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn sửa thông tin nhân viên không ", "Thông Báo!!", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    this.Close();
                   

                }
            }
        }
    }
}
