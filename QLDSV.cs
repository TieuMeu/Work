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
    public partial class QLDSV : Form
    {
        public QLDSV()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void QLDSV_Load(object sender, EventArgs e)
        {
            listView1.Columns[0].Width = (int)(listView1.Width * 0.25);
            listView1.Columns[1].Width = (int)(listView1.Width * 0.25);
            listView1.Columns[2].Width = (int)(listView1.Width * 0.25);
            listView1.Columns[3].Width = (int)(listView1.Width * 0.25);
            listView1.Columns[4].Width = (int)(listView1.Width * 0.25);
            listView1.Columns[5].Width = (int)(listView1.Width * 0.25);
            listView1.Columns[6].Width = (int)(listView1.Width * 0.25);
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
        }
    }
}
