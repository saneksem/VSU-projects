namespace Algem_manual
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Подтема1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Подтема2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Тема1", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Подтема1");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Подтема2");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Тема2", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tab_control_main = new System.Windows.Forms.TabControl();
            this.tab_theory = new System.Windows.Forms.TabPage();
            this.tab_example = new System.Windows.Forms.TabPage();
            this.tab_test = new System.Windows.Forms.TabPage();
            this.toolStripMain.SuspendLayout();
            this.tab_control_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(774, 27);
            this.toolStripMain.TabIndex = 0;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(120, 24);
            this.toolStripButton1.Text = "Калькулятор";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 27);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node2";
            treeNode1.Text = "Подтема1";
            treeNode2.Name = "Node3";
            treeNode2.Text = "Подтема2";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Тема1";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Подтема1";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Подтема2";
            treeNode6.Name = "Node1";
            treeNode6.Text = "Тема2";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(165, 327);
            this.treeView1.TabIndex = 1;
            // 
            // tab_control_main
            // 
            this.tab_control_main.Controls.Add(this.tab_theory);
            this.tab_control_main.Controls.Add(this.tab_example);
            this.tab_control_main.Controls.Add(this.tab_test);
            this.tab_control_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_control_main.Location = new System.Drawing.Point(165, 27);
            this.tab_control_main.Name = "tab_control_main";
            this.tab_control_main.SelectedIndex = 0;
            this.tab_control_main.Size = new System.Drawing.Size(609, 327);
            this.tab_control_main.TabIndex = 2;
            // 
            // tab_theory
            // 
            this.tab_theory.Location = new System.Drawing.Point(4, 25);
            this.tab_theory.Name = "tab_theory";
            this.tab_theory.Padding = new System.Windows.Forms.Padding(3);
            this.tab_theory.Size = new System.Drawing.Size(601, 298);
            this.tab_theory.TabIndex = 0;
            this.tab_theory.Text = "Теория";
            this.tab_theory.UseVisualStyleBackColor = true;
            // 
            // tab_example
            // 
            this.tab_example.Location = new System.Drawing.Point(4, 25);
            this.tab_example.Name = "tab_example";
            this.tab_example.Padding = new System.Windows.Forms.Padding(3);
            this.tab_example.Size = new System.Drawing.Size(601, 298);
            this.tab_example.TabIndex = 1;
            this.tab_example.Text = "Примеры";
            this.tab_example.UseVisualStyleBackColor = true;
            // 
            // tab_test
            // 
            this.tab_test.Location = new System.Drawing.Point(4, 25);
            this.tab_test.Name = "tab_test";
            this.tab_test.Padding = new System.Windows.Forms.Padding(3);
            this.tab_test.Size = new System.Drawing.Size(601, 298);
            this.tab_test.TabIndex = 2;
            this.tab_test.Text = "Тесты";
            this.tab_test.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 354);
            this.Controls.Add(this.tab_control_main);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.toolStripMain);
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Электронный учебник. Алгебра и геометрия";
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.tab_control_main.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabControl tab_control_main;
        private System.Windows.Forms.TabPage tab_theory;
        private System.Windows.Forms.TabPage tab_example;
        private System.Windows.Forms.TabPage tab_test;
    }
}

