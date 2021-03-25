
namespace QuanLyThuVien
{
    partial class QLMuonTra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbInfor = new System.Windows.Forms.TextBox();
            this.cbbOption = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvMuonTra = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuonTra)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(824, 402);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 36);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(811, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 33);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbInfor
            // 
            this.txbInfor.Location = new System.Drawing.Point(324, 20);
            this.txbInfor.Name = "txbInfor";
            this.txbInfor.Size = new System.Drawing.Size(350, 20);
            this.txbInfor.TabIndex = 11;
            // 
            // cbbOption
            // 
            this.cbbOption.FormattingEnabled = true;
            this.cbbOption.Items.AddRange(new object[] {
            "Mã mượn",
            "Số thẻ"});
            this.cbbOption.Location = new System.Drawing.Point(76, 19);
            this.cbbOption.Name = "cbbOption";
            this.cbbOption.Size = new System.Drawing.Size(131, 21);
            this.cbbOption.TabIndex = 10;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(189, 402);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 36);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvMuonTra
            // 
            this.dgvMuonTra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMuonTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuonTra.Location = new System.Drawing.Point(50, 72);
            this.dgvMuonTra.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMuonTra.Name = "dgvMuonTra";
            this.dgvMuonTra.RowHeadersWidth = 51;
            this.dgvMuonTra.RowTemplate.Height = 24;
            this.dgvMuonTra.Size = new System.Drawing.Size(939, 284);
            this.dgvMuonTra.TabIndex = 8;
            this.dgvMuonTra.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMuonTra_CellDoubleClick);
            // 
            // QLMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 558);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txbInfor);
            this.Controls.Add(this.cbbOption);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvMuonTra);
            this.Name = "QLMuonTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLMuonTra";
            this.Load += new System.EventHandler(this.QLMuonTra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuonTra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbInfor;
        private System.Windows.Forms.ComboBox cbbOption;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvMuonTra;
    }
}