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

namespace Algem_manual
{

    public partial class Main : Form
    {
        List<object> answers;
        Settings settings;

        private void UpdateAllWebBrowsersStyle()
        {
            settings.ApplyWebBrowserStyle(browser_Теория);
            settings.ApplyWebBrowserStyle(browser_Примеры);

            settings.ApplyTreeViewStyle(tree_Теория);
            settings.ApplyTreeViewStyle(tree_Примеры);
            settings.ApplyTreeViewStyle(tree_Тесты);

            split_Тесты.Panel2.BackColor = settings.BackgroundColor;
        }

        public Main()
        {
            Logs.InitLogging();

            Logs.Write("Версия ОС: "+Environment.OSVersion);
            if (Environment.Is64BitOperatingSystem)
                Logs.Write(" х64; ");
            else
                Logs.Write(" х32; ");
            Logs.WriteLine(Environment.ProcessorCount.ToString() + " ядер ЦП");
            
            Logs.WriteLine("Инициализация главной формы");

            
            Settings temp = Settings.Load();
            if (temp == null)
            {
                //создать настройки по умолчанию и сохранить
                settings = new Settings();
                try
                {
                    settings.Save();
                }
                catch
                {
                    MessageBox.Show("Невозможно сохранить настройки по умолчанию."+Environment.NewLine+"Возможно, приложение нужно запустить с правами администратора." + Environment.NewLine + "При следующем запуске будут загружены настройки по умолчанию.", "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //MessageBox.Show("успешно загружено");
                settings = temp;
            }

            InitializeComponent();

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
            int buttonsize = 150;
            int buttonstart = split_Тесты.Panel2.Width - 20 - buttonsize;
            int buttonwidth = split_Тесты.Panel2.Width - 20 - buttonstart;
            for (int i = 0; i < count; i++)
            {
                WebBrowser b = new WebBrowser();
                b.Location = new Point(10, currentpos);
                b.Url = new Uri(String.Format("file:///{0}", Path.Combine(path,(i+1).ToString(),"main.html")));
                b.Visible = true;
                b.Name = "WebBrowser" + i.ToString();
                b.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                b.Width = split_Тесты.Panel2.Width - 25;
                b.Height = 500;

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
            Calculations c = new Calculations();
            c.Show();
        }

        private void treeViewSelection(object sender, TreeViewEventArgs e)
        {
            TreeView tree = (TreeView)sender;

            WebBrowser browser = null;

            TreeNode current = tree.SelectedNode;
            if (current.Tag.ToString() == "child")
            {
                String htmlpath = Path.Combine(DirectoriesSettings.ConvertedPath, current.Parent.Name, current.Text);

                if (tree.Name == "tree_Теория")
                {
                    htmlpath = Path.Combine(htmlpath, "main.html");
                    browser_Теория.Navigate(String.Format("file:///{0}", htmlpath));

                    browser = browser_Теория;
                    /*
                    while (browser_Теория.ReadyState != WebBrowserReadyState.Complete)
                    { Application.DoEvents(); }
                    //MessageBox.Show("TEST");
                    browser_Теория.Document.Body.Style = "font-size:14pt;";
                    if (browser_Теория.Document != null)
                        browser_Теория.Document.BackColor = Color.LightYellow;*/
                }
                    

                if (tree.Name == "tree_Примеры")
                {
                    htmlpath = Path.Combine(htmlpath, "main.html");
                    browser_Примеры.Navigate(String.Format("file:///{0}", htmlpath));

                    browser = browser_Примеры;
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
                    FillTest(answers.Count,htmlpath);

                    UnlockControls();
                }

                if (browser != null)
                    settings.ApplyWebBrowserStyle(browser);
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

            Converters.MainConverter converter = new Converters.MainConverter(DirectoriesSettings.UnconvertedPath);
            if (converter.CheckForUpdates())
            {
                Logs.WriteLine("Найдены обновления контента");
                
                MessageBox.Show("Необходимо распаковать новый контент." + Environment.NewLine + "Главный элемент с вкладками будет временно доступен.");
                
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

            UpdateAllWebBrowsersStyle();

            UnlockControls();
        }

        private void tool_settings_Click(object sender, EventArgs e)
        {
            SettingsForm frm = new SettingsForm(settings);
            frm.ShowDialog();
            if (frm.DialogResult!=DialogResult.Cancel)
            {
                UpdateAllWebBrowsersStyle();
                if (tree_Тесты.SelectedNode != null)
                    MessageBox.Show("Настройки текста для тестов будут применены только после выбора нового теста", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
        }
    }
}
