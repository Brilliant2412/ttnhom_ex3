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
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DocGia Docgia = new DocGia();
            Docgia.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            QLSach s = new QLSach();
            s.Visible = true;
        }
    }
}
