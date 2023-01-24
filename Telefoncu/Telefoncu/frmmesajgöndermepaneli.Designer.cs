
namespace Telefoncu
{
    partial class frmmesajgöndermepaneli
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mERKEZDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLMERKEZLERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbTelefoncuDataSet12 = new Telefoncu.DbTelefoncuDataSet12();
            this.tBLMERKEZLERTableAdapter = new Telefoncu.DbTelefoncuDataSet12TableAdapters.TBLMERKEZLERTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMERKEZLERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTelefoncuDataSet12)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(1654, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(400, 929);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(525, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 630);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bayii-Toptancı Kodları";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mERKEZDataGridViewTextBoxColumn,
            this.kODDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLMERKEZLERBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(216, 605);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // mERKEZDataGridViewTextBoxColumn
            // 
            this.mERKEZDataGridViewTextBoxColumn.DataPropertyName = "MERKEZ";
            this.mERKEZDataGridViewTextBoxColumn.HeaderText = "MERKEZ";
            this.mERKEZDataGridViewTextBoxColumn.Name = "mERKEZDataGridViewTextBoxColumn";
            // 
            // kODDataGridViewTextBoxColumn
            // 
            this.kODDataGridViewTextBoxColumn.DataPropertyName = "KOD";
            this.kODDataGridViewTextBoxColumn.HeaderText = "KOD";
            this.kODDataGridViewTextBoxColumn.Name = "kODDataGridViewTextBoxColumn";
            // 
            // tBLMERKEZLERBindingSource
            // 
            this.tBLMERKEZLERBindingSource.DataMember = "TBLMERKEZLER";
            this.tBLMERKEZLERBindingSource.DataSource = this.dbTelefoncuDataSet12;
            // 
            // dbTelefoncuDataSet12
            // 
            this.dbTelefoncuDataSet12.DataSetName = "DbTelefoncuDataSet12";
            this.dbTelefoncuDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLMERKEZLERTableAdapter
            // 
            this.tBLMERKEZLERTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(34, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "ALICI : ";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBox1.Location = new System.Drawing.Point(151, 52);
            this.maskedTextBox1.Mask = "0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(69, 40);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(345, 31);
            this.textBox1.TabIndex = 4;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(143, 188);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(353, 339);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.richTextBox1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.maskedTextBox1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(507, 617);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mesaj Gönder";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(226, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "kodu otomatik doldurabilirsiniz.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(226, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Yan taraftan merkez adına tıklayarak .";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(16, 551);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(480, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "Mesajı Gönder";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(10, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "MESAJ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(6, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "BAŞLIK : ";
            // 
            // frmmesajgöndermepaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(750, 644);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmmesajgöndermepaneli";
            this.Text = "B&S Bayii-Toptancı Mesaj  Gönderme Paneli";
            this.Load += new System.EventHandler(this.frmmesajgöndermepaneli_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMERKEZLERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTelefoncuDataSet12)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DbTelefoncuDataSet12 dbTelefoncuDataSet12;
        private System.Windows.Forms.BindingSource tBLMERKEZLERBindingSource;
        private DbTelefoncuDataSet12TableAdapters.TBLMERKEZLERTableAdapter tBLMERKEZLERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mERKEZDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kODDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}