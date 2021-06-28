
namespace QuanLyThuVien
{
    partial class FormSearchBook
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
            this.dvgSearch = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgSearch
            // 
            this.dvgSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgSearch.Location = new System.Drawing.Point(165, 74);
            this.dvgSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dvgSearch.Name = "dvgSearch";
            this.dvgSearch.RowHeadersWidth = 51;
            this.dvgSearch.RowTemplate.Height = 24;
            this.dvgSearch.Size = new System.Drawing.Size(701, 315);
            this.dvgSearch.TabIndex = 3;
            // 
            // FormSearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyThuVien.Properties.Resources._10_mnt_design_hinh_nen_giao_duc_truong_hoc_optimized;
            this.ClientSize = new System.Drawing.Size(952, 411);
            this.Controls.Add(this.dvgSearch);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSearchBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSearchBook";
            this.Load += new System.EventHandler(this.FormSearchBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgSearch;
    }
}