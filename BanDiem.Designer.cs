
namespace CoCaro
{
    partial class BanDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BanDiem));
            this.diemCoCaroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banDiemCoCaroDataSet = new CoCaro.BanDiemCoCaroDataSet();
            this.diemCoCaroTableAdapter = new CoCaro.BanDiemCoCaroDataSetTableAdapters.DiemCoCaroTableAdapter();
            this.diemCoCaroBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.banDiemCoCaroDataSet1 = new CoCaro.BanDiemCoCaroDataSet1();
            this.diemCoCaroTableAdapter1 = new CoCaro.BanDiemCoCaroDataSet1TableAdapters.DiemCoCaroTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.banDiemCoCaroDataSet2 = new CoCaro.BanDiemCoCaroDataSet2();
            this.diemCoCaroBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.diemCoCaroTableAdapter2 = new CoCaro.BanDiemCoCaroDataSet2TableAdapters.DiemCoCaroTableAdapter();
            this.lanChoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoiChoi1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoiChoi2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.diemCoCaroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banDiemCoCaroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemCoCaroBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banDiemCoCaroDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banDiemCoCaroDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemCoCaroBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // diemCoCaroBindingSource
            // 
            this.diemCoCaroBindingSource.DataMember = "DiemCoCaro";
            this.diemCoCaroBindingSource.DataSource = this.banDiemCoCaroDataSet;
            // 
            // banDiemCoCaroDataSet
            // 
            this.banDiemCoCaroDataSet.DataSetName = "BanDiemCoCaroDataSet";
            this.banDiemCoCaroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diemCoCaroTableAdapter
            // 
            this.diemCoCaroTableAdapter.ClearBeforeFill = true;
            // 
            // diemCoCaroBindingSource1
            // 
            this.diemCoCaroBindingSource1.DataMember = "DiemCoCaro";
            this.diemCoCaroBindingSource1.DataSource = this.banDiemCoCaroDataSet1;
            // 
            // banDiemCoCaroDataSet1
            // 
            this.banDiemCoCaroDataSet1.DataSetName = "BanDiemCoCaroDataSet1";
            this.banDiemCoCaroDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diemCoCaroTableAdapter1
            // 
            this.diemCoCaroTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lanChoiDataGridViewTextBoxColumn,
            this.nguoiChoi1DataGridViewTextBoxColumn,
            this.nguoiChoi2DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.diemCoCaroBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(551, 367);
            this.dataGridView1.TabIndex = 0;
            // 
            // banDiemCoCaroDataSet2
            // 
            this.banDiemCoCaroDataSet2.DataSetName = "BanDiemCoCaroDataSet2";
            this.banDiemCoCaroDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diemCoCaroBindingSource2
            // 
            this.diemCoCaroBindingSource2.DataMember = "DiemCoCaro";
            this.diemCoCaroBindingSource2.DataSource = this.banDiemCoCaroDataSet2;
            // 
            // diemCoCaroTableAdapter2
            // 
            this.diemCoCaroTableAdapter2.ClearBeforeFill = true;
            // 
            // lanChoiDataGridViewTextBoxColumn
            // 
            this.lanChoiDataGridViewTextBoxColumn.DataPropertyName = "Lan_Choi";
            this.lanChoiDataGridViewTextBoxColumn.HeaderText = "Lan_Choi";
            this.lanChoiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lanChoiDataGridViewTextBoxColumn.Name = "lanChoiDataGridViewTextBoxColumn";
            this.lanChoiDataGridViewTextBoxColumn.ReadOnly = true;
            this.lanChoiDataGridViewTextBoxColumn.Width = 125;
            // 
            // nguoiChoi1DataGridViewTextBoxColumn
            // 
            this.nguoiChoi1DataGridViewTextBoxColumn.DataPropertyName = "Nguoi_Choi_1";
            this.nguoiChoi1DataGridViewTextBoxColumn.HeaderText = "Nguoi_Choi_1";
            this.nguoiChoi1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nguoiChoi1DataGridViewTextBoxColumn.Name = "nguoiChoi1DataGridViewTextBoxColumn";
            this.nguoiChoi1DataGridViewTextBoxColumn.ReadOnly = true;
            this.nguoiChoi1DataGridViewTextBoxColumn.Width = 125;
            // 
            // nguoiChoi2DataGridViewTextBoxColumn
            // 
            this.nguoiChoi2DataGridViewTextBoxColumn.DataPropertyName = "Nguoi_Choi_2";
            this.nguoiChoi2DataGridViewTextBoxColumn.HeaderText = "Nguoi_Choi_2";
            this.nguoiChoi2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nguoiChoi2DataGridViewTextBoxColumn.Name = "nguoiChoi2DataGridViewTextBoxColumn";
            this.nguoiChoi2DataGridViewTextBoxColumn.ReadOnly = true;
            this.nguoiChoi2DataGridViewTextBoxColumn.Width = 125;
            // 
            // BanDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 392);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BanDiem";
            this.Text = "BanDiem";
            this.Load += new System.EventHandler(this.BanDiem_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.diemCoCaroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banDiemCoCaroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemCoCaroBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banDiemCoCaroDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banDiemCoCaroDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemCoCaroBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BanDiemCoCaroDataSet banDiemCoCaroDataSet;
        private System.Windows.Forms.BindingSource diemCoCaroBindingSource;
        private BanDiemCoCaroDataSetTableAdapters.DiemCoCaroTableAdapter diemCoCaroTableAdapter;
        private BanDiemCoCaroDataSet1 banDiemCoCaroDataSet1;
        private System.Windows.Forms.BindingSource diemCoCaroBindingSource1;
        private BanDiemCoCaroDataSet1TableAdapters.DiemCoCaroTableAdapter diemCoCaroTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BanDiemCoCaroDataSet2 banDiemCoCaroDataSet2;
        private System.Windows.Forms.BindingSource diemCoCaroBindingSource2;
        private BanDiemCoCaroDataSet2TableAdapters.DiemCoCaroTableAdapter diemCoCaroTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn lanChoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoiChoi1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoiChoi2DataGridViewTextBoxColumn;
    }
}