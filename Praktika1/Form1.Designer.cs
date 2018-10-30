namespace Praktika1
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
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.владельцыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.владениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.магазиныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поставкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поставщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.представленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.молодойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.представленияToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(826, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.владельцыToolStripMenuItem,
            this.владениеToolStripMenuItem,
            this.магазиныToolStripMenuItem,
            this.поставкиToolStripMenuItem,
            this.поставщикиToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.testToolStripMenuItem.Text = "Открыть";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // владельцыToolStripMenuItem
            // 
            this.владельцыToolStripMenuItem.Name = "владельцыToolStripMenuItem";
            this.владельцыToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.владельцыToolStripMenuItem.Text = "Владельцы";
            this.владельцыToolStripMenuItem.Click += new System.EventHandler(this.владельцыToolStripMenuItem_Click);
            // 
            // владениеToolStripMenuItem
            // 
            this.владениеToolStripMenuItem.Name = "владениеToolStripMenuItem";
            this.владениеToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.владениеToolStripMenuItem.Text = "Владение";
            this.владениеToolStripMenuItem.Click += new System.EventHandler(this.владениеToolStripMenuItem_Click);
            // 
            // магазиныToolStripMenuItem
            // 
            this.магазиныToolStripMenuItem.Name = "магазиныToolStripMenuItem";
            this.магазиныToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.магазиныToolStripMenuItem.Text = "Магазины";
            this.магазиныToolStripMenuItem.Click += new System.EventHandler(this.магазиныToolStripMenuItem_Click);
            // 
            // поставкиToolStripMenuItem
            // 
            this.поставкиToolStripMenuItem.Name = "поставкиToolStripMenuItem";
            this.поставкиToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.поставкиToolStripMenuItem.Text = "Поставки";
            this.поставкиToolStripMenuItem.Click += new System.EventHandler(this.поставкиToolStripMenuItem_Click);
            // 
            // поставщикиToolStripMenuItem
            // 
            this.поставщикиToolStripMenuItem.Name = "поставщикиToolStripMenuItem";
            this.поставщикиToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.поставщикиToolStripMenuItem.Text = "Поставщики";
            this.поставщикиToolStripMenuItem.Click += new System.EventHandler(this.поставщикиToolStripMenuItem_Click);
            // 
            // представленияToolStripMenuItem
            // 
            this.представленияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.молодойToolStripMenuItem});
            this.представленияToolStripMenuItem.Name = "представленияToolStripMenuItem";
            this.представленияToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.представленияToolStripMenuItem.Text = "Представления";
            // 
            // молодойToolStripMenuItem
            // 
            this.молодойToolStripMenuItem.Name = "молодойToolStripMenuItem";
            this.молодойToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.молодойToolStripMenuItem.Text = "Молодой";
            this.молодойToolStripMenuItem.Click += new System.EventHandler(this.молодойToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 477);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Главная";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem владельцыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem владениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem магазиныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поставкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поставщикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem представленияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem молодойToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
    }
}

