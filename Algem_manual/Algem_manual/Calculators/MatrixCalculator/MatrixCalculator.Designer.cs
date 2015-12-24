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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mtr1row = new System.Windows.Forms.NumericUpDown();
            this.mtr1col = new System.Windows.Forms.NumericUpDown();
            this.dgv_mtr1 = new System.Windows.Forms.DataGridView();
            this.dgv_mtr2 = new System.Windows.Forms.DataGridView();
            this.mtr2row = new System.Windows.Forms.NumericUpDown();
            this.mtr2col = new System.Windows.Forms.NumericUpDown();
            this.splitContainerMatrix = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbx_определитель = new System.Windows.Forms.GroupBox();
            this.cmbx_определитель_лаплас_2 = new System.Windows.Forms.ComboBox();
            this.cmbx_определитель_лаплас = new System.Windows.Forms.ComboBox();
            this.chbx_определитель_саррюс = new System.Windows.Forms.CheckBox();
            this.btn_определитель = new System.Windows.Forms.Button();
            this.chbx_определитель_лаплас = new System.Windows.Forms.CheckBox();
            this.cmbx_определитель_разложение_столбец = new System.Windows.Forms.ComboBox();
            this.chbx_определитель_разложение_столбец = new System.Windows.Forms.CheckBox();
            this.cmbx_определитель_разложение_строка = new System.Windows.Forms.ComboBox();
            this.chbx_определитель_разложение_строка = new System.Windows.Forms.CheckBox();
            this.gbx_ранг = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chbx_ранг = new System.Windows.Forms.CheckBox();
            this.gbx_слу = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.chbx_слу_гаусс = new System.Windows.Forms.CheckBox();
            this.chbx_слу_крит_совместности = new System.Windows.Forms.CheckBox();
            this.gbx_обратная_матрица = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.chbx_обратная_матрица_алг_дополнение = new System.Windows.Forms.CheckBox();
            this.chbx_обратная_матрица_приписывание = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbx_две_матр_действия = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.cmbx_две_матр_действия_умножение = new System.Windows.Forms.ComboBox();
            this.chbx_две_матр_действия_умножение = new System.Windows.Forms.CheckBox();
            this.cmbx_две_матр_действия_вычитание = new System.Windows.Forms.ComboBox();
            this.chbx_две_матр_действия_вычитание = new System.Windows.Forms.CheckBox();
            this.chbx_две_матр_действия_сложение = new System.Windows.Forms.CheckBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_show_panel2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chbx_details = new System.Windows.Forms.CheckBox();
            this.browser_results = new System.Windows.Forms.WebBrowser();
            this.btn_show_hide = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.groupBox1.SuspendLayout();
            this.gbx_определитель.SuspendLayout();
            this.gbx_ранг.SuspendLayout();
            this.gbx_слу.SuspendLayout();
            this.gbx_обратная_матрица.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbx_две_матр_действия.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtr1row
            // 
            this.mtr1row.Location = new System.Drawing.Point(8, 19);
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
            this.mtr1col.Location = new System.Drawing.Point(65, 19);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_mtr1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_mtr1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_mtr1.Location = new System.Drawing.Point(0, 44);
            this.dgv_mtr1.MultiSelect = false;
            this.dgv_mtr1.Name = "dgv_mtr1";
            this.dgv_mtr1.RowHeadersVisible = false;
            this.dgv_mtr1.RowTemplate.Height = 24;
            this.dgv_mtr1.Size = new System.Drawing.Size(357, 101);
            this.dgv_mtr1.TabIndex = 0;
            // 
            // dgv_mtr2
            // 
            this.dgv_mtr2.AllowUserToAddRows = false;
            this.dgv_mtr2.AllowUserToDeleteRows = false;
            this.dgv_mtr2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mtr2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_mtr2.Location = new System.Drawing.Point(0, 48);
            this.dgv_mtr2.Name = "dgv_mtr2";
            this.dgv_mtr2.RowTemplate.Height = 24;
            this.dgv_mtr2.Size = new System.Drawing.Size(381, 224);
            this.dgv_mtr2.TabIndex = 0;
            // 
            // mtr2row
            // 
            this.mtr2row.Location = new System.Drawing.Point(6, 21);
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
            this.mtr2col.Location = new System.Drawing.Point(56, 21);
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
            this.splitContainerMatrix.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainerMatrix.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMatrix.MinimumSize = new System.Drawing.Size(729, 0);
            this.splitContainerMatrix.Name = "splitContainerMatrix";
            // 
            // splitContainerMatrix.Panel1
            // 
            this.splitContainerMatrix.Panel1.Controls.Add(this.dgv_mtr1);
            this.splitContainerMatrix.Panel1.Controls.Add(this.groupBox1);
            this.splitContainerMatrix.Panel1.Controls.Add(this.gbx_определитель);
            this.splitContainerMatrix.Panel1.Controls.Add(this.gbx_ранг);
            this.splitContainerMatrix.Panel1.Controls.Add(this.gbx_слу);
            this.splitContainerMatrix.Panel1.Controls.Add(this.gbx_обратная_матрица);
            // 
            // splitContainerMatrix.Panel2
            // 
            this.splitContainerMatrix.Panel2.Controls.Add(this.dgv_mtr2);
            this.splitContainerMatrix.Panel2.Controls.Add(this.groupBox2);
            this.splitContainerMatrix.Panel2.Controls.Add(this.gbx_две_матр_действия);
            this.splitContainerMatrix.Panel2MinSize = 0;
            this.splitContainerMatrix.Size = new System.Drawing.Size(753, 372);
            this.splitContainerMatrix.SplitterDistance = 357;
            this.splitContainerMatrix.SplitterWidth = 15;
            this.splitContainerMatrix.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtr1col);
            this.groupBox1.Controls.Add(this.mtr1row);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 44);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Матрица 1";
            // 
            // gbx_определитель
            // 
            this.gbx_определитель.Controls.Add(this.cmbx_определитель_лаплас_2);
            this.gbx_определитель.Controls.Add(this.cmbx_определитель_лаплас);
            this.gbx_определитель.Controls.Add(this.chbx_определитель_саррюс);
            this.gbx_определитель.Controls.Add(this.btn_определитель);
            this.gbx_определитель.Controls.Add(this.chbx_определитель_лаплас);
            this.gbx_определитель.Controls.Add(this.cmbx_определитель_разложение_столбец);
            this.gbx_определитель.Controls.Add(this.chbx_определитель_разложение_столбец);
            this.gbx_определитель.Controls.Add(this.cmbx_определитель_разложение_строка);
            this.gbx_определитель.Controls.Add(this.chbx_определитель_разложение_строка);
            this.gbx_определитель.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbx_определитель.Location = new System.Drawing.Point(0, 145);
            this.gbx_определитель.Name = "gbx_определитель";
            this.gbx_определитель.Size = new System.Drawing.Size(357, 128);
            this.gbx_определитель.TabIndex = 3;
            this.gbx_определитель.TabStop = false;
            this.gbx_определитель.Text = "Определитель";
            // 
            // cmbx_определитель_лаплас_2
            // 
            this.cmbx_определитель_лаплас_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_определитель_лаплас_2.FormattingEnabled = true;
            this.cmbx_определитель_лаплас_2.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbx_определитель_лаплас_2.Location = new System.Drawing.Point(265, 101);
            this.cmbx_определитель_лаплас_2.Name = "cmbx_определитель_лаплас_2";
            this.cmbx_определитель_лаплас_2.Size = new System.Drawing.Size(68, 24);
            this.cmbx_определитель_лаплас_2.TabIndex = 8;
            // 
            // cmbx_определитель_лаплас
            // 
            this.cmbx_определитель_лаплас.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_определитель_лаплас.FormattingEnabled = true;
            this.cmbx_определитель_лаплас.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbx_определитель_лаплас.Location = new System.Drawing.Point(201, 101);
            this.cmbx_определитель_лаплас.Name = "cmbx_определитель_лаплас";
            this.cmbx_определитель_лаплас.Size = new System.Drawing.Size(58, 24);
            this.cmbx_определитель_лаплас.TabIndex = 7;
            // 
            // chbx_определитель_саррюс
            // 
            this.chbx_определитель_саррюс.AutoSize = true;
            this.chbx_определитель_саррюс.Location = new System.Drawing.Point(7, 21);
            this.chbx_определитель_саррюс.Name = "chbx_определитель_саррюс";
            this.chbx_определитель_саррюс.Size = new System.Drawing.Size(109, 21);
            this.chbx_определитель_саррюс.TabIndex = 6;
            this.chbx_определитель_саррюс.Text = "По Саррюсу";
            this.chbx_определитель_саррюс.UseVisualStyleBackColor = true;
            // 
            // btn_определитель
            // 
            this.btn_определитель.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_определитель.Location = new System.Drawing.Point(280, 0);
            this.btn_определитель.Name = "btn_определитель";
            this.btn_определитель.Size = new System.Drawing.Size(78, 23);
            this.btn_определитель.TabIndex = 5;
            this.btn_определитель.Text = "Скрыть";
            this.btn_определитель.UseVisualStyleBackColor = true;
            this.btn_определитель.Click += new System.EventHandler(this.show_hide_groupbox);
            // 
            // chbx_определитель_лаплас
            // 
            this.chbx_определитель_лаплас.AutoSize = true;
            this.chbx_определитель_лаплас.Location = new System.Drawing.Point(7, 100);
            this.chbx_определитель_лаплас.Name = "chbx_определитель_лаплас";
            this.chbx_определитель_лаплас.Size = new System.Drawing.Size(108, 21);
            this.chbx_определитель_лаплас.TabIndex = 4;
            this.chbx_определитель_лаплас.Text = "По Лапласу";
            this.chbx_определитель_лаплас.UseVisualStyleBackColor = true;
            // 
            // cmbx_определитель_разложение_столбец
            // 
            this.cmbx_определитель_разложение_столбец.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_определитель_разложение_столбец.FormattingEnabled = true;
            this.cmbx_определитель_разложение_столбец.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbx_определитель_разложение_столбец.Location = new System.Drawing.Point(201, 71);
            this.cmbx_определитель_разложение_столбец.Name = "cmbx_определитель_разложение_столбец";
            this.cmbx_определитель_разложение_столбец.Size = new System.Drawing.Size(132, 24);
            this.cmbx_определитель_разложение_столбец.TabIndex = 3;
            // 
            // chbx_определитель_разложение_столбец
            // 
            this.chbx_определитель_разложение_столбец.AutoSize = true;
            this.chbx_определитель_разложение_столбец.Location = new System.Drawing.Point(7, 73);
            this.chbx_определитель_разложение_столбец.Name = "chbx_определитель_разложение_столбец";
            this.chbx_определитель_разложение_столбец.Size = new System.Drawing.Size(188, 21);
            this.chbx_определитель_разложение_столбец.TabIndex = 2;
            this.chbx_определитель_разложение_столбец.Text = "Разложение по столбцу";
            this.chbx_определитель_разложение_столбец.UseVisualStyleBackColor = true;
            // 
            // cmbx_определитель_разложение_строка
            // 
            this.cmbx_определитель_разложение_строка.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_определитель_разложение_строка.FormattingEnabled = true;
            this.cmbx_определитель_разложение_строка.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbx_определитель_разложение_строка.Location = new System.Drawing.Point(201, 43);
            this.cmbx_определитель_разложение_строка.Name = "cmbx_определитель_разложение_строка";
            this.cmbx_определитель_разложение_строка.Size = new System.Drawing.Size(132, 24);
            this.cmbx_определитель_разложение_строка.TabIndex = 1;
            // 
            // chbx_определитель_разложение_строка
            // 
            this.chbx_определитель_разложение_строка.AutoSize = true;
            this.chbx_определитель_разложение_строка.Location = new System.Drawing.Point(7, 46);
            this.chbx_определитель_разложение_строка.Name = "chbx_определитель_разложение_строка";
            this.chbx_определитель_разложение_строка.Size = new System.Drawing.Size(180, 21);
            this.chbx_определитель_разложение_строка.TabIndex = 0;
            this.chbx_определитель_разложение_строка.Text = "Разложение по строке";
            this.chbx_определитель_разложение_строка.UseVisualStyleBackColor = true;
            // 
            // gbx_ранг
            // 
            this.gbx_ранг.Controls.Add(this.button1);
            this.gbx_ранг.Controls.Add(this.chbx_ранг);
            this.gbx_ранг.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbx_ранг.Location = new System.Drawing.Point(0, 273);
            this.gbx_ранг.Name = "gbx_ранг";
            this.gbx_ранг.Size = new System.Drawing.Size(357, 53);
            this.gbx_ранг.TabIndex = 4;
            this.gbx_ранг.TabStop = false;
            this.gbx_ранг.Text = "Ранг";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(280, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Скрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.show_hide_groupbox);
            // 
            // chbx_ранг
            // 
            this.chbx_ранг.AutoSize = true;
            this.chbx_ранг.Location = new System.Drawing.Point(6, 21);
            this.chbx_ранг.Name = "chbx_ранг";
            this.chbx_ранг.Size = new System.Drawing.Size(153, 21);
            this.chbx_ранг.TabIndex = 0;
            this.chbx_ранг.Text = "Вычисление ранга";
            this.chbx_ранг.UseVisualStyleBackColor = true;
            // 
            // gbx_слу
            // 
            this.gbx_слу.Controls.Add(this.button2);
            this.gbx_слу.Controls.Add(this.chbx_слу_гаусс);
            this.gbx_слу.Controls.Add(this.chbx_слу_крит_совместности);
            this.gbx_слу.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbx_слу.Location = new System.Drawing.Point(0, 326);
            this.gbx_слу.Name = "gbx_слу";
            this.gbx_слу.Size = new System.Drawing.Size(357, 23);
            this.gbx_слу.TabIndex = 6;
            this.gbx_слу.TabStop = false;
            this.gbx_слу.Text = "Система линейных уравнений (СЛУ)";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(280, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Показать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.show_hide_groupbox);
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
            // gbx_обратная_матрица
            // 
            this.gbx_обратная_матрица.Controls.Add(this.button3);
            this.gbx_обратная_матрица.Controls.Add(this.chbx_обратная_матрица_алг_дополнение);
            this.gbx_обратная_матрица.Controls.Add(this.chbx_обратная_матрица_приписывание);
            this.gbx_обратная_матрица.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbx_обратная_матрица.Location = new System.Drawing.Point(0, 349);
            this.gbx_обратная_матрица.Name = "gbx_обратная_матрица";
            this.gbx_обратная_матрица.Size = new System.Drawing.Size(357, 23);
            this.gbx_обратная_матрица.TabIndex = 5;
            this.gbx_обратная_матрица.TabStop = false;
            this.gbx_обратная_матрица.Text = "Обратная матрица";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(280, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Показать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.show_hide_groupbox);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mtr2row);
            this.groupBox2.Controls.Add(this.mtr2col);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 48);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Матрица 2";
            // 
            // gbx_две_матр_действия
            // 
            this.gbx_две_матр_действия.Controls.Add(this.button4);
            this.gbx_две_матр_действия.Controls.Add(this.cmbx_две_матр_действия_умножение);
            this.gbx_две_матр_действия.Controls.Add(this.chbx_две_матр_действия_умножение);
            this.gbx_две_матр_действия.Controls.Add(this.cmbx_две_матр_действия_вычитание);
            this.gbx_две_матр_действия.Controls.Add(this.chbx_две_матр_действия_вычитание);
            this.gbx_две_матр_действия.Controls.Add(this.chbx_две_матр_действия_сложение);
            this.gbx_две_матр_действия.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbx_две_матр_действия.Location = new System.Drawing.Point(0, 272);
            this.gbx_две_матр_действия.Name = "gbx_две_матр_действия";
            this.gbx_две_матр_действия.Size = new System.Drawing.Size(381, 100);
            this.gbx_две_матр_действия.TabIndex = 12;
            this.gbx_две_матр_действия.TabStop = false;
            this.gbx_две_матр_действия.Text = "Действия с двумя матрицами";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(304, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Скрыть";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.show_hide_groupbox);
            // 
            // cmbx_две_матр_действия_умножение
            // 
            this.cmbx_две_матр_действия_умножение.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_две_матр_действия_умножение.FormattingEnabled = true;
            this.cmbx_две_матр_действия_умножение.Items.AddRange(new object[] {
            "Первую на вторую",
            "Вторую на первую"});
            this.cmbx_две_матр_действия_умножение.Location = new System.Drawing.Point(116, 70);
            this.cmbx_две_матр_действия_умножение.Name = "cmbx_две_матр_действия_умножение";
            this.cmbx_две_матр_действия_умножение.Size = new System.Drawing.Size(224, 24);
            this.cmbx_две_матр_действия_умножение.TabIndex = 4;
            // 
            // chbx_две_матр_действия_умножение
            // 
            this.chbx_две_матр_действия_умножение.AutoSize = true;
            this.chbx_две_матр_действия_умножение.Location = new System.Drawing.Point(6, 73);
            this.chbx_две_матр_действия_умножение.Name = "chbx_две_матр_действия_умножение";
            this.chbx_две_матр_действия_умножение.Size = new System.Drawing.Size(105, 21);
            this.chbx_две_матр_действия_умножение.TabIndex = 3;
            this.chbx_две_матр_действия_умножение.Text = "Умножение";
            this.chbx_две_матр_действия_умножение.UseVisualStyleBackColor = true;
            // 
            // cmbx_две_матр_действия_вычитание
            // 
            this.cmbx_две_матр_действия_вычитание.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_две_матр_действия_вычитание.FormattingEnabled = true;
            this.cmbx_две_матр_действия_вычитание.Items.AddRange(new object[] {
            "Из первой вторую",
            "Из второй первую"});
            this.cmbx_две_матр_действия_вычитание.Location = new System.Drawing.Point(116, 44);
            this.cmbx_две_матр_действия_вычитание.Name = "cmbx_две_матр_действия_вычитание";
            this.cmbx_две_матр_действия_вычитание.Size = new System.Drawing.Size(224, 24);
            this.cmbx_две_матр_действия_вычитание.TabIndex = 2;
            // 
            // chbx_две_матр_действия_вычитание
            // 
            this.chbx_две_матр_действия_вычитание.AutoSize = true;
            this.chbx_две_матр_действия_вычитание.Location = new System.Drawing.Point(6, 47);
            this.chbx_две_матр_действия_вычитание.Name = "chbx_две_матр_действия_вычитание";
            this.chbx_две_матр_действия_вычитание.Size = new System.Drawing.Size(104, 21);
            this.chbx_две_матр_действия_вычитание.TabIndex = 1;
            this.chbx_две_матр_действия_вычитание.Text = "Вычитание";
            this.chbx_две_матр_действия_вычитание.UseVisualStyleBackColor = true;
            // 
            // chbx_две_матр_действия_сложение
            // 
            this.chbx_две_матр_действия_сложение.AutoSize = true;
            this.chbx_две_матр_действия_сложение.Location = new System.Drawing.Point(6, 22);
            this.chbx_две_матр_действия_сложение.Name = "chbx_две_матр_действия_сложение";
            this.chbx_две_матр_действия_сложение.Size = new System.Drawing.Size(96, 21);
            this.chbx_две_матр_действия_сложение.TabIndex = 0;
            this.chbx_две_матр_действия_сложение.Text = "Сложение";
            this.chbx_две_матр_действия_сложение.UseVisualStyleBackColor = true;
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(9, 8);
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
            this.btn_show_panel2.Location = new System.Drawing.Point(552, 7);
            this.btn_show_panel2.Name = "btn_show_panel2";
            this.btn_show_panel2.Size = new System.Drawing.Size(193, 37);
            this.btn_show_panel2.TabIndex = 3;
            this.btn_show_panel2.Text = "Показать вторую матрицу";
            this.btn_show_panel2.UseVisualStyleBackColor = true;
            this.btn_show_panel2.Click += new System.EventHandler(this.btn_show_panel2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Результаты:";
            // 
            // chbx_details
            // 
            this.chbx_details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chbx_details.AutoSize = true;
            this.chbx_details.Location = new System.Drawing.Point(116, 16);
            this.chbx_details.Name = "chbx_details";
            this.chbx_details.Size = new System.Drawing.Size(167, 21);
            this.chbx_details.TabIndex = 7;
            this.chbx_details.Text = "Подробное решение";
            this.chbx_details.UseVisualStyleBackColor = true;
            // 
            // browser_results
            // 
            this.browser_results.AllowWebBrowserDrop = false;
            this.browser_results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browser_results.IsWebBrowserContextMenuEnabled = false;
            this.browser_results.Location = new System.Drawing.Point(0, 452);
            this.browser_results.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser_results.Name = "browser_results";
            this.browser_results.Size = new System.Drawing.Size(753, 244);
            this.browser_results.TabIndex = 8;
            // 
            // btn_show_hide
            // 
            this.btn_show_hide.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_show_hide.Location = new System.Drawing.Point(0, 372);
            this.btn_show_hide.Name = "btn_show_hide";
            this.btn_show_hide.Size = new System.Drawing.Size(753, 28);
            this.btn_show_hide.TabIndex = 9;
            this.btn_show_hide.Text = "Показать / Скрыть панель с матрицами";
            this.btn_show_hide.UseVisualStyleBackColor = true;
            this.btn_show_hide.Click += new System.EventHandler(this.btn_show_hide_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_show_panel2);
            this.panel1.Controls.Add(this.chbx_details);
            this.panel1.Controls.Add(this.btn_calculate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 52);
            this.panel1.TabIndex = 10;
            // 
            // Calculations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 696);
            this.Controls.Add(this.browser_results);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_show_hide);
            this.Controls.Add(this.label1);
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
            this.groupBox1.ResumeLayout(false);
            this.gbx_определитель.ResumeLayout(false);
            this.gbx_определитель.PerformLayout();
            this.gbx_ранг.ResumeLayout(false);
            this.gbx_ранг.PerformLayout();
            this.gbx_слу.ResumeLayout(false);
            this.gbx_слу.PerformLayout();
            this.gbx_обратная_матрица.ResumeLayout(false);
            this.gbx_обратная_матрица.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gbx_две_матр_действия.ResumeLayout(false);
            this.gbx_две_матр_действия.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbx_обратная_матрица;
        private System.Windows.Forms.CheckBox chbx_обратная_матрица_алг_дополнение;
        private System.Windows.Forms.CheckBox chbx_обратная_матрица_приписывание;
        private System.Windows.Forms.GroupBox gbx_ранг;
        private System.Windows.Forms.CheckBox chbx_ранг;
        private System.Windows.Forms.GroupBox gbx_определитель;
        private System.Windows.Forms.CheckBox chbx_определитель_лаплас;
        private System.Windows.Forms.ComboBox cmbx_определитель_разложение_столбец;
        private System.Windows.Forms.CheckBox chbx_определитель_разложение_столбец;
        private System.Windows.Forms.ComboBox cmbx_определитель_разложение_строка;
        private System.Windows.Forms.CheckBox chbx_определитель_разложение_строка;
        private System.Windows.Forms.GroupBox gbx_слу;
        private System.Windows.Forms.CheckBox chbx_слу_гаусс;
        private System.Windows.Forms.CheckBox chbx_слу_крит_совместности;
        private System.Windows.Forms.CheckBox chbx_details;
        private System.Windows.Forms.GroupBox gbx_две_матр_действия;
        private System.Windows.Forms.ComboBox cmbx_две_матр_действия_умножение;
        private System.Windows.Forms.CheckBox chbx_две_матр_действия_умножение;
        private System.Windows.Forms.ComboBox cmbx_две_матр_действия_вычитание;
        private System.Windows.Forms.CheckBox chbx_две_матр_действия_вычитание;
        private System.Windows.Forms.CheckBox chbx_две_матр_действия_сложение;
        private System.Windows.Forms.Button btn_определитель;
        private System.Windows.Forms.CheckBox chbx_определитель_саррюс;
        private System.Windows.Forms.WebBrowser browser_results;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_show_hide;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cmbx_определитель_лаплас_2;
        private System.Windows.Forms.ComboBox cmbx_определитель_лаплас;
    }
}