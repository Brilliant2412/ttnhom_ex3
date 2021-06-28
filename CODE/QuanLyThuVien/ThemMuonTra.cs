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
        public string addMM;
        public string tenSachCu;

        public ThemMuonTra(string maMuon)
        {
            this.maMuon = maMuon;
            InitializeComponent();
        }

        private void ThemMuonTra_Load(object sender, EventArgs e)
        {
            
            DataTable theTable1 = new Database().SelectData("SELECT SoThe from TheThuVien");
            cbbSoThe.DisplayMember = "SoThe";
            cbbSoThe.ValueMember = "SoThe";
            cbbSoThe.DataSource = theTable1.Copy();
            DataTable theTable2 = new Database().SelectData("exec listAllSachAvailable");
            cbcTenSach.DisplayMember = "TenSach";
            cbcTenSach.ValueMember = "TenSach";
            cbcTenSach.DataSource = theTable2.Copy();
            if (string.IsNullOrEmpty(maMuon))
            {
                this.Text = "Thêm mượn trả";
                var res = new Database().Select("SELECT current_value FROM sys.sequences WHERE name = 'MuonTra_seq'");
                addMM = (Convert.ToInt32(res["current_value"])).ToString();
            }
            else
            {
                var r = new Database().Select(string.Format("SelectMuonTraandCTMTById '" + maMuon + "'"));
                dtPickerMuon.Value = Convert.ToDateTime(r["NgayMuon"]); 
                dtPickerTra.Value = Convert.ToDateTime(r["NgayHenTra"]);
                cbbSoThe.SelectedValue = r["SoThe"].ToString();
                cbcTenSach.SelectedValue = r["TenSach"].ToString();
                tenSachCu = r["TenSach"].ToString();
                this.Text = "Chỉnh sửa thông tin mượn trả";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            DateTime dtMuon = dtPickerMuon.Value;
            DateTime dtTra = dtPickerTra.Value;
            string soThe = cbbSoThe.Text;
            string tenSach = cbcTenSach.Text;
            List<CustomParameter> lstPara = new List<CustomParameter>();

            if (string.IsNullOrEmpty(maMuon))
            {
                sql = "InsertMTandCTMT";
                lstPara.Add(new CustomParameter()
                {
                    key = "@MaMM",
                    value = addMM
                });
            }
            else
            {
                sql = "UpdateMTandCTMT";
                lstPara.Add(new CustomParameter()
                {
                    key = "@MaMM",
                    value = maMuon
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@TenSachCu",
                    value = tenSachCu
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
            lstPara.Add(new CustomParameter()
            {
                key = "@TenSach",
                value = tenSach
            });

            var rs = new Database().execute(sql, lstPara);
            if (rs >= 1)
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
