namespace TNC_Theme_Maker
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
            this.themeFile = new System.Windows.Forms.Button();
            this.themeButtonContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // themeFile
            // 
            this.themeFile.Location = new System.Drawing.Point(504, 11);
            this.themeFile.Name = "themeFile";
            this.themeFile.Size = new System.Drawing.Size(75, 23);
            this.themeFile.TabIndex = 0;
            this.themeFile.Text = "Theme File";
            this.themeFile.UseVisualStyleBackColor = true;
            this.themeFile.Click += new System.EventHandler(this.themeFile_Click);
            // 
            // flowLayoutPanel1
            // 
            this.themeButtonContainer.AutoScroll = true;
            this.themeButtonContainer.Location = new System.Drawing.Point(10, 11);
            this.themeButtonContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.themeButtonContainer.Name = "flowLayoutPanel1";
            this.themeButtonContainer.Size = new System.Drawing.Size(489, 376);
            this.themeButtonContainer.TabIndex = 1;
            this.themeButtonContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(620, 11);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(322, 376);
            this.treeView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 586);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.themeButtonContainer);
            this.Controls.Add(this.themeFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button themeFile;
        private System.Windows.Forms.FlowLayoutPanel themeButtonContainer;
        private System.Windows.Forms.TreeView treeView1;
    }
}

