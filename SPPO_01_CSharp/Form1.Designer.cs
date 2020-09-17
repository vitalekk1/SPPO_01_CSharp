namespace SPPO_01_CSharp
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
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RTB_Text = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LB_Separator = new System.Windows.Forms.ListBox();
            this.файлСРазделителямиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлСТекстомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LB_Number = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлСРазделителямиToolStripMenuItem,
            this.файлСТекстомToolStripMenuItem});
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // RTB_Text
            // 
            this.RTB_Text.Location = new System.Drawing.Point(12, 66);
            this.RTB_Text.Name = "RTB_Text";
            this.RTB_Text.Size = new System.Drawing.Size(301, 372);
            this.RTB_Text.TabIndex = 2;
            this.RTB_Text.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(134, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(676, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Разделители";
            // 
            // LB_Separator
            // 
            this.LB_Separator.FormattingEnabled = true;
            this.LB_Separator.Location = new System.Drawing.Point(668, 66);
            this.LB_Separator.Name = "LB_Separator";
            this.LB_Separator.Size = new System.Drawing.Size(120, 368);
            this.LB_Separator.TabIndex = 6;
            // 
            // файлСРазделителямиToolStripMenuItem
            // 
            this.файлСРазделителямиToolStripMenuItem.Name = "файлСРазделителямиToolStripMenuItem";
            this.файлСРазделителямиToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.файлСРазделителямиToolStripMenuItem.Text = "Файл с Разделителями";
            this.файлСРазделителямиToolStripMenuItem.Click += new System.EventHandler(this.fileSeparatorClick);
            // 
            // файлСТекстомToolStripMenuItem
            // 
            this.файлСТекстомToolStripMenuItem.Name = "файлСТекстомToolStripMenuItem";
            this.файлСТекстомToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.файлСТекстомToolStripMenuItem.Text = "Файл с Текстом";
            this.файлСТекстомToolStripMenuItem.Click += new System.EventHandler(this.fileSTextClick);
            // 
            // LB_Number
            // 
            this.LB_Number.FormattingEnabled = true;
            this.LB_Number.Location = new System.Drawing.Point(415, 66);
            this.LB_Number.Name = "LB_Number";
            this.LB_Number.Size = new System.Drawing.Size(145, 186);
            this.LB_Number.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(411, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Найденные Числа";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.Location = new System.Drawing.Point(435, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Найти Числа";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LB_Number);
            this.Controls.Add(this.LB_Separator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RTB_Text);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.RichTextBox RTB_Text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LB_Separator;
        private System.Windows.Forms.ToolStripMenuItem файлСРазделителямиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлСТекстомToolStripMenuItem;
        private System.Windows.Forms.ListBox LB_Number;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

