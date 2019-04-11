namespace WindowsFormsApp1
{
    partial class SetFunction
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TryCalcButtion = new System.Windows.Forms.Button();
            this.Analyzerbutton = new System.Windows.Forms.Button();
            this.PolNotBox = new System.Windows.Forms.TextBox();
            this.FAfterBox = new System.Windows.Forms.TextBox();
            this.FBox = new System.Windows.Forms.TextBox();
            this.Consolebox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Consolebox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.65385F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.34615F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(665, 520);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TryCalcButtion);
            this.panel1.Controls.Add(this.Analyzerbutton);
            this.panel1.Controls.Add(this.PolNotBox);
            this.panel1.Controls.Add(this.FAfterBox);
            this.panel1.Controls.Add(this.FBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 351);
            this.panel1.TabIndex = 0;
            // 
            // TryCalcButtion
            // 
            this.TryCalcButtion.Location = new System.Drawing.Point(84, 84);
            this.TryCalcButtion.Name = "TryCalcButtion";
            this.TryCalcButtion.Size = new System.Drawing.Size(96, 23);
            this.TryCalcButtion.TabIndex = 2;
            this.TryCalcButtion.Text = "Try calculate";
            this.TryCalcButtion.UseVisualStyleBackColor = true;
            // 
            // Analyzerbutton
            // 
            this.Analyzerbutton.Location = new System.Drawing.Point(3, 84);
            this.Analyzerbutton.Name = "Analyzerbutton";
            this.Analyzerbutton.Size = new System.Drawing.Size(75, 23);
            this.Analyzerbutton.TabIndex = 1;
            this.Analyzerbutton.Text = "Analyze";
            this.Analyzerbutton.UseVisualStyleBackColor = true;
            this.Analyzerbutton.Click += new System.EventHandler(this.Analyzerbutton_Click);
            // 
            // PolNotBox
            // 
            this.PolNotBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PolNotBox.Location = new System.Drawing.Point(3, 57);
            this.PolNotBox.Name = "PolNotBox";
            this.PolNotBox.Size = new System.Drawing.Size(653, 21);
            this.PolNotBox.TabIndex = 0;
            this.PolNotBox.Text = "PolishNotation";
            // 
            // FAfterBox
            // 
            this.FAfterBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FAfterBox.Location = new System.Drawing.Point(3, 30);
            this.FAfterBox.Name = "FAfterBox";
            this.FAfterBox.Size = new System.Drawing.Size(653, 21);
            this.FAfterBox.TabIndex = 0;
            this.FAfterBox.Text = "Function after analyze";
            // 
            // FBox
            // 
            this.FBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FBox.Location = new System.Drawing.Point(3, 3);
            this.FBox.Name = "FBox";
            this.FBox.Size = new System.Drawing.Size(653, 21);
            this.FBox.TabIndex = 0;
            this.FBox.Text = "Function";
            // 
            // Consolebox
            // 
            this.Consolebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Consolebox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Consolebox.Location = new System.Drawing.Point(3, 360);
            this.Consolebox.Multiline = true;
            this.Consolebox.Name = "Consolebox";
            this.Consolebox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Consolebox.Size = new System.Drawing.Size(659, 157);
            this.Consolebox.TabIndex = 1;
            this.Consolebox.Text = "Console";
            // 
            // SetFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 520);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SetFunction";
            this.Text = "SetFunction";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Analyzerbutton;
        private System.Windows.Forms.TextBox PolNotBox;
        private System.Windows.Forms.TextBox FAfterBox;
        private System.Windows.Forms.TextBox FBox;
        private System.Windows.Forms.Button TryCalcButtion;
        private System.Windows.Forms.TextBox Consolebox;
    }
}