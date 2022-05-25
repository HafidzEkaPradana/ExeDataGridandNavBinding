
namespace ExeDataGridandNavBinding
{
    partial class DataGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataGrid));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prodiTIDataSet = new ExeDataGridandNavBinding.ProdiTIDataSet();
            this.prodiTIDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswaTableAdapter = new ExeDataGridandNavBinding.ProdiTIDataSetTableAdapters.MahasiswaTableAdapter();
            this.mataKuliahBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mataKuliahTableAdapter = new ExeDataGridandNavBinding.ProdiTIDataSetTableAdapters.MataKuliahTableAdapter();
            this.nilaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nilaiTableAdapter = new ExeDataGridandNavBinding.ProdiTIDataSetTableAdapters.NilaiTableAdapter();
            this.periodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.periodeTableAdapter = new ExeDataGridandNavBinding.ProdiTIDataSetTableAdapters.PeriodeTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nimDataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaMhsDataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatMhsDataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneMhsDataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mataKuliahBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nilaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nimDataGrid,
            this.namaMhsDataGrid,
            this.alamatMhsDataGrid,
            this.sexDataGrid,
            this.phoneMhsDataGrid});
            this.dataGridView1.DataSource = this.mahasiswaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(817, 253);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // prodiTIDataSet
            // 
            this.prodiTIDataSet.DataSetName = "ProdiTIDataSet";
            this.prodiTIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prodiTIDataSetBindingSource
            // 
            this.prodiTIDataSetBindingSource.DataSource = this.prodiTIDataSet;
            this.prodiTIDataSetBindingSource.Position = 0;
            // 
            // mahasiswaBindingSource
            // 
            this.mahasiswaBindingSource.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource.DataSource = this.prodiTIDataSetBindingSource;
            // 
            // mahasiswaTableAdapter
            // 
            this.mahasiswaTableAdapter.ClearBeforeFill = true;
            // 
            // mataKuliahBindingSource
            // 
            this.mataKuliahBindingSource.DataMember = "MataKuliah";
            this.mataKuliahBindingSource.DataSource = this.prodiTIDataSetBindingSource;
            // 
            // mataKuliahTableAdapter
            // 
            this.mataKuliahTableAdapter.ClearBeforeFill = true;
            // 
            // nilaiBindingSource
            // 
            this.nilaiBindingSource.DataMember = "Nilai";
            this.nilaiBindingSource.DataSource = this.prodiTIDataSetBindingSource;
            // 
            // nilaiTableAdapter
            // 
            this.nilaiTableAdapter.ClearBeforeFill = true;
            // 
            // periodeBindingSource
            // 
            this.periodeBindingSource.DataMember = "Periode";
            this.periodeBindingSource.DataSource = this.prodiTIDataSetBindingSource;
            // 
            // periodeTableAdapter
            // 
            this.periodeTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(817, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // nimDataGrid
            // 
            this.nimDataGrid.DataPropertyName = "NIM";
            this.nimDataGrid.HeaderText = "NIM";
            this.nimDataGrid.MinimumWidth = 8;
            this.nimDataGrid.Name = "nimDataGrid";
            this.nimDataGrid.ReadOnly = true;
            this.nimDataGrid.Width = 85;
            // 
            // namaMhsDataGrid
            // 
            this.namaMhsDataGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.namaMhsDataGrid.DataPropertyName = "NamaMhs";
            this.namaMhsDataGrid.HeaderText = "NamaMhs";
            this.namaMhsDataGrid.MinimumWidth = 8;
            this.namaMhsDataGrid.Name = "namaMhsDataGrid";
            this.namaMhsDataGrid.ReadOnly = true;
            this.namaMhsDataGrid.Width = 117;
            // 
            // alamatMhsDataGrid
            // 
            this.alamatMhsDataGrid.DataPropertyName = "AlamatMhs";
            this.alamatMhsDataGrid.HeaderText = "AlamatMhs";
            this.alamatMhsDataGrid.MinimumWidth = 8;
            this.alamatMhsDataGrid.Name = "alamatMhsDataGrid";
            this.alamatMhsDataGrid.ReadOnly = true;
            this.alamatMhsDataGrid.Width = 145;
            // 
            // sexDataGrid
            // 
            this.sexDataGrid.DataPropertyName = "Sex";
            this.sexDataGrid.HeaderText = "Sex";
            this.sexDataGrid.MinimumWidth = 8;
            this.sexDataGrid.Name = "sexDataGrid";
            this.sexDataGrid.ReadOnly = true;
            this.sexDataGrid.Width = 50;
            // 
            // phoneMhsDataGrid
            // 
            this.phoneMhsDataGrid.DataPropertyName = "PhoneMhs";
            this.phoneMhsDataGrid.HeaderText = "PhoneMhs";
            this.phoneMhsDataGrid.MinimumWidth = 8;
            this.phoneMhsDataGrid.Name = "phoneMhsDataGrid";
            this.phoneMhsDataGrid.ReadOnly = true;
            this.phoneMhsDataGrid.Width = 85;
            // 
            // DataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 552);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataGrid";
            this.Text = "DataGridView";
            this.Load += new System.EventHandler(this.DataGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mataKuliahBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nilaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource prodiTIDataSetBindingSource;
        private ProdiTIDataSet prodiTIDataSet;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource;
        private ProdiTIDataSetTableAdapters.MahasiswaTableAdapter mahasiswaTableAdapter;
        private System.Windows.Forms.BindingSource mataKuliahBindingSource;
        private ProdiTIDataSetTableAdapters.MataKuliahTableAdapter mataKuliahTableAdapter;
        private System.Windows.Forms.BindingSource nilaiBindingSource;
        private ProdiTIDataSetTableAdapters.NilaiTableAdapter nilaiTableAdapter;
        private System.Windows.Forms.BindingSource periodeBindingSource;
        private ProdiTIDataSetTableAdapters.PeriodeTableAdapter periodeTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaMhsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatMhsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneMhsDataGrid;
    }
}