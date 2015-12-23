using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algem_manual
{
    public partial class SettingsForm : Form
    {
        Settings settings;
        Settings backup;

        static Color[] colors = { Color.White, Color.LightYellow, Color.LightGray };

        public void UpdateStyle()
        {
            while (browser_test.ReadyState != WebBrowserReadyState.Complete)
            { Application.DoEvents(); }

            browser_test.Document.Body.Style = String.Format("font-size:{0}pt;", settings.FontSize);
            if (browser_test.Document != null)
                browser_test.Document.BackColor = settings.BackgroundColor;
        }

        public SettingsForm(Settings global)
        {
            settings = global;

            backup = new Settings();
            backup.FontSize = settings.FontSize;
            backup.BackgroundColor = settings.BackgroundColor;

            InitializeComponent();
            browser_test.Navigate(String.Format("file:///{0}", DirectoriesSettings.SettingsTestHTMLPath));

            UpdateStyle();

            this.DialogResult = DialogResult.None;
        }

        private void cmbx_font_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbx_font.SelectedItem.ToString());
            settings.FontSize = Convert.ToInt32(cmbx_font.SelectedItem);
            UpdateStyle();
        }

        private void lbx_color_SelectedIndexChanged(object sender, EventArgs e)
        {
            settings.BackgroundColor = colors[lbx_color.SelectedIndex];
            UpdateStyle();

            this.DialogResult = DialogResult.Cancel;
        }
    }
}
