using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class HocSinhDTO
    {
        private string _maHocSinh;
        public string MaHocSinh
        {
            get { return _maHocSinh; }
            set { _maHocSinh = value; }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        private string _hoTen;
        public string Hoten
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }

        private DateTime _ngaySinh;
        public DateTime NgaySinh
        {
            get { return _ngaySinh; }
            set { _ngaySinh = value; }
        }

        private string _diaChi;
        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }

        private string _maLop;
        public string MaLop
        {
            get { return _maLop; }
            set { _maLop = value; }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
