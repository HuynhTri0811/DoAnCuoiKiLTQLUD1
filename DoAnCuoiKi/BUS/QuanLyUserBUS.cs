using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAO;
using DTO;

namespace BUS
{
    public class QuanLyUserBUS
    {
        public DataTable LayTatCaUser()
        {
            try
            {
                QuanLyUserDAO dao = new QuanLyUserDAO();
                return dao.LayTatCaUser();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int FindOneUser(UsersDTO User)
        {
            try
            {
                QuanLyUserDAO dao = new QuanLyUserDAO();
                return dao.FindOneUser(User);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
