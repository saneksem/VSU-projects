using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algem_manual
{
    public partial class Calculations : Form
    {
        Settings settings;

        public Calculations(Settings global)
        {
            //загрузка настроек
            settings = global;

            //инициализация компонентов формы
            InitializeComponent();

            splitContainer1.Panel2Collapsed = true;
            splitContainer1.SplitterWidth = 15;

            //по умолчанию грузится матрица 2 на 2
            string col = "";
            dgv_mtr1.Columns.Add(col, col);
            dgv_mtr1.Columns.Add(col, col);
            dgv_mtr1.Rows.Add(2);

            dgv_mtr2.Columns.Add(col, col);
            dgv_mtr2.Columns.Add(col, col);
            dgv_mtr2.Rows.Add(2);

            //установка индексов для выбора номера строк и прочего
            cmbx_две_матр_действия_вычитание.SelectedIndex = 0;
            cmbx_две_матр_действия_умножение.SelectedIndex = 0;
            cmbx_определитель_разложение_строка.SelectedIndex = 0;
            cmbx_определитель_разложение_столбец.SelectedIndex = 0;
            cmbx_определитель_лаплас.SelectedIndex = 0;
            cmbx_определитель_лаплас_2.SelectedIndex = 0;

            //проверка доступности опций
            CheckSizes();
            CheckBothSizes();

            //установка начальной страницы браузера(можно сделать какую-нибудь страничку,как в настройках)
            browser_results.Navigate("about:blank");
            settings.ApplyWebBrowserStyle(browser_results);
        }

        private void mtr_index_changed(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString()+Environment.NewLine+e.ToString());
        }

        private void addRows(DataGridView dgv, int count)
        {
            for (int i=0;i<count;i++)
            {
                DataGridViewRow row = (DataGridViewRow)dgv.Rows[0].Clone();
                for (int j = 0; j < row.Cells.Count; j++)
                    row.Cells[j].Value = "";

                dgv.Rows.Add(row);
            }
        }

        private void addCols(DataGridView dgv, int count)
        {
            for (int i = 0; i < count; i++)
            {
                string col = "";
                dgv.Columns.Add(col, col);
            }
        }

        private void delRows(DataGridView dgv, int count)
        {
            for (int i = 0; i < count; i++)
            {
                dgv.Rows.RemoveAt(dgv.Rows.Count - 1);
            }
        }

        private void delCols(DataGridView dgv, int count)
        {
            for (int i = 0; i < count; i++)
            {
                dgv.Columns.RemoveAt(dgv.Columns.Count - 1);
            }
        }

        private void addItems(ComboBox cmbx, int count)
        {
            for (int i = 0; i < count; i++)
            {
                cmbx.Items.Add((cmbx.Items.Count + 1).ToString());
            }
        }

        private void delItems(ComboBox cmbx, int count)
        {
            for (int i = 0; i < count; i++)
            {
                cmbx.Items.RemoveAt(cmbx.Items.Count - 1);
            }
        }

        //проверка чекбоксов для операций с одной матрицей
        private void CheckSizes()
        {
            //саррюс требует квадратную матрицу
            if ((mtr1row.Value == mtr1col.Value) && (mtr1row.Value >= 3))
                chbx_определитель_саррюс.Enabled = true;
            else
            {
                chbx_определитель_саррюс.Enabled = false;
                chbx_определитель_саррюс.Checked = false;
            }
        }

        //проверка на доступность опции "умножение матриц"
        private void CheckMultiply()
        {
            if (cmbx_две_матр_действия_умножение.SelectedIndex == 0)
                if (mtr1col.Value == mtr2row.Value)
                    chbx_две_матр_действия_умножение.Enabled = true;
                else
                {
                    chbx_две_матр_действия_умножение.Enabled = false;
                    chbx_две_матр_действия_умножение.Checked = false;
                }
            else
                if (mtr2col.Value == mtr1row.Value)
                    chbx_две_матр_действия_умножение.Enabled = true;
                else
                {
                    chbx_две_матр_действия_умножение.Enabled = false;
                    chbx_две_матр_действия_умножение.Checked = false;
                }
        }

        //проверка чекбоксов для операций с двумя матрицами
        private void CheckBothSizes()
        {
            //сложение и вычитаение требуют одинаковых размеров
            if ((mtr1row.Value == mtr2row.Value) && (mtr1col.Value == mtr2col.Value))
            {
                chbx_две_матр_действия_сложение.Enabled = true;
                chbx_две_матр_действия_вычитание.Enabled = true;
            }
            else
            {
                chbx_две_матр_действия_сложение.Enabled = false;
                chbx_две_матр_действия_сложение.Checked = false;

                chbx_две_матр_действия_вычитание.Enabled = false;
                chbx_две_матр_действия_вычитание.Checked = false;
            }

            //умножение требует проверки второй и первой размерности множителей
            CheckMultiply();
        }

        private void mtr1row_changed(object sender, EventArgs e)
        {
            if (mtr1row.Value > dgv_mtr1.Rows.Count)
                addRows(dgv_mtr1, Convert.ToInt32(mtr1row.Value) - dgv_mtr1.Rows.Count);
            else
                delRows(dgv_mtr1, dgv_mtr1.Rows.Count - Convert.ToInt32(mtr1row.Value));

            if (mtr1row.Value > cmbx_определитель_разложение_строка.Items.Count)
                addItems(cmbx_определитель_разложение_строка, Convert.ToInt32(mtr1row.Value) - cmbx_определитель_разложение_строка.Items.Count);
            else
                delItems(cmbx_определитель_разложение_строка, cmbx_определитель_разложение_строка.Items.Count - Convert.ToInt32(mtr1row.Value));

            if(mtr1row.Value > cmbx_определитель_лаплас.Items.Count)
                addItems(cmbx_определитель_лаплас, Convert.ToInt32(mtr1row.Value) - cmbx_определитель_лаплас.Items.Count);
            else
                delItems(cmbx_определитель_лаплас, cmbx_определитель_лаплас.Items.Count - Convert.ToInt32(mtr1row.Value));

            if (mtr1row.Value > cmbx_определитель_лаплас_2.Items.Count)
                addItems(cmbx_определитель_лаплас_2, Convert.ToInt32(mtr1row.Value) - cmbx_определитель_лаплас_2.Items.Count);
            else
                delItems(cmbx_определитель_лаплас_2, cmbx_определитель_лаплас_2.Items.Count - Convert.ToInt32(mtr1row.Value));

            CheckSizes();
            if (chbx_две_матр.Checked == true)
                CheckBothSizes();
        }

        private void mtr1col_changed(object sender,EventArgs e)
        {
            if (mtr1col.Value > dgv_mtr1.Columns.Count)
                addCols(dgv_mtr1, Convert.ToInt32(mtr1col.Value) - dgv_mtr1.Columns.Count);
            else
                delCols(dgv_mtr1, dgv_mtr1.Columns.Count - Convert.ToInt32(mtr1col.Value));

            if (mtr1col.Value > cmbx_определитель_разложение_столбец.Items.Count)
                addItems(cmbx_определитель_разложение_столбец, Convert.ToInt32(mtr1col.Value) - cmbx_определитель_разложение_столбец.Items.Count);
            else
                delItems(cmbx_определитель_разложение_столбец, cmbx_определитель_разложение_столбец.Items.Count - Convert.ToInt32(mtr1col.Value));

            CheckSizes();
            if (chbx_две_матр.Checked == true)
                CheckBothSizes();
        }

        private void mtr2row_changed(object sender, EventArgs e)
        {
            if (mtr2row.Value > dgv_mtr2.Rows.Count)
                addRows(dgv_mtr2, Convert.ToInt32(mtr2row.Value) - dgv_mtr2.Rows.Count);
            else
                delRows(dgv_mtr2, dgv_mtr2.Rows.Count - Convert.ToInt32(mtr2row.Value));

            CheckBothSizes();
        }

        private void mtr2col_changed(object sender, EventArgs e)
        {
            if (mtr2col.Value > dgv_mtr2.Columns.Count)
                addCols(dgv_mtr2, Convert.ToInt32(mtr2col.Value) - dgv_mtr2.Columns.Count);
            else
                delCols(dgv_mtr2, dgv_mtr2.Columns.Count - Convert.ToInt32(mtr2col.Value));

            CheckBothSizes();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            string result = "";

            //считывание первой матрицы
            int[,] A = new int[dgv_mtr1.Rows.Count, dgv_mtr1.Columns.Count];
            try
            {
                ReadMatr(dgv_mtr1, A);
            }
            catch
            {
                MessageBox.Show("Ошибка при считывании первой матрицы", "Ошибка матрицы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //считывание второй матрицы
            int[,] B = new int[dgv_mtr2.Rows.Count, dgv_mtr2.Columns.Count];
            if (chbx_две_матр.Checked == true)
            {
                try
                {
                    ReadMatr(dgv_mtr2, B);
                }
                catch
                {
                    MessageBox.Show("Ошибка при считывании второй матрицы", "Ошибка матрицы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            
            //вызов соответствующих процедур
            foreach (Control panel_control in splitContainerMatrix.Panel2.Controls)
                if (panel_control is GroupBox)
                    switch (panel_control.Name)
                    {
                        case "gbx_две_матр_действия":
                            if (chbx_две_матр.Checked == true)
                                foreach (Control group_control in panel_control.Controls)
                                    if ((group_control is CheckBox) && ((CheckBox)group_control).Checked)
                                    {
                                        string function = group_control.Name.Substring(5);
                                        Type matr_utils = typeof(MatrixUtils);
                                        MethodInfo method = matr_utils.GetMethod(function);

                                        Control[] controls = Controls.Find("cmbx_" + function, true);
                                        if (controls.Count() == 0)
                                            result += (string)method.Invoke(this, new object[] { A, B, this.chbx_details.Checked });
                                        else
                                            //тут проверка на выбранный индекс
                                            if (((ComboBox)controls[0]).SelectedIndex == 1)
                                            result += (string)method.Invoke(this, new object[] { B, A, this.chbx_details.Checked });
                                        else
                                            result += (string)method.Invoke(this, new object[] { A, B, this.chbx_details.Checked });
                                    }
                            break;
                        default:
                            foreach (Control group_control in panel_control.Controls)
                                if ((group_control is CheckBox) && ((CheckBox)group_control).Checked)
                                {
                                    string function = group_control.Name.Substring(5);
                                    Type matr_utils = typeof(MatrixUtils);
                                    MethodInfo method = matr_utils.GetMethod(function);

                                    Control[] controls = Controls.Find("cmbx_" + function, true);
                                    if (controls.Count() == 0)
                                        //MessageBox.Show(String.Format("Для чекбокса {0} не найден привязанный комбобокс", group_control.Name));
                                        result += (string)method.Invoke(this, new object[] { A, this.chbx_details.Checked });
                                    else
                                    {
                                        //вызов для одного или двух комбобоксов
                                        Control[] controls2 = Controls.Find("cmbx_" + function + "_2", true);
                                        if (controls2.Count() == 0)
                                            //один комбобокс
                                            //MessageBox.Show(String.Format("Для чекбокса {0} НАШЁЛСЯ привязанный комбобокс", group_control.Name));
                                            result += (string)method.Invoke(this, new object[] { A, ((ComboBox)controls[0]).SelectedIndex, this.chbx_details.Checked });
                                        else
                                            //два комбобокса
                                            result += (string)method.Invoke(this, new object[] { A, ((ComboBox)controls[0]).SelectedIndex, ((ComboBox)controls2[0]).SelectedIndex, this.chbx_details.Checked });
                                    }

                                }
                            break;
                    }

            string[] temp = result.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            //!очистка директории
            //!создание директории

            TexUtils.Render r1 = new TexUtils.Render(DirectoriesSettings.MatrixCalculatorPath);
            r1.StringToHTML(temp,"калькулятора матриц");
            //browser_results.Url = new Uri(String.Format("file:///{0}", r1.HTMLPath));
            browser_results.Navigate(String.Format("file:///{0}", r1.HTMLPath));
            settings.ApplyWebBrowserStyle(browser_results);
            //browser_results.Refresh();
        }

        private void ReadMatr(DataGridView dgv,int[,] matr)
        {
            for (int i = 0;i < dgv.Rows.Count;i++)
                for (int j = 0;j<dgv.Columns.Count;j++)
                {
                    matr[i, j] = Convert.ToInt32(dgv.Rows[i].Cells[j].Value);
                }
        }

        private void btn_show_panel2_Click(object sender, EventArgs e)
        {
            if (splitContainerMatrix.Panel2Collapsed == true)
                splitContainerMatrix.Panel2Collapsed = false;
            else
                splitContainerMatrix.Panel2Collapsed = true;
        }

        private void btn_show_hide_Click(object sender, EventArgs e)
        {

            if (splitContainerMatrix.Panel2Collapsed == true)
            {
                splitContainerMatrix.Panel2Collapsed = false;
                btn_show_hide.Text = "Скрыть операции";
            }
            else
            {
                splitContainerMatrix.Panel2Collapsed = true;
                btn_show_hide.Text = "Показать операции";
            }
        }

        private void chbx_две_матр_CheckedChanged(object sender, EventArgs e)
        {
            if (chbx_две_матр.Checked == true)
            {
                gbx_две_матр_действия.Enabled = true;
                splitContainer1.Panel2Collapsed = false;
                CheckBothSizes();
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
            }
            else
            {
                gbx_две_матр_действия.Enabled = false;
                splitContainer1.Panel2Collapsed = true;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }
        }

        private void cmbx_две_матр_действия_умножение_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckMultiply();
        }

        private void CopyMatrix(DataGridView from, DataGridView to)
        {
            int m = (from.Rows.Count > to.Rows.Count) ? to.Rows.Count : from.Rows.Count;
            int n = (from.Columns.Count > to.Columns.Count) ? to.Columns.Count : from.Columns.Count;

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    to.Rows[i].Cells[j].Value = from.Rows[i].Cells[j].Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CopyMatrix(dgv_mtr1, dgv_mtr2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CopyMatrix(dgv_mtr2, dgv_mtr1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> rows1 = new List<DataGridViewRow>();

            for (int i = 0; i < dgv_mtr1.Rows.Count; i++)
            {
                rows1.Add((DataGridViewRow)dgv_mtr1.Rows[i].Clone());
                for (int j = 0; j < dgv_mtr1.Rows[i].Cells.Count; j++)
                    rows1[i].Cells[j].Value = dgv_mtr1.Rows[i].Cells[j].Value;
            }

            List<DataGridViewRow> rows2 = new List<DataGridViewRow>();

            for (int i = 0; i < dgv_mtr2.Rows.Count; i++)
            {
                rows2.Add((DataGridViewRow)dgv_mtr2.Rows[i].Clone());
                for (int j = 0; j < dgv_mtr2.Rows[i].Cells.Count; j++)
                    rows2[i].Cells[j].Value = dgv_mtr2.Rows[i].Cells[j].Value;
            }

            dgv_mtr1.Columns.Clear();
            dgv_mtr1.Rows.Clear();

            dgv_mtr2.Columns.Clear();
            dgv_mtr2.Rows.Clear();

            addCols(dgv_mtr1, rows2[0].Cells.Count);
            foreach (DataGridViewRow row in rows2)
                dgv_mtr1.Rows.Add(row);
            mtr1row.Value = Convert.ToDecimal(dgv_mtr1.Rows.Count);
            mtr1col.Value = Convert.ToDecimal(dgv_mtr1.Columns.Count);

            addCols(dgv_mtr2, rows1[0].Cells.Count);
            foreach (DataGridViewRow row in rows1)
                dgv_mtr2.Rows.Add(row);
            mtr2row.Value = Convert.ToDecimal(dgv_mtr2.Rows.Count);
            mtr2col.Value = Convert.ToDecimal(dgv_mtr2.Columns.Count);
        }
    }
}
