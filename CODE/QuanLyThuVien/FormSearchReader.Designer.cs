
namespace QuanLyThuVien
{
    partial class FormSearchReader
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
            this.dgvSearchReader = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchReader)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSearchReader
            // 
            this.dgvSearchReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchReader.Location = new System.Drawing.Point(144, 78);
            this.dgvSearchReader.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSearchReader.Name = "dgvSearchReader";
            this.dgvSearchReader.RowHeadersWidth = 51;
            this.dgvSearchReader.Size = new System.Drawing.Size(688, 282);
            this.dgvSearchReader.TabIndex = 0;
            // 
            // FormSearchReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyThuVien.Properties.Resources._10_mnt_design_hinh_nen_giao_duc_truong_hoc_optimized;
            this.ClientSize = new System.Drawing.Size(895, 409);
            this.Controls.Add(this.dgvSearchReader);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSearchReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSearchReader";
            this.Load += new System.EventHandler(this.FormSearchReader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchReader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSearchReader;
    }
}