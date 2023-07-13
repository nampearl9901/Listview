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
    public partial class listitem : UserControl
    {
        public listitem()
        {
            InitializeComponent();
        }
        public Image itemImage
        {
            get { return imgitem.Image; }
            set { imgitem.Image = value; }
        }
        public string itemName
        {
            get { return lblname.Text; }
               set { lblname.Text = value; }
        }
        public string itemgia
        {
            get { return lblgia.Text; }
            set { lblgia.Text = value; }
        }
    }
}
