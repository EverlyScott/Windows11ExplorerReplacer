
namespace Windows11ExplorerReplacer
{
    partial class form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.installedText = new System.Windows.Forms.Label();
            this.install = new System.Windows.Forms.Button();
            this.uninstall = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // installedText
            // 
            this.installedText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.installedText.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.installedText.Location = new System.Drawing.Point(12, 9);
            this.installedText.Name = "installedText";
            this.installedText.Size = new System.Drawing.Size(776, 44);
            this.installedText.TabIndex = 0;
            this.installedText.Text = "Installed";
            this.installedText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // install
            // 
            this.install.Location = new System.Drawing.Point(344, 112);
            this.install.Name = "install";
            this.install.Size = new System.Drawing.Size(113, 23);
            this.install.TabIndex = 1;
            this.install.Text = "Install";
            this.install.UseVisualStyleBackColor = true;
            this.install.Click += new System.EventHandler(this.install_Click);
            // 
            // uninstall
            // 
            this.uninstall.Location = new System.Drawing.Point(344, 141);
            this.uninstall.Name = "uninstall";
            this.uninstall.Size = new System.Drawing.Size(113, 23);
            this.uninstall.TabIndex = 2;
            this.uninstall.Text = "Uninstall";
            this.uninstall.UseVisualStyleBackColor = true;
            this.uninstall.Click += new System.EventHandler(this.uninstall_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "(do not run this on windows 10 as it could break something)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "(I am not responsible if this breaks your computer)";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uninstall);
            this.Controls.Add(this.install);
            this.Controls.Add(this.installedText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Windows 11 Explorer Replacer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label installedText;
        private System.Windows.Forms.Button install;
        private System.Windows.Forms.Button uninstall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

