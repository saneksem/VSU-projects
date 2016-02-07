using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algem_manual
{
    [Serializable]
    public class Settings
    {
        private static string FilePath = Path.Combine(Application.StartupPath, "settings.conf");
        public int FontSize;
        public Color BackgroundColor;
        public Point WindowLocation;
        public Size WindowSize;
        public FormWindowState WindowState;
        public Point TheoryBookmark;
        public Point ExamplesBookmark;
        public Point TestsBookmark;

        public void ResetBookmarks()
        {
            TheoryBookmark = new Point(-1, -1);
            ExamplesBookmark = new Point(-1, -1);
            TestsBookmark = new Point(-1, -1);
        }

        public Settings()
        {
            FontSize = 14;
            BackgroundColor = System.Drawing.Color.White;
            ResetBookmarks();
        }

        public Settings(Form frm)
        {
            FontSize = 14;
            BackgroundColor = System.Drawing.Color.White;
            ResetBookmarks();
            SaveFormState(frm);
        }

        public void SaveFormState(Form frm)
        {
            switch(frm.WindowState)
            {
                case FormWindowState.Normal:
                    WindowLocation = frm.Location;
                    WindowSize = frm.Size;
                    break;
                default:
                    WindowLocation = frm.RestoreBounds.Location;
                    WindowSize = frm.RestoreBounds.Size;
                    break;
            }
            
            WindowState = frm.WindowState;
        }

        public void LoadFormState(Form frm)
        {
            frm.WindowState = WindowState;
            frm.Location = WindowLocation;
            frm.Size = WindowSize;
        }

        public void SaveBookmark(ref Point point,TreeView tree, TreeNode node)
        {
            if (node == null || !PointOfNode(ref point, tree, node))
                point = new Point(-1, -1);
        }

        public void LoadBookmarks(TreeView theory,TreeView examples,TreeView tests)
        {
            Logs.WriteLine("Восстанавливаю закладки");

            if (TheoryBookmark.X>-1 && TheoryBookmark.Y>-1)
                theory.SelectedNode = theory.Nodes[TheoryBookmark.X].Nodes[TheoryBookmark.Y];

            if (ExamplesBookmark.X>-1 && ExamplesBookmark.Y>-1)
                examples.SelectedNode = examples.Nodes[ExamplesBookmark.X].Nodes[ExamplesBookmark.Y];

            if (TestsBookmark.X>-1 && TestsBookmark.Y >-1)
            tests.SelectedNode = tests.Nodes[TestsBookmark.X].Nodes[TestsBookmark.Y];
        }

        public bool PointOfNode(ref Point point,TreeView tree,TreeNode node)
        {
            int x = 0;
            while (x < tree.Nodes.Count && !tree.Nodes[x].Nodes.Contains(node))
                x++;

            if (x >= tree.Nodes.Count)
                return false;

            int y = tree.Nodes[x].Nodes.IndexOf(node);
            point.X = x;
            point.Y = y;
            return true;
        }

        public void Save()
        {
            Logs.WriteLine("Сохраняю настройки в файл...");
            using (Stream stream = File.Open(FilePath, FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, this);
            }
        }

        public static Settings Load()
        {
            try
            {
                using (Stream stream = File.Open(FilePath, FileMode.Open))
                {
                    var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    return (Settings)binaryFormatter.Deserialize(stream);
                }
            }
            catch
            {
                return null;
            }
        }

        public void ApplyWebBrowserStyle(WebBrowser browser)
        {
            browser.Hide();
            
            while (browser.ReadyState != WebBrowserReadyState.Complete)
            { Application.DoEvents(); }

            if (browser.Document != null)
                browser.Document.BackColor = this.BackgroundColor;
            browser.Document.Body.Style = String.Format("font-size:{0}pt;", this.FontSize);

            browser.Show();
        }

        public void ApplyTreeViewStyle(TreeView tree)
        {
            tree.BackColor = this.BackgroundColor;
        }

        public void CopyTo(Settings other)
        {
            other.BackgroundColor = this.BackgroundColor;
            other.FontSize = this.FontSize;
    }
    }
}
