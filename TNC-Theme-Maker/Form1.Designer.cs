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
            this.visibleCheckbox = new System.Windows.Forms.CheckBox();
            this.selectedImageLabel = new System.Windows.Forms.Label();
            this.forwardButton = new System.Windows.Forms.Button();
            this.backwardsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.currentIndexLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalIndexLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.leftNumberPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topNumberPicker)).BeginInit();
            this.locationGroup.SuspendLayout();
            this.sizeGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumberPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumberPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // themeFile
            // 
            this.themeFile.Location = new System.Drawing.Point(12, 11);
            this.themeFile.Name = "themeFile";
            this.themeFile.Size = new System.Drawing.Size(75, 23);
            this.themeFile.TabIndex = 0;
            this.themeFile.Text = "Theme File";
            this.themeFile.UseVisualStyleBackColor = true;
            this.themeFile.Click += new System.EventHandler(this.themeFile_Click);
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(12, 40);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(322, 376);
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
            this.locationGroup.Controls.Add(this.leftLabel);
            this.locationGroup.Controls.Add(this.topLabel);
            this.locationGroup.Controls.Add(this.topNumberPicker);
            this.locationGroup.Controls.Add(this.leftNumberPicker);
            this.locationGroup.Location = new System.Drawing.Point(357, 299);
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
            this.sizeGroup.Controls.Add(this.heightLabel);
            this.sizeGroup.Controls.Add(this.widthLabel);
            this.sizeGroup.Controls.Add(this.widthNumberPicker);
            this.sizeGroup.Controls.Add(this.heightNumberPicker);
            this.sizeGroup.Location = new System.Drawing.Point(534, 299);
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
            this.selectedImage.Location = new System.Drawing.Point(363, 40);
            this.selectedImage.Name = "selectedImage";
            this.selectedImage.Size = new System.Drawing.Size(321, 177);
            this.selectedImage.TabIndex = 8;
            this.selectedImage.TabStop = false;
            // 
            // visibleCheckbox
            // 
            this.visibleCheckbox.AutoSize = true;
            this.visibleCheckbox.Location = new System.Drawing.Point(628, 227);
            this.visibleCheckbox.Name = "visibleCheckbox";
            this.visibleCheckbox.Size = new System.Drawing.Size(56, 17);
            this.visibleCheckbox.TabIndex = 9;
            this.visibleCheckbox.Text = "Visible";
            this.visibleCheckbox.UseVisualStyleBackColor = true;
            this.visibleCheckbox.CheckedChanged += new System.EventHandler(this.visibleCheckbox_CheckedChanged);
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
            this.forwardButton.Location = new System.Drawing.Point(363, 236);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(96, 23);
            this.forwardButton.TabIndex = 11;
            this.forwardButton.Text = "Forward";
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // backwardsButton
            // 
            this.backwardsButton.Location = new System.Drawing.Point(363, 265);
            this.backwardsButton.Name = "backwardsButton";
            this.backwardsButton.Size = new System.Drawing.Size(96, 23);
            this.backwardsButton.TabIndex = 12;
            this.backwardsButton.Text = "Backwards";
            this.backwardsButton.UseVisualStyleBackColor = true;
            this.backwardsButton.Click += new System.EventHandler(this.backwardsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(479, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Position ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentIndexLabel
            // 
            this.currentIndexLabel.AutoSize = true;
            this.currentIndexLabel.Location = new System.Drawing.Point(476, 246);
            this.currentIndexLabel.Name = "currentIndexLabel";
            this.currentIndexLabel.Size = new System.Drawing.Size(13, 13);
            this.currentIndexLabel.TabIndex = 14;
            this.currentIndexLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(495, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "/";
            // 
            // totalIndexLabel
            // 
            this.totalIndexLabel.AutoSize = true;
            this.totalIndexLabel.Location = new System.Drawing.Point(513, 246);
            this.totalIndexLabel.Name = "totalIndexLabel";
            this.totalIndexLabel.Size = new System.Drawing.Size(13, 13);
            this.totalIndexLabel.TabIndex = 16;
            this.totalIndexLabel.Text = "0";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(229, 10);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(105, 23);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Save Theme";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 586);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.totalIndexLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.currentIndexLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backwardsButton);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.selectedImageLabel);
            this.Controls.Add(this.visibleCheckbox);
            this.Controls.Add(this.selectedImage);
            this.Controls.Add(this.sizeGroup);
            this.Controls.Add(this.locationGroup);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.themeFile);
            this.Name = "Form1";
            this.Text = "w";
            ((System.ComponentModel.ISupportInitialize)(this.leftNumberPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topNumberPicker)).EndInit();
            this.locationGroup.ResumeLayout(false);
            this.locationGroup.PerformLayout();
            this.sizeGroup.ResumeLayout(false);
            this.sizeGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumberPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumberPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button themeFile;
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
        private System.Windows.Forms.CheckBox visibleCheckbox;
        private System.Windows.Forms.Label selectedImageLabel;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Button backwardsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentIndexLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalIndexLabel;
        private System.Windows.Forms.Button saveButton;
    }
}

