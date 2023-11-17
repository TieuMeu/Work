using Quan_ly_Sinh_Vien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class QLSV : Form
    {
        public QLSV()
        {
            InitializeComponent();
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            //Dl TextBox
            string str_Hoten = txt_Hoten.Text;
            string str_MSSV = txt_MSSV.Text;
            string str_SDT = txt_SDT.Text;
            string str_Email = txt_Email.Text;
            string str_NgaySinh = txt_NgaySinh.Text;
            //Khoi tAO
            cls_SinhVien SinhVien = new cls_SinhVien()
            {
                Hoten = str_Hoten,
                MSSV = str_MSSV,
                SDT = str_SDT,
                Email = str_Email,
                NgaySinh = str_NgaySinh,
            };





            lt_SinhVien item_sinhvien = new lt_SinhVien(SinhVien);
            item_sinhvien.TopLevel = false;

            pn_DanhSach.Controls.Add(item_sinhvien);
            item_sinhvien.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
