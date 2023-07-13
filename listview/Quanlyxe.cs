using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listview
{
    public partial class Quanlyxe : DevExpress.XtraEditors.XtraForm
    {
        
          
        
        public Quanlyxe()
        {
            InitializeComponent();
        }

        UserInfor userinfor;

        /// custom nut 
        private void Quanlyxe_Load(object sender, EventArgs e)
        {
            //
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Normal;
            //
            Home h = new Home();
           h.MdiParent = this;
            h.Dock = DockStyle.Fill;
            h.Show();
        


            //

        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Thoát Không ??", "Thông Báo!!", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
                
            }
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
        //thu nho man hinh

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

        /// mouseDown

        bool mouseDown;
        private Point offset;
        private void MouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;



        }

        private void MouseMove_event(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void MouseUp_event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        //// mouse down
        /// end custom nut
        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Đăng Xuất Không ??", "Thông Báo!!", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();
                Login f = new Login();
                f.Show();
            }
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("chức Năng Tư Vấn chưa hoàn thiện??", "Thông Báo!!");
           

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
             MessageBox.Show("chức Năng Thông Báo chưa hoàn thiện??", "Xin Lỗi!!");


        }

        private void sanpham_Click(object sender, EventArgs e)
        {
            SanPham form1 = new SanPham();
            form1.MdiParent = this;
            form1.Dock = DockStyle.Fill;
            form1.Show();
        

        }

        private void trangchu_Click(object sender, EventArgs e)
        {
           
            Home h = new Home();
            h.MdiParent = this;
            h.Dock = DockStyle.Fill;
            h.Show();

        }

        private void nhanvien_Click(object sender, EventArgs e)
        {
            Nhanvien nv = new Nhanvien();
            nv.MdiParent = this;
            nv.Dock = DockStyle.Fill;
            nv.Show();
        }

        private void nhaphang_Click(object sender, EventArgs e)
        {
            Nhaphang nh = new Nhaphang();
            nh.MdiParent = this;
            nh.Dock = DockStyle.Fill;
            nh.Show();
        }

        private void xuathang_Click(object sender, EventArgs e)
        {
            Xuathang xh = new Xuathang();
            xh.MdiParent = this;
            xh.Dock = DockStyle.Fill;
            xh.Show();
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

   

        private void guna2CircleButton7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=RpRvEFgcppg");
        }
    }
}