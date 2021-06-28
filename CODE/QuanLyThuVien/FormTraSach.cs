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
using System.Threading;

namespace QuanLyThuVien
{
    public partial class FormTraSach : Form
    {
        public string maMuon;
        public DateTime ngayHenTra;
        public FormTraSach(string maMuon)
        {
            this.maMuon = maMuon;
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn trả sách ", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string sql = "updateCTMTKhiTraSach";
                string soThe = txtSoThe.Text;
                string tenSach = txtTenSach.Text;
                DateTime ngayTraNow = dtPickerTra.Value;
                List<CustomParameter> lstPara = new List<CustomParameter>();
                lstPara.Add(new CustomParameter()
                {
                    key = "@MaMM",
                    value = maMuon
                });

                lstPara.Add(new CustomParameter()
                {
                    key = "@ngayTra",
                    value = ngayTraNow.ToString("yyyy-MM-dd")
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
                    int res = DateTime.Compare(ngayHenTra, ngayTraNow);
                    if (res <= 0)
                    {
                        MessageBox.Show("Trả sách thành công và bạn trả sách đúng hoặc trước hạn");
                    }
                    else
                    {
                        MessageBox.Show("Trả sách thành công và bạn trả sách quá hạn");
                    }
                        
                    
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Thao tác không thành công");
                }
            }
            else
            {
                MessageBox.Show("Chọn lại sách muốn trả nếu chọn nhầm");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FormTraSach_Load(object sender, EventArgs e)
        {
            //mt.MaMuon,s.TenSach, mt.NgayMuon,mt.NgayHenTra,mt.SoThe,dg.TenDocGia
            this.Text = "Trả sách";
            var r = new Database().Select("exec searchMaMuon '" + maMuon + "'");
            ngayHenTra = Convert.ToDateTime(r["NgayHenTra"].ToString());
            txtSoThe.Text = r["SoThe"].ToString();
            txtTenSach.Text = r["TenSach"].ToString();
            txtSoThe.Enabled = false;
            txtTenSach.Enabled = false;
            int result = DateTime.Compare(DateTime.Now, ngayHenTra);
            if (result > 0)
            {
                string message = "Bạn đã trả muộn hơn so với hôm nay: "+ngayHenTra.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) + " < "+DateTime.Now.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture); ;
                string title = "Thông báo";
                MessageBox.Show(message,title);
            }
        }
    }
}
