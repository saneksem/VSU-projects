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
            settings.ApplyWebBrowserStyle(browser_test);
        }

        public SettingsForm(Settings global)
        {
            backup = new Settings();
            global.CopyTo(backup);

            settings = global;

            InitializeComponent();

            //this.ClientSize = new Size(this.Width,this.Height);

            browser_test.Navigate(String.Format("file:///{0}", DirectoriesSettings.SettingsTestHTMLPath));
            numeric_font.Value = Convert.ToDecimal(settings.FontSize);

            for (int i = 0; i < colors.GetLength(0); i++)
                if (colors[i] == settings.BackgroundColor)
                    lbx_color.SelectedIndex = i;

            UpdateStyle();
        }

        private void cmbx_font_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbx_font.SelectedItem.ToString());
            //settings.FontSize = Convert.ToInt32(cmbx_font.SelectedItem);
            UpdateStyle();
        }

        private void lbx_color_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbx_color.SelectedIndex!=-1)
            {
                settings.BackgroundColor = colors[lbx_color.SelectedIndex];
                UpdateStyle();
            }
            //this.DialogResult = DialogResult.Cancel;
        }

        private void numeric_font_ValueChanged(object sender, EventArgs e)
        {
            settings.FontSize = Convert.ToInt32(numeric_font.Value);
            UpdateStyle();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            backup.CopyTo(settings);
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                settings.Save();
            }
            catch
            {
                MessageBox.Show("Невозможно сохранить настройки." + Environment.NewLine + "Возможно, приложение нужно запустить с правами администратора." + Environment.NewLine + "При следующем запуске будут загружены настройки по умолчанию.", "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
