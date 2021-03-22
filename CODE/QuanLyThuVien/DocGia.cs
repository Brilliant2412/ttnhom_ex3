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


    }
}

