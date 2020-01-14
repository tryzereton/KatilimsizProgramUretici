namespace KatilimsizProgramUretici
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelUst = new System.Windows.Forms.Panel();
            this.btnCiktiDizini = new System.Windows.Forms.Button();
            this.lblCikti = new System.Windows.Forms.Label();
            this.txtCiktiDizini = new System.Windows.Forms.TextBox();
            this.chkProgramAc = new System.Windows.Forms.CheckBox();
            this.lblProgramAdi = new System.Windows.Forms.Label();
            this.txtProgramAdi = new System.Windows.Forms.TextBox();
            this.btnKatilimsiz = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.lblParametre = new System.Windows.Forms.Label();
            this.lblKatilimsiz = new System.Windows.Forms.Label();
            this.txtParametre = new System.Windows.Forms.TextBox();
            this.txtProgramYolu = new System.Windows.Forms.TextBox();
            this.panelOrta = new System.Windows.Forms.Panel();
            this.lstBilgiKonsolu = new System.Windows.Forms.ListBox();
            this.sagTik = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tümünüSeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçimiTemizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyayaAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBilgiKonsolu = new System.Windows.Forms.Label();
            this.panelAlt = new System.Windows.Forms.Panel();
            this.lblDurumBilgisi = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblIlerleme = new System.Windows.Forms.Label();
            this.pbIlerleme = new System.Windows.Forms.ProgressBar();
            this.ofdProgramSec = new System.Windows.Forms.OpenFileDialog();
            this.fdCiktiDizini = new System.Windows.Forms.FolderBrowserDialog();
            this.bgBaslat = new System.ComponentModel.BackgroundWorker();
            this.disaAktar = new System.Windows.Forms.SaveFileDialog();
            this.panelUst.SuspendLayout();
            this.panelOrta.SuspendLayout();
            this.sagTik.SuspendLayout();
            this.panelAlt.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUst
            // 
            this.panelUst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panelUst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUst.Controls.Add(this.btnCiktiDizini);
            this.panelUst.Controls.Add(this.lblCikti);
            this.panelUst.Controls.Add(this.txtCiktiDizini);
            this.panelUst.Controls.Add(this.chkProgramAc);
            this.panelUst.Controls.Add(this.lblProgramAdi);
            this.panelUst.Controls.Add(this.txtProgramAdi);
            this.panelUst.Controls.Add(this.btnKatilimsiz);
            this.panelUst.Controls.Add(this.btnTemizle);
            this.panelUst.Controls.Add(this.btnDurdur);
            this.panelUst.Controls.Add(this.btnBaslat);
            this.panelUst.Controls.Add(this.lblParametre);
            this.panelUst.Controls.Add(this.lblKatilimsiz);
            this.panelUst.Controls.Add(this.txtParametre);
            this.panelUst.Controls.Add(this.txtProgramYolu);
            this.panelUst.Location = new System.Drawing.Point(8, 30);
            this.panelUst.Name = "panelUst";
            this.panelUst.Size = new System.Drawing.Size(888, 236);
            this.panelUst.TabIndex = 0;
            // 
            // btnCiktiDizini
            // 
            this.btnCiktiDizini.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCiktiDizini.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnCiktiDizini.FlatAppearance.BorderSize = 2;
            this.btnCiktiDizini.ForeColor = System.Drawing.Color.Black;
            this.btnCiktiDizini.Location = new System.Drawing.Point(783, 48);
            this.btnCiktiDizini.Name = "btnCiktiDizini";
            this.btnCiktiDizini.Size = new System.Drawing.Size(61, 27);
            this.btnCiktiDizini.TabIndex = 17;
            this.btnCiktiDizini.Text = "Gözat";
            this.btnCiktiDizini.UseVisualStyleBackColor = false;
            this.btnCiktiDizini.Click += new System.EventHandler(this.btnCiktiDizini_Click);
            // 
            // lblCikti
            // 
            this.lblCikti.AutoSize = true;
            this.lblCikti.Location = new System.Drawing.Point(178, 51);
            this.lblCikti.Name = "lblCikti";
            this.lblCikti.Size = new System.Drawing.Size(70, 16);
            this.lblCikti.TabIndex = 16;
            this.lblCikti.Text = "Çıktı Dizini: ";
            // 
            // txtCiktiDizini
            // 
            this.txtCiktiDizini.Location = new System.Drawing.Point(259, 51);
            this.txtCiktiDizini.Name = "txtCiktiDizini";
            this.txtCiktiDizini.Size = new System.Drawing.Size(518, 20);
            this.txtCiktiDizini.TabIndex = 1;
            //this.txtCiktiDizini.TextChanged += new System.EventHandler(this.txtCiktiDizini_TextChanged);
            // 
            // chkProgramAc
            // 
            this.chkProgramAc.AutoSize = true;
            this.chkProgramAc.Location = new System.Drawing.Point(262, 155);
            this.chkProgramAc.Name = "chkProgramAc";
            this.chkProgramAc.Size = new System.Drawing.Size(309, 20);
            this.chkProgramAc.TabIndex = 7;
            this.chkProgramAc.Text = "Oluşturma tamamlandıktan sonra programı açmaya çalış.";
            this.chkProgramAc.UseVisualStyleBackColor = true;
            // 
            // lblProgramAdi
            // 
            this.lblProgramAdi.AutoSize = true;
            this.lblProgramAdi.Location = new System.Drawing.Point(178, 123);
            this.lblProgramAdi.Name = "lblProgramAdi";
            this.lblProgramAdi.Size = new System.Drawing.Size(75, 16);
            this.lblProgramAdi.TabIndex = 10;
            this.lblProgramAdi.Text = "Program Adı: ";
            // 
            // txtProgramAdi
            // 
            this.txtProgramAdi.Location = new System.Drawing.Point(259, 121);
            this.txtProgramAdi.Name = "txtProgramAdi";
            this.txtProgramAdi.Size = new System.Drawing.Size(518, 20);
            this.txtProgramAdi.TabIndex = 3;
            // 
            // btnKatilimsiz
            // 
            this.btnKatilimsiz.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnKatilimsiz.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnKatilimsiz.FlatAppearance.BorderSize = 2;
            this.btnKatilimsiz.ForeColor = System.Drawing.Color.Black;
            this.btnKatilimsiz.Location = new System.Drawing.Point(783, 13);
            this.btnKatilimsiz.Name = "btnKatilimsiz";
            this.btnKatilimsiz.Size = new System.Drawing.Size(61, 27);
            this.btnKatilimsiz.TabIndex = 7;
            this.btnKatilimsiz.Text = "Gözat";
            this.btnKatilimsiz.UseVisualStyleBackColor = false;
            this.btnKatilimsiz.Click += new System.EventHandler(this.btnProgramSec_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTemizle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnTemizle.ForeColor = System.Drawing.Color.Black;
            this.btnTemizle.Location = new System.Drawing.Point(699, 186);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 27);
            this.btnTemizle.TabIndex = 10;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnDurdur
            // 
            this.btnDurdur.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDurdur.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnDurdur.ForeColor = System.Drawing.Color.Black;
            this.btnDurdur.Location = new System.Drawing.Point(478, 186);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(75, 27);
            this.btnDurdur.TabIndex = 9;
            this.btnDurdur.Text = "Durdur";
            this.btnDurdur.UseVisualStyleBackColor = false;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // btnBaslat
            // 
            this.btnBaslat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBaslat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnBaslat.ForeColor = System.Drawing.Color.Black;
            this.btnBaslat.Location = new System.Drawing.Point(257, 186);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(75, 27);
            this.btnBaslat.TabIndex = 8;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = false;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // lblParametre
            // 
            this.lblParametre.AutoSize = true;
            this.lblParametre.Location = new System.Drawing.Point(43, 87);
            this.lblParametre.Name = "lblParametre";
            this.lblParametre.Size = new System.Drawing.Size(210, 16);
            this.lblParametre.TabIndex = 3;
            this.lblParametre.Text = "Programın SILENT INSTALL Parametresi: ";
            // 
            // lblKatilimsiz
            // 
            this.lblKatilimsiz.AutoSize = true;
            this.lblKatilimsiz.Location = new System.Drawing.Point(95, 19);
            this.lblKatilimsiz.Name = "lblKatilimsiz";
            this.lblKatilimsiz.Size = new System.Drawing.Size(158, 16);
            this.lblKatilimsiz.TabIndex = 2;
            this.lblKatilimsiz.Text = "Katılımsız Yapılacak Program: ";
            // 
            // txtParametre
            // 
            this.txtParametre.Location = new System.Drawing.Point(259, 86);
            this.txtParametre.Name = "txtParametre";
            this.txtParametre.Size = new System.Drawing.Size(518, 20);
            this.txtParametre.TabIndex = 2;
            // 
            // txtProgramYolu
            // 
            this.txtProgramYolu.Location = new System.Drawing.Point(259, 16);
            this.txtProgramYolu.Name = "txtProgramYolu";
            this.txtProgramYolu.Size = new System.Drawing.Size(518, 20);
            this.txtProgramYolu.TabIndex = 0;
            // 
            // panelOrta
            // 
            this.panelOrta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panelOrta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOrta.Controls.Add(this.lstBilgiKonsolu);
            this.panelOrta.Controls.Add(this.lblBilgiKonsolu);
            this.panelOrta.Location = new System.Drawing.Point(8, 266);
            this.panelOrta.Name = "panelOrta";
            this.panelOrta.Size = new System.Drawing.Size(888, 263);
            this.panelOrta.TabIndex = 0;
            // 
            // lstBilgiKonsolu
            // 
            this.lstBilgiKonsolu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lstBilgiKonsolu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstBilgiKonsolu.ContextMenuStrip = this.sagTik;
            this.lstBilgiKonsolu.ForeColor = System.Drawing.Color.Lime;
            this.lstBilgiKonsolu.FormattingEnabled = true;
            this.lstBilgiKonsolu.ItemHeight = 16;
            this.lstBilgiKonsolu.Location = new System.Drawing.Point(0, 34);
            this.lstBilgiKonsolu.Name = "lstBilgiKonsolu";
            this.lstBilgiKonsolu.Size = new System.Drawing.Size(883, 224);
            this.lstBilgiKonsolu.TabIndex = 1;
            // 
            // sagTik
            // 
            this.sagTik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tümünüSeçToolStripMenuItem,
            this.seçimiTemizleToolStripMenuItem,
            this.temizleToolStripMenuItem,
            this.dosyayaAktarToolStripMenuItem});
            this.sagTik.Name = "contextMenuStrip1";
            this.sagTik.Size = new System.Drawing.Size(154, 92);
            // 
            // tümünüSeçToolStripMenuItem
            // 
            this.tümünüSeçToolStripMenuItem.Name = "tümünüSeçToolStripMenuItem";
            this.tümünüSeçToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.tümünüSeçToolStripMenuItem.Text = "Tümünü Seç";
            this.tümünüSeçToolStripMenuItem.Click += new System.EventHandler(this.tümünüSeçToolStripMenuItem_Click);
            // 
            // seçimiTemizleToolStripMenuItem
            // 
            this.seçimiTemizleToolStripMenuItem.Name = "seçimiTemizleToolStripMenuItem";
            this.seçimiTemizleToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.seçimiTemizleToolStripMenuItem.Text = "Seçimi Temizle";
            this.seçimiTemizleToolStripMenuItem.Click += new System.EventHandler(this.seçimiTemizleToolStripMenuItem_Click);
            // 
            // temizleToolStripMenuItem
            // 
            this.temizleToolStripMenuItem.Name = "temizleToolStripMenuItem";
            this.temizleToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.temizleToolStripMenuItem.Text = "İçeriği Temizle";
            this.temizleToolStripMenuItem.Click += new System.EventHandler(this.temizleToolStripMenuItem_Click);
            // 
            // dosyayaAktarToolStripMenuItem
            // 
            this.dosyayaAktarToolStripMenuItem.Name = "dosyayaAktarToolStripMenuItem";
            this.dosyayaAktarToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.dosyayaAktarToolStripMenuItem.Text = "Dosyaya Aktar";
            this.dosyayaAktarToolStripMenuItem.Click += new System.EventHandler(this.dosyayaAktarToolStripMenuItem_Click);
            // 
            // lblBilgiKonsolu
            // 
            this.lblBilgiKonsolu.AutoSize = true;
            this.lblBilgiKonsolu.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.lblBilgiKonsolu.Location = new System.Drawing.Point(378, 8);
            this.lblBilgiKonsolu.Name = "lblBilgiKonsolu";
            this.lblBilgiKonsolu.Size = new System.Drawing.Size(107, 22);
            this.lblBilgiKonsolu.TabIndex = 0;
            this.lblBilgiKonsolu.Text = "Bilgi Konsolu";
            // 
            // panelAlt
            // 
            this.panelAlt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panelAlt.Controls.Add(this.lblDurumBilgisi);
            this.panelAlt.Controls.Add(this.lblDurum);
            this.panelAlt.Controls.Add(this.lblIlerleme);
            this.panelAlt.Controls.Add(this.pbIlerleme);
            this.panelAlt.Location = new System.Drawing.Point(8, 529);
            this.panelAlt.Name = "panelAlt";
            this.panelAlt.Size = new System.Drawing.Size(888, 57);
            this.panelAlt.TabIndex = 1;
            // 
            // lblDurumBilgisi
            // 
            this.lblDurumBilgisi.AutoSize = true;
            this.lblDurumBilgisi.Location = new System.Drawing.Point(70, 6);
            this.lblDurumBilgisi.Name = "lblDurumBilgisi";
            this.lblDurumBilgisi.Size = new System.Drawing.Size(27, 16);
            this.lblDurumBilgisi.TabIndex = 13;
            this.lblDurumBilgisi.Text = "N/A";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(12, 6);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(47, 16);
            this.lblDurum.TabIndex = 10;
            this.lblDurum.Text = "Durum: ";
            // 
            // lblIlerleme
            // 
            this.lblIlerleme.AutoSize = true;
            this.lblIlerleme.Location = new System.Drawing.Point(5, 30);
            this.lblIlerleme.Name = "lblIlerleme";
            this.lblIlerleme.Size = new System.Drawing.Size(54, 16);
            this.lblIlerleme.TabIndex = 12;
            this.lblIlerleme.Text = "İlerleme: ";
            // 
            // pbIlerleme
            // 
            this.pbIlerleme.Location = new System.Drawing.Point(68, 27);
            this.pbIlerleme.Maximum = 4;
            this.pbIlerleme.Name = "pbIlerleme";
            this.pbIlerleme.Size = new System.Drawing.Size(815, 21);
            this.pbIlerleme.Step = 1;
            this.pbIlerleme.TabIndex = 11;
            // 
            // ofdProgramSec
            // 
            this.ofdProgramSec.DefaultExt = "*.exe";
            this.ofdProgramSec.FileName = "Program Seç";
            this.ofdProgramSec.Filter = "Programlar |*.exe";
            // 
            // fdCiktiDizini
            // 
            this.fdCiktiDizini.Description = "Çıktı Klasörü";
            // 
            // bgBaslat
            // 
            this.bgBaslat.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgBaslat_DoWork);
            // 
            // disaAktar
            // 
            this.disaAktar.DefaultExt = "*.txt";
            this.disaAktar.Filter = "Metin Dosyasi|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(902, 593);
            this.Controls.Add(this.panelAlt);
            this.Controls.Add(this.panelOrta);
            this.Controls.Add(this.panelUst);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Katılımsız Program Üretici";
            this.panelUst.ResumeLayout(false);
            this.panelUst.PerformLayout();
            this.panelOrta.ResumeLayout(false);
            this.panelOrta.PerformLayout();
            this.sagTik.ResumeLayout(false);
            this.panelAlt.ResumeLayout(false);
            this.panelAlt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUst;
        private System.Windows.Forms.Panel panelOrta;
        private System.Windows.Forms.TextBox txtParametre;
        private System.Windows.Forms.TextBox txtProgramYolu;
        private System.Windows.Forms.Label lblParametre;
        private System.Windows.Forms.Label lblKatilimsiz;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.Label lblBilgiKonsolu;
        private System.Windows.Forms.ListBox lstBilgiKonsolu;
        private System.Windows.Forms.Panel panelAlt;
        private System.Windows.Forms.Label lblDurumBilgisi;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblIlerleme;
        private System.Windows.Forms.ProgressBar pbIlerleme;
        private System.Windows.Forms.Button btnKatilimsiz;
        private System.Windows.Forms.OpenFileDialog ofdProgramSec;
        private System.Windows.Forms.TextBox txtProgramAdi;
        private System.Windows.Forms.Label lblProgramAdi;
        private System.Windows.Forms.CheckBox chkProgramAc;
        private System.Windows.Forms.FolderBrowserDialog fdCiktiDizini;
        private System.Windows.Forms.Label lblCikti;
        private System.Windows.Forms.Button btnCiktiDizini;
        private System.ComponentModel.BackgroundWorker bgBaslat;
        private System.Windows.Forms.ContextMenuStrip sagTik;
        private System.Windows.Forms.ToolStripMenuItem tümünüSeçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyayaAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçimiTemizleToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog disaAktar;
        public System.Windows.Forms.TextBox txtCiktiDizini;



    }
}

