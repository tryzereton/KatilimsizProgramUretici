/** @Author 
 * 
 * Bu proje Ferhat Kurt tarafından geliştirilmiştir.
 * 
 * Bilgi için ferhatkurt.net, facebook.com/ferhatkrtt instagram.com/ferhatkrtt 
 * adreslerinden ulaşabilirsiniz.
 * 
 * 
 * */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using jSkin;
using System.Diagnostics;
using System.IO;

namespace KatilimsizProgramUretici
{
    public partial class Form1 : Form
    {
        jSkin.ctlModernBlack yeniForm = new jSkin.ctlModernBlack();
        Process p = new Process();
        string veri = "";
        public string ciktiDizini;

        public Form1()
        {
            InitializeComponent();
            this.Controls.Add(yeniForm);
            Control.CheckForIllegalCrossThreadCalls = false;
            p.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
        }

        private void btnProgramSec_Click(object sender, EventArgs e)
        {
            //OpenFileDialog ile program seçimi metin kutusuna aktarılıyor
            if(ofdProgramSec.ShowDialog() == DialogResult.OK)
            {
                txtProgramYolu.Text = ofdProgramSec.FileName;
            }
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
        private void temizle()
        {
            ofdProgramSec.FileName = "";
            txtProgramYolu.Text = "";
            txtParametre.Text = "";
            txtProgramAdi.Text = "";
            txtCiktiDizini.Text = "";
            lstBilgiKonsolu.Items.Clear();
            lblDurumBilgisi.Text = "N/A";
            pbIlerleme.Value = 0;
            chkProgramAc.Checked = false;
        }
        private void btnDurdur_Click(object sender, EventArgs e)
        {
            //Durdurma işlemi için MSBuild ve CMD süreçleri taranıyor..
            try
            {
                foreach (Process p in Process.GetProcesses())
                {
                    if (p.ProcessName.Equals("MSBuild") || p.ProcessName.Equals("cmd") ||
                        p.ProcessName.Equals("MSBuildTaskHost.exe"))
                    {
                        p.Kill();
                    }

                }
            }catch(Exception ex)
            {
                MessageBox.Show("İşlem durdurulamıyor.Program yeniden başlatılacak...\nHata: " + ex.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Application.Restart();
            }
            
        }
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            bgBaslat.RunWorkerAsync();
        }
        private void DosyayiKopyala()
        {
            try
            {
                File.Copy(ofdProgramSec.FileName, Application.StartupPath + "\\Resources\\Program.exe", true);

            }
            catch (IOException)
            {

            }
        }
        private void ProcessBaslat(string dosyaAdi)
        {

            ProcessStartInfo pi = new ProcessStartInfo(dosyaAdi);
            pi.RedirectStandardOutput = true;
            pi.CreateNoWindow = true;
            pi.WindowStyle = ProcessWindowStyle.Hidden;
            pi.UseShellExecute = false;
            pi.StandardOutputEncoding = Encoding.UTF8;
            p.StartInfo = pi;
            p.Start();
            p.BeginOutputReadLine();

            p.WaitForExit();
            p.CancelOutputRead();


        }
        private void OutputHandler(object sender, DataReceivedEventArgs e)
        {
            try
            {
                lstBilgiKonsolu.Items.Add(e.Data.ToString());
                lstBilgiKonsolu.SelectedIndex = lstBilgiKonsolu.Items.Count - 1;
            }
            catch (Exception)
            {

            }

        }
        private void btnCiktiDizini_Click(object sender, EventArgs e)
        {
            if(fdCiktiDizini.ShowDialog() == DialogResult.OK)
            {
                txtCiktiDizini.Text = fdCiktiDizini.SelectedPath;
            }
        }
        private void bgBaslat_DoWork(object sender, DoWorkEventArgs e)
        {
            veri = txtProgramAdi.Text;
            Properties.Settings.Default.cikti = txtCiktiDizini.Text;
            pbIlerleme.Value = 0;
            if (!string.IsNullOrWhiteSpace(txtProgramYolu.Text) && !string.IsNullOrWhiteSpace(txtParametre.Text) &&
                !string.IsNullOrWhiteSpace(txtProgramAdi.Text) && !string.IsNullOrWhiteSpace(txtCiktiDizini.Text))
            {
                lblDurumBilgisi.Text = "Dosya alınıyor...";
                DosyayiKopyala();
                pbIlerleme.Value++;

                //csprojDegistir(textBox3.Text);
                CsprojOlustur yeni = new CsprojOlustur();
                yeni.csprojOlustur(txtProgramAdi.Text, txtParametre.Text);
                lblDurumBilgisi.Text = "Proje Dosyası ayarlanıyor...";
                pbIlerleme.Value++;

               // Form1Degistir(txtProgramAdi.Text, txtParametre.Text);
                FormOlustur yeniForm = new FormOlustur();
                yeniForm.formOlustur(txtParametre.Text, txtProgramAdi.Text);
                lblDurumBilgisi.Text = "CS dosyası ayarlanıyor...";
                pbIlerleme.Value++;

                lblDurumBilgisi.Text = "Compiler için komut dosyası oluşturuluyor...";
                StreamWriter sw = new StreamWriter("msbuildBaslat.cmd");
                sw.WriteLine("msbuild /t:Clean OrnekProje.csproj" + sw.NewLine);
                sw.Write("msbuild OrnekProje.csproj");
                sw.Close();

                //KOMUT DOSYASI OLUŞTURULMUŞSSA ÇALIŞTIR
                if (File.Exists("msbuildBaslat.cmd"))
                {
                    lblDurumBilgisi.Text = "Komut dosyası başlatılıyor...";
                    ProcessBaslat("msbuildBaslat.cmd");
                }
                pbIlerleme.Value++;
                lblDurumBilgisi.Text = "Komut yürütme başarılı oldu. Lütfen Bilgi Konsolunu kontrol edin.";
            }
            else
            {
                MessageBox.Show("Bütün alanları doldurun ve tekrar deneyin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //CHECKBOX SEÇİLİ İSE PROGRAMI BAŞLAT
            if (chkProgramAc.Checked)
            {
                if (File.Exists(fdCiktiDizini.SelectedPath + "\\" + veri + "_katilimsiz.exe"))
                {
                    Process.Start(fdCiktiDizini.SelectedPath + "\\" + veri + "_katilimsiz.exe");
                }
            }

            //KALINTILAR TEMİZLENİYOR....
            try
            {
                File.Delete(fdCiktiDizini.SelectedPath + "\\" + veri + "_katilimsiz.exe.config");
                File.Delete(fdCiktiDizini.SelectedPath + "\\" + veri + "_katilimsiz.pdb");
                File.Delete(fdCiktiDizini.SelectedPath + "\\" + veri + "_katilimsiz.vshost.exe");
                File.Delete(fdCiktiDizini.SelectedPath + "\\" + veri + "_katilimsiz.vshost.exe.config");
                File.Delete(fdCiktiDizini.SelectedPath + "\\" + veri + "_katilimsiz.vshost.exe.manifest");

            }
            catch (Exception)
            {

            }
        }
        private void dosyayaAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(disaAktar.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(disaAktar.FileName);
                for(int i=0; i<lstBilgiKonsolu.Items.Count; i++)
                {
                    sw.WriteLine(lstBilgiKonsolu.Items[i].ToString());
                }
                sw.Close();
            }
        }
        private void tümünüSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstBilgiKonsolu.SelectionMode = SelectionMode.MultiSimple;
            for(int i=0; i<lstBilgiKonsolu.Items.Count; i++)
            {
                lstBilgiKonsolu.SetSelected(i, true);
            }
            
        }
        private void seçimiTemizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstBilgiKonsolu.SelectionMode = SelectionMode.One;
            lstBilgiKonsolu.SelectedIndex = lstBilgiKonsolu.Items.Count - 1;
        }
        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstBilgiKonsolu.Items.Clear();
        }
      
   }
}
