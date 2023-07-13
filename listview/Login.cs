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
    public partial class Login : Form

    {
      
      
        public Login()
        {
            InitializeComponent();
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Thoát Không ??", "Thông Báo!!", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

         
                if (KiemTraDangNhap(txt_taikhoan.Text, txt_matkhau.Text))
                {
                    Quanlyxe f = new Quanlyxe();
                    f.Show();
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu ", "Lỗi !!!");
                    txt_taikhoan.Focus();
                }


            
           

        }
        bool KiemTraDangNhap(string tentaikhoan, string matkhau)
        {
            TaikhoanBLL tkbl = new TaikhoanBLL();
            List<login> logins = tkbl.laytaikhoan();

            for(int i =0; i < logins.Count; i++)
            {
                if(tentaikhoan == logins[i].TaiKhoan && matkhau== logins[i].matKhau)
                
                    return true;
                    

            }   
            return false;

           //if (tentaikhoan== this.tentaikhoan && matkhau == this.matKhau)
          //  {
              //  return true;
           // }    
          //  return false;

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
            this.KeyDown += Login_KeyDown;
        }
        bool mouseDown;
        private Point offset;
        private void MouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }
        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2GradientButton1_Click(sender, e);
            }
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
            Application.Exit();
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

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("chức Năng chỉnh sửa chưa hoàn thiện??", "Xin Lỗi!!");
        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("chức Năng Tư Vấn chưa hoàn thiện??", "Xin Lỗi!!");
        }

        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("chức Năng Tìm kiếm chưa hoàn thiện??", "Xin Lỗi!!");
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
             login lg = new login();
            lg.TaiKhoan = txt_taikhoan.Text;
            lg.matKhau = txt_matkhau.Text;
          
            TaikhoanBLL tkbl = new TaikhoanBLL();
            bool kq = tkbl.Themtaikhoan(lg);
            if (kq)
            {
                DialogResult dialogResult = MessageBox.Show("bạn Đã đăng ký thành công ", "Thông Báo!!", MessageBoxButtons.OKCancel);
           
            }

        }
    }
}
