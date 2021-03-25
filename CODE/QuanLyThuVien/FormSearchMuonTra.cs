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
    public partial class FormSearchMuonTra : Form
    {
        string sqlSearch;
        public FormSearchMuonTra()
        {
            InitializeComponent();
        }
        public FormSearchMuonTra(string sql)
        {
            sqlSearch = sql;
            InitializeComponent();
        }
        private void LoadInformation()
        {
            dgvSearchMuonTra.DataSource = null;
            dgvSearchMuonTra.DataSource = new Database().SelectData(sqlSearch);
            dgvSearchMuonTra.Columns["MaMuon"].HeaderText = "Mã mượn";
            dgvSearchMuonTra.Columns["NgayMuon"].HeaderText = "Ngày mượn";
            dgvSearchMuonTra.Columns["NgayHenTra"].HeaderText = "Ngày hẹn trả";
            dgvSearchMuonTra.Columns["SoThe"].HeaderText = "Số thẻ";
        }

        private void FormSearchMuonTra_Load(object sender, EventArgs e)
        {
            LoadInformation();
        }
    }
}
