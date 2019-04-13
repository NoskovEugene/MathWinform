namespace WindowsFormsApp1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFunctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFunctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.FLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.FView = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ConsoleBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SetFunctionButton = new System.Windows.Forms.Button();
            this.DrawButton = new System.Windows.Forms.Button();
            this.EndBox = new System.Windows.Forms.TextBox();
            this.StartBox = new System.Windows.Forms.TextBox();
            this.StepBox = new System.Windows.Forms.TextBox();
            this.DXBox = new System.Windows.Forms.TextBox();
            this.XBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FView)).BeginInit();
            this.panel1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1028, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveFunctionToolStripMenuItem,
            this.openFunctionToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveFunctionToolStripMenuItem
            // 
            this.saveFunctionToolStripMenuItem.Name = "saveFunctionToolStripMenuItem";
            this.saveFunctionToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.saveFunctionToolStripMenuItem.Text = "Save function";
            this.saveFunctionToolStripMenuItem.Click += new System.EventHandler(this.SaveFunctionToolStripMenuItem_Click);
            // 
            // openFunctionToolStripMenuItem
            // 
            this.openFunctionToolStripMenuItem.Name = "openFunctionToolStripMenuItem";
            this.openFunctionToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.openFunctionToolStripMenuItem.Text = "Open function";
            this.openFunctionToolStripMenuItem.Click += new System.EventHandler(this.OpenFunctionToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FLabel,
            this.toolStripDropDownButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 525);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1028, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FLabel
            // 
            this.FLabel.Name = "FLabel";
            this.FLabel.Size = new System.Drawing.Size(53, 17);
            this.FLabel.Text = "Funciton";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 20);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ConsoleBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1028, 501);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.18817F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.81184F));
            this.tableLayoutPanel2.Controls.Add(this.FView, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.0597F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1022, 409);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // FView
            // 
            chartArea3.Name = "ChartArea1";
            this.FView.ChartAreas.Add(chartArea3);
            this.FView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FView.Location = new System.Drawing.Point(270, 3);
            this.FView.Name = "FView";
            this.FView.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Name = "Series1";
            this.FView.Series.Add(series3);
            this.FView.Size = new System.Drawing.Size(749, 403);
            this.FView.TabIndex = 1;
            this.FView.Text = "chart1";
            // 
            // ConsoleBox
            // 
            this.ConsoleBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsoleBox.Location = new System.Drawing.Point(3, 418);
            this.ConsoleBox.Multiline = true;
            this.ConsoleBox.Name = "ConsoleBox";
            this.ConsoleBox.Size = new System.Drawing.Size(1022, 80);
            this.ConsoleBox.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.MainPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 403);
            this.panel1.TabIndex = 2;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.SetFunctionButton);
            this.MainPanel.Controls.Add(this.DrawButton);
            this.MainPanel.Controls.Add(this.EndBox);
            this.MainPanel.Controls.Add(this.StartBox);
            this.MainPanel.Controls.Add(this.StepBox);
            this.MainPanel.Controls.Add(this.DXBox);
            this.MainPanel.Controls.Add(this.XBox);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(261, 168);
            this.MainPanel.TabIndex = 1;
            // 
            // SetFunctionButton
            // 
            this.SetFunctionButton.Location = new System.Drawing.Point(90, 138);
            this.SetFunctionButton.Name = "SetFunctionButton";
            this.SetFunctionButton.Size = new System.Drawing.Size(90, 23);
            this.SetFunctionButton.TabIndex = 1;
            this.SetFunctionButton.Text = "Set Function";
            this.SetFunctionButton.UseVisualStyleBackColor = true;
            this.SetFunctionButton.Click += new System.EventHandler(this.SetFunctionButton_Click);
            // 
            // DrawButton
            // 
            this.DrawButton.Location = new System.Drawing.Point(9, 138);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(75, 23);
            this.DrawButton.TabIndex = 1;
            this.DrawButton.Text = "Draw";
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click_1);
            // 
            // EndBox
            // 
            this.EndBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EndBox.Location = new System.Drawing.Point(3, 111);
            this.EndBox.Name = "EndBox";
            this.EndBox.Size = new System.Drawing.Size(251, 21);
            this.EndBox.TabIndex = 0;
            this.EndBox.Text = "End value";
            // 
            // StartBox
            // 
            this.StartBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartBox.Location = new System.Drawing.Point(3, 84);
            this.StartBox.Name = "StartBox";
            this.StartBox.Size = new System.Drawing.Size(251, 21);
            this.StartBox.TabIndex = 0;
            this.StartBox.Text = "Start value";
            // 
            // StepBox
            // 
            this.StepBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StepBox.Location = new System.Drawing.Point(3, 57);
            this.StepBox.Name = "StepBox";
            this.StepBox.Size = new System.Drawing.Size(251, 21);
            this.StepBox.TabIndex = 0;
            this.StepBox.Text = "Step";
            // 
            // DXBox
            // 
            this.DXBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DXBox.Location = new System.Drawing.Point(3, 30);
            this.DXBox.Name = "DXBox";
            this.DXBox.Size = new System.Drawing.Size(251, 21);
            this.DXBox.TabIndex = 0;
            this.DXBox.Text = "DX value";
            // 
            // XBox
            // 
            this.XBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.XBox.Location = new System.Drawing.Point(3, 3);
            this.XBox.Name = "XBox";
            this.XBox.Size = new System.Drawing.Size(251, 21);
            this.XBox.TabIndex = 0;
            this.XBox.Text = "Starting x value";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 168);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(261, 235);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(253, 209);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Normal mode";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 547);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Main form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel FLabel;
        private System.Windows.Forms.ToolStripMenuItem saveFunctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFunctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart FView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button SetFunctionButton;
        private System.Windows.Forms.Button DrawButton;
        private System.Windows.Forms.TextBox EndBox;
        private System.Windows.Forms.TextBox StartBox;
        private System.Windows.Forms.TextBox StepBox;
        private System.Windows.Forms.TextBox DXBox;
        private System.Windows.Forms.TextBox XBox;
        private System.Windows.Forms.TextBox ConsoleBox;
    }
}

