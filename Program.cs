using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoABC
{
    class Principal
    {
        static void Main(string[]args)
        {   Form IniciarApp = BancoCuentas.Variables.Menu_Principal;
            Application.Run(IniciarApp);
        }
        
    }
}
