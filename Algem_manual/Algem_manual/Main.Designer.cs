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
            this.tree_Теория = new System.Windows.Forms.TreeView();
            this.tab_control_main = new System.Windows.Forms.TabControl();
            this.tab_Теория = new System.Windows.Forms.TabPage();
            this.split_Теория = new System.Windows.Forms.SplitContainer();
            this.browser_Теория = new System.Windows.Forms.WebBrowser();
            this.tab_Примеры = new System.Windows.Forms.TabPage();
            this.split_Примеры = new System.Windows.Forms.SplitContainer();
            this.tree_Примеры = new System.Windows.Forms.TreeView();
            this.browser_Примеры = new System.Windows.Forms.WebBrowser();
            this.tab_Тесты = new System.Windows.Forms.TabPage();
            this.split_Тесты = new System.Windows.Forms.SplitContainer();
            this.tree_Тесты = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.калькуляторыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матрицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.комплексныеЧислаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tab_control_main.SuspendLayout();
            this.tab_Теория.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split_Теория)).BeginInit();
            this.split_Теория.Panel1.SuspendLayout();
            this.split_Теория.Panel2.SuspendLayout();
            this.split_Теория.SuspendLayout();
            this.tab_Примеры.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split_Примеры)).BeginInit();
            this.split_Примеры.Panel1.SuspendLayout();
            this.split_Примеры.Panel2.SuspendLayout();
            this.split_Примеры.SuspendLayout();
            this.tab_Тесты.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split_Тесты)).BeginInit();
            this.split_Тесты.Panel1.SuspendLayout();
            this.split_Тесты.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tree_Теория
            // 
            this.tree_Теория.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tree_Теория.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tree_Теория.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tree_Теория.HideSelection = false;
            this.tree_Теория.Location = new System.Drawing.Point(0, 0);
            this.tree_Теория.Margin = new System.Windows.Forms.Padding(2);
            this.tree_Теория.Name = "tree_Теория";
            this.tree_Теория.Size = new System.Drawing.Size(273, 405);
            this.tree_Теория.TabIndex = 1;
            this.tree_Теория.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewSelection);
            // 
            // tab_control_main
            // 
            this.tab_control_main.Controls.Add(this.tab_Теория);
            this.tab_control_main.Controls.Add(this.tab_Примеры);
            this.tab_control_main.Controls.Add(this.tab_Тесты);
            this.tab_control_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_control_main.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tab_control_main.Location = new System.Drawing.Point(0, 24);
            this.tab_control_main.Margin = new System.Windows.Forms.Padding(2);
            this.tab_control_main.Name = "tab_control_main";
            this.tab_control_main.SelectedIndex = 0;
            this.tab_control_main.Size = new System.Drawing.Size(784, 437);
            this.tab_control_main.TabIndex = 2;
            // 
            // tab_Теория
            // 
            this.tab_Теория.Controls.Add(this.split_Теория);
            this.tab_Теория.Location = new System.Drawing.Point(4, 22);
            this.tab_Теория.Margin = new System.Windows.Forms.Padding(2);
            this.tab_Теория.Name = "tab_Теория";
            this.tab_Теория.Padding = new System.Windows.Forms.Padding(2);
            this.tab_Теория.Size = new System.Drawing.Size(776, 411);
            this.tab_Теория.TabIndex = 0;
            this.tab_Теория.Text = "Теория";
            this.tab_Теория.UseVisualStyleBackColor = true;
            // 
            // split_Теория
            // 
            this.split_Теория.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.split_Теория.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split_Теория.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.split_Теория.Location = new System.Drawing.Point(2, 2);
            this.split_Теория.Margin = new System.Windows.Forms.Padding(2);
            this.split_Теория.Name = "split_Теория";
            // 
            // split_Теория.Panel1
            // 
            this.split_Теория.Panel1.Controls.Add(this.tree_Теория);
            // 
            // split_Теория.Panel2
            // 
            this.split_Теория.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.split_Теория.Panel2.Controls.Add(this.browser_Теория);
            this.split_Теория.Size = new System.Drawing.Size(772, 407);
            this.split_Теория.SplitterDistance = 275;
            this.split_Теория.SplitterWidth = 8;
            this.split_Теория.TabIndex = 2;
            // 
            // browser_Теория
            // 
            this.browser_Теория.AllowWebBrowserDrop = false;
            this.browser_Теория.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browser_Теория.Location = new System.Drawing.Point(0, 0);
            this.browser_Теория.Margin = new System.Windows.Forms.Padding(2);
            this.browser_Теория.MinimumSize = new System.Drawing.Size(15, 16);
            this.browser_Теория.Name = "browser_Теория";
            this.browser_Теория.Size = new System.Drawing.Size(487, 405);
            this.browser_Теория.TabIndex = 0;
            this.browser_Теория.WebBrowserShortcutsEnabled = false;
            // 
            // tab_Примеры
            // 
            this.tab_Примеры.Controls.Add(this.split_Примеры);
            this.tab_Примеры.Location = new System.Drawing.Point(4, 22);
            this.tab_Примеры.Margin = new System.Windows.Forms.Padding(2);
            this.tab_Примеры.Name = "tab_Примеры";
            this.tab_Примеры.Padding = new System.Windows.Forms.Padding(2);
            this.tab_Примеры.Size = new System.Drawing.Size(776, 411);
            this.tab_Примеры.TabIndex = 1;
            this.tab_Примеры.Text = "Примеры";
            this.tab_Примеры.UseVisualStyleBackColor = true;
            // 
            // split_Примеры
            // 
            this.split_Примеры.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.split_Примеры.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split_Примеры.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.split_Примеры.Location = new System.Drawing.Point(2, 2);
            this.split_Примеры.Margin = new System.Windows.Forms.Padding(2);
            this.split_Примеры.Name = "split_Примеры";
            // 
            // split_Примеры.Panel1
            // 
            this.split_Примеры.Panel1.Controls.Add(this.tree_Примеры);
            // 
            // split_Примеры.Panel2
            // 
            this.split_Примеры.Panel2.Controls.Add(this.browser_Примеры);
            this.split_Примеры.Size = new System.Drawing.Size(772, 407);
            this.split_Примеры.SplitterDistance = 275;
            this.split_Примеры.SplitterWidth = 8;
            this.split_Примеры.TabIndex = 0;
            // 
            // tree_Примеры
            // 
            this.tree_Примеры.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tree_Примеры.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tree_Примеры.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tree_Примеры.HideSelection = false;
            this.tree_Примеры.Location = new System.Drawing.Point(0, 0);
            this.tree_Примеры.Margin = new System.Windows.Forms.Padding(2);
            this.tree_Примеры.Name = "tree_Примеры";
            this.tree_Примеры.Size = new System.Drawing.Size(273, 405);
            this.tree_Примеры.TabIndex = 0;
            this.tree_Примеры.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewSelection);
            // 
            // browser_Примеры
            // 
            this.browser_Примеры.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browser_Примеры.Location = new System.Drawing.Point(0, 0);
            this.browser_Примеры.Margin = new System.Windows.Forms.Padding(2);
            this.browser_Примеры.MinimumSize = new System.Drawing.Size(15, 16);
            this.browser_Примеры.Name = "browser_Примеры";
            this.browser_Примеры.Size = new System.Drawing.Size(487, 405);
            this.browser_Примеры.TabIndex = 0;
            // 
            // tab_Тесты
            // 
            this.tab_Тесты.Controls.Add(this.split_Тесты);
            this.tab_Тесты.Location = new System.Drawing.Point(4, 22);
            this.tab_Тесты.Margin = new System.Windows.Forms.Padding(2);
            this.tab_Тесты.Name = "tab_Тесты";
            this.tab_Тесты.Padding = new System.Windows.Forms.Padding(2);
            this.tab_Тесты.Size = new System.Drawing.Size(776, 411);
            this.tab_Тесты.TabIndex = 2;
            this.tab_Тесты.Text = "Тесты";
            this.tab_Тесты.UseVisualStyleBackColor = true;
            // 
            // split_Тесты
            // 
            this.split_Тесты.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.split_Тесты.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split_Тесты.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.split_Тесты.Location = new System.Drawing.Point(2, 2);
            this.split_Тесты.Margin = new System.Windows.Forms.Padding(2);
            this.split_Тесты.Name = "split_Тесты";
            // 
            // split_Тесты.Panel1
            // 
            this.split_Тесты.Panel1.Controls.Add(this.tree_Тесты);
            // 
            // split_Тесты.Panel2
            // 
            this.split_Тесты.Panel2.AutoScroll = true;
            this.split_Тесты.Size = new System.Drawing.Size(772, 407);
            this.split_Тесты.SplitterDistance = 275;
            this.split_Тесты.SplitterWidth = 3;
            this.split_Тесты.TabIndex = 0;
            // 
            // tree_Тесты
            // 
            this.tree_Тесты.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tree_Тесты.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tree_Тесты.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tree_Тесты.HideSelection = false;
            this.tree_Тесты.Location = new System.Drawing.Point(0, 0);
            this.tree_Тесты.Margin = new System.Windows.Forms.Padding(2);
            this.tree_Тесты.Name = "tree_Тесты";
            this.tree_Тесты.Size = new System.Drawing.Size(273, 405);
            this.tree_Тесты.TabIndex = 0;
            this.tree_Тесты.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewSelection);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.калькуляторыToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // калькуляторыToolStripMenuItem
            // 
            this.калькуляторыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.матрицыToolStripMenuItem,
            this.комплексныеЧислаToolStripMenuItem});
            this.калькуляторыToolStripMenuItem.Name = "калькуляторыToolStripMenuItem";
            this.калькуляторыToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.калькуляторыToolStripMenuItem.Text = "Калькуляторы";
            // 
            // матрицыToolStripMenuItem
            // 
            this.матрицыToolStripMenuItem.Name = "матрицыToolStripMenuItem";
            this.матрицыToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.матрицыToolStripMenuItem.Text = "Матрицы";
            this.матрицыToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // комплексныеЧислаToolStripMenuItem
            // 
            this.комплексныеЧислаToolStripMenuItem.Name = "комплексныеЧислаToolStripMenuItem";
            this.комплексныеЧислаToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.комплексныеЧислаToolStripMenuItem.Text = "Комплексные числа";
            this.комплексныеЧислаToolStripMenuItem.Click += new System.EventHandler(this.комплексныеЧислаToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.tool_settings_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tab_control_main);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Электронный учебник. Алгебра и геометрия";
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.tab_control_main.ResumeLayout(false);
            this.tab_Теория.ResumeLayout(false);
            this.split_Теория.Panel1.ResumeLayout(false);
            this.split_Теория.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split_Теория)).EndInit();
            this.split_Теория.ResumeLayout(false);
            this.tab_Примеры.ResumeLayout(false);
            this.split_Примеры.Panel1.ResumeLayout(false);
            this.split_Примеры.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split_Примеры)).EndInit();
            this.split_Примеры.ResumeLayout(false);
            this.tab_Тесты.ResumeLayout(false);
            this.split_Тесты.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split_Тесты)).EndInit();
            this.split_Тесты.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView tree_Теория;
        private System.Windows.Forms.TabControl tab_control_main;
        private System.Windows.Forms.TabPage tab_Теория;
        private System.Windows.Forms.TabPage tab_Примеры;
        private System.Windows.Forms.TabPage tab_Тесты;
        private System.Windows.Forms.WebBrowser browser_Теория;
        private System.Windows.Forms.SplitContainer split_Теория;
        private System.Windows.Forms.SplitContainer split_Примеры;
        private System.Windows.Forms.TreeView tree_Примеры;
        private System.Windows.Forms.SplitContainer split_Тесты;
        private System.Windows.Forms.TreeView tree_Тесты;
        private System.Windows.Forms.WebBrowser browser_Примеры;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem калькуляторыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матрицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem комплексныеЧислаToolStripMenuItem;
    }
}

