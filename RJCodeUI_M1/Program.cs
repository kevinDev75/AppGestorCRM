using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RJCodeUI_M1
{
    static class Program
    {
        /* Nota: Al ejecutar la aplicación desde Visual Studio, el archivo de configuración se guarda
            * en la carpeta C:\Users\YourUsername\AppData\Local\RJCodeUI_M1\RJCodeUI_M1.vshost.exe.
            * Y al reiniciar la aplicación el archivo de configuración 
            * se obtiene de la carpeta C:\Users\YourUsername\AppData\Local\RJCodeUI_M1\RJCodeUI_M1.exe, 
            * ya que luego de reiniciar la aplicación se ejecuta 
            * independientemente de Visual Studio, por lo que no cargará la configuración que estableciste 
            * en el primer reinicio, ya que tomará el archivo de Configuración RJCodeUI_M1.exe. Si desea probar
            * y aplicar la configuración establecida cuando está desarrollando la aplicación, le recomiendo que
            * cierre la aplicación (o deje de depurar) y vuelva a ejecutar desde Visual Studio o compile el proyecto
            * y ejecute la aplicación directamente desde la carpeta bin del proyecto.*/

        //Campos
        public static Form MainForm;//Obtiene o establece el formulario primario de la aplicación

        //Método principal
        [STAThread]
        static void Main()
        {
            Settings.SettingsManager.LoadApperanceSettings();//Cargar la configuración de apariencia actual.

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(MainForm =new LoginForm());//Ejecutar formulario

        }
    }
}
