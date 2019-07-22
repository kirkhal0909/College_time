using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Reversi
{    
    static class Program
    {
        /// <summary>        
        /// </summary>
        public static Form1 mainForm;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainForm = new Form1();
            Application.Run(mainForm);
        }
    }
}
