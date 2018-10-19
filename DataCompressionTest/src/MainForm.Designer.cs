namespace DataCompressionTest
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNewSize = new System.Windows.Forms.Label();
            this.labelOriginalSize = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxAlgorithmType = new System.Windows.Forms.ComboBox();
            this.buttonOutputDirectory = new System.Windows.Forms.Button();
            this.textBoxDirectoryPath = new System.Windows.Forms.TextBox();
            this.buttonInputFile = new System.Windows.Forms.Button();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.buttonCode = new System.Windows.Forms.Button();
            this.textBoxNewSize = new System.Windows.Forms.TextBox();
            this.textBoxOriginalSize = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNewSize
            // 
            this.labelNewSize.AutoSize = true;
            this.labelNewSize.Location = new System.Drawing.Point(366, 127);
            this.labelNewSize.Name = "labelNewSize";
            this.labelNewSize.Size = new System.Drawing.Size(53, 13);
            this.labelNewSize.TabIndex = 154;
            this.labelNewSize.Text = "New size:";
            // 
            // labelOriginalSize
            // 
            this.labelOriginalSize.AutoSize = true;
            this.labelOriginalSize.Location = new System.Drawing.Point(182, 127);
            this.labelOriginalSize.Name = "labelOriginalSize";
            this.labelOriginalSize.Size = new System.Drawing.Size(66, 13);
            this.labelOriginalSize.TabIndex = 153;
            this.labelOriginalSize.Text = "Original size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 152;
            this.label2.Text = "Algorithm:";
            // 
            // comboBoxAlgorithmType
            // 
            this.comboBoxAlgorithmType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlgorithmType.FormattingEnabled = true;
            this.comboBoxAlgorithmType.Location = new System.Drawing.Point(74, 124);
            this.comboBoxAlgorithmType.Name = "comboBoxAlgorithmType";
            this.comboBoxAlgorithmType.Size = new System.Drawing.Size(74, 21);
            this.comboBoxAlgorithmType.TabIndex = 151;
            // 
            // buttonOutputDirectory
            // 
            this.buttonOutputDirectory.Location = new System.Drawing.Point(451, 78);
            this.buttonOutputDirectory.Name = "buttonOutputDirectory";
            this.buttonOutputDirectory.Size = new System.Drawing.Size(103, 23);
            this.buttonOutputDirectory.TabIndex = 150;
            this.buttonOutputDirectory.Text = "Output Directory";
            this.buttonOutputDirectory.UseVisualStyleBackColor = true;
            this.buttonOutputDirectory.Click += new System.EventHandler(this.buttonOutputDirectory_Click);
            // 
            // textBoxDirectoryPath
            // 
            this.textBoxDirectoryPath.Location = new System.Drawing.Point(12, 81);
            this.textBoxDirectoryPath.Name = "textBoxDirectoryPath";
            this.textBoxDirectoryPath.ReadOnly = true;
            this.textBoxDirectoryPath.Size = new System.Drawing.Size(422, 20);
            this.textBoxDirectoryPath.TabIndex = 149;
            // 
            // buttonInputFile
            // 
            this.buttonInputFile.Location = new System.Drawing.Point(451, 28);
            this.buttonInputFile.Name = "buttonInputFile";
            this.buttonInputFile.Size = new System.Drawing.Size(103, 23);
            this.buttonInputFile.TabIndex = 148;
            this.buttonInputFile.Text = "Input File";
            this.buttonInputFile.UseVisualStyleBackColor = true;
            this.buttonInputFile.Click += new System.EventHandler(this.buttonInputFile_Click);
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(12, 31);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.ReadOnly = true;
            this.textBoxFilePath.Size = new System.Drawing.Size(422, 20);
            this.textBoxFilePath.TabIndex = 147;
            // 
            // buttonDecode
            // 
            this.buttonDecode.Location = new System.Drawing.Point(314, 182);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(75, 23);
            this.buttonDecode.TabIndex = 146;
            this.buttonDecode.Text = "Decode";
            this.buttonDecode.UseVisualStyleBackColor = true;
            this.buttonDecode.Click += new System.EventHandler(this.buttonDecode_Click);
            // 
            // buttonCode
            // 
            this.buttonCode.Location = new System.Drawing.Point(155, 182);
            this.buttonCode.Name = "buttonCode";
            this.buttonCode.Size = new System.Drawing.Size(75, 23);
            this.buttonCode.TabIndex = 145;
            this.buttonCode.Text = "Code";
            this.buttonCode.UseVisualStyleBackColor = true;
            this.buttonCode.Click += new System.EventHandler(this.buttonCode_Click);
            // 
            // textBoxNewSize
            // 
            this.textBoxNewSize.AllowDrop = true;
            this.textBoxNewSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNewSize.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxNewSize.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxNewSize.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNewSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNewSize.Location = new System.Drawing.Point(425, 127);
            this.textBoxNewSize.MaxLength = 15;
            this.textBoxNewSize.Name = "textBoxNewSize";
            this.textBoxNewSize.ReadOnly = true;
            this.textBoxNewSize.Size = new System.Drawing.Size(81, 13);
            this.textBoxNewSize.TabIndex = 156;
            // 
            // textBoxOriginalSize
            // 
            this.textBoxOriginalSize.AllowDrop = true;
            this.textBoxOriginalSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOriginalSize.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxOriginalSize.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxOriginalSize.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxOriginalSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOriginalSize.Location = new System.Drawing.Point(254, 127);
            this.textBoxOriginalSize.MaxLength = 15;
            this.textBoxOriginalSize.Name = "textBoxOriginalSize";
            this.textBoxOriginalSize.ReadOnly = true;
            this.textBoxOriginalSize.Size = new System.Drawing.Size(81, 13);
            this.textBoxOriginalSize.TabIndex = 155;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 225);
            this.Controls.Add(this.textBoxNewSize);
            this.Controls.Add(this.textBoxOriginalSize);
            this.Controls.Add(this.labelNewSize);
            this.Controls.Add(this.labelOriginalSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxAlgorithmType);
            this.Controls.Add(this.buttonOutputDirectory);
            this.Controls.Add(this.textBoxDirectoryPath);
            this.Controls.Add(this.buttonInputFile);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.buttonDecode);
            this.Controls.Add(this.buttonCode);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNewSize;
        private System.Windows.Forms.Label labelOriginalSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxAlgorithmType;
        private System.Windows.Forms.Button buttonOutputDirectory;
        private System.Windows.Forms.TextBox textBoxDirectoryPath;
        private System.Windows.Forms.Button buttonInputFile;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.Button buttonCode;
        private System.Windows.Forms.TextBox textBoxNewSize;
        private System.Windows.Forms.TextBox textBoxOriginalSize;
    }
}

