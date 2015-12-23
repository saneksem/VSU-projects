using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algem_manual
{
    public static class DirectoriesSettings
    {
        public static string LogsPath = Application.StartupPath + "\\Logs";
        public static string TempImagesPath = Application.StartupPath + "\\Data\\Temp\\Images";
        public static string UnconvertedPath = Application.StartupPath + "\\Data\\Unconverted";
        public static string ConvertedPath = Application.StartupPath + "\\Data\\Content";
        public static string TreeViewPath = Application.StartupPath + "\\Data\\Temp\\TreeView";
        public static string CalculatorsTempPath = Application.StartupPath + "\\Data\\Temp\\Calculators";
        public static string MatrixCalculatorPath = CalculatorsTempPath + "\\Matrix";
        public static string SettingsTestHTMLPath = Application.StartupPath + "\\Data\\test.html";
    }
    public static class TexSettings
    {
        public static string HTMLHeader = "<meta http-equiv=\"Content-Type\" content=\"text/html\"; charset=\"windows-1251\" />";
        public static string HTMLImageStyle = "<style>img {display: inline-block; margin-right: 0px; vertical-align: middle;}</style>";
        public static string[] Ignorable = { @"\documentclass{article}", @"\usepackage[cp1251]{inputenc}", @"\usepackage[russian]{babel}" };
        public static string DocumentStart = @"\begin{document}";
        public static string DocumentEnd = @"\end{document}";
    }
}
