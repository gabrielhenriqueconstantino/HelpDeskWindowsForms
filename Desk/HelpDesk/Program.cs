using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpDesk
{
    internal static class Program
    {

        public static List<Usuario> Usuarios { get; set; } = new List<Usuario>();
        public static List<Maquina> Maquinas { get; set; } = new List<Maquina>();
        public static List<Chamado> Chamados { get; set; } = new List<Chamado>();

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());
        }
    }
}
