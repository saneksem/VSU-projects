using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Algem_manual.Calculators.ComplexCalculator
{
    static class ComplexUtils
    {
        public static string компл_сложение(Complex c1, Complex c2, bool detail)
        {
            StringBuilder tex = new StringBuilder();

            tex.Append("Результат сложения комплексных чисел:\n\n");
            tex.Append("$$(" + complexToString(c1) + ") + (" + complexToString(c2) + ") = $$");

            if (detail)
            {
                tex.Append("$$(" + ((c1.Real != 0) ? "" + Math.Round(c1.Real, 2) : "") + ((c2.Real > 0) ? " + " : " - ") + Math.Round(Math.Abs(c2.Real), 2) + ")");
                tex.Append(" + " + "(" + Math.Round(c1.Imaginary, 2) + "i" + ((c2.Imaginary >= 0) ? " + " : " - ") + Math.Round(Math.Abs(c2.Imaginary), 2) + "i) = $$");
            }

            tex.Append("$$" + complexToString(Complex.Add(c1, c2)) + "$$");

            return tex.ToString();
        }

        private static string makeMultiplyTexOneStep(Complex c1, Complex c2)
        {
            StringBuilder tex = new StringBuilder();

            tex.Append(bracket(c1.Real, true) + " \\cdot " + bracket(c2.Real, true));
            tex.Append(" + " + bracket(c1.Real, true) + " \\cdot " + bracket(c2.Imaginary, false));
            tex.Append(" + " + bracket(c1.Imaginary, false) + " \\cdot " + bracket(c2.Real, true));
            tex.Append(" + " + bracket(c1.Imaginary, false) + " \\cdot " + bracket(c2.Imaginary, false));

            return tex.ToString();
        }

        private static string makeMultiplyTexTwoStep(Complex c1, Complex c2)
        {
            StringBuilder tex = new StringBuilder();

            tex.Append("(" + bracket(c1.Real, true) + " \\cdot " + bracket(c2.Real, true));
            tex.Append(" - " + bracket(c1.Imaginary, true) + " \\cdot " + bracket(c2.Imaginary, true) + ")");
            tex.Append(" + (" + bracket(c1.Real, true) + " \\cdot " + bracket(c2.Imaginary, true));
            tex.Append(" + " + bracket(c1.Imaginary, true) + " \\cdot " + bracket(c2.Real, true) + ")i");

            return tex.ToString();
        }

        public static string компл_умножение(Complex c1, Complex c2, bool detail)
        {
            StringBuilder tex = new StringBuilder();

            tex.Append("Результат умножения комплексных чисел:\n\n");
            tex.Append("$$(" + complexToString(c1) + ") \\cdot (" + complexToString(c2) + ") = $$");

            if (detail)
            {
                tex.Append("$$" + makeMultiplyTexOneStep(c1, c2));
                tex.Append(" = $$");
                tex.Append("$$" + makeMultiplyTexTwoStep(c1, c2));
                tex.Append(" = $$");
            }

            tex.Append("$$" + complexToString(Complex.Multiply(c1, c2)) + "$$");

            return tex.ToString();
        }

        public static string компл_деление(Complex c1, Complex c2, bool detail)
        {
            StringBuilder tex = new StringBuilder();

            tex.Append("Результат деления комплексных чисел:\n\n");
            tex.Append("$$\\frac{" + complexToString(c1) + "}{" + complexToString(c2) + "} = $$");
            Complex cn = Complex.Multiply(c1, new Complex(c2.Real, -c2.Imaginary));
            double d = c2.Real * c2.Real - c2.Imaginary * c2.Imaginary;

            if (detail)
            {
                tex.Append("$$\\frac{" + "(" + complexToString(c1) + ") \\cdot (" + complexToString(new Complex(c2.Real, -c2.Imaginary)) + ")}");
                tex.Append("{(" + complexToString(c2) + ") \\cdot " + "(" + complexToString(new Complex(c2.Real, -c2.Imaginary)) + ")} = $$");
                tex.Append("$$\\frac{");
                tex.Append(makeMultiplyTexOneStep(c1, new Complex(c2.Real, -c2.Imaginary)));
                tex.Append("}{");
                tex.Append(bracket(c2.Real, true) + "^{2} - (" + c2.Imaginary + "i)^{2}");
                tex.Append("} = $$");
                tex.Append("$$\\frac{");
                tex.Append(makeMultiplyTexTwoStep(c1, new Complex(c2.Real, -c2.Imaginary)));
                tex.Append("}{" + d + "} = ");
                tex.Append("\\frac{" + complexToString(cn) + "}{" + d + "} = $$");
            }

            tex.Append("$$" + complexToString(new Complex(cn.Real / d, cn.Imaginary / d)) + "$$");

            return tex.ToString();
        }

        public static string компл_степень(Complex c, int d, bool detail)
        {
            StringBuilder tex = new StringBuilder();

            if (d >= 0)
            {
                tex.Append("Результат возведения комплесного числа в степень:\n\n");
                tex.Append("$$(" + complexToString(c) + ")^{" + d + "} = $$");

                if (detail && d >= 2)
                {
                    Complex cTemp = new Complex(c.Real, c.Imaginary);
                    d--;
                    while (d >= 2)
                    {
                        d--;
                        tex.Append("$$(" + complexToString(c) + ")" + ((d > 1) ? ("^{" + d + "}") : "") + " \\cdot (" + complexToString(c) + ") \\cdot (" + complexToString(cTemp) + ")");
                        tex.Append(" = $$$$(" + complexToString(c) + ")" + ((d > 1) ? ("^{" + d + "}") : "") + " \\cdot (" + makeMultiplyTexOneStep(c, cTemp) + ")");
                        tex.Append(" = $$$$(" + complexToString(c) + ")" + ((d > 1) ? ("^{" + d + "}") : "") + " \\cdot (" + makeMultiplyTexTwoStep(c, cTemp) + ") = $$");
                        cTemp = Complex.Multiply(c, cTemp);
                    }

                    tex.Append("$$(" + complexToString(c) + ") \\cdot (" + complexToString(cTemp) + ")");
                    tex.Append(" = $$$$" + makeMultiplyTexOneStep(c, cTemp) + "");
                    tex.Append(" = $$$$" + makeMultiplyTexTwoStep(c, cTemp) + " = $$");
                    d++;
                }

                tex.Append("$$" + complexToString(Complex.Pow(c, new Complex(d, 0))) + "$$");
            }

            return tex.ToString();
        }

        private static string bracket(double n, bool isReal)
        {
            string s = "";
            if (n < 0)
                s += "(";
            s += Math.Round(n, 2) + (isReal ? "" : "i");
            if (n < 0)
                s += ")";
            return s;
        }

        private static string complexToString(Complex c)
        {
            string outStr = "";

            outStr = "" + Math.Round(c.Real, 2);
            if (c.Imaginary >= 0)
                outStr += " + " + Math.Round(c.Imaginary, 2) + "i";
            else if (c.Imaginary < 0)
                outStr += " - " + Math.Abs(Math.Round(c.Imaginary, 2)) + "i";

            return outStr;
        }
    }
}
