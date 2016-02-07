using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;

namespace Algem_manual
{
    public partial class Main : Form
    {
        //WIN32 - отключение крестика и скроллбар для тестов
        [DllImport("user32")]
        private static extern int GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        private static extern bool DeleteMenu(int hMenu, int uPosition, int uFlags);
        private int s_SystemMenuHandle = 0;
        private void cmdDisableX_Click(object sender, EventArgs e)
        {
            this.s_SystemMenuHandle = GetSystemMenu(this.Handle, false);
            DeleteMenu(this.s_SystemMenuHandle, 6, 1024);
        }
        private void cmdEnableX_Click(object sender, EventArgs e)
        {
            this.s_SystemMenuHandle = GetSystemMenu(this.Handle, true);
            DeleteMenu(this.s_SystemMenuHandle, 6, 1024);
        }

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool ShowScrollBar(IntPtr hWnd, int wBar, bool bShow);
        private enum ScrollBarDirection
        {
            SB_HORZ = 0,
            SB_VERT = 1,
            SB_CTL = 2,
            SB_BOTH = 3
        }
        //конец WIN32

        List<object> answers;
        Settings settings;
        private bool backspace;

        private void UpdateAllStyles()
        {
            settings.ApplyWebBrowserStyle(browser_Теория);
            settings.ApplyWebBrowserStyle(browser_Примеры);

            foreach (Control c in split_Тесты.Panel2.Controls)
                if (c is WebBrowser)
                    settings.ApplyWebBrowserStyle((WebBrowser)c);

            settings.ApplyTreeViewStyle(tree_Теория);
            settings.ApplyTreeViewStyle(tree_Примеры);
            settings.ApplyTreeViewStyle(tree_Тесты);

            split_Тесты.Panel2.BackColor = settings.BackgroundColor;
        }

        public Main()
        {
            Logs.WriteLine("Инициализация главной формы");
            InitializeComponent();

            

            tree_Теория.ImageList = img_list_theory_examples;
            tree_Примеры.ImageList = img_list_theory_examples;
            tree_Тесты.ImageList = img_list_tests;

            split_Теория.SplitterWidth = 10;
            split_Примеры.SplitterWidth = 10;
            split_Тесты.SplitterWidth = 10;

            backspace = false;
        }

        private void webBrowserButtonCheck(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                backspace = true;
                return;
            }

            backspace = false;
        }

