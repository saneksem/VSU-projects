using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Drawing.Drawing2D;

namespace Algem_manual
{
    [System.Security.SuppressUnmanagedCodeSecurity()]
    public static class TexUtils
    {
        [System.Runtime.InteropServices.DllImport("MimeTex.dll")]
        public static extern int CreateGifFromEq(string expr, string fileName);

        public class Render
        {
            private int current;
            private string subfolder;
            public string Directory
            { get
                {
                    return Path.Combine(DirectoriesSettings.TempImagesPath, subfolder);
                }
            }
            public string HTMLPath
            {
                get
                {
                    return Path.Combine(Directory, "main.html");
                }
            }
            
            public Render(string folder)
            {
                Logs.WriteLine("Инициализиация рендера ТЕХ формул");
                subfolder = folder;
                current = 0;
            }

            /// <summary>
            /// Удаляет временное изображение
            /// </summary>
            /// <param name="FileNumber">Индекс изображения</param>
            private void Delete(int FileNumber)
            {
                try
                {
                    File.Delete(Path.Combine(DirectoriesSettings.TempImagesPath, subfolder, String.Format("{0}.gif", FileNumber)));
                }
                catch (Exception ex)
                {
                    Logs.WriteLine(ex.Message);
                }
            }

            /// <summary>
            /// Удаляет все временные изображения для текущего экземпляра класса
            /// </summary>
            public void Clear()
            {
                for (int i = 0; i<=current;i++)
                {
                    Delete(i);
                }
                current = 0;
            }

            /// <summary>
            /// Вставляет ТЕХ формулу в RichTextBox
            /// </summary>
            /// <param name="expression">Формула</param>
            /// <param name="control">Компонент для вывода</param>
            public void FormulaToRTB(string expression, RichTextBox control)
            {
                string filename = CreateImage(expression);
                int width;
                int height;
                Image img;

                using (Image image1 = Image.FromFile(filename))
                {
                    width = image1.Width;
                    height = image1.Height;
                    Logs.WriteLine("Получаю эскиз изображения "+filename);
                    img = image1.GetThumbnailImage(width, height, null,IntPtr.Zero);
                }
                Bitmap myBitmap = new Bitmap(width, height);

                System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(myBitmap);
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.Clear(control.BackColor);
                g.DrawImage(img, 0, 0);
                g.Dispose();

                // Copy the bitmap to the clipboard.
                Clipboard.SetDataObject(myBitmap);
                
                
                // Get the format for the object type.
                DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);

                // After verifying that the data can be pasted, paste
                if (control.CanPaste(myFormat))
                {
                    Logs.WriteLine("Вставляю на форму изображение " + filename);
                    control.Paste(myFormat);
                }
            }

            /// <summary>
            /// Выводит текст с отрисованными ТЕХ формулами в RichTextBox
            /// </summary>
            /// <param name="text">Текст с ТЕХ формулами</param>
            /// <param name="control">Компонент для вывода</param>
            public void StringToRTB(string text, RichTextBox control)
            {
                throw new NotImplementedException();
            }

            /// <summary>
            /// На основе .тех файла создаёт HTML страницу с картинками в текущем каталоге экземпляра
            /// </summary>
            /// <param name="filepath">Полный путь до .тех файла</param>
            public void TexToHTML(string filepath)
            {
                string FilePath = Directory;
                System.IO.Directory.CreateDirectory(FilePath);//проверка на существование не нужна!!! 100%!!!
                FilePath = Path.Combine(FilePath, "main.html");

                using (StreamReader reader = new StreamReader(filepath, System.Text.Encoding.GetEncoding("windows-1251"), true))
                using (StreamWriter writer = new StreamWriter(File.Open(FilePath, FileMode.Create), Encoding.GetEncoding("windows-1251")))
                {
                    string current = "";
                    writer.WriteLine(TexSettings.HTMLHeader);
                    writer.WriteLine(TexSettings.HTMLImageStyle);

                    //пропускаем служебные строки
                    while ((current = reader.ReadLine()) != null && current.Trim() != TexSettings.DocumentStart)
                    { }

                    //теперь мы либо в контенте,либо файл кончился
                    //если файл закончился,ничего не делаем
                    if (current == null)
                        return;

                    
                    string formula = ""; //временное хранение формулы (возможно, многострочной)
                    bool formula_opened = false; //флаг,отслеживающий, не рассматриваем ли мы формулу
                    

                    //иначе создаём абзац и начинаем считывать
                    writer.Write("<p>");
                    while ((current = reader.ReadLine()) != null && current.Trim() != TexSettings.DocumentEnd)
                    {
                        //MessageBox.Show("строка:" + current);
                        //если пустая строка,то новый абзац
                        if (String.IsNullOrWhiteSpace(current))
                        {
                            writer.WriteLine("</p>");
                            writer.WriteLine("<p>");
                        }
                        else
                        {
                            int cur_index = 0;

                            if (formula_opened)
                                if (current.IndexOf("$$") == -1)
                                {
                                    formula += current;
                                    //MessageBox.Show("Обновление незакрытой формулы: " + formula);
                                    continue;
                                }
                                else
                                {
                                    int formula_end = current.IndexOf("$$");
                                    formula += current.Substring(0, formula_end + 2);
                                    current = current.Remove(0, formula_end + 2);

                                    //MessageBox.Show("Конец незакрытой формулы: " + formula);

                                    string finished_formula = "<img src=\"" + CreateImage(formula) + "\">";
                                    current = current.Insert(0, finished_formula);
                                    

                                    formula = "";
                                    formula_opened = false;
                                    cur_index += finished_formula.Length;
                                }

                            
                            int pred_index = cur_index;
                            while ( (cur_index <= current.Length) && ((cur_index = current.IndexOf("$$",cur_index)) != -1) )
                            {
                                if(!formula_opened)
                                {
                                    formula_opened = true;
                                    pred_index = cur_index;
                                    cur_index += 2;
                                }
                                else
                                {
                                    formula += current.Substring(pred_index, cur_index + 2 - pred_index);
                                    current = current.Remove(pred_index, cur_index + 2 - pred_index);
                                    //MessageBox.Show("after delete строка:" + current);
                                    //MessageBox.Show("Найдена формула: " + formula);
                                    string expression = "<img src=\"" + CreateImage(formula) + "\">";
                                    //MessageBox.Show("Добавляем:" + expression);
                                    current = current.Insert(pred_index, expression);
                                    //MessageBox.Show("Новая строка:" + current);
                                    cur_index = pred_index + expression.Length;
                                    formula_opened = false;
                                    formula = "";
                                }
                            }

                            if (formula_opened)
                            {
                                formula += current.Substring(pred_index, current.Length - pred_index);
                                current = current.Remove(pred_index, current.Length - pred_index);
                                //MessageBox.Show("Есть незакрытая формула: " + formula);
                            }

                             //просто бежим по строке и считываем формулы

                             writer.WriteLine(current);
                        }
                    }
                }
            }

            public void StringToHTML(string[] strings)
            {
                string FilePath = Directory;
                System.IO.Directory.CreateDirectory(FilePath);//проверка на существование не нужна!!! 100%!!!
                FilePath = Path.Combine(FilePath, "main.html");

                using (StreamWriter writer = new StreamWriter(File.Open(FilePath, FileMode.Create), Encoding.GetEncoding("windows-1251")))
                {
                    writer.WriteLine(TexSettings.HTMLHeader);
                    writer.WriteLine(TexSettings.HTMLImageStyle);

                    string formula = ""; //временное хранение формулы (возможно, многострочной)
                    bool formula_opened = false; //флаг,отслеживающий, не рассматриваем ли мы формулу

                    //создаём абзац и начинаем считывать
                    writer.Write("<p>");
                    foreach (string current_string in strings)
                    {
                        string current = current_string;

                        //если пустая строка,то новый абзац
                        if (String.IsNullOrWhiteSpace(current))
                        {
                            writer.WriteLine("</p>");
                            writer.WriteLine("<p>");
                        }
                        else
                        {
                            int cur_index = 0;

                            if (formula_opened)
                                if (current.IndexOf("$$") == -1)
                                {
                                    formula += current;
                                    //MessageBox.Show("Обновление незакрытой формулы: " + formula);
                                    continue;
                                }
                                else
                                {
                                    int formula_end = current.IndexOf("$$");
                                    formula += current.Substring(0, formula_end + 2);
                                    current = current.Remove(0, formula_end + 2);

                                    //MessageBox.Show("Конец незакрытой формулы: " + formula);

                                    string finished_formula = "<img src=\"" + CreateImage(formula) + "\">";
                                    current = current.Insert(0, finished_formula);


                                    formula = "";
                                    formula_opened = false;
                                    cur_index += finished_formula.Length;
                                }


                            int pred_index = cur_index;
                            while ((cur_index <= current.Length) && ((cur_index = current.IndexOf("$$", cur_index)) != -1))
                            {
                                if (!formula_opened)
                                {
                                    formula_opened = true;
                                    pred_index = cur_index;
                                    cur_index += 2;
                                }
                                else
                                {
                                    formula += current.Substring(pred_index, cur_index + 2 - pred_index);
                                    current = current.Remove(pred_index, cur_index + 2 - pred_index);
                                    //MessageBox.Show("after delete строка:" + current);
                                    //MessageBox.Show("Найдена формула: " + formula);
                                    string expression = "<img src=\"" + CreateImage(formula) + "\">";
                                    //MessageBox.Show("Добавляем:" + expression);
                                    current = current.Insert(pred_index, expression);
                                    //MessageBox.Show("Новая строка:" + current);
                                    cur_index = pred_index + expression.Length;
                                    formula_opened = false;
                                    formula = "";
                                }
                            }

                            if (formula_opened)
                            {
                                formula += current.Substring(pred_index, current.Length - pred_index);
                                current = current.Remove(pred_index, current.Length - pred_index);
                                //MessageBox.Show("Есть незакрытая формула: " + formula);
                            }

                            //просто бежим по строке и считываем формулы

                            writer.WriteLine(current);
                        }
                    }
                }
            }

            /// <summary>
            /// Создаёт временное изображение для ТЕХ формулы
            /// </summary>
            /// <param name="expression">Формула</param>
            /// <returns>Имя созданного изображения или NULL, если формула была пуста</returns>
            private string CreateImage(string expression)
            {
                if (expression.Trim() == "")
                {
                    Logs.WriteLine(String.Format("Формула №{0} была пустой", current));
                    return null;
                }

                try
                {
                    Logs.WriteLine("Поиск или создание подкаталога для формулы");
                    string FilePath = Directory;
                    System.IO.Directory.CreateDirectory(FilePath);//проверка на существование не нужна!!! 100%!!!
                    FilePath = Path.Combine(FilePath, String.Format("{0}.gif", current));

                    Logs.WriteLine(String.Format("Попытка отрендерить формулу №{0} : {1}", current, expression));
                    expression.Trim();
                    expression = expression.Insert(2, @"\color{black} \Huge ");
                    TexUtils.CreateGifFromEq(expression, FilePath);

                    Logs.WriteLine(String.Format("Успешно сохранена формула №{0} : {1}", current, expression));
                    current++;

                    //return FilePath;
                    return String.Format("{0}.gif", current - 1);
                }
                catch (Exception ex)
                {
                    Logs.WriteLine(String.Format("Ошибка при рендере формулы №{0} : {1}. Подробности:{2}", current, expression, ex.Message));
                    return null;
                }
            }

            public override string ToString()
            {
                return "";
            }
        }
    }
}
