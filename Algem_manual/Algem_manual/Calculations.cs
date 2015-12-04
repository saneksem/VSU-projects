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

            /*
            /begin { array} (lllll)\(
                1&2&3&4&5\\
            ...
            /)/End { array }*/
            /*int[,] mtr = new int[2, 2];
            mtr[0, 0] = 1;
            mtr[0, 1] = 2;
            mtr[1, 0] = 3;
            mtr[1, 1] = 4;
            dgv_mtr1.DataSource = mtr;*/
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
            int[,] A = new int[dgv_mtr1.Rows.Count, dgv_mtr1.Columns.Count];
            ReadMatr(dgv_mtr1, A);

            //Определитель
            if (chbx_определитель_разложение_строка.Checked)
                tbx_output.Text += "";
            if (chbx_определитель_разложение_столбец.Checked)
                tbx_output.Text += "";
            if (chbx_определитель_лаплас.Checked)
                tbx_output.Text += "";
            if (chbx_определитель_саррюс.Checked)
                tbx_output.Text += DetMatrix(A);

            //Ранг
            if (chbx_ранг.Checked)
                tbx_output.Text += RankMatrix(A);

            //Обратная матрица
            if (chbx_обратная_матрица_приписывание.Checked)
                tbx_output.Text += "";
            if (chbx_обратная_матрица_алг_дополнение.Checked)
                tbx_output.Text += "";

            //СЛУ
            if (chbx_слу_крит_совместности.Checked)
                tbx_output.Text += "";
            if (chbx_слу_гаусс.Checked)
                tbx_output.Text += "";

            //Несколько матриц
            int[,] B = new int[dgv_mtr2.Rows.Count, dgv_mtr2.Columns.Count];
            ReadMatr(dgv_mtr2, B);

            if (gbx_две_матр_действия_сложение.Checked)
                tbx_output.Text += AddMatrix(A, B);
            if (gbx_две_матр_действия_вычитание.Checked)
                tbx_output.Text += SubMatrix(A, B);
            if (gbx_две_матр_действия_умножение.Checked)
                tbx_output.Text += MultMatrix(A, B);

            MessageBox.Show("Готово!");
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

        //calculators
        public static string DetMatrix(int[,] Matr)
        {
            StringBuilder Result = new StringBuilder();
            int det = 0;
            det = Matr[0, 0] * Matr[1, 1] * Matr[2, 2] + Matr[0, 1] * Matr[1, 2] * Matr[2, 0] + Matr[0, 2] * Matr[1, 0] * Matr[2, 1] - Matr[0, 2] * Matr[1, 1] * Matr[2, 0] - Matr[0, 0] * Matr[1, 2] * Matr[2, 1] - Matr[0, 1] * Matr[1, 0] * Matr[2, 2];
            Result.Append(Matr[0, 0] + "*" + Matr[1, 1] + "*" + Matr[2, 2] + " + " + Matr[0, 1] + "*" + Matr[1, 2] + "*" + Matr[2, 0] + " + " + Matr[0, 2] + "*" + Matr[1, 0] + "*" + Matr[2, 1] + " - " + Matr[0, 2] + "*" + Matr[1, 1] + "*" + Matr[2, 0] + " - " + Matr[0, 0] + "*" + Matr[1, 2] + "*" + Matr[2, 1] + " - " + Matr[0, 1] + "*" + Matr[1, 0] + "*" + Matr[2, 2] + " = ")
                  .Append(Matr[0, 0] * Matr[1, 1] * Matr[2, 2] + " + " + Matr[0, 1] * Matr[1, 2] * Matr[2, 0] + " + " + Matr[0, 2] * Matr[1, 0] * Matr[2, 1] + " - " + Matr[0, 2] * Matr[1, 1] * Matr[2, 0] + " - " + Matr[0, 0] * Matr[1, 2] * Matr[2, 1] + " - " + Matr[0, 1] * Matr[1, 0] * Matr[2, 2] + " = ")
                  .Append(det)
                  .Append(Environment.NewLine);

            return Result.ToString();
        }

        public static string AddMatrix(int[,] Matr1, int[,] Matr2)
        {
            int CountLines = Matr1.GetLength(0), CountCols = Matr1.GetLength(1);
            StringBuilder Result = new StringBuilder();

            for (int i = 0; i < CountLines; i++)
            {
                for (int j = 0; j < CountCols; j++)
                    Result.Append(Matr1[i, j] + Matr2[i, j] + " ");
                Result.Append(Environment.NewLine);
            }
            return Result.ToString();
        }

        public static string SubMatrix(int[,] Matr1, int[,] Matr2)
        {
            int CountLines = Matr1.GetLength(0), CountCols = Matr1.GetLength(1);
            StringBuilder Result = new StringBuilder();

            for (int i = 0; i < CountLines; i++)
            {
                for (int j = 0; j < CountCols; j++)
                    Result.Append(Matr1[i, j] - Matr2[i, j] + " ");
                Result.Append(Environment.NewLine);
            }
            return Result.ToString();
        }

        public static string MultMatrix(int[,] Matr1, int[,] Matr2)
        {
            int CountLines1 = Matr1.GetLength(0), CountCols1 = Matr1.GetLength(1),
             CountLines2 = Matr2.GetLength(0), CountCols2 = Matr2.GetLength(1);
            if (CountLines2 != CountCols1)
                return null;
            StringBuilder Result = new StringBuilder();

            for (int i = 0; i < CountLines1; i++)
            {
                for (int j = 0; j < CountCols2; j++)
                {
                    int Current = 0;
                    for (int k = 0; k < CountCols1; k++)
                        Current += Matr1[i, k] * Matr2[k, j];
                    Result.Append(Current + " ");
                }
                Result.Append(Environment.NewLine);
            }
            return Result.ToString();
        }

        //------------------------------Вспомогательные функции для вычисления ранга------------------------------//

        static void SwapLines(double[,] Matr, int L1, int L2)
        {
            int CountCols = Matr.GetLength(1);
            for (int j = 0; j < CountCols; j++)
            {
                double tmp = Matr[L1, j];
                Matr[L1, j] = Matr[L2, j];
                Matr[L2, j] = tmp;
            }
        }

        static void SwapCols(double[,] Matr, int C1, int C2)
        {
            int CountLines = Matr.GetLength(0);
            for (int i = 0; i < CountLines; i++)
            {
                double tmp = Matr[i, C1];
                Matr[i, C1] = Matr[i, C2];
                Matr[i, C2] = tmp;
            }
        }

        static void CastString(double[,] Matr, int IndexSourceString, int IndexStr, int BeginIndex)
        {
            double tmp = -Matr[IndexStr, BeginIndex] / Matr[IndexSourceString, BeginIndex];
            int CountCols = Matr.GetLength(1);
            for (int i = 0; i < CountCols; i++)
                Matr[IndexStr, i] += tmp * Matr[IndexSourceString, i];
        }

        static void FindMaxAbs(double[,] Matr, int BeginIndexForFind, ref int Line, ref int Col)
        {
            int CountLines = Matr.GetLength(0);
            int CountCols = Matr.GetLength(1);
            double MaxAbs = Math.Abs(Matr[BeginIndexForFind, BeginIndexForFind]), Abs;
            for (int i = BeginIndexForFind; i < CountLines; i++)
                for (int j = BeginIndexForFind + 1; j < CountCols; j++)
                    if ((Abs = Math.Abs(Matr[i, j])) > MaxAbs)
                    {
                        MaxAbs = Abs;
                        Line = i;
                        Col = j;
                    }
        }

        public static string RankMatrix(int[,] Matr)
        {
            int CountLines = Matr.GetLength(0), CountCols = Matr.GetLength(1);
            double[,] HelpMatr = new double[CountLines, CountCols];
            for (int i = 0; i < CountLines; i++)
                for (int j = 0; j < CountCols; j++)
                    HelpMatr[i, j] = Matr[i, j];

            int LineMaxAbs = 0, ColMaxAbs = 0, BeginIndex = -1;
            for (int i = 0; i < CountLines; i++)
            {
                FindMaxAbs(HelpMatr, ++BeginIndex, ref LineMaxAbs, ref ColMaxAbs);
                SwapLines(HelpMatr, BeginIndex, LineMaxAbs);
                SwapCols(HelpMatr, BeginIndex, ColMaxAbs);

                if (HelpMatr[LineMaxAbs, ColMaxAbs] == 0)
                    return BeginIndex.ToString();
                else
                    for (int j = BeginIndex + 1; j < CountLines; j++)
                        if (HelpMatr[j, BeginIndex] != 0)
                            CastString(HelpMatr, i, j, BeginIndex);
            }
            return CountLines.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] temp = new int[dgv_mtr1.Rows.Count, dgv_mtr1.Columns.Count];
            ReadMatr(dgv_mtr1, temp);
            tbx_output.Text = DetMatrix(temp);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[,] temp1 = new int[dgv_mtr1.Rows.Count, dgv_mtr1.Columns.Count];
            ReadMatr(dgv_mtr1, temp1);
            int[,] temp2 = new int[dgv_mtr2.Rows.Count, dgv_mtr2.Columns.Count];
            ReadMatr(dgv_mtr2, temp2);
            tbx_output.Text = AddMatrix(temp1, temp2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[,] temp1 = new int[dgv_mtr1.Rows.Count, dgv_mtr1.Columns.Count];
            ReadMatr(dgv_mtr1, temp1);
            int[,] temp2 = new int[dgv_mtr2.Rows.Count, dgv_mtr2.Columns.Count];
            ReadMatr(dgv_mtr2, temp2);
            tbx_output.Text = SubMatrix(temp1, temp2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[,] temp1 = new int[dgv_mtr1.Rows.Count, dgv_mtr1.Columns.Count];
            ReadMatr(dgv_mtr1, temp1);
            int[,] temp2 = new int[dgv_mtr2.Rows.Count, dgv_mtr2.Columns.Count];
            ReadMatr(dgv_mtr2, temp2);
            tbx_output.Text = MultMatrix(temp1, temp2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[,] temp = new int[dgv_mtr1.Rows.Count, dgv_mtr1.Columns.Count];
            ReadMatr(dgv_mtr1, temp);
            tbx_output.Text = RankMatrix(temp);
        }

        private void btn_определитель_Click(object sender, EventArgs e)
        {
            gbx_определитель.Height = 20;
        }
    }
}
