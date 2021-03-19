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
    public partial class QLSach : Form
    {
        public QLSach()
        {
            InitializeComponent();
        }

        private void Sach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ttn_ex3DataSet.Sach' table. You can move, or remove it, as needed.
            //this.sachTableAdapter.Fill(this.ttn_ex3DataSet.Sach);
            dataGridView1.DataSource = new Database().SelectData("select * from SACH");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            (new ThemSach(null, dataGridView1)).ShowDialog();
            reload();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maSach = dataGridView1.Rows[e.RowIndex].Cells["MaSach"].Value.ToString();
                new ThemSach(maSach, dataGridView1).ShowDialog();
                reload();
            }
        }

        private void reload()
        {
            dataGridView1.DataSource = new Database().SelectData("select * from SACH");
        }

        private void sachBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var db = new Database();
            if (MessageBox.Show("Bạn muốn xóa sách " + dataGridView1.CurrentRow.Cells["TenSach"].Value.ToString() + " ?", "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.del_ctMuonTra(dataGridView1.CurrentRow.Cells["MaSach"].Value.ToString());
                db.del_dataSach(dataGridView1.CurrentRow.Cells["MaSach"].Value.ToString());
            }

            reload();
        }

        private void resetValue()
        {
            txtSearchBook.Text = "";
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchBook.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (cbbForSearchBook.SelectedIndex != -1)
                {
                    String valueSearch = txtSearchBook.Text;
                    var db = new Database();
                    String sqlSearch = "";
                    if (cbbForSearchBook.SelectedIndex == 0)
                    {
                        sqlSearch = "exec searchMaSach '" + valueSearch + "'";
                        if (db.SelectData(sqlSearch).Rows.Count != 0)
                        {
                            new FormSearchBook(sqlSearch).Show();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (cbbForSearchBook.SelectedIndex == 1)
                    {
                        sqlSearch = "exec searchTenSach N'" + valueSearch + "'";
                        if (db.SelectData(sqlSearch).Rows.Count != 0)
                        {
                            new FormSearchBook(sqlSearch).Show();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (cbbForSearchBook.SelectedIndex == 2)
                    {
                        sqlSearch = "exec searchTenTheLoai N'" + valueSearch + "'";
                        if (db.SelectData(sqlSearch).Rows.Count != 0)
                        {
                            new FormSearchBook(sqlSearch).Show();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (cbbForSearchBook.SelectedIndex == 3)
                    {
                        sqlSearch = "exec searchTenTacGia N'" + valueSearch + "'";
                        if (db.SelectData(sqlSearch).Rows.Count != 0)
                        {
                            new FormSearchBook(sqlSearch).Show();
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
