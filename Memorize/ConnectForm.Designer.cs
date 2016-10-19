namespace Memorize
{
    partial class ConnectForm
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
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.SystemColors.Control;
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(0, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(381, 262);
            this.pnlRight.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlLeft.Location = new System.Drawing.Point(184, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(197, 262);
            this.pnlLeft.TabIndex = 1;
            // 
            // ConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 262);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRight);
            this.Name = "ConnectForm";
            this.Text = "ConnectForm";
            this.Resize += new System.EventHandler(this.ConnectForm_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlLeft;
    }
}