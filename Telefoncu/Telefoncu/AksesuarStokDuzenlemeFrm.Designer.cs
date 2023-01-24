
namespace Telefoncu
{
    partial class AksesuarStokDuzenlemeFrm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSatis = new System.Windows.Forms.TextBox();
            this.tbAlis = new System.Windows.Forms.TextBox();
            this.tbStok = new System.Windows.Forms.TextBox();
            this.tbAd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aKSESUARADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aKSESUARALISFIYATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aKSESUARSATISFIYATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aKASESUARSTOKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLAKSESUARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbTelefoncuDataSet3 = new Telefoncu.DbTelefoncuDataSet3();
            this.tBLAKSESUARTableAdapter = new Telefoncu.DbTelefoncuDataSet3TableAdapters.TBLAKSESUARTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLAKSESUARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTelefoncuDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSatis);
            this.groupBox1.Controls.Add(this.tbAlis);
            this.groupBox1.Controls.Add(this.tbStok);
            this.groupBox1.Controls.Add(this.tbAd);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1294, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aksesuar Bilgisi Düzenleme";
            // 
            // tbSatis
            // 
            this.tbSatis.Location = new System.Drawing.Point(626, 93);
            this.tbSatis.Name = "tbSatis";
            this.tbSatis.Size = new System.Drawing.Size(138, 31);
            this.tbSatis.TabIndex = 8;
            // 
            // tbAlis
            // 
            this.tbAlis.Location = new System.Drawing.Point(626, 37);
            this.tbAlis.Name = "tbAlis";
            this.tbAlis.Size = new System.Drawing.Size(138, 31);
            this.tbAlis.TabIndex = 7;
            // 
            // tbStok
            // 
            this.tbStok.Location = new System.Drawing.Point(163, 96);
            this.tbStok.Name = "tbStok";
            this.tbStok.Size = new System.Drawing.Size(87, 31);
            this.tbStok.TabIndex = 6;
            // 
            // tbAd
            // 
            this.tbAd.Location = new System.Drawing.Point(151, 37);
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(346, 31);
            this.tbAd.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(954, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 89);
            this.button1.TabIndex = 4;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tavsiye Edilen Satış Fiyatı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alış Fiyatı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stok :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aksesuar Adı :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1294, 420);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aksesuar Bilgisi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aKSESUARADDataGridViewTextBoxColumn,
            this.aKSESUARALISFIYATDataGridViewTextBoxColumn,
            this.aKSESUARSATISFIYATDataGridViewTextBoxColumn,
            this.aKASESUARSTOKDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLAKSESUARBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1288, 392);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // aKSESUARADDataGridViewTextBoxColumn
            // 
            this.aKSESUARADDataGridViewTextBoxColumn.DataPropertyName = "AKSESUARAD";
            this.aKSESUARADDataGridViewTextBoxColumn.HeaderText = "AKSESUARAD";
            this.aKSESUARADDataGridViewTextBoxColumn.Name = "aKSESUARADDataGridViewTextBoxColumn";
            // 
            // aKSESUARALISFIYATDataGridViewTextBoxColumn
            // 
            this.aKSESUARALISFIYATDataGridViewTextBoxColumn.DataPropertyName = "AKSESUARALISFIYAT";
            this.aKSESUARALISFIYATDataGridViewTextBoxColumn.HeaderText = "AKSESUARALISFIYAT";
            this.aKSESUARALISFIYATDataGridViewTextBoxColumn.Name = "aKSESUARALISFIYATDataGridViewTextBoxColumn";
            // 
            // aKSESUARSATISFIYATDataGridViewTextBoxColumn
            // 
            this.aKSESUARSATISFIYATDataGridViewTextBoxColumn.DataPropertyName = "AKSESUARSATISFIYAT";
            this.aKSESUARSATISFIYATDataGridViewTextBoxColumn.HeaderText = "AKSESUARSATISFIYAT";
            this.aKSESUARSATISFIYATDataGridViewTextBoxColumn.Name = "aKSESUARSATISFIYATDataGridViewTextBoxColumn";
            // 
            // aKASESUARSTOKDataGridViewTextBoxColumn
            // 
            this.aKASESUARSTOKDataGridViewTextBoxColumn.DataPropertyName = "AKASESUARSTOK";
            this.aKASESUARSTOKDataGridViewTextBoxColumn.HeaderText = "AKASESUARSTOK";
            this.aKASESUARSTOKDataGridViewTextBoxColumn.Name = "aKASESUARSTOKDataGridViewTextBoxColumn";
            // 
            // tBLAKSESUARBindingSource
            // 
            this.tBLAKSESUARBindingSource.DataMember = "TBLAKSESUAR";
            this.tBLAKSESUARBindingSource.DataSource = this.dbTelefoncuDataSet3;
            // 
            // dbTelefoncuDataSet3
            // 
            this.dbTelefoncuDataSet3.DataSetName = "DbTelefoncuDataSet3";
            this.dbTelefoncuDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLAKSESUARTableAdapter
            // 
            this.tBLAKSESUARTableAdapter.ClearBeforeFill = true;
            // 
            // AksesuarStokDuzenlemeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1318, 614);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "AksesuarStokDuzenlemeFrm";
            this.Text = "AksesuarStokDuzenlemeFrm";
            this.Load += new System.EventHandler(this.AksesuarStokDuzenlemeFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLAKSESUARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTelefoncuDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DbTelefoncuDataSet3 dbTelefoncuDataSet3;
        private System.Windows.Forms.BindingSource tBLAKSESUARBindingSource;
        private DbTelefoncuDataSet3TableAdapters.TBLAKSESUARTableAdapter tBLAKSESUARTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aKSESUARADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aKSESUARALISFIYATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aKSESUARSATISFIYATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aKASESUARSTOKDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tbSatis;
        private System.Windows.Forms.TextBox tbAlis;
        private System.Windows.Forms.TextBox tbStok;
        private System.Windows.Forms.TextBox tbAd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}