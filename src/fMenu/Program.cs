using proyecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fMenu
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        public static ColeccionDePersonas colPers;
        public static ColeccionDeCursos colCursos;
        public static ColeccionInstitutos colIns;
        [STAThread]
        static void Main()
        {   


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            colPers = new ColeccionDePersonas(); 
            colCursos = new ColeccionDeCursos();
            colIns = new ColeccionInstitutos();


            Application.Run(new fMenu());


        }
    }
}
