using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.IO;
using System.Reflection;

namespace Algem_manual.Calculators.ComplexCalculator
{
    public partial class ComplexCalculator : Form
    {
        public ComplexCalculator(Settings global)
        {
            InitializeComponent();
        }

        //private Complex Rea

        private void btn_result_Click(object sender, EventArgs e)
        {
            Complex c1 = new Complex();
            Complex c2 = new Complex();

            try
            {
                c1 = new Complex(Double.Parse(tbx_complex1_a.Text), Double.Parse(tbx_complex1_b.Text));
            }
            catch
            {
                MessageBox.Show("Ошибка при считывании первого числа");
            }
            
            try
            {
                c2 = new Complex(Double.Parse(tbx_complex2_a.Text), Double.Parse(tbx_complex2_b.Text));
            }
            catch
            {
                MessageBox.Show("Ошибка при считывании второго числа");
            }

            string result = "";

            //вызов соответствующих процедур
            foreach (Control panel_control in split_complex.Panel2.Controls)
                if (panel_control is GroupBox)
                    switch (panel_control.Name)
                    {
                        case "gbx_два_компл_действия":
                            if (chbx_два_компл.Checked == true)
                                foreach (Control group_control in panel_control.Controls)
                                    if ((group_control is CheckBox) && ((CheckBox)group_control).Checked && group_control.Name!="chbx_два_компл")
                                    {
                                        string function = group_control.Name.Substring(5);
                                        Type matr_utils = typeof(ComplexUtils);
                                        MethodInfo method = matr_utils.GetMethod(function);

                                        result += (string)method.Invoke(this, new object[] { c1, c2, this.chbx_details.Checked });
                                    }
                            break;
                        default:
                            foreach (Control group_control in panel_control.Controls)
                                if ((group_control is CheckBox) && ((CheckBox)group_control).Checked)
                                {
                                    string function = group_control.Name.Substring(5);
                                    Type matr_utils = typeof(ComplexUtils);
                                    MethodInfo method = matr_utils.GetMethod(function);

                                    Control[] controls = Controls.Find("numeric_" + function, true);
                                    if (controls.Count() == 0)
                                        //MessageBox.Show(String.Format("Для чекбокса {0} не найден привязанный комбобокс", group_control.Name));
                                        result += (string)method.Invoke(this, new object[] { c1, this.chbx_details.Checked });
                                    else
                                    {
                                        //вызов для одного или двух нумериков
                                        Control[] controls2 = Controls.Find("numeric_" + function + "_2", true);
                                        if (controls2.Count() == 0)
                                            //один нумерик
                                            result += (string)method.Invoke(this, new object[] { c1, Int32.Parse(((NumericUpDown)controls[0]).Value.ToString()), this.chbx_details.Checked });
                                        else
                                            //два нумерика
                                            result += (string)method.Invoke(this, new object[] { c1, ((NumericUpDown)controls[0]).Value, ((NumericUpDown)controls2[0]).Value, this.chbx_details.Checked });
                                    }

                                }
                            break;
                    }

            //очистка временной директории
            try
            {
                Directory.Delete(DirectoriesSettings.ComplexCalculatorPath, true);
            }
            catch (Exception ex)
            {
                Logs.WriteLine("При удалении старых файлов калькулятора матриц. Подробности:" + ex.Message);
            }

            TexUtils.Render r1 = new TexUtils.Render(DirectoriesSettings.ComplexCalculatorPath);
            string[] temp = result.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            r1.StringToHTML(temp, "калькулятора матриц");
            browser_results.Navigate(String.Format("file:///{0}", r1.HTMLPath));
            //settings.ApplyWebBrowserStyle(browser_results);
        }
    }
}
