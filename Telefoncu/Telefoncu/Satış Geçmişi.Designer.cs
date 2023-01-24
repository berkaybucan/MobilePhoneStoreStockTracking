
namespace Telefoncu
{
    partial class Satış_Geçmişi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Satış_Geçmişi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mARKADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mODELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıMEIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bARKODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mUSTERIADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mUSTERITELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIYATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERSONELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tARIHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLTELSATISBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbTelefoncuDataSet11 = new Telefoncu.DbTelefoncuDataSet11();
            this.tBLTELEFONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbTelefoncuDataSet10 = new Telefoncu.DbTelefoncuDataSet10();
            this.tBLTELEFONTableAdapter = new Telefoncu.DbTelefoncuDataSet10TableAdapters.TBLTELEFONTableAdapter();
            this.tBLTELSATISTableAdapter = new Telefoncu.DbTelefoncuDataSet11TableAdapters.TBLTELSATISTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLTELSATISBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTelefoncuDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLTELEFONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTelefoncuDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mARKADataGridViewTextBoxColumn,
            this.mODELDataGridViewTextBoxColumn,
            this.ıMEIDataGridViewTextBoxColumn,
            this.bARKODDataGridViewTextBoxColumn,
            this.mUSTERIADDataGridViewTextBoxColumn,
            this.mUSTERITELDataGridViewTextBoxColumn,
            this.fIYATDataGridViewTextBoxColumn,
            this.pERSONELDataGridViewTextBoxColumn,
            this.tARIHDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLTELSATISBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1038, 510);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // mARKADataGridViewTextBoxColumn
            // 
            this.mARKADataGridViewTextBoxColumn.DataPropertyName = "MARKA";
            this.mARKADataGridViewTextBoxColumn.HeaderText = "MARKA";
            this.mARKADataGridViewTextBoxColumn.Name = "mARKADataGridViewTextBoxColumn";
            // 
            // mODELDataGridViewTextBoxColumn
            // 
            this.mODELDataGridViewTextBoxColumn.DataPropertyName = "MODEL";
            this.mODELDataGridViewTextBoxColumn.HeaderText = "MODEL";
            this.mODELDataGridViewTextBoxColumn.Name = "mODELDataGridViewTextBoxColumn";
            // 
            // ıMEIDataGridViewTextBoxColumn
            // 
            this.ıMEIDataGridViewTextBoxColumn.DataPropertyName = "IMEI";
            this.ıMEIDataGridViewTextBoxColumn.HeaderText = "IMEI";
            this.ıMEIDataGridViewTextBoxColumn.Name = "ıMEIDataGridViewTextBoxColumn";
            // 
            // bARKODDataGridViewTextBoxColumn
            // 
            this.bARKODDataGridViewTextBoxColumn.DataPropertyName = "BARKOD";
            this.bARKODDataGridViewTextBoxColumn.HeaderText = "BARKOD";
            this.bARKODDataGridViewTextBoxColumn.Name = "bARKODDataGridViewTextBoxColumn";
            // 
            // mUSTERIADDataGridViewTextBoxColumn
            // 
            this.mUSTERIADDataGridViewTextBoxColumn.DataPropertyName = "MUSTERIAD";
            this.mUSTERIADDataGridViewTextBoxColumn.HeaderText = "MUSTERIAD";
            this.mUSTERIADDataGridViewTextBoxColumn.Name = "mUSTERIADDataGridViewTextBoxColumn";
            // 
            // mUSTERITELDataGridViewTextBoxColumn
            // 
            this.mUSTERITELDataGridViewTextBoxColumn.DataPropertyName = "MUSTERITEL";
            this.mUSTERITELDataGridViewTextBoxColumn.HeaderText = "MUSTERITEL";
            this.mUSTERITELDataGridViewTextBoxColumn.Name = "mUSTERITELDataGridViewTextBoxColumn";
            // 
            // fIYATDataGridViewTextBoxColumn
            // 
            this.fIYATDataGridViewTextBoxColumn.DataPropertyName = "FIYAT";
            this.fIYATDataGridViewTextBoxColumn.HeaderText = "FIYAT";
            this.fIYATDataGridViewTextBoxColumn.Name = "fIYATDataGridViewTextBoxColumn";
            // 
            // pERSONELDataGridViewTextBoxColumn
            // 
            this.pERSONELDataGridViewTextBoxColumn.DataPropertyName = "PERSONEL";
            this.pERSONELDataGridViewTextBoxColumn.HeaderText = "PERSONEL";
            this.pERSONELDataGridViewTextBoxColumn.Name = "pERSONELDataGridViewTextBoxColumn";
            // 
            // tARIHDataGridViewTextBoxColumn
            // 
            this.tARIHDataGridViewTextBoxColumn.DataPropertyName = "TARIH";
            this.tARIHDataGridViewTextBoxColumn.HeaderText = "TARIH";
            this.tARIHDataGridViewTextBoxColumn.Name = "tARIHDataGridViewTextBoxColumn";
            // 
            // tBLTELSATISBindingSource
            // 
            this.tBLTELSATISBindingSource.DataMember = "TBLTELSATIS";
            this.tBLTELSATISBindingSource.DataSource = this.dbTelefoncuDataSet11;
            // 
            // dbTelefoncuDataSet11
            // 
            this.dbTelefoncuDataSet11.DataSetName = "DbTelefoncuDataSet11";
            this.dbTelefoncuDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLTELEFONBindingSource
            // 
            this.tBLTELEFONBindingSource.DataMember = "TBLTELEFON";
            this.tBLTELEFONBindingSource.DataSource = this.dbTelefoncuDataSet10;
            // 
            // dbTelefoncuDataSet10
            // 
            this.dbTelefoncuDataSet10.DataSetName = "DbTelefoncuDataSet10";
            this.dbTelefoncuDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLTELEFONTableAdapter
            // 
            this.tBLTELEFONTableAdapter.ClearBeforeFill = true;
            // 
            // tBLTELSATISTableAdapter
            // 
            this.tBLTELSATISTableAdapter.ClearBeforeFill = true;
            // 
            // Satış_Geçmişi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 510);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Satış_Geçmişi";
            this.Text = "Satış Geçmişi";
            this.Load += new System.EventHandler(this.Satış_Geçmişi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLTELSATISBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTelefoncuDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLTELEFONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTelefoncuDataSet10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DbTelefoncuDataSet10 dbTelefoncuDataSet10;
        private System.Windows.Forms.BindingSource tBLTELEFONBindingSource;
        private DbTelefoncuDataSet10TableAdapters.TBLTELEFONTableAdapter tBLTELEFONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mARKADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mODELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıMEIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bARKODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mUSTERIADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mUSTERITELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIYATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERSONELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tARIHDataGridViewTextBoxColumn;
        private DbTelefoncuDataSet11 dbTelefoncuDataSet11;
        private System.Windows.Forms.BindingSource tBLTELSATISBindingSource;
        private DbTelefoncuDataSet11TableAdapters.TBLTELSATISTableAdapter tBLTELSATISTableAdapter;
    }
}