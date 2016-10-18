namespace Memorize
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
            this.pnlWorkArea = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mmDictionary = new System.Windows.Forms.ToolStripMenuItem();
            this.mmDictNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mmDictOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mmWord = new System.Windows.Forms.ToolStripMenuItem();
            this.mmWordAppend = new System.Windows.Forms.ToolStripMenuItem();
            this.mmWordEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mmWordDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lbAppHint = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mmDictList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWorkArea
            // 
            this.pnlWorkArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWorkArea.BackColor = System.Drawing.SystemColors.Control;
            this.pnlWorkArea.Location = new System.Drawing.Point(12, 42);
            this.pnlWorkArea.Name = "pnlWorkArea";
            this.pnlWorkArea.Size = new System.Drawing.Size(371, 220);
            this.pnlWorkArea.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmDictionary,
            this.mmWord});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(395, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // mmDictionary
            // 
            this.mmDictionary.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmDictNew,
            this.mmDictOpen,
            this.mmDictList,
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.mmExit});
            this.mmDictionary.Name = "mmDictionary";
            this.mmDictionary.Size = new System.Drawing.Size(66, 20);
            this.mmDictionary.Text = "Словарь";
            // 
            // mmDictNew
            // 
            this.mmDictNew.Name = "mmDictNew";
            this.mmDictNew.Size = new System.Drawing.Size(180, 22);
            this.mmDictNew.Text = "Новый";
            this.mmDictNew.Click += new System.EventHandler(this.mmDictNew_Click);
            // 
            // mmDictOpen
            // 
            this.mmDictOpen.Name = "mmDictOpen";
            this.mmDictOpen.Size = new System.Drawing.Size(180, 22);
            this.mmDictOpen.Text = "Открыть...";
            this.mmDictOpen.Click += new System.EventHandler(this.mmDictOpen_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // mmExit
            // 
            this.mmExit.Name = "mmExit";
            this.mmExit.Size = new System.Drawing.Size(180, 22);
            this.mmExit.Text = "Выход";
            this.mmExit.Click += new System.EventHandler(this.mmExit_Click);
            // 
            // mmWord
            // 
            this.mmWord.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmWordAppend,
            this.mmWordEdit,
            this.mmWordDelete});
            this.mmWord.Name = "mmWord";
            this.mmWord.Size = new System.Drawing.Size(54, 20);
            this.mmWord.Text = "Слово";
            // 
            // mmWordAppend
            // 
            this.mmWordAppend.Name = "mmWordAppend";
            this.mmWordAppend.Size = new System.Drawing.Size(154, 22);
            this.mmWordAppend.Text = "Добавить";
            this.mmWordAppend.Click += new System.EventHandler(this.mmWordAppend_Click);
            // 
            // mmWordEdit
            // 
            this.mmWordEdit.Name = "mmWordEdit";
            this.mmWordEdit.Size = new System.Drawing.Size(154, 22);
            this.mmWordEdit.Text = "Редактировать";
            this.mmWordEdit.Click += new System.EventHandler(this.mmWordEdit_Click);
            // 
            // mmWordDelete
            // 
            this.mmWordDelete.Name = "mmWordDelete";
            this.mmWordDelete.Size = new System.Drawing.Size(154, 22);
            this.mmWordDelete.Text = "Удалить";
            this.mmWordDelete.Click += new System.EventHandler(this.mmWordDelete_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbAppHint});
            this.statusStrip.Location = new System.Drawing.Point(0, 274);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(395, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // lbAppHint
            // 
            this.lbAppHint.Name = "lbAppHint";
            this.lbAppHint.Size = new System.Drawing.Size(13, 17);
            this.lbAppHint.Text = "0";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Начать изучение";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 6);
            // 
            // mmDictList
            // 
            this.mmDictList.Name = "mmDictList";
            this.mmDictList.Size = new System.Drawing.Size(167, 22);
            this.mmDictList.Text = "Показать список";
            this.mmDictList.Click += new System.EventHandler(this.mmDictList_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 296);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.pnlWorkArea);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Memorize";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlWorkArea;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem mmDictionary;
        private System.Windows.Forms.ToolStripMenuItem mmDictNew;
        private System.Windows.Forms.ToolStripMenuItem mmDictOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mmWord;
        private System.Windows.Forms.ToolStripMenuItem mmWordAppend;
        private System.Windows.Forms.ToolStripMenuItem mmWordEdit;
        private System.Windows.Forms.ToolStripMenuItem mmWordDelete;
        private System.Windows.Forms.ToolStripMenuItem mmExit;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripStatusLabel lbAppHint;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mmDictList;
    }
}

