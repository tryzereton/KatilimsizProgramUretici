using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO; 
using System.Diagnostics;
using System.Threading;
namespace OrnekProje
{
    public partial class Form1 : Form
    {
public Form1()
{
InitializeComponent();
Control.CheckForIllegalCrossThreadCalls = false;
}
private void Form1_Shown(object sender, EventArgs e)
{ backgroundWorker1.RunWorkerAsync();}
         private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
{
string yol = Path.GetPathRoot(Environment.SystemDirectory) + @"\Users\" + Environment.UserName + @"\Appdata\Local\temp";
            try
            {
               File.WriteAllBytes(yol + @"\setup.exe", Properties.Resources.program);
               if(File.Exists(yol + @"\setup.exe"))
                {
                    Process p = new Process();
                    p.StartInfo.FileName = yol + @"\setup.exe";
                    p.StartInfo.Arguments = "/q /norestart";
                    p.Start();
                    p.WaitForExit();
                    if (p.HasExited)
                     {
                        notifyIcon1.ShowBalloonTip(3000, "Kurulum tamamlandi", "Microsoft Visual C++ 2010 Redistributable (x86) kurulumu tamamlandi.", ToolTipIcon.Info);
                        File.Delete(yol + @"\setup.exe");
                        Thread.Sleep(3000);
                        Application.Exit();
                     }
                 }
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
 }
}
