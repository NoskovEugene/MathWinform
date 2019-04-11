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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.DrawButton = new System.Windows.Forms.Button();
            this.EndBox = new System.Windows.Forms.TextBox();
            this.StartBox = new System.Windows.Forms.TextBox();
            this.StepBox = new System.Windows.Forms.TextBox();
            this.DXBox = new System.Windows.Forms.TextBox();
            this.XBox = new System.Windows.Forms.TextBox();
            this.FView = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.18817F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.81184F));
            this.tableLayoutPanel1.Controls.Add(this.MainPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.FView, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.0597F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1031, 520);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.DrawButton);
            this.MainPanel.Controls.Add(this.EndBox);
            this.MainPanel.Controls.Add(this.StartBox);
            this.MainPanel.Controls.Add(this.StepBox);
            this.MainPanel.Controls.Add(this.DXBox);
            this.MainPanel.Controls.Add(this.XBox);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanel.Location = new System.Drawing.Point(3, 3);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(264, 170);
            this.MainPanel.TabIndex = 0;
            // 
            // DrawButton
            // 
            this.DrawButton.Location = new System.Drawing.Point(9, 138);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(75, 23);
            this.DrawButton.TabIndex = 1;
            this.DrawButton.Text = "Draw";
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // EndBox
            // 
            this.EndBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EndBox.Location = new System.Drawing.Point(3, 111);
            this.EndBox.Name = "EndBox";
            this.EndBox.Size = new System.Drawing.Size(254, 21);
            this.EndBox.TabIndex = 0;
            this.EndBox.Text = "End value";
            // 
            // StartBox
            // 
            this.StartBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartBox.Location = new System.Drawing.Point(3, 84);
            this.StartBox.Name = "StartBox";
            this.StartBox.Size = new System.Drawing.Size(254, 21);
            this.StartBox.TabIndex = 0;
            this.StartBox.Text = "Start value";
            // 
            // StepBox
            // 
            this.StepBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StepBox.Location = new System.Drawing.Point(3, 57);
            this.StepBox.Name = "StepBox";
            this.StepBox.Size = new System.Drawing.Size(254, 21);
            this.StepBox.TabIndex = 0;
            this.StepBox.Text = "Step";
            // 
            // DXBox
            // 
            this.DXBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DXBox.Location = new System.Drawing.Point(3, 30);
            this.DXBox.Name = "DXBox";
            this.DXBox.Size = new System.Drawing.Size(254, 21);
            this.DXBox.TabIndex = 0;
            this.DXBox.Text = "DX value";
            // 
            // XBox
            // 
            this.XBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.XBox.Location = new System.Drawing.Point(3, 3);
            this.XBox.Name = "XBox";
            this.XBox.Size = new System.Drawing.Size(254, 21);
            this.XBox.TabIndex = 0;
            this.XBox.Text = "Starting x value";
            // 
            // FView
            // 
            chartArea1.Name = "ChartArea1";
            this.FView.ChartAreas.Add(chartArea1);
            this.FView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FView.Location = new System.Drawing.Point(273, 3);
            this.FView.Name = "FView";
            this.FView.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Name = "Series1";
            this.FView.Series.Add(series1);
            this.FView.Size = new System.Drawing.Size(755, 514);
            this.FView.TabIndex = 1;
            this.FView.Text = "chart1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1031, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 544);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TextBox EndBox;
        private System.Windows.Forms.TextBox StartBox;
        private System.Windows.Forms.TextBox StepBox;
        private System.Windows.Forms.TextBox DXBox;
        private System.Windows.Forms.TextBox XBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart FView;
        private System.Windows.Forms.Button DrawButton;
    }
}

