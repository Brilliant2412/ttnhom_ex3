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
    public partial class ThemMuonTra : Form
    {
        private string maMuon;
        public ThemMuonTra(string maMuon)
        {
            this.lbNgayMuon.BackColor = System.Drawing.Color.Transparent;
            this.lbNgayTra.BackColor = System.Drawing.Color.Transparent;
            this.lbSoThe.BackColor = System.Drawing.Color.Transparent;
            this.maMuon = maMuon;
            InitializeComponent();
        }

        private void ThemMuonTra_Load(object sender, EventArgs e)
        {
            DataTable theTable1 = new Database().SelectData("SELECT SoThe from TheThuVien");
            cbbSoThe.DisplayMember = "SoThe";
            cbbSoThe.ValueMember = "SoThe";
            cbbSoThe.DataSource = theTable1.Copy();

            if (string.IsNullOrEmpty(maMuon))
            {
                this.Text = "Thêm mượn trả";
            }
            else
            {
                var r = new Database().Select(string.Format("SelectMuonTraById '" + maMuon + "'"));
                dtPickerMuon.Value = DateTime.ParseExact(r["NgayMuon"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                dtPickerTra.Value = DateTime.ParseExact(r["NgayHenTra"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                this.Text = "Chỉnh sửa thông tin mượn trả";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            DateTime dtMuon = dtPickerMuon.Value;
            DateTime dtTra = dtPickerTra.Value;
            string soThe = cbbSoThe.Text;

            List<CustomParameter> lstPara = new List<CustomParameter>();

            if (string.IsNullOrEmpty(maMuon))
            {
                sql = "ThemMoiMuonTra";
            }
            else
            {
                sql = "UpdateMuonTra";
                lstPara.Add(new CustomParameter()
                {
                    key = "@maMuon",
                    value = maMuon
                });
            }

            lstPara.Add(new CustomParameter()
            {
                key = "@ngayMuon",
                value = dtMuon.ToString("yyyy-MM-dd")
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@ngayHenTra",
                value = dtTra.ToString("yyyy-MM-dd")
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@soThe",
                value = soThe
            });


            var rs = new Database().execute(sql, lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(maMuon))
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
