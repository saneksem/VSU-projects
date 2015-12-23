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
            this.cmbx_font = new System.Windows.Forms.ComboBox();
            this.lbx_color = new System.Windows.Forms.ListBox();
            this.browser_test = new System.Windows.Forms.WebBrowser();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbx_font
            // 
            this.cmbx_font.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_font.FormattingEnabled = true;
            this.cmbx_font.Items.AddRange(new object[] {
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cmbx_font.Location = new System.Drawing.Point(83, 12);
            this.cmbx_font.Name = "cmbx_font";
            this.cmbx_font.Size = new System.Drawing.Size(178, 24);
            this.cmbx_font.TabIndex = 0;
            this.cmbx_font.SelectedIndexChanged += new System.EventHandler(this.cmbx_font_SelectedIndexChanged);
            // 
            // lbx_color
            // 
            this.lbx_color.FormattingEnabled = true;
            this.lbx_color.ItemHeight = 16;
            this.lbx_color.Items.AddRange(new object[] {
            "Белый",
            "Светло-жёлтый",
            "Серый"});
            this.lbx_color.Location = new System.Drawing.Point(83, 42);
            this.lbx_color.Name = "lbx_color";
            this.lbx_color.Size = new System.Drawing.Size(179, 244);
            this.lbx_color.TabIndex = 1;
            this.lbx_color.SelectedIndexChanged += new System.EventHandler(this.lbx_color_SelectedIndexChanged);
            // 
            // browser_test
            // 
            this.browser_test.Location = new System.Drawing.Point(268, 12);
            this.browser_test.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser_test.Name = "browser_test";
            this.browser_test.Size = new System.Drawing.Size(375, 283);
            this.browser_test.TabIndex = 2;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(108, 299);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(104, 38);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Сохранить";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(401, 301);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(103, 36);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Отмена";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 349);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.browser_test);
            this.Controls.Add(this.lbx_color);
            this.Controls.Add(this.cmbx_font);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbx_font;
        private System.Windows.Forms.ListBox lbx_color;
        private System.Windows.Forms.WebBrowser browser_test;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
    }
}