namespace ExcelThang
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.trademarkLabel = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolTip_buttons = new System.Windows.Forms.ToolTip(this.components);
            this.dividerPanel = new BottomBorderPanel();
            this.settingsControlsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.openFileButtonPanel = new System.Windows.Forms.Panel();
            this.fileNamePanel = new System.Windows.Forms.Panel();
            this.fileNameDynamic = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Panel();
            this.dividerPanelSettings1 = new System.Windows.Forms.Panel();
            this.barChartButton = new System.Windows.Forms.Panel();
            this.pieChartButton = new System.Windows.Forms.Panel();
            this.areaChartButton = new System.Windows.Forms.Panel();
            this.lineChartButton = new System.Windows.Forms.Panel();
            this.pointChartButton = new System.Windows.Forms.Panel();
            this.dividerPanelSettings2 = new System.Windows.Forms.Panel();
            this.saveChartButton = new System.Windows.Forms.Panel();
            this.createTemplateExcelButton = new System.Windows.Forms.Panel();
            this.userMenuButton = new System.Windows.Forms.Panel();
            this.headerPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.dividerPanel.SuspendLayout();
            this.settingsControlsFlowLayoutPanel.SuspendLayout();
            this.fileNamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.SeaGreen;
            this.headerPanel.Controls.Add(this.appNameLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(784, 100);
            this.headerPanel.TabIndex = 1;
            // 
            // appNameLabel
            // 
            this.appNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appNameLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.appNameLabel.Location = new System.Drawing.Point(0, 0);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(784, 100);
            this.appNameLabel.TabIndex = 0;
            this.appNameLabel.Text = "GraphEx";
            this.appNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.trademarkLabel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 981);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(784, 30);
            this.bottomPanel.TabIndex = 4;
            // 
            // trademarkLabel
            // 
            this.trademarkLabel.BackColor = System.Drawing.Color.Transparent;
            this.trademarkLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trademarkLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.trademarkLabel.Location = new System.Drawing.Point(312, 3);
            this.trademarkLabel.Name = "trademarkLabel";
            this.trademarkLabel.Size = new System.Drawing.Size(160, 24);
            this.trademarkLabel.TabIndex = 19;
            this.trademarkLabel.Text = "Mark Filliger Co.® 2023-2024";
            this.trademarkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 143);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(784, 838);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // toolTip_buttons
            // 
            this.toolTip_buttons.AutomaticDelay = 100;
            this.toolTip_buttons.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.toolTip_buttons.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // dividerPanel
            // 
            this.dividerPanel.BackColor = System.Drawing.Color.Transparent;
            this.dividerPanel.Controls.Add(this.settingsControlsFlowLayoutPanel);
            this.dividerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dividerPanel.Location = new System.Drawing.Point(0, 100);
            this.dividerPanel.Name = "dividerPanel";
            this.dividerPanel.Size = new System.Drawing.Size(784, 37);
            this.dividerPanel.TabIndex = 2;
            // 
            // settingsControlsFlowLayoutPanel
            // 
            this.settingsControlsFlowLayoutPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.settingsControlsFlowLayoutPanel.Controls.Add(this.openFileButtonPanel);
            this.settingsControlsFlowLayoutPanel.Controls.Add(this.fileNamePanel);
            this.settingsControlsFlowLayoutPanel.Controls.Add(this.refreshButton);
            this.settingsControlsFlowLayoutPanel.Controls.Add(this.dividerPanelSettings1);
            this.settingsControlsFlowLayoutPanel.Controls.Add(this.barChartButton);
            this.settingsControlsFlowLayoutPanel.Controls.Add(this.pieChartButton);
            this.settingsControlsFlowLayoutPanel.Controls.Add(this.areaChartButton);
            this.settingsControlsFlowLayoutPanel.Controls.Add(this.lineChartButton);
            this.settingsControlsFlowLayoutPanel.Controls.Add(this.pointChartButton);
            this.settingsControlsFlowLayoutPanel.Controls.Add(this.dividerPanelSettings2);
            this.settingsControlsFlowLayoutPanel.Controls.Add(this.saveChartButton);
            this.settingsControlsFlowLayoutPanel.Controls.Add(this.createTemplateExcelButton);
            this.settingsControlsFlowLayoutPanel.Controls.Add(this.userMenuButton);
            this.settingsControlsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsControlsFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.settingsControlsFlowLayoutPanel.Name = "settingsControlsFlowLayoutPanel";
            this.settingsControlsFlowLayoutPanel.Size = new System.Drawing.Size(784, 36);
            this.settingsControlsFlowLayoutPanel.TabIndex = 3;
            // 
            // openFileButtonPanel
            // 
            this.openFileButtonPanel.BackgroundImage = global::ExcelThang.Properties.Resources.fileIcon;
            this.openFileButtonPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openFileButtonPanel.Location = new System.Drawing.Point(3, 3);
            this.openFileButtonPanel.Name = "openFileButtonPanel";
            this.openFileButtonPanel.Size = new System.Drawing.Size(30, 30);
            this.openFileButtonPanel.TabIndex = 0;
            this.openFileButtonPanel.Tag = "ButtonTag";
            this.openFileButtonPanel.Click += new System.EventHandler(this.openFileButtonPanel_Click);
            // 
            // fileNamePanel
            // 
            this.fileNamePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fileNamePanel.Controls.Add(this.fileNameDynamic);
            this.fileNamePanel.Controls.Add(this.fileNameLabel);
            this.fileNamePanel.Location = new System.Drawing.Point(39, 3);
            this.fileNamePanel.Name = "fileNamePanel";
            this.fileNamePanel.Size = new System.Drawing.Size(221, 30);
            this.fileNamePanel.TabIndex = 1;
            // 
            // fileNameDynamic
            // 
            this.fileNameDynamic.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.fileNameDynamic.Dock = System.Windows.Forms.DockStyle.Left;
            this.fileNameDynamic.Location = new System.Drawing.Point(62, 0);
            this.fileNameDynamic.Name = "fileNameDynamic";
            this.fileNameDynamic.Size = new System.Drawing.Size(159, 30);
            this.fileNameDynamic.TabIndex = 3;
            this.fileNameDynamic.Text = "none for now...";
            this.fileNameDynamic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.fileNameLabel.Location = new System.Drawing.Point(0, 0);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(62, 30);
            this.fileNameLabel.TabIndex = 3;
            this.fileNameLabel.Text = "File Name: ";
            this.fileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // refreshButton
            // 
            this.refreshButton.BackgroundImage = global::ExcelThang.Properties.Resources.iconRefresh;
            this.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshButton.Location = new System.Drawing.Point(266, 3);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(30, 30);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Tag = "ButtonTag";
            this.refreshButton.Click += new System.EventHandler(this.RefreshDataAndChart);
            // 
            // dividerPanelSettings1
            // 
            this.dividerPanelSettings1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dividerPanelSettings1.Location = new System.Drawing.Point(302, 3);
            this.dividerPanelSettings1.Name = "dividerPanelSettings1";
            this.dividerPanelSettings1.Size = new System.Drawing.Size(30, 30);
            this.dividerPanelSettings1.TabIndex = 3;
            this.dividerPanelSettings1.Tag = "";
            // 
            // barChartButton
            // 
            this.barChartButton.BackgroundImage = global::ExcelThang.Properties.Resources.barChartIcon;
            this.barChartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.barChartButton.Location = new System.Drawing.Point(338, 3);
            this.barChartButton.Name = "barChartButton";
            this.barChartButton.Size = new System.Drawing.Size(30, 30);
            this.barChartButton.TabIndex = 4;
            this.barChartButton.Tag = "ButtonTag";
            this.barChartButton.Click += new System.EventHandler(this.barChartButton_Click);
            // 
            // pieChartButton
            // 
            this.pieChartButton.BackgroundImage = global::ExcelThang.Properties.Resources.pieChartIcon;
            this.pieChartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pieChartButton.Location = new System.Drawing.Point(374, 3);
            this.pieChartButton.Name = "pieChartButton";
            this.pieChartButton.Size = new System.Drawing.Size(30, 30);
            this.pieChartButton.TabIndex = 5;
            this.pieChartButton.Tag = "ButtonTag";
            this.pieChartButton.Click += new System.EventHandler(this.pieChartButton_Click);
            // 
            // areaChartButton
            // 
            this.areaChartButton.BackgroundImage = global::ExcelThang.Properties.Resources.areaChartIcon;
            this.areaChartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.areaChartButton.Location = new System.Drawing.Point(410, 3);
            this.areaChartButton.Name = "areaChartButton";
            this.areaChartButton.Size = new System.Drawing.Size(30, 30);
            this.areaChartButton.TabIndex = 6;
            this.areaChartButton.Tag = "ButtonTag";
            this.areaChartButton.Click += new System.EventHandler(this.areaChartButton_Click);
            // 
            // lineChartButton
            // 
            this.lineChartButton.BackgroundImage = global::ExcelThang.Properties.Resources.lineChartIcon;
            this.lineChartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lineChartButton.Location = new System.Drawing.Point(446, 3);
            this.lineChartButton.Name = "lineChartButton";
            this.lineChartButton.Size = new System.Drawing.Size(30, 30);
            this.lineChartButton.TabIndex = 7;
            this.lineChartButton.Tag = "ButtonTag";
            this.lineChartButton.Click += new System.EventHandler(this.lineChartButton_Click);
            // 
            // pointChartButton
            // 
            this.pointChartButton.BackgroundImage = global::ExcelThang.Properties.Resources.pointChartIcon;
            this.pointChartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pointChartButton.Location = new System.Drawing.Point(482, 3);
            this.pointChartButton.Name = "pointChartButton";
            this.pointChartButton.Size = new System.Drawing.Size(30, 30);
            this.pointChartButton.TabIndex = 8;
            this.pointChartButton.Tag = "ButtonTag";
            this.pointChartButton.Click += new System.EventHandler(this.pointChartButton_Click);
            // 
            // dividerPanelSettings2
            // 
            this.dividerPanelSettings2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dividerPanelSettings2.Location = new System.Drawing.Point(518, 3);
            this.dividerPanelSettings2.Name = "dividerPanelSettings2";
            this.dividerPanelSettings2.Size = new System.Drawing.Size(155, 30);
            this.dividerPanelSettings2.TabIndex = 12;
            this.dividerPanelSettings2.Tag = "";
            // 
            // saveChartButton
            // 
            this.saveChartButton.BackgroundImage = global::ExcelThang.Properties.Resources.saveIcon;
            this.saveChartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveChartButton.Location = new System.Drawing.Point(679, 3);
            this.saveChartButton.Name = "saveChartButton";
            this.saveChartButton.Size = new System.Drawing.Size(30, 30);
            this.saveChartButton.TabIndex = 10;
            this.saveChartButton.Tag = "ButtonTag";
            this.saveChartButton.Click += new System.EventHandler(this.SaveAsPNG_Dialog);
            // 
            // createTemplateExcelButton
            // 
            this.createTemplateExcelButton.BackgroundImage = global::ExcelThang.Properties.Resources.createTemplateExcelIcon;
            this.createTemplateExcelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.createTemplateExcelButton.Location = new System.Drawing.Point(715, 3);
            this.createTemplateExcelButton.Name = "createTemplateExcelButton";
            this.createTemplateExcelButton.Size = new System.Drawing.Size(30, 30);
            this.createTemplateExcelButton.TabIndex = 9;
            this.createTemplateExcelButton.Tag = "ButtonTag";
            this.createTemplateExcelButton.Click += new System.EventHandler(this.createTemplateExcelButton_Click);
            // 
            // userMenuButton
            // 
            this.userMenuButton.BackgroundImage = global::ExcelThang.Properties.Resources.menuIcon;
            this.userMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userMenuButton.Location = new System.Drawing.Point(751, 3);
            this.userMenuButton.Name = "userMenuButton";
            this.userMenuButton.Size = new System.Drawing.Size(30, 30);
            this.userMenuButton.TabIndex = 11;
            this.userMenuButton.Tag = "ButtonTag";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 1011);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.dividerPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GraphEx";
            this.headerPanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.dividerPanel.ResumeLayout(false);
            this.settingsControlsFlowLayoutPanel.ResumeLayout(false);
            this.fileNamePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label appNameLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private BottomBorderPanel dividerPanel;
        private System.Windows.Forms.FlowLayoutPanel settingsControlsFlowLayoutPanel;
        private System.Windows.Forms.Panel openFileButtonPanel;
        private System.Windows.Forms.Panel fileNamePanel;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label fileNameDynamic;
        private System.Windows.Forms.Panel refreshButton;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel dividerPanelSettings1;
        private System.Windows.Forms.Panel barChartButton;
        private System.Windows.Forms.Panel pieChartButton;
        private System.Windows.Forms.Panel areaChartButton;
        private System.Windows.Forms.Panel lineChartButton;
        private System.Windows.Forms.Panel pointChartButton;
        private System.Windows.Forms.Panel createTemplateExcelButton;
        private System.Windows.Forms.Panel saveChartButton;
        private System.Windows.Forms.Panel userMenuButton;
        private System.Windows.Forms.Panel dividerPanelSettings2;
        private System.Windows.Forms.Label trademarkLabel;
        private System.Windows.Forms.ToolTip toolTip_buttons;
    }
}

