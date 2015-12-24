using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algem_manual.Scanners
{
    class MainScanner
    {
        private string path;

        public MainScanner(string directory)
        {
            path = directory;
        }

        public void ScanContent(TreeView trv_theory, TreeView trv_examples, TreeView trv_tests)
        {
            if (!Directory.Exists(path) || !Directory.EnumerateFileSystemEntries(path).Any())
            {
                Logs.WriteLine("Контент не обнаружен");
                return;
            }

            DirectoryScanner theory = new DirectoryScanner(path, "Теория", trv_theory);
            Thread thread_theory = new Thread(theory.ScanContent);
            thread_theory.Start();

            DirectoryScanner examples = new DirectoryScanner(path, "Примеры", trv_examples);
            Thread thread_examples = new Thread(examples.ScanContent);
            thread_examples.Start();

            DirectoryScanner tests = new DirectoryScanner(path, "Тесты", trv_tests);
            Thread thread_tests = new Thread(tests.ScanContent);
            thread_tests.Start();

            while (thread_theory.ThreadState == ThreadState.Running || thread_examples.ThreadState == ThreadState.Running || thread_tests.ThreadState == ThreadState.Running)
            {
                Application.DoEvents();
            }
        }
    }
}
