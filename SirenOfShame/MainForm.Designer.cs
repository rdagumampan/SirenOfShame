﻿using System;
using SirenOfShame.Lib.Watcher;

namespace SirenOfShame {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
            try
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            } catch (Exception ex)
            {
                
            }
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this._lastStatusUpdate = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.minimizedMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.duration2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkedInBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.balls = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this._openSettings = new System.Windows.Forms.Button();
            this._configureSiren = new System.Windows.Forms.Button();
            this._testSiren = new System.Windows.Forms.Button();
            this._configureServers = new System.Windows.Forms.Button();
            this._configureRules = new System.Windows.Forms.Button();
            this.buildStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._buildMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._affectsTrayIcon = new System.Windows.Forms.ToolStripMenuItem();
            this._stopWatching = new System.Windows.Forms.ToolStripMenuItem();
            this._when = new System.Windows.Forms.ToolStripMenuItem();
            this._toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1.SuspendLayout();
            this.minimizedMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buildStatusBindingSource)).BeginInit();
            this._buildMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._lastStatusUpdate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 195);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(909, 22);
            this.statusStrip1.TabIndex = 29;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // _lastStatusUpdate
            // 
            this._lastStatusUpdate.Name = "_lastStatusUpdate";
            this._lastStatusUpdate.Size = new System.Drawing.Size(119, 17);
            this._lastStatusUpdate.Text = "Build Last Checked: n/a";
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.ContextMenuStrip = this.minimizedMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Siren of Shame";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.NotifyIconDoubleClick);
            // 
            // minimizedMenu
            // 
            this.minimizedMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.minimizedMenu.Name = "contextMenuStrip1";
            this.minimizedMenu.Size = new System.Drawing.Size(104, 48);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItemClick);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.date,
            this.duration2,
            this.checkedInBy,
            this.comment});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 30);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(909, 165);
            this.listView1.SmallImageList = this.balls;
            this.listView1.TabIndex = 36;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.ListView1DoubleClick);
            this.listView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ListView1MouseUp);
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 150;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.Width = 105;
            // 
            // duration2
            // 
            this.duration2.Text = "Duration";
            this.duration2.Width = 54;
            // 
            // checkedInBy
            // 
            this.checkedInBy.Text = "Checked In By";
            this.checkedInBy.Width = 102;
            // 
            // comment
            // 
            this.comment.Text = "Comment";
            this.comment.Width = 250;
            // 
            // balls
            // 
            this.balls.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("balls.ImageStream")));
            this.balls.TransparentColor = System.Drawing.Color.Transparent;
            this.balls.Images.SetKeyName(0, "ball_red.png");
            this.balls.Images.SetKeyName(1, "ball_green.png");
            this.balls.Images.SetKeyName(2, "ball_gray.png");
            this.balls.Images.SetKeyName(3, "ConfigureRules.png");
            this.balls.Images.SetKeyName(4, "ConfigureServer.png");
            this.balls.Images.SetKeyName(5, "TestSiren.png");
            this.balls.Images.SetKeyName(6, "ConfigureSiren.png");
            this.balls.Images.SetKeyName(7, "question.png");
            this.balls.Images.SetKeyName(8, "Tools.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this._openSettings);
            this.panel1.Controls.Add(this._configureSiren);
            this.panel1.Controls.Add(this._testSiren);
            this.panel1.Controls.Add(this._configureServers);
            this.panel1.Controls.Add(this._configureRules);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 30);
            this.panel1.TabIndex = 37;
            // 
            // _openSettings
            // 
            this._openSettings.FlatAppearance.BorderSize = 0;
            this._openSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._openSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._openSettings.ImageIndex = 8;
            this._openSettings.ImageList = this.balls;
            this._openSettings.Location = new System.Drawing.Point(414, 3);
            this._openSettings.Name = "_openSettings";
            this._openSettings.Size = new System.Drawing.Size(70, 23);
            this._openSettings.TabIndex = 4;
            this._openSettings.Text = "Settings";
            this._openSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._openSettings.UseVisualStyleBackColor = true;
            this._openSettings.Click += new System.EventHandler(this.OpenSettingsClick);
            // 
            // _configureSiren
            // 
            this._configureSiren.FlatAppearance.BorderSize = 0;
            this._configureSiren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._configureSiren.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._configureSiren.ImageIndex = 6;
            this._configureSiren.ImageList = this.balls;
            this._configureSiren.Location = new System.Drawing.Point(304, 3);
            this._configureSiren.Name = "_configureSiren";
            this._configureSiren.Size = new System.Drawing.Size(104, 23);
            this._configureSiren.TabIndex = 3;
            this._configureSiren.Text = "Configure Siren";
            this._configureSiren.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._configureSiren.UseVisualStyleBackColor = true;
            this._configureSiren.Click += new System.EventHandler(this.ConfigureSirenClick);
            // 
            // _testSiren
            // 
            this._testSiren.Enabled = false;
            this._testSiren.FlatAppearance.BorderSize = 0;
            this._testSiren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._testSiren.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._testSiren.ImageIndex = 5;
            this._testSiren.ImageList = this.balls;
            this._testSiren.Location = new System.Drawing.Point(218, 3);
            this._testSiren.Name = "_testSiren";
            this._testSiren.Size = new System.Drawing.Size(80, 23);
            this._testSiren.TabIndex = 2;
            this._testSiren.Text = "Test Siren";
            this._testSiren.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._testSiren.UseVisualStyleBackColor = true;
            this._testSiren.Click += new System.EventHandler(this.TestSirenClick);
            // 
            // _configureServers
            // 
            this._configureServers.FlatAppearance.BorderSize = 0;
            this._configureServers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._configureServers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._configureServers.ImageIndex = 4;
            this._configureServers.ImageList = this.balls;
            this._configureServers.Location = new System.Drawing.Point(12, 4);
            this._configureServers.Name = "_configureServers";
            this._configureServers.Size = new System.Drawing.Size(87, 23);
            this._configureServers.TabIndex = 1;
            this._configureServers.Text = "Add Server";
            this._configureServers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._configureServers.UseVisualStyleBackColor = true;
            this._configureServers.Click += new System.EventHandler(this.ConfigureServersClick);
            // 
            // _configureRules
            // 
            this._configureRules.FlatAppearance.BorderSize = 0;
            this._configureRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._configureRules.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._configureRules.ImageIndex = 3;
            this._configureRules.ImageList = this.balls;
            this._configureRules.Location = new System.Drawing.Point(105, 4);
            this._configureRules.Name = "_configureRules";
            this._configureRules.Size = new System.Drawing.Size(107, 23);
            this._configureRules.TabIndex = 0;
            this._configureRules.Text = "Configure Rules";
            this._configureRules.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._configureRules.UseVisualStyleBackColor = true;
            this._configureRules.Click += new System.EventHandler(this.ConfigureRulesClick);
            // 
            // buildStatusBindingSource
            // 
            this.buildStatusBindingSource.DataSource = typeof(SirenOfShame.Lib.Watcher.BuildStatus);
            // 
            // _buildMenu
            // 
            this._buildMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._affectsTrayIcon,
            this._stopWatching,
            this._when,
            this._toolStripSeparator1});
            this._buildMenu.Name = "_buildMenu";
            this._buildMenu.Size = new System.Drawing.Size(159, 76);
            this._buildMenu.Text = "BuildMenu";
            this._buildMenu.Opening += new System.ComponentModel.CancelEventHandler(this.BuildMenuOpening);
            // 
            // _affectsTrayIcon
            // 
            this._affectsTrayIcon.Checked = true;
            this._affectsTrayIcon.CheckState = System.Windows.Forms.CheckState.Checked;
            this._affectsTrayIcon.Name = "_affectsTrayIcon";
            this._affectsTrayIcon.Size = new System.Drawing.Size(158, 22);
            this._affectsTrayIcon.Text = "Affects Tray Icon";
            this._affectsTrayIcon.Click += new System.EventHandler(this.AffectsTrayIconClick);
            // 
            // _stopWatching
            // 
            this._stopWatching.Name = "_stopWatching";
            this._stopWatching.Size = new System.Drawing.Size(158, 22);
            this._stopWatching.Text = "Stop Watching";
            this._stopWatching.Click += new System.EventHandler(this.StopWatchingClick);
            // 
            // _when
            // 
            this._when.Name = "_when";
            this._when.Size = new System.Drawing.Size(158, 22);
            this._when.Text = "When";
            // 
            // _toolStripSeparator1
            // 
            this._toolStripSeparator1.Name = "_toolStripSeparator1";
            this._toolStripSeparator1.Size = new System.Drawing.Size(155, 6);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 217);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.Text = "Siren of Shame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
            this.Load += new System.EventHandler(this.Form1Load);
            this.Move += new System.EventHandler(this.MainFormMove);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.minimizedMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buildStatusBindingSource)).EndInit();
            this._buildMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel _lastStatusUpdate;
        private System.Windows.Forms.BindingSource buildStatusBindingSource;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip minimizedMenu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        //private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader checkedInBy;
        private System.Windows.Forms.ImageList balls;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button _configureRules;
        private System.Windows.Forms.Button _configureServers;
        private System.Windows.Forms.Button _testSiren;
        private System.Windows.Forms.Button _configureSiren;
        private System.Windows.Forms.ContextMenuStrip _buildMenu;
        private System.Windows.Forms.ToolStripMenuItem _affectsTrayIcon;
        private System.Windows.Forms.ToolStripMenuItem _when;
        private System.Windows.Forms.ToolStripSeparator _toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem _stopWatching;
      private System.Windows.Forms.Button _openSettings;
      private System.Windows.Forms.ColumnHeader comment;
      private System.Windows.Forms.ColumnHeader duration2;

	}
}
