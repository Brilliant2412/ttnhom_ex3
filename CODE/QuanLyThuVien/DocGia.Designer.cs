
namespace QuanLyThuVien
{
    partial class DocGia
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
            this.addDocGiaBtn = new System.Windows.Forms.Button();
            this.dgvDocGia = new System.Windows.Forms.DataGridView();
            this.cbbForSearchReader = new System.Windows.Forms.ComboBox();
            this.txtSearchReader = new System.Windows.Forms.TextBox();
            this.btnSearchReader = new System.Windows.Forms.Button();
            this.btnDealeteReader = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // addDocGiaBtn
            // 
            this.addDocGiaBtn.BackColor = System.Drawing.Color.Aqua;
            this.addDocGiaBtn.Location = new System.Drawing.Point(203, 498);
            this.addDocGiaBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addDocGiaBtn.Name = "addDocGiaBtn";
            this.addDocGiaBtn.Size = new System.Drawing.Size(119, 44);
            this.addDocGiaBtn.TabIndex = 3;
            this.addDocGiaBtn.Text = "Thêm";
            this.addDocGiaBtn.UseVisualStyleBackColor = false;
            this.addDocGiaBtn.Click += new System.EventHandler(this.addDocGiaBtn_Click);
            // 
            // dgvDocGia
            // 
            this.dgvDocGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocGia.Location = new System.Drawing.Point(203, 84);
            this.dgvDocGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDocGia.Name = "dgvDocGia";
            this.dgvDocGia.RowHeadersWidth = 51;
            this.dgvDocGia.RowTemplate.Height = 24;
            this.dgvDocGia.Size = new System.Drawing.Size(901, 388);
            this.dgvDocGia.TabIndex = 2;
            this.dgvDocGia.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocGia_CellDoubleClick);
            // 
            // cbbForSearchReader
            // 
            this.cbbForSearchReader.FormattingEnabled = true;
            this.cbbForSearchReader.Items.AddRange(new object[] {
            "Mã Độc Giả",
            "Tên Độc Giả",
            "Số thẻ"});
            this.cbbForSearchReader.Location = new System.Drawing.Point(203, 27);
            this.cbbForSearchReader.Margin = new System.Windows.Forms.Padding(4);
            this.cbbForSearchReader.Name = "cbbForSearchReader";
            this.cbbForSearchReader.Size = new System.Drawing.Size(173, 24);
            this.cbbForSearchReader.TabIndex = 4;
            // 
            // txtSearchReader
            // 
            this.txtSearchReader.Location = new System.Drawing.Point(479, 27);
            this.txtSearchReader.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchReader.Name = "txtSearchReader";
            this.txtSearchReader.Size = new System.Drawing.Size(357, 22);
            this.txtSearchReader.TabIndex = 5;
            // 
            // btnSearchReader
            // 
            this.btnSearchReader.BackColor = System.Drawing.Color.Aqua;
            this.btnSearchReader.Location = new System.Drawing.Point(992, 18);
            this.btnSearchReader.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchReader.Name = "btnSearchReader";
            this.btnSearchReader.Size = new System.Drawing.Size(112, 41);
            this.btnSearchReader.TabIndex = 6;
            this.btnSearchReader.Text = "Tìm kiếm";
            this.btnSearchReader.UseVisualStyleBackColor = false;
            this.btnSearchReader.Click += new System.EventHandler(this.btnSearchReader_Click);
            // 
            // btnDealeteReader
            // 
            this.btnDealeteReader.BackColor = System.Drawing.Color.Red;
            this.btnDealeteReader.Location = new System.Drawing.Point(992, 498);
            this.btnDealeteReader.Margin = new System.Windows.Forms.Padding(4);
            this.btnDealeteReader.Name = "btnDealeteReader";
            this.btnDealeteReader.Size = new System.Drawing.Size(112, 44);
            this.btnDealeteReader.TabIndex = 7;
            this.btnDealeteReader.Text = "Xóa";
            this.btnDealeteReader.UseVisualStyleBackColor = false;
            this.btnDealeteReader.Click += new System.EventHandler(this.btnDealeteReader_Click);
            // 
            // DocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyThuVien.Properties.Resources._12fd70f0805bf2306f87753b08627757;
            this.ClientSize = new System.Drawing.Size(1262, 648);
            this.Controls.Add(this.btnDealeteReader);
            this.Controls.Add(this.btnSearchReader);
            this.Controls.Add(this.txtSearchReader);
            this.Controls.Add(this.cbbForSearchReader);
            this.Controls.Add(this.addDocGiaBtn);
            this.Controls.Add(this.dgvDocGia);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DocGia";
            this.Load += new System.EventHandler(this.DocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addDocGiaBtn;
        private System.Windows.Forms.DataGridView dgvDocGia;
        private System.Windows.Forms.ComboBox cbbForSearchReader;
        private System.Windows.Forms.TextBox txtSearchReader;
        private System.Windows.Forms.Button btnSearchReader;
        private System.Windows.Forms.Button btnDealeteReader;
    }
}