using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listview.Resources.UI
{
    public partial class Control : UserControl
    {
        public Control()
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

       

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //
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
    }
}
