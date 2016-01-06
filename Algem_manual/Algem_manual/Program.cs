using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algem_manual
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

            //проверка наличия библиотеки
            if (!File.Exists(Path.Combine(Application.StartupPath,"MimeTeX.dll")))
            {
                MessageBox.Show("Не найдена библиотека MimeTex.dll", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(0);
            }

            //проверка папки Data
            if (!Directory.Exists(Path.Combine(Application.StartupPath,"Data")))
            {
                MessageBox.Show("Не найдена папка Data", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(0);
            }

            Application.Run(new Main());
        }
    }
}
