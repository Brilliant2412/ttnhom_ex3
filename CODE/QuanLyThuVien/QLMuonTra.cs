using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class QLMuonTra : Form
    {
        public QLMuonTra()
        {
            InitializeComponent();
        }

        private void QLMuonTra_Load(object sender, EventArgs e)
        {
            dgvMuonTra.DataSource = new Database().SelectData("SELECT * FROM MuonTra");
        }
        private void dgvMuonTra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maMuon = dgvMuonTra.Rows[e.RowIndex].Cells["MaMuon"].Value.ToString();
                new ThemMuonTra(maMuon).ShowDialog();
                QLMuonTra_Load(sender, e);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            new ThemMuonTra(null).ShowDialog();
            reload();
        }
        private void reload()
        {
            dgvMuonTra.DataSource = new Database().SelectData("SELECT * FROM MuonTra");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var r = new Database();
            if (MessageBox.Show("Bạn muốn xóa độc giả có mã " + dgvMuonTra.CurrentRow.Cells["MaMuon"].Value.ToString() + " ?", "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                r.del_MaMuon_CTMuonTra(dgvMuonTra.CurrentRow.Cells["MaMuon"].Value.ToString());
                r.del_NguoiMuon(dgvMuonTra.CurrentRow.Cells["MaMuon"].Value.ToString());
            }
            reload();
        }
        private void resetValue()
        {
            txbInfor.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbInfor.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (cbbOption.SelectedIndex != -1)
                {
                    String valueSearch = txbInfor.Text;
                    var db = new Database();
                    String sqlSearch = "";
                    if (cbbOption.SelectedIndex == 0)
                    {
                        sqlSearch = "exec searchMaMuon '" + valueSearch + "'";
                        if (db.SelectData(sqlSearch).Rows.Count != 0)
                        {
                            new FormSearchMuonTra(sqlSearch).Show();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (cbbOption.SelectedIndex == 1)
                    {
                        sqlSearch = "exec searchSoTheNguoiMuon '" + valueSearch + "'";
                        if (db.SelectData(sqlSearch).Rows.Count != 0)
                        {
                            new FormSearchMuonTra(sqlSearch).Show();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                resetValue();
            }
        }
    }
}
