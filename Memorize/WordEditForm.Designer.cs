namespace Memorize
{
    partial class WordEditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.bbEdit = new System.Windows.Forms.Button();
            this.bbDel = new System.Windows.Forms.Button();
            this.bbAdd = new System.Windows.Forms.Button();
            this.pnlWorkArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWorkArea
            // 
            this.pnlWorkArea.Controls.Add(this.bbAdd);
            this.pnlWorkArea.Controls.Add(this.bbDel);
            this.pnlWorkArea.Controls.Add(this.bbEdit);
            this.pnlWorkArea.Controls.Add(this.listBox);
            this.pnlWorkArea.Controls.Add(this.label2);
            this.pnlWorkArea.Controls.Add(this.textBox);
            this.pnlWorkArea.Controls.Add(this.label1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Слово";
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(13, 30);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(255, 26);
            this.textBox.TabIndex = 1;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Значения";
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(15, 89);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(188, 68);
            this.listBox.TabIndex = 3;
            // 
            // bbEdit
            // 
            this.bbEdit.Location = new System.Drawing.Point(210, 103);
            this.bbEdit.Name = "bbEdit";
            this.bbEdit.Size = new System.Drawing.Size(58, 23);
            this.bbEdit.TabIndex = 4;
            this.bbEdit.Text = "Edit";
            this.bbEdit.UseVisualStyleBackColor = true;
            this.bbEdit.Click += new System.EventHandler(this.bbEdit_Click);
            // 
            // bbDel
            // 
            this.bbDel.Location = new System.Drawing.Point(210, 134);
            this.bbDel.Name = "bbDel";
            this.bbDel.Size = new System.Drawing.Size(58, 23);
            this.bbDel.TabIndex = 5;
            this.bbDel.Text = "Delete";
            this.bbDel.UseVisualStyleBackColor = true;
            this.bbDel.Click += new System.EventHandler(this.bbDel_Click);
            // 
            // bbAdd
            // 
            this.bbAdd.Location = new System.Drawing.Point(210, 74);
            this.bbAdd.Name = "bbAdd";
            this.bbAdd.Size = new System.Drawing.Size(58, 23);
            this.bbAdd.TabIndex = 6;
            this.bbAdd.Text = "Add";
            this.bbAdd.UseVisualStyleBackColor = true;
            this.bbAdd.Click += new System.EventHandler(this.bbAdd_Click);
            // 
            // WordEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(285, 262);
            this.Name = "WordEditForm";
            this.Activated += new System.EventHandler(this.WordEditForm_Activated);
            this.pnlWorkArea.ResumeLayout(false);
            this.pnlWorkArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bbAdd;
        private System.Windows.Forms.Button bbDel;
        private System.Windows.Forms.Button bbEdit;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox;
    }
}
