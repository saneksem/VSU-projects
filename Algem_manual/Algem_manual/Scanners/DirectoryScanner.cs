using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algem_manual.Scanners
{
    class DirectoryScanner
    {
        private string path;
        private string keyWord;
        private TreeView tree;

        public DirectoryScanner(string directory, string key, TreeView output)
        {
            path = directory;
            keyWord = key;
            tree = output;
        }

        public void ScanContent()
        {
            string[] root_folders = Directory.GetDirectories(path);
            foreach (string root_folder in root_folders)
            {
                string fullpath = Path.Combine(root_folder, keyWord);
                if (Directory.Exists(fullpath) && Directory.EnumerateFileSystemEntries(fullpath).Any())
                {
                    //нашли папку с теорией,примерами или тестами
                    TreeNode root = new TreeNode(root_folder.Split(Path.DirectorySeparatorChar).Last());
                    root.Name = Path.Combine(root.Text, keyWord);

                    string[] folders = Directory.GetDirectories(fullpath);
                    foreach (string folder in folders)
                    {
                        TreeNode child = new TreeNode(folder.Split(Path.DirectorySeparatorChar).Last());
                        child.Tag = "child";
                        root.Nodes.Add(child);
                    }

                    root.Tag = "root";
                    tree.Invoke((MethodInvoker) delegate { tree.Nodes.Add(root); });
                    
                }
            }
        }
    }
}
