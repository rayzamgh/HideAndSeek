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
            this.queryLabel = new System.Windows.Forms.Label();
            this.queryBox = new System.Windows.Forms.TextBox();
            this.graphBrowseButton = new System.Windows.Forms.Button();
            this.hasilLabel = new System.Windows.Forms.Label();
            this.queryBrowseButton = new System.Windows.Forms.Button();
            this.queryPathBox = new System.Windows.Forms.TextBox();
            this.fileSolveButton = new System.Windows.Forms.Button();
            this.inputForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(36, 31);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(159, 26);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Hide and Seek";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // solveButton
            // 
            this.solveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.solveButton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solveButton.Location = new System.Drawing.Point(24, 189);
            this.solveButton.Margin = new System.Windows.Forms.Padding(2);
            this.solveButton.MinimumSize = new System.Drawing.Size(55, 27);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(55, 27);
            this.solveButton.TabIndex = 1;
            this.solveButton.Text = "Cari!";
            this.solveButton.UseVisualStyleBackColor = true;
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(62, 7);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(180, 20);
            this.pathBox.TabIndex = 2;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathLabel.Location = new System.Drawing.Point(7, 6);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(44, 18);
            this.pathLabel.TabIndex = 3;
            this.pathLabel.Text = "Path:";
            // 
            // inputForm
            // 
            this.inputForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputForm.Controls.Add(this.queryPathBox);
            this.inputForm.Controls.Add(this.graphBrowseButton);
            this.inputForm.Controls.Add(this.queryBrowseButton);
            this.inputForm.Controls.Add(this.queryLabel);
            this.inputForm.Controls.Add(this.pathLabel);
            this.inputForm.Controls.Add(this.pathBox);
            this.inputForm.Location = new System.Drawing.Point(41, 68);
            this.inputForm.Name = "inputForm";
            this.inputForm.Size = new System.Drawing.Size(291, 74);
            this.inputForm.TabIndex = 4;
            this.inputForm.Paint += new System.Windows.Forms.PaintEventHandler(this.inputForm_Paint);
            // 
            // queryLabel
            // 
            this.queryLabel.AutoSize = true;
            this.queryLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryLabel.Location = new System.Drawing.Point(7, 47);
            this.queryLabel.Name = "queryLabel";
            this.queryLabel.Size = new System.Drawing.Size(53, 18);
            this.queryLabel.TabIndex = 5;
            this.queryLabel.Text = "Query:";
            // 
            // queryBox
            // 
            this.queryBox.Location = new System.Drawing.Point(119, 154);
            this.queryBox.Name = "queryBox";
            this.queryBox.Size = new System.Drawing.Size(180, 20);
            this.queryBox.TabIndex = 5;
            // 
            // graphBrowseButton
            // 
            this.graphBrowseButton.Location = new System.Drawing.Point(248, 5);
            this.graphBrowseButton.Name = "graphBrowseButton";
            this.graphBrowseButton.Size = new System.Drawing.Size(37, 23);
            this.graphBrowseButton.TabIndex = 4;
            this.graphBrowseButton.Text = "...";
            this.graphBrowseButton.UseVisualStyleBackColor = true;
            // 
            // hasilLabel
            // 
            this.hasilLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hasilLabel.AutoSize = true;
            this.hasilLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasilLabel.Location = new System.Drawing.Point(37, 154);
            this.hasilLabel.Name = "hasilLabel";
            this.hasilLabel.Size = new System.Drawing.Size(65, 24);
            this.hasilLabel.TabIndex = 5;
            this.hasilLabel.Text = "Hasil:";
            // 
            // queryBrowseButton
            // 
            this.queryBrowseButton.Location = new System.Drawing.Point(248, 43);
            this.queryBrowseButton.Name = "queryBrowseButton";
            this.queryBrowseButton.Size = new System.Drawing.Size(37, 23);
            this.queryBrowseButton.TabIndex = 6;
            this.queryBrowseButton.Text = "...";
            this.queryBrowseButton.UseVisualStyleBackColor = true;
            // 
            // queryPathBox
            // 
            this.queryPathBox.Location = new System.Drawing.Point(62, 46);
            this.queryPathBox.Name = "queryPathBox";
            this.queryPathBox.Size = new System.Drawing.Size(180, 20);
            this.queryPathBox.TabIndex = 7;
            // 
            // fileSolveButton
            // 
            this.fileSolveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fileSolveButton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileSolveButton.Location = new System.Drawing.Point(242, 189);
            this.fileSolveButton.Margin = new System.Windows.Forms.Padding(2);
            this.fileSolveButton.MinimumSize = new System.Drawing.Size(55, 27);
            this.fileSolveButton.Name = "fileSolveButton";
            this.fileSolveButton.Size = new System.Drawing.Size(118, 27);
            this.fileSolveButton.TabIndex = 6;
            this.fileSolveButton.Text = "File Solve !";
            this.fileSolveButton.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 248);
            this.Controls.Add(this.fileSolveButton);
            this.Controls.Add(this.hasilLabel);
            this.Controls.Add(this.inputForm);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.queryBox);
            this.Controls.Add(this.solveButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(340, 240);
            this.Name = "Main";
            this.Text = "Main";
            this.inputForm.ResumeLayout(false);
            this.inputForm.PerformLayout();
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
        private System.Windows.Forms.Label queryLabel;
        private System.Windows.Forms.Label hasilLabel;
        private System.Windows.Forms.Button queryBrowseButton;
        private System.Windows.Forms.TextBox queryPathBox;
        private System.Windows.Forms.Button fileSolveButton;
    }
}