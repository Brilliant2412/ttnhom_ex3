using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    class Database
    {
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=ttn_ex3;Integrated Security=True;";
        private SqlConnection conn;

        //private string sql;
        private DataTable dt;
        private SqlCommand cmd;
        public Database()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                //conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connected Failed: " + ex.Message);
            }

        }
        public DataTable SelectData(string sql)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)

            {
                MessageBox.Show("Data Loading ERROR: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataRow Select(string sql)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt.Rows[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loading Error: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }


        public int execute(string sql, List<CustomParameter> lstPara)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //return (int)cmd.ExecuteScalar();

                foreach (var p in lstPara)
                {
                    cmd.Parameters.AddWithValue(p.key, p.value);
                }
                var rs = cmd.ExecuteNonQuery();
                return (int)rs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error: " + ex.Message);
                return -100;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool del_ctMuonTra(string maSach)
        {
            bool check = false;
            try
            {
                conn.Open();
                string sql1 = "DELETE From CT_MuonTra where MaSach = '" + maSach + "'";
                SqlCommand cmd1 = new SqlCommand(sql1, conn);                
                cmd1.ExecuteNonQuery();
                check = true;
                conn.Close();
            }
            catch
            {
                check = false;
                throw;
            }
            return check;
        }

        public bool del_dataSach(string maSach)
        {
            bool check = false;
            try
            {
                conn.Open();
                string sql = "DELETE From Sach where MaSach = '" + maSach + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();                
                check = true;
                conn.Close();
            }
            catch (Exception)
            {
                check = false;
                throw;
            }


            return check;
        }

        /*------------------------------------------------------------------------------*/
        public bool del_DocGia(string madg)
        {
            bool check = false;
            try
            {
                conn.Open();
                string sql2 = "DELETE From DocGia where MaDG = '" + madg + "'";
                SqlCommand cmd2 = new SqlCommand(sql2, conn);
                cmd2.ExecuteNonQuery();
                check = true;
                conn.Close();
            }
            catch
            {
                check = false;
                throw;
            }
            return check;
        }
        public bool del_MaMuon_CTMuonTra(string maMuon)
        {
            bool check = false;
            try
            {
                conn.Open();
                string sql1 = "DELETE From CT_MuonTra where MaMuon = '" + maMuon + "'";
                SqlCommand cmd1 = new SqlCommand(sql1, conn);
                cmd1.ExecuteNonQuery();
                check = true;
                conn.Close();
            }
            catch
            {
                check = false;
                throw;
            }
            return check;
        }
        public bool del_NguoiMuon(string maMuon)
        {
            bool check = false;
            try
            {
                conn.Open();
                string sql2 = "DELETE From MuonTra where MaMuon = '" + maMuon + "'";
                SqlCommand cmd2 = new SqlCommand(sql2, conn);
                cmd2.ExecuteNonQuery();
                check = true;
                conn.Close();
            }
            catch
            {
                check = false;
                throw;
            }
            return check;
        }


        public bool executeNonQuery(string sql)
        {
            bool check = true; ;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                check = false;
            }
            return check;
        }
    }
}
