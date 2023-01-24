
namespace Telefoncu
{
    partial class TelefonSatısFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelefonSatısFrm));
            this.CbMarka = new System.Windows.Forms.ComboBox();
            this.CbModel = new System.Windows.Forms.ComboBox();
            this.CbPersonel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txIMEI = new System.Windows.Forms.TextBox();
            this.txBarkod = new System.Windows.Forms.TextBox();
            this.txFiyat = new System.Windows.Forms.TextBox();
            this.txMusteriAd = new System.Windows.Forms.TextBox();
            this.txMusteriTel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LblStok = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.LblTSatisFiyat = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbltelsatısTableAdapter1 = new Telefoncu.DbTelefoncuDataSet11TableAdapters.TBLTELSATISTableAdapter();
            this.SuspendLayout();
            // 
            // CbMarka
            // 
            this.CbMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbMarka.FormattingEnabled = true;
            this.CbMarka.Location = new System.Drawing.Point(168, 10);
            this.CbMarka.Margin = new System.Windows.Forms.Padding(6);
            this.CbMarka.Name = "CbMarka";
            this.CbMarka.Size = new System.Drawing.Size(201, 32);
            this.CbMarka.TabIndex = 0;
            // 
            // CbModel
            // 
            this.CbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbModel.FormattingEnabled = true;
            this.CbModel.Location = new System.Drawing.Point(168, 60);
            this.CbModel.Margin = new System.Windows.Forms.Padding(6);
            this.CbModel.Name = "CbModel";
            this.CbModel.Size = new System.Drawing.Size(417, 32);
            this.CbModel.TabIndex = 1;
            this.CbModel.SelectedIndexChanged += new System.EventHandler(this.CbModel_SelectedIndexChanged);
            // 
            // CbPersonel
            // 
            this.CbPersonel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbPersonel.FormattingEnabled = true;
            this.CbPersonel.Location = new System.Drawing.Point(289, 313);
            this.CbPersonel.Margin = new System.Windows.Forms.Padding(6);
            this.CbPersonel.Name = "CbPersonel";
            this.CbPersonel.Size = new System.Drawing.Size(219, 32);
            this.CbPersonel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Marka :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Model :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "IMEI :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Barkod :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Müşterinin Adı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Müşterinin Telefon Numarası :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "Fiyat  :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(274, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "Satışı Gerçekleştiren Personel  :";
            // 
            // txIMEI
            // 
            this.txIMEI.Location = new System.Drawing.Point(165, 99);
            this.txIMEI.Name = "txIMEI";
            this.txIMEI.Size = new System.Drawing.Size(419, 29);
            this.txIMEI.TabIndex = 11;
            // 
            // txBarkod
            // 
            this.txBarkod.Location = new System.Drawing.Point(165, 134);
            this.txBarkod.Name = "txBarkod";
            this.txBarkod.Size = new System.Drawing.Size(419, 29);
            this.txBarkod.TabIndex = 12;
            // 
            // txFiyat
            // 
            this.txFiyat.Location = new System.Drawing.Point(165, 169);
            this.txFiyat.Name = "txFiyat";
            this.txFiyat.Size = new System.Drawing.Size(161, 29);
            this.txFiyat.TabIndex = 13;
            // 
            // txMusteriAd
            // 
            this.txMusteriAd.Location = new System.Drawing.Point(286, 213);
            this.txMusteriAd.Name = "txMusteriAd";
            this.txMusteriAd.Size = new System.Drawing.Size(298, 29);
            this.txMusteriAd.TabIndex = 14;
            // 
            // txMusteriTel
            // 
            this.txMusteriTel.Location = new System.Drawing.Point(289, 262);
            this.txMusteriTel.Name = "txMusteriTel";
            this.txMusteriTel.Size = new System.Drawing.Size(161, 29);
            this.txMusteriTel.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(616, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Seçtiğiniz Model";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(616, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Telefonun Stoğu :";
            // 
            // LblStok
            // 
            this.LblStok.AutoSize = true;
            this.LblStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblStok.Location = new System.Drawing.Point(625, 42);
            this.LblStok.Name = "LblStok";
            this.LblStok.Size = new System.Drawing.Size(85, 18);
            this.LblStok.TabIndex = 20;
            this.LblStok.Text = "Seçilmemiş";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(599, 64);
            this.progressBar1.Maximum = 30;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(142, 23);
            this.progressBar1.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(332, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(283, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Seçtiğiniz Modelin Tavsiye Edilen Satış Fiyatı :";
            // 
            // LblTSatisFiyat
            // 
            this.LblTSatisFiyat.AutoSize = true;
            this.LblTSatisFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTSatisFiyat.Location = new System.Drawing.Point(616, 178);
            this.LblTSatisFiyat.Name = "LblTSatisFiyat";
            this.LblTSatisFiyat.Size = new System.Drawing.Size(85, 18);
            this.LblTSatisFiyat.TabIndex = 23;
            this.LblTSatisFiyat.Text = "Seçilmemiş";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(211, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(324, 73);
            this.button1.TabIndex = 24;
            this.button1.Text = "Satış Gerçekleştir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbltelsatısTableAdapter1
            // 
            this.tbltelsatısTableAdapter1.ClearBeforeFill = true;
            // 
            // TelefonSatısFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(747, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblTSatisFiyat);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.LblStok);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txMusteriTel);
            this.Controls.Add(this.txMusteriAd);
            this.Controls.Add(this.txFiyat);
            this.Controls.Add(this.txBarkod);
            this.Controls.Add(this.txIMEI);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbPersonel);
            this.Controls.Add(this.CbModel);
            this.Controls.Add(this.CbMarka);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TelefonSatısFrm";
            this.Text = "Telefon Satış";
            this.Load += new System.EventHandler(this.TelefonSatısFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbMarka;
        private System.Windows.Forms.ComboBox CbModel;
        private System.Windows.Forms.ComboBox CbPersonel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txIMEI;
        private System.Windows.Forms.TextBox txBarkod;
        private System.Windows.Forms.TextBox txFiyat;
        private System.Windows.Forms.TextBox txMusteriAd;
        private System.Windows.Forms.TextBox txMusteriTel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LblStok;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblTSatisFiyat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private DbTelefoncuDataSet11TableAdapters.TBLTELSATISTableAdapter tbltelsatısTableAdapter1;
    }
}