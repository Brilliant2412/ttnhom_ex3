using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            
            //DataTable theTable = new Database().SelectData("SELECT SoThe from TheThuVien where NgayBatDau is null");
            //cboxSoThe.DisplayMember = "SoThe";
            //cboxSoThe.ValueMember = "SoThe";
            //cboxSoThe.DataSource = theTable.Copy();
            var res = new Database().Select("SELECT current_value FROM sys.sequences WHERE name = 'TheThuVien_seg'");
            txtSothe.Text = (Convert.ToInt32(res["current_value"]) + 1).ToString();
            txtSothe.ReadOnly = true;
            if (string.IsNullOrEmpty(maDocGia))
            {
                this.Text = "Thêm độc giả";
            }
            else
            {
                var r = new Database().Select(string.Format("SelectDocGiaById '" + maDocGia + "'"));
                tboxDiaChi.Text = r["DiaChi"].ToString();
                tboxTenDocGia.Text = r["TenDocGia"].ToString();
                txtSothe.Text = r["SoThe"].ToString();
                //dtpNgayBatDau.Format = DateTimePickerFormat.Custom;
                //dtpNgayBatDau.CustomFormat = "dd-MM-yyyy";
                dtpNgayBatDau.Value = Convert.ToDateTime(r["NgayBatDau"]);
                //dtpNgayKetThuc.Format = DateTimePickerFormat.Custom;
                //dtpNgayKetThuc.CustomFormat = "dd-MM-yyyy";
                dtpNgayKetThuc.Value = Convert.ToDateTime(r["NgayHetHan"]);
                //DateTime.ParseExact(r["NgayHetHan"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                this.Text = "Chỉnh sửa thông tin độc giả";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql;
            string sql2 = "";
            string tenDocGia = tboxTenDocGia.Text;
            string diaChi = tboxDiaChi.Text;
            DateTime ngayBatDau = dtpNgayBatDau.Value;
            DateTime ngayHetHan = dtpNgayKetThuc.Value;
            string soTheAdd = txtSothe.Text;
            List<CustomParameter> lstPara = new List<CustomParameter>();
            List<CustomParameter> lstPara2 = new List<CustomParameter>();
            string soThe = "TV" + soTheAdd;
            if (string.IsNullOrEmpty(maDocGia))
            {
                sql = "ThemMoiDocGia";
                sql2 = "ThemMoiTheThuVIen";
                lstPara.Add(new CustomParameter()
                {
                    key = "@soThe",
                    value = soThe
                });
            }
            else
            {
                sql = "UpdateDocGia";
                sql2 = "UpdateTheThuVIen";
                lstPara.Add(new CustomParameter()
                {
                    key = "@maDocGia",
                    value = maDocGia
                });
                lstPara2.Add(new CustomParameter()
                {
                    key = "@soThe",
                    value = soTheAdd
                });

                lstPara.Add(new CustomParameter()
                {
                    key = "@soThe",
                    value = soTheAdd
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
           




            lstPara2.Add(new CustomParameter()
            {
                key = "@ngayBatDau",
                value = ngayBatDau.ToString("yyyy-MM-dd")
            });
            lstPara2.Add(new CustomParameter()
            {
                key = "@ngayHetHan",
                value = ngayHetHan.ToString("yyyy-MM-dd")
            });

            var rs2 = new Database().execute(sql2, lstPara2);
            var rs = new Database().execute(sql, lstPara);
            if (rs == 1 && rs2==1)
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

        private void txtSothe_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
