namespace Memorize
{
    partial class WordListForm
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
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.pnlWorkArea = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeaderWord = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlInfo.SuspendLayout();
            this.pnlWorkArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlInfo.Controls.Add(this.label1);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(284, 28);
            this.pnlInfo.TabIndex = 1;
            // 
            // pnlWorkArea
            // 
            this.pnlWorkArea.Controls.Add(this.listView);
            this.pnlWorkArea.Location = new System.Drawing.Point(34, 91);
            this.pnlWorkArea.Name = "pnlWorkArea";
            this.pnlWorkArea.Size = new System.Drawing.Size(200, 100);
            this.pnlWorkArea.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список слов";
            // 
            // listView
            // 
            this.listView.AllowColumnReorder = true;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderWord});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.LabelEdit = true;
            this.listView.Location = new System.Drawing.Point(29, 28);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(121, 48);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            this.listView.Resize += new System.EventHandler(this.listView_Resize);
            // 
            // columnHeaderWord
            // 
            this.columnHeaderWord.Text = "Слово";
            // 
            // WordListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.pnlWorkArea);
            this.Controls.Add(this.pnlInfo);
            this.Name = "WordListForm";
            this.Text = "WordListForm";
            this.Activated += new System.EventHandler(this.WordListForm_Activated);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.pnlWorkArea.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Panel pnlWorkArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeaderWord;
    }
}