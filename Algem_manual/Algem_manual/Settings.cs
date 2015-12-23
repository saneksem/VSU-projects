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

        public Settings()
        {
            FontSize = 14;
            BackgroundColor = System.Drawing.Color.White;
        }

        public void Save()
        {
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
    }
}
