namespace Memorize
{
    partial class ChoiceForm
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
            this.pnlWorkArea = new System.Windows.Forms.Panel();
            this.pnlChoice = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlCaption = new System.Windows.Forms.Panel();
            this.lbCaption = new System.Windows.Forms.Label();
            this.pnlWorkArea.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlCaption.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWorkArea
            // 
            this.pnlWorkArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWorkArea.Controls.Add(this.pnlChoice);
            this.pnlWorkArea.Location = new System.Drawing.Point(5, 75);
            this.pnlWorkArea.Name = "pnlWorkArea";
            this.pnlWorkArea.Size = new System.Drawing.Size(274, 182);
            this.pnlWorkArea.TabIndex = 1;
            // 
            // pnlChoice
            // 
            this.pnlChoice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlChoice.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.pnlChoice.ColumnCount = 2;
            this.pnlChoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlChoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlChoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlChoice.Location = new System.Drawing.Point(18, 16);
            this.pnlChoice.Name = "pnlChoice";
            this.pnlChoice.RowCount = 2;
            this.pnlChoice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlChoice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlChoice.Size = new System.Drawing.Size(165, 68);
            this.pnlChoice.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlCaption);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(284, 69);
            this.panel1.TabIndex = 2;
            // 
            // pnlCaption
            // 
            this.pnlCaption.BackColor = System.Drawing.SystemColors.Info;
            this.pnlCaption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCaption.Controls.Add(this.lbCaption);
            this.pnlCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCaption.Location = new System.Drawing.Point(5, 5);
            this.pnlCaption.Name = "pnlCaption";
            this.pnlCaption.Padding = new System.Windows.Forms.Padding(10);
            this.pnlCaption.Size = new System.Drawing.Size(274, 59);
            this.pnlCaption.TabIndex = 1;
            // 
            // lbCaption
            // 
            this.lbCaption.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCaption.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCaption.Location = new System.Drawing.Point(7, 10);
            this.lbCaption.Name = "lbCaption";
            this.lbCaption.Size = new System.Drawing.Size(257, 37);
            this.lbCaption.TabIndex = 0;
            this.lbCaption.Text = "label1";
            this.lbCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlWorkArea);
            this.Name = "ChoiceForm";
            this.Text = "ChoiceForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChoiceForm_FormClosed);
            this.Shown += new System.EventHandler(this.ChoiceForm_Shown);
            this.pnlWorkArea.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlCaption.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlWorkArea;
        private System.Windows.Forms.TableLayoutPanel pnlChoice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlCaption;
        private System.Windows.Forms.Label lbCaption;
    }
}