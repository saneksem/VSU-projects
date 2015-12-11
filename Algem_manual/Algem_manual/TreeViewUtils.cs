using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algem_manual
{
    public class TreeViewUtils
    {
        public class TreeRunner
        {
            private string folder;
            public string GetFolder
            {
                get
                {
                    return folder;
                }
            }

            private TreeView tree;

            public TreeRunner(string directory, TreeView control)
            {
                folder = directory;
                tree = control;
            }

            public void Fill()
            {
                tree.Nodes.Clear();

                string[] folders = Directory.GetDirectories(folder);
                foreach (string folder in folders)
                {
                    TreeNode root = new TreeNode(folder.Split(Path.DirectorySeparatorChar).Last());

                    string[] files = Directory.GetFiles(folder);
                    foreach(string file in files)
                    {
                        TreeNode child = new TreeNode(file.Split(Path.DirectorySeparatorChar).Last());
                        child.Tag = "child";
                        root.Nodes.Add(child);
                    }

                    root.Tag = "root";
                    tree.Nodes.Add(root);
                }
                tree.ExpandAll();

                //string[] files = Directory.GetFiles(folder);
                //FileAttributes attr = File.GetAttributes("");
            }
        }
    }
}
