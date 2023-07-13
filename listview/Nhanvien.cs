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
    public partial class Nhanvien : Form
    {
        public Nhanvien()
        {
            InitializeComponent();
        }

        private void Nhanvien_Load(object sender, EventArgs e)
        {
           
        

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            

        }
        
      
        private void button_chucnang_Click_1(object sender, EventArgs e)
        {
            Thongtinnhanvien f = new Thongtinnhanvien();
            f.Show();

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void hienthi_Click(object sender, EventArgs e)
        {
            NhanvienBLL dsnvbl = new NhanvienBLL();
            List<DTO.Nhanvien> listnv = dsnvbl.laytoanbonhanvien();
            listnhanvien.Items.Clear();
            foreach (DTO.Nhanvien nv in listnv)
            {
                ListViewItem lvi = new ListViewItem(nv.Manv + "");
                lvi.SubItems.Add(nv.Tennv);
                lvi.SubItems.Add(nv.Ngaysinh + "");
                lvi.SubItems.Add(nv.Diachi);
                lvi.SubItems.Add(nv.Sodienthoai + "");
                lvi.SubItems.Add(nv.SoCMTND + "");
                lvi.SubItems.Add(nv.Nguyenquan);
                lvi.SubItems.Add(nv.Ngayvao + "");
                lvi.SubItems.Add(nv.Gioitinh);
                lvi.SubItems.Add(nv.Chucvu + "");
                lvi.SubItems.Add(nv.TienLuong + "");
                listnhanvien.Items.Add(lvi);
                lvi.Tag = nv;
            }
        }

        private void Xóa_Click(object sender, EventArgs e)
        {
            if (listnhanvien.SelectedItems.Count > 0)
            {
                ListViewItem liv = listnhanvien.SelectedItems[0];
                DTO.Nhanvien nv = liv.Tag as DTO.Nhanvien;
                NhanvienBLL nvbl = new NhanvienBLL();
              
              
                    DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn sửa thông tin nhân viên không ", "Thông Báo!!", MessageBoxButtons.OKCancel);
                    if (dialogResult == DialogResult.OK)
                    {
                    bool kq = nvbl.xoanhanvien(nv.Manv);
                    if(kq)
                    {
                        hienthi.PerformClick();
                    }    
                   
                    }
                   
                
            }
        }

        private void timkiem_Click(object sender, EventArgs e)
        {


            if (listnhanvien.SelectedItems.Count > 0)
            {
                ListViewItem liv = listnhanvien.SelectedItems[0];
                DTO.Nhanvien nv = liv.Tag as DTO.Nhanvien;
                NhanvienBLL nvbl = new NhanvienBLL();
                bool kq = nvbl.timkiemnhanvien(nv.Manv);
                if (kq)
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn sửa thông tin nhân viên không ", "Thông Báo!!", MessageBoxButtons.OKCancel);
                    if (dialogResult == DialogResult.OK)
                    {
                        hienthi.PerformClick();
                    }

                }
            }



        }
    }
}
