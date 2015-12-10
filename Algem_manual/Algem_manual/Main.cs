using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Algem_manual
{

    public partial class Main : Form
    {
        TexUtils.Render tex_writer;

        public Main()
        {
            Logs.InitLogging();

            tex_writer = new TexUtils.Render("main");

            Logs.WriteLine("Инициализация главной формы");
            InitializeComponent();

            /*tex_writer.FormulaToRTB(@"$$ \color{black} \Huge \text{ A_f}=\left\{
                                    \begin{array}{lll}
                                    \lambda_1 & 0 & 0\\
                                    0 & \lambda_1 & 0\\
                                    0 & 0 & \lambda_2
                                    \end{array}
                                    \right\}
                                     $$", rtf_theory);*/
            
            //tex_writer.FormulaToRTB(@"$$ \color{black} \Huge  \text x^2+z^2=0 $$", new RichTextBox());

            tex_writer.TexToHTML(Application.StartupPath + "\\test.tex");
            //browser_theory.Url = new Uri(String.Format("file:///{0}/main.html", tex_writer.ToString()));
            
            browser_theory.Url = new Uri(String.Format("file:///{0}",Application.StartupPath+ @"/Data/Temp/Images/main/main.html"));
            //tex_writer.Clear();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Calculations c = new Calculations();
            c.Show();
        }
    }
}
