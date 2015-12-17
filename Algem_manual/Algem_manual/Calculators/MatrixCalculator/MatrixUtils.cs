﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algem_manual
{
    static class MatrixUtils
    {
        public static string определитель_саррюс(int[,] Matr, bool ok)
        {
            StringBuilder Result = new StringBuilder();
            int det = 0;
            StringBuilder CurString = new StringBuilder();
            det = Matr[0, 0] * Matr[1, 1] * Matr[2, 2] + Matr[0, 1] * Matr[1, 2] * Matr[2, 0] + Matr[0, 2] * Matr[1, 0] * Matr[2, 1] - Matr[0, 2] * Matr[1, 1] * Matr[2, 0] - Matr[0, 0] * Matr[1, 2] * Matr[2, 1] - Matr[0, 1] * Matr[1, 0] * Matr[2, 2];
            if (ok)
            {
                CurString.Append(@"$$\left(\begin{array}{lll} $");
                CurString.Append(@"$$\color{red}{" + Matr[0, 0] + @"}  + $$\color{blue}{" + Matr[0, 1] + @"} + $$\color{green}{" + Matr[0, 2] + @"} $" + Matr[0, 0] + Matr[0, 1]);
                CurString.Append(@"\\");
                CurString.Append(@Matr[1, 0] + @"$$\color{red}{" + Matr[1, 1] + @"}  + $$\color{blue}{" + Matr[1, 2] + @"} + $$\color{green}{" + Matr[1, 0] + @"} $" + Matr[1, 1]);
                CurString.Append(@"\\");
                CurString.Append(@Matr[2, 0] + Matr[2, 1] + @"$$\color{red}{" + Matr[2, 2] + @"}  + $$\color{blue}{" + Matr[2, 0] + @"} + $$\color{green}{" + Matr[2, 1] + @"} $");
                CurString.Append(@"\\");
                CurString.Append(@"\end{array}\right)");
                CurString.Append("");
                CurString.Append("");
                int det1 = Matr[0, 0] * Matr[1, 1] * Matr[2, 2] + Matr[0, 1] * Matr[1, 2] * Matr[2, 0] + Matr[0, 2] * Matr[1, 0] * Matr[2, 1];
                CurString.Append(@"$$= $" + Matr[0, 0] + @"$$\cdot $" + Matr[1, 1] + @"$$\cdot $" + Matr[2, 2] + @"$$ + $" + Matr[0, 1] + @"$$\cdot $" + Matr[1, 2] + @"$$\cdot $" + Matr[2, 0] + @"$$+ $" + Matr[0, 2] + @"$$\cdot $" + Matr[1, 0] + @"$$\cdot $" + Matr[2, 1] + @"$$= $" + det1);
                CurString.Append("");
                CurString.Append("");
                CurString.Append(@"$$\left(\begin{array}{lll} $");
                CurString.Append(@Matr[0, 0] + Matr[0, 1] + @"$$\color{red}{" + Matr[0, 2] + @"} + $$\color{blue}{" + Matr[0, 0] + @"} $" + @"$$\color{green}{" + Matr[0, 1] + @"} $");
                CurString.Append(@"\\");
                CurString.Append(@Matr[1, 0] + @"$$\color{red}{" + Matr[1, 1] + @"}  + $$\color{blue}{" + Matr[1, 2] + @"} + $$\color{green}{" + Matr[1, 0] + @"} $" + Matr[1, 1]);
                CurString.Append(@"\\");
                CurString.Append(@"$$\color{red}{" + Matr[2, 0] + @"} + $$\color{blue}{" + Matr[2, 1] + @"$$\color{green}{" + Matr[2, 2] + @"} $$" + Matr[2, 0] + Matr[2, 1]);
                CurString.Append(@"\\");
                CurString.Append(@"\end{array}\right)");
                CurString.Append("");
                CurString.Append("");
                int det2 = Matr[0, 2] * Matr[1, 1] * Matr[2, 0] + Matr[0, 0] * Matr[1, 2] * Matr[2, 1] + Matr[0, 1] * Matr[1, 0] * Matr[2, 2];
                CurString.Append(@"$$= $" + Matr[0, 2] + @"$$\cdot $" + Matr[1, 1] + @"$$\cdot $" + Matr[2, 0] + @"$$+ $" + Matr[0, 0] + @"$$\cdot $" + Matr[1, 2] + @"$$\cdot $" + Matr[2, 1] + @"$$+ $" + Matr[0, 1] + @"$$\cdot $" + Matr[1, 0] + @"$$\cdot $" + Matr[2, 2] + @"$$= $" + det2);
                CurString.Append("");
                CurString.Append("");
                int det3 = det1 - det2;
                CurString.Append(@"$$|A| = " + det1 + @"}  + $$ - {" + det2 + @"$$= $" + det3);
            }
            else
                CurString.Append(@"$$|A| = " + det);

            MessageBox.Show("END");
            return CurString.ToString();
        }

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
                            CurString.Append(@"\fbox{" + HelpMatrix[i, j] + "}");
                        else
                            CurString.Append(HelpMatrix[i, j]);
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

                            CurString.Append("Обнуляем элементы, находящиеся ниже диагонального элемента равного " + HelpMatrix[i, i] + ":" + Environment.NewLine + Environment.NewLine);
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

                        CurString.Append("Обнуляем элементы, находящиеся ниже диагонального элемента равного " + HelpMatrix[i, i] + ":" + Environment.NewLine + Environment.NewLine);
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
                            CurString.Append(@"& ");
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
                            CurString.Append(@"& ");
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
                            CurString.Append(@"& ");
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
                        CurString.Append(@"\fbox{" + HelpMatrix[k, j] + "}");
                    else
                        CurString.Append(HelpMatrix[k, j]);
                }
                CurString.Append(@"\\");
            }
            CurString.Append(@"\end{array}\right)$$");
        }
    }
}