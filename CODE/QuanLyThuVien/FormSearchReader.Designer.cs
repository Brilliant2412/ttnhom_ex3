﻿
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
            this.dgvSearchReader.Location = new System.Drawing.Point(72, 46);
            this.dgvSearchReader.Name = "dgvSearchReader";
            this.dgvSearchReader.Size = new System.Drawing.Size(522, 145);
            this.dgvSearchReader.TabIndex = 0;
            // 
            // FormSearchReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 260);
            this.Controls.Add(this.dgvSearchReader);
            this.Name = "FormSearchReader";
            this.Text = "FormSearchReader";
            this.Load += new System.EventHandler(this.FormSearchReader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchReader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSearchReader;
    }
}