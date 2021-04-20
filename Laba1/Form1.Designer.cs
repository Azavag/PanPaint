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
            this.ImageSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FugureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StraightLineMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.CurveLineMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.RectangleMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.EllipseMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.FillMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBar = new System.Windows.Forms.StatusBar();
            this.statusBarPanelCursor = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanelColor1 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanelColor2 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanelWidth = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanelSize = new System.Windows.Forms.StatusBarPanel();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.OpenFileStripButton = new System.Windows.Forms.ToolStripButton();
            this.NewFileStripButton = new System.Windows.Forms.ToolStripButton();
            this.SaveStripButton = new System.Windows.Forms.ToolStripButton();
            this.SaveAsStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LineColorStripButton = new System.Windows.Forms.ToolStripButton();
            this.ColorBackgroundStripButton = new System.Windows.Forms.ToolStripButton();
            this.LineWidthStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ChooseSizeStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.CreateRectangleStripButton = new System.Windows.Forms.ToolStripButton();
            this.CreateEllipseStripButton = new System.Windows.Forms.ToolStripButton();
            this.CreateStraightLineStripButton = new System.Windows.Forms.ToolStripButton();
            this.CreateCurveLineStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.FillStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelCursor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelColor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelColor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelSize)).BeginInit();
            this.ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowToolStripMenuItem,
            this.toolStripMenuItem1,
            this.FugureToolStripMenuItem});
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
            this.LineWidthToolStripMenuItem,
            this.ImageSizeToolStripMenuItem});
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
            // ImageSizeToolStripMenuItem
            // 
            this.ImageSizeToolStripMenuItem.Name = "ImageSizeToolStripMenuItem";
            resources.ApplyResources(this.ImageSizeToolStripMenuItem, "ImageSizeToolStripMenuItem");
            this.ImageSizeToolStripMenuItem.Click += new System.EventHandler(this.ImageSizeToolStripMenuItem_Click);
            // 
            // FugureToolStripMenuItem
            // 
            this.FugureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StraightLineMenuStrip,
            this.CurveLineMenuStrip,
            this.RectangleMenuStrip,
            this.EllipseMenuStrip,
            this.FillMenuStrip});
            this.FugureToolStripMenuItem.Name = "FugureToolStripMenuItem";
            resources.ApplyResources(this.FugureToolStripMenuItem, "FugureToolStripMenuItem");
            // 
            // StraightLineMenuStrip
            // 
            this.StraightLineMenuStrip.CheckOnClick = true;
            this.StraightLineMenuStrip.Name = "StraightLineMenuStrip";
            resources.ApplyResources(this.StraightLineMenuStrip, "StraightLineMenuStrip");
            this.StraightLineMenuStrip.Click += new System.EventHandler(this.StraightLineMenuStrip_Click);
            // 
            // CurveLineMenuStrip
            // 
            this.CurveLineMenuStrip.CheckOnClick = true;
            this.CurveLineMenuStrip.Name = "CurveLineMenuStrip";
            resources.ApplyResources(this.CurveLineMenuStrip, "CurveLineMenuStrip");
            this.CurveLineMenuStrip.Click += new System.EventHandler(this.CurveLineMenuStrip_Click);
            // 
            // RectangleMenuStrip
            // 
            this.RectangleMenuStrip.CheckOnClick = true;
            this.RectangleMenuStrip.Name = "RectangleMenuStrip";
            resources.ApplyResources(this.RectangleMenuStrip, "RectangleMenuStrip");
            this.RectangleMenuStrip.Click += new System.EventHandler(this.RectangleMenuStrip_Click);
            // 
            // EllipseMenuStrip
            // 
            this.EllipseMenuStrip.CheckOnClick = true;
            this.EllipseMenuStrip.Name = "EllipseMenuStrip";
            resources.ApplyResources(this.EllipseMenuStrip, "EllipseMenuStrip");
            this.EllipseMenuStrip.Click += new System.EventHandler(this.EllipseMenuStrip_Click);
            // 
            // FillMenuStrip
            // 
            this.FillMenuStrip.CheckOnClick = true;
            this.FillMenuStrip.Name = "FillMenuStrip";
            resources.ApplyResources(this.FillMenuStrip, "FillMenuStrip");
            this.FillMenuStrip.Click += new System.EventHandler(this.FillMenuStrip_Click);
            // 
            // StatusBar
            // 
            resources.ApplyResources(this.StatusBar, "StatusBar");
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanelCursor,
            this.statusBarPanelColor1,
            this.statusBarPanelColor2,
            this.statusBarPanelWidth,
            this.statusBarPanelSize});
            this.StatusBar.ShowPanels = true;
            this.StatusBar.DrawItem += new System.Windows.Forms.StatusBarDrawItemEventHandler(this.StatusBar_DrawItem);
            // 
            // statusBarPanelCursor
            // 
            resources.ApplyResources(this.statusBarPanelCursor, "statusBarPanelCursor");
            // 
            // statusBarPanelColor1
            // 
            resources.ApplyResources(this.statusBarPanelColor1, "statusBarPanelColor1");
            this.statusBarPanelColor1.Style = System.Windows.Forms.StatusBarPanelStyle.OwnerDraw;
            // 
            // statusBarPanelColor2
            // 
            resources.ApplyResources(this.statusBarPanelColor2, "statusBarPanelColor2");
            this.statusBarPanelColor2.Style = System.Windows.Forms.StatusBarPanelStyle.OwnerDraw;
            // 
            // statusBarPanelWidth
            // 
            resources.ApplyResources(this.statusBarPanelWidth, "statusBarPanelWidth");
            // 
            // statusBarPanelSize
            // 
            resources.ApplyResources(this.statusBarPanelSize, "statusBarPanelSize");
            // 
            // ToolStrip
            // 
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewFileStripButton,
            this.OpenFileStripButton,
            this.SaveStripButton,
            this.SaveAsStripButton,
            this.toolStripSeparator1,
            this.LineColorStripButton,
            this.ColorBackgroundStripButton,
            this.LineWidthStripButton,
            this.FillStripButton,
            this.toolStripSeparator2,
            this.ChooseSizeStripButton,
            this.toolStripSeparator3,
            this.CreateRectangleStripButton,
            this.CreateEllipseStripButton,
            this.CreateStraightLineStripButton,
            this.CreateCurveLineStripButton,
            this.toolStripSeparator4});
            resources.ApplyResources(this.ToolStrip, "ToolStrip");
            this.ToolStrip.Name = "ToolStrip";
            // 
            // OpenFileStripButton
            // 
            this.OpenFileStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.OpenFileStripButton, "OpenFileStripButton");
            this.OpenFileStripButton.Name = "OpenFileStripButton";
            this.OpenFileStripButton.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // NewFileStripButton
            // 
            this.NewFileStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.NewFileStripButton, "NewFileStripButton");
            this.NewFileStripButton.Name = "NewFileStripButton";
            this.NewFileStripButton.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // SaveStripButton
            // 
            this.SaveStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.SaveStripButton, "SaveStripButton");
            this.SaveStripButton.Name = "SaveStripButton";
            this.SaveStripButton.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // SaveAsStripButton
            // 
            this.SaveAsStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.SaveAsStripButton, "SaveAsStripButton");
            this.SaveAsStripButton.Name = "SaveAsStripButton";
            this.SaveAsStripButton.Click += new System.EventHandler(this.Save_AsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // LineColorStripButton
            // 
            this.LineColorStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.LineColorStripButton, "LineColorStripButton");
            this.LineColorStripButton.Name = "LineColorStripButton";
            this.LineColorStripButton.Click += new System.EventHandler(this.LineColorToolStripMenuItem_Click);
            // 
            // ColorBackgroundStripButton
            // 
            this.ColorBackgroundStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.ColorBackgroundStripButton, "ColorBackgroundStripButton");
            this.ColorBackgroundStripButton.Name = "ColorBackgroundStripButton";
            this.ColorBackgroundStripButton.Click += new System.EventHandler(this.BackgroundColorToolStripMenuItem_Click);
            // 
            // LineWidthStripButton
            // 
            this.LineWidthStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.LineWidthStripButton, "LineWidthStripButton");
            this.LineWidthStripButton.Name = "LineWidthStripButton";
            this.LineWidthStripButton.Click += new System.EventHandler(this.LineWidthToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // ChooseSizeStripButton
            // 
            this.ChooseSizeStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.ChooseSizeStripButton, "ChooseSizeStripButton");
            this.ChooseSizeStripButton.Name = "ChooseSizeStripButton";
            this.ChooseSizeStripButton.Click += new System.EventHandler(this.ImageSizeToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // CreateRectangleStripButton
            // 
            this.CreateRectangleStripButton.CheckOnClick = true;
            this.CreateRectangleStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.CreateRectangleStripButton, "CreateRectangleStripButton");
            this.CreateRectangleStripButton.Name = "CreateRectangleStripButton";
            this.CreateRectangleStripButton.Click += new System.EventHandler(this.RectangleMenuStrip_Click);
            // 
            // CreateEllipseStripButton
            // 
            this.CreateEllipseStripButton.CheckOnClick = true;
            this.CreateEllipseStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.CreateEllipseStripButton, "CreateEllipseStripButton");
            this.CreateEllipseStripButton.Name = "CreateEllipseStripButton";
            this.CreateEllipseStripButton.Click += new System.EventHandler(this.EllipseMenuStrip_Click);
            // 
            // CreateStraightLineStripButton
            // 
            this.CreateStraightLineStripButton.CheckOnClick = true;
            this.CreateStraightLineStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.CreateStraightLineStripButton, "CreateStraightLineStripButton");
            this.CreateStraightLineStripButton.Name = "CreateStraightLineStripButton";
            this.CreateStraightLineStripButton.Click += new System.EventHandler(this.StraightLineMenuStrip_Click);
            // 
            // CreateCurveLineStripButton
            // 
            this.CreateCurveLineStripButton.CheckOnClick = true;
            this.CreateCurveLineStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.CreateCurveLineStripButton, "CreateCurveLineStripButton");
            this.CreateCurveLineStripButton.Name = "CreateCurveLineStripButton";
            this.CreateCurveLineStripButton.Click += new System.EventHandler(this.CurveLineMenuStrip_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // FillStripButton
            // 
            this.FillStripButton.CheckOnClick = true;
            this.FillStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.FillStripButton, "FillStripButton");
            this.FillStripButton.Name = "FillStripButton";
            this.FillStripButton.Click += new System.EventHandler(this.FillMenuStrip_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelCursor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelColor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelColor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelSize)).EndInit();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem ImageSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FugureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RectangleMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem EllipseMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem StraightLineMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CurveLineMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FillMenuStrip;
        private System.Windows.Forms.StatusBar StatusBar;
        private System.Windows.Forms.StatusBarPanel statusBarPanelCursor;
        private System.Windows.Forms.StatusBarPanel statusBarPanelColor2;
        private System.Windows.Forms.StatusBarPanel statusBarPanelWidth;
        private System.Windows.Forms.StatusBarPanel statusBarPanelSize;
        private System.Windows.Forms.StatusBarPanel statusBarPanelColor1;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripButton OpenFileStripButton;
        private System.Windows.Forms.ToolStripButton NewFileStripButton;
        private System.Windows.Forms.ToolStripButton SaveStripButton;
        private System.Windows.Forms.ToolStripButton SaveAsStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton LineColorStripButton;
        private System.Windows.Forms.ToolStripButton ColorBackgroundStripButton;
        private System.Windows.Forms.ToolStripButton LineWidthStripButton;
        private System.Windows.Forms.ToolStripButton ChooseSizeStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton CreateRectangleStripButton;
        private System.Windows.Forms.ToolStripButton CreateEllipseStripButton;
        private System.Windows.Forms.ToolStripButton CreateStraightLineStripButton;
        private System.Windows.Forms.ToolStripButton CreateCurveLineStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton FillStripButton;
    }
}

