namespace TNCThemeMaker
{
    partial class Form1
    {
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.leftNumberPicker = new System.Windows.Forms.NumericUpDown();
            this.topNumberPicker = new System.Windows.Forms.NumericUpDown();
            this.locationGroup = new System.Windows.Forms.GroupBox();
            this.leftLabel = new System.Windows.Forms.Label();
            this.topLabel = new System.Windows.Forms.Label();
            this.sizeGroup = new System.Windows.Forms.GroupBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.widthNumberPicker = new System.Windows.Forms.NumericUpDown();
            this.heightNumberPicker = new System.Windows.Forms.NumericUpDown();
            this.selectedImage = new System.Windows.Forms.PictureBox();
            this.selectedImageLabel = new System.Windows.Forms.Label();
            this.forwardButton = new System.Windows.Forms.Button();
            this.backwardsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.currentIndexLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalIndexLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSave = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.leftNumberPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topNumberPicker)).BeginInit();
            this.locationGroup.SuspendLayout();
            this.sizeGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumberPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumberPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(245, 394);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // leftNumberPicker
            // 
            this.leftNumberPicker.Enabled = false;
            this.leftNumberPicker.Location = new System.Drawing.Point(6, 90);
            this.leftNumberPicker.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.leftNumberPicker.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.leftNumberPicker.Name = "leftNumberPicker";
            this.leftNumberPicker.Size = new System.Drawing.Size(120, 20);
            this.leftNumberPicker.TabIndex = 3;
            this.leftNumberPicker.ValueChanged += new System.EventHandler(this.leftNumberPicker_ValueChanged);
            // 
            // topNumberPicker
            // 
            this.topNumberPicker.Enabled = false;
            this.topNumberPicker.Location = new System.Drawing.Point(6, 42);
            this.topNumberPicker.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.topNumberPicker.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.topNumberPicker.Name = "topNumberPicker";
            this.topNumberPicker.Size = new System.Drawing.Size(120, 20);
            this.topNumberPicker.TabIndex = 4;
            this.topNumberPicker.ValueChanged += new System.EventHandler(this.topNumberPicker_ValueChanged);
            // 
            // locationGroup
            // 
            this.locationGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.locationGroup.Controls.Add(this.leftLabel);
            this.locationGroup.Controls.Add(this.topLabel);
            this.locationGroup.Controls.Add(this.topNumberPicker);
            this.locationGroup.Controls.Add(this.leftNumberPicker);
            this.locationGroup.Location = new System.Drawing.Point(159, 272);
            this.locationGroup.Name = "locationGroup";
            this.locationGroup.Size = new System.Drawing.Size(150, 117);
            this.locationGroup.TabIndex = 5;
            this.locationGroup.TabStop = false;
            this.locationGroup.Text = "Location";
            // 
            // leftLabel
            // 
            this.leftLabel.AutoSize = true;
            this.leftLabel.Location = new System.Drawing.Point(6, 74);
            this.leftLabel.Name = "leftLabel";
            this.leftLabel.Size = new System.Drawing.Size(25, 13);
            this.leftLabel.TabIndex = 6;
            this.leftLabel.Text = "Left";
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Location = new System.Drawing.Point(6, 23);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(26, 13);
            this.topLabel.TabIndex = 5;
            this.topLabel.Text = "Top";
            // 
            // sizeGroup
            // 
            this.sizeGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sizeGroup.Controls.Add(this.heightLabel);
            this.sizeGroup.Controls.Add(this.widthLabel);
            this.sizeGroup.Controls.Add(this.widthNumberPicker);
            this.sizeGroup.Controls.Add(this.heightNumberPicker);
            this.sizeGroup.Location = new System.Drawing.Point(3, 272);
            this.sizeGroup.Name = "sizeGroup";
            this.sizeGroup.Size = new System.Drawing.Size(150, 117);
            this.sizeGroup.TabIndex = 7;
            this.sizeGroup.TabStop = false;
            this.sizeGroup.Text = "Size";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(6, 74);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(38, 13);
            this.heightLabel.TabIndex = 6;
            this.heightLabel.Text = "Height";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(6, 23);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(35, 13);
            this.widthLabel.TabIndex = 5;
            this.widthLabel.Text = "Width";
            // 
            // widthNumberPicker
            // 
            this.widthNumberPicker.Enabled = false;
            this.widthNumberPicker.Location = new System.Drawing.Point(6, 42);
            this.widthNumberPicker.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.widthNumberPicker.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.widthNumberPicker.Name = "widthNumberPicker";
            this.widthNumberPicker.Size = new System.Drawing.Size(120, 20);
            this.widthNumberPicker.TabIndex = 4;
            this.widthNumberPicker.ValueChanged += new System.EventHandler(this.widthNumberPicker_ValueChanged);
            // 
            // heightNumberPicker
            // 
            this.heightNumberPicker.Enabled = false;
            this.heightNumberPicker.Location = new System.Drawing.Point(6, 90);
            this.heightNumberPicker.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.heightNumberPicker.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.heightNumberPicker.Name = "heightNumberPicker";
            this.heightNumberPicker.Size = new System.Drawing.Size(120, 20);
            this.heightNumberPicker.TabIndex = 3;
            this.heightNumberPicker.ValueChanged += new System.EventHandler(this.heightNumberPicker_ValueChanged);
            // 
            // selectedImage
            // 
            this.selectedImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedImage.Location = new System.Drawing.Point(3, 3);
            this.selectedImage.Name = "selectedImage";
            this.selectedImage.Size = new System.Drawing.Size(481, 234);
            this.selectedImage.TabIndex = 8;
            this.selectedImage.TabStop = false;
            // 
            // selectedImageLabel
            // 
            this.selectedImageLabel.AutoSize = true;
            this.selectedImageLabel.Location = new System.Drawing.Point(363, 20);
            this.selectedImageLabel.Name = "selectedImageLabel";
            this.selectedImageLabel.Size = new System.Drawing.Size(0, 13);
            this.selectedImageLabel.TabIndex = 10;
            // 
            // forwardButton
            // 
            this.forwardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.forwardButton.Location = new System.Drawing.Point(3, 243);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(96, 23);
            this.forwardButton.TabIndex = 11;
            this.forwardButton.Text = "Forward";
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // backwardsButton
            // 
            this.backwardsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.backwardsButton.Location = new System.Drawing.Point(105, 243);
            this.backwardsButton.Name = "backwardsButton";
            this.backwardsButton.Size = new System.Drawing.Size(96, 23);
            this.backwardsButton.TabIndex = 12;
            this.backwardsButton.Text = "Backwards";
            this.backwardsButton.UseVisualStyleBackColor = true;
            this.backwardsButton.Click += new System.EventHandler(this.backwardsButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Position ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentIndexLabel
            // 
            this.currentIndexLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.currentIndexLabel.AutoSize = true;
            this.currentIndexLabel.Location = new System.Drawing.Point(207, 253);
            this.currentIndexLabel.Name = "currentIndexLabel";
            this.currentIndexLabel.Size = new System.Drawing.Size(13, 13);
            this.currentIndexLabel.TabIndex = 14;
            this.currentIndexLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "/";
            // 
            // totalIndexLabel
            // 
            this.totalIndexLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totalIndexLabel.AutoSize = true;
            this.totalIndexLabel.Location = new System.Drawing.Point(244, 253);
            this.totalIndexLabel.Name = "totalIndexLabel";
            this.totalIndexLabel.Size = new System.Drawing.Size(13, 13);
            this.totalIndexLabel.TabIndex = 16;
            this.totalIndexLabel.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(736, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip";
            // 
            // tsmFile
            // 
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOpen,
            this.tsmSave});
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(37, 20);
            this.tsmFile.Text = "File";
            // 
            // tsmOpen
            // 
            this.tsmOpen.Name = "tsmOpen";
            this.tsmOpen.Size = new System.Drawing.Size(180, 22);
            this.tsmOpen.Text = "Open";
            this.tsmOpen.Click += new System.EventHandler(this.tsmOpen_Click);
            // 
            // tsmSave
            // 
            this.tsmSave.Enabled = false;
            this.tsmSave.Name = "tsmSave";
            this.tsmSave.Size = new System.Drawing.Size(180, 22);
            this.tsmSave.Text = "Save";
            this.tsmSave.Click += new System.EventHandler(this.tsmSave_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.totalIndexLabel);
            this.splitContainer1.Panel2.Controls.Add(this.locationGroup);
            this.splitContainer1.Panel2.Controls.Add(this.forwardButton);
            this.splitContainer1.Panel2.Controls.Add(this.backwardsButton);
            this.splitContainer1.Panel2.Controls.Add(this.selectedImage);
            this.splitContainer1.Panel2.Controls.Add(this.sizeGroup);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.currentIndexLabel);
            this.splitContainer1.Size = new System.Drawing.Size(736, 394);
            this.splitContainer1.SplitterDistance = 245;
            this.splitContainer1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 418);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.selectedImageLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Theme Designer";
            ((System.ComponentModel.ISupportInitialize)(this.leftNumberPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topNumberPicker)).EndInit();
            this.locationGroup.ResumeLayout(false);
            this.locationGroup.PerformLayout();
            this.sizeGroup.ResumeLayout(false);
            this.sizeGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumberPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumberPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.NumericUpDown leftNumberPicker;
        private System.Windows.Forms.NumericUpDown topNumberPicker;
        private System.Windows.Forms.GroupBox locationGroup;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Label leftLabel;
        private System.Windows.Forms.GroupBox sizeGroup;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.NumericUpDown widthNumberPicker;
        private System.Windows.Forms.NumericUpDown heightNumberPicker;
        private System.Windows.Forms.PictureBox selectedImage;
        private System.Windows.Forms.Label selectedImageLabel;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Button backwardsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentIndexLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalIndexLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmFile;
        private System.Windows.Forms.ToolStripMenuItem tsmOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmSave;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

