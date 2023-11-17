using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_Sinh_Vien
{
    partial class lt_SinhVien : Form
    {
        public lt_SinhVien(cls_SinhVien SinhVien)
        {
            InitializeComponent();
            lb_Hoten.Text = SinhVien.Hoten;
            lb_MSSV.Text = SinhVien.MSSV;
            lb_SDT.Text = SinhVien.SDT;
            lb_Email.Text = SinhVien.Email;
            lb_NgaySinh.Text = SinhVien.NgaySinh;
        }

        private void lt_SinhVien_Load(object sender, EventArgs e)
        {

        }

        private void lt_SinhVien_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Gainsboro;
        }

        private void lt_SinhVien_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
