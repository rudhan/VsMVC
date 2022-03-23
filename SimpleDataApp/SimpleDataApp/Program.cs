using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleDataApp
{
    static class Program
    {
        //başlaması için 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // navgation ana olduğu için lazımmış
            Application.Run(new Navigation());
        }
    }
}
