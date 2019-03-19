namespace Hide_and_Seek
{
    partial class Main
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.solveButton = new System.Windows.Forms.Button();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.inputForm = new System.Windows.Forms.Panel();
            this.queryPathBox = new System.Windows.Forms.TextBox();
            this.graphBrowseButton = new System.Windows.Forms.Button();
            this.queryBrowseButton = new System.Windows.Forms.Button();
            this.queryPathLabel = new System.Windows.Forms.Label();
            this.queryBox = new System.Windows.Forms.TextBox();
            this.hasilLabel = new System.Windows.Forms.Label();
            this.nextQueryButton = new System.Windows.Forms.Button();
            this.queryLabel = new System.Windows.Forms.Label();
            this.queryPanel = new System.Windows.Forms.Panel();
            this.inputForm.SuspendLayout();
            this.queryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(16, 21);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(235, 37);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Hide and Seek";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // solveButton
            // 
            this.solveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.solveButton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solveButton.Location = new System.Drawing.Point(20, 409);
            this.solveButton.MinimumSize = new System.Drawing.Size(82, 42);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(82, 42);
            this.solveButton.TabIndex = 1;
            this.solveButton.Text = "Cari!";
            this.solveButton.UseVisualStyleBackColor = true;
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(160, 12);
            this.pathBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(268, 26);
            this.pathBox.TabIndex = 2;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathLabel.Location = new System.Drawing.Point(10, 9);
            this.pathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(69, 27);
            this.pathLabel.TabIndex = 3;
            this.pathLabel.Text = "Path:";
            // 
            // inputForm
            // 
            this.inputForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputForm.Controls.Add(this.queryPathBox);
            this.inputForm.Controls.Add(this.graphBrowseButton);
            this.inputForm.Controls.Add(this.queryBrowseButton);
            this.inputForm.Controls.Add(this.queryPathLabel);
            this.inputForm.Controls.Add(this.pathLabel);
            this.inputForm.Controls.Add(this.pathBox);
            this.inputForm.Location = new System.Drawing.Point(19, 63);
            this.inputForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputForm.Name = "inputForm";
            this.inputForm.Size = new System.Drawing.Size(521, 114);
            this.inputForm.TabIndex = 4;
            // 
            // queryPathBox
            // 
            this.queryPathBox.Location = new System.Drawing.Point(160, 72);
            this.queryPathBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.queryPathBox.Name = "queryPathBox";
            this.queryPathBox.Size = new System.Drawing.Size(268, 26);
            this.queryPathBox.TabIndex = 7;
            // 
            // graphBrowseButton
            // 
            this.graphBrowseButton.Location = new System.Drawing.Point(439, 9);
            this.graphBrowseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.graphBrowseButton.Name = "graphBrowseButton";
            this.graphBrowseButton.Size = new System.Drawing.Size(56, 35);
            this.graphBrowseButton.TabIndex = 4;
            this.graphBrowseButton.Text = "...";
            this.graphBrowseButton.UseVisualStyleBackColor = true;
            // 
            // queryBrowseButton
            // 
            this.queryBrowseButton.Location = new System.Drawing.Point(439, 67);
            this.queryBrowseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.queryBrowseButton.Name = "queryBrowseButton";
            this.queryBrowseButton.Size = new System.Drawing.Size(56, 35);
            this.queryBrowseButton.TabIndex = 6;
            this.queryBrowseButton.Text = "...";
            this.queryBrowseButton.UseVisualStyleBackColor = true;
            // 
            // queryPathLabel
            // 
            this.queryPathLabel.AutoSize = true;
            this.queryPathLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryPathLabel.Location = new System.Drawing.Point(10, 72);
            this.queryPathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.queryPathLabel.Name = "queryPathLabel";
            this.queryPathLabel.Size = new System.Drawing.Size(142, 27);
            this.queryPathLabel.TabIndex = 5;
            this.queryPathLabel.Text = "Query Path:";
            // 
            // queryBox
            // 
            this.queryBox.Location = new System.Drawing.Point(17, 54);
            this.queryBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.queryBox.Name = "queryBox";
            this.queryBox.Size = new System.Drawing.Size(180, 26);
            this.queryBox.TabIndex = 5;
            // 
            // hasilLabel
            // 
            this.hasilLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hasilLabel.AutoSize = true;
            this.hasilLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasilLabel.Location = new System.Drawing.Point(16, 297);
            this.hasilLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hasilLabel.Name = "hasilLabel";
            this.hasilLabel.Size = new System.Drawing.Size(105, 37);
            this.hasilLabel.TabIndex = 5;
            this.hasilLabel.Text = "Hasil:";
            // 
            // nextQueryButton
            // 
            this.nextQueryButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nextQueryButton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextQueryButton.Location = new System.Drawing.Point(20, 352);
            this.nextQueryButton.MinimumSize = new System.Drawing.Size(82, 42);
            this.nextQueryButton.Name = "nextQueryButton";
            this.nextQueryButton.Size = new System.Drawing.Size(177, 42);
            this.nextQueryButton.TabIndex = 6;
            this.nextQueryButton.Text = "Next Query";
            this.nextQueryButton.UseVisualStyleBackColor = true;
            // 
            // queryLabel
            // 
            this.queryLabel.AutoSize = true;
            this.queryLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryLabel.Location = new System.Drawing.Point(11, 13);
            this.queryLabel.Name = "queryLabel";
            this.queryLabel.Size = new System.Drawing.Size(96, 33);
            this.queryLabel.TabIndex = 7;
            this.queryLabel.Text = "Query";
            // 
            // queryPanel
            // 
            this.queryPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.queryPanel.Controls.Add(this.queryBox);
            this.queryPanel.Controls.Add(this.queryLabel);
            this.queryPanel.Location = new System.Drawing.Point(19, 190);
            this.queryPanel.Name = "queryPanel";
            this.queryPanel.Size = new System.Drawing.Size(213, 100);
            this.queryPanel.TabIndex = 8;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 464);
            this.Controls.Add(this.queryPanel);
            this.Controls.Add(this.nextQueryButton);
            this.Controls.Add(this.hasilLabel);
            this.Controls.Add(this.inputForm);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.solveButton);
            this.MinimumSize = new System.Drawing.Size(499, 339);
            this.Name = "Main";
            this.Text = "Main";
            this.inputForm.ResumeLayout(false);
            this.inputForm.PerformLayout();
            this.queryPanel.ResumeLayout(false);
            this.queryPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Panel inputForm;
        private System.Windows.Forms.Button graphBrowseButton;
        private System.Windows.Forms.TextBox queryBox;
        private System.Windows.Forms.Label queryPathLabel;
        private System.Windows.Forms.Label hasilLabel;
        private System.Windows.Forms.Button queryBrowseButton;
        private System.Windows.Forms.TextBox queryPathBox;
        private System.Windows.Forms.Button nextQueryButton;
        private System.Windows.Forms.Label queryLabel;
        private System.Windows.Forms.Panel queryPanel;
    }
}