namespace MSPMTextureTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openFileLabel = new System.Windows.Forms.Label();
            this.openFolderTextBox = new System.Windows.Forms.TextBox();
            this.openFileButton = new System.Windows.Forms.Button();
            this.authorLabel = new System.Windows.Forms.Label();
            this.outfitComboBox = new System.Windows.Forms.ComboBox();
            this.outfitLabel = new System.Windows.Forms.Label();
            this.characterLabel = new System.Windows.Forms.Label();
            this.characterComboBox = new System.Windows.Forms.ComboBox();
            this.fatiguesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileLabel
            // 
            this.openFileLabel.AutoSize = true;
            this.openFileLabel.Location = new System.Drawing.Point(20, 20);
            this.openFileLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.openFileLabel.Name = "openFileLabel";
            this.openFileLabel.Size = new System.Drawing.Size(378, 25);
            this.openFileLabel.TabIndex = 0;
            this.openFileLabel.Text = "Select the MSPM Tool\'s Output Folder";
            // 
            // openFolderTextBox
            // 
            this.openFolderTextBox.Location = new System.Drawing.Point(24, 55);
            this.openFolderTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.openFolderTextBox.Name = "openFolderTextBox";
            this.openFolderTextBox.Size = new System.Drawing.Size(368, 31);
            this.openFolderTextBox.TabIndex = 1;
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(406, 45);
            this.openFileButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(48, 44);
            this.openFileButton.TabIndex = 2;
            this.openFileButton.Text = "...";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(18, 809);
            this.authorLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(523, 25);
            this.authorLabel.TabIndex = 8;
            this.authorLabel.Text = "Created by BobDoleOwndU and edited by Joey35233";
            this.authorLabel.Click += new System.EventHandler(this.authorLabel_Click);
            // 
            // outfitComboBox
            // 
            this.outfitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outfitComboBox.FormattingEnabled = true;
            this.outfitComboBox.Location = new System.Drawing.Point(24, 128);
            this.outfitComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.outfitComboBox.Name = "outfitComboBox";
            this.outfitComboBox.Size = new System.Drawing.Size(763, 33);
            this.outfitComboBox.TabIndex = 14;
            this.outfitComboBox.SelectedIndexChanged += new System.EventHandler(this.outfitComboBox_SelectedIndexChanged);
            // 
            // outfitLabel
            // 
            this.outfitLabel.AutoSize = true;
            this.outfitLabel.Location = new System.Drawing.Point(20, 95);
            this.outfitLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.outfitLabel.Name = "outfitLabel";
            this.outfitLabel.Size = new System.Drawing.Size(130, 25);
            this.outfitLabel.TabIndex = 15;
            this.outfitLabel.Text = "Player Outfit";
            // 
            // characterLabel
            // 
            this.characterLabel.AutoSize = true;
            this.characterLabel.Location = new System.Drawing.Point(20, 172);
            this.characterLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.characterLabel.Name = "characterLabel";
            this.characterLabel.Size = new System.Drawing.Size(173, 25);
            this.characterLabel.TabIndex = 18;
            this.characterLabel.Text = "Player Character";
            // 
            // characterComboBox
            // 
            this.characterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.characterComboBox.FormattingEnabled = true;
            this.characterComboBox.Location = new System.Drawing.Point(24, 206);
            this.characterComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.characterComboBox.Name = "characterComboBox";
            this.characterComboBox.Size = new System.Drawing.Size(763, 33);
            this.characterComboBox.TabIndex = 19;
            this.characterComboBox.SelectedIndexChanged += new System.EventHandler(this.characterComboBox_SelectedIndexChanged);
            // 
            // fatiguesButton
            // 
            this.fatiguesButton.Location = new System.Drawing.Point(334, 634);
            this.fatiguesButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.fatiguesButton.Name = "fatiguesButton";
            this.fatiguesButton.Size = new System.Drawing.Size(174, 44);
            this.fatiguesButton.TabIndex = 21;
            this.fatiguesButton.Text = "Apply Texture";
            this.fatiguesButton.UseVisualStyleBackColor = true;
            this.fatiguesButton.Click += new System.EventHandler(this.fatiguesButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 850);
            this.Controls.Add(this.fatiguesButton);
            this.Controls.Add(this.characterComboBox);
            this.Controls.Add(this.characterLabel);
            this.Controls.Add(this.outfitLabel);
            this.Controls.Add(this.outfitComboBox);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.openFolderTextBox);
            this.Controls.Add(this.openFileLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi Skull Player Mod Texture Tool";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label openFileLabel;
        private System.Windows.Forms.TextBox openFolderTextBox;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.ComboBox outfitComboBox;
        private System.Windows.Forms.Label outfitLabel;
        private System.Windows.Forms.Label characterLabel;
        private System.Windows.Forms.ComboBox characterComboBox;
        private System.Windows.Forms.Button fatiguesButton;
    }
}