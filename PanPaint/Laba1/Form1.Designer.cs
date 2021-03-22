namespace Laba1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_AsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LineColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LineWidthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowToolStripMenuItem,
            this.toolStripMenuItem1});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.MdiWindowListItem = this.windowToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.Save_AsToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            resources.ApplyResources(this.windowToolStripMenuItem, "windowToolStripMenuItem");
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            resources.ApplyResources(this.NewToolStripMenuItem, "NewToolStripMenuItem");
            this.NewToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            resources.ApplyResources(this.OpenToolStripMenuItem, "OpenToolStripMenuItem");
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            resources.ApplyResources(this.SaveToolStripMenuItem, "SaveToolStripMenuItem");
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // Save_AsToolStripMenuItem
            // 
            resources.ApplyResources(this.Save_AsToolStripMenuItem, "Save_AsToolStripMenuItem");
            this.Save_AsToolStripMenuItem.Name = "Save_AsToolStripMenuItem";
            this.Save_AsToolStripMenuItem.Click += new System.EventHandler(this.Save_AsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LineColorToolStripMenuItem,
            this.BackgroundColorToolStripMenuItem,
            this.LineWidthToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // LineColorToolStripMenuItem
            // 
            this.LineColorToolStripMenuItem.Name = "LineColorToolStripMenuItem";
            resources.ApplyResources(this.LineColorToolStripMenuItem, "LineColorToolStripMenuItem");
            this.LineColorToolStripMenuItem.Click += new System.EventHandler(this.LineColorToolStripMenuItem_Click);
            // 
            // BackgroundColorToolStripMenuItem
            // 
            this.BackgroundColorToolStripMenuItem.Name = "BackgroundColorToolStripMenuItem";
            resources.ApplyResources(this.BackgroundColorToolStripMenuItem, "BackgroundColorToolStripMenuItem");
            this.BackgroundColorToolStripMenuItem.Click += new System.EventHandler(this.BackgroundColorToolStripMenuItem_Click);
            // 
            // LineWidthToolStripMenuItem
            // 
            this.LineWidthToolStripMenuItem.Name = "LineWidthToolStripMenuItem";
            resources.ApplyResources(this.LineWidthToolStripMenuItem, "LineWidthToolStripMenuItem");
            this.LineWidthToolStripMenuItem.Click += new System.EventHandler(this.LineWidthToolStripMenuItem_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Save_AsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem LineColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BackgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LineWidthToolStripMenuItem;
    }
}

