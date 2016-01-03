using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algem_manual
{
    static class MatrixUtils
    {
        //для лапласа
        public static StringBuilder getStr(double[,] matr)
        {
            int n = matr.GetLength(0);
            string CountCol = String.Concat(Enumerable.Repeat("c", n));
            StringBuilder CurString = new StringBuilder();
            StringBuilder Result = new StringBuilder();
            CurString.Append(@"\left|\begin{array}{" + CountCol + "} ");
            CurString.Append(@"\\");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    CurString.Append(matr[i, j] + @"& ");
                CurString.Append(@"\\");
            }
            CurString.Append(@"\end{array}\right|");
            Result.Append(CurString.ToString());
            CurString.Clear();
            return Result;

        }
        public static double DetRec(double[,] matrix, ref StringBuilder str, int k1, int k2, int n)
        {

            if (matrix.Length == 4)
            {
                return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            }
            if (matrix.Length == 1)
            {
                return matrix[0, 0];
            }


            double result = 0;
            int nowN = matrix.GetLength(0);
            double countSum = (int)knownBin(2, nowN);
            if (nowN != n)
            {
                k1 = 0;
                k2 = 1;
            }
            List<String> list = new List<String>();
            list.Clear();
            int[] a = new int[2];
            p1(0, 0, nowN, a, list);
            int sign = 0;
            List<int[]> listmas = strToArr(list);
            for (int i = 0; i < countSum; i++)
            {
                if (listmas.Count != countSum)
                {
                    list.Clear();
                    p1(0, 0, nowN, a, list);
                    listmas = strToArr(list);
                }
                int[] column = listmas[i];
                double[,] dopMinor = getDopMinor(column, matrix, nowN, k1, k2);
                double detDopMinor = DetRec(dopMinor, ref str, k1, k2, n);
                double[,] minor = getMinor(column, matrix, k1, k2);
                double detMinor = DetRec(minor, ref str, k1, k2, n);
                sign = k1 + k2 + column[0] + column[1];
                if (sign % 2 == 0)
                    sign = 1;
                else
                    sign = -1;
                str.Append(getStr(minor).ToString() + @"\cdot");
                string signText = "" + k1 + " + " + k2 + " + " + column[0] + " + " + column[1];
                string row;
                row = @"(- 1)^{ " + signText + @"}";
                str.Append(row);
                str.Append(@"\cdot" + getStr(dopMinor).ToString());
                if (i + 1 != countSum)
                    str.Append("  +  ");
                if (i % 2 == 0)
                {
                    str.Append(@"$$");
                    str.Append(Environment.NewLine);
                    str.Append(@"$$");
                }

                result += sign * detMinor * detDopMinor;
            }
            return result;
        }
        private static double[,] getMinor(int[] col, double[,] matrix, int k1, int k2)
        {
            double[,] newMatr = new double[2, 2];
            for (int j = 0; j < 2; j++)
            {
                newMatr[0, j] = matrix[k1, col[j]];
            }
            for (int j = 0; j < 2; j++)
            {
                newMatr[1, j] = matrix[k2, col[j]];
            }
            return newMatr;

        }
        private static double[,] getDopMinor(int[] col, double[,] matrix, int n, int k1, int k2)
        {
            List<int> rows = new List<int>();
            List<int> colum = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if ((i == k1) || (i == k2))
                    continue;
                rows.Add(i);
            }
            for (int i = 0; i < n; i++)
            {
                if ((i == col[0]) || (i == col[1]))
                    continue;
                colum.Add(i);
            }
            int newN = n - 2;
            double[,] newMatr = new double[newN, newN];
            for (int i = 0; i < newN; i++)
            {
                for (int j = 0; j < newN; j++)
                {
                    newMatr[i, j] = matrix[rows[i], colum[j]];
                }
            }

            return newMatr;


        }
        private static double knownBin(int k, int nn)
        {

            if (k > nn)
                return 0;
            else
            {
                return Factorial(nn) / Factorial(k) / Factorial(nn - k);
            }
        }
        static long Factorial(int x)
        {
            return (x == 0) ? 1 : x * Factorial(x - 1);
        }
        public static void p1(int pos, int maxUsed, int nn, int[] a, List<String> list)
        {

            if (pos == 2)
            {
                list.Add(arrToStr(a));
            }
            else
            {
                for (int i = maxUsed + 1; i <= nn; i++)
                {
                    a[pos] = i;
                    p1(pos + 1, i, nn, a, list);
                }
            }
        }
        private static string arrToStr(int[] mas)
        {
            string str = "";
            foreach (int a in mas)
            {
                str += a.ToString();
            }
            return str;
        }
        public static List<int[]> strToArr(List<String> list)
        {
            List<int[]> listmas = new List<int[]>();
            listmas.Clear();
            foreach (string str in list)
            {
                int[] a = new int[str.Length];
                for (int i = 0; i < str.Length; i++)
                {
                    a[i] = (int)Char.GetNumericValue(str[i]) - 1;
                }
                listmas.Add(a);
            }
            return listmas;
        }
        //конец для лапласа

        public static string определитель_лаплас(int[,] matr1, int k1, int k2, bool flag)
        {
            int n = matr1.GetLength(0);
            double[,] matr = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matr[i, j] = (double)matr1[i, j];
                }
            }

            StringBuilder CurString = new StringBuilder();
            StringBuilder Result = new StringBuilder();
            Result.Append("Определитель матрицы по общей теореме Лапласа по " + (k1 + 1).ToString() + " и " + (k2 + 1).ToString() + " строкам равен:" + Environment.NewLine + Environment.NewLine);
            if (!flag)
            {
                Result.Append("$$");
                Result.Append(getStr(matr));
                Result.Append(" =" + DetRec(matr, ref CurString, k1, k2, n) + " $$");
                Result.Append(Environment.NewLine);
                Result.Append(Environment.NewLine);
                return Result.ToString();
            }
            else
            {
                CurString.Append("$$");
                double res = DetRec(matr, ref CurString, k1, k2, n);
                Result.Append("$$");
                Result.Append(getStr(matr).ToString() + " = $$");
                Result.Append(CurString.ToString());
                Result.Append(" = " + res + "$$");
                Result.Append(Environment.NewLine);
                Result.Append(Environment.NewLine);
                return Result.ToString();
            };
        }

        public static string обратная_матрица_приписывание(int[,] Matr, bool flag)
        {
            string str = "";
            int Size = Matr.GetLength(0);
            double[,] help = new double[Size, Size];
            double[,] res = new double[Size, Size];
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (i == j)
                    {
                        res[i, j] = 1;
                    }
                    else
                    {
                        res[i, j] = 0;
                    }
                }
            }


            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    help[i, j] = (double)Matr[i, j];
                }
            }
            if (flag)
            {
                str += @"Шаг 1: Приписываем к исходной матрице справа единичную матрицу, получаем $$A=\left(\begin{array}{ccc}";
                for (int i = 0; i < Size; i++)
                {
                    for (int j = 0; j < Size - 1; j++)
                    {
                        str += Convert.ToString(Math.Round(help[i, j], 2)) + " & ";
                    }
                    str += Convert.ToString(Math.Round(help[i, Size - 1], 2)) + " ";
                    str += "\\" + "\\ ";
                }
                str += @"\end{array}$$ $$\left|\begin{array}{ccc}";
                for (int i = 0; i < Size; i++)
                {
                    for (int j = 0; j < Size - 1; j++)
                    {
                        str += Convert.ToString(Math.Round(res[i, j], 2)) + " & ";
                    }
                    str += Convert.ToString(Math.Round(help[i, Size - 1], 2)) + " ";
                    str += "\\" + "\\ ";
                }
                str += @"\end{array}\right)$$" + Environment.NewLine + Environment.NewLine;

            }

            double buf;
            try
            {
                for (int i = 0; i < Size; i++)
                {
                    buf = help[i, i];
                    for (int j = Size - 1; j >= i; j--)
                    {
                        help[i, j] /= buf;
                    }
                    for (int k = 0; k < Size; k++)
                    {
                        res[i, k] /= buf;
                    }
                    for (int j = i + 1; j < Size; j++)
                    {
                        buf = help[j, i];
                        for (int k = Size - 1; k >= i; k--)
                            help[j, k] -= buf * help[i, k];
                        for (int k = 0; k < Size; k++)
                            res[j, k] -= buf * res[i, k];
                    }
                }
                if (flag)
                {
                    str += @"Шаг 2: Приводим матрицу A к верхнетреугольному виду с помощью элементарных преобраований, получаем $$A=\left(\begin{array}{ccc}";
                    for (int i = 0; i < Size; i++)
                    {
                        for (int j = 0; j < Size - 1; j++)
                        {
                            str += Convert.ToString(Math.Round(help[i, j], 2)) + " & ";
                        }
                        str += Convert.ToString(Math.Round(help[i, Size - 1], 2)) + " ";
                        str += "\\" + "\\ ";
                    }
                    str += @"\end{array}$$ $$\left|\begin{array}{ccc}";
                    for (int i = 0; i < Size; i++)
                    {
                        for (int j = 0; j < Size - 1; j++)
                        {
                            str += Convert.ToString(Math.Round(res[i, j], 2)) + " & ";
                        }
                        str += Convert.ToString(Math.Round(help[i, Size - 1], 2)) + " ";
                        str += "\\" + "\\ ";
                    }
                    str += @"\end{array}\right)$$" + Environment.NewLine + Environment.NewLine;
                }
                for (int kk = Size - 1; kk > 0; kk--)
                {
                    help[kk, Size - 1] /= help[kk, kk];
                    res[kk, Size - 1] /= help[kk, kk];

                    for (int i = kk - 1; i + 1 > 0; i--)
                    {
                        double multi2 = help[i, kk];
                        for (int j = 0; j < Size; j++)
                        {
                            help[i, j] -= multi2 * help[kk, j];
                            res[i, j] -= multi2 * res[kk, j];
                        }
                    }
                }
                if (flag)
                {
                    str += @"Шаг 3: Приводим матрицу A к единчной матрице виду с помощью элементарных преобраований. Таким образом, справа, на месте единичной матрицы, была получена обратная матрица.
                    $$A=\left(\begin{array}{ccc}";
                    for (int i = 0; i < Size; i++)
                    {
                        for (int j = 0; j < Size - 1; j++)
                        {
                            str += Convert.ToString(Math.Round(help[i, j], 2)) + " & ";
                        }
                        str += Convert.ToString(Math.Round(help[i, Size - 1], 2)) + " ";
                        str += "\\" + "\\ ";
                    }
                    str += @"\end{array}$$ $$\left|\begin{array}{ccc}";
                    for (int i = 0; i < Size; i++)
                    {
                        for (int j = 0; j < Size - 1; j++)
                        {
                            str += Convert.ToString(Math.Round(res[i, j], 2)) + " & ";
                        }
                        str += Convert.ToString(Math.Round(help[i, Size - 1], 2)) + " ";
                        str += "\\" + "\\ ";
                    }
                    str += @"\end{array}\right)$$" + Environment.NewLine + Environment.NewLine;
                }
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Обнаружено деление на 0");
            }
            str += @"Обратная матрица: $$A^{-1} = \left(\begin{array}{ccc}";
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size - 1; j++)
                {
                    str += Convert.ToString(Math.Round(res[i, j], 2)) + " & ";
                }
                str += Convert.ToString(Math.Round(res[i, Size - 1], 2)) + " ";
                str += "\\" + "\\ ";
            }
            str += @"\end{array}\right)$$" + Environment.NewLine + Environment.NewLine;
            int p = 0;
            int q = 0;
            bool OK = true;
            while (p < Size && OK)
            {
                while (q < Size && OK)
                {
                    if ((double.IsNaN(res[p, q])) || Double.IsInfinity(res[p, q]))
                        OK = false;
                    q++;
                }
                p++;
            }
            if (OK)
                return str;
            else
                return "Не удалось найти обратную матрицу. Есть зависимые строки.";

        }

        public static string определитель_саррюс(int[,] Matr, bool ok)
        {
            StringBuilder Result = new StringBuilder();
            int det = 0;
            StringBuilder CurString = new StringBuilder();
            CurString.Append("Разложение определителя матрицы по правилу Саррюса: ");
            CurString.Append("$$");
            det = Matr[0, 0] * Matr[1, 1] * Matr[2, 2] + Matr[0, 1] * Matr[1, 2] * Matr[2, 0] + Matr[0, 2] * Matr[1, 0] * Matr[2, 1] - Matr[0, 2] * Matr[1, 1] * Matr[2, 0] - Matr[0, 0] * Matr[1, 2] * Matr[2, 1] - Matr[0, 1] * Matr[1, 0] * Matr[2, 2];
            if (ok)
            {
                CurString.Append(@"\left|\begin{array}{ссс}");
                CurString.Append(@"\fbox{" + Matr[0, 0] + @"} & \fbox{\fbox{" + Matr[0, 1] + @"}} & \fbox{\fbox{\fbox{" + Matr[0, 2] + @"}}} & ");
                CurString.Append(@"\\");
                CurString.Append(@Matr[1, 0] + @"& \fbox{" + Matr[1, 1] + @"} & \fbox{\fbox{" + Matr[1, 2] + @"}} ");
                CurString.Append(@"\\");
                CurString.Append(@Matr[2, 0] + @"& " + Matr[2, 1] + @"& \fbox{" + Matr[2, 2] + @"}");
                CurString.Append(@"\end{array}\right|");
                CurString.Append(@"\begin{array}{сс}");
                CurString.Append(Matr[0, 0] + @"& " + Matr[0, 1]);
                CurString.Append(@"\\");
                CurString.Append(@"\fbox{\fbox{\fbox{" + Matr[1, 0] + @"}}} & " + Matr[1, 1]);
                CurString.Append(@"\\");
                CurString.Append(@"\fbox{\fbox{" + Matr[2, 0] + @"}} & \fbox{\fbox{\fbox{" + Matr[2, 1] + "}}}");
                CurString.Append(@"\end{array} \ ");
                CurString.Append(Environment.NewLine);
                CurString.Append(Environment.NewLine);
                int det1 = Matr[0, 0] * Matr[1, 1] * Matr[2, 2] + Matr[0, 1] * Matr[1, 2] * Matr[2, 0] + Matr[0, 2] * Matr[1, 0] * Matr[2, 1];
                CurString.Append(@" = " + Matr[0, 0] + @"\cdot " + Matr[1, 1] + @"\cdot " + Matr[2, 2] + @" + " + Matr[0, 1] + @"\cdot " + Matr[1, 2] + @"\cdot " + Matr[2, 0] + @" + " + Matr[0, 2] + @"\cdot " + Matr[1, 0] + @"\cdot " + Matr[2, 1] + @" = " + det1 + " $$ ");
                CurString.Append(Environment.NewLine);
                CurString.Append(Environment.NewLine);
                CurString.Append(@"$$ \left|\begin{array}{ccc}");
                CurString.Append(@Matr[0, 0] + @"& " + Matr[0, 1] + @"& \fbox{" + Matr[0, 2] + @"}");
                CurString.Append(@"\\");
                CurString.Append(@Matr[1, 0] + @"& \fbox{" + Matr[1, 1] + @"} & \fbox{\fbox{" + Matr[1, 2] + @"}} ");
                CurString.Append(@"\\");
                CurString.Append(@"\fbox{" + Matr[2, 0] + @"} & \fbox{\fbox{" + Matr[2, 1] + @"}} & \fbox{\fbox{\fbox{" + Matr[2, 2] + @"}}}");
                CurString.Append(@"\end{array}\right|");
                CurString.Append(@"\begin{array}{cc}");
                CurString.Append(@"\fbox{\fbox{" + Matr[0, 0] + @"}} & \fbox{\fbox{\fbox{" + Matr[0, 1] + "}}}");
                CurString.Append(@"\\");
                CurString.Append(@"\fbox{\fbox{\fbox{" + Matr[1, 0] + @"}}} & " + Matr[1, 1]);
                CurString.Append(@"\\");
                CurString.Append(Matr[2, 0] + @"& " + Matr[2, 1]);
                CurString.Append(@"\end{array} \");
                CurString.Append(Environment.NewLine);
                CurString.Append(Environment.NewLine);
                int det2 = Matr[0, 2] * Matr[1, 1] * Matr[2, 0] + Matr[0, 0] * Matr[1, 2] * Matr[2, 1] + Matr[0, 1] * Matr[1, 0] * Matr[2, 2];
                CurString.Append(@" = " + Matr[0, 2] + @"\cdot " + Matr[1, 1] + @"\cdot " + Matr[2, 0] + @" + " + Matr[0, 0] + @"\cdot " + Matr[1, 2] + @"\cdot " + Matr[2, 1] + @" + " + Matr[0, 1] + @"\cdot " + Matr[1, 0] + @"\cdot " + Matr[2, 2] + @" = " + det2 + @" $$ ");
                CurString.Append(Environment.NewLine);
                CurString.Append(Environment.NewLine);
                int det3 = det1 - det2;
                CurString.Append(@"$$ |A| = " + det1 + @" - " + det2 + @" = " + det3);
            }
            else
                CurString.Append(@"$$ |A| = " + det);
            CurString.Append("$$");
            CurString.Append(Environment.NewLine);
            CurString.Append(Environment.NewLine);
            return CurString.ToString();
        }

        public static string определитель_разложение_строка(int[,] Matr, int row, bool ok)
        {
            //MessageBox.Show("строка:" + row);
            return DeterminantMain(Matr, row, true, ok);
        }

        public static string определитель_разложение_столбец(int[,] Matr, int column, bool ok)
        {
            //MessageBox.Show("столбец:" + column);
            return DeterminantMain(Matr, column, false, ok);
        }

        // ---------------------------------ранг
        public static string ранг(int[,] Matrix, bool flag)
        {
            CountRows = Matrix.GetLength(0);
            CountCols = Matrix.GetLength(1);
            StringBuilder Result = new StringBuilder();

            if (CountRows == 0 || CountCols == 0)
            {
                Result.Append("Ранг матрицы = 0");
                return Result.ToString();
            }

            if (CountRows == 1 || CountCols == 1)
            {
                Result.Append("Ранг матрицы = 1");
                return Result.ToString();
            }

            if (!flag)
            {
                ColumnExchanged = new bool[CountCols];

                double[,] HelpMatrix = new double[CountRows, CountCols];
                for (int k = 0; k < CountRows; k++)
                    for (int j = 0; j < CountCols; j++)
                        HelpMatrix[k, j] = Matrix[k, j];

                //Ищем количество проходов
                LastColumn = Math.Min(CountRows, CountCols) - 1;

                //Идём по всем нужным столбцам

                for (int i = 0; i < LastColumn; i++)
                {
                    //Проверяем что текущий диагональный элемент не равен 0
                    if (Math.Abs(HelpMatrix[i, i]) < Eps)
                        //Если он равен нулю, то ищем следующую строку, где элемент в позиции i не равен 0, и меняем их местами
                        if (TrySwapRows(HelpMatrix, (i)))
                        {
                            //Если нашли такую строку, то обнуляем столбец i
                            NullifyColumn(HelpMatrix, i);

                            //Вычёркиваем нулевые строки
                            DeleteRowsMatrix(ref HelpMatrix, i);
                        }
                        else
                            //Если не нашли такую строку, то меняем текущий столбец с последним столбцом, который ещё не участвовал в обмене
                            if (TrySwapColumns(HelpMatrix, i))
                            //Если текущий столбец не являлся последним, не учавствующим в обмене,
                            //то откатываемся назад(i больше, чем нужно на 1) и снова заходим в цикл
                            i--;
                        else
                            //Если текущий столбец - последний, не учавствующий в обмене, то завершаем цикл
                            break;
                    else
                    {
                        //Если текущий диагональный элемент не равен 0, то обнуляем столбец i
                        NullifyColumn(HelpMatrix, i);
                        //Вычёркиваем нулевые строки

                        DeleteRowsMatrix(ref HelpMatrix, i);
                    }
                }
                Result.Append("Ранг матрицы = ");
                //Рангом матрицы после преобразований будет являться минимум из количества столбцов и количества ненулевых cтрок
                //(которые предварительно вычеркнуты, поэтому - количества строк)
                Result.Append(Math.Min(HelpMatrix.GetLength(0), CountCols).ToString());
                Result.Append(Environment.NewLine + Environment.NewLine);
                return Result.ToString();
            }
            else
            {
                StringBuilder CurString = new StringBuilder();
                string CountCol = String.Concat(Enumerable.Repeat("c", CountCols));

                Result.Append("Вычисление ранга матрицы:" + Environment.NewLine + Environment.NewLine);

                ColumnExchanged = new bool[CountCols];

                double[,] HelpMatrix = new double[CountRows, CountCols];

                CurString.Append(@"$$\left(\begin{array}{" + CountCol + "}");
                for (int i = 0; i < CountRows; i++)
                {
                    for (int j = 0; j < CountCols; j++)
                    {
                        HelpMatrix[i, j] = Matrix[i, j];
                        if (j != 0)
                            CurString.Append("& ");
                        if (i == j)
                            CurString.Append(@"\fbox{" + Math.Round(HelpMatrix[i, j], 2) + "}");
                        else
                            CurString.Append(Math.Round(HelpMatrix[i, j], 2));
                    }
                    CurString.Append(@"\\");
                }
                CurString.Append(@"\end{array}\right)$$");

                CurString.Append(Environment.NewLine + Environment.NewLine);
                Result.Append(CurString.ToString());
                CurString.Clear();

                //Ищем количество проходов
                LastColumn = Math.Min(CountRows, CountCols) - 1;

                //Идём по всем нужным столбцам

                for (int i = 0; i < LastColumn; i++)
                {
                    //Проверяем что текущий диагональный элемент не равен 0
                    if (Math.Abs(HelpMatrix[i, i]) < Eps)
                        //Если он равен нулю, то ищем следующую строку, где элемент в позиции i не равен 0, и меняем их местами
                        if (TrySwapRows(HelpMatrix, i))
                        {

                            CurString.Append("Поменяем местами строки, т.к. на главной диагонали находится элемент равный нулю:" + Environment.NewLine + Environment.NewLine);
                            PrintHelpMatrix(ref CurString, CountCol, ref HelpMatrix);
                            CurString.Append(Environment.NewLine + Environment.NewLine);

                            //Если нашли такую строку, то обнуляем столбец i
                            NullifyColumn(HelpMatrix, i);

                            CurString.Append("Обнуляем элементы " + (i + 1) + "-го столбца, находящиеся ниже диагонального элемента (равного " + HelpMatrix[i, i] + "):" + Environment.NewLine + Environment.NewLine);
                            PrintHelpMatrix(ref CurString, CountCol, ref HelpMatrix);
                            CurString.Append(Environment.NewLine + Environment.NewLine);

                            if (DeleteRowsMatrix(ref HelpMatrix, i))
                            {
                                CurString.Append("Удалим нулевые строки:" + Environment.NewLine + Environment.NewLine);
                                PrintHelpMatrix(ref CurString, CountCol, ref HelpMatrix);
                                CurString.Append(Environment.NewLine + Environment.NewLine);
                            }

                            Result.Append(CurString.ToString());
                            CurString.Clear();
                        }
                        else
                            //Если не нашли такую строку, то меняем текущий столбец с последним столбцом, который ещё не участвовал в обмене
                            if (TrySwapColumns(HelpMatrix, i))
                        {
                            CurString.Append("Поменяем местами столбцы, т.к. на главной диагонали находится элемент равный нулю:" + Environment.NewLine + Environment.NewLine);
                            PrintHelpMatrix(ref CurString, CountCol, ref HelpMatrix);
                            CurString.Append(Environment.NewLine + Environment.NewLine);
                            Result.Append(CurString.ToString());
                            CurString.Clear();
                            //Если текущий столбец не являлся последним, не учавствующим в обмене,
                            //то откатываемся назад(i больше, чем нужно на 1) и снова заходим в цикл
                            i--;
                        }
                        else
                            //Если текущий столбец - последний, не учавствующий в обмене, то завершаем цикл
                            break;
                    else
                    {
                        //Если текущий диагональный элемент не равен 0, то обнуляем столбец i
                        NullifyColumn(HelpMatrix, i);

                        CurString.Append("Обнуляем элементы " + (i + 1) + "-го столбца, находящиеся ниже диагонального элемента (равного " + HelpMatrix[i, i] + "):" + Environment.NewLine + Environment.NewLine);
                        PrintHelpMatrix(ref CurString, CountCol, ref HelpMatrix);
                        CurString.Append(Environment.NewLine + Environment.NewLine);
                        if (DeleteRowsMatrix(ref HelpMatrix, i))
                        {
                            CurString.Append("Удалим нулевые строки:" + Environment.NewLine + Environment.NewLine);
                            PrintHelpMatrix(ref CurString, CountCol, ref HelpMatrix);
                            CurString.Append(Environment.NewLine + Environment.NewLine);
                        }
                        Result.Append(CurString.ToString());
                        CurString.Clear();
                    }

                }
                Result.Append("Ранг матрицы = ");
                //Рангом матрицы после преобразований будет являться минимум из количества столбцов и количества ненулевых cтрок
                //(которые предварительно вычеркнуты, поэтому - количества строк)
                Result.Append(Math.Min(HelpMatrix.GetLength(0), CountCols).ToString());
                Result.Append(Environment.NewLine + Environment.NewLine);
                return Result.ToString();
            }
        }

        public static string две_матр_действия_сложение(int[,] Matr1, int[,] Matr2, bool flag)
        {
            int CountLines = Matr1.GetLength(0), CountCols = Matr1.GetLength(1);
            string CountCol = String.Concat(Enumerable.Repeat("c", CountCols));
            StringBuilder Result = new StringBuilder();
            StringBuilder CurString = new StringBuilder();
            Result.Append("Результат сложения матриц:" + Environment.NewLine + Environment.NewLine);
            if (!flag)
            {
                CurString.Append(@"$$\left(\begin{array}{" + CountCol + "} ");
                for (int i = 0; i < CountLines; i++)
                {
                    CurString.Append(Matr1[i, 0] + Matr2[i, 0]);
                    for (int j = 1; j < CountCols; j++)
                        CurString.Append(@"& " + (Matr1[i, j] + Matr2[i, j]));
                    CurString.Append(@"\\");
                }
                CurString.Append(@"\end{array}\right)$$");
                CurString.Append(Environment.NewLine + Environment.NewLine);
                Result.Append(CurString.ToString());
                CurString.Clear();
                return Result.ToString();
            }
            else
            {
                //вывод выражение суммы исходных матриц

                CurString.Append(@"$$\left(\begin{array}{" + CountCol + "}");
                for (int i = 0; i < CountLines; i++)
                {
                    CurString.Append(Matr1[i, 0]);
                    for (int j = 1; j < CountCols; j++)
                        CurString.Append(@"& " + Matr1[i, j]);
                    CurString.Append(@"\\");
                }
                CurString.Append(@"\end{array}\right)+");

                CurString.Append(@"\left(\begin{array}{" + CountCol + "} ");
                for (int i = 0; i < CountLines; i++)
                {
                    CurString.Append(Matr2[i, 0]);
                    for (int j = 1; j < CountCols; j++)
                        CurString.Append(@"& " + Matr2[i, j]);
                    CurString.Append(@"\\");
                }
                CurString.Append(@"\end{array}\right)=");
                CurString.Append(Environment.NewLine + Environment.NewLine);
                Result.Append(CurString.ToString());
                CurString.Clear();
                /////////////////////////////////////////////////////////////////
                CurString.Append(@"\left(\begin{array}{" + CountCol + "} ");
                for (int i = 0; i < CountLines; i++)
                {
                    for (int j = 0; j < CountCols; j++)
                    {
                        if (j != 0)
                            CurString.Append(@"\;& ");
                        if (Matr2[i, j] < 0)
                            CurString.Append(Matr1[i, j] + @" + (" + Matr2[i, j] + ")");
                        else
                            CurString.Append(Matr1[i, j] + @" + " + Matr2[i, j]);
                    }
                    CurString.Append(@"\\");
                }
                CurString.Append(@"\end{array}\right)=");
                CurString.Append(Environment.NewLine + Environment.NewLine);
                Result.Append(CurString.ToString());
                CurString.Clear();
                ///////////////////////////////////////////////////////////////////
                CurString.Append(@"\left(\begin{array}{" + CountCol + "} ");
                for (int i = 0; i < CountLines; i++)
                {
                    CurString.Append(Matr1[i, 0] + Matr2[i, 0]);
                    for (int j = 1; j < CountCols; j++)
                        CurString.Append(@"& " + (Matr1[i, j] + Matr2[i, j]));
                    CurString.Append(@"\\");
                }
                CurString.Append(@"\end{array}\right)$$");
                CurString.Append(Environment.NewLine + Environment.NewLine);
                Result.Append(CurString.ToString());
                CurString.Clear();
                return Result.ToString();
            }
        }

        public static string две_матр_действия_вычитание(int[,] Matr1, int[,] Matr2, bool flag)
        {
            int CountLines = Matr1.GetLength(0), CountCols = Matr1.GetLength(1);
            StringBuilder CurString = new StringBuilder();
            string CountCol = String.Concat(Enumerable.Repeat("c", CountCols));
            StringBuilder Result = new StringBuilder();
            Result.Append("Результат вычитания матриц:" + Environment.NewLine + Environment.NewLine);
            if (!flag)
            {
                CurString.Append(@"$$\left(\begin{array}{" + CountCol + "} ");
                for (int i = 0; i < CountLines; i++)
                {
                    CurString.Append(Matr1[i, 0] - Matr2[i, 0]);
                    for (int j = 1; j < CountCols; j++)
                        CurString.Append(@"& " + (Matr1[i, j] - Matr2[i, j]));
                    CurString.Append(@"\\");
                }
                CurString.Append(@"\end{array}\right)$$");
                CurString.Append(Environment.NewLine + Environment.NewLine);
                Result.Append(CurString.ToString());
                CurString.Clear();
                return Result.ToString();
            }
            else
            {
                //вывод   исходных матриц
                CurString.Append(@"$$\left(\begin{array}{" + CountCol + "}");
                for (int i = 0; i < CountLines; i++)
                {
                    CurString.Append(Matr1[i, 0]);
                    for (int j = 1; j < CountCols; j++)
                        CurString.Append(@"& " + Matr1[i, j]);
                    CurString.Append(@"\\");
                }
                CurString.Append(@"\end{array}\right)-");

                CurString.Append(@"\left(\begin{array}{" + CountCol + "} ");
                for (int i = 0; i < CountLines; i++)
                {
                    CurString.Append(Matr2[i, 0]);
                    for (int j = 1; j < CountCols; j++)
                        CurString.Append(@"& " + Matr2[i, j]);
                    CurString.Append(@"\\");
                }
                CurString.Append(@"\end{array}\right)=");
                CurString.Append(Environment.NewLine + Environment.NewLine);
                Result.Append(CurString.ToString());
                CurString.Clear();
                /////////////////////////////////////////////////////////////////
                CurString.Append(@"\left(\begin{array}{" + CountCol + "} ");
                for (int i = 0; i < CountLines; i++)
                {
                    for (int j = 0; j < CountCols; j++)
                    {
                        if (j != 0)
                            CurString.Append(@"\;& ");
                        if (Matr2[i, j] < 0)
                            CurString.Append(Matr1[i, j] + @" - (" + Matr2[i, j] + ")");
                        else
                            CurString.Append(Matr1[i, j] + @" - " + Matr2[i, j]);
                    }
                    CurString.Append(@"\\");
                }
                CurString.Append(@"\end{array}\right)=");
                CurString.Append(Environment.NewLine + Environment.NewLine);
                Result.Append(CurString.ToString());
                CurString.Clear();
                ///////////////////////////////////////////////////////////////////
                CurString.Append(@"\left(\begin{array}{" + CountCol + "} ");
                for (int i = 0; i < CountLines; i++)
                {
                    CurString.Append(Matr1[i, 0] - Matr2[i, 0]);
                    for (int j = 1; j < CountCols; j++)
                        CurString.Append(@"& " + (Matr1[i, j] - Matr2[i, j]));
                    CurString.Append(@"\\");
                }
                CurString.Append(@"\end{array}\right)$$");
                CurString.Append(Environment.NewLine + Environment.NewLine);
                Result.Append(CurString.ToString());
                CurString.Clear();

                return Result.ToString();
            }
        }

        public static string две_матр_действия_умножение(int[,] Matr1, int[,] Matr2, bool flag)
        {
            int CountLines1 = Matr1.GetLength(0), CountCols1 = Matr1.GetLength(1),
             CountLines2 = Matr2.GetLength(0), CountCols2 = Matr2.GetLength(1);
            if (CountLines2 != CountCols1)
                return null;
            StringBuilder CurString = new StringBuilder();
            string CountCol = String.Concat(Enumerable.Repeat("c", CountCols2));
            StringBuilder Result = new StringBuilder();
            Result.Append("Результат умножения матриц:" + Environment.NewLine + Environment.NewLine);
            if (!flag)
            {
                CurString.Append(@"$$\left(\begin{array}{" + CountCol + "} ");

                for (int i = 0; i < CountLines1; i++)
                {
                    for (int j = 0; j < CountCols2; j++)
                    {
                        int cur = 0;
                        if (j != 0)
                            CurString.Append(@"& ");
                        for (int k = 0; k < CountCols1; k++)
                            cur += Matr1[i, k] * Matr2[k, j];
                        CurString.Append(cur);
                    }
                    CurString.Append(@"\\");
                }
                CurString.Append(@"\end{array}\right)$$");
                CurString.Append(Environment.NewLine + Environment.NewLine);
                Result.Append(CurString.ToString());
                CurString.Clear();
                return Result.ToString();
            }
            else
            {
                //вывод  исходных матриц
                CurString.Append(@"$$\left(\begin{array}{" + CountCol + "}");
                for (int i = 0; i < CountLines1; i++)
                {

                    for (int j = 0; j < CountCols1; j++)
                    {
                        if (j != 0)
                            CurString.Append(@"& ");
                        if (i == 0)
                            CurString.Append(@"\fbox{" + Matr1[i, j] + "}");
                        else
                            CurString.Append(Matr1[i, j]);
                    }
                    CurString.Append(@"\\");
                }
                CurString.Append(@"\end{array}\right)\cdot");

                CurString.Append(@"\left(\begin{array}{" + CountCol + "} ");
                for (int i = 0; i < CountLines2; i++)
                {
                    for (int j = 0; j < CountCols2; j++)
                    {
                        if (j != 0)
                            CurString.Append(@"& ");
                        if (j == 0)
                            CurString.Append(@" \fbox{" + Matr2[i, j] + "}");
                        else
                            CurString.Append(Matr2[i, j]);
                    }
                    CurString.Append(@"\\");
                }
                CurString.Append(@"\end{array}\right)=");
                CurString.Append(Environment.NewLine + Environment.NewLine);
                Result.Append(CurString.ToString());
                CurString.Clear();
                /////////////////////////////////////////////////////////////////
                CurString.Append(@"\left(\begin{array}{" + CountCol + "} ");
                for (int i = 0; i < CountLines1; i++)
                {
                    for (int j = 0; j < CountCols2; j++)
                    {
                        if (j != 0)
                            CurString.Append(@"\;& ");
                        for (int k = 0; k < CountCols1; k++)
                        {
                            if (k != 0)
                                CurString.Append("+");
                            if (Matr1[i, k] < 0)
                                CurString.Append("(" + Matr1[i, k] + ")");
                            else
                                CurString.Append(Matr1[i, k]);
                            CurString.Append(@" \cdot ");
                            if (Matr2[k, j] < 0)
                                CurString.Append("(" + Matr2[k, j] + ")");
                            else
                                CurString.Append(Matr2[k, j]);
                        }
                    }
                    CurString.Append(@"\\");
                }
                CurString.Append(@"\end{array}\right)=");
                CurString.Append(Environment.NewLine + Environment.NewLine);
                Result.Append(CurString.ToString());
                CurString.Clear();

                ///////////////////////////////////////////////////////////////////
                CurString.Append(@"\left(\begin{array}{" + CountCol + "} ");

                for (int i = 0; i < CountLines1; i++)
                {
                    for (int j = 0; j < CountCols2; j++)
                    {
                        int cur = 0;
                        if (j != 0)
                            CurString.Append(@"& ");
                        for (int k = 0; k < CountCols1; k++)
                            cur += Matr1[i, k] * Matr2[k, j];
                        CurString.Append(cur);
                    }
                    CurString.Append(@"\\");
                }
                CurString.Append(@"\end{array}\right)$$");
                CurString.Append(Environment.NewLine + Environment.NewLine);
                Result.Append(CurString.ToString());
                CurString.Clear();

                return Result.ToString();
            }
        }

        //------------------------------Вспомогательные функции для вычисления ранга------------------------------//

        const double Eps = 0.0001;
        static bool[] ColumnExchanged; // элемент i = true, если столбец участвовал в обмене
        static int CountRows, CountCols, LastColumn;

        //Меняет строки R1 и R2 местами
        static void SwapRows(double[,] Matr, int R1, int R2)
        {
            int CountCols = Matr.GetLength(1);
            for (int j = 0; j < CountCols; j++)
            {
                double tmp = Matr[R1, j];
                Matr[R1, j] = Matr[R2, j];
                Matr[R2, j] = tmp;
            }
        }

        //Меняет столбцы C1 и C2 местами
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

        //Ищет первую строку, начиная с позиции Index + 1, в которой элемент Index не равен 0, и меняет местами со строкой 
        //с индексом Index в случае успеха. Возвращает true, если был обмен.
        static bool TrySwapRows(double[,] Matrix, int Index)
        {
            CountRows = Matrix.GetLength(0);

            for (int i = Index + 1; i < CountRows; i++)
                if (Math.Abs(Matrix[i, Index]) >= Eps)
                {
                    SwapRows(Matrix, Index, i);
                    return true;
                }
            return false;
        }

        //Ищет первый стобец, начиная с последнего и заканчивая позицией Index + 1, который ещё не участвовал в обмене, и меняет местами со стобцом
        //с индексом Index в случае успеха. Возвращает true, если был обмен.
        static bool TrySwapColumns(double[,] Matrix, int Index)
        {
            for (int j = CountCols - 1; j > Index; j--)
                if (!ColumnExchanged[j])
                {
                    SwapCols(Matrix, Index, j);
                    ColumnExchanged[Index] = ColumnExchanged[j] = true;
                    return true;
                }
            return false;
        }

        //Обнуляет столбец Index, начиная с элемента Index + 1, с помощью преобразования строк
        static void NullifyColumn(double[,] Matrix, int Index)
        {
            //Идём по всем строкам, начиная от Index + 1
            CountRows = Matrix.GetLength(0);

            for (int i = Index + 1; i < CountRows; i++)
            {
                //Запоминаем текущий элемент строки
                double Current = Matrix[i, Index];
                //Проверяем, что текущий элемент строки не равен 0. Если он уже равен 0, то переходим к следующей строке
                if (Math.Abs(Current) >= Eps)
                {
                    //Если текущий элемент строки не равен 0, то запоминаем константу для преобразования, с помощью которой
                    //обнулится нужный элемент
                    double C = -Current / Matrix[Index, Index];

                    //Умножаем строку Index на константу и добавляем к строке i
                    for (int j = Index; j < CountCols; j++)
                        Matrix[i, j] += C * Matrix[Index, j];
                }
            }
        }

        static bool DeleteRowsMatrix(ref double[,] Matrix, int BeginIndex)
        {
            bool Result = false;
            for (int i = BeginIndex + 1; i < Matrix.GetLength(0); i++)
            {
                bool AllZero = true;

                for (int j = BeginIndex + 1; j < CountCols && AllZero; j++)
                    if (Math.Abs(Matrix[i, j]) >= Eps)
                        AllZero = false;
                if (AllZero)
                {
                    Result = true;
                    DeleteRowMatrix(ref Matrix, i);
                    i--;
                }
            }
            return Result;
        }

        static void DeleteRowMatrix(ref double[,] Matrix, int Index)
        {
            int NewCountRows = Matrix.GetLength(0) - 1;
            double[,] Result = new double[NewCountRows, CountCols];

            int Increment = 0;
            for (int i = 0; i < NewCountRows; i++)
            {
                if (i == Index)
                    Increment = 1;
                for (int j = 0; j < CountCols; j++)
                    Result[i, j] = Matrix[i + Increment, j];
            }
            Matrix = Result;
            if (NewCountRows < CountCols)
                LastColumn--;
        }

        static void PrintHelpMatrix(ref StringBuilder CurString, string CountCol, ref double[,] HelpMatrix)
        {
            CountRows = HelpMatrix.GetLength(0);
            CountCols = HelpMatrix.GetLength(1);
            CurString.Append(@"$$\left(\begin{array}{" + CountCol + "}");
            for (int k = 0; k < CountRows; k++)
            {
                for (int j = 0; j < CountCols; j++)
                {
                    if (j != 0)
                        CurString.Append("& ");
                    if (k == j)
                        CurString.Append(@"\fbox{" + Math.Round(HelpMatrix[k, j], 2) + "}");
                    else
                        CurString.Append(Math.Round(HelpMatrix[k, j], 2));
                }
                CurString.Append(@"\\");
            }
            CurString.Append(@"\end{array}\right)$$");
        }

        //===============вспомогательное для разложения по строкам и столбцам

        public static int[,] CreateMatrix(int[,] MatrIn, int size, int row, int coloumn)
        {
            int[,] result = new int[size - 1, size - 1];
            int iRes = 0, jRes;
            for (int i = 0; i < size; i++)
            {
                if (i != row)
                {
                    jRes = 0;
                    for (int j = 0; j < size; j++)
                    {
                        if (j != coloumn)
                        {
                            result[iRes, jRes] = MatrIn[i, j];
                            jRes++;
                        }
                    }
                    iRes++;
                }
            }
            return result;
        }

        public static int Determinant(int[,] MatrIn, int size)
        {
            int result = 0;
            if (size == 1)
                return MatrIn[0, 0];
            else
            {
                int MatrSize = size - 1;
                for (int i = 0; i < size; i++)
                    if (i % 2 == 0)
                        result += MatrIn[0, i] * Determinant(CreateMatrix(MatrIn, size, 0, i), MatrSize);
                    else
                        result -= MatrIn[0, i] * Determinant(CreateMatrix(MatrIn, size, 0, i), MatrSize);
                return result;
            }
        }

        public static string DeterminantMain(int[,] MatrIn, int num, bool IsRow, bool ok)
        {
            int size = MatrIn.GetLength(0);
            int result = 0;
            StringBuilder Result = new StringBuilder();
            StringBuilder CurString = new StringBuilder();
            CurString.Append("Разложение определителя по " + (num + 1));
            if (IsRow)
                CurString.Append(" строке: ");
            else
                CurString.Append(" столбцу: ");
            CurString.Append("$$ |A| = ");
            if (ok)
            {
                CurString.Append(@"\left| \begin{array}{ + lll + } ");
                if (IsRow)
                {
                    for (int l = 0; l < size; l++)
                    {
                        for (int k = 0; k < size; k++)
                        {
                            if (l == num)
                            {
                                CurString.Append(@"\fbox{" + MatrIn[l, k] + @"} & ");
                                //CurString.Append(MatrIn[l, k] + @" & ");
                            }
                            else
                                CurString.Append(MatrIn[l, k] + @" & ");
                        }
                        CurString.Append(@"\\");
                    }
                }
                else
                {
                    for (int l = 0; l < size; l++)
                    {
                        for (int k = 0; k < size - 1; k++)
                        {
                            if (k == num)
                            {
                                CurString.Append(@" \fbox{");
                                CurString.Append(MatrIn[l, k] + @"} & ");
                            }
                            else
                                CurString.Append(MatrIn[l, k] + @" & ");
                        }
                        CurString.Append(MatrIn[l, size - 1] + @"\\");
                    }
                }
                int len = CurString.Length - 2;
                CurString.Remove(len, 2);
                CurString.Append(@"\end{array} \right| = ");
                CurString.Append("");
                CurString.Append("");
            }

            if (size == 1)
                result = MatrIn[0, 0];
            else
            {
                int MatrSize = size - 1;
                for (int i = 0; i < size; i++)
                {
                    if (ok)
                        CurString.Append(@"(-1)^{(" + (num + 1) + "+" + (i + 1) + @")}\cdot ");
                    if (IsRow)
                    {
                        int[,] Matr = CreateMatrix(MatrIn, size, num, i);
                        if (ok)
                        {
                            CurString.Append(MatrIn[num, i] + @"\cdot \left| \begin{array}{ + lll + } ");
                            for (int l = 0; l < size - 1; l++)
                            {
                                for (int k = 0; k < size - 2; k++)
                                {
                                    CurString.Append(Matr[l, k] + @" & ");
                                }
                                CurString.Append(Matr[l, size - 2] + @"\\");
                            }
                            int len = CurString.Length - 2;
                            CurString.Remove(len, 2);
                            CurString.Append(@"\end{array} \right| + ");
                            CurString.Append("");
                            CurString.Append("");
                        }
                        if ((i + num) % 2 == 0)
                        {
                            result += MatrIn[num, i] * Determinant(Matr, MatrSize);
                        }
                        else
                        {
                            result -= MatrIn[num, i] * Determinant(Matr, MatrSize);
                        }
                    }
                    else
                    {
                        int[,] Matr = CreateMatrix(MatrIn, size, i, num);
                        if (ok)
                        {
                            CurString.Append(MatrIn[i, num] + @"\cdot \left| \begin{array}{ + lll + } ");
                            for (int l = 0; l < size - 1; l++)
                            {
                                for (int k = 0; k < size - 2; k++)
                                {
                                    CurString.Append(Matr[l, k] + @" & ");
                                }
                                CurString.Append(Matr[l, size - 2] + @"\\");
                            }
                            int len = CurString.Length - 2;
                            CurString.Remove(len, 2);
                            CurString.Append(@"\end{array} \right| + ");
                            CurString.Append("");
                            CurString.Append("");
                        }
                        if ((i + num) % 2 == 0)
                        {
                            result += MatrIn[i, num] * Determinant(Matr, MatrSize);
                        }
                        else
                        {
                            result -= MatrIn[i, num] * Determinant(Matr, MatrSize);
                        }
                    }
                }
            }
            CurString.Remove(CurString.Length - 2, 2);
            CurString.Append(" = " + result);
            CurString.Append("$$");
            CurString.Append(Environment.NewLine);
            CurString.Append(Environment.NewLine);
            return CurString.ToString();
        }
    }
}
