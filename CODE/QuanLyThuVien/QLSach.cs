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
    }
}
