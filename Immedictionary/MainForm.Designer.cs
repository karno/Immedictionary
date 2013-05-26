namespace Immedictionary
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toggleWatchClipboardButton = new System.Windows.Forms.ToolStripButton();
            this.executeSearchButton = new System.Windows.Forms.ToolStripButton();
            this.browserOwnerTab = new System.Windows.Forms.TabControl();
            this.tabWeblio = new System.Windows.Forms.TabPage();
            this.browserWeblio = new System.Windows.Forms.WebBrowser();
            this.tabNaver = new System.Windows.Forms.TabPage();
            this.browserNaver = new System.Windows.Forms.WebBrowser();
            this.tabSpaceAlc = new System.Windows.Forms.TabPage();
            this.browserSpaceAlc = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.browserOwnerTab.SuspendLayout();
            this.tabWeblio.SuspendLayout();
            this.tabNaver.SuspendLayout();
            this.tabSpaceAlc.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1199, 25);
            this.panel1.TabIndex = 0;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.Location = new System.Drawing.Point(35, 3);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(1136, 19);
            this.searchTextBox.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toggleWatchClipboardButton,
            this.executeSearchButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1199, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toggleWatchClipboardButton
            // 
            this.toggleWatchClipboardButton.CheckOnClick = true;
            this.toggleWatchClipboardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toggleWatchClipboardButton.Image = ((System.Drawing.Image)(resources.GetObject("toggleWatchClipboardButton.Image")));
            this.toggleWatchClipboardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toggleWatchClipboardButton.Name = "toggleWatchClipboardButton";
            this.toggleWatchClipboardButton.Size = new System.Drawing.Size(23, 22);
            this.toggleWatchClipboardButton.Text = "クリップボードを監視";
            // 
            // executeSearchButton
            // 
            this.executeSearchButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.executeSearchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.executeSearchButton.Image = ((System.Drawing.Image)(resources.GetObject("executeSearchButton.Image")));
            this.executeSearchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.executeSearchButton.Name = "executeSearchButton";
            this.executeSearchButton.Size = new System.Drawing.Size(23, 22);
            this.executeSearchButton.Text = "検索";
            this.executeSearchButton.Click += new System.EventHandler(this.executeSearchButton_Click);
            // 
            // browserOwnerTab
            // 
            this.browserOwnerTab.Controls.Add(this.tabWeblio);
            this.browserOwnerTab.Controls.Add(this.tabNaver);
            this.browserOwnerTab.Controls.Add(this.tabSpaceAlc);
            this.browserOwnerTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserOwnerTab.Location = new System.Drawing.Point(0, 25);
            this.browserOwnerTab.Name = "browserOwnerTab";
            this.browserOwnerTab.SelectedIndex = 0;
            this.browserOwnerTab.Size = new System.Drawing.Size(1199, 701);
            this.browserOwnerTab.TabIndex = 1;
            this.browserOwnerTab.SelectedIndexChanged += new System.EventHandler(this.browserOwnerTab_SelectedIndexChanged);
            // 
            // tabWeblio
            // 
            this.tabWeblio.Controls.Add(this.browserWeblio);
            this.tabWeblio.Location = new System.Drawing.Point(4, 22);
            this.tabWeblio.Name = "tabWeblio";
            this.tabWeblio.Padding = new System.Windows.Forms.Padding(3);
            this.tabWeblio.Size = new System.Drawing.Size(1191, 675);
            this.tabWeblio.TabIndex = 0;
            this.tabWeblio.Text = "weblio";
            this.tabWeblio.UseVisualStyleBackColor = true;
            // 
            // browserWeblio
            // 
            this.browserWeblio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserWeblio.Location = new System.Drawing.Point(3, 3);
            this.browserWeblio.MinimumSize = new System.Drawing.Size(20, 20);
            this.browserWeblio.Name = "browserWeblio";
            this.browserWeblio.ScriptErrorsSuppressed = true;
            this.browserWeblio.Size = new System.Drawing.Size(1185, 669);
            this.browserWeblio.TabIndex = 0;
            // 
            // tabNaver
            // 
            this.tabNaver.Controls.Add(this.browserNaver);
            this.tabNaver.Location = new System.Drawing.Point(4, 22);
            this.tabNaver.Name = "tabNaver";
            this.tabNaver.Padding = new System.Windows.Forms.Padding(3);
            this.tabNaver.Size = new System.Drawing.Size(1191, 675);
            this.tabNaver.TabIndex = 1;
            this.tabNaver.Text = "naver";
            this.tabNaver.UseVisualStyleBackColor = true;
            // 
            // browserNaver
            // 
            this.browserNaver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserNaver.Location = new System.Drawing.Point(3, 3);
            this.browserNaver.MinimumSize = new System.Drawing.Size(20, 20);
            this.browserNaver.Name = "browserNaver";
            this.browserNaver.ScriptErrorsSuppressed = true;
            this.browserNaver.Size = new System.Drawing.Size(1185, 669);
            this.browserNaver.TabIndex = 1;
            // 
            // tabSpaceAlc
            // 
            this.tabSpaceAlc.Controls.Add(this.browserSpaceAlc);
            this.tabSpaceAlc.Location = new System.Drawing.Point(4, 22);
            this.tabSpaceAlc.Name = "tabSpaceAlc";
            this.tabSpaceAlc.Padding = new System.Windows.Forms.Padding(3);
            this.tabSpaceAlc.Size = new System.Drawing.Size(1191, 675);
            this.tabSpaceAlc.TabIndex = 2;
            this.tabSpaceAlc.Text = "space alc";
            this.tabSpaceAlc.UseVisualStyleBackColor = true;
            // 
            // browserSpaceAlc
            // 
            this.browserSpaceAlc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserSpaceAlc.Location = new System.Drawing.Point(3, 3);
            this.browserSpaceAlc.MinimumSize = new System.Drawing.Size(20, 20);
            this.browserSpaceAlc.Name = "browserSpaceAlc";
            this.browserSpaceAlc.ScriptErrorsSuppressed = true;
            this.browserSpaceAlc.Size = new System.Drawing.Size(1185, 669);
            this.browserSpaceAlc.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 726);
            this.Controls.Add(this.browserOwnerTab);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Immedictionary";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.browserOwnerTab.ResumeLayout(false);
            this.tabWeblio.ResumeLayout(false);
            this.tabNaver.ResumeLayout(false);
            this.tabSpaceAlc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl browserOwnerTab;
        private System.Windows.Forms.TabPage tabWeblio;
        private System.Windows.Forms.TabPage tabNaver;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toggleWatchClipboardButton;
        private System.Windows.Forms.ToolStripButton executeSearchButton;
        private System.Windows.Forms.TabPage tabSpaceAlc;
        private System.Windows.Forms.WebBrowser browserWeblio;
        private System.Windows.Forms.WebBrowser browserNaver;
        private System.Windows.Forms.WebBrowser browserSpaceAlc;
    }
}

