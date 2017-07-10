using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPcheck
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
            SuperSPForm SuperSPToolkitForm = new SuperSPForm();
            SuperSPToolkitForm.StartPosition = FormStartPosition.CenterScreen;
            SuperSPToolkitForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            //IController controller = new IController(Form1);
            Application.Run(SuperSPToolkitForm);
        }
    }
}
