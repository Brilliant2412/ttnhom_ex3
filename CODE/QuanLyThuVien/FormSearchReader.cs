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
    public partial class FormSearchReader : Form
    {
        string sqlSearch;
        public FormSearchReader()
        {
            InitializeComponent();
        }

        public FormSearchReader(string sql)
        {
            sqlSearch = sql;
            InitializeComponent();
        }

        private void LoadReader()
        {
            dgvSearchReader.DataSource = null;
            dgvSearchReader.DataSource = new Database().SelectData(sqlSearch);
            dgvSearchReader.Columns["MaDG"].HeaderText = "Mã Độc Giả";
            dgvSearchReader.Columns["TenDocGia"].HeaderText = "Tên Độc Giả";
            dgvSearchReader.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dgvSearchReader.Columns["SoThe"].HeaderText = "Số thẻ";
        }

        private void FormSearchReader_Load(object sender, EventArgs e)
        {
            LoadReader();
        }
    }
}
