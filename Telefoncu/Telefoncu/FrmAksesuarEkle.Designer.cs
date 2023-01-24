
namespace Telefoncu
{
    partial class FrmAksesuarEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAksesuarEkle));
            this.tbAd = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbAlisFiyat = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbSatisFiyat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbStok = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbAd
            // 
            this.tbAd.Location = new System.Drawing.Point(192, 37);
            this.tbAd.Multiline = true;
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(318, 35);
            this.tbAd.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbAlisFiyat
            // 
            this.tbAlisFiyat.Location = new System.Drawing.Point(303, 78);
            this.tbAlisFiyat.Multiline = true;
            this.tbAlisFiyat.Name = "tbAlisFiyat";
            this.tbAlisFiyat.Size = new System.Drawing.Size(207, 38);
            this.tbAlisFiyat.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(536, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 137);
            this.button1.TabIndex = 3;
            this.button1.Text = "Aksesuar Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbSatisFiyat
            // 
            this.tbSatisFiyat.Location = new System.Drawing.Point(303, 122);
            this.tbSatisFiyat.Multiline = true;
            this.tbSatisFiyat.Name = "tbSatisFiyat";
            this.tbSatisFiyat.Size = new System.Drawing.Size(207, 38);
            this.tbSatisFiyat.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(55, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Aksesuar Adı :";
            // 
            // tbStok
            // 
            this.tbStok.Location = new System.Drawing.Point(303, 166);
            this.tbStok.Multiline = true;
            this.tbStok.Name = "tbStok";
            this.tbStok.Size = new System.Drawing.Size(207, 38);
            this.tbStok.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(155, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Adet Alış Fiyatı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(146, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Adet Satış Fiyatı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(226, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "STOK :";
            // 
            // FrmAksesuarEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 223);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbStok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSatisFiyat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbAlisFiyat);
            this.Controls.Add(this.tbAd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAksesuarEkle";
            this.Text = "Aksesuar Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbAlisFiyat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbSatisFiyat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbStok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}