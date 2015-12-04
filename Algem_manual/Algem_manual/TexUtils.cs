using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
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
            /// Создаёт временное изображение для ТЕХ формулы
            /// </summary>
            /// <param name="expression">Формула</param>
            /// <returns>Полный путь созданного изображения или NULL, если формула была пуста</returns>
            private string CreateImage(string expression)
            {
                if (expression != "")
                {
                    try
                    {
                        Logs.WriteLine("Поиск или создание подкаталога для формулы");
                        string FilePath = Path.Combine(DirectoriesSettings.TempImagesPath, subfolder);
                        System.IO.Directory.CreateDirectory(FilePath);//проверка на существование не нужна!!! 100%!!!
                        FilePath = Path.Combine(FilePath, String.Format("{0}.gif", current));

                        Logs.WriteLine(String.Format("Попытка отрендерить формулу №{0} : {1}", current, expression));

                        TexUtils.CreateGifFromEq(expression, FilePath);
                        Logs.WriteLine(String.Format("Успешно сохранена формула №{0} : {1}", current, expression));
                        current++;
                        return FilePath;
                    }
                    catch (Exception ex)
                    {
                        Logs.WriteLine(String.Format("Ошибка при рендере формулы №{0} : {1}. Подробности:{2}", current, expression, ex.Message));
                        return null;
                    }
                }
                else
                {
                    Logs.WriteLine(String.Format("Формула №{0} была пустой", current));
                    return null;
                }
            }
        }
    }
}
