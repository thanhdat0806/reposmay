
namespace DoAn_QL_Karaoke
{
    partial class Frm_ThongKeDoanhThu
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
            this.components = new System.ComponentModel.Container();
            this.dpk_ngaycuoi = new System.Windows.Forms.DateTimePicker();
            this.dpk_ngaydau = new System.Windows.Forms.DateTimePicker();
            this.btn_DT = new System.Windows.Forms.Button();
            this.dBQLKaraokeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_QLKaraokeDataSet = new DoAn_QL_Karaoke.DB_QLKaraokeDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBQLKaraokeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QLKaraokeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dpk_ngaycuoi
            // 
            this.dpk_ngaycuoi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpk_ngaycuoi.Location = new System.Drawing.Point(108, 32);
            this.dpk_ngaycuoi.Name = "dpk_ngaycuoi";
            this.dpk_ngaycuoi.Size = new System.Drawing.Size(174, 20);
            this.dpk_ngaycuoi.TabIndex = 12;
            // 
            // dpk_ngaydau
            // 
            this.dpk_ngaydau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpk_ngaydau.Location = new System.Drawing.Point(108, 6);
            this.dpk_ngaydau.Name = "dpk_ngaydau";
            this.dpk_ngaydau.Size = new System.Drawing.Size(174, 20);
            this.dpk_ngaydau.TabIndex = 13;
            this.dpk_ngaydau.Value = new System.DateTime(2022, 5, 1, 0, 0, 0, 0);
            // 
            // btn_DT
            // 
            this.btn_DT.Location = new System.Drawing.Point(31, 55);
            this.btn_DT.Name = "btn_DT";
            this.btn_DT.Size = new System.Drawing.Size(251, 23);
            this.btn_DT.TabIndex = 14;
            this.btn_DT.Text = "Xem Doanh Thu";
            this.btn_DT.UseVisualStyleBackColor = true;
            this.btn_DT.Click += new System.EventHandler(this.btn_DT_Click);
            // 
            // dBQLKaraokeDataSetBindingSource
            // 
            this.dBQLKaraokeDataSetBindingSource.DataSource = this.dB_QLKaraokeDataSet;
            this.dBQLKaraokeDataSetBindingSource.Position = 0;
            // 
            // dB_QLKaraokeDataSet
            // 
            this.dB_QLKaraokeDataSet.DataSetName = "DB_QLKaraokeDataSet";
            this.dB_QLKaraokeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView2.Location = new System.Drawing.Point(31, 84);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 15;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(251, 193);
            this.dataGridView2.TabIndex = 95;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 80F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Ngày ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 120F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tổng Tiền";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 96;
            this.label1.Text = "Từ Ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 96;
            this.label2.Text = "Đến Ngày";
            // 
            // Frm_ThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 289);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_DT);
            this.Controls.Add(this.dpk_ngaydau);
            this.Controls.Add(this.dpk_ngaycuoi);
            this.Name = "Frm_ThongKeDoanhThu";
            this.Text = "Frm_ThongKeDoanhThu";
            this.Load += new System.EventHandler(this.Frm_ThongKeDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBQLKaraokeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QLKaraokeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dpk_ngaycuoi;
        private System.Windows.Forms.DateTimePicker dpk_ngaydau;
        private System.Windows.Forms.Button btn_DT;
        private System.Windows.Forms.BindingSource dBQLKaraokeDataSetBindingSource;
        private DB_QLKaraokeDataSet dB_QLKaraokeDataSet;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}