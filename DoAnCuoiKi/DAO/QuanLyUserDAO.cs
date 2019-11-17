using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class QuanLyUserDAO
    {
        public DataTable LayTatCaUser()
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "SELECT * FROM SanPham";
                provider.Connect(); ;
                DataTable dt = provider.Select(CommandType.Text, strSql);
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
        }

        public int FindOneUser(UsersDTO User)
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "SELECT * FROM Users WHERE User_kyDanh = @kyDanh and User_matKhau = @matKhau";
                provider.Connect(); ;
                DataTable dt = provider.Select(CommandType.Text, strSql, 
                            new SqlParameter { ParameterName = "@kyDanh", Value = User.User_kyDanh },
                            new SqlParameter { ParameterName = "@matKhau", Value = User.User_matKhau }
                            );
                return dt.Rows.Count;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
        }
    }
}
