using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algem_manual
{
    public class TreeViewUtils
    {
        public static void Serialize(string savepath, TreeView trv)
        {
            System.IO.Directory.CreateDirectory(savepath);
            FileStream fs = new FileStream(Path.Combine(savepath,trv.Name+".tree"), FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, trv.Nodes.Cast<TreeNode>().ToList());
            }
            catch (SerializationException e)
            {
                Logs.WriteLine("Ошибка сериализации TreeView. Подробности: " + e.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        public static void Deserialize(string loadpath, ref TreeView trv)
        {
            FileStream fs = new FileStream(Path.Combine(loadpath,trv.Name+".tree"), FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                object obj = formatter.Deserialize(fs);
                TreeNode[] nodeList = (obj as IEnumerable<TreeNode>).ToArray();
                trv.Nodes.AddRange(nodeList);
            }
            catch (SerializationException ex)
            {
                Logs.WriteLine("Ошибка при чтении ответов. Подробности: " + ex.Message);
                return;
            }
            finally
            {
                fs.Close();

                //восстанавливаем индексы по тегам
                foreach (TreeNode tn in trv.Nodes)
                {
                    FillImageIndexes(tn);

                    if (tn.Nodes.Count > 0)
                        foreach (TreeNode tn_child in tn.Nodes)
                            FillImageIndexes(tn_child);
                }
            }
        }

        //выставление индекса изображения для TreeNode в зависимости от тега
        private static void FillImageIndexes(TreeNode tn)
        {
            int image_index = 0;

            if (tn.Tag.ToString() == "child")
                image_index = 1;

            tn.ImageIndex = image_index;
            tn.SelectedImageIndex = image_index;
        }

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
