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
    public partial class DocGia : Form
    {
        public DocGia()
        {
            InitializeComponent();
        }

        private void DocGia_Load(object sender, EventArgs e)
        {
            dgvDocGia.DataSource = new Database().SelectData("select * from DocGia");
        }

        private void dgvDocGia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maDocGia = dgvDocGia.Rows[e.RowIndex].Cells["MaDG"].Value.ToString();
                new ThemDocGia(maDocGia).ShowDialog();
                DocGia_Load(sender, e);
            }
        }

        private void addDocGiaBtn_Click(object sender, EventArgs e)
        {
            new ThemDocGia(null).ShowDialog();
        }

        private void reload()
        {
            dgvDocGia.DataSource = new Database().SelectData("select * from DocGia");
        }

        private void btnDealeteReader_Click(object sender, EventArgs e)
        {
            var db = new Database();
            if (MessageBox.Show("Bạn muốn xóa độc giả có mã " + dgvDocGia.CurrentRow.Cells["MaDG"].Value.ToString() + " ?", "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.del_DocGia(dgvDocGia.CurrentRow.Cells["MaDG"].Value.ToString());
            }

            reload();
        }

        private void resetValue()
        {
            txtSearchReader.Text = "";
        }

        private void btnSearchReader_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchReader.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (cbbForSearchReader.SelectedIndex != -1)
                {
                    String valueSearch = txtSearchReader.Text;
                    var db = new Database();
                    String sqlSearch = "";
                    if (cbbForSearchReader.SelectedIndex == 0)
                    {
                        sqlSearch = "exec searchMaDG '" + valueSearch + "'";
                        if (db.SelectData(sqlSearch).Rows.Count != 0)
                        {
                            new FormSearchReader(sqlSearch).Show();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (cbbForSearchReader.SelectedIndex == 1)
                    {
                        sqlSearch = "exec searchTenDG N'" + valueSearch + "'";
                        if (db.SelectData(sqlSearch).Rows.Count != 0)
                        {
                            new FormSearchReader(sqlSearch).Show();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (cbbForSearchReader.SelectedIndex == 2)
                    {
                        sqlSearch = "exec searchSoThe '" + valueSearch + "'";
                        if (db.SelectData(sqlSearch).Rows.Count != 0)
                        {
                            new FormSearchReader(sqlSearch).Show();
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