        private void webBrowserNavigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (backspace)
            {
                e.Cancel = true;
                backspace = false;
            }
        }

        private void TestTextBoxChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        private void TestButtonPressed(object sender, EventArgs e)
        {
            Button current = (Button)sender;
            int index = Int32.Parse(current.Name.Substring(6));

            SplitterPanel parent = (SplitterPanel)current.Parent;
            TextBox tbx = (TextBox)parent.Controls["TextBox"+index.ToString()];

            Object right_answer = answers[index - 1];
            bool correct = false;
            if (right_answer is Double)
            {
                Double user_answer = 0;
                if ((Double.TryParse(tbx.Text, out user_answer) && ((Double)right_answer == user_answer)))
                    correct = true;
            }
            else
            {
                if (right_answer.Equals(tbx.Text))
                    correct = true;
            }

            if (correct)
                tbx.BackColor = Color.LightGreen;
            else
                tbx.BackColor = Color.LightPink;
        }

        private void FillTest(int count,string path)
        {
            int currentpos = 10;
            const int buttonsize = 150;
            int buttonstart = split_Тесты.Panel2.Width - 40 - buttonsize;
            int buttonwidth = split_Тесты.Panel2.Width - 40 - buttonstart;
            int browserwidth = split_Тесты.Panel2.Width - 45;
            for (int i = 0; i < count; i++)
            {
                WebBrowser b = new WebBrowser();
                b.Location = new Point(10, currentpos);
                b.IsWebBrowserContextMenuEnabled = false;
                b.AllowWebBrowserDrop = false;
                b.WebBrowserShortcutsEnabled = false;
                b.Url = new Uri(String.Format("file:///{0}", Path.Combine(path,(i+1).ToString(),"main.html")));
                b.Visible = true;
                b.Name = "WebBrowser" + i.ToString();
                b.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                b.Invalidate();
                b.Width = browserwidth;
                b.Height = 250;
                

                //установка стиля согласно настройкам
                settings.ApplyWebBrowserStyle(b);

                /* Размер по документу
                while (b.Document.Body == null)
                {
                    Application.DoEvents();
                }
                b.Height = b.Document.Body.ScrollRectangle.Height + 25;*/

                b.Parent = split_Тесты.Panel2;
                currentpos += b.Height + 5;
                
                TextBox t = new TextBox();
                t.Location = new Point(10, currentpos);
                t.Width = buttonstart;
                t.Name = "TextBox" + (i + 1).ToString();
                t.Visible = true;
                t.Multiline = false;
                t.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                t.Parent = split_Тесты.Panel2;
                t.TextChanged += TestTextBoxChanged;
                

                Button btn = new Button();
                btn.Location = new Point(buttonstart + 10, currentpos - 1);
                btn.Height = t.Height + 2;
                btn.Width = buttonwidth;
                btn.Name = "Button" + (i + 1).ToString();
                btn.Text = "Проверить";
                btn.Visible = true;
                btn.Anchor = AnchorStyles.Right | AnchorStyles.Top;
                btn.Parent = split_Тесты.Panel2;
                btn.Click += TestButtonPressed;

                currentpos += t.Height + 100;
            }
        }

        private void ClearTest()
        {
            split_Тесты.Panel2.Controls.Clear();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Calculations c = new Calculations(settings);
            c.Show();
        }

        private void treeViewSelection(object sender, TreeViewEventArgs e)
        {
            backspace = false;

            TreeView tree = (TreeView)sender;

            WebBrowser browser = null;

            TreeNode current = tree.SelectedNode;
            if (current.Tag.ToString() == "child")
            {
                String htmlpath = Path.Combine(DirectoriesSettings.ConvertedPath, current.Parent.Name, current.Text);

                if (tree.Name == "tree_Теория")
                {
                    
                    browser = browser_Теория;
                    ((Control)browser).Enabled = false;

                    htmlpath = Path.Combine(htmlpath, "main.html");
                    browser_Теория.Navigate(String.Format("file:///{0}", htmlpath));
                    
                }


                if (tree.Name == "tree_Примеры")
                {
                    browser = browser_Примеры;
                    ((Control)browser).Enabled = false;

                    htmlpath = Path.Combine(htmlpath, "main.html");
                    browser_Примеры.Navigate(String.Format("file:///{0}", htmlpath));
                    
                }
                    

                if (tree.Name == "tree_Тесты")
                {
                    LockControls();

                    FileStream fs = new FileStream(Path.Combine(htmlpath,"answers.dat"),FileMode.Open);
                    BinaryFormatter formatter = new BinaryFormatter();
                    try
                    {
                        answers = (List<Object>)formatter.Deserialize(fs);
                    }
                    catch (SerializationException ex)
                    {
                        Logs.WriteLine("Ошибка при чтении ответов. Подробности: " + ex.Message);
                        return;
                    }
                    finally
                    {
                        fs.Close();
                    }

                    ClearTest();
                    ShowScrollBar(split_Тесты.Panel2.Handle, (int)ScrollBarDirection.SB_VERT, true);
                    FillTest(answers.Count,htmlpath);

                    UnlockControls();
                    
                }

                if (browser != null)
                {
                    settings.ApplyWebBrowserStyle(browser);
                    ((Control)browser).Enabled = true;
                }
            }
        }

        private void LockControls()
        {
            this.tab_control_main.Enabled = false;
            this.Cursor = Cursors.WaitCursor;
        }

        private void UnlockControls()
        {
            this.tab_control_main.Enabled = true;
            this.Cursor = Cursors.Default;
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            LockControls();
            
            cmdDisableX_Click(sender, e);

            bool update = false;

            Converters.MainConverter converter = new Converters.MainConverter(DirectoriesSettings.UnconvertedPath);
            if (converter.CheckForUpdates())
            {
                Logs.WriteLine("Найдены обновления контента");
                update = true;

                MessageBox.Show("Начинается распаковка нового контента" + Environment.NewLine + "Главный элемент с вкладками будет временно недоступен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                //обновляем контент
                converter.UpdateContent(DirectoriesSettings.ConvertedPath);
                
                //перезаполняем treeview
                Scanners.MainScanner scanner = new Scanners.MainScanner(DirectoriesSettings.ConvertedPath);
                scanner.ScanContent(tree_Теория, tree_Примеры, tree_Тесты);

                //сериализуем treeview для будущего использования
                TreeViewUtils.Serialize(DirectoriesSettings.TreeViewPath, tree_Теория);
                TreeViewUtils.Serialize(DirectoriesSettings.TreeViewPath, tree_Примеры);
                TreeViewUtils.Serialize(DirectoriesSettings.TreeViewPath, tree_Тесты);

                File.Delete(Path.Combine(DirectoriesSettings.UnconvertedPath, "update.conf"));
                MessageBox.Show("Распаковка нового контента успешно завершена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Logs.WriteLine("Обновления контента не найдены");
                TreeViewUtils.Deserialize(DirectoriesSettings.TreeViewPath, ref tree_Теория);
                TreeViewUtils.Deserialize(DirectoriesSettings.TreeViewPath, ref tree_Примеры);
                TreeViewUtils.Deserialize(DirectoriesSettings.TreeViewPath, ref tree_Тесты);
            }

            tree_Теория.ExpandAll();
            tree_Примеры.ExpandAll();
            tree_Тесты.ExpandAll();

            browser_Теория.Navigate("about:blank");
            browser_Примеры.Navigate("about:blank");

            Logs.WriteLine("Загрузка файла настроек");
            Settings temp = Settings.Load();
            if (temp == null)
            {
                Logs.WriteLine("Файл настроек не найден. Создание файла настроек.");
                settings = new Settings(this);
                try
                {
                    settings.Save();
                    Logs.WriteLine("Успешно сохранён файл настроек со стандартными значениями.");
                }
                catch (Exception ex)
                {
                    Logs.WriteLine("Ошибка при создании файла настроек.");
                    Logs.WriteException(ex);
                    MessageBox.Show("Невозможно сохранить настройки по умолчанию." + Environment.NewLine + "При следующем запуске будут загружены настройки по умолчанию." + Environment.NewLine + "Возможно, приложение нужно запустить с правами администратора.", "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Logs.WriteLine("Файл настроек успешно загружен");
                settings = temp;
            }

            UpdateAllStyles();
            settings.LoadFormState(this);
            if (update == true)
                settings.ResetBookmarks();
            else
                settings.LoadBookmarks(tree_Теория, tree_Примеры, tree_Тесты);

            cmdEnableX_Click(sender, e);
            UnlockControls();
        }

        private void tool_settings_Click(object sender, EventArgs e)
        {
            SettingsForm frm = new SettingsForm(settings);
            
            frm.ShowDialog();
            if (frm.DialogResult != DialogResult.Cancel)
                UpdateAllStyles();
        }

        private void комплексныеЧислаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculators.ComplexCalculator.ComplexCalculator c = new Calculators.ComplexCalculator.ComplexCalculator(settings);
            c.Show();
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://" + DirectoriesSettings.HelpPath);
        }

        private void Main_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "file://" + DirectoriesSettings.HelpPath);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            settings.SaveFormState(this);
            settings.SaveBookmark(ref settings.TheoryBookmark, tree_Теория, tree_Теория.SelectedNode);
            settings.SaveBookmark(ref settings.ExamplesBookmark, tree_Примеры, tree_Примеры.SelectedNode);
            settings.SaveBookmark(ref settings.TestsBookmark, tree_Тесты, tree_Тесты.SelectedNode);

            try
            {
                settings.Save();
            }
            catch
            {
                MessageBox.Show("Невозможно сохранить настройки." + Environment.NewLine + "Возможно, приложение нужно запустить с правами администратора." + Environment.NewLine + "При следующем запуске будут загружены настройки по умолчанию.", "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
