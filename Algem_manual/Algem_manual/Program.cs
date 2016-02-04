using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algem_manual
{
    static class Program
    {
        const int FEATURE_DISABLE_NAVIGATION_SOUNDS = 21;
        const int SET_FEATURE_ON_PROCESS = 0x00000002;

        [DllImport("urlmon.dll")]
        [PreserveSig]
        [return: MarshalAs(UnmanagedType.Error)]
        static extern int CoInternetSetFeatureEnabled(int FeatureEntry,[MarshalAs(UnmanagedType.U4)] int dwFlags,bool fEnable);

        static void DisableClickSounds()
        {
            CoInternetSetFeatureEnabled(
                FEATURE_DISABLE_NAVIGATION_SOUNDS,
                SET_FEATURE_ON_PROCESS,
                true);
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlAppDomain)]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DisableClickSounds();

            //обработка необработанных ранее исключений
            System.AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionTrapper;
            Application.ThreadException += Application_ThreadException;
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

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

            //инициализация логов
            try
            {
                int logs_count = 20;
                System.IO.Directory.CreateDirectory(DirectoriesSettings.LogsPath);
                Logs.InitLogging();

                Logs.Write("Версия ОС: " + Environment.OSVersion);
                if (Environment.Is64BitOperatingSystem)
                    Logs.Write(" х64; ");
                else
                    Logs.Write(" х32; ");
                Logs.WriteLine(Environment.ProcessorCount.ToString() + "-ядерный процессор");

                FileInfo[] files = Directory.GetFiles(DirectoriesSettings.LogsPath).Select(x => new FileInfo(x))
                 .OrderByDescending(x => x.LastWriteTime)
                 .ToArray();
                Logs.WriteLine("Найдено " + files.Count().ToString() + " логов.");
                if (files.Count() > logs_count)
                {
                    Logs.WriteLine("Удаление лишних логов. Всего " + (files.Count() - logs_count).ToString() + " файл(а)");
                    for (int current_file = logs_count; current_file < files.Count(); current_file++)
                        files[current_file].Delete();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при инициализации системы логов"+Environment.NewLine+"При возникновении ошибок в дальнейшем Вы не сможете отследить их с помощью лога", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(0);
            }

            //запуск программы
            Logs.WriteLine("Запуск программы");
            Application.Run(new Main());
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show("Непредвиденная ошибка: " + e.Exception.Message + Environment.NewLine + "Подробности в последнем логе в папке Logs", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            Logs.WriteLine("************************************************************************");
            Logs.WriteLine("Необработанное исключение вызвало остановку программы. Подробности ниже.");
            Logs.WriteException(e.Exception);
            Logs.WriteLine("************************************************************************");
            Logs.WriteLine("Программа остановлена принудительно во избежание дальнейших ошибок.");
            System.Environment.Exit(0);
        }

        static void UnhandledExceptionTrapper(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show("Непредвиденная ошибка: " + ((Exception)e.ExceptionObject).Message + Environment.NewLine + "Подробности в последнем логе в папке Logs", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            Logs.WriteLine("************************************************************************");
            Logs.WriteLine("Необработанное исключение вызвало остановку программы. Подробности ниже.");
            Logs.WriteException((Exception)e.ExceptionObject);
            Logs.WriteLine("************************************************************************");
            Logs.WriteLine("Программа остановлена принудительно во избежание дальнейших ошибок.");
            System.Environment.Exit(0);
        }
    }
}
