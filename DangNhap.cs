using Quan_ly_Sinh_Vien;
using System.Drawing.Drawing2D;
using System.Text;

namespace Login
{
    public partial class DangNhap : Form
    {
        private const int CORNER_RADIUS = 15;
        private bool isDragging = false;
        private int offsetX, offsetY;
        public DangNhap()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Paint += DangNhap_Load;
            this.MouseDown += TaskBar_MouseDown;
            this.MouseMove += TaskBar_MouseMove;
            this.MouseUp += TaskBar_MouseUp;

        }

        private void Close_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Close();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(new Rectangle(0, 0, CORNER_RADIUS * 2, CORNER_RADIUS * 2), 180, 90);
            path.AddArc(new Rectangle(Width - CORNER_RADIUS * 2, 0, CORNER_RADIUS * 2, CORNER_RADIUS * 2), 270, 90);
            path.AddArc(new Rectangle(Width - CORNER_RADIUS * 2, Height - CORNER_RADIUS * 2, CORNER_RADIUS * 2, CORNER_RADIUS * 2), 0, 90);
            path.AddArc(new Rectangle(0, Height - CORNER_RADIUS * 2, CORNER_RADIUS * 2, CORNER_RADIUS * 2), 90, 90);
            path.CloseFigure();

            Region = new Region(path);
        }

        private void TaskBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TaskBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                offsetX = e.X;
                offsetY = e.Y;
            }
        }

        private void TaskBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Left += e.X - offsetX;
                this.Top += e.Y - offsetY;
            }
        }

        private void TaskBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (tbusername.Text == "")
            {
                MessageBox.Show("Chua Nhap Tai Khoan !!");
                tbusername.Focus();
                return;
            }
            if (tbpassword.Text == "")
            {
                MessageBox.Show("Chua Nhap Mat Khau !!");
                tbpassword.Focus();
                return;
            }
            else
            {

                //QLSV form2 = new QLSV();

                //// Chuyển sang Form2
                //form2.Show();
                //QLDSV form4 = new QLDSV();
                //form4.Show();
                TrangChu form5 = new TrangChu();
                form5.Show();

            }


        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            tbpassword.UseSystemPasswordChar = false;
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            tbpassword.UseSystemPasswordChar = true;
        }
    }
}