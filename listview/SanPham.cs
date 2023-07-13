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
    public partial class SanPham : Form
    {
        public SanPham()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); 
            form1.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            cungcapsp f = new cungcapsp();
            f.Show();

        }
    }
}
