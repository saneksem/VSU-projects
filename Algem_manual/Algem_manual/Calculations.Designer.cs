namespace Algem_manual
{
    partial class Calculations
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.mtr1row = new System.Windows.Forms.NumericUpDown();
            this.mtr1col = new System.Windows.Forms.NumericUpDown();
            this.dgv_mtr1 = new System.Windows.Forms.DataGridView();
            this.dgv_mtr2 = new System.Windows.Forms.DataGridView();
            this.mtr2row = new System.Windows.Forms.NumericUpDown();
            this.mtr2col = new System.Windows.Forms.NumericUpDown();
            this.splitContainerMatrix = new System.Windows.Forms.SplitContainer();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_show_panel2 = new System.Windows.Forms.Button();
            this.tbx_output = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mtr1row)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtr1col)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mtr1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mtr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtr2row)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtr2col)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMatrix)).BeginInit();
            this.splitContainerMatrix.Panel1.SuspendLayout();
            this.splitContainerMatrix.Panel2.SuspendLayout();
            this.splitContainerMatrix.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Определитель (разложение по строке)",
            "Определитель (теорема Лапласа)",
            "Ранг",
            "Обратная матрица (алгебраическое дополнение)",
            "Обратная матрица (приписывание единичной справа)"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 160);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(434, 21);
            this.checkedListBox1.TabIndex = 1;
            this.checkedListBox1.ThreeDCheckBoxes = true;
            // 
            // mtr1row
            // 
            this.mtr1row.Location = new System.Drawing.Point(22, 4);
            this.mtr1row.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.mtr1row.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.mtr1row.Name = "mtr1row";
            this.mtr1row.Size = new System.Drawing.Size(49, 22);
            this.mtr1row.TabIndex = 1;
            this.mtr1row.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.mtr1row.ValueChanged += new System.EventHandler(this.mtr1row_changed);
            // 
            // mtr1col
            // 
            this.mtr1col.Location = new System.Drawing.Point(77, 4);
            this.mtr1col.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.mtr1col.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.mtr1col.Name = "mtr1col";
            this.mtr1col.Size = new System.Drawing.Size(46, 22);
            this.mtr1col.TabIndex = 2;
            this.mtr1col.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.mtr1col.ValueChanged += new System.EventHandler(this.mtr1col_changed);
            // 
            // dgv_mtr1
            // 
            this.dgv_mtr1.AllowUserToAddRows = false;
            this.dgv_mtr1.AllowUserToDeleteRows = false;
            this.dgv_mtr1.AllowUserToResizeColumns = false;
            this.dgv_mtr1.AllowUserToResizeRows = false;
            this.dgv_mtr1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_mtr1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_mtr1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mtr1.ColumnHeadersVisible = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_mtr1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_mtr1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_mtr1.Location = new System.Drawing.Point(0, 30);
            this.dgv_mtr1.MultiSelect = false;
            this.dgv_mtr1.Name = "dgv_mtr1";
            this.dgv_mtr1.RowHeadersVisible = false;
            this.dgv_mtr1.RowTemplate.Height = 24;
            this.dgv_mtr1.Size = new System.Drawing.Size(209, 123);
            this.dgv_mtr1.TabIndex = 0;
            // 
            // dgv_mtr2
            // 
            this.dgv_mtr2.AllowUserToAddRows = false;
            this.dgv_mtr2.AllowUserToDeleteRows = false;
            this.dgv_mtr2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mtr2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_mtr2.Location = new System.Drawing.Point(0, 30);
            this.dgv_mtr2.Name = "dgv_mtr2";
            this.dgv_mtr2.RowTemplate.Height = 24;
            this.dgv_mtr2.Size = new System.Drawing.Size(210, 123);
            this.dgv_mtr2.TabIndex = 0;
            // 
            // mtr2row
            // 
            this.mtr2row.Location = new System.Drawing.Point(14, 4);
            this.mtr2row.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.mtr2row.Name = "mtr2row";
            this.mtr2row.Size = new System.Drawing.Size(44, 22);
            this.mtr2row.TabIndex = 1;
            this.mtr2row.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.mtr2row.ValueChanged += new System.EventHandler(this.mtr2row_changed);
            // 
            // mtr2col
            // 
            this.mtr2col.Location = new System.Drawing.Point(64, 4);
            this.mtr2col.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.mtr2col.Name = "mtr2col";
            this.mtr2col.Size = new System.Drawing.Size(44, 22);
            this.mtr2col.TabIndex = 2;
            this.mtr2col.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.mtr2col.ValueChanged += new System.EventHandler(this.mtr2col_changed);
            // 
            // splitContainerMatrix
            // 
            this.splitContainerMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerMatrix.Location = new System.Drawing.Point(12, 1);
            this.splitContainerMatrix.Name = "splitContainerMatrix";
            // 
            // splitContainerMatrix.Panel1
            // 
            this.splitContainerMatrix.Panel1.Controls.Add(this.dgv_mtr1);
            this.splitContainerMatrix.Panel1.Controls.Add(this.mtr1row);
            this.splitContainerMatrix.Panel1.Controls.Add(this.mtr1col);
            // 
            // splitContainerMatrix.Panel2
            // 
            this.splitContainerMatrix.Panel2.Controls.Add(this.mtr2col);
            this.splitContainerMatrix.Panel2.Controls.Add(this.dgv_mtr2);
            this.splitContainerMatrix.Panel2.Controls.Add(this.mtr2row);
            this.splitContainerMatrix.Panel2MinSize = 0;
            this.splitContainerMatrix.Size = new System.Drawing.Size(434, 153);
            this.splitContainerMatrix.SplitterDistance = 209;
            this.splitContainerMatrix.SplitterWidth = 15;
            this.splitContainerMatrix.TabIndex = 0;
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(13, 272);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(101, 35);
            this.btn_calculate.TabIndex = 2;
            this.btn_calculate.Text = "Посчитать";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // btn_show_panel2
            // 
            this.btn_show_panel2.Location = new System.Drawing.Point(253, 272);
            this.btn_show_panel2.Name = "btn_show_panel2";
            this.btn_show_panel2.Size = new System.Drawing.Size(193, 37);
            this.btn_show_panel2.TabIndex = 3;
            this.btn_show_panel2.Text = "Показать вторую матрицу";
            this.btn_show_panel2.UseVisualStyleBackColor = true;
            this.btn_show_panel2.Click += new System.EventHandler(this.btn_show_panel2_Click);
            // 
            // tbx_output
            // 
            this.tbx_output.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbx_output.Location = new System.Drawing.Point(12, 334);
            this.tbx_output.Multiline = true;
            this.tbx_output.Name = "tbx_output";
            this.tbx_output.ReadOnly = true;
            this.tbx_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_output.Size = new System.Drawing.Size(433, 110);
            this.tbx_output.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Результаты:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 24);
            this.button1.TabIndex = 7;
            this.button1.Text = "Определитель по Саррюсу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(236, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 24);
            this.button2.TabIndex = 8;
            this.button2.Text = "+ Матрицы";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(335, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "- Матрицы";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(239, 218);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(206, 25);
            this.button4.TabIndex = 10;
            this.button4.Text = "* матрицы";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(17, 218);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(213, 24);
            this.button5.TabIndex = 11;
            this.button5.Text = "Ранг матрицы";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Calculations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 456);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_output);
            this.Controls.Add(this.btn_show_panel2);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.splitContainerMatrix);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Calculations";
            this.ShowIcon = false;
            this.Text = "Калькулятор матриц";
            ((System.ComponentModel.ISupportInitialize)(this.mtr1row)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtr1col)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mtr1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mtr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtr2row)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtr2col)).EndInit();
            this.splitContainerMatrix.Panel1.ResumeLayout(false);
            this.splitContainerMatrix.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMatrix)).EndInit();
            this.splitContainerMatrix.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.NumericUpDown mtr1row;
        private System.Windows.Forms.NumericUpDown mtr1col;
        private System.Windows.Forms.DataGridView dgv_mtr1;
        private System.Windows.Forms.NumericUpDown mtr2col;
        private System.Windows.Forms.NumericUpDown mtr2row;
        private System.Windows.Forms.DataGridView dgv_mtr2;
        private System.Windows.Forms.SplitContainer splitContainerMatrix;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Button btn_show_panel2;
        private System.Windows.Forms.TextBox tbx_output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}