using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class DangNhapForm : Form
    {
        public DangNhapForm()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                UsersDTO User = new UsersDTO();
                User.User_kyDanh = tbKyDanh.Text;
                User.User_matKhau = tbMatKhau.Text;

                QuanLyUserBUS bus = new QuanLyUserBUS();
                int check = bus.FindOneUser(User);
                
                if(check == 1)
                {
                    //Dang nhap thanh cong
                    MessageBox.Show("Đăng nhập thành công", "Thông báo");
                }
                else
                {
                    //Dang nhap that bai
                    MessageBox.Show("Ký danh hoặc mật khẩu không đúng!", "Thông báo");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMatKhau.Checked)
            {
                //Check vao o hien mat khau
                tbMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                //Bo check o hien mat khau
                tbMatKhau.UseSystemPasswordChar = true;
            }
        }
    }
}
