using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_HinhChuNhat_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 1.0;
        }

        private void btnDientich_Click(object sender, EventArgs e)
        {
            HINH_CHU_NHAT  hcn = new HINH_CHU_NHAT ();
            hcn.chieudai = Double.Parse(txtCao.Text);
            hcn.chieurong = Double.Parse(txtRong.Text);
            txtketqua.Text = hcn.tinhdientich().ToString();
        }

        private void btnChuvi_Click(object sender, EventArgs e)
        {
            HINH_CHU_NHAT hcn = new HINH_CHU_NHAT();
            hcn.chieudai = Double.Parse(txtCao.Text);
            hcn.chieurong = Double.Parse(txtRong.Text);
            txtketqua.Text = hcn.tinhchuvi().ToString();
        }
    }
    
}
