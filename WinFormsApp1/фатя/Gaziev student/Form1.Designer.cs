namespace Gaziev_student
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
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закритToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.специальностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.группыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.курсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.получитьСписокВсехКурсовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.получитьКурсыСИнформацииОСтудентахИОКурсахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.запросиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зToolStripMenuItem,
            this.закритToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // зToolStripMenuItem
            // 
            this.зToolStripMenuItem.Name = "зToolStripMenuItem";
            this.зToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.зToolStripMenuItem.Text = "Закрить";
            // 
            // закритToolStripMenuItem
            // 
            this.закритToolStripMenuItem.Name = "закритToolStripMenuItem";
            this.закритToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.закритToolStripMenuItem.Text = "О програме ";
            this.закритToolStripMenuItem.Click += new System.EventHandler(this.закритToolStripMenuItem_Click);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.студентToolStripMenuItem,
            this.специальностиToolStripMenuItem,
            this.группыToolStripMenuItem,
            this.курсToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники ";
            this.справочникиToolStripMenuItem.Click += new System.EventHandler(this.справочникиToolStripMenuItem_Click);
            // 
            // студентToolStripMenuItem
            // 
            this.студентToolStripMenuItem.Name = "студентToolStripMenuItem";
            this.студентToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.студентToolStripMenuItem.Text = "Студент";
            this.студентToolStripMenuItem.Click += new System.EventHandler(this.студентToolStripMenuItem_Click);
            // 
            // специальностиToolStripMenuItem
            // 
            this.специальностиToolStripMenuItem.Name = "специальностиToolStripMenuItem";
            this.специальностиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.специальностиToolStripMenuItem.Text = "Специальности";
            this.специальностиToolStripMenuItem.Click += new System.EventHandler(this.специальностиToolStripMenuItem_Click);
            // 
            // группыToolStripMenuItem
            // 
            this.группыToolStripMenuItem.Name = "группыToolStripMenuItem";
            this.группыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.группыToolStripMenuItem.Text = "Группы";
            this.группыToolStripMenuItem.Click += new System.EventHandler(this.группыToolStripMenuItem_Click);
            // 
            // курсToolStripMenuItem
            // 
            this.курсToolStripMenuItem.Name = "курсToolStripMenuItem";
            this.курсToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.курсToolStripMenuItem.Text = "Курс ";
            this.курсToolStripMenuItem.Click += new System.EventHandler(this.курсToolStripMenuItem_Click);
            // 
            // запросиToolStripMenuItem
            // 
            this.запросиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.получитьСписокВсехКурсовToolStripMenuItem,
            this.получитьКурсыСИнформацииОСтудентахИОКурсахToolStripMenuItem});
            this.запросиToolStripMenuItem.Name = "запросиToolStripMenuItem";
            this.запросиToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.запросиToolStripMenuItem.Text = "Запросы";
            // 
            // получитьСписокВсехКурсовToolStripMenuItem
            // 
            this.получитьСписокВсехКурсовToolStripMenuItem.Name = "получитьСписокВсехКурсовToolStripMenuItem";
            this.получитьСписокВсехКурсовToolStripMenuItem.Size = new System.Drawing.Size(376, 22);
            this.получитьСписокВсехКурсовToolStripMenuItem.Text = "Получить список всех курсов";
            // 
            // получитьКурсыСИнформацииОСтудентахИОКурсахToolStripMenuItem
            // 
            this.получитьКурсыСИнформацииОСтудентахИОКурсахToolStripMenuItem.Name = "получитьКурсыСИнформацииОСтудентахИОКурсахToolStripMenuItem";
            this.получитьКурсыСИнформацииОСтудентахИОКурсахToolStripMenuItem.Size = new System.Drawing.Size(376, 22);
            this.получитьКурсыСИнформацииОСтудентахИОКурсахToolStripMenuItem.Text = "Получить курсы с информации о студентах и о курсах";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Учет студентов ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закритToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem специальностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem группыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem курсToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem получитьСписокВсехКурсовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem получитьКурсыСИнформацииОСтудентахИОКурсахToolStripMenuItem;
    }
}

