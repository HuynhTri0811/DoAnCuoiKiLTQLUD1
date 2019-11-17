using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UsersDTO
    {
        private int _user_id;
        public int User_id
        {
            get { return _user_id; }
            set { _user_id = value; }
        }

        private string _user_kyDanh;
        public string User_kyDanh
        {
            get { return _user_kyDanh; }
            set { _user_kyDanh = value; }
        }

        private string _user_matKhau;
        public string User_matKhau
        {
            get { return _user_matKhau; }
            set { _user_matKhau = value; }
        }

        private string _user_status;
        public string User_status
        {
            get { return _user_status; }
            set { _user_status = value; }
        }
    }
}