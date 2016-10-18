namespace Memorize
{
    partial class EditForm
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lbHeader = new System.Windows.Forms.Label();
            this.pnlWorkArea = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bbCancel = new System.Windows.Forms.Button();
            this.bbOk = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lbHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(285, 27);
            this.pnlHeader.TabIndex = 0;
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHeader.Location = new System.Drawing.Point(5, 5);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(51, 16);
            this.lbHeader.TabIndex = 0;
            this.lbHeader.Text = "label1";
            // 
            // pnlWorkArea
            // 
            this.pnlWorkArea.Location = new System.Drawing.Point(12, 71);
            this.pnlWorkArea.Name = "pnlWorkArea";
            this.pnlWorkArea.Size = new System.Drawing.Size(200, 100);
            this.pnlWorkArea.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bbCancel);
            this.panel1.Controls.Add(this.bbOk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 50);
            this.panel1.TabIndex = 2;
            // 
            // bbCancel
            // 
            this.bbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bbCancel.Location = new System.Drawing.Point(193, 10);
            this.bbCancel.Name = "bbCancel";
            this.bbCancel.Size = new System.Drawing.Size(75, 30);
            this.bbCancel.TabIndex = 1;
            this.bbCancel.Text = "Cancel";
            this.bbCancel.UseVisualStyleBackColor = true;
            // 
            // bbOk
            // 
            this.bbOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bbOk.Location = new System.Drawing.Point(112, 10);
            this.bbOk.Name = "bbOk";
            this.bbOk.Size = new System.Drawing.Size(75, 30);
            this.bbOk.TabIndex = 0;
            this.bbOk.Text = "Ok";
            this.bbOk.UseVisualStyleBackColor = true;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 262);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlWorkArea);
            this.Controls.Add(this.pnlHeader);
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditForm";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bbCancel;
        private System.Windows.Forms.Button bbOk;
        protected System.Windows.Forms.Panel pnlWorkArea;
        protected System.Windows.Forms.Label lbHeader;
    }
}