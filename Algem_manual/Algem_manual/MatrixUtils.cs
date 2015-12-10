using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algem_manual
{
    static class MatrixUtils
    {
        public static string определитель_саррюс(int[,] Matr, bool flag)
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

        public static string ранг(int[,] Matr, bool flag)
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

        public static string две_матр_действия_сложение(int[,] Matr1, int[,] Matr2, bool flag)
        {
            int CountLines = Matr1.GetLength(0), CountCols = Matr1.GetLength(1);
            StringBuilder Result = new StringBuilder();
            if (!flag)
            {
                for (int i = 0; i < CountLines; i++)
                {
                    for (int j = 0; j < CountCols; j++)
                        Result.Append(Matr1[i, j] + Matr2[i, j] + " ");
                    Result.Append(Environment.NewLine);
                }
                return Result.ToString();
            }
            else
            {
                StringBuilder CurString = new StringBuilder();
                string CountCol = String.Concat(Enumerable.Repeat("c", CountCols));
                //вывод выражение суммы исходных матриц
                CurString.Append(@"$$\left(\begin{array}{" + CountCol + "}");
                for (int i = 0; i < CountLines; i++)
                {
                    CurString.Append(@"\textcolor{red}{" + Matr1[i, 0] + "}");
                    for (int j = 1; j < CountCols; j++)
                        CurString.Append(@"& \textcolor{red}{" + Matr1[i, j] + "}");
                    CurString.Append(@"\\");
                }
                CurString.Append(@"\end{array}\right)+");

                CurString.Append(@"\left(\begin{array}{" + CountCol + "} ");
                for (int i = 0; i < CountLines; i++)
                {
                    CurString.Append(@"\textcolor{blue}{" + Matr2[i, 0] + "}");
                    for (int j = 1; j < CountCols; j++)
                        CurString.Append(@"& \textcolor{blue}{" + Matr2[i, j] + "}");
                    CurString.Append(@"\\");
                }
                CurString.Append(@"\end{array}\right)=");
                Result.Append(CurString.ToString());
                CurString.Clear();
                /////////////////////////////////////////////////////////////////
                CurString.Append(@"\left(\begin{array}{" + CountCol + "} ");
                for (int i = 0; i < CountLines; i++)
                {
                    CurString.Append(@"\textcolor{red}{" + Matr1[i, 0] + @"} + \textcolor{blue}{" + Matr2[i, 0] + "}");
                    for (int j = 1; j < CountCols; j++)
                        CurString.Append(@"& \textcolor{red}{" + Matr1[i, j] + @"} + \textcolor{blue}{" + Matr2[i, j] + "}");
                    CurString.Append(@"\\");
                }
                CurString.Append(@"\end{array}\right)=");
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
                Result.Append(CurString.ToString());
                CurString.Clear();
                return Result.ToString();
            }
        }

        public static string две_матр_действия_вычитание(int[,] Matr1, int[,] Matr2, bool flag)
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

        public static string две_матр_действия_умножение(int[,] Matr1, int[,] Matr2, bool flag)
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
    }
}
