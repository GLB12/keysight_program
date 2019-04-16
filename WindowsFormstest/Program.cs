using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormstest
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Form1 form = new Form1();
            //form.ShowDialog();
            //if(form.DialogResult==DialogResult.None)
            //{
            //    form.Dispose();
            //    Application.Run(new Form2());
            //}
            //else if(form.DialogResult == DialogResult.OK)
            //{
            //    form.Dispose();
            //    Application.Run(new Form3());
            //}
            Application.Run(new Form1());
        }
    }
}
