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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace KatilimsizProgramUretici
{
    class FormOlustur
    {

        public void formOlustur(string parametre,string programAdi)
        {
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Form1.cs");
            sw.WriteLine(
                
"using System;" + sw.NewLine +
"using System.Collections.Generic;" + sw.NewLine +
"using System.ComponentModel;" + sw.NewLine +
"using System.Data;" + sw.NewLine +
"using System.Drawing;" + sw.NewLine +
"using System.Linq;" + sw.NewLine +
"using System.Text;" + sw.NewLine +
"using System.Windows.Forms;" + sw.NewLine +
"using System.IO; " + sw.NewLine +
"using System.Diagnostics;" + sw.NewLine +
"using System.Threading;" + sw.NewLine +
"namespace OrnekProje" + sw.NewLine +
"{" + sw.NewLine +
"    public partial class Form1 : Form" + sw.NewLine +
"    {" + sw.NewLine +
"public Form1()" + sw.NewLine +
"{" + sw.NewLine +
"InitializeComponent();" + sw.NewLine +
"Control.CheckForIllegalCrossThreadCalls = false;" + sw.NewLine +
"}" + sw.NewLine +
"private void Form1_Shown(object sender, EventArgs e)" + sw.NewLine +

"{ backgroundWorker1.RunWorkerAsync();}" + sw.NewLine +

"         private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)" + sw.NewLine +
"{" + sw.NewLine +
"string yol = Path.GetPathRoot(Environment.SystemDirectory) + @\"\\Users\\\" + Environment.UserName + @\"\\Appdata\\Local\\temp\";" + sw.NewLine +
"            try" + sw.NewLine +
"            {" + sw.NewLine +

"               File.WriteAllBytes(yol + @\"\\setup.exe\", Properties.Resources.program);" + sw.NewLine +
"               if(File.Exists(yol + @\"\\setup.exe\"))"+sw.NewLine+
"                {" +sw.NewLine+

"                    Process p = new Process();" + sw.NewLine +
"                    p.StartInfo.FileName = yol + @\"\\setup.exe\";" + sw.NewLine +
"                    p.StartInfo.Arguments = \"" + parametre + "\";" + sw.NewLine +
"                    p.Start();" + sw.NewLine +
"                    p.WaitForExit();" + sw.NewLine +
"                    if (p.HasExited)" + sw.NewLine +
"                     {" + sw.NewLine +
"                        notifyIcon1.ShowBalloonTip(3000, \"Kurulum tamamlandi\", \"" + programAdi + " kurulumu tamamlandi.\", ToolTipIcon.Info);" + sw.NewLine +
"                        File.Delete(yol + @\"\\setup.exe\");" + sw.NewLine +
"                        Thread.Sleep(3000);" + sw.NewLine +
"                        Application.Exit();" + sw.NewLine +
"                     }" + sw.NewLine +
"                 }" + sw.NewLine +
"             }" + sw.NewLine +
"            catch (Exception ex)" + sw.NewLine +
"            {" + sw.NewLine +
"                MessageBox.Show(ex.Message);" + sw.NewLine +
"            }" + sw.NewLine +
"            }" + sw.NewLine +

" }" + sw.NewLine +
"}");
            sw.Close();


        }
    }
}
