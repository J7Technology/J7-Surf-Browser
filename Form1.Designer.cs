using EasyTabs;

namespace Surf
{
    partial class SurfUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SurfUI));
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.SideBar = new System.Windows.Forms.ToolStrip();
            this.SettingsButton = new System.Windows.Forms.ToolStripButton();
            this.HistoryButton = new System.Windows.Forms.ToolStripButton();
            this.LDButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.DockButton = new System.Windows.Forms.ToolStripButton();
            this.VisibilityButton = new System.Windows.Forms.ToolStripButton();
            this.FullScreenButton = new System.Windows.Forms.ToolStripButton();
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.ShowSideButton = new System.Windows.Forms.Button();
            this.ExitFullscreenButton = new System.Windows.Forms.Button();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SearchBar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mainBar = new System.Windows.Forms.ToolStrip();
            this.BackButton = new System.Windows.Forms.ToolStripButton();
            this.ForwardButton = new System.Windows.Forms.ToolStripButton();
            this.ReloadButton = new System.Windows.Forms.ToolStripButton();
            this.SecureImage = new System.Windows.Forms.ToolStripButton();
            this.DownloadsButton = new System.Windows.Forms.ToolStripButton();
            this.HomeButton = new System.Windows.Forms.ToolStripButton();
            this.Surf = new System.Windows.Forms.ToolStripButton();
            this.settings = new System.Windows.Forms.Panel();
            this.dseLabel = new System.Windows.Forms.Label();
            this.yandexButton = new System.Windows.Forms.Button();
            this.baiduButton = new System.Windows.Forms.Button();
            this.naverButton = new System.Windows.Forms.Button();
            this.ecosiaButton = new System.Windows.Forms.Button();
            this.braveButton = new System.Windows.Forms.Button();
            this.yahooButton = new System.Windows.Forms.Button();
            this.moogleButton = new System.Windows.Forms.Button();
            this.bingButton = new System.Windows.Forms.Button();
            this.duckDuckGoButton = new System.Windows.Forms.Button();
            this.googleButton = new System.Windows.Forms.Button();
            this.ExitSettings = new System.Windows.Forms.Button();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.SideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.mainBar.SuspendLayout();
            this.settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(51, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(51, 6);
            // 
            // SideBar
            // 
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.SideBar.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.SideBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.SettingsButton,
            this.HistoryButton,
            this.toolStripSeparator4,
            this.LDButton,
            this.toolStripSeparator5,
            this.DockButton,
            this.VisibilityButton,
            this.FullScreenButton});
            this.SideBar.Location = new System.Drawing.Point(0, 44);
            this.SideBar.Name = "SideBar";
            this.SideBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.SideBar.Size = new System.Drawing.Size(56, 1584);
            this.SideBar.TabIndex = 2;
            this.SideBar.Text = "Side Bar";
            this.SideBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // SettingsButton
            // 
            this.SettingsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Image")));
            this.SettingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(51, 32);
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // HistoryButton
            // 
            this.HistoryButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HistoryButton.Image = ((System.Drawing.Image)(resources.GetObject("HistoryButton.Image")));
            this.HistoryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Size = new System.Drawing.Size(51, 32);
            this.HistoryButton.Text = "History";
            this.HistoryButton.Click += new System.EventHandler(this.HistoryButton_Click);
            // 
            // LDButton
            // 
            this.LDButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LDButton.Image = ((System.Drawing.Image)(resources.GetObject("LDButton.Image")));
            this.LDButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LDButton.Name = "LDButton";
            this.LDButton.Size = new System.Drawing.Size(51, 32);
            this.LDButton.Text = "Light/Dark Mode Toggle";
            this.LDButton.Click += new System.EventHandler(this.LDButton_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(51, 6);
            // 
            // DockButton
            // 
            this.DockButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DockButton.Image = ((System.Drawing.Image)(resources.GetObject("DockButton.Image")));
            this.DockButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DockButton.Name = "DockButton";
            this.DockButton.Size = new System.Drawing.Size(51, 32);
            this.DockButton.Text = "BarLocation";
            this.DockButton.Click += new System.EventHandler(this.DockButton_Click);
            // 
            // VisibilityButton
            // 
            this.VisibilityButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.VisibilityButton.Image = ((System.Drawing.Image)(resources.GetObject("VisibilityButton.Image")));
            this.VisibilityButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.VisibilityButton.Name = "VisibilityButton";
            this.VisibilityButton.Size = new System.Drawing.Size(51, 32);
            this.VisibilityButton.Text = "SideBar Visibility";
            this.VisibilityButton.Click += new System.EventHandler(this.VisibilityButton_Click);
            // 
            // FullScreenButton
            // 
            this.FullScreenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FullScreenButton.Image = ((System.Drawing.Image)(resources.GetObject("FullScreenButton.Image")));
            this.FullScreenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FullScreenButton.Name = "FullScreenButton";
            this.FullScreenButton.Size = new System.Drawing.Size(51, 32);
            this.FullScreenButton.Text = "Full Screen";
            this.FullScreenButton.Click += new System.EventHandler(this.FullScreenButton_Click);
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView.Location = new System.Drawing.Point(56, 44);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(2532, 1584);
            this.webView.TabIndex = 3;
            this.webView.ZoomFactor = 1D;
            this.webView.NavigationStarting += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs>(this.webView_NavigationStarting);
            this.webView.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.webView_NavigationCompleted);
            this.webView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // ShowSideButton
            // 
            this.ShowSideButton.BackColor = System.Drawing.Color.White;
            this.ShowSideButton.Font = new System.Drawing.Font("Javanese Text", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowSideButton.Location = new System.Drawing.Point(0, 63);
            this.ShowSideButton.Name = "ShowSideButton";
            this.ShowSideButton.Size = new System.Drawing.Size(160, 45);
            this.ShowSideButton.TabIndex = 4;
            this.ShowSideButton.Text = "Show SideBar";
            this.ShowSideButton.UseVisualStyleBackColor = false;
            this.ShowSideButton.Visible = false;
            this.ShowSideButton.Click += new System.EventHandler(this.ShowSideButton_Click);
            this.ShowSideButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // ExitFullscreenButton
            // 
            this.ExitFullscreenButton.BackColor = System.Drawing.Color.White;
            this.ExitFullscreenButton.Font = new System.Drawing.Font("Javanese Text", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitFullscreenButton.Location = new System.Drawing.Point(0, 0);
            this.ExitFullscreenButton.Name = "ExitFullscreenButton";
            this.ExitFullscreenButton.Size = new System.Drawing.Size(160, 40);
            this.ExitFullscreenButton.TabIndex = 5;
            this.ExitFullscreenButton.Text = "Exit Fullscreen";
            this.ExitFullscreenButton.UseVisualStyleBackColor = false;
            this.ExitFullscreenButton.Visible = false;
            this.ExitFullscreenButton.Click += new System.EventHandler(this.ExitFullscreenButton_Click);
            this.ExitFullscreenButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // SearchBar
            // 
            this.SearchBar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.SearchBar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.SearchBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SearchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBar.Font = new System.Drawing.Font("Tahoma", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBar.ForeColor = System.Drawing.Color.Black;
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(2140, 40);
            this.SearchBar.ToolTipText = "Search";
            this.SearchBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBar_Search);
            this.SearchBar.DoubleClick += new System.EventHandler(this.SearchBar_DoubleClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // mainBar
            // 
            this.mainBar.BackColor = System.Drawing.Color.White;
            this.mainBar.CanOverflow = false;
            this.mainBar.Font = new System.Drawing.Font("Symbol", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.mainBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainBar.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.mainBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackButton,
            this.ForwardButton,
            this.ReloadButton,
            this.toolStripSeparator1,
            this.SearchBar,
            this.SecureImage,
            this.toolStripSeparator2,
            this.DownloadsButton,
            this.HomeButton,
            this.Surf});
            this.mainBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mainBar.Location = new System.Drawing.Point(0, 0);
            this.mainBar.Name = "mainBar";
            this.mainBar.Padding = new System.Windows.Forms.Padding(0);
            this.mainBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainBar.Size = new System.Drawing.Size(2588, 44);
            this.mainBar.Stretch = true;
            this.mainBar.TabIndex = 0;
            this.mainBar.Text = "SearchBar";
            this.mainBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // BackButton
            // 
            this.BackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(40, 34);
            this.BackButton.Text = "Previous";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ForwardButton
            // 
            this.ForwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ForwardButton.Image = ((System.Drawing.Image)(resources.GetObject("ForwardButton.Image")));
            this.ForwardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(40, 34);
            this.ForwardButton.Text = "Next Page";
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // ReloadButton
            // 
            this.ReloadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ReloadButton.Image = ((System.Drawing.Image)(resources.GetObject("ReloadButton.Image")));
            this.ReloadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(40, 34);
            this.ReloadButton.Text = "Reload";
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // SecureImage
            // 
            this.SecureImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SecureImage.Image = ((System.Drawing.Image)(resources.GetObject("SecureImage.Image")));
            this.SecureImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SecureImage.Name = "SecureImage";
            this.SecureImage.Size = new System.Drawing.Size(40, 34);
            this.SecureImage.Text = "Secure Website";
            // 
            // DownloadsButton
            // 
            this.DownloadsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DownloadsButton.Image = ((System.Drawing.Image)(resources.GetObject("DownloadsButton.Image")));
            this.DownloadsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DownloadsButton.Name = "DownloadsButton";
            this.DownloadsButton.Size = new System.Drawing.Size(40, 34);
            this.DownloadsButton.Text = "Downloads";
            this.DownloadsButton.Click += new System.EventHandler(this.DownloadsButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(40, 34);
            this.HomeButton.Text = "Home";
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // Surf
            // 
            this.Surf.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Surf.Image = ((System.Drawing.Image)(resources.GetObject("Surf.Image")));
            this.Surf.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Surf.Name = "Surf";
            this.Surf.Size = new System.Drawing.Size(40, 34);
            this.Surf.Text = "Surf";
            // 
            // settings
            // 
            this.settings.AutoScroll = true;
            this.settings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.settings.BackColor = System.Drawing.Color.White;
            this.settings.Controls.Add(this.dseLabel);
            this.settings.Controls.Add(this.yandexButton);
            this.settings.Controls.Add(this.baiduButton);
            this.settings.Controls.Add(this.naverButton);
            this.settings.Controls.Add(this.ecosiaButton);
            this.settings.Controls.Add(this.braveButton);
            this.settings.Controls.Add(this.yahooButton);
            this.settings.Controls.Add(this.moogleButton);
            this.settings.Controls.Add(this.bingButton);
            this.settings.Controls.Add(this.duckDuckGoButton);
            this.settings.Controls.Add(this.googleButton);
            this.settings.Controls.Add(this.ExitSettings);
            this.settings.Controls.Add(this.settingsLabel);
            this.settings.Location = new System.Drawing.Point(203, 47);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(2330, 1400);
            this.settings.TabIndex = 6;
            this.settings.Visible = false;
            // 
            // dseLabel
            // 
            this.dseLabel.Font = new System.Drawing.Font("Yu Gothic", 21.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dseLabel.Location = new System.Drawing.Point(647, 92);
            this.dseLabel.Name = "dseLabel";
            this.dseLabel.Size = new System.Drawing.Size(1029, 106);
            this.dseLabel.TabIndex = 21;
            this.dseLabel.Text = "Default Search Engine";
            this.dseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yandexButton
            // 
            this.yandexButton.BackColor = System.Drawing.Color.White;
            this.yandexButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yandexButton.FlatAppearance.BorderSize = 0;
            this.yandexButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.yandexButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.yandexButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.yandexButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yandexButton.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yandexButton.Location = new System.Drawing.Point(1297, 479);
            this.yandexButton.Name = "yandexButton";
            this.yandexButton.Size = new System.Drawing.Size(230, 160);
            this.yandexButton.TabIndex = 20;
            this.yandexButton.Text = "Yandex";
            this.yandexButton.UseVisualStyleBackColor = false;
            this.yandexButton.Click += new System.EventHandler(this.yandexButton_Click);
            this.yandexButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // baiduButton
            // 
            this.baiduButton.BackColor = System.Drawing.Color.White;
            this.baiduButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.baiduButton.FlatAppearance.BorderSize = 0;
            this.baiduButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.baiduButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.baiduButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.baiduButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baiduButton.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baiduButton.Location = new System.Drawing.Point(791, 479);
            this.baiduButton.Name = "baiduButton";
            this.baiduButton.Size = new System.Drawing.Size(230, 160);
            this.baiduButton.TabIndex = 19;
            this.baiduButton.Text = "Baidu";
            this.baiduButton.UseVisualStyleBackColor = false;
            this.baiduButton.Click += new System.EventHandler(this.baiduButton_Click);
            this.baiduButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // naverButton
            // 
            this.naverButton.BackColor = System.Drawing.Color.White;
            this.naverButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.naverButton.FlatAppearance.BorderSize = 0;
            this.naverButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.naverButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.naverButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.naverButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.naverButton.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naverButton.Location = new System.Drawing.Point(1046, 479);
            this.naverButton.Name = "naverButton";
            this.naverButton.Size = new System.Drawing.Size(230, 160);
            this.naverButton.TabIndex = 18;
            this.naverButton.Text = "Naver";
            this.naverButton.UseVisualStyleBackColor = false;
            this.naverButton.Click += new System.EventHandler(this.naverButton_Click);
            this.naverButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // ecosiaButton
            // 
            this.ecosiaButton.BackColor = System.Drawing.Color.White;
            this.ecosiaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ecosiaButton.FlatAppearance.BorderSize = 0;
            this.ecosiaButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ecosiaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ecosiaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ecosiaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ecosiaButton.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecosiaButton.Location = new System.Drawing.Point(1808, 280);
            this.ecosiaButton.Name = "ecosiaButton";
            this.ecosiaButton.Size = new System.Drawing.Size(230, 167);
            this.ecosiaButton.TabIndex = 17;
            this.ecosiaButton.Text = "Ecosia";
            this.ecosiaButton.UseVisualStyleBackColor = false;
            this.ecosiaButton.Click += new System.EventHandler(this.ecosiaButton_Click);
            this.ecosiaButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // braveButton
            // 
            this.braveButton.BackColor = System.Drawing.Color.White;
            this.braveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.braveButton.FlatAppearance.BorderSize = 0;
            this.braveButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.braveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.braveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.braveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.braveButton.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.braveButton.Location = new System.Drawing.Point(1547, 280);
            this.braveButton.Name = "braveButton";
            this.braveButton.Size = new System.Drawing.Size(230, 167);
            this.braveButton.TabIndex = 16;
            this.braveButton.Text = "Brave";
            this.braveButton.UseVisualStyleBackColor = false;
            this.braveButton.Click += new System.EventHandler(this.braveButton_Click);
            this.braveButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // yahooButton
            // 
            this.yahooButton.BackColor = System.Drawing.Color.White;
            this.yahooButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yahooButton.FlatAppearance.BorderSize = 0;
            this.yahooButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.yahooButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.yahooButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.yahooButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yahooButton.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yahooButton.Location = new System.Drawing.Point(1297, 280);
            this.yahooButton.Name = "yahooButton";
            this.yahooButton.Size = new System.Drawing.Size(230, 167);
            this.yahooButton.TabIndex = 15;
            this.yahooButton.Text = "Yahoo";
            this.yahooButton.UseVisualStyleBackColor = false;
            this.yahooButton.Click += new System.EventHandler(this.yahooButton_Click);
            this.yahooButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // moogleButton
            // 
            this.moogleButton.BackColor = System.Drawing.Color.White;
            this.moogleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moogleButton.FlatAppearance.BorderSize = 0;
            this.moogleButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.moogleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.moogleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.moogleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moogleButton.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moogleButton.Location = new System.Drawing.Point(1046, 280);
            this.moogleButton.Name = "moogleButton";
            this.moogleButton.Size = new System.Drawing.Size(230, 167);
            this.moogleButton.TabIndex = 14;
            this.moogleButton.Text = "Moogle";
            this.moogleButton.UseVisualStyleBackColor = false;
            this.moogleButton.Click += new System.EventHandler(this.moogleButton_Click);
            this.moogleButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // bingButton
            // 
            this.bingButton.BackColor = System.Drawing.Color.White;
            this.bingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bingButton.FlatAppearance.BorderSize = 0;
            this.bingButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bingButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bingButton.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bingButton.Location = new System.Drawing.Point(791, 280);
            this.bingButton.Name = "bingButton";
            this.bingButton.Size = new System.Drawing.Size(230, 167);
            this.bingButton.TabIndex = 13;
            this.bingButton.Text = "Bing";
            this.bingButton.UseVisualStyleBackColor = false;
            this.bingButton.Click += new System.EventHandler(this.bingButton_Click);
            this.bingButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // duckDuckGoButton
            // 
            this.duckDuckGoButton.BackColor = System.Drawing.Color.White;
            this.duckDuckGoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.duckDuckGoButton.FlatAppearance.BorderSize = 0;
            this.duckDuckGoButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.duckDuckGoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.duckDuckGoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.duckDuckGoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.duckDuckGoButton.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duckDuckGoButton.Location = new System.Drawing.Point(542, 280);
            this.duckDuckGoButton.Name = "duckDuckGoButton";
            this.duckDuckGoButton.Size = new System.Drawing.Size(230, 167);
            this.duckDuckGoButton.TabIndex = 12;
            this.duckDuckGoButton.Text = "Duck Duck Go";
            this.duckDuckGoButton.UseVisualStyleBackColor = false;
            this.duckDuckGoButton.Click += new System.EventHandler(this.duckDuckGoButton_Click);
            this.duckDuckGoButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // googleButton
            // 
            this.googleButton.BackColor = System.Drawing.Color.White;
            this.googleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.googleButton.FlatAppearance.BorderSize = 0;
            this.googleButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.googleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.googleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.googleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.googleButton.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.googleButton.Location = new System.Drawing.Point(293, 280);
            this.googleButton.Name = "googleButton";
            this.googleButton.Size = new System.Drawing.Size(230, 167);
            this.googleButton.TabIndex = 11;
            this.googleButton.Text = "Google";
            this.googleButton.UseVisualStyleBackColor = false;
            this.googleButton.Click += new System.EventHandler(this.googleButton_Click);
            this.googleButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // ExitSettings
            // 
            this.ExitSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitSettings.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ExitSettings.BackgroundImage = global::Surf.Properties.Resources.XIcon;
            this.ExitSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitSettings.Location = new System.Drawing.Point(2247, 0);
            this.ExitSettings.Name = "ExitSettings";
            this.ExitSettings.Size = new System.Drawing.Size(74, 74);
            this.ExitSettings.TabIndex = 0;
            this.ExitSettings.UseVisualStyleBackColor = false;
            this.ExitSettings.Click += new System.EventHandler(this.ExitSettings_Click);
            this.ExitSettings.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // settingsLabel
            // 
            this.settingsLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.settingsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsLabel.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLabel.Location = new System.Drawing.Point(0, 0);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(2330, 74);
            this.settingsLabel.TabIndex = 1;
            this.settingsLabel.Text = "J7 SURF SETTINGS";
            this.settingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SurfUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(2588, 1628);
            this.Controls.Add(this.ExitFullscreenButton);
            this.Controls.Add(this.ShowSideButton);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.webView);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.mainBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1800, 400);
            this.Name = "SurfUI";
            this.Text = "Surf";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.SideBar.ResumeLayout(false);
            this.SideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.mainBar.ResumeLayout(false);
            this.mainBar.PerformLayout();
            this.settings.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton HistoryButton;
        private System.Windows.Forms.ToolStripButton LDButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton FullScreenButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton VisibilityButton;
        private System.Windows.Forms.ToolStripButton DockButton;
        private System.Windows.Forms.ToolStrip SideBar;
        public Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private System.Windows.Forms.Button ShowSideButton;
        private System.Windows.Forms.Button ExitFullscreenButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton BackButton;
        private System.Windows.Forms.ToolStripButton ForwardButton;
        private System.Windows.Forms.ToolStripButton ReloadButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripTextBox SearchBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton DownloadsButton;
        private System.Windows.Forms.ToolStripButton HomeButton;
        private System.Windows.Forms.ToolStripButton Surf;
        private System.Windows.Forms.ToolStrip mainBar;
        private System.Windows.Forms.ToolStripButton SecureImage;
        private System.Windows.Forms.ToolStripButton SettingsButton;
        private System.Windows.Forms.Panel settings;
        private System.Windows.Forms.Button ExitSettings;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Label dseLabel;
        private System.Windows.Forms.Button yandexButton;
        private System.Windows.Forms.Button baiduButton;
        private System.Windows.Forms.Button naverButton;
        private System.Windows.Forms.Button ecosiaButton;
        private System.Windows.Forms.Button braveButton;
        private System.Windows.Forms.Button yahooButton;
        private System.Windows.Forms.Button moogleButton;
        private System.Windows.Forms.Button bingButton;
        private System.Windows.Forms.Button duckDuckGoButton;
        private System.Windows.Forms.Button googleButton;
    }
}