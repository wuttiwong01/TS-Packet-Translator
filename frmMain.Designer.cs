namespace TS_Packet_Translator
{
    partial class frmMain
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
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtMask = new System.Windows.Forms.TextBox();
            this.chkClear = new System.Windows.Forms.CheckBox();
            this.rtbBefore = new System.Windows.Forms.RichTextBox();
            this.rtbAfter = new System.Windows.Forms.RichTextBox();
            this.btnReverse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnConvert.Location = new System.Drawing.Point(525, 255);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(115, 28);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = ">> Convert >>";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtMask
            // 
            this.txtMask.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtMask.Location = new System.Drawing.Point(566, 289);
            this.txtMask.Name = "txtMask";
            this.txtMask.Size = new System.Drawing.Size(34, 23);
            this.txtMask.TabIndex = 3;
            this.txtMask.Text = "173";
            this.txtMask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkClear
            // 
            this.chkClear.AutoSize = true;
            this.chkClear.Checked = true;
            this.chkClear.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkClear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkClear.Location = new System.Drawing.Point(536, 359);
            this.chkClear.Name = "chkClear";
            this.chkClear.Size = new System.Drawing.Size(88, 36);
            this.chkClear.TabIndex = 2;
            this.chkClear.Text = "Clear after\r\nConvert";
            this.chkClear.UseVisualStyleBackColor = true;
            // 
            // rtbBefore
            // 
            this.rtbBefore.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbBefore.Location = new System.Drawing.Point(12, 8);
            this.rtbBefore.Name = "rtbBefore";
            this.rtbBefore.Size = new System.Drawing.Size(507, 691);
            this.rtbBefore.TabIndex = 1;
            this.rtbBefore.Text = "";
            // 
            // rtbAfter
            // 
            this.rtbAfter.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAfter.Location = new System.Drawing.Point(647, 6);
            this.rtbAfter.Name = "rtbAfter";
            this.rtbAfter.Size = new System.Drawing.Size(507, 691);
            this.rtbAfter.TabIndex = 4;
            this.rtbAfter.Text = "";
            // 
            // btnReverse
            // 
            this.btnReverse.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnReverse.Location = new System.Drawing.Point(525, 318);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(115, 28);
            this.btnReverse.TabIndex = 2;
            this.btnReverse.Text = "<< Convert <<";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 709);
            this.Controls.Add(this.rtbAfter);
            this.Controls.Add(this.rtbBefore);
            this.Controls.Add(this.chkClear);
            this.Controls.Add(this.txtMask);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnConvert);
            this.Name = "frmMain";
            this.Text = "TS Packet Translator (xor AD)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtMask;
        private System.Windows.Forms.CheckBox chkClear;
        private System.Windows.Forms.RichTextBox rtbBefore;
        private System.Windows.Forms.RichTextBox rtbAfter;
        private System.Windows.Forms.Button btnReverse;
    }
}

