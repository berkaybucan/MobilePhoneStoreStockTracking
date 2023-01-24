
namespace Telefoncu
{
    partial class frmaksesuarsatis
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAksesuarlar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStok = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSatisFiyat = new System.Windows.Forms.Label();
            this.tbSatisFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CbPersonel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(668, 43);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(381, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aksesuar :";
            // 
            // cbAksesuarlar
            // 
            this.cbAksesuarlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAksesuarlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbAksesuarlar.FormattingEnabled = true;
            this.cbAksesuarlar.Location = new System.Drawing.Point(152, 34);
            this.cbAksesuarlar.Name = "cbAksesuarlar";
            this.cbAksesuarlar.Size = new System.Drawing.Size(479, 32);
            this.cbAksesuarlar.TabIndex = 2;
            this.cbAksesuarlar.SelectedIndexChanged += new System.EventHandler(this.cbAksesuarlar_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(690, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stok :";
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStok.Location = new System.Drawing.Point(763, 15);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(121, 25);
            this.lblStok.TabIndex = 4;
            this.lblStok.Text = "Seçilmemiş";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(664, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Aksesuarın Tavsiye Edilen Satış Fiyatı :";
            // 
            // lblSatisFiyat
            // 
            this.lblSatisFiyat.AutoSize = true;
            this.lblSatisFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatisFiyat.Location = new System.Drawing.Point(951, 82);
            this.lblSatisFiyat.Name = "lblSatisFiyat";
            this.lblSatisFiyat.Size = new System.Drawing.Size(89, 20);
            this.lblSatisFiyat.TabIndex = 6;
            this.lblSatisFiyat.Text = "Seçilmemiş";
            // 
            // tbSatisFiyat
            // 
            this.tbSatisFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSatisFiyat.Location = new System.Drawing.Point(152, 99);
            this.tbSatisFiyat.Name = "tbSatisFiyat";
            this.tbSatisFiyat.Size = new System.Drawing.Size(187, 29);
            this.tbSatisFiyat.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(16, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Satış Fiyatı :";
            // 
            // CbPersonel
            // 
            this.CbPersonel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CbPersonel.FormattingEnabled = true;
            this.CbPersonel.Location = new System.Drawing.Point(152, 160);
            this.CbPersonel.Name = "CbPersonel";
            this.CbPersonel.Size = new System.Drawing.Size(272, 32);
            this.CbPersonel.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(16, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Personel :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(649, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 64);
            this.button1.TabIndex = 11;
            this.button1.Text = "Satış Gerçekleştir";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmaksesuarsatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1073, 237);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CbPersonel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSatisFiyat);
            this.Controls.Add(this.lblSatisFiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblStok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAksesuarlar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Name = "frmaksesuarsatis";
            this.Text = "Aksesuar Satış ";
            this.Load += new System.EventHandler(this.frmaksesuarsatis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAksesuarlar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSatisFiyat;
        private System.Windows.Forms.TextBox tbSatisFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbPersonel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}