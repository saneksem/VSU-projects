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
        TreeViewUtils.TreeRunner theory;

        public Main()
        {
            Logs.InitLogging();

            tex_writer = new TexUtils.Render("main");
            

            Logs.WriteLine("Инициализация главной формы");
            InitializeComponent();

            theory = new TreeViewUtils.TreeRunner(Application.StartupPath + "\\Data\\Content", treeView1);
            theory.Fill();

            tex_writer.TexToHTML(Application.StartupPath + "\\test.tex");
            //browser_theory.Url = new Uri(String.Format("file:///{0}/main.html", tex_writer.ToString()));

            //browser_theory.Url = new Uri(String.Format("file:///{0}",Application.StartupPath+ @"/Data/Temp/Images/main/main.html"));
            browser_theory.Url = new Uri(String.Format("file:///{0}", tex_writer.HTMLPath));

            //изменение цвета
            browser_theory.Document.BackColor = Color.White;
            //browser_theory.Document.BackColor = Color.LightYellow;
            //tex_writer.Clear();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Calculations c = new Calculations();
            c.Show();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode current = treeView1.SelectedNode;
            if (current.Tag.ToString() == "child")
            {
                string file = theory.GetFolder + "\\" + current.Parent.Text + "\\" + current.Text;
                tex_writer.Clear();
                tex_writer.TexToHTML(file);
                browser_theory.Url = new Uri(String.Format("file:///{0}", tex_writer.HTMLPath));
                browser_theory.Refresh();
            }
        }
    }
}
