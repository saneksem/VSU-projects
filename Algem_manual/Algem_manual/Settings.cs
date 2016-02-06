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

        public Settings()
        {
            FontSize = 14;
            BackgroundColor = System.Drawing.Color.White;
        }

        public Settings(Form frm)
        {
            FontSize = 14;
            BackgroundColor = System.Drawing.Color.White;
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

        public void Save()
        {
            Logs.WriteLine("Сохраняю настройки в файл...");
            using (Stream stream = File.Open(FilePath, FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, this);
                stream.Close();
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
