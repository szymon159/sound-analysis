﻿using System;

namespace SoundAnalysis
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.mpfGroupBox = new System.Windows.Forms.GroupBox();
            this.mpfButton = new System.Windows.Forms.Button();
            this.mpfTextBox = new System.Windows.Forms.TextBox();
            this.windowTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.windowTypeComboBox = new System.Windows.Forms.ComboBox();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.timeParamsTabPage = new System.Windows.Forms.TabPage();
            this.timeParamsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.timeParamsChartTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.musicPlotView = new OxyPlot.WindowsForms.PlotView();
            this.soundSpeechPlotView = new OxyPlot.WindowsForms.PlotView();
            this.soundlessSpeechPlotView = new OxyPlot.WindowsForms.PlotView();
            this.silencePlotView = new OxyPlot.WindowsForms.PlotView();
            this.zcrPlotView = new OxyPlot.WindowsForms.PlotView();
            this.stePlotView = new OxyPlot.WindowsForms.PlotView();
            this.volumePlotView = new OxyPlot.WindowsForms.PlotView();
            this.timeParamsLabelsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.musicValueLabel = new System.Windows.Forms.Label();
            this.soundSpeechValueLabel = new System.Windows.Forms.Label();
            this.soundlessSpeechValueLabel = new System.Windows.Forms.Label();
            this.silenceValueLabel = new System.Windows.Forms.Label();
            this.zcrValueLabel = new System.Windows.Forms.Label();
            this.steValueLabel = new System.Windows.Forms.Label();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.steLabel = new System.Windows.Forms.Label();
            this.zcrLabel = new System.Windows.Forms.Label();
            this.silenceLabel = new System.Windows.Forms.Label();
            this.soundlessSpeechLabel = new System.Windows.Forms.Label();
            this.soundSpeechLabel = new System.Windows.Forms.Label();
            this.musicLabel = new System.Windows.Forms.Label();
            this.volumeValueLabel = new System.Windows.Forms.Label();
            this.timeParamsClipLevelTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lsterValueLabel = new System.Windows.Forms.Label();
            this.vdrValueLabel = new System.Windows.Forms.Label();
            this.hzcrrValueLabel = new System.Windows.Forms.Label();
            this.vstdLabel = new System.Windows.Forms.Label();
            this.vdrLabel = new System.Windows.Forms.Label();
            this.hzcrrLabel = new System.Windows.Forms.Label();
            this.lsterLabel = new System.Windows.Forms.Label();
            this.vstdValueLabel = new System.Windows.Forms.Label();
            this.fourierTransformTabPage = new System.Windows.Forms.TabPage();
            this.fourierTransformTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.fourierTransformScopePanel = new System.Windows.Forms.Panel();
            this.oneFrameRadioButton = new System.Windows.Forms.RadioButton();
            this.wholeClipRadioButton = new System.Windows.Forms.RadioButton();
            this.fourierFrameTimePanel = new System.Windows.Forms.Panel();
            this.frameStartTextBox = new System.Windows.Forms.TextBox();
            this.frameStartLabel = new System.Windows.Forms.Label();
            this.fourierPlotView = new OxyPlot.WindowsForms.PlotView();
            this.spectrumTabPage = new System.Windows.Forms.TabPage();
            this.spectrumTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.spectrogramPlotView = new OxyPlot.WindowsForms.PlotView();
            this.frameOverlappingPanel = new System.Windows.Forms.Panel();
            this.frameOverlappingValueLabel = new System.Windows.Forms.Label();
            this.frameOverlappingLabel = new System.Windows.Forms.Label();
            this.frameOverlappingTrackBar = new System.Windows.Forms.TrackBar();
            this.fundamentalFrequencyTabPage = new System.Windows.Forms.TabPage();
            this.fundamentalFrequencyTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.frameOverlappingTrackBar2 = new System.Windows.Forms.TrackBar();
            this.frameOverlappingPanel2 = new System.Windows.Forms.Panel();
            this.frameOverlappingValueLabel2 = new System.Windows.Forms.Label();
            this.frameOverlappingLabel2 = new System.Windows.Forms.Label();
            this.fundamentalFrequencyValueLabel = new System.Windows.Forms.Label();
            this.fundamentalFrequencyLabel = new System.Windows.Forms.Label();
            this.fundamentalFrequencyPlotView = new OxyPlot.WindowsForms.PlotView();
            this.frequencyParamsTabPage = new System.Windows.Forms.TabPage();
            this.freqParamsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.bandEndPanel = new System.Windows.Forms.Panel();
            this.applyBandButton = new System.Windows.Forms.Button();
            this.bandEndTextBox = new System.Windows.Forms.TextBox();
            this.bandEndLabel = new System.Windows.Forms.Label();
            this.bandStartPanel = new System.Windows.Forms.Panel();
            this.bandStartTextBox = new System.Windows.Forms.TextBox();
            this.bandStartLabel = new System.Windows.Forms.Label();
            this.freqParamsChartsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.frequencyParamsChartsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.bePlotView = new OxyPlot.WindowsForms.PlotView();
            this.freqVolumePlotView = new OxyPlot.WindowsForms.PlotView();
            this.fcPlotView = new OxyPlot.WindowsForms.PlotView();
            this.bwPlotView = new OxyPlot.WindowsForms.PlotView();
            this.frequencyParamsLabelsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.beValueLabel = new System.Windows.Forms.Label();
            this.beLabel = new System.Windows.Forms.Label();
            this.bwValueLabel = new System.Windows.Forms.Label();
            this.fcValueLabel = new System.Windows.Forms.Label();
            this.freqVolumeLabel = new System.Windows.Forms.Label();
            this.fcLabel = new System.Windows.Forms.Label();
            this.bwLabel = new System.Windows.Forms.Label();
            this.freqVolumeValueLabel = new System.Windows.Forms.Label();
            this.recordingPlotView = new OxyPlot.WindowsForms.PlotView();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displaySilenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSilenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soundlessSpeechToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displaySoundlessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSoundlessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soundSpeechToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displaySoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayMusicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportMusicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainLayoutPanel.SuspendLayout();
            this.mpfGroupBox.SuspendLayout();
            this.windowTypeGroupBox.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.timeParamsTabPage.SuspendLayout();
            this.timeParamsTableLayoutPanel.SuspendLayout();
            this.timeParamsChartTableLayoutPanel.SuspendLayout();
            this.timeParamsLabelsTableLayoutPanel.SuspendLayout();
            this.timeParamsClipLevelTableLayoutPanel.SuspendLayout();
            this.fourierTransformTabPage.SuspendLayout();
            this.fourierTransformTableLayoutPanel.SuspendLayout();
            this.fourierTransformScopePanel.SuspendLayout();
            this.fourierFrameTimePanel.SuspendLayout();
            this.spectrumTabPage.SuspendLayout();
            this.spectrumTableLayoutPanel.SuspendLayout();
            this.frameOverlappingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frameOverlappingTrackBar)).BeginInit();
            this.fundamentalFrequencyTabPage.SuspendLayout();
            this.fundamentalFrequencyTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frameOverlappingTrackBar2)).BeginInit();
            this.frameOverlappingPanel2.SuspendLayout();
            this.frequencyParamsTabPage.SuspendLayout();
            this.freqParamsTableLayoutPanel.SuspendLayout();
            this.bandEndPanel.SuspendLayout();
            this.bandStartPanel.SuspendLayout();
            this.freqParamsChartsTableLayoutPanel.SuspendLayout();
            this.frequencyParamsChartsTableLayoutPanel.SuspendLayout();
            this.frequencyParamsLabelsTableLayoutPanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.ColumnCount = 2;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.mainLayoutPanel.Controls.Add(this.mpfGroupBox, 0, 0);
            this.mainLayoutPanel.Controls.Add(this.windowTypeGroupBox, 0, 1);
            this.mainLayoutPanel.Controls.Add(this.mainTabControl, 0, 2);
            this.mainLayoutPanel.Controls.Add(this.recordingPlotView, 1, 0);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.mainLayoutPanel.Margin = new System.Windows.Forms.Padding(10);
            this.mainLayoutPanel.MinimumSize = new System.Drawing.Size(1000, 426);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.Padding = new System.Windows.Forms.Padding(10);
            this.mainLayoutPanel.RowCount = 3;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(1350, 705);
            this.mainLayoutPanel.TabIndex = 0;
            // 
            // mpfGroupBox
            // 
            this.mpfGroupBox.Controls.Add(this.mpfButton);
            this.mpfGroupBox.Controls.Add(this.mpfTextBox);
            this.mpfGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mpfGroupBox.Location = new System.Drawing.Point(13, 13);
            this.mpfGroupBox.Name = "mpfGroupBox";
            this.mpfGroupBox.Size = new System.Drawing.Size(260, 62);
            this.mpfGroupBox.TabIndex = 3;
            this.mpfGroupBox.TabStop = false;
            this.mpfGroupBox.Text = "Miliseconds per frame";
            // 
            // mpfButton
            // 
            this.mpfButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mpfButton.Location = new System.Drawing.Point(156, 24);
            this.mpfButton.Name = "mpfButton";
            this.mpfButton.Size = new System.Drawing.Size(86, 24);
            this.mpfButton.TabIndex = 1;
            this.mpfButton.Text = "Apply";
            this.mpfButton.UseVisualStyleBackColor = true;
            this.mpfButton.Click += new System.EventHandler(this.mpfButton_Click);
            // 
            // mpfTextBox
            // 
            this.mpfTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mpfTextBox.Location = new System.Drawing.Point(6, 26);
            this.mpfTextBox.Name = "mpfTextBox";
            this.mpfTextBox.Size = new System.Drawing.Size(139, 20);
            this.mpfTextBox.TabIndex = 0;
            // 
            // windowTypeGroupBox
            // 
            this.windowTypeGroupBox.Controls.Add(this.windowTypeComboBox);
            this.windowTypeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowTypeGroupBox.Location = new System.Drawing.Point(13, 81);
            this.windowTypeGroupBox.Name = "windowTypeGroupBox";
            this.windowTypeGroupBox.Size = new System.Drawing.Size(260, 62);
            this.windowTypeGroupBox.TabIndex = 5;
            this.windowTypeGroupBox.TabStop = false;
            this.windowTypeGroupBox.Text = "Window type";
            this.windowTypeGroupBox.Visible = false;
            // 
            // windowTypeComboBox
            // 
            this.windowTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.windowTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.windowTypeComboBox.FormattingEnabled = true;
            this.windowTypeComboBox.Items.AddRange(new object[] {
            SoundAnalysis.WindowType.Rectangular,
            SoundAnalysis.WindowType.Hamming,
            SoundAnalysis.WindowType.Hann});
            this.windowTypeComboBox.Location = new System.Drawing.Point(41, 24);
            this.windowTypeComboBox.Name = "windowTypeComboBox";
            this.windowTypeComboBox.Size = new System.Drawing.Size(185, 21);
            this.windowTypeComboBox.TabIndex = 0;
            this.windowTypeComboBox.Visible = false;
            this.windowTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.windowTypeComboBox_SelectedIndexChanged);
            // 
            // mainTabControl
            // 
            this.mainLayoutPanel.SetColumnSpan(this.mainTabControl, 2);
            this.mainTabControl.Controls.Add(this.timeParamsTabPage);
            this.mainTabControl.Controls.Add(this.fourierTransformTabPage);
            this.mainTabControl.Controls.Add(this.spectrumTabPage);
            this.mainTabControl.Controls.Add(this.fundamentalFrequencyTabPage);
            this.mainTabControl.Controls.Add(this.frequencyParamsTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(13, 149);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.Padding = new System.Drawing.Point(0, 0);
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1324, 543);
            this.mainTabControl.TabIndex = 7;
            this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.mainTabControl_SelectedIndexChanged);
            // 
            // timeParamsTabPage
            // 
            this.timeParamsTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.timeParamsTabPage.Controls.Add(this.timeParamsTableLayoutPanel);
            this.timeParamsTabPage.Location = new System.Drawing.Point(4, 22);
            this.timeParamsTabPage.Name = "timeParamsTabPage";
            this.timeParamsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.timeParamsTabPage.Size = new System.Drawing.Size(1316, 517);
            this.timeParamsTabPage.TabIndex = 0;
            this.timeParamsTabPage.Text = "Time Parameters";
            // 
            // timeParamsTableLayoutPanel
            // 
            this.timeParamsTableLayoutPanel.ColumnCount = 2;
            this.timeParamsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.timeParamsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.timeParamsTableLayoutPanel.Controls.Add(this.timeParamsChartTableLayoutPanel, 1, 0);
            this.timeParamsTableLayoutPanel.Controls.Add(this.timeParamsLabelsTableLayoutPanel, 0, 0);
            this.timeParamsTableLayoutPanel.Controls.Add(this.timeParamsClipLevelTableLayoutPanel, 1, 1);
            this.timeParamsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeParamsTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.timeParamsTableLayoutPanel.Name = "timeParamsTableLayoutPanel";
            this.timeParamsTableLayoutPanel.RowCount = 2;
            this.timeParamsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.timeParamsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.timeParamsTableLayoutPanel.Size = new System.Drawing.Size(1310, 511);
            this.timeParamsTableLayoutPanel.TabIndex = 6;
            // 
            // timeParamsChartTableLayoutPanel
            // 
            this.timeParamsChartTableLayoutPanel.ColumnCount = 1;
            this.timeParamsChartTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.timeParamsChartTableLayoutPanel.Controls.Add(this.musicPlotView, 0, 6);
            this.timeParamsChartTableLayoutPanel.Controls.Add(this.soundSpeechPlotView, 0, 5);
            this.timeParamsChartTableLayoutPanel.Controls.Add(this.soundlessSpeechPlotView, 0, 4);
            this.timeParamsChartTableLayoutPanel.Controls.Add(this.silencePlotView, 0, 3);
            this.timeParamsChartTableLayoutPanel.Controls.Add(this.zcrPlotView, 0, 2);
            this.timeParamsChartTableLayoutPanel.Controls.Add(this.stePlotView, 0, 1);
            this.timeParamsChartTableLayoutPanel.Controls.Add(this.volumePlotView, 0, 0);
            this.timeParamsChartTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeParamsChartTableLayoutPanel.Location = new System.Drawing.Point(265, 3);
            this.timeParamsChartTableLayoutPanel.Name = "timeParamsChartTableLayoutPanel";
            this.timeParamsChartTableLayoutPanel.RowCount = 7;
            this.timeParamsChartTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.timeParamsChartTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.timeParamsChartTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.timeParamsChartTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.timeParamsChartTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.timeParamsChartTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.timeParamsChartTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.timeParamsChartTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.timeParamsChartTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.timeParamsChartTableLayoutPanel.Size = new System.Drawing.Size(1042, 377);
            this.timeParamsChartTableLayoutPanel.TabIndex = 1;
            // 
            // musicPlotView
            // 
            this.musicPlotView.BackColor = System.Drawing.Color.White;
            this.musicPlotView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.musicPlotView.Location = new System.Drawing.Point(3, 321);
            this.musicPlotView.Name = "musicPlotView";
            this.musicPlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.musicPlotView.Size = new System.Drawing.Size(1036, 53);
            this.musicPlotView.TabIndex = 6;
            this.musicPlotView.Text = "musicPlotView";
            this.musicPlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.musicPlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.musicPlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // soundSpeechPlotView
            // 
            this.soundSpeechPlotView.BackColor = System.Drawing.Color.White;
            this.soundSpeechPlotView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.soundSpeechPlotView.Location = new System.Drawing.Point(3, 268);
            this.soundSpeechPlotView.Name = "soundSpeechPlotView";
            this.soundSpeechPlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.soundSpeechPlotView.Size = new System.Drawing.Size(1036, 47);
            this.soundSpeechPlotView.TabIndex = 5;
            this.soundSpeechPlotView.Text = "soundSpeechPlotView";
            this.soundSpeechPlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.soundSpeechPlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.soundSpeechPlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // soundlessSpeechPlotView
            // 
            this.soundlessSpeechPlotView.BackColor = System.Drawing.Color.White;
            this.soundlessSpeechPlotView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.soundlessSpeechPlotView.Location = new System.Drawing.Point(3, 215);
            this.soundlessSpeechPlotView.Name = "soundlessSpeechPlotView";
            this.soundlessSpeechPlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.soundlessSpeechPlotView.Size = new System.Drawing.Size(1036, 47);
            this.soundlessSpeechPlotView.TabIndex = 4;
            this.soundlessSpeechPlotView.Text = "soundlessSpeechPlotView";
            this.soundlessSpeechPlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.soundlessSpeechPlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.soundlessSpeechPlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // silencePlotView
            // 
            this.silencePlotView.BackColor = System.Drawing.Color.White;
            this.silencePlotView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.silencePlotView.Location = new System.Drawing.Point(3, 162);
            this.silencePlotView.Name = "silencePlotView";
            this.silencePlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.silencePlotView.Size = new System.Drawing.Size(1036, 47);
            this.silencePlotView.TabIndex = 3;
            this.silencePlotView.Text = "silencePlotView";
            this.silencePlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.silencePlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.silencePlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // zcrPlotView
            // 
            this.zcrPlotView.BackColor = System.Drawing.Color.White;
            this.zcrPlotView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zcrPlotView.Location = new System.Drawing.Point(3, 109);
            this.zcrPlotView.Name = "zcrPlotView";
            this.zcrPlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.zcrPlotView.Size = new System.Drawing.Size(1036, 47);
            this.zcrPlotView.TabIndex = 2;
            this.zcrPlotView.Text = "zcrPlotView";
            this.zcrPlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.zcrPlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.zcrPlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // stePlotView
            // 
            this.stePlotView.BackColor = System.Drawing.Color.White;
            this.stePlotView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stePlotView.Location = new System.Drawing.Point(3, 56);
            this.stePlotView.Name = "stePlotView";
            this.stePlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.stePlotView.Size = new System.Drawing.Size(1036, 47);
            this.stePlotView.TabIndex = 1;
            this.stePlotView.Text = "stePlotView";
            this.stePlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.stePlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.stePlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // volumePlotView
            // 
            this.volumePlotView.BackColor = System.Drawing.Color.White;
            this.volumePlotView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.volumePlotView.Location = new System.Drawing.Point(3, 3);
            this.volumePlotView.Name = "volumePlotView";
            this.volumePlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.volumePlotView.Size = new System.Drawing.Size(1036, 47);
            this.volumePlotView.TabIndex = 0;
            this.volumePlotView.Text = "volumePlotView";
            this.volumePlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.volumePlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.volumePlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // timeParamsLabelsTableLayoutPanel
            // 
            this.timeParamsLabelsTableLayoutPanel.ColumnCount = 2;
            this.timeParamsLabelsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.timeParamsLabelsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.timeParamsLabelsTableLayoutPanel.Controls.Add(this.musicValueLabel, 1, 6);
            this.timeParamsLabelsTableLayoutPanel.Controls.Add(this.soundSpeechValueLabel, 1, 5);
            this.timeParamsLabelsTableLayoutPanel.Controls.Add(this.soundlessSpeechValueLabel, 1, 4);
            this.timeParamsLabelsTableLayoutPanel.Controls.Add(this.silenceValueLabel, 1, 3);
            this.timeParamsLabelsTableLayoutPanel.Controls.Add(this.zcrValueLabel, 1, 2);
            this.timeParamsLabelsTableLayoutPanel.Controls.Add(this.steValueLabel, 1, 1);
            this.timeParamsLabelsTableLayoutPanel.Controls.Add(this.volumeLabel, 0, 0);
            this.timeParamsLabelsTableLayoutPanel.Controls.Add(this.steLabel, 0, 1);
            this.timeParamsLabelsTableLayoutPanel.Controls.Add(this.zcrLabel, 0, 2);
            this.timeParamsLabelsTableLayoutPanel.Controls.Add(this.silenceLabel, 0, 3);
            this.timeParamsLabelsTableLayoutPanel.Controls.Add(this.soundlessSpeechLabel, 0, 4);
            this.timeParamsLabelsTableLayoutPanel.Controls.Add(this.soundSpeechLabel, 0, 5);
            this.timeParamsLabelsTableLayoutPanel.Controls.Add(this.musicLabel, 0, 6);
            this.timeParamsLabelsTableLayoutPanel.Controls.Add(this.volumeValueLabel, 1, 0);
            this.timeParamsLabelsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeParamsLabelsTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.timeParamsLabelsTableLayoutPanel.Name = "timeParamsLabelsTableLayoutPanel";
            this.timeParamsLabelsTableLayoutPanel.RowCount = 7;
            this.timeParamsLabelsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.timeParamsLabelsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.timeParamsLabelsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.timeParamsLabelsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.timeParamsLabelsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.timeParamsLabelsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.timeParamsLabelsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.timeParamsLabelsTableLayoutPanel.Size = new System.Drawing.Size(256, 377);
            this.timeParamsLabelsTableLayoutPanel.TabIndex = 2;
            // 
            // musicValueLabel
            // 
            this.musicValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.musicValueLabel.AutoSize = true;
            this.musicValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.musicValueLabel.Location = new System.Drawing.Point(182, 339);
            this.musicValueLabel.Name = "musicValueLabel";
            this.musicValueLabel.Size = new System.Drawing.Size(17, 17);
            this.musicValueLabel.TabIndex = 13;
            this.musicValueLabel.Text = "0";
            // 
            // soundSpeechValueLabel
            // 
            this.soundSpeechValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.soundSpeechValueLabel.AutoSize = true;
            this.soundSpeechValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.soundSpeechValueLabel.Location = new System.Drawing.Point(182, 283);
            this.soundSpeechValueLabel.Name = "soundSpeechValueLabel";
            this.soundSpeechValueLabel.Size = new System.Drawing.Size(17, 17);
            this.soundSpeechValueLabel.TabIndex = 12;
            this.soundSpeechValueLabel.Text = "0";
            // 
            // soundlessSpeechValueLabel
            // 
            this.soundlessSpeechValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.soundlessSpeechValueLabel.AutoSize = true;
            this.soundlessSpeechValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.soundlessSpeechValueLabel.Location = new System.Drawing.Point(182, 230);
            this.soundlessSpeechValueLabel.Name = "soundlessSpeechValueLabel";
            this.soundlessSpeechValueLabel.Size = new System.Drawing.Size(17, 17);
            this.soundlessSpeechValueLabel.TabIndex = 11;
            this.soundlessSpeechValueLabel.Text = "0";
            // 
            // silenceValueLabel
            // 
            this.silenceValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.silenceValueLabel.AutoSize = true;
            this.silenceValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.silenceValueLabel.Location = new System.Drawing.Point(182, 177);
            this.silenceValueLabel.Name = "silenceValueLabel";
            this.silenceValueLabel.Size = new System.Drawing.Size(17, 17);
            this.silenceValueLabel.TabIndex = 10;
            this.silenceValueLabel.Text = "0";
            // 
            // zcrValueLabel
            // 
            this.zcrValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.zcrValueLabel.AutoSize = true;
            this.zcrValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zcrValueLabel.Location = new System.Drawing.Point(182, 124);
            this.zcrValueLabel.Name = "zcrValueLabel";
            this.zcrValueLabel.Size = new System.Drawing.Size(17, 17);
            this.zcrValueLabel.TabIndex = 9;
            this.zcrValueLabel.Text = "0";
            // 
            // steValueLabel
            // 
            this.steValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.steValueLabel.AutoSize = true;
            this.steValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.steValueLabel.Location = new System.Drawing.Point(182, 71);
            this.steValueLabel.Name = "steValueLabel";
            this.steValueLabel.Size = new System.Drawing.Size(17, 17);
            this.steValueLabel.TabIndex = 8;
            this.steValueLabel.Text = "0";
            // 
            // volumeLabel
            // 
            this.volumeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.volumeLabel.Location = new System.Drawing.Point(117, 18);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(59, 17);
            this.volumeLabel.TabIndex = 0;
            this.volumeLabel.Text = "Volume:";
            // 
            // steLabel
            // 
            this.steLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.steLabel.AutoSize = true;
            this.steLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.steLabel.Location = new System.Drawing.Point(137, 71);
            this.steLabel.Name = "steLabel";
            this.steLabel.Size = new System.Drawing.Size(39, 17);
            this.steLabel.TabIndex = 1;
            this.steLabel.Text = "STE:";
            // 
            // zcrLabel
            // 
            this.zcrLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.zcrLabel.AutoSize = true;
            this.zcrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zcrLabel.Location = new System.Drawing.Point(136, 124);
            this.zcrLabel.Name = "zcrLabel";
            this.zcrLabel.Size = new System.Drawing.Size(40, 17);
            this.zcrLabel.TabIndex = 2;
            this.zcrLabel.Text = "ZCR:";
            // 
            // silenceLabel
            // 
            this.silenceLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.silenceLabel.AutoSize = true;
            this.silenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.silenceLabel.Location = new System.Drawing.Point(118, 177);
            this.silenceLabel.Name = "silenceLabel";
            this.silenceLabel.Size = new System.Drawing.Size(58, 17);
            this.silenceLabel.TabIndex = 3;
            this.silenceLabel.Text = "Silence:";
            // 
            // soundlessSpeechLabel
            // 
            this.soundlessSpeechLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.soundlessSpeechLabel.AutoSize = true;
            this.soundlessSpeechLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.soundlessSpeechLabel.Location = new System.Drawing.Point(51, 230);
            this.soundlessSpeechLabel.Name = "soundlessSpeechLabel";
            this.soundlessSpeechLabel.Size = new System.Drawing.Size(125, 16);
            this.soundlessSpeechLabel.TabIndex = 4;
            this.soundlessSpeechLabel.Text = "Soundless Speech:";
            // 
            // soundSpeechLabel
            // 
            this.soundSpeechLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.soundSpeechLabel.AutoSize = true;
            this.soundSpeechLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.soundSpeechLabel.Location = new System.Drawing.Point(71, 283);
            this.soundSpeechLabel.Name = "soundSpeechLabel";
            this.soundSpeechLabel.Size = new System.Drawing.Size(105, 17);
            this.soundSpeechLabel.TabIndex = 5;
            this.soundSpeechLabel.Text = "Sound Speech:";
            // 
            // musicLabel
            // 
            this.musicLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.musicLabel.AutoSize = true;
            this.musicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.musicLabel.Location = new System.Drawing.Point(128, 339);
            this.musicLabel.Name = "musicLabel";
            this.musicLabel.Size = new System.Drawing.Size(48, 17);
            this.musicLabel.TabIndex = 6;
            this.musicLabel.Text = "Music:";
            // 
            // volumeValueLabel
            // 
            this.volumeValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.volumeValueLabel.AutoSize = true;
            this.volumeValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.volumeValueLabel.Location = new System.Drawing.Point(182, 18);
            this.volumeValueLabel.Name = "volumeValueLabel";
            this.volumeValueLabel.Size = new System.Drawing.Size(17, 17);
            this.volumeValueLabel.TabIndex = 7;
            this.volumeValueLabel.Text = "0";
            // 
            // timeParamsClipLevelTableLayoutPanel
            // 
            this.timeParamsClipLevelTableLayoutPanel.ColumnCount = 4;
            this.timeParamsClipLevelTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.timeParamsClipLevelTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.timeParamsClipLevelTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.timeParamsClipLevelTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.timeParamsClipLevelTableLayoutPanel.Controls.Add(this.lsterValueLabel, 3, 1);
            this.timeParamsClipLevelTableLayoutPanel.Controls.Add(this.vdrValueLabel, 1, 1);
            this.timeParamsClipLevelTableLayoutPanel.Controls.Add(this.hzcrrValueLabel, 3, 0);
            this.timeParamsClipLevelTableLayoutPanel.Controls.Add(this.vstdLabel, 0, 0);
            this.timeParamsClipLevelTableLayoutPanel.Controls.Add(this.vdrLabel, 0, 1);
            this.timeParamsClipLevelTableLayoutPanel.Controls.Add(this.hzcrrLabel, 2, 0);
            this.timeParamsClipLevelTableLayoutPanel.Controls.Add(this.lsterLabel, 2, 1);
            this.timeParamsClipLevelTableLayoutPanel.Controls.Add(this.vstdValueLabel, 1, 0);
            this.timeParamsClipLevelTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeParamsClipLevelTableLayoutPanel.Location = new System.Drawing.Point(265, 386);
            this.timeParamsClipLevelTableLayoutPanel.Name = "timeParamsClipLevelTableLayoutPanel";
            this.timeParamsClipLevelTableLayoutPanel.RowCount = 2;
            this.timeParamsClipLevelTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.timeParamsClipLevelTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.timeParamsClipLevelTableLayoutPanel.Size = new System.Drawing.Size(1042, 122);
            this.timeParamsClipLevelTableLayoutPanel.TabIndex = 4;
            // 
            // lsterValueLabel
            // 
            this.lsterValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lsterValueLabel.AutoSize = true;
            this.lsterValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lsterValueLabel.Location = new System.Drawing.Point(783, 83);
            this.lsterValueLabel.Name = "lsterValueLabel";
            this.lsterValueLabel.Size = new System.Drawing.Size(17, 17);
            this.lsterValueLabel.TabIndex = 7;
            this.lsterValueLabel.Text = "0";
            // 
            // vdrValueLabel
            // 
            this.vdrValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.vdrValueLabel.AutoSize = true;
            this.vdrValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vdrValueLabel.Location = new System.Drawing.Point(263, 83);
            this.vdrValueLabel.Name = "vdrValueLabel";
            this.vdrValueLabel.Size = new System.Drawing.Size(17, 17);
            this.vdrValueLabel.TabIndex = 6;
            this.vdrValueLabel.Text = "0";
            // 
            // hzcrrValueLabel
            // 
            this.hzcrrValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.hzcrrValueLabel.AutoSize = true;
            this.hzcrrValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hzcrrValueLabel.Location = new System.Drawing.Point(783, 22);
            this.hzcrrValueLabel.Name = "hzcrrValueLabel";
            this.hzcrrValueLabel.Size = new System.Drawing.Size(17, 17);
            this.hzcrrValueLabel.TabIndex = 5;
            this.hzcrrValueLabel.Text = "0";
            // 
            // vstdLabel
            // 
            this.vstdLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.vstdLabel.AutoSize = true;
            this.vstdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vstdLabel.Location = new System.Drawing.Point(208, 22);
            this.vstdLabel.Name = "vstdLabel";
            this.vstdLabel.Size = new System.Drawing.Size(49, 17);
            this.vstdLabel.TabIndex = 0;
            this.vstdLabel.Text = "VSTD:";
            // 
            // vdrLabel
            // 
            this.vdrLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.vdrLabel.AutoSize = true;
            this.vdrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vdrLabel.Location = new System.Drawing.Point(216, 83);
            this.vdrLabel.Name = "vdrLabel";
            this.vdrLabel.Size = new System.Drawing.Size(41, 17);
            this.vdrLabel.TabIndex = 1;
            this.vdrLabel.Text = "VDR:";
            // 
            // hzcrrLabel
            // 
            this.hzcrrLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.hzcrrLabel.AutoSize = true;
            this.hzcrrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hzcrrLabel.Location = new System.Drawing.Point(717, 22);
            this.hzcrrLabel.Name = "hzcrrLabel";
            this.hzcrrLabel.Size = new System.Drawing.Size(60, 17);
            this.hzcrrLabel.TabIndex = 2;
            this.hzcrrLabel.Text = "HZCRR:";
            // 
            // lsterLabel
            // 
            this.lsterLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lsterLabel.AutoSize = true;
            this.lsterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lsterLabel.Location = new System.Drawing.Point(720, 83);
            this.lsterLabel.Name = "lsterLabel";
            this.lsterLabel.Size = new System.Drawing.Size(57, 17);
            this.lsterLabel.TabIndex = 3;
            this.lsterLabel.Text = "LSTER:";
            // 
            // vstdValueLabel
            // 
            this.vstdValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.vstdValueLabel.AutoSize = true;
            this.vstdValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vstdValueLabel.Location = new System.Drawing.Point(263, 22);
            this.vstdValueLabel.Name = "vstdValueLabel";
            this.vstdValueLabel.Size = new System.Drawing.Size(17, 17);
            this.vstdValueLabel.TabIndex = 4;
            this.vstdValueLabel.Text = "0";
            // 
            // fourierTransformTabPage
            // 
            this.fourierTransformTabPage.Controls.Add(this.fourierTransformTableLayoutPanel);
            this.fourierTransformTabPage.Location = new System.Drawing.Point(4, 22);
            this.fourierTransformTabPage.Name = "fourierTransformTabPage";
            this.fourierTransformTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.fourierTransformTabPage.Size = new System.Drawing.Size(1316, 517);
            this.fourierTransformTabPage.TabIndex = 1;
            this.fourierTransformTabPage.Text = "Fourier Transform";
            this.fourierTransformTabPage.UseVisualStyleBackColor = true;
            // 
            // fourierTransformTableLayoutPanel
            // 
            this.fourierTransformTableLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.fourierTransformTableLayoutPanel.ColumnCount = 2;
            this.fourierTransformTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fourierTransformTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fourierTransformTableLayoutPanel.Controls.Add(this.fourierTransformScopePanel, 0, 0);
            this.fourierTransformTableLayoutPanel.Controls.Add(this.fourierFrameTimePanel, 1, 0);
            this.fourierTransformTableLayoutPanel.Controls.Add(this.fourierPlotView, 0, 1);
            this.fourierTransformTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fourierTransformTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.fourierTransformTableLayoutPanel.Name = "fourierTransformTableLayoutPanel";
            this.fourierTransformTableLayoutPanel.RowCount = 2;
            this.fourierTransformTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.fourierTransformTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.fourierTransformTableLayoutPanel.Size = new System.Drawing.Size(1310, 511);
            this.fourierTransformTableLayoutPanel.TabIndex = 12;
            // 
            // fourierTransformScopePanel
            // 
            this.fourierTransformScopePanel.Controls.Add(this.oneFrameRadioButton);
            this.fourierTransformScopePanel.Controls.Add(this.wholeClipRadioButton);
            this.fourierTransformScopePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fourierTransformScopePanel.Location = new System.Drawing.Point(3, 3);
            this.fourierTransformScopePanel.Name = "fourierTransformScopePanel";
            this.fourierTransformScopePanel.Size = new System.Drawing.Size(649, 24);
            this.fourierTransformScopePanel.TabIndex = 12;
            // 
            // oneFrameRadioButton
            // 
            this.oneFrameRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oneFrameRadioButton.AutoSize = true;
            this.oneFrameRadioButton.Location = new System.Drawing.Point(130, 4);
            this.oneFrameRadioButton.Name = "oneFrameRadioButton";
            this.oneFrameRadioButton.Size = new System.Drawing.Size(77, 17);
            this.oneFrameRadioButton.TabIndex = 1;
            this.oneFrameRadioButton.Text = "One Frame";
            this.oneFrameRadioButton.UseVisualStyleBackColor = true;
            this.oneFrameRadioButton.CheckedChanged += new System.EventHandler(this.oneFrameRadioButton_CheckedChanged);
            // 
            // wholeClipRadioButton
            // 
            this.wholeClipRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wholeClipRadioButton.AutoSize = true;
            this.wholeClipRadioButton.Checked = true;
            this.wholeClipRadioButton.Location = new System.Drawing.Point(14, 4);
            this.wholeClipRadioButton.Name = "wholeClipRadioButton";
            this.wholeClipRadioButton.Size = new System.Drawing.Size(76, 17);
            this.wholeClipRadioButton.TabIndex = 0;
            this.wholeClipRadioButton.TabStop = true;
            this.wholeClipRadioButton.Text = "Whole Clip";
            this.wholeClipRadioButton.UseVisualStyleBackColor = true;
            this.wholeClipRadioButton.CheckedChanged += new System.EventHandler(this.wholeClipRadioButton_CheckedChanged);
            // 
            // fourierFrameTimePanel
            // 
            this.fourierFrameTimePanel.Controls.Add(this.frameStartTextBox);
            this.fourierFrameTimePanel.Controls.Add(this.frameStartLabel);
            this.fourierFrameTimePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fourierFrameTimePanel.Location = new System.Drawing.Point(658, 3);
            this.fourierFrameTimePanel.Name = "fourierFrameTimePanel";
            this.fourierFrameTimePanel.Size = new System.Drawing.Size(649, 24);
            this.fourierFrameTimePanel.TabIndex = 13;
            // 
            // frameStartTextBox
            // 
            this.frameStartTextBox.Enabled = false;
            this.frameStartTextBox.Location = new System.Drawing.Point(537, 1);
            this.frameStartTextBox.Name = "frameStartTextBox";
            this.frameStartTextBox.Size = new System.Drawing.Size(100, 20);
            this.frameStartTextBox.TabIndex = 1;
            this.frameStartTextBox.Text = "0";
            this.frameStartTextBox.TextChanged += new System.EventHandler(this.frameStartTextBox_TextChanged);
            // 
            // frameStartLabel
            // 
            this.frameStartLabel.AutoSize = true;
            this.frameStartLabel.Location = new System.Drawing.Point(407, 4);
            this.frameStartLabel.Name = "frameStartLabel";
            this.frameStartLabel.Size = new System.Drawing.Size(124, 13);
            this.frameStartLabel.TabIndex = 0;
            this.frameStartLabel.Text = "Frame Start (in seconds):";
            // 
            // fourierPlotView
            // 
            this.fourierPlotView.BackColor = System.Drawing.Color.White;
            this.fourierTransformTableLayoutPanel.SetColumnSpan(this.fourierPlotView, 2);
            this.fourierPlotView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fourierPlotView.Location = new System.Drawing.Point(3, 33);
            this.fourierPlotView.Name = "fourierPlotView";
            this.fourierPlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.fourierPlotView.Size = new System.Drawing.Size(1304, 475);
            this.fourierPlotView.TabIndex = 14;
            this.fourierPlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.fourierPlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.fourierPlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // spectrumTabPage
            // 
            this.spectrumTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.spectrumTabPage.Controls.Add(this.spectrumTableLayoutPanel);
            this.spectrumTabPage.Location = new System.Drawing.Point(4, 22);
            this.spectrumTabPage.Name = "spectrumTabPage";
            this.spectrumTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.spectrumTabPage.Size = new System.Drawing.Size(1316, 517);
            this.spectrumTabPage.TabIndex = 2;
            this.spectrumTabPage.Text = "Spectrum";
            // 
            // spectrumTableLayoutPanel
            // 
            this.spectrumTableLayoutPanel.CausesValidation = false;
            this.spectrumTableLayoutPanel.ColumnCount = 2;
            this.spectrumTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.spectrumTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.spectrumTableLayoutPanel.Controls.Add(this.spectrogramPlotView, 0, 1);
            this.spectrumTableLayoutPanel.Controls.Add(this.frameOverlappingPanel, 0, 0);
            this.spectrumTableLayoutPanel.Controls.Add(this.frameOverlappingTrackBar, 1, 0);
            this.spectrumTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spectrumTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.spectrumTableLayoutPanel.Name = "spectrumTableLayoutPanel";
            this.spectrumTableLayoutPanel.RowCount = 2;
            this.spectrumTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.spectrumTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.spectrumTableLayoutPanel.Size = new System.Drawing.Size(1310, 511);
            this.spectrumTableLayoutPanel.TabIndex = 0;
            // 
            // spectrogramPlotView
            // 
            this.spectrogramPlotView.BackColor = System.Drawing.Color.White;
            this.spectrumTableLayoutPanel.SetColumnSpan(this.spectrogramPlotView, 2);
            this.spectrogramPlotView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spectrogramPlotView.Location = new System.Drawing.Point(3, 33);
            this.spectrogramPlotView.Name = "spectrogramPlotView";
            this.spectrogramPlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.spectrogramPlotView.Size = new System.Drawing.Size(1304, 475);
            this.spectrogramPlotView.TabIndex = 4;
            this.spectrogramPlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.spectrogramPlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.spectrogramPlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // frameOverlappingPanel
            // 
            this.frameOverlappingPanel.Controls.Add(this.frameOverlappingValueLabel);
            this.frameOverlappingPanel.Controls.Add(this.frameOverlappingLabel);
            this.frameOverlappingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frameOverlappingPanel.Location = new System.Drawing.Point(3, 3);
            this.frameOverlappingPanel.Name = "frameOverlappingPanel";
            this.frameOverlappingPanel.Size = new System.Drawing.Size(125, 24);
            this.frameOverlappingPanel.TabIndex = 0;
            // 
            // frameOverlappingValueLabel
            // 
            this.frameOverlappingValueLabel.AutoSize = true;
            this.frameOverlappingValueLabel.Location = new System.Drawing.Point(100, 4);
            this.frameOverlappingValueLabel.Name = "frameOverlappingValueLabel";
            this.frameOverlappingValueLabel.Size = new System.Drawing.Size(22, 13);
            this.frameOverlappingValueLabel.TabIndex = 1;
            this.frameOverlappingValueLabel.Text = "0.5";
            // 
            // frameOverlappingLabel
            // 
            this.frameOverlappingLabel.AutoSize = true;
            this.frameOverlappingLabel.Location = new System.Drawing.Point(4, 4);
            this.frameOverlappingLabel.Name = "frameOverlappingLabel";
            this.frameOverlappingLabel.Size = new System.Drawing.Size(97, 13);
            this.frameOverlappingLabel.TabIndex = 0;
            this.frameOverlappingLabel.Text = "Frame overlapping:";
            // 
            // frameOverlappingTrackBar
            // 
            this.frameOverlappingTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frameOverlappingTrackBar.LargeChange = 10;
            this.frameOverlappingTrackBar.Location = new System.Drawing.Point(134, 3);
            this.frameOverlappingTrackBar.Maximum = 99;
            this.frameOverlappingTrackBar.Name = "frameOverlappingTrackBar";
            this.frameOverlappingTrackBar.Size = new System.Drawing.Size(1173, 24);
            this.frameOverlappingTrackBar.SmallChange = 5;
            this.frameOverlappingTrackBar.TabIndex = 2;
            this.frameOverlappingTrackBar.Value = 50;
            this.frameOverlappingTrackBar.ValueChanged += new System.EventHandler(this.frameOverlappingTrackBar_ValueChanged);
            // 
            // fundamentalFrequencyTabPage
            // 
            this.fundamentalFrequencyTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.fundamentalFrequencyTabPage.Controls.Add(this.fundamentalFrequencyTableLayoutPanel);
            this.fundamentalFrequencyTabPage.Location = new System.Drawing.Point(4, 22);
            this.fundamentalFrequencyTabPage.Name = "fundamentalFrequencyTabPage";
            this.fundamentalFrequencyTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.fundamentalFrequencyTabPage.Size = new System.Drawing.Size(1316, 517);
            this.fundamentalFrequencyTabPage.TabIndex = 3;
            this.fundamentalFrequencyTabPage.Text = "Fundamental Frequency";
            // 
            // fundamentalFrequencyTableLayoutPanel
            // 
            this.fundamentalFrequencyTableLayoutPanel.ColumnCount = 3;
            this.fundamentalFrequencyTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.fundamentalFrequencyTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.fundamentalFrequencyTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fundamentalFrequencyTableLayoutPanel.Controls.Add(this.frameOverlappingTrackBar2, 1, 0);
            this.fundamentalFrequencyTableLayoutPanel.Controls.Add(this.frameOverlappingPanel2, 0, 0);
            this.fundamentalFrequencyTableLayoutPanel.Controls.Add(this.fundamentalFrequencyValueLabel, 2, 1);
            this.fundamentalFrequencyTableLayoutPanel.Controls.Add(this.fundamentalFrequencyLabel, 0, 1);
            this.fundamentalFrequencyTableLayoutPanel.Controls.Add(this.fundamentalFrequencyPlotView, 0, 2);
            this.fundamentalFrequencyTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fundamentalFrequencyTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.fundamentalFrequencyTableLayoutPanel.Name = "fundamentalFrequencyTableLayoutPanel";
            this.fundamentalFrequencyTableLayoutPanel.RowCount = 3;
            this.fundamentalFrequencyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.fundamentalFrequencyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.fundamentalFrequencyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.fundamentalFrequencyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.fundamentalFrequencyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.fundamentalFrequencyTableLayoutPanel.Size = new System.Drawing.Size(1310, 511);
            this.fundamentalFrequencyTableLayoutPanel.TabIndex = 0;
            // 
            // frameOverlappingTrackBar2
            // 
            this.fundamentalFrequencyTableLayoutPanel.SetColumnSpan(this.frameOverlappingTrackBar2, 2);
            this.frameOverlappingTrackBar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frameOverlappingTrackBar2.LargeChange = 10;
            this.frameOverlappingTrackBar2.Location = new System.Drawing.Point(134, 3);
            this.frameOverlappingTrackBar2.Maximum = 99;
            this.frameOverlappingTrackBar2.Name = "frameOverlappingTrackBar2";
            this.frameOverlappingTrackBar2.Size = new System.Drawing.Size(1173, 24);
            this.frameOverlappingTrackBar2.SmallChange = 5;
            this.frameOverlappingTrackBar2.TabIndex = 19;
            this.frameOverlappingTrackBar2.Value = 50;
            this.frameOverlappingTrackBar2.ValueChanged += new System.EventHandler(this.frameOverlappingTrackBar_ValueChanged);
            // 
            // frameOverlappingPanel2
            // 
            this.frameOverlappingPanel2.Controls.Add(this.frameOverlappingValueLabel2);
            this.frameOverlappingPanel2.Controls.Add(this.frameOverlappingLabel2);
            this.frameOverlappingPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frameOverlappingPanel2.Location = new System.Drawing.Point(3, 3);
            this.frameOverlappingPanel2.Name = "frameOverlappingPanel2";
            this.frameOverlappingPanel2.Size = new System.Drawing.Size(125, 24);
            this.frameOverlappingPanel2.TabIndex = 18;
            // 
            // frameOverlappingValueLabel2
            // 
            this.frameOverlappingValueLabel2.AutoSize = true;
            this.frameOverlappingValueLabel2.Location = new System.Drawing.Point(100, 4);
            this.frameOverlappingValueLabel2.Name = "frameOverlappingValueLabel2";
            this.frameOverlappingValueLabel2.Size = new System.Drawing.Size(22, 13);
            this.frameOverlappingValueLabel2.TabIndex = 1;
            this.frameOverlappingValueLabel2.Text = "0.5";
            // 
            // frameOverlappingLabel2
            // 
            this.frameOverlappingLabel2.AutoSize = true;
            this.frameOverlappingLabel2.Location = new System.Drawing.Point(4, 4);
            this.frameOverlappingLabel2.Name = "frameOverlappingLabel2";
            this.frameOverlappingLabel2.Size = new System.Drawing.Size(97, 13);
            this.frameOverlappingLabel2.TabIndex = 0;
            this.frameOverlappingLabel2.Text = "Frame overlapping:";
            // 
            // fundamentalFrequencyValueLabel
            // 
            this.fundamentalFrequencyValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fundamentalFrequencyValueLabel.AutoSize = true;
            this.fundamentalFrequencyValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fundamentalFrequencyValueLabel.Location = new System.Drawing.Point(658, 36);
            this.fundamentalFrequencyValueLabel.Name = "fundamentalFrequencyValueLabel";
            this.fundamentalFrequencyValueLabel.Size = new System.Drawing.Size(27, 17);
            this.fundamentalFrequencyValueLabel.TabIndex = 17;
            this.fundamentalFrequencyValueLabel.Text = "Hz";
            // 
            // fundamentalFrequencyLabel
            // 
            this.fundamentalFrequencyLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.fundamentalFrequencyLabel.AutoSize = true;
            this.fundamentalFrequencyTableLayoutPanel.SetColumnSpan(this.fundamentalFrequencyLabel, 2);
            this.fundamentalFrequencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fundamentalFrequencyLabel.Location = new System.Drawing.Point(487, 36);
            this.fundamentalFrequencyLabel.Name = "fundamentalFrequencyLabel";
            this.fundamentalFrequencyLabel.Size = new System.Drawing.Size(165, 17);
            this.fundamentalFrequencyLabel.TabIndex = 16;
            this.fundamentalFrequencyLabel.Text = "Fundamental Frequency:";
            // 
            // fundamentalFrequencyPlotView
            // 
            this.fundamentalFrequencyPlotView.BackColor = System.Drawing.Color.White;
            this.fundamentalFrequencyTableLayoutPanel.SetColumnSpan(this.fundamentalFrequencyPlotView, 3);
            this.fundamentalFrequencyPlotView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fundamentalFrequencyPlotView.Location = new System.Drawing.Point(3, 63);
            this.fundamentalFrequencyPlotView.Name = "fundamentalFrequencyPlotView";
            this.fundamentalFrequencyPlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.fundamentalFrequencyPlotView.Size = new System.Drawing.Size(1304, 445);
            this.fundamentalFrequencyPlotView.TabIndex = 20;
            this.fundamentalFrequencyPlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.fundamentalFrequencyPlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.fundamentalFrequencyPlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // frequencyParamsTabPage
            // 
            this.frequencyParamsTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.frequencyParamsTabPage.Controls.Add(this.freqParamsTableLayoutPanel);
            this.frequencyParamsTabPage.Location = new System.Drawing.Point(4, 22);
            this.frequencyParamsTabPage.Name = "frequencyParamsTabPage";
            this.frequencyParamsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.frequencyParamsTabPage.Size = new System.Drawing.Size(1316, 517);
            this.frequencyParamsTabPage.TabIndex = 5;
            this.frequencyParamsTabPage.Text = "Frequency Parameters";
            // 
            // freqParamsTableLayoutPanel
            // 
            this.freqParamsTableLayoutPanel.ColumnCount = 2;
            this.freqParamsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.freqParamsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.freqParamsTableLayoutPanel.Controls.Add(this.bandEndPanel, 1, 0);
            this.freqParamsTableLayoutPanel.Controls.Add(this.bandStartPanel, 0, 0);
            this.freqParamsTableLayoutPanel.Controls.Add(this.freqParamsChartsTableLayoutPanel, 0, 1);
            this.freqParamsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.freqParamsTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.freqParamsTableLayoutPanel.Name = "freqParamsTableLayoutPanel";
            this.freqParamsTableLayoutPanel.RowCount = 2;
            this.freqParamsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.freqParamsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.freqParamsTableLayoutPanel.Size = new System.Drawing.Size(1310, 511);
            this.freqParamsTableLayoutPanel.TabIndex = 7;
            // 
            // bandEndPanel
            // 
            this.bandEndPanel.Controls.Add(this.applyBandButton);
            this.bandEndPanel.Controls.Add(this.bandEndTextBox);
            this.bandEndPanel.Controls.Add(this.bandEndLabel);
            this.bandEndPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bandEndPanel.Location = new System.Drawing.Point(658, 3);
            this.bandEndPanel.Name = "bandEndPanel";
            this.bandEndPanel.Size = new System.Drawing.Size(649, 24);
            this.bandEndPanel.TabIndex = 15;
            // 
            // applyBandButton
            // 
            this.applyBandButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.applyBandButton.Location = new System.Drawing.Point(212, -1);
            this.applyBandButton.Name = "applyBandButton";
            this.applyBandButton.Size = new System.Drawing.Size(86, 24);
            this.applyBandButton.TabIndex = 2;
            this.applyBandButton.Text = "Apply";
            this.applyBandButton.UseVisualStyleBackColor = true;
            this.applyBandButton.Click += new System.EventHandler(this.applyBandButton_Click);
            // 
            // bandEndTextBox
            // 
            this.bandEndTextBox.Location = new System.Drawing.Point(106, 1);
            this.bandEndTextBox.Name = "bandEndTextBox";
            this.bandEndTextBox.Size = new System.Drawing.Size(100, 20);
            this.bandEndTextBox.TabIndex = 1;
            this.bandEndTextBox.Text = "0";
            // 
            // bandEndLabel
            // 
            this.bandEndLabel.AutoSize = true;
            this.bandEndLabel.Location = new System.Drawing.Point(3, 4);
            this.bandEndLabel.Name = "bandEndLabel";
            this.bandEndLabel.Size = new System.Drawing.Size(97, 13);
            this.bandEndLabel.TabIndex = 0;
            this.bandEndLabel.Text = "Band End (in herz):";
            // 
            // bandStartPanel
            // 
            this.bandStartPanel.Controls.Add(this.bandStartTextBox);
            this.bandStartPanel.Controls.Add(this.bandStartLabel);
            this.bandStartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bandStartPanel.Location = new System.Drawing.Point(3, 3);
            this.bandStartPanel.Name = "bandStartPanel";
            this.bandStartPanel.Size = new System.Drawing.Size(649, 24);
            this.bandStartPanel.TabIndex = 14;
            // 
            // bandStartTextBox
            // 
            this.bandStartTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bandStartTextBox.Location = new System.Drawing.Point(537, 1);
            this.bandStartTextBox.Name = "bandStartTextBox";
            this.bandStartTextBox.Size = new System.Drawing.Size(100, 20);
            this.bandStartTextBox.TabIndex = 1;
            this.bandStartTextBox.Text = "0";
            // 
            // bandStartLabel
            // 
            this.bandStartLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bandStartLabel.AutoSize = true;
            this.bandStartLabel.Location = new System.Drawing.Point(431, 4);
            this.bandStartLabel.Name = "bandStartLabel";
            this.bandStartLabel.Size = new System.Drawing.Size(100, 13);
            this.bandStartLabel.TabIndex = 0;
            this.bandStartLabel.Text = "Band Start (in herz):";
            // 
            // freqParamsChartsTableLayoutPanel
            // 
            this.freqParamsChartsTableLayoutPanel.ColumnCount = 2;
            this.freqParamsTableLayoutPanel.SetColumnSpan(this.freqParamsChartsTableLayoutPanel, 2);
            this.freqParamsChartsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.freqParamsChartsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.freqParamsChartsTableLayoutPanel.Controls.Add(this.frequencyParamsChartsTableLayoutPanel, 1, 0);
            this.freqParamsChartsTableLayoutPanel.Controls.Add(this.frequencyParamsLabelsTableLayoutPanel, 0, 0);
            this.freqParamsChartsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.freqParamsChartsTableLayoutPanel.Location = new System.Drawing.Point(3, 33);
            this.freqParamsChartsTableLayoutPanel.Name = "freqParamsChartsTableLayoutPanel";
            this.freqParamsChartsTableLayoutPanel.RowCount = 1;
            this.freqParamsChartsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.freqParamsChartsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 475F));
            this.freqParamsChartsTableLayoutPanel.Size = new System.Drawing.Size(1304, 475);
            this.freqParamsChartsTableLayoutPanel.TabIndex = 6;
            // 
            // frequencyParamsChartsTableLayoutPanel
            // 
            this.frequencyParamsChartsTableLayoutPanel.ColumnCount = 1;
            this.frequencyParamsChartsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.frequencyParamsChartsTableLayoutPanel.Controls.Add(this.bePlotView, 0, 3);
            this.frequencyParamsChartsTableLayoutPanel.Controls.Add(this.freqVolumePlotView, 0, 0);
            this.frequencyParamsChartsTableLayoutPanel.Controls.Add(this.fcPlotView, 0, 1);
            this.frequencyParamsChartsTableLayoutPanel.Controls.Add(this.bwPlotView, 0, 2);
            this.frequencyParamsChartsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frequencyParamsChartsTableLayoutPanel.Location = new System.Drawing.Point(263, 3);
            this.frequencyParamsChartsTableLayoutPanel.Name = "frequencyParamsChartsTableLayoutPanel";
            this.frequencyParamsChartsTableLayoutPanel.RowCount = 4;
            this.frequencyParamsChartsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.frequencyParamsChartsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.frequencyParamsChartsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.frequencyParamsChartsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.frequencyParamsChartsTableLayoutPanel.Size = new System.Drawing.Size(1038, 469);
            this.frequencyParamsChartsTableLayoutPanel.TabIndex = 1;
            // 
            // bePlotView
            // 
            this.bePlotView.BackColor = System.Drawing.Color.White;
            this.bePlotView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bePlotView.Location = new System.Drawing.Point(3, 354);
            this.bePlotView.Name = "bePlotView";
            this.bePlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.bePlotView.Size = new System.Drawing.Size(1032, 112);
            this.bePlotView.TabIndex = 3;
            this.bePlotView.Text = "bePlotView";
            this.bePlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.bePlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.bePlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // freqVolumePlotView
            // 
            this.freqVolumePlotView.BackColor = System.Drawing.Color.White;
            this.freqVolumePlotView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.freqVolumePlotView.Location = new System.Drawing.Point(3, 3);
            this.freqVolumePlotView.Name = "freqVolumePlotView";
            this.freqVolumePlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.freqVolumePlotView.Size = new System.Drawing.Size(1032, 111);
            this.freqVolumePlotView.TabIndex = 0;
            this.freqVolumePlotView.Text = "freqVolumePlotView";
            this.freqVolumePlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.freqVolumePlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.freqVolumePlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // fcPlotView
            // 
            this.fcPlotView.BackColor = System.Drawing.Color.White;
            this.fcPlotView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fcPlotView.Location = new System.Drawing.Point(3, 120);
            this.fcPlotView.Name = "fcPlotView";
            this.fcPlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.fcPlotView.Size = new System.Drawing.Size(1032, 111);
            this.fcPlotView.TabIndex = 1;
            this.fcPlotView.Text = "fcPlotView";
            this.fcPlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.fcPlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.fcPlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // bwPlotView
            // 
            this.bwPlotView.BackColor = System.Drawing.Color.White;
            this.bwPlotView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bwPlotView.Location = new System.Drawing.Point(3, 237);
            this.bwPlotView.Name = "bwPlotView";
            this.bwPlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.bwPlotView.Size = new System.Drawing.Size(1032, 111);
            this.bwPlotView.TabIndex = 2;
            this.bwPlotView.Text = "bwPlotView";
            this.bwPlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.bwPlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.bwPlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // frequencyParamsLabelsTableLayoutPanel
            // 
            this.frequencyParamsLabelsTableLayoutPanel.ColumnCount = 2;
            this.frequencyParamsLabelsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.frequencyParamsLabelsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.frequencyParamsLabelsTableLayoutPanel.Controls.Add(this.beValueLabel, 1, 3);
            this.frequencyParamsLabelsTableLayoutPanel.Controls.Add(this.beLabel, 0, 3);
            this.frequencyParamsLabelsTableLayoutPanel.Controls.Add(this.bwValueLabel, 1, 2);
            this.frequencyParamsLabelsTableLayoutPanel.Controls.Add(this.fcValueLabel, 1, 1);
            this.frequencyParamsLabelsTableLayoutPanel.Controls.Add(this.freqVolumeLabel, 0, 0);
            this.frequencyParamsLabelsTableLayoutPanel.Controls.Add(this.fcLabel, 0, 1);
            this.frequencyParamsLabelsTableLayoutPanel.Controls.Add(this.bwLabel, 0, 2);
            this.frequencyParamsLabelsTableLayoutPanel.Controls.Add(this.freqVolumeValueLabel, 1, 0);
            this.frequencyParamsLabelsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frequencyParamsLabelsTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.frequencyParamsLabelsTableLayoutPanel.Name = "frequencyParamsLabelsTableLayoutPanel";
            this.frequencyParamsLabelsTableLayoutPanel.RowCount = 4;
            this.frequencyParamsLabelsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.frequencyParamsLabelsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.frequencyParamsLabelsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.frequencyParamsLabelsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.frequencyParamsLabelsTableLayoutPanel.Size = new System.Drawing.Size(254, 469);
            this.frequencyParamsLabelsTableLayoutPanel.TabIndex = 2;
            // 
            // beValueLabel
            // 
            this.beValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.beValueLabel.AutoSize = true;
            this.beValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.beValueLabel.Location = new System.Drawing.Point(180, 401);
            this.beValueLabel.Name = "beValueLabel";
            this.beValueLabel.Size = new System.Drawing.Size(17, 17);
            this.beValueLabel.TabIndex = 11;
            this.beValueLabel.Text = "0";
            // 
            // beLabel
            // 
            this.beLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.beLabel.AutoSize = true;
            this.beLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.beLabel.Location = new System.Drawing.Point(48, 401);
            this.beLabel.Name = "beLabel";
            this.beLabel.Size = new System.Drawing.Size(126, 17);
            this.beLabel.TabIndex = 10;
            this.beLabel.Text = "Band Energy (BE):";
            // 
            // bwValueLabel
            // 
            this.bwValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bwValueLabel.AutoSize = true;
            this.bwValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bwValueLabel.Location = new System.Drawing.Point(180, 284);
            this.bwValueLabel.Name = "bwValueLabel";
            this.bwValueLabel.Size = new System.Drawing.Size(17, 17);
            this.bwValueLabel.TabIndex = 9;
            this.bwValueLabel.Text = "0";
            // 
            // fcValueLabel
            // 
            this.fcValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fcValueLabel.AutoSize = true;
            this.fcValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fcValueLabel.Location = new System.Drawing.Point(180, 167);
            this.fcValueLabel.Name = "fcValueLabel";
            this.fcValueLabel.Size = new System.Drawing.Size(17, 17);
            this.fcValueLabel.TabIndex = 8;
            this.fcValueLabel.Text = "0";
            // 
            // freqVolumeLabel
            // 
            this.freqVolumeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.freqVolumeLabel.AutoSize = true;
            this.freqVolumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.freqVolumeLabel.Location = new System.Drawing.Point(115, 50);
            this.freqVolumeLabel.Name = "freqVolumeLabel";
            this.freqVolumeLabel.Size = new System.Drawing.Size(59, 17);
            this.freqVolumeLabel.TabIndex = 0;
            this.freqVolumeLabel.Text = "Volume:";
            // 
            // fcLabel
            // 
            this.fcLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.fcLabel.AutoSize = true;
            this.fcLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fcLabel.Location = new System.Drawing.Point(7, 167);
            this.fcLabel.Name = "fcLabel";
            this.fcLabel.Size = new System.Drawing.Size(167, 17);
            this.fcLabel.TabIndex = 1;
            this.fcLabel.Text = "Frequency Centroid (FC):";
            // 
            // bwLabel
            // 
            this.bwLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bwLabel.AutoSize = true;
            this.bwLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bwLabel.Location = new System.Drawing.Point(3, 284);
            this.bwLabel.Name = "bwLabel";
            this.bwLabel.Size = new System.Drawing.Size(171, 17);
            this.bwLabel.TabIndex = 2;
            this.bwLabel.Text = "Effective Bandwidth (BW):";
            // 
            // freqVolumeValueLabel
            // 
            this.freqVolumeValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.freqVolumeValueLabel.AutoSize = true;
            this.freqVolumeValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.freqVolumeValueLabel.Location = new System.Drawing.Point(180, 50);
            this.freqVolumeValueLabel.Name = "freqVolumeValueLabel";
            this.freqVolumeValueLabel.Size = new System.Drawing.Size(17, 17);
            this.freqVolumeValueLabel.TabIndex = 7;
            this.freqVolumeValueLabel.Text = "0";
            // 
            // recordingPlotView
            // 
            this.recordingPlotView.BackColor = System.Drawing.Color.White;
            this.recordingPlotView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recordingPlotView.Location = new System.Drawing.Point(279, 13);
            this.recordingPlotView.Name = "recordingPlotView";
            this.recordingPlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.mainLayoutPanel.SetRowSpan(this.recordingPlotView, 2);
            this.recordingPlotView.Size = new System.Drawing.Size(1058, 130);
            this.recordingPlotView.TabIndex = 8;
            this.recordingPlotView.Text = "recordingPlotView";
            this.recordingPlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.recordingPlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.recordingPlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.statisticsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silenceToolStripMenuItem,
            this.soundlessSpeechToolStripMenuItem,
            this.soundSpeechToolStripMenuItem,
            this.musicToolStripMenuItem});
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            // 
            // silenceToolStripMenuItem
            // 
            this.silenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displaySilenceToolStripMenuItem,
            this.exportSilenceToolStripMenuItem});
            this.silenceToolStripMenuItem.Name = "silenceToolStripMenuItem";
            this.silenceToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.silenceToolStripMenuItem.Text = "Silence";
            // 
            // displaySilenceToolStripMenuItem
            // 
            this.displaySilenceToolStripMenuItem.Name = "displaySilenceToolStripMenuItem";
            this.displaySilenceToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.displaySilenceToolStripMenuItem.Text = "Display";
            this.displaySilenceToolStripMenuItem.Click += new System.EventHandler(this.displayToolStripMenuItem_Click);
            // 
            // exportSilenceToolStripMenuItem
            // 
            this.exportSilenceToolStripMenuItem.Name = "exportSilenceToolStripMenuItem";
            this.exportSilenceToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exportSilenceToolStripMenuItem.Text = "Export";
            this.exportSilenceToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // soundlessSpeechToolStripMenuItem
            // 
            this.soundlessSpeechToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displaySoundlessToolStripMenuItem,
            this.exportSoundlessToolStripMenuItem});
            this.soundlessSpeechToolStripMenuItem.Name = "soundlessSpeechToolStripMenuItem";
            this.soundlessSpeechToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.soundlessSpeechToolStripMenuItem.Text = "Soundless Speech";
            // 
            // displaySoundlessToolStripMenuItem
            // 
            this.displaySoundlessToolStripMenuItem.Name = "displaySoundlessToolStripMenuItem";
            this.displaySoundlessToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.displaySoundlessToolStripMenuItem.Text = "Display";
            this.displaySoundlessToolStripMenuItem.Click += new System.EventHandler(this.displayToolStripMenuItem_Click);
            // 
            // exportSoundlessToolStripMenuItem
            // 
            this.exportSoundlessToolStripMenuItem.Name = "exportSoundlessToolStripMenuItem";
            this.exportSoundlessToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exportSoundlessToolStripMenuItem.Text = "Export";
            this.exportSoundlessToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // soundSpeechToolStripMenuItem
            // 
            this.soundSpeechToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displaySoundToolStripMenuItem,
            this.exportSoundToolStripMenuItem});
            this.soundSpeechToolStripMenuItem.Name = "soundSpeechToolStripMenuItem";
            this.soundSpeechToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.soundSpeechToolStripMenuItem.Text = "Sound Speech";
            // 
            // displaySoundToolStripMenuItem
            // 
            this.displaySoundToolStripMenuItem.Name = "displaySoundToolStripMenuItem";
            this.displaySoundToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.displaySoundToolStripMenuItem.Text = "Display";
            this.displaySoundToolStripMenuItem.Click += new System.EventHandler(this.displayToolStripMenuItem_Click);
            // 
            // exportSoundToolStripMenuItem
            // 
            this.exportSoundToolStripMenuItem.Name = "exportSoundToolStripMenuItem";
            this.exportSoundToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exportSoundToolStripMenuItem.Text = "Export";
            this.exportSoundToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // musicToolStripMenuItem
            // 
            this.musicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayMusicToolStripMenuItem,
            this.exportMusicToolStripMenuItem});
            this.musicToolStripMenuItem.Name = "musicToolStripMenuItem";
            this.musicToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.musicToolStripMenuItem.Text = "Music";
            // 
            // displayMusicToolStripMenuItem
            // 
            this.displayMusicToolStripMenuItem.Name = "displayMusicToolStripMenuItem";
            this.displayMusicToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.displayMusicToolStripMenuItem.Text = "Display";
            this.displayMusicToolStripMenuItem.Click += new System.EventHandler(this.displayToolStripMenuItem_Click);
            // 
            // exportMusicToolStripMenuItem
            // 
            this.exportMusicToolStripMenuItem.Name = "exportMusicToolStripMenuItem";
            this.exportMusicToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exportMusicToolStripMenuItem.Text = "Export";
            this.exportMusicToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.mainLayoutPanel);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Sound analysis";
            this.mainLayoutPanel.ResumeLayout(false);
            this.mpfGroupBox.ResumeLayout(false);
            this.mpfGroupBox.PerformLayout();
            this.windowTypeGroupBox.ResumeLayout(false);
            this.mainTabControl.ResumeLayout(false);
            this.timeParamsTabPage.ResumeLayout(false);
            this.timeParamsTableLayoutPanel.ResumeLayout(false);
            this.timeParamsChartTableLayoutPanel.ResumeLayout(false);
            this.timeParamsLabelsTableLayoutPanel.ResumeLayout(false);
            this.timeParamsLabelsTableLayoutPanel.PerformLayout();
            this.timeParamsClipLevelTableLayoutPanel.ResumeLayout(false);
            this.timeParamsClipLevelTableLayoutPanel.PerformLayout();
            this.fourierTransformTabPage.ResumeLayout(false);
            this.fourierTransformTableLayoutPanel.ResumeLayout(false);
            this.fourierTransformScopePanel.ResumeLayout(false);
            this.fourierTransformScopePanel.PerformLayout();
            this.fourierFrameTimePanel.ResumeLayout(false);
            this.fourierFrameTimePanel.PerformLayout();
            this.spectrumTabPage.ResumeLayout(false);
            this.spectrumTableLayoutPanel.ResumeLayout(false);
            this.spectrumTableLayoutPanel.PerformLayout();
            this.frameOverlappingPanel.ResumeLayout(false);
            this.frameOverlappingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frameOverlappingTrackBar)).EndInit();
            this.fundamentalFrequencyTabPage.ResumeLayout(false);
            this.fundamentalFrequencyTableLayoutPanel.ResumeLayout(false);
            this.fundamentalFrequencyTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frameOverlappingTrackBar2)).EndInit();
            this.frameOverlappingPanel2.ResumeLayout(false);
            this.frameOverlappingPanel2.PerformLayout();
            this.frequencyParamsTabPage.ResumeLayout(false);
            this.freqParamsTableLayoutPanel.ResumeLayout(false);
            this.bandEndPanel.ResumeLayout(false);
            this.bandEndPanel.PerformLayout();
            this.bandStartPanel.ResumeLayout(false);
            this.bandStartPanel.PerformLayout();
            this.freqParamsChartsTableLayoutPanel.ResumeLayout(false);
            this.frequencyParamsChartsTableLayoutPanel.ResumeLayout(false);
            this.frequencyParamsLabelsTableLayoutPanel.ResumeLayout(false);
            this.frequencyParamsLabelsTableLayoutPanel.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.GroupBox mpfGroupBox;
        private System.Windows.Forms.Button mpfButton;
        private System.Windows.Forms.TextBox mpfTextBox;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displaySilenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportSilenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soundlessSpeechToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soundSpeechToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displaySoundlessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportSoundlessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displaySoundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportSoundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayMusicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportMusicToolStripMenuItem;
        private System.Windows.Forms.GroupBox windowTypeGroupBox;
        private System.Windows.Forms.ComboBox windowTypeComboBox;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage timeParamsTabPage;
        private System.Windows.Forms.TableLayoutPanel timeParamsTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel timeParamsChartTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel timeParamsLabelsTableLayoutPanel;
        private System.Windows.Forms.Label musicValueLabel;
        private System.Windows.Forms.Label soundSpeechValueLabel;
        private System.Windows.Forms.Label soundlessSpeechValueLabel;
        private System.Windows.Forms.Label silenceValueLabel;
        private System.Windows.Forms.Label zcrValueLabel;
        private System.Windows.Forms.Label steValueLabel;
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.Label steLabel;
        private System.Windows.Forms.Label zcrLabel;
        private System.Windows.Forms.Label silenceLabel;
        private System.Windows.Forms.Label soundlessSpeechLabel;
        private System.Windows.Forms.Label soundSpeechLabel;
        private System.Windows.Forms.Label musicLabel;
        private System.Windows.Forms.Label volumeValueLabel;
        private System.Windows.Forms.TableLayoutPanel timeParamsClipLevelTableLayoutPanel;
        private System.Windows.Forms.Label lsterValueLabel;
        private System.Windows.Forms.Label vdrValueLabel;
        private System.Windows.Forms.Label hzcrrValueLabel;
        private System.Windows.Forms.Label vstdLabel;
        private System.Windows.Forms.Label vdrLabel;
        private System.Windows.Forms.Label hzcrrLabel;
        private System.Windows.Forms.Label lsterLabel;
        private System.Windows.Forms.Label vstdValueLabel;
        private System.Windows.Forms.TabPage fourierTransformTabPage;
        private System.Windows.Forms.TableLayoutPanel fourierTransformTableLayoutPanel;
        private System.Windows.Forms.Panel fourierTransformScopePanel;
        private System.Windows.Forms.RadioButton oneFrameRadioButton;
        private System.Windows.Forms.RadioButton wholeClipRadioButton;
        private System.Windows.Forms.Panel fourierFrameTimePanel;
        private System.Windows.Forms.TextBox frameStartTextBox;
        private System.Windows.Forms.Label frameStartLabel;
        private OxyPlot.WindowsForms.PlotView fourierPlotView;
        private System.Windows.Forms.TabPage spectrumTabPage;
        private System.Windows.Forms.TableLayoutPanel spectrumTableLayoutPanel;
        private OxyPlot.WindowsForms.PlotView spectrogramPlotView;
        private System.Windows.Forms.Panel frameOverlappingPanel;
        private System.Windows.Forms.Label frameOverlappingValueLabel;
        private System.Windows.Forms.Label frameOverlappingLabel;
        private System.Windows.Forms.TrackBar frameOverlappingTrackBar;
        private System.Windows.Forms.TabPage fundamentalFrequencyTabPage;
        private System.Windows.Forms.TableLayoutPanel fundamentalFrequencyTableLayoutPanel;
        private System.Windows.Forms.TrackBar frameOverlappingTrackBar2;
        private System.Windows.Forms.Panel frameOverlappingPanel2;
        private System.Windows.Forms.Label frameOverlappingValueLabel2;
        private System.Windows.Forms.Label frameOverlappingLabel2;
        private System.Windows.Forms.Label fundamentalFrequencyValueLabel;
        private System.Windows.Forms.Label fundamentalFrequencyLabel;
        private OxyPlot.WindowsForms.PlotView fundamentalFrequencyPlotView;
        private System.Windows.Forms.TabPage frequencyParamsTabPage;
        private System.Windows.Forms.TableLayoutPanel freqParamsChartsTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel frequencyParamsChartsTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel frequencyParamsLabelsTableLayoutPanel;
        private System.Windows.Forms.Label bwValueLabel;
        private System.Windows.Forms.Label fcValueLabel;
        private System.Windows.Forms.Label freqVolumeLabel;
        private System.Windows.Forms.Label fcLabel;
        private System.Windows.Forms.Label freqVolumeValueLabel;
        private OxyPlot.WindowsForms.PlotView freqVolumePlotView;
        private OxyPlot.WindowsForms.PlotView fcPlotView;
        private OxyPlot.WindowsForms.PlotView bwPlotView;
        private OxyPlot.WindowsForms.PlotView musicPlotView;
        private OxyPlot.WindowsForms.PlotView soundSpeechPlotView;
        private OxyPlot.WindowsForms.PlotView soundlessSpeechPlotView;
        private OxyPlot.WindowsForms.PlotView silencePlotView;
        private OxyPlot.WindowsForms.PlotView zcrPlotView;
        private OxyPlot.WindowsForms.PlotView stePlotView;
        private OxyPlot.WindowsForms.PlotView volumePlotView;
        private OxyPlot.WindowsForms.PlotView recordingPlotView;
        private OxyPlot.WindowsForms.PlotView bePlotView;
        private System.Windows.Forms.Label beValueLabel;
        private System.Windows.Forms.Label beLabel;
        private System.Windows.Forms.Label bwLabel;
        private System.Windows.Forms.TableLayoutPanel freqParamsTableLayoutPanel;
        private System.Windows.Forms.Panel bandEndPanel;
        private System.Windows.Forms.TextBox bandEndTextBox;
        private System.Windows.Forms.Label bandEndLabel;
        private System.Windows.Forms.Panel bandStartPanel;
        private System.Windows.Forms.TextBox bandStartTextBox;
        private System.Windows.Forms.Label bandStartLabel;
        private System.Windows.Forms.Button applyBandButton;
    }
}

