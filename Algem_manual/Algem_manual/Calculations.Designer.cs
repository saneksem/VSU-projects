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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.gbx_определитель = new System.Windows.Forms.GroupBox();
            this.chbx_определитель_разложение_строка = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chbx_определитель_разложение_столбец = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.chbx_определитель_лаплас = new System.Windows.Forms.CheckBox();
            this.gbx_ранг = new System.Windows.Forms.GroupBox();
            this.chbx_ранг = new System.Windows.Forms.CheckBox();
            this.gbx_обратная_матрица = new System.Windows.Forms.GroupBox();
            this.chbx_обратная_матрица_приписывание = new System.Windows.Forms.CheckBox();
            this.chbx_обратная_матрица_алг_дополнение = new System.Windows.Forms.CheckBox();
            this.gbx_слу = new System.Windows.Forms.GroupBox();
            this.chbx_слу_крит_совместности = new System.Windows.Forms.CheckBox();
            this.chbx_слу_гаусс = new System.Windows.Forms.CheckBox();
            this.chbx_details = new System.Windows.Forms.CheckBox();
            this.gbx_две_матр_действия = new System.Windows.Forms.GroupBox();
            this.gbx_две_матр_действия_сложение = new System.Windows.Forms.CheckBox();
            this.gbx_две_матр_действия_вычитание = new System.Windows.Forms.CheckBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.gbx_две_матр_действия_умножение = new System.Windows.Forms.CheckBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.btn_определитель = new System.Windows.Forms.Button();
            this.chbx_определитель_саррюс = new System.Windows.Forms.CheckBox();
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
            this.gbx_определитель.SuspendLayout();
            this.gbx_ранг.SuspendLayout();
            this.gbx_обратная_матрица.SuspendLayout();
            this.gbx_слу.SuspendLayout();
            this.gbx_две_матр_действия.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtr1row
            // 
            this.mtr1row.Location = new System.Drawing.Point(4, 4);
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
            this.mtr1col.Location = new System.Drawing.Point(59, 4);
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
            this.dgv_mtr1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_mtr1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_mtr1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_mtr1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mtr1.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_mtr1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_mtr1.Location = new System.Drawing.Point(4, 32);
            this.dgv_mtr1.MultiSelect = false;
            this.dgv_mtr1.Name = "dgv_mtr1";
            this.dgv_mtr1.RowHeadersVisible = false;
            this.dgv_mtr1.RowTemplate.Height = 24;
            this.dgv_mtr1.Size = new System.Drawing.Size(339, 123);
            this.dgv_mtr1.TabIndex = 0;
            // 
            // dgv_mtr2
            // 
            this.dgv_mtr2.AllowUserToAddRows = false;
            this.dgv_mtr2.AllowUserToDeleteRows = false;
            this.dgv_mtr2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_mtr2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mtr2.Location = new System.Drawing.Point(3, 32);
            this.dgv_mtr2.Name = "dgv_mtr2";
            this.dgv_mtr2.RowTemplate.Height = 24;
            this.dgv_mtr2.Size = new System.Drawing.Size(356, 123);
            this.dgv_mtr2.TabIndex = 0;
            // 
            // mtr2row
            // 
            this.mtr2row.Location = new System.Drawing.Point(3, 3);
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
            this.mtr2col.Location = new System.Drawing.Point(53, 3);
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
            this.splitContainerMatrix.Panel1.Controls.Add(this.gbx_слу);
            this.splitContainerMatrix.Panel1.Controls.Add(this.gbx_обратная_матрица);
            this.splitContainerMatrix.Panel1.Controls.Add(this.gbx_ранг);
            this.splitContainerMatrix.Panel1.Controls.Add(this.gbx_определитель);
            this.splitContainerMatrix.Panel1.Controls.Add(this.dgv_mtr1);
            this.splitContainerMatrix.Panel1.Controls.Add(this.mtr1row);
            this.splitContainerMatrix.Panel1.Controls.Add(this.mtr1col);
            // 
            // splitContainerMatrix.Panel2
            // 
            this.splitContainerMatrix.Panel2.Controls.Add(this.gbx_две_матр_действия);
            this.splitContainerMatrix.Panel2.Controls.Add(this.button5);
            this.splitContainerMatrix.Panel2.Controls.Add(this.mtr2col);
            this.splitContainerMatrix.Panel2.Controls.Add(this.button4);
            this.splitContainerMatrix.Panel2.Controls.Add(this.dgv_mtr2);
            this.splitContainerMatrix.Panel2.Controls.Add(this.button3);
            this.splitContainerMatrix.Panel2.Controls.Add(this.mtr2row);
            this.splitContainerMatrix.Panel2.Controls.Add(this.button2);
            this.splitContainerMatrix.Panel2.Controls.Add(this.button1);
            this.splitContainerMatrix.Panel2MinSize = 0;
            this.splitContainerMatrix.Size = new System.Drawing.Size(729, 499);
            this.splitContainerMatrix.SplitterDistance = 346;
            this.splitContainerMatrix.SplitterWidth = 15;
            this.splitContainerMatrix.TabIndex = 0;
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(12, 506);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(101, 35);
            this.btn_calculate.TabIndex = 2;
            this.btn_calculate.Text = "Посчитать";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // btn_show_panel2
            // 
            this.btn_show_panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_show_panel2.Location = new System.Drawing.Point(548, 510);
            this.btn_show_panel2.Name = "btn_show_panel2";
            this.btn_show_panel2.Size = new System.Drawing.Size(193, 37);
            this.btn_show_panel2.TabIndex = 3;
            this.btn_show_panel2.Text = "Показать вторую матрицу";
            this.btn_show_panel2.UseVisualStyleBackColor = true;
            this.btn_show_panel2.Click += new System.EventHandler(this.btn_show_panel2_Click);
            // 
            // tbx_output
            // 
            this.tbx_output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_output.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbx_output.Location = new System.Drawing.Point(12, 567);
            this.tbx_output.Multiline = true;
            this.tbx_output.Name = "tbx_output";
            this.tbx_output.ReadOnly = true;
            this.tbx_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_output.Size = new System.Drawing.Size(729, 180);
            this.tbx_output.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 545);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Результаты:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 24);
            this.button1.TabIndex = 7;
            this.button1.Text = "Определитель по Саррюсу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 24);
            this.button2.TabIndex = 8;
            this.button2.Text = "+ Матрицы";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 345);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "- Матрицы";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(8, 284);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(206, 25);
            this.button4.TabIndex = 10;
            this.button4.Text = "* матрицы";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(8, 404);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(213, 24);
            this.button5.TabIndex = 11;
            this.button5.Text = "Ранг матрицы";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // gbx_определитель
            // 
            this.gbx_определитель.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbx_определитель.Controls.Add(this.chbx_определитель_саррюс);
            this.gbx_определитель.Controls.Add(this.btn_определитель);
            this.gbx_определитель.Controls.Add(this.chbx_определитель_лаплас);
            this.gbx_определитель.Controls.Add(this.comboBox2);
            this.gbx_определитель.Controls.Add(this.chbx_определитель_разложение_столбец);
            this.gbx_определитель.Controls.Add(this.comboBox1);
            this.gbx_определитель.Controls.Add(this.chbx_определитель_разложение_строка);
            this.gbx_определитель.Location = new System.Drawing.Point(4, 162);
            this.gbx_определитель.Name = "gbx_определитель";
            this.gbx_определитель.Size = new System.Drawing.Size(339, 112);
            this.gbx_определитель.TabIndex = 3;
            this.gbx_определитель.TabStop = false;
            this.gbx_определитель.Text = "Определитель";
            // 
            // chbx_определитель_разложение_строка
            // 
            this.chbx_определитель_разложение_строка.AutoSize = true;
            this.chbx_определитель_разложение_строка.Location = new System.Drawing.Point(7, 22);
            this.chbx_определитель_разложение_строка.Name = "chbx_определитель_разложение_строка";
            this.chbx_определитель_разложение_строка.Size = new System.Drawing.Size(180, 21);
            this.chbx_определитель_разложение_строка.TabIndex = 0;
            this.chbx_определитель_разложение_строка.Text = "Разложение по строке";
            this.chbx_определитель_разложение_строка.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(201, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(99, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // chbx_определитель_разложение_столбец
            // 
            this.chbx_определитель_разложение_столбец.AutoSize = true;
            this.chbx_определитель_разложение_столбец.Location = new System.Drawing.Point(7, 50);
            this.chbx_определитель_разложение_столбец.Name = "chbx_определитель_разложение_столбец";
            this.chbx_определитель_разложение_столбец.Size = new System.Drawing.Size(188, 21);
            this.chbx_определитель_разложение_столбец.TabIndex = 2;
            this.chbx_определитель_разложение_столбец.Text = "Разложение по столбцу";
            this.chbx_определитель_разложение_столбец.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(201, 48);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(99, 24);
            this.comboBox2.TabIndex = 3;
            // 
            // chbx_определитель_лаплас
            // 
            this.chbx_определитель_лаплас.AutoSize = true;
            this.chbx_определитель_лаплас.Location = new System.Drawing.Point(7, 77);
            this.chbx_определитель_лаплас.Name = "chbx_определитель_лаплас";
            this.chbx_определитель_лаплас.Size = new System.Drawing.Size(108, 21);
            this.chbx_определитель_лаплас.TabIndex = 4;
            this.chbx_определитель_лаплас.Text = "По Лапласу";
            this.chbx_определитель_лаплас.UseVisualStyleBackColor = true;
            // 
            // gbx_ранг
            // 
            this.gbx_ранг.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbx_ранг.Controls.Add(this.chbx_ранг);
            this.gbx_ранг.Location = new System.Drawing.Point(4, 280);
            this.gbx_ранг.Name = "gbx_ранг";
            this.gbx_ранг.Size = new System.Drawing.Size(339, 59);
            this.gbx_ранг.TabIndex = 4;
            this.gbx_ранг.TabStop = false;
            this.gbx_ранг.Text = "Ранг";
            // 
            // chbx_ранг
            // 
            this.chbx_ранг.AutoSize = true;
            this.chbx_ранг.Location = new System.Drawing.Point(7, 22);
            this.chbx_ранг.Name = "chbx_ранг";
            this.chbx_ранг.Size = new System.Drawing.Size(153, 21);
            this.chbx_ранг.TabIndex = 0;
            this.chbx_ранг.Text = "Вычисление ранга";
            this.chbx_ранг.UseVisualStyleBackColor = true;
            // 
            // gbx_обратная_матрица
            // 
            this.gbx_обратная_матрица.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbx_обратная_матрица.Controls.Add(this.chbx_обратная_матрица_алг_дополнение);
            this.gbx_обратная_матрица.Controls.Add(this.chbx_обратная_матрица_приписывание);
            this.gbx_обратная_матрица.Location = new System.Drawing.Point(4, 346);
            this.gbx_обратная_матрица.Name = "gbx_обратная_матрица";
            this.gbx_обратная_матрица.Size = new System.Drawing.Size(339, 69);
            this.gbx_обратная_матрица.TabIndex = 5;
            this.gbx_обратная_матрица.TabStop = false;
            this.gbx_обратная_матрица.Text = "Обратная матрица";
            // 
            // chbx_обратная_матрица_приписывание
            // 
            this.chbx_обратная_матрица_приписывание.AutoSize = true;
            this.chbx_обратная_матрица_приписывание.Location = new System.Drawing.Point(7, 21);
            this.chbx_обратная_матрица_приписывание.Name = "chbx_обратная_матрица_приписывание";
            this.chbx_обратная_матрица_приписывание.Size = new System.Drawing.Size(270, 21);
            this.chbx_обратная_матрица_приписывание.TabIndex = 0;
            this.chbx_обратная_матрица_приписывание.Text = "Нахождение приписыванием справа";
            this.chbx_обратная_матрица_приписывание.UseVisualStyleBackColor = true;
            // 
            // chbx_обратная_матрица_алг_дополнение
            // 
            this.chbx_обратная_матрица_алг_дополнение.AutoSize = true;
            this.chbx_обратная_матрица_алг_дополнение.Location = new System.Drawing.Point(7, 43);
            this.chbx_обратная_матрица_алг_дополнение.Name = "chbx_обратная_матрица_алг_дополнение";
            this.chbx_обратная_матрица_алг_дополнение.Size = new System.Drawing.Size(270, 21);
            this.chbx_обратная_матрица_алг_дополнение.TabIndex = 1;
            this.chbx_обратная_матрица_алг_дополнение.Text = "Через алгебраическое дополнение ";
            this.chbx_обратная_матрица_алг_дополнение.UseVisualStyleBackColor = true;
            // 
            // gbx_слу
            // 
            this.gbx_слу.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbx_слу.Controls.Add(this.chbx_слу_гаусс);
            this.gbx_слу.Controls.Add(this.chbx_слу_крит_совместности);
            this.gbx_слу.Location = new System.Drawing.Point(4, 417);
            this.gbx_слу.Name = "gbx_слу";
            this.gbx_слу.Size = new System.Drawing.Size(339, 77);
            this.gbx_слу.TabIndex = 6;
            this.gbx_слу.TabStop = false;
            this.gbx_слу.Text = "Система линейных уравнений (СЛУ)";
            // 
            // chbx_слу_крит_совместности
            // 
            this.chbx_слу_крит_совместности.AutoSize = true;
            this.chbx_слу_крит_совместности.Location = new System.Drawing.Point(7, 22);
            this.chbx_слу_крит_совместности.Name = "chbx_слу_крит_совместности";
            this.chbx_слу_крит_совместности.Size = new System.Drawing.Size(255, 21);
            this.chbx_слу_крит_совместности.TabIndex = 0;
            this.chbx_слу_крит_совместности.Text = "Проверка критерия совместности";
            this.chbx_слу_крит_совместности.UseVisualStyleBackColor = true;
            // 
            // chbx_слу_гаусс
            // 
            this.chbx_слу_гаусс.AutoSize = true;
            this.chbx_слу_гаусс.Location = new System.Drawing.Point(7, 49);
            this.chbx_слу_гаусс.Name = "chbx_слу_гаусс";
            this.chbx_слу_гаусс.Size = new System.Drawing.Size(96, 21);
            this.chbx_слу_гаусс.TabIndex = 1;
            this.chbx_слу_гаусс.Text = "По Гауссу";
            this.chbx_слу_гаусс.UseVisualStyleBackColor = true;
            // 
            // chbx_details
            // 
            this.chbx_details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chbx_details.AutoSize = true;
            this.chbx_details.Location = new System.Drawing.Point(119, 514);
            this.chbx_details.Name = "chbx_details";
            this.chbx_details.Size = new System.Drawing.Size(167, 21);
            this.chbx_details.TabIndex = 7;
            this.chbx_details.Text = "Подробное решение";
            this.chbx_details.UseVisualStyleBackColor = true;
            // 
            // gbx_две_матр_действия
            // 
            this.gbx_две_матр_действия.Controls.Add(this.comboBox4);
            this.gbx_две_матр_действия.Controls.Add(this.gbx_две_матр_действия_умножение);
            this.gbx_две_матр_действия.Controls.Add(this.comboBox3);
            this.gbx_две_матр_действия.Controls.Add(this.gbx_две_матр_действия_вычитание);
            this.gbx_две_матр_действия.Controls.Add(this.gbx_две_матр_действия_сложение);
            this.gbx_две_матр_действия.Location = new System.Drawing.Point(8, 162);
            this.gbx_две_матр_действия.Name = "gbx_две_матр_действия";
            this.gbx_две_матр_действия.Size = new System.Drawing.Size(351, 100);
            this.gbx_две_матр_действия.TabIndex = 12;
            this.gbx_две_матр_действия.TabStop = false;
            this.gbx_две_матр_действия.Text = "Действия с двумя матрицами";
            // 
            // gbx_две_матр_действия_сложение
            // 
            this.gbx_две_матр_действия_сложение.AutoSize = true;
            this.gbx_две_матр_действия_сложение.Location = new System.Drawing.Point(6, 20);
            this.gbx_две_матр_действия_сложение.Name = "gbx_две_матр_действия_сложение";
            this.gbx_две_матр_действия_сложение.Size = new System.Drawing.Size(96, 21);
            this.gbx_две_матр_действия_сложение.TabIndex = 0;
            this.gbx_две_матр_действия_сложение.Text = "Сложение";
            this.gbx_две_матр_действия_сложение.UseVisualStyleBackColor = true;
            // 
            // gbx_две_матр_действия_вычитание
            // 
            this.gbx_две_матр_действия_вычитание.AutoSize = true;
            this.gbx_две_матр_действия_вычитание.Location = new System.Drawing.Point(6, 47);
            this.gbx_две_матр_действия_вычитание.Name = "gbx_две_матр_действия_вычитание";
            this.gbx_две_матр_действия_вычитание.Size = new System.Drawing.Size(104, 21);
            this.gbx_две_матр_действия_вычитание.TabIndex = 1;
            this.gbx_две_матр_действия_вычитание.Text = "Вычитание";
            this.gbx_две_матр_действия_вычитание.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(116, 44);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(100, 24);
            this.comboBox3.TabIndex = 2;
            // 
            // gbx_две_матр_действия_умножение
            // 
            this.gbx_две_матр_действия_умножение.AutoSize = true;
            this.gbx_две_матр_действия_умножение.Location = new System.Drawing.Point(6, 73);
            this.gbx_две_матр_действия_умножение.Name = "gbx_две_матр_действия_умножение";
            this.gbx_две_матр_действия_умножение.Size = new System.Drawing.Size(105, 21);
            this.gbx_две_матр_действия_умножение.TabIndex = 3;
            this.gbx_две_матр_действия_умножение.Text = "Умножение";
            this.gbx_две_матр_действия_умножение.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(116, 70);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(100, 24);
            this.comboBox4.TabIndex = 4;
            // 
            // btn_определитель
            // 
            this.btn_определитель.Location = new System.Drawing.Point(112, -3);
            this.btn_определитель.Name = "btn_определитель";
            this.btn_определитель.Size = new System.Drawing.Size(75, 25);
            this.btn_определитель.TabIndex = 5;
            this.btn_определитель.Text = "Скрыть";
            this.btn_определитель.UseVisualStyleBackColor = true;
            this.btn_определитель.Click += new System.EventHandler(this.btn_определитель_Click);
            // 
            // chbx_определитель_саррюс
            // 
            this.chbx_определитель_саррюс.AutoSize = true;
            this.chbx_определитель_саррюс.Location = new System.Drawing.Point(121, 77);
            this.chbx_определитель_саррюс.Name = "chbx_определитель_саррюс";
            this.chbx_определитель_саррюс.Size = new System.Drawing.Size(109, 21);
            this.chbx_определитель_саррюс.TabIndex = 6;
            this.chbx_определитель_саррюс.Text = "По Саррюсу";
            this.chbx_определитель_саррюс.UseVisualStyleBackColor = true;
            // 
            // Calculations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 759);
            this.Controls.Add(this.chbx_details);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_output);
            this.Controls.Add(this.btn_show_panel2);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.splitContainerMatrix);
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
            this.gbx_определитель.ResumeLayout(false);
            this.gbx_определитель.PerformLayout();
            this.gbx_ранг.ResumeLayout(false);
            this.gbx_ранг.PerformLayout();
            this.gbx_обратная_матрица.ResumeLayout(false);
            this.gbx_обратная_матрица.PerformLayout();
            this.gbx_слу.ResumeLayout(false);
            this.gbx_слу.PerformLayout();
            this.gbx_две_матр_действия.ResumeLayout(false);
            this.gbx_две_матр_действия.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.GroupBox gbx_обратная_матрица;
        private System.Windows.Forms.CheckBox chbx_обратная_матрица_алг_дополнение;
        private System.Windows.Forms.CheckBox chbx_обратная_матрица_приписывание;
        private System.Windows.Forms.GroupBox gbx_ранг;
        private System.Windows.Forms.CheckBox chbx_ранг;
        private System.Windows.Forms.GroupBox gbx_определитель;
        private System.Windows.Forms.CheckBox chbx_определитель_лаплас;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox chbx_определитель_разложение_столбец;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox chbx_определитель_разложение_строка;
        private System.Windows.Forms.GroupBox gbx_слу;
        private System.Windows.Forms.CheckBox chbx_слу_гаусс;
        private System.Windows.Forms.CheckBox chbx_слу_крит_совместности;
        private System.Windows.Forms.CheckBox chbx_details;
        private System.Windows.Forms.GroupBox gbx_две_матр_действия;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.CheckBox gbx_две_матр_действия_умножение;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.CheckBox gbx_две_матр_действия_вычитание;
        private System.Windows.Forms.CheckBox gbx_две_матр_действия_сложение;
        private System.Windows.Forms.Button btn_определитель;
        private System.Windows.Forms.CheckBox chbx_определитель_саррюс;
    }
}