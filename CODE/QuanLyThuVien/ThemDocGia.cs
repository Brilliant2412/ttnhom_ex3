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
    public partial class ThemDocGia : Form
    {
        private string maDocGia;
        public ThemDocGia(string maDocGia)
        {
            this.maDocGia = maDocGia;
            InitializeComponent();
        }

        private void ThemDocGia_Load(object sender, EventArgs e)
        {
            DataTable theTable = new Database().SelectData("SELECT SoThe from TheThuVien");
            cboxSoThe.DisplayMember = "SoThe";
            cboxSoThe.ValueMember = "SoThe";
            cboxSoThe.DataSource = theTable.Copy();
            if (string.IsNullOrEmpty(maDocGia))
            {
                this.Text = "Thêm đầu sách";

            }
            else
            {
                var r = new Database().Select(string.Format("SelectDocGiaById '" + maDocGia + "'"));
                tboxDiaChi.Text = r["DiaChi"].ToString();
                tboxTenDocGia.Text = r["TenDocGia"].ToString();


                this.Text = "Chỉnh sửa đầu sách";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql;
            string tenDocGia = tboxTenDocGia.Text;
            string diaChi = tboxDiaChi.Text;
            string soThe = cboxSoThe.Text;

            List<CustomParameter> lstPara = new List<CustomParameter>();

            if (string.IsNullOrEmpty(maDocGia))
            {
                sql = "ThemMoiDocGia";
            }
            else
            {
                sql = "UpdateDocGia";
                lstPara.Add(new CustomParameter()
                {
                    key = "@maDocGia",
                    value = maDocGia
                });
            }

            lstPara.Add(new CustomParameter()
            {
                key = "@tenDocGia",
                value = tenDocGia
            }); ;

            lstPara.Add(new CustomParameter()
            {
                key = "@diaChi",
                value = diaChi
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@soThe",
                value = soThe
            });


            var rs = new Database().execute(sql, lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(maDocGia))
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
    }
}
