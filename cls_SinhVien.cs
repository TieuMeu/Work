using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_Sinh_Vien
{
     internal class cls_SinhVien
    {
        private string m_Hoten = "";
        private string m_MSSV = "";
        private string m_SDT = "";
        private string m_Email = "";
        private string m_NgaySinh = "";

        public string Hoten { get => m_Hoten; set => m_Hoten = value; }
        public string MSSV { get => m_MSSV; set => m_MSSV = value; }
        public string SDT { get => m_SDT; set => m_SDT = value; }
        public string Email { get => m_Email; set => m_Email = value; }
        public string NgaySinh { get => m_NgaySinh; set => m_NgaySinh = value; }
    }
}
