namespace ServiceApp
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aNASEHIFEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hAQQINDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xIDMETLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tEXNIKIDESTEKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(181, 117);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(399, 227);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(391, 201);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kartla";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(391, 201);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registrasiya";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(391, 201);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tek istifade";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aNASEHIFEToolStripMenuItem,
            this.hAQQINDAToolStripMenuItem,
            this.xIDMETLERToolStripMenuItem,
            this.tEXNIKIDESTEKToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aNASEHIFEToolStripMenuItem
            // 
            this.aNASEHIFEToolStripMenuItem.Name = "aNASEHIFEToolStripMenuItem";
            this.aNASEHIFEToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.aNASEHIFEToolStripMenuItem.Text = "ANA SEHIFE";
            // 
            // hAQQINDAToolStripMenuItem
            // 
            this.hAQQINDAToolStripMenuItem.Name = "hAQQINDAToolStripMenuItem";
            this.hAQQINDAToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.hAQQINDAToolStripMenuItem.Text = "HAQQINDA";
            // 
            // xIDMETLERToolStripMenuItem
            // 
            this.xIDMETLERToolStripMenuItem.Name = "xIDMETLERToolStripMenuItem";
            this.xIDMETLERToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.xIDMETLERToolStripMenuItem.Text = "XIDMETLER";
            // 
            // tEXNIKIDESTEKToolStripMenuItem
            // 
            this.tEXNIKIDESTEKToolStripMenuItem.Name = "tEXNIKIDESTEKToolStripMenuItem";
            this.tEXNIKIDESTEKToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.tEXNIKIDESTEKToolStripMenuItem.Text = "TEXNIKI DESTEK";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 64);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 29);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aNASEHIFEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hAQQINDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xIDMETLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tEXNIKIDESTEKToolStripMenuItem;
    }
}

