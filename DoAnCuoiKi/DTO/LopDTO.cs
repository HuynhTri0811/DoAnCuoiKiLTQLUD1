using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DTO
{
    class LopDTO
    {
        private string _maLop;
        public string MaLop
        {
            get { return _maLop; }
            set { _maLop = value; }
        }

        private string _tenLop;
        public string TenLop
        {
            get { return _tenLop; }
            set { _tenLop = value; }
        }

        private int _maKhoi;
        public int MaKhoi
        {
            get { return _maKhoi; }
            set { _maKhoi = value; }
        }

    }
}
