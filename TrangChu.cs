using Login;
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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }


        public void loadform(object Form)
        {
            if (this.pn_main.Controls.Count > 0)
                this.pn_main.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pn_main.Controls.Add(f);
            this.pn_main.Tag = f;
            f.Show();
        }



        private void Close_menu_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_Sinhvien_Click_1(object sender, EventArgs e)
        {
            loadform(new QLSV());
        }

        private void bt_GV_Click(object sender, EventArgs e)
        {
            loadform(new QLGV());
        }

        private void bt_qldsv_Click(object sender, EventArgs e)
        {
            loadform(new QLDSV());
        }
    }
}
