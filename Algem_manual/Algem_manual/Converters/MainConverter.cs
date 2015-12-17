using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algem_manual.Converters
{
    class MainConverter
    {
        /// <summary>
        /// Где лежит контент
        /// </summary>
        private string path;

        public MainConverter(string directory)
        {
            path = directory;
        }

        public bool CheckForUpdates()
        {
            if (File.Exists(path + "\\update.conf"))
                return true;
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ContentPath">Директория, в которую сохраняем контент</param>
        public void UpdateContent(string oldContentPath, string ContentPath)
        {
            //сначала удаляем старые файлы
            if (!Directory.Exists(oldContentPath))
                Logs.WriteLine("Директория со старым контентом не найдена. Пропускаю удаление.");
            else
            {
                try
                {
                    Directory.Delete(oldContentPath, true);
                }
                catch(Exception e)
                {
                    Logs.WriteLine("При удалении старого контента возникла ошибка. Подробности:"+e.Message);
                    MessageBox.Show("Ошибка при обновлении контента!"+Environment.NewLine+"Пожалуйста, закройте все открытые Вами файлы и перезапустите приложение."+Environment.NewLine+"Если ошибка продолжает появляться, отправьте логи разработчику.");
                    Environment.Exit(0);
                }
            }

            //запускаем потоки-конвертеры для теории, примеров и тестов
            TexConverter theory = new TexConverter(path,ContentPath,"Теория");
            TexConverter examples = new TexConverter(path, ContentPath, "Примеры");
            TestConverter tests = new TestConverter(path, ContentPath, "Тесты");

            Thread thread_theory = new Thread(theory.Run);
            thread_theory.Start();

            Thread thread_examples = new Thread(examples.Run);
            thread_examples.Start();

            Thread thread_tests = new Thread(tests.Run);
            //thread_tests.Start();

            while (thread_theory.ThreadState == ThreadState.Running || thread_examples.ThreadState == ThreadState.Running || thread_tests.ThreadState == ThreadState.Running)
            {
                Application.DoEvents();
            }
        }
    }
}
