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
        public Calculations()
        {
            InitializeComponent();

            splitContainerMatrix.Panel2Collapsed = true;
            string col = "";
            dgv_mtr1.Columns.Add(col, col);
            dgv_mtr1.Columns.Add(col, col);
            dgv_mtr1.Rows.Add(2);

            dgv_mtr2.Columns.Add(col, col);
            dgv_mtr2.Columns.Add(col, col);
            dgv_mtr2.Rows.Add(2);
        }

        private void mtr_index_changed(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString()+Environment.NewLine+e.ToString());
        }

        private void addRows(DataGridView dgv, int count)
        {
            for (int i=0;i<count;i++)
            {
                dgv.Rows.Add();
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

        private void mtr1row_changed(object sender, EventArgs e)
        {
            if (mtr1row.Value > dgv_mtr1.Rows.Count)
                addRows(dgv_mtr1, Convert.ToInt32(mtr1row.Value) - dgv_mtr1.Rows.Count);
            else
                delRows(dgv_mtr1, dgv_mtr1.Rows.Count - Convert.ToInt32(mtr1row.Value));
        }

        private void mtr1col_changed(object sender,EventArgs e)
        {
            if (mtr1col.Value > dgv_mtr1.Columns.Count)
                addCols(dgv_mtr1, Convert.ToInt32(mtr1col.Value) - dgv_mtr1.Columns.Count);
            else
                delCols(dgv_mtr1, dgv_mtr1.Columns.Count - Convert.ToInt32(mtr1col.Value));
        }

        private void mtr2row_changed(object sender, EventArgs e)
        {
            if (mtr2row.Value > dgv_mtr2.Rows.Count)
                addRows(dgv_mtr2, Convert.ToInt32(mtr2row.Value) - dgv_mtr2.Rows.Count);
            else
                delRows(dgv_mtr2, dgv_mtr2.Rows.Count - Convert.ToInt32(mtr2row.Value));
        }

        private void mtr2col_changed(object sender, EventArgs e)
        {
            if (mtr2col.Value > dgv_mtr2.Columns.Count)
                addCols(dgv_mtr2, Convert.ToInt32(mtr2col.Value) - dgv_mtr2.Columns.Count);
            else
                delCols(dgv_mtr2, dgv_mtr2.Columns.Count - Convert.ToInt32(mtr2col.Value));
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            string result = "";
            //tbx_output.Text = result;

            //действия с одной матрицей
            int[,] A = new int[dgv_mtr1.Rows.Count, dgv_mtr1.Columns.Count];
            ReadMatr(dgv_mtr1, A);

            foreach (Control panel_control in splitContainerMatrix.Panel1.Controls)
                if (panel_control is GroupBox)
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
                                //MessageBox.Show(String.Format("Для чекбокса {0} НАШЁЛСЯ привязанный комбобокс", group_control.Name));
                                result += (string)method.Invoke(this, new object[] { A, ((ComboBox)controls[0]).SelectedIndex, this.chbx_details.Checked });
                        }

            //действия с двумя матрицами
            int[,] B = new int[dgv_mtr2.Rows.Count, dgv_mtr2.Columns.Count];
            ReadMatr(dgv_mtr2, B);

            foreach (Control panel_control in splitContainerMatrix.Panel2.Controls)
                if (panel_control is GroupBox)
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

            //tbx_output.Text += result;
            string[] temp = result.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            TexUtils.Render r1 = new TexUtils.Render("matrix_calc");
            r1.StringToHTML(temp);
            browser_results.Url = new Uri(String.Format("file:///{0}", r1.HTMLPath));
            browser_results.Refresh();
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

        private void show_hide_groupbox(object sender, EventArgs e)
        {
            GroupBox parent = (GroupBox)((Button)sender).Parent;
            if (parent.Height == 23)
                parent.Height = 100;
            else
                parent.Height = 23;
        }

        private void btn_show_hide_Click(object sender, EventArgs e)
        {
            if (splitContainerMatrix.Height > 0)
                splitContainerMatrix.Height = 0;
            else
                splitContainerMatrix.Height = 372;
        }
    }
}
