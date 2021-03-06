﻿using RocketBot2.Models;
using System;
using System.Windows.Forms;

namespace RocketBot2.Forms
{
    partial class MainForm : IDisposable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void  Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        new void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /*~MainForm()
        {
            Dispose(false);
        }*/

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.logTextBox = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startStopBotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokeEaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.olvPokemonList = new BrightIdeasSoftware.ObjectListView();
            this.pkmnName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pkmnCP = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pkmnAtkIV = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pkmnDefIV = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pkmnStaIV = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pkmnIV = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pkmnLevel = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pkmnCandy = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pkmnCandyToEvolve = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pkmnEvolveTimes = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pkmnMove1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pkmnMove2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pkmnTransferButton = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pkmnPowerUpButton = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pkmnEvolveButton = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.cmsPokemonList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.largePokemonImageList = new System.Windows.Forms.ImageList(this.components);
            this.smallPokemonImageList = new System.Windows.Forms.ImageList(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.GMAPSatellite = new System.Windows.Forms.CheckBox();
            this.togglePrecalRoute = new System.Windows.Forms.CheckBox();
            this.followTrainerCheckBox = new System.Windows.Forms.CheckBox();
            this.showMoreCheckBox = new System.Windows.Forms.CheckBox();
            this.speedLable = new System.Windows.Forms.Label();
            this.btnPokeDex = new System.Windows.Forms.Button();
            this.checkBoxAutoRefresh = new System.Windows.Forms.CheckBox();
            this.lblInventory = new System.Windows.Forms.Label();
            this.flpItems = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPokemonList = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvPokemonList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // logTextBox
            // 
            this.logTextBox.BackColor = System.Drawing.Color.Black;
            this.logTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logTextBox.ForeColor = System.Drawing.Color.White;
            this.logTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.logTextBox.Location = new System.Drawing.Point(0, 0);
            this.logTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.logTextBox.Size = new System.Drawing.Size(651, 283);
            this.logTextBox.TabIndex = 0;
            this.logTextBox.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 571);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1341, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(49, 20);
            this.statusLabel.Text = "Status";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startStopBotToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.accountsToolStripMenuItem,
            this.showConsoleToolStripMenuItem,
            this.pokeEaseToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1341, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startStopBotToolStripMenuItem
            // 
            this.startStopBotToolStripMenuItem.Name = "startStopBotToolStripMenuItem";
            this.startStopBotToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.startStopBotToolStripMenuItem.Text = "▶ Start RocketBot2";
            this.startStopBotToolStripMenuItem.Click += new System.EventHandler(this.StartStopBotToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.settingToolStripMenuItem.Text = "Settings";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.TodoToolStripMenuItem_Click);
            // 
            // accountsToolStripMenuItem
            // 
            this.accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            this.accountsToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.accountsToolStripMenuItem.Text = "Accounts";
            this.accountsToolStripMenuItem.Click += new System.EventHandler(this.AccountsToolStripMenuItem_Click);
            // 
            // showConsoleToolStripMenuItem
            // 
            this.showConsoleToolStripMenuItem.Name = "showConsoleToolStripMenuItem";
            this.showConsoleToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.showConsoleToolStripMenuItem.Text = "Show Console";
            this.showConsoleToolStripMenuItem.Click += new System.EventHandler(this.ShowConsoleToolStripMenuItem_Click);
            // 
            // pokeEaseToolStripMenuItem
            // 
            this.pokeEaseToolStripMenuItem.Name = "pokeEaseToolStripMenuItem";
            this.pokeEaseToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.pokeEaseToolStripMenuItem.Text = "PokeEase";
            this.pokeEaseToolStripMenuItem.Click += new System.EventHandler(this.PokeEaseToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.aboutToolStripMenuItem.Text = "About && Sniper";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // GMapControl1
            // 
            this.GMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GMapControl1.Bearing = 0F;
            this.GMapControl1.CanDragMap = true;
            this.GMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.GMapControl1.GrayScaleMode = false;
            this.GMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.GMapControl1.LevelsKeepInMemmory = 5;
            this.GMapControl1.Location = new System.Drawing.Point(4, 4);
            this.GMapControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.GMapControl1.MarkersEnabled = true;
            this.GMapControl1.MaxZoom = 18;
            this.GMapControl1.MinZoom = 2;
            this.GMapControl1.MouseWheelZoomEnabled = true;
            this.GMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.GMapControl1.Name = "GMapControl1";
            this.GMapControl1.NegativeMode = false;
            this.GMapControl1.PolygonsEnabled = true;
            this.GMapControl1.RetryLoadTile = 0;
            this.GMapControl1.RoutesEnabled = true;
            this.GMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.GMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.GMapControl1.ShowTileGridLines = false;
            this.GMapControl1.Size = new System.Drawing.Size(644, 246);
            this.GMapControl1.TabIndex = 23;
            this.GMapControl1.Zoom = 15D;
            this.GMapControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GMapControl1_MouseDoubleClick);
            // 
            // olvPokemonList
            // 
            this.olvPokemonList.AllColumns.Add(this.pkmnName);
            this.olvPokemonList.AllColumns.Add(this.pkmnCP);
            this.olvPokemonList.AllColumns.Add(this.pkmnAtkIV);
            this.olvPokemonList.AllColumns.Add(this.pkmnDefIV);
            this.olvPokemonList.AllColumns.Add(this.pkmnStaIV);
            this.olvPokemonList.AllColumns.Add(this.pkmnIV);
            this.olvPokemonList.AllColumns.Add(this.pkmnLevel);
            this.olvPokemonList.AllColumns.Add(this.pkmnCandy);
            this.olvPokemonList.AllColumns.Add(this.pkmnCandyToEvolve);
            this.olvPokemonList.AllColumns.Add(this.pkmnEvolveTimes);
            this.olvPokemonList.AllColumns.Add(this.pkmnMove1);
            this.olvPokemonList.AllColumns.Add(this.pkmnMove2);
            this.olvPokemonList.AllColumns.Add(this.pkmnTransferButton);
            this.olvPokemonList.AllColumns.Add(this.pkmnPowerUpButton);
            this.olvPokemonList.AllColumns.Add(this.pkmnEvolveButton);
            this.olvPokemonList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olvPokemonList.CellEditUseWholeCell = false;
            this.olvPokemonList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pkmnName,
            this.pkmnCP,
            this.pkmnAtkIV,
            this.pkmnDefIV,
            this.pkmnStaIV,
            this.pkmnIV,
            this.pkmnLevel,
            this.pkmnCandy,
            this.pkmnCandyToEvolve,
            this.pkmnEvolveTimes,
            this.pkmnMove1,
            this.pkmnMove2,
            this.pkmnTransferButton,
            this.pkmnPowerUpButton,
            this.pkmnEvolveButton});
            this.olvPokemonList.ContextMenuStrip = this.cmsPokemonList;
            this.olvPokemonList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.olvPokemonList.FullRowSelect = true;
            this.olvPokemonList.GridLines = true;
            this.olvPokemonList.LargeImageList = this.largePokemonImageList;
            this.olvPokemonList.Location = new System.Drawing.Point(2, 0);
            this.olvPokemonList.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.olvPokemonList.Name = "olvPokemonList";
            this.olvPokemonList.RowHeight = 32;
            this.olvPokemonList.ShowGroups = false;
            this.olvPokemonList.Size = new System.Drawing.Size(683, 355);
            this.olvPokemonList.SmallImageList = this.smallPokemonImageList;
            this.olvPokemonList.TabIndex = 25;
            this.olvPokemonList.UseCompatibleStateImageBehavior = false;
            this.olvPokemonList.View = System.Windows.Forms.View.Details;
            this.olvPokemonList.ButtonClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.OlvPokemonList_ButtonClick);
            this.olvPokemonList.DoubleClick += new System.EventHandler(this.OlvPokemonList_DoubleClick);
            // 
            // pkmnName
            // 
            this.pkmnName.AspectName = "PokemonId";
            this.pkmnName.AspectToStringFormat = "";
            this.pkmnName.Text = "Name";
            this.pkmnName.Width = 100;
            // 
            // pkmnCP
            // 
            this.pkmnCP.AspectName = "Cp";
            this.pkmnCP.Text = "CP";
            this.pkmnCP.Width = 40;
            // 
            // pkmnAtkIV
            // 
            this.pkmnAtkIV.AspectName = "IndividualAttack";
            this.pkmnAtkIV.Text = "Atk IV";
            this.pkmnAtkIV.Width = 30;
            // 
            // pkmnDefIV
            // 
            this.pkmnDefIV.AspectName = "IndividualDefense";
            this.pkmnDefIV.Text = "Def IV";
            this.pkmnDefIV.Width = 30;
            // 
            // pkmnStaIV
            // 
            this.pkmnStaIV.AspectName = "IndividualStamina";
            this.pkmnStaIV.Text = "Sta IV";
            this.pkmnStaIV.Width = 30;
            // 
            // pkmnIV
            // 
            this.pkmnIV.AspectName = "GetIV";
            this.pkmnIV.AspectToStringFormat = "{0:P2}";
            this.pkmnIV.Text = "IV %";
            this.pkmnIV.Width = 54;
            // 
            // pkmnLevel
            // 
            this.pkmnLevel.AspectName = "GetLv";
            this.pkmnLevel.Text = "Lv";
            this.pkmnLevel.Width = 40;
            // 
            // pkmnCandy
            // 
            this.pkmnCandy.AspectName = "Candy";
            this.pkmnCandy.Text = "Candy";
            this.pkmnCandy.Width = 50;
            // 
            // pkmnCandyToEvolve
            // 
            this.pkmnCandyToEvolve.AspectName = "CandyToEvolve";
            this.pkmnCandyToEvolve.Text = "CtE";
            this.pkmnCandyToEvolve.Width = 35;
            // 
            // pkmnEvolveTimes
            // 
            this.pkmnEvolveTimes.AspectName = "EvolveTimes";
            this.pkmnEvolveTimes.Text = "Evolves";
            this.pkmnEvolveTimes.Width = 30;
            // 
            // pkmnMove1
            // 
            this.pkmnMove1.AspectName = "Move1";
            this.pkmnMove1.Text = "Move1";
            this.pkmnMove1.Width = 70;
            // 
            // pkmnMove2
            // 
            this.pkmnMove2.AspectName = "Move2";
            this.pkmnMove2.Text = "Move2";
            this.pkmnMove2.Width = 70;
            // 
            // pkmnTransferButton
            // 
            this.pkmnTransferButton.AspectName = "Id";
            this.pkmnTransferButton.AspectToStringFormat = "Transfer";
            this.pkmnTransferButton.ButtonSizing = BrightIdeasSoftware.OLVColumn.ButtonSizingMode.CellBounds;
            this.pkmnTransferButton.IsButton = true;
            this.pkmnTransferButton.Text = "";
            // 
            // pkmnPowerUpButton
            // 
            this.pkmnPowerUpButton.AspectName = "Id";
            this.pkmnPowerUpButton.AspectToStringFormat = "Power Up";
            this.pkmnPowerUpButton.ButtonSizing = BrightIdeasSoftware.OLVColumn.ButtonSizingMode.CellBounds;
            this.pkmnPowerUpButton.IsButton = true;
            this.pkmnPowerUpButton.Text = "";
            // 
            // pkmnEvolveButton
            // 
            this.pkmnEvolveButton.AspectName = "Id";
            this.pkmnEvolveButton.AspectToStringFormat = "Evolve";
            this.pkmnEvolveButton.ButtonSizing = BrightIdeasSoftware.OLVColumn.ButtonSizingMode.CellBounds;
            this.pkmnEvolveButton.IsButton = true;
            this.pkmnEvolveButton.Text = "";
            // 
            // cmsPokemonList
            // 
            this.cmsPokemonList.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPokemonList.Name = "cmsPokemonList";
            this.cmsPokemonList.ShowImageMargin = false;
            this.cmsPokemonList.Size = new System.Drawing.Size(36, 4);
            // 
            // largePokemonImageList
            // 
            this.largePokemonImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.largePokemonImageList.ImageSize = new System.Drawing.Size(96, 96);
            this.largePokemonImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // smallPokemonImageList
            // 
            this.smallPokemonImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.smallPokemonImageList.ImageSize = new System.Drawing.Size(32, 32);
            this.smallPokemonImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRefresh.Location = new System.Drawing.Point(517, 509);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(68, 28);
            this.btnRefresh.TabIndex = 26;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 30);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnPokeDex);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxAutoRefresh);
            this.splitContainer1.Panel2.Controls.Add(this.lblInventory);
            this.splitContainer1.Panel2.Controls.Add(this.flpItems);
            this.splitContainer1.Panel2.Controls.Add(this.lblPokemonList);
            this.splitContainer1.Panel2.Controls.Add(this.olvPokemonList);
            this.splitContainer1.Panel2.Controls.Add(this.btnRefresh);
            this.splitContainer1.Size = new System.Drawing.Size(1341, 541);
            this.splitContainer1.SplitterDistance = 651;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 27;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.logTextBox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.GMAPSatellite);
            this.splitContainer2.Panel2.Controls.Add(this.togglePrecalRoute);
            this.splitContainer2.Panel2.Controls.Add(this.followTrainerCheckBox);
            this.splitContainer2.Panel2.Controls.Add(this.showMoreCheckBox);
            this.splitContainer2.Panel2.Controls.Add(this.speedLable);
            this.splitContainer2.Panel2.Controls.Add(this.GMapControl1);
            this.splitContainer2.Size = new System.Drawing.Size(651, 541);
            this.splitContainer2.SplitterDistance = 283;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // GMAPSatellite
            // 
            this.GMAPSatellite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GMAPSatellite.AutoSize = true;
            this.GMAPSatellite.BackColor = System.Drawing.Color.Transparent;
            this.GMAPSatellite.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GMAPSatellite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.GMAPSatellite.ForeColor = System.Drawing.Color.Red;
            this.GMAPSatellite.Location = new System.Drawing.Point(550, 68);
            this.GMAPSatellite.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.GMAPSatellite.Name = "GMAPSatellite";
            this.GMAPSatellite.Size = new System.Drawing.Size(89, 21);
            this.GMAPSatellite.TabIndex = 28;
            this.GMAPSatellite.Text = "Satellite";
            this.GMAPSatellite.UseVisualStyleBackColor = false;
            this.GMAPSatellite.Visible = false;
            this.GMAPSatellite.CheckedChanged += new System.EventHandler(this.GMAPSatellite_CheckedChanged);
            // 
            // togglePrecalRoute
            // 
            this.togglePrecalRoute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.togglePrecalRoute.AutoSize = true;
            this.togglePrecalRoute.BackColor = System.Drawing.Color.Transparent;
            this.togglePrecalRoute.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.togglePrecalRoute.Enabled = false;
            this.togglePrecalRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.togglePrecalRoute.ForeColor = System.Drawing.Color.Red;
            this.togglePrecalRoute.Location = new System.Drawing.Point(399, 46);
            this.togglePrecalRoute.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.togglePrecalRoute.Name = "togglePrecalRoute";
            this.togglePrecalRoute.Size = new System.Drawing.Size(240, 21);
            this.togglePrecalRoute.TabIndex = 27;
            this.togglePrecalRoute.Text = "Toggle Pre-Calculated Route";
            this.togglePrecalRoute.UseVisualStyleBackColor = false;
            this.togglePrecalRoute.Visible = false;
            this.togglePrecalRoute.CheckedChanged += new System.EventHandler(this.TogglePrecalRoute_CheckedChanged);
            // 
            // followTrainerCheckBox
            // 
            this.followTrainerCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.followTrainerCheckBox.AutoSize = true;
            this.followTrainerCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.followTrainerCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.followTrainerCheckBox.Checked = true;
            this.followTrainerCheckBox.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.followTrainerCheckBox.Enabled = false;
            this.followTrainerCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.followTrainerCheckBox.ForeColor = System.Drawing.Color.Red;
            this.followTrainerCheckBox.Location = new System.Drawing.Point(471, 25);
            this.followTrainerCheckBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.followTrainerCheckBox.Name = "followTrainerCheckBox";
            this.followTrainerCheckBox.Size = new System.Drawing.Size(168, 21);
            this.followTrainerCheckBox.TabIndex = 26;
            this.followTrainerCheckBox.Text = "Map Follow Trainer";
            this.followTrainerCheckBox.UseVisualStyleBackColor = false;
            this.followTrainerCheckBox.Visible = false;
            this.followTrainerCheckBox.CheckedChanged += new System.EventHandler(this.FollowTrainerCheckBox_CheckedChanged);
            // 
            // showMoreCheckBox
            // 
            this.showMoreCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showMoreCheckBox.AutoSize = true;
            this.showMoreCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.showMoreCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.showMoreCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.showMoreCheckBox.ForeColor = System.Drawing.Color.Red;
            this.showMoreCheckBox.Location = new System.Drawing.Point(443, 4);
            this.showMoreCheckBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.showMoreCheckBox.Name = "showMoreCheckBox";
            this.showMoreCheckBox.Size = new System.Drawing.Size(196, 21);
            this.showMoreCheckBox.TabIndex = 25;
            this.showMoreCheckBox.Text = "Show Advance Options";
            this.showMoreCheckBox.UseVisualStyleBackColor = false;
            this.showMoreCheckBox.CheckedChanged += new System.EventHandler(this.ShowMoreCheckBox_CheckedChanged);
            // 
            // speedLable
            // 
            this.speedLable.AutoSize = true;
            this.speedLable.BackColor = System.Drawing.Color.Transparent;
            this.speedLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.speedLable.ForeColor = System.Drawing.Color.Red;
            this.speedLable.Location = new System.Drawing.Point(1, 4);
            this.speedLable.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.speedLable.Name = "speedLable";
            this.speedLable.Size = new System.Drawing.Size(0, 17);
            this.speedLable.TabIndex = 24;
            // 
            // btnPokeDex
            // 
            this.btnPokeDex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPokeDex.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPokeDex.Enabled = false;
            this.btnPokeDex.Location = new System.Drawing.Point(597, 509);
            this.btnPokeDex.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnPokeDex.Name = "btnPokeDex";
            this.btnPokeDex.Size = new System.Drawing.Size(73, 28);
            this.btnPokeDex.TabIndex = 35;
            this.btnPokeDex.Text = "PokéDex";
            this.btnPokeDex.UseVisualStyleBackColor = true;
            this.btnPokeDex.Click += new System.EventHandler(this.BtnPokeDex_Click);
            // 
            // checkBoxAutoRefresh
            // 
            this.checkBoxAutoRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxAutoRefresh.AutoSize = true;
            this.checkBoxAutoRefresh.Checked = true;
            this.checkBoxAutoRefresh.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.checkBoxAutoRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.checkBoxAutoRefresh.Location = new System.Drawing.Point(11, 516);
            this.checkBoxAutoRefresh.Name = "checkBoxAutoRefresh";
            this.checkBoxAutoRefresh.Size = new System.Drawing.Size(133, 21);
            this.checkBoxAutoRefresh.TabIndex = 34;
            this.checkBoxAutoRefresh.Text = "Auto Resfresh";
            this.checkBoxAutoRefresh.UseVisualStyleBackColor = true;
            this.checkBoxAutoRefresh.CheckedChanged += new System.EventHandler(this.CheckBoxAutoRefresh_CheckedChanged);
            // 
            // lblInventory
            // 
            this.lblInventory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInventory.Location = new System.Drawing.Point(2, 494);
            this.lblInventory.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(683, 16);
            this.lblInventory.TabIndex = 33;
            this.lblInventory.Text = "0 / 0 ";
            this.lblInventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpItems
            // 
            this.flpItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpItems.AutoScroll = true;
            this.flpItems.BackColor = System.Drawing.SystemColors.Window;
            this.flpItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpItems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpItems.Location = new System.Drawing.Point(2, 377);
            this.flpItems.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.flpItems.Name = "flpItems";
            this.flpItems.Size = new System.Drawing.Size(683, 114);
            this.flpItems.TabIndex = 32;
            // 
            // lblPokemonList
            // 
            this.lblPokemonList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPokemonList.Location = new System.Drawing.Point(3, 357);
            this.lblPokemonList.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblPokemonList.Name = "lblPokemonList";
            this.lblPokemonList.Size = new System.Drawing.Size(683, 16);
            this.lblPokemonList.TabIndex = 27;
            this.lblPokemonList.Text = "0 / 0";
            this.lblPokemonList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 596);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RocketBot2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvPokemonList)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox logTextBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripMenuItem startStopBotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private GMap.NET.WindowsForms.GMapControl GMapControl1;
        private BrightIdeasSoftware.ObjectListView olvPokemonList;
        private BrightIdeasSoftware.OLVColumn pkmnName;
        private BrightIdeasSoftware.OLVColumn pkmnCP;
        private BrightIdeasSoftware.OLVColumn pkmnAtkIV;
        private BrightIdeasSoftware.OLVColumn pkmnDefIV;
        private BrightIdeasSoftware.OLVColumn pkmnStaIV;
        private BrightIdeasSoftware.OLVColumn pkmnIV;
        private BrightIdeasSoftware.OLVColumn pkmnTransferButton;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ImageList smallPokemonImageList;
        private System.Windows.Forms.ImageList largePokemonImageList;
        private BrightIdeasSoftware.OLVColumn pkmnPowerUpButton;
        private BrightIdeasSoftware.OLVColumn pkmnEvolveButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label lblPokemonList;
        private BrightIdeasSoftware.OLVColumn pkmnCandy;
        private BrightIdeasSoftware.OLVColumn pkmnCandyToEvolve;
        private BrightIdeasSoftware.OLVColumn pkmnEvolveTimes;
        private System.Windows.Forms.ContextMenuStrip cmsPokemonList;
        private System.Windows.Forms.FlowLayoutPanel flpItems;
        private System.Windows.Forms.Label lblInventory;
        private BrightIdeasSoftware.OLVColumn pkmnLevel;
        private BrightIdeasSoftware.OLVColumn pkmnMove1;
        private BrightIdeasSoftware.OLVColumn pkmnMove2;
        private Label speedLable;
        private CheckBox togglePrecalRoute;
        private CheckBox followTrainerCheckBox;
        private CheckBox showMoreCheckBox;
        private ToolStripMenuItem accountsToolStripMenuItem;
        private ToolStripMenuItem showConsoleToolStripMenuItem;
        public CheckBox checkBoxAutoRefresh;
        private Button btnPokeDex;
        private ToolStripMenuItem pokeEaseToolStripMenuItem;
        private CheckBox GMAPSatellite;
    }
}