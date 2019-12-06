using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAN
{
    public static class Program
    {
        public static frm_dn frm_dn;
        public static frm_main frm_main;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
     
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(frm_dn = new frm_dn());
            //Application.Run(new frm_NhapHang());
        }

        //public static object frm_main { get; set; }
    }
}
