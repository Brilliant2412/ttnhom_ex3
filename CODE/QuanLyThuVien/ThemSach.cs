using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class ThemSach : Form
    {
        private string maSach;
        private DataGridView dgv;
        public ThemSach(string maSach, DataGridView dgv)
        {
            this.maSach = maSach;
            this.dgv = dgv;
            InitializeComponent();
        }

        private void ThemSach_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maSach))
            {
                this.Text = "Thêm đầu sách";
            }
            else
            {
                var r = new Database().Select(string.Format("SelectSachById '" + maSach + "'"));
                tboxTheLoai.Text = r["TenTheLoai"].ToString();
                tboxNXB.Text = r["TenNXB"].ToString();
                tboxTacGia.Text = r["TenTacGia"].ToString();
                tboxTenSach.Text = r["TenSach"].ToString();
                nudSoLuong.Value = int.Parse(r["SoLuong"].ToString());
                this.Text = "Chỉnh sửa đầu sách";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql;
            string tenSach = tboxTenSach.Text;
            string tenTheLoai = tboxTheLoai.Text;
            string tenTacGia = tboxTacGia.Text;
            string tenNXB = tboxNXB.Text;
            int soLuong = (int)nudSoLuong.Value;

            List<CustomParameter> lstPara = new List<CustomParameter>();

            if (string.IsNullOrEmpty(maSach))
            {
                sql = "ThemMoiSach";
            }
            else
            {
                sql = "UpdateSach";
                lstPara.Add(new CustomParameter()
                {
                    key = "@MaSach",
                    value = maSach
                });
            }

            lstPara.Add(new CustomParameter()
            {
                key = "@tenSach",
                value = tenSach
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@tenTheLoai",
                value = tenTheLoai
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@tenTacGia",
                value = tenTacGia
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@tenNXB",
                value = tenNXB
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@soLuong",
                value = soLuong.ToString()
            });

            var rs = new Database().execute(sql, lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(maSach))
                {
                    MessageBox.Show("Thêm mới thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thao tác không thành công");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nudSoLuong_Click(object sender, EventArgs e)
        {
            nudSoLuong.Select(0, nudSoLuong.Value.ToString().Length);
        }
    }
}
