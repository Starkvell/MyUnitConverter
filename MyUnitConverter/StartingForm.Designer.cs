namespace MyUnitConverter
{
    partial class StartingForm
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
            this.MainArea = new System.Windows.Forms.Panel();
            this.StatusBarStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Swap = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.ToUnitPicker = new System.Windows.Forms.ListBox();
            this.FromUnitPicker = new System.Windows.Forms.ListBox();
            this.QuantityPicker = new System.Windows.Forms.ListBox();
            this.MainBoxMenuStrip = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainArea.SuspendLayout();
            this.StatusBarStrip.SuspendLayout();
            this.MainBoxMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainArea
            // 
            this.MainArea.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.MainArea.Controls.Add(this.StatusBarStrip);
            this.MainArea.Controls.Add(this.Swap);
            this.MainArea.Controls.Add(this.Clear);
            this.MainArea.Controls.Add(this.OutputBox);
            this.MainArea.Controls.Add(this.InputBox);
            this.MainArea.Controls.Add(this.ToUnitPicker);
            this.MainArea.Controls.Add(this.FromUnitPicker);
            this.MainArea.Controls.Add(this.QuantityPicker);
            this.MainArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainArea.ForeColor = System.Drawing.SystemColors.Window;
            this.MainArea.Location = new System.Drawing.Point(0, 24);
            this.MainArea.Name = "MainArea";
            this.MainArea.Size = new System.Drawing.Size(538, 244);
            this.MainArea.TabIndex = 0;
            // 
            // StatusBarStrip
            // 
            this.StatusBarStrip.BackColor = System.Drawing.Color.Gray;
            this.StatusBarStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.StatusLabel });
            this.StatusBarStrip.Location = new System.Drawing.Point(187, 222);
            this.StatusBarStrip.Name = "StatusBarStrip";
            this.StatusBarStrip.Size = new System.Drawing.Size(351, 22);
            this.StatusBarStrip.TabIndex = 7;
            this.StatusBarStrip.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(88, 17);
            this.StatusLabel.Text = "Status Message";
            // 
            // Swap
            // 
            this.Swap.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Swap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Swap.Location = new System.Drawing.Point(371, 178);
            this.Swap.Name = "Swap";
            this.Swap.Size = new System.Drawing.Size(155, 32);
            this.Swap.TabIndex = 6;
            this.Swap.Text = "Swap";
            this.Swap.UseVisualStyleBackColor = false;
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Clear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.SystemColors.Window;
            this.Clear.Location = new System.Drawing.Point(198, 178);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(155, 32);
            this.Clear.TabIndex = 5;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            // 
            // OutputBox
            // 
            this.OutputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OutputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.OutputBox.Location = new System.Drawing.Point(371, 152);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(155, 20);
            this.OutputBox.TabIndex = 4;
            // 
            // InputBox
            // 
            this.InputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.InputBox.Location = new System.Drawing.Point(198, 152);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(155, 20);
            this.InputBox.TabIndex = 3;
            this.InputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            // 
            // ToUnitPicker
            // 
            this.ToUnitPicker.BackColor = System.Drawing.Color.Gray;
            this.ToUnitPicker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ToUnitPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToUnitPicker.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ToUnitPicker.FormattingEnabled = true;
            this.ToUnitPicker.ItemHeight = 15;
            this.ToUnitPicker.Location = new System.Drawing.Point(371, 3);
            this.ToUnitPicker.Name = "ToUnitPicker";
            this.ToUnitPicker.Size = new System.Drawing.Size(155, 135);
            this.ToUnitPicker.TabIndex = 2;
            this.ToUnitPicker.SelectedIndexChanged += new System.EventHandler(this.ToUnitPicker_SelectedIndexChanged);
            // 
            // FromUnitPicker
            // 
            this.FromUnitPicker.BackColor = System.Drawing.Color.Gray;
            this.FromUnitPicker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FromUnitPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FromUnitPicker.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FromUnitPicker.FormattingEnabled = true;
            this.FromUnitPicker.ItemHeight = 15;
            this.FromUnitPicker.Location = new System.Drawing.Point(198, 3);
            this.FromUnitPicker.Name = "FromUnitPicker";
            this.FromUnitPicker.Size = new System.Drawing.Size(155, 135);
            this.FromUnitPicker.TabIndex = 1;
            this.FromUnitPicker.SelectedIndexChanged += new System.EventHandler(this.FromUnitPicker_SelectedIndexChanged);
            // 
            // QuantityPicker
            // 
            this.QuantityPicker.BackColor = System.Drawing.Color.Gray;
            this.QuantityPicker.Dock = System.Windows.Forms.DockStyle.Left;
            this.QuantityPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuantityPicker.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.QuantityPicker.FormattingEnabled = true;
            this.QuantityPicker.ItemHeight = 20;
            this.QuantityPicker.Items.AddRange(new object[] { "Length", "Mass", "Speed", "Area", "Energy", "Force" });
            this.QuantityPicker.Location = new System.Drawing.Point(0, 0);
            this.QuantityPicker.Margin = new System.Windows.Forms.Padding(0);
            this.QuantityPicker.Name = "QuantityPicker";
            this.QuantityPicker.Size = new System.Drawing.Size(187, 244);
            this.QuantityPicker.TabIndex = 0;
            this.QuantityPicker.SelectedIndexChanged += new System.EventHandler(this.QuantityPicker_SelectedIndexChanged);
            // 
            // MainBoxMenuStrip
            // 
            this.MainBoxMenuStrip.BackColor = System.Drawing.SystemColors.MenuBar;
            this.MainBoxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.aboutToolStripMenuItem });
            this.MainBoxMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainBoxMenuStrip.Name = "MainBoxMenuStrip";
            this.MainBoxMenuStrip.Size = new System.Drawing.Size(538, 24);
            this.MainBoxMenuStrip.TabIndex = 1;
            this.MainBoxMenuStrip.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // StartingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(538, 268);
            this.Controls.Add(this.MainArea);
            this.Controls.Add(this.MainBoxMenuStrip);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.MainBoxMenuStrip;
            this.MaximizeBox = false;
            this.Name = "StartingForm";
            this.Text = "Конвертер величин";
            this.MainArea.ResumeLayout(false);
            this.MainArea.PerformLayout();
            this.StatusBarStrip.ResumeLayout(false);
            this.StatusBarStrip.PerformLayout();
            this.MainBoxMenuStrip.ResumeLayout(false);
            this.MainBoxMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;

        private System.Windows.Forms.StatusStrip StatusBarStrip;

        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Swap;

        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.TextBox InputBox;

        private System.Windows.Forms.ListBox ToUnitPicker;

        private System.Windows.Forms.ListBox FromUnitPicker;

        private System.Windows.Forms.ListBox QuantityPicker;

        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

        private System.Windows.Forms.MenuStrip MainBoxMenuStrip;

        private System.Windows.Forms.Panel MainArea;

        #endregion
    }
}