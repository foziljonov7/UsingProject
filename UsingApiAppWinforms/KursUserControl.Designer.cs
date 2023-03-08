namespace UsingApiAppWinforms
{
    partial class KursUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl1 = new System.Windows.Forms.Label();
            lbl2 = new System.Windows.Forms.Label();
            LblValue = new System.Windows.Forms.Label();
            Lblname = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl1.Location = new System.Drawing.Point(32, 42);
            lbl1.Name = "lbl1";
            lbl1.Size = new System.Drawing.Size(83, 32);
            lbl1.TabIndex = 0;
            lbl1.Text = "Name:";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl2.Location = new System.Drawing.Point(286, 42);
            lbl2.Name = "lbl2";
            lbl2.Size = new System.Drawing.Size(77, 32);
            lbl2.TabIndex = 1;
            lbl2.Text = "Value:";
            // 
            // LblValue
            // 
            LblValue.AutoSize = true;
            LblValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LblValue.Location = new System.Drawing.Point(377, 42);
            LblValue.Name = "LblValue";
            LblValue.Size = new System.Drawing.Size(79, 32);
            LblValue.TabIndex = 3;
            LblValue.Text = "11350";
            // 
            // Lblname
            // 
            Lblname.AutoSize = true;
            Lblname.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Lblname.Location = new System.Drawing.Point(123, 42);
            Lblname.Name = "Lblname";
            Lblname.Size = new System.Drawing.Size(60, 32);
            Lblname.TabIndex = 2;
            Lblname.Text = "USD";
            // 
            // KursUserControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(LblValue);
            Controls.Add(Lblname);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Name = "KursUserControl";
            Size = new System.Drawing.Size(576, 116);
            Load += KursUserControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label LblValue;
        private System.Windows.Forms.Label Lblname;
    }
}
