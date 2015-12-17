using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algem_manual.Converters
{
    class TestConverter
    {
        /// <summary>
        /// Ключевое слово, по которому конвертер проверяет каталоги
        /// </summary>
        private string keyWord;
        private string path;
        private string savepath;

        public TestConverter(string initpath, string save, string word)
        {
            path = initpath;
            savepath = save;
            keyWord = word;
        }

        public void Run()
        {
            //root_folders

            //получаем список директорий
            string[] root_folders = Directory.GetDirectories(path);
            foreach (string root_folder in root_folders)
            {
                string current = root_folder.Split(Path.DirectorySeparatorChar).Last();
                string full = Path.Combine(path, current, keyWord); //full=тема/тесты/
                if (Directory.EnumerateFileSystemEntries(root_folder).Any() && Directory.Exists(full) && Directory.EnumerateFileSystemEntries(full).Any())
                {
                    //каталог не пустой и в нём есть папка "тесты", которая тоже не пуста
                    string[] folders = Directory.GetDirectories(full);
                    foreach (string folder in folders)
                    {
                        //MessageBox.Show(folder);
                        //full = Path.Combine(full, folder.Split(Path.DirectorySeparatorChar).Last());
                        if (Directory.EnumerateFileSystemEntries(folder).Any())
                        {
                            MessageBox.Show(folder);
                            //в тестах нашёлся непустой подкаталог

                            //получаем список файлов
                            string[] files = Directory.GetFiles(folder);

                            string temp = "";
                            int file_lines = 0;
                            List<Object> answers = new List<Object>();
                            try
                            {
                                double obj = 0;
                                using (StreamReader reader = new StreamReader(Path.Combine(folder, "ответы.txt"), System.Text.Encoding.GetEncoding("windows-1251"), true))
                                    while ((temp = reader.ReadLine()) != null)
                                    {
                                        if (Double.TryParse(temp, out obj))
                                            answers.Add(obj);
                                        else
                                            answers.Add(temp);

                                        MessageBox.Show(answers[file_lines].GetType().ToString());

                                        file_lines++;
                                    }
                            }
                            catch(Exception e)
                            {
                                Logs.WriteLine("В теме '" + current + "в тесте " + folder.Split(Path.DirectorySeparatorChar).Last() + " файл ответов был не найден или содержал ошибки. Подробности: "+e.Message);
                                continue;
                            }
                            

                            if (files.Length - 1 == file_lines)
                            {
                                MessageBox.Show("Ответы и файлы совпали");
                                //сохранить список ответов
                                //отрендерить вопросы

                                /*
                                TexUtils.Render render = new TexUtils.Render("");

                                foreach (string file in files)
                                    if (Path.GetExtension(file) == ".tex")
                                    {
                                        string fulloutput = Path.Combine(savepath, current, keyWord, Path.GetFileNameWithoutExtension(file));
                                        System.IO.Directory.CreateDirectory(fulloutput);

                                        render.SetDirectory = fulloutput;
                                        render.TexToHTML(file);
                                        render.Reset();
                                    }*/
                            }
                            else
                                Logs.WriteLine("В теме '" + current + "' в папке '" + keyWord + "' количество вопросов и ответов не совпадают. Проверьте пустые строки в конце файла.");
                        }
                    }                   
                }
                else
                {
                    Logs.WriteLine("В теме '" + current + "' папка '" + keyWord + "' оказалась пустой");
                }
            }
        }
    }
}
