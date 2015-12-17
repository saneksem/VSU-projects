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

            tex_writer = new TexUtils.Render(Path.Combine(DirectoriesSettings.ConvertedPath,"main"));

            

            Logs.WriteLine("Инициализация главной формы");
            InitializeComponent();

            theory = new TreeViewUtils.TreeRunner(Application.StartupPath + "\\Data\\Content", tree_Теория);
            theory.Fill();

            //Scanners.TestScanner scan = new Scanners.TestScanner(Application.StartupPath);
            //scan.TestWrite();
            //scan.TestRead();
            TestTest();
        }

        private void TestTest()
        {
            int currentpos = 10;
            int buttonsize = 150;
            int buttonstart = split_Тесты.Panel2.Width - 20 - buttonsize;
            int buttonwidth = split_Тесты.Panel2.Width - 20 - buttonstart;
            for (int i = 0; i < 10; i++)
            {
                WebBrowser b = new WebBrowser();
                b.Location = new Point(10, currentpos);
                b.Url = new Uri(String.Format("file:///{0}", Application.StartupPath + "\\Data\\Temp\\Images\\main\\main.html"));
                b.Visible = true;
                b.Name = "WebBrowser" + i.ToString();
                b.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                b.Width = split_Тесты.Panel2.Width - 20;
                b.Height = 500;
                
                /* Размер по документу
                while (b.Document.Body == null)
                {
                    Application.DoEvents();
                }
                b.Height = b.Document.Body.ScrollRectangle.Height + 25;*/


                b.Parent = split_Тесты.Panel2;
                currentpos += b.Height + 5;
                

                TextBox t = new TextBox();
                t.Location = new Point(10, currentpos);
                t.Width = buttonstart;
                t.Name = "TextBox" + i.ToString();
                t.Visible = true;
                t.Multiline = false;
                t.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                t.Parent = split_Тесты.Panel2;

                Button btn = new Button();
                btn.Location = new Point(buttonstart + 10, currentpos - 1);
                btn.Height = t.Height + 2;
                btn.Width = buttonwidth;
                btn.Name = "Button" + (i + 1).ToString();
                btn.Text = "Button" + (i + 1).ToString();
                btn.Visible = true;
                btn.Anchor = AnchorStyles.Right | AnchorStyles.Top;
                btn.Parent = split_Тесты.Panel2;

                currentpos += t.Height + 100;
            }
            //split_Тесты.Panel2.Controls.Clear(); - пашет!
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Calculations c = new Calculations();
            c.Show();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode current = tree_Теория.SelectedNode;
            if (current.Tag.ToString() == "child")
            {
                string file = theory.GetFolder + "\\" + current.Parent.Text + "\\" + current.Text;
                tex_writer.Clear();
                tex_writer.TexToHTML(file);
                browser_Теория.Url = new Uri(String.Format("file:///{0}", tex_writer.HTMLPath));
                browser_Теория.Document.BackColor = Color.White;
                browser_Теория.Refresh();
            }
        }
    }
}
