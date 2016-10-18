namespace Memorize
{
    partial class DictionaryForm
    {
        /// <summary>
        ///Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbDictionaryName = new System.Windows.Forms.Label();
            this.edDictName = new System.Windows.Forms.TextBox();
            this.lbPlace = new System.Windows.Forms.Label();
            this.edDictPath = new System.Windows.Forms.TextBox();
            this.bbShowDir = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlWorkArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWorkArea
            // 
            this.pnlWorkArea.Controls.Add(this.bbShowDir);
            this.pnlWorkArea.Controls.Add(this.edDictPath);
            this.pnlWorkArea.Controls.Add(this.lbPlace);
            this.pnlWorkArea.Controls.Add(this.edDictName);
            this.pnlWorkArea.Controls.Add(this.lbDictionaryName);
            this.pnlWorkArea.Size = new System.Drawing.Size(284, 212);
            // 
            // lbDictionaryName
            // 
            this.lbDictionaryName.AutoSize = true;
            this.lbDictionaryName.Location = new System.Drawing.Point(12, 17);
            this.lbDictionaryName.Name = "lbDictionaryName";
            this.lbDictionaryName.Size = new System.Drawing.Size(128, 13);
            this.lbDictionaryName.TabIndex = 0;
            this.lbDictionaryName.Text = "Наименование словаря";
            // 
            // edDictName
            // 
            this.edDictName.Location = new System.Drawing.Point(15, 33);
            this.edDictName.Name = "edDictName";
            this.edDictName.Size = new System.Drawing.Size(200, 20);
            this.edDictName.TabIndex = 1;
            this.edDictName.TextChanged += new System.EventHandler(this.edDictName_TextChanged);
            // 
            // lbPlace
            // 
            this.lbPlace.AutoSize = true;
            this.lbPlace.Location = new System.Drawing.Point(12, 72);
            this.lbPlace.Name = "lbPlace";
            this.lbPlace.Size = new System.Drawing.Size(90, 13);
            this.lbPlace.TabIndex = 2;
            this.lbPlace.Text = "Созхранить в ....";
            // 
            // edDictPath
            // 
            this.edDictPath.Location = new System.Drawing.Point(15, 88);
            this.edDictPath.Name = "edDictPath";
            this.edDictPath.Size = new System.Drawing.Size(200, 20);
            this.edDictPath.TabIndex = 3;
            // 
            // bbShowDir
            // 
            this.bbShowDir.Enabled = false;
            this.bbShowDir.Location = new System.Drawing.Point(221, 88);
            this.bbShowDir.Name = "bbShowDir";
            this.bbShowDir.Size = new System.Drawing.Size(29, 23);
            this.bbShowDir.TabIndex = 4;
            this.bbShowDir.Text = "...";
            this.bbShowDir.UseVisualStyleBackColor = true;
            this.bbShowDir.Click += new System.EventHandler(this.button1_Click);
            // 
            // DictionaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "DictionaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.pnlWorkArea.ResumeLayout(false);
            this.pnlWorkArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bbShowDir;
        private System.Windows.Forms.TextBox edDictPath;
        private System.Windows.Forms.Label lbPlace;
        private System.Windows.Forms.TextBox edDictName;
        private System.Windows.Forms.Label lbDictionaryName;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}
