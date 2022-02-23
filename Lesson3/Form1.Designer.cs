
namespace Lesson3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.общееРасписаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.самаркинАИToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.самаркинаЕИToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мудровАСToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.общееРасписаниеToolStripMenuItem,
            this.самаркинАИToolStripMenuItem,
            this.самаркинаЕИToolStripMenuItem,
            this.мудровАСToolStripMenuItem,
            this.toolStripComboBox1,
            this.toolStripTextBox1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1001, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // общееРасписаниеToolStripMenuItem
            // 
            this.общееРасписаниеToolStripMenuItem.Name = "общееРасписаниеToolStripMenuItem";
            this.общееРасписаниеToolStripMenuItem.Size = new System.Drawing.Size(126, 23);
            this.общееРасписаниеToolStripMenuItem.Text = "Общее расписание";
            this.общееРасписаниеToolStripMenuItem.Click += new System.EventHandler(this.общееРасписаниеToolStripMenuItem_Click);
            // 
            // самаркинАИToolStripMenuItem
            // 
            this.самаркинАИToolStripMenuItem.Name = "самаркинАИToolStripMenuItem";
            this.самаркинАИToolStripMenuItem.Size = new System.Drawing.Size(101, 23);
            this.самаркинАИToolStripMenuItem.Text = "Самаркин А.И.";
            this.самаркинАИToolStripMenuItem.Click += new System.EventHandler(this.самаркинАИToolStripMenuItem_Click);
            // 
            // самаркинаЕИToolStripMenuItem
            // 
            this.самаркинаЕИToolStripMenuItem.Name = "самаркинаЕИToolStripMenuItem";
            this.самаркинаЕИToolStripMenuItem.Size = new System.Drawing.Size(105, 23);
            this.самаркинаЕИToolStripMenuItem.Text = "Самаркина Е.И.";
            this.самаркинаЕИToolStripMenuItem.Click += new System.EventHandler(this.самаркинаЕИToolStripMenuItem_Click);
            // 
            // мудровАСToolStripMenuItem
            // 
            this.мудровАСToolStripMenuItem.Name = "мудровАСToolStripMenuItem";
            this.мудровАСToolStripMenuItem.Size = new System.Drawing.Size(87, 23);
            this.мудровАСToolStripMenuItem.Text = "Мудров А.С.";
            this.мудровАСToolStripMenuItem.Click += new System.EventHandler(this.мудровАСToolStripMenuItem_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox1_KeyUp);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 27);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(1001, 614);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Url = new System.Uri("http://www.yandex.ru", System.UriKind.Absolute);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 641);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Расписание";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem общееРасписаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem самаркинАИToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem самаркинаЕИToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem мудровАСToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

