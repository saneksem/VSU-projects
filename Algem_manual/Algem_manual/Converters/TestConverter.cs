using System;
using System.Collections.Generic;
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
            MessageBox.Show("testing testing");
            MessageBox.Show("testing testing");
            MessageBox.Show("testing testing");
        }
    }
}
