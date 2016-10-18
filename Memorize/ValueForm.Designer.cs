namespace Memorize
{
    partial class ValueForm
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
            this.bbOk = new System.Windows.Forms.Button();
            this.bbCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bbOk
            // 
            this.bbOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bbOk.Location = new System.Drawing.Point(116, 74);
            this.bbOk.Name = "bbOk";
            this.bbOk.Size = new System.Drawing.Size(75, 30);
            this.bbOk.TabIndex = 0;
            this.bbOk.Text = "Ok";
            this.bbOk.UseVisualStyleBackColor = true;
            this.bbOk.Click += new System.EventHandler(this.bbOk_Click);
            // 
            // bbCancel
            // 
            this.bbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bbCancel.Location = new System.Drawing.Point(197, 74);
            this.bbCancel.Name = "bbCancel";
            this.bbCancel.Size = new System.Drawing.Size(75, 30);
            this.bbCancel.TabIndex = 1;
            this.bbCancel.Text = "Cancel";
            this.bbCancel.UseVisualStyleBackColor = true;
            this.bbCancel.Click += new System.EventHandler(this.bbCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Перевод слова";
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(19, 35);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(254, 26);
            this.textBox.TabIndex = 3;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // ValueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 109);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bbCancel);
            this.Controls.Add(this.bbOk);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ValueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Перевод к слову";
            this.Activated += new System.EventHandler(this.ValueForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bbOk;
        private System.Windows.Forms.Button bbCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox;
    }
}