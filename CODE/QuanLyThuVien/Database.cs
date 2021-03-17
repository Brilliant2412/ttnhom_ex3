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
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=ttn_ex3;Trusted_Connection=Yes;";
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


        public Boolean del_data(String magv)
        {
            bool check = false;
            try
            {
                conn.Open();
                string sql = "DELETE From GIAOVIEN where MaGV = '" + magv + "'";
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

        public bool del_dataLop(String maLop)
        {
            bool check = false;
            try
            {
                conn.Open();
                string sql = "DELETE From LOP where MaLop = '" + maLop + "'";
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

        public bool del_dataHS(string mahs)
        {
            bool check = false;
            try
            {
                conn.Open();
                string sql = "DELETE From HOCSINH where MaHS = '" + mahs + "'";
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
