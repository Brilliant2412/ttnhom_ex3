
namespace QuanLyThuVien
{
    partial class FormSearchMuonTra
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
            this.dgvSearchMuonTra = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchMuonTra)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSearchMuonTra
            // 
            this.dgvSearchMuonTra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearchMuonTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchMuonTra.Location = new System.Drawing.Point(70, 114);
            this.dgvSearchMuonTra.Name = "dgvSearchMuonTra";
            this.dgvSearchMuonTra.Size = new System.Drawing.Size(550, 153);
            this.dgvSearchMuonTra.TabIndex = 1;
            // 
            // FormSearchMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 352);
            this.Controls.Add(this.dgvSearchMuonTra);
            this.Name = "FormSearchMuonTra";
            this.Text = "FormSearchMuonTra";
            this.Load += new System.EventHandler(this.FormSearchMuonTra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchMuonTra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSearchMuonTra;
    }
}