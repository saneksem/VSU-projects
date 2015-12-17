using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algem_manual.Converters
{
    class TexConverter
    {
        /// <summary>
        /// Ключевое слово, по которому конвертер проверяет каталоги
        /// </summary>
        private string keyWord;
        private string path;
        private string savepath;

        public TexConverter(string initpath, string save, string word)
        {
            path = initpath;
            savepath = save;
            keyWord = word;
        }

        public void Run()
        {
            //получаем список директорий
            string[] folders = Directory.GetDirectories(path);
            foreach (string folder in folders)
            {
                string current = folder.Split(Path.DirectorySeparatorChar).Last();
                string full = Path.Combine(path, current, keyWord);
                if (Directory.EnumerateFileSystemEntries(folder).Any() && Directory.Exists(full) && Directory.EnumerateFileSystemEntries(full).Any())
                {
                    //каталог не пустой и в нём есть папка "теория", которая тоже не пуста
                    //получаем список файлов и начинаем конвертацию
                    TexUtils.Render render = new TexUtils.Render("");

                    string[] files = Directory.GetFiles(full);
                    foreach (string file in files)
                        if (Path.GetExtension(file) == ".tex")
                        {
                            string fulloutput = Path.Combine(savepath, current, keyWord, Path.GetFileNameWithoutExtension(file));
                            System.IO.Directory.CreateDirectory(fulloutput);

                            render.SetDirectory = fulloutput;
                            render.TexToHTML(file);
                            render.Reset();
                        }
                }
                else
                {
                    Logs.WriteLine("В теме '"+current+"' папка '"+keyWord+"' оказалась пустой");
                }
            }
        }
    }
}
