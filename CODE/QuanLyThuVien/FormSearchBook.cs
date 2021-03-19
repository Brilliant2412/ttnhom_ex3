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
    public partial class FormSearchBook : Form
    {
        string sqlSearch;
        public FormSearchBook()
        {
            InitializeComponent();
        }

        public FormSearchBook(string sql)
        {
            sqlSearch = sql;
            InitializeComponent();
        }

        private void LoadBooks()
        {
            dvgSearch.DataSource = null;
            dvgSearch.DataSource = new Database().SelectData(sqlSearch);
            dvgSearch.Columns["MaSach"].HeaderText = "Mã Sách";
            dvgSearch.Columns["TenSach"].HeaderText = "Tên Sách";
            dvgSearch.Columns["TenTheLoai"].HeaderText = "Thể Loại";
            dvgSearch.Columns["TenTacGia"].HeaderText = "Tác Giả";
            dvgSearch.Columns["TenNXB"].HeaderText = "Nhà Xuất Bản";
            dvgSearch.Columns["SoLuong"].HeaderText = "Số Lượng";
        }

        private void FormSearchBook_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }
    }
}
