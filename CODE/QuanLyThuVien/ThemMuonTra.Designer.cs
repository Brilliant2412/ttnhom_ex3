
namespace QuanLyThuVien
{
    partial class ThemMuonTra
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
            this.cbbSoThe = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lbSoThe = new System.Windows.Forms.Label();
            this.lbNgayTra = new System.Windows.Forms.Label();
            this.lbNgayMuon = new System.Windows.Forms.Label();
            this.dtPickerMuon = new System.Windows.Forms.DateTimePicker();
            this.dtPickerTra = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cbbSoThe
            // 
            this.cbbSoThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSoThe.FormattingEnabled = true;
            this.cbbSoThe.Location = new System.Drawing.Point(289, 248);
            this.cbbSoThe.Margin = new System.Windows.Forms.Padding(2);
            this.cbbSoThe.Name = "cbbSoThe";
            this.cbbSoThe.Size = new System.Drawing.Size(232, 32);
            this.cbbSoThe.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(334, 77);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 24);
            this.label6.TabIndex = 45;
            this.label6.Text = "THÔNG TIN CHUNG";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(183, 339);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(56, 39);
            this.btnLuu.TabIndex = 44;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(470, 339);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(56, 39);
            this.btnHuy.TabIndex = 43;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lbSoThe
            // 
            this.lbSoThe.AutoSize = true;
            this.lbSoThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoThe.Location = new System.Drawing.Point(129, 248);
            this.lbSoThe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSoThe.Name = "lbSoThe";
            this.lbSoThe.Size = new System.Drawing.Size(64, 24);
            this.lbSoThe.TabIndex = 40;
            this.lbSoThe.Text = "Số thẻ";
            // 
            // lbNgayTra
            // 
            this.lbNgayTra.AutoSize = true;
            this.lbNgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayTra.Location = new System.Drawing.Point(129, 187);
            this.lbNgayTra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNgayTra.Name = "lbNgayTra";
            this.lbNgayTra.Size = new System.Drawing.Size(117, 24);
            this.lbNgayTra.TabIndex = 39;
            this.lbNgayTra.Text = "Ngày hẹn trả";
            // 
            // lbNgayMuon
            // 
            this.lbNgayMuon.AutoSize = true;
            this.lbNgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayMuon.Location = new System.Drawing.Point(129, 125);
            this.lbNgayMuon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNgayMuon.Name = "lbNgayMuon";
            this.lbNgayMuon.Size = new System.Drawing.Size(108, 24);
            this.lbNgayMuon.TabIndex = 38;
            this.lbNgayMuon.Text = "Ngày mượn";
            // 
            // dtPickerMuon
            // 
            this.dtPickerMuon.Location = new System.Drawing.Point(289, 128);
            this.dtPickerMuon.Name = "dtPickerMuon";
            this.dtPickerMuon.Size = new System.Drawing.Size(232, 20);
            this.dtPickerMuon.TabIndex = 47;
            // 
            // dtPickerTra
            // 
            this.dtPickerTra.Location = new System.Drawing.Point(289, 187);
            this.dtPickerTra.Name = "dtPickerTra";
            this.dtPickerTra.Size = new System.Drawing.Size(232, 20);
            this.dtPickerTra.TabIndex = 47;
            // 
            // ThemMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 463);
            this.Controls.Add(this.dtPickerTra);
            this.Controls.Add(this.dtPickerMuon);
            this.Controls.Add(this.cbbSoThe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.lbSoThe);
            this.Controls.Add(this.lbNgayTra);
            this.Controls.Add(this.lbNgayMuon);
            this.Name = "ThemMuonTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemMuonTra";
            this.Load += new System.EventHandler(this.ThemMuonTra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbSoThe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lbSoThe;
        private System.Windows.Forms.Label lbNgayTra;
        private System.Windows.Forms.Label lbNgayMuon;
        private System.Windows.Forms.DateTimePicker dtPickerMuon;
        private System.Windows.Forms.DateTimePicker dtPickerTra;
    }
}