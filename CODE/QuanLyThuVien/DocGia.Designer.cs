
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
            this.addDocGiaBtn.Location = new System.Drawing.Point(45, 405);
            this.addDocGiaBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addDocGiaBtn.Name = "addDocGiaBtn";
            this.addDocGiaBtn.Size = new System.Drawing.Size(89, 36);
            this.addDocGiaBtn.TabIndex = 3;
            this.addDocGiaBtn.Text = "Thêm";
            this.addDocGiaBtn.UseVisualStyleBackColor = true;
            this.addDocGiaBtn.Click += new System.EventHandler(this.addDocGiaBtn_Click);
            // 
            // dgvDocGia
            // 
            this.dgvDocGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocGia.Location = new System.Drawing.Point(6, 66);
            this.dgvDocGia.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDocGia.Name = "dgvDocGia";
            this.dgvDocGia.RowHeadersWidth = 51;
            this.dgvDocGia.RowTemplate.Height = 24;
            this.dgvDocGia.Size = new System.Drawing.Size(762, 284);
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
            this.cbbForSearchReader.Location = new System.Drawing.Point(45, 22);
            this.cbbForSearchReader.Name = "cbbForSearchReader";
            this.cbbForSearchReader.Size = new System.Drawing.Size(131, 21);
            this.cbbForSearchReader.TabIndex = 4;
            // 
            // txtSearchReader
            // 
            this.txtSearchReader.Location = new System.Drawing.Point(224, 22);
            this.txtSearchReader.Name = "txtSearchReader";
            this.txtSearchReader.Size = new System.Drawing.Size(350, 20);
            this.txtSearchReader.TabIndex = 5;
            // 
            // btnSearchReader
            // 
            this.btnSearchReader.Location = new System.Drawing.Point(637, 15);
            this.btnSearchReader.Name = "btnSearchReader";
            this.btnSearchReader.Size = new System.Drawing.Size(84, 33);
            this.btnSearchReader.TabIndex = 6;
            this.btnSearchReader.Text = "Tìm kiếm";
            this.btnSearchReader.UseVisualStyleBackColor = true;
            this.btnSearchReader.Click += new System.EventHandler(this.btnSearchReader_Click);
            // 
            // btnDealeteReader
            // 
            this.btnDealeteReader.Location = new System.Drawing.Point(637, 405);
            this.btnDealeteReader.Name = "btnDealeteReader";
            this.btnDealeteReader.Size = new System.Drawing.Size(84, 36);
            this.btnDealeteReader.TabIndex = 7;
            this.btnDealeteReader.Text = "Xóa";
            this.btnDealeteReader.UseVisualStyleBackColor = true;
            this.btnDealeteReader.Click += new System.EventHandler(this.btnDealeteReader_Click);
            // 
            // DocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 509);
            this.Controls.Add(this.btnDealeteReader);
            this.Controls.Add(this.btnSearchReader);
            this.Controls.Add(this.txtSearchReader);
            this.Controls.Add(this.cbbForSearchReader);
            this.Controls.Add(this.addDocGiaBtn);
            this.Controls.Add(this.dgvDocGia);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DocGia";
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