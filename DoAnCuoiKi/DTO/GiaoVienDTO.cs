using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class GiaoVienDTO
    {
        private string _maGiaoVien;
        public string MaGiaoVien
        {
            get { return _maGiaoVien; }
            set { _maGiaoVien = value; }
        }

        private string _password;
        public string PassWord
        {
            get { return _password; }
            set { _password = value; }
        }

        private string _hoTen;
        public string HoTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }


        private string _diaChi;
        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }


        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }


        private string _sdt;
        public string SDT
        {
            get { return _sdt; }
            set { _sdt = value; }
        }


        private int _maKhoi;
        public int MaKhoi
        {
            get { return _maKhoi; }
            set { _maKhoi = value; }
        }


    }
}
