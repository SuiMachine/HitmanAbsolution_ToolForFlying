namespace Flying47
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.LB_Running = new System.Windows.Forms.Label();
            this.C_Freeze = new System.Windows.Forms.CheckBox();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.KeyPanel = new System.Windows.Forms.Panel();
            this.b_Down_mod = new System.Windows.Forms.CheckBox();
            this.b_Up_mod = new System.Windows.Forms.CheckBox();
            this.b_ToggleKey_mod = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.L_Z = new System.Windows.Forms.Label();
            this.L_Y = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.L_X = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputPanel.SuspendLayout();
            this.KeyPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // LB_Running
            // 
            this.LB_Running.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LB_Running.Dock = System.Windows.Forms.DockStyle.Top;
            this.LB_Running.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Running.ForeColor = System.Drawing.Color.Red;
            this.LB_Running.Location = new System.Drawing.Point(0, 0);
            this.LB_Running.Name = "LB_Running";
            this.LB_Running.Size = new System.Drawing.Size(328, 24);
            this.LB_Running.TabIndex = 1;
            this.LB_Running.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // C_Freeze
            // 
            this.C_Freeze.AutoSize = true;
            this.C_Freeze.Location = new System.Drawing.Point(3, 9);
            this.C_Freeze.Name = "C_Freeze";
            this.C_Freeze.Size = new System.Drawing.Size(59, 17);
            this.C_Freeze.TabIndex = 40;
            this.C_Freeze.Text = "Enable";
            this.C_Freeze.UseVisualStyleBackColor = true;
            this.C_Freeze.CheckedChanged += new System.EventHandler(this.C_KeyMode_CheckedChanged);
            // 
            // InputPanel
            // 
            this.InputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputPanel.Controls.Add(this.KeyPanel);
            this.InputPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InputPanel.Location = new System.Drawing.Point(0, 129);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(328, 90);
            this.InputPanel.TabIndex = 41;
            // 
            // KeyPanel
            // 
            this.KeyPanel.Controls.Add(this.b_Down_mod);
            this.KeyPanel.Controls.Add(this.b_Up_mod);
            this.KeyPanel.Controls.Add(this.b_ToggleKey_mod);
            this.KeyPanel.Controls.Add(this.C_Freeze);
            this.KeyPanel.Location = new System.Drawing.Point(11, 14);
            this.KeyPanel.Name = "KeyPanel";
            this.KeyPanel.Size = new System.Drawing.Size(300, 65);
            this.KeyPanel.TabIndex = 41;
            // 
            // b_Down_mod
            // 
            this.b_Down_mod.Appearance = System.Windows.Forms.Appearance.Button;
            this.b_Down_mod.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.b_Down_mod.Location = new System.Drawing.Point(182, 34);
            this.b_Down_mod.Name = "b_Down_mod";
            this.b_Down_mod.Size = new System.Drawing.Size(86, 24);
            this.b_Down_mod.TabIndex = 43;
            this.b_Down_mod.Text = "Num3";
            this.b_Down_mod.UseVisualStyleBackColor = true;
            this.b_Down_mod.CheckedChanged += new System.EventHandler(this.b_Down_mod_CheckedChanged);
            // 
            // b_Up_mod
            // 
            this.b_Up_mod.Appearance = System.Windows.Forms.Appearance.Button;
            this.b_Up_mod.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.b_Up_mod.Location = new System.Drawing.Point(182, 4);
            this.b_Up_mod.Name = "b_Up_mod";
            this.b_Up_mod.Size = new System.Drawing.Size(86, 24);
            this.b_Up_mod.TabIndex = 42;
            this.b_Up_mod.Text = "Num9";
            this.b_Up_mod.UseVisualStyleBackColor = true;
            this.b_Up_mod.CheckedChanged += new System.EventHandler(this.b_Up_mod_CheckedChanged);
            // 
            // b_ToggleKey_mod
            // 
            this.b_ToggleKey_mod.Appearance = System.Windows.Forms.Appearance.Button;
            this.b_ToggleKey_mod.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.b_ToggleKey_mod.Location = new System.Drawing.Point(76, 4);
            this.b_ToggleKey_mod.Name = "b_ToggleKey_mod";
            this.b_ToggleKey_mod.Size = new System.Drawing.Size(86, 24);
            this.b_ToggleKey_mod.TabIndex = 41;
            this.b_ToggleKey_mod.Text = "F2";
            this.b_ToggleKey_mod.UseVisualStyleBackColor = true;
            this.b_ToggleKey_mod.CheckedChanged += new System.EventHandler(this.B_Key_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 105);
            this.panel1.TabIndex = 42;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel1.Controls.Add(this.L_Z, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.L_Y, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.L_X, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(311, 63);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // L_Z
            // 
            this.L_Z.AutoSize = true;
            this.L_Z.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Z.Location = new System.Drawing.Point(206, 35);
            this.L_Z.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.L_Z.Name = "L_Z";
            this.L_Z.Size = new System.Drawing.Size(47, 13);
            this.L_Z.TabIndex = 6;
            this.L_Z.Text = "#####";
            // 
            // L_Y
            // 
            this.L_Y.AutoSize = true;
            this.L_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Y.Location = new System.Drawing.Point(105, 35);
            this.L_Y.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.L_Y.Name = "L_Y";
            this.L_Y.Size = new System.Drawing.Size(47, 13);
            this.L_Y.TabIndex = 5;
            this.L_Y.Text = "#####";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 1);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label5.Size = new System.Drawing.Size(52, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Z (height)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 1);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label4.Size = new System.Drawing.Size(14, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Y";
            // 
            // L_X
            // 
            this.L_X.AutoSize = true;
            this.L_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_X.Location = new System.Drawing.Point(4, 35);
            this.L_X.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.L_X.Name = "L_X";
            this.L_X.Size = new System.Drawing.Size(47, 13);
            this.L_X.TabIndex = 1;
            this.L_X.Text = "#####";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 1);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label3.Size = new System.Drawing.Size(14, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Current Coordinates:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 219);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InputPanel);
            this.Controls.Add(this.LB_Running);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "NotQuiteAToolForFlyingInHimanAbsolution";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.InputPanel.ResumeLayout(false);
            this.KeyPanel.ResumeLayout(false);
            this.KeyPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label LB_Running;
        private System.Windows.Forms.CheckBox C_Freeze;
        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.Panel KeyPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label L_X;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox b_ToggleKey_mod;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label L_Z;
        private System.Windows.Forms.Label L_Y;
        private System.Windows.Forms.CheckBox b_Down_mod;
        private System.Windows.Forms.CheckBox b_Up_mod;
    }
}

