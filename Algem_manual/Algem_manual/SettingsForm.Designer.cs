namespace Algem_manual
{
    partial class SettingsForm
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
            this.lbx_color = new System.Windows.Forms.ListBox();
            this.browser_test = new System.Windows.Forms.WebBrowser();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.numeric_font = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_font)).BeginInit();
            this.SuspendLayout();
            // 
            // lbx_color
            // 
            this.lbx_color.FormattingEnabled = true;
            this.lbx_color.ItemHeight = 16;
            this.lbx_color.Items.AddRange(new object[] {
            "Белый",
            "Светло-жёлтый",
            "Серый"});
            this.lbx_color.Location = new System.Drawing.Point(15, 27);
            this.lbx_color.Name = "lbx_color";
            this.lbx_color.Size = new System.Drawing.Size(200, 68);
            this.lbx_color.TabIndex = 1;
            this.lbx_color.SelectedIndexChanged += new System.EventHandler(this.lbx_color_SelectedIndexChanged);
            // 
            // browser_test
            // 
            this.browser_test.Location = new System.Drawing.Point(221, 27);
            this.browser_test.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser_test.Name = "browser_test";
            this.browser_test.Size = new System.Drawing.Size(422, 244);
            this.browser_test.TabIndex = 2;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(109, 275);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(104, 38);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Сохранить";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(404, 277);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(103, 36);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Отмена";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // numeric_font
            // 
            this.numeric_font.Location = new System.Drawing.Point(155, 101);
            this.numeric_font.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.numeric_font.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numeric_font.Name = "numeric_font";
            this.numeric_font.Size = new System.Drawing.Size(60, 22);
            this.numeric_font.TabIndex = 5;
            this.numeric_font.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numeric_font.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numeric_font.ValueChanged += new System.EventHandler(this.numeric_font_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Цвет фона:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Размер шрифта:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Предпросмотр:";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 319);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numeric_font);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.browser_test);
            this.Controls.Add(this.lbx_color);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_font)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbx_color;
        private System.Windows.Forms.WebBrowser browser_test;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.NumericUpDown numeric_font;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}