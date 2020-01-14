using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/** @Author 
 * 
 * Bu proje Ferhat Kurt tarafından geliştirilmiştir.
 * 
 * Bilgi için ferhatkurt.net, facebook.com/ferhatkrtt instagram.com/ferhatkrtt 
 * adreslerinden ulaşabilirsiniz.
 * 
 * 
 * */
namespace KatilimsizProgramUretici
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
