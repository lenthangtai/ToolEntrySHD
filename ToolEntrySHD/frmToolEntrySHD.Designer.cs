namespace ToolEntrySHD
{
    partial class frmToolEntrySHD
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
            this.btnInputPath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.ImageView = new System.Windows.Forms.PictureBox();
            this.lblValueIndex = new System.Windows.Forms.Label();
            this.txtEntry = new System.Windows.Forms.TextBox();
            this.txtPathHidden = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInputPath
            // 
            this.btnInputPath.Location = new System.Drawing.Point(12, 10);
            this.btnInputPath.Name = "btnInputPath";
            this.btnInputPath.Size = new System.Drawing.Size(49, 23);
            this.btnInputPath.TabIndex = 0;
            this.btnInputPath.Text = "....";
            this.btnInputPath.UseVisualStyleBackColor = true;
            this.btnInputPath.Click += new System.EventHandler(this.btnInputPath_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(69, 13);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(363, 20);
            this.txtPath.TabIndex = 3;
            this.txtPath.TabStop = false;
            // 
            // ImageView
            // 
            this.ImageView.Location = new System.Drawing.Point(13, 42);
            this.ImageView.Name = "ImageView";
            this.ImageView.Size = new System.Drawing.Size(418, 477);
            this.ImageView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageView.TabIndex = 2;
            this.ImageView.TabStop = false;
            // 
            // lblValueIndex
            // 
            this.lblValueIndex.AutoSize = true;
            this.lblValueIndex.Location = new System.Drawing.Point(396, 527);
            this.lblValueIndex.Name = "lblValueIndex";
            this.lblValueIndex.Size = new System.Drawing.Size(12, 13);
            this.lblValueIndex.TabIndex = 3;
            this.lblValueIndex.Text = "/";
            // 
            // txtEntry
            // 
            this.txtEntry.Location = new System.Drawing.Point(13, 555);
            this.txtEntry.Name = "txtEntry";
            this.txtEntry.Size = new System.Drawing.Size(418, 20);
            this.txtEntry.TabIndex = 1;
            this.txtEntry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEntry_KeyDown);
            // 
            // txtPathHidden
            // 
            this.txtPathHidden.Location = new System.Drawing.Point(421, 13);
            this.txtPathHidden.Name = "txtPathHidden";
            this.txtPathHidden.ReadOnly = true;
            this.txtPathHidden.Size = new System.Drawing.Size(10, 20);
            this.txtPathHidden.TabIndex = 4;
            this.txtPathHidden.TabStop = false;
            this.txtPathHidden.Visible = false;
            // 
            // frmToolEntrySHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 583);
            this.Controls.Add(this.txtPathHidden);
            this.Controls.Add(this.txtEntry);
            this.Controls.Add(this.lblValueIndex);
            this.Controls.Add(this.ImageView);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnInputPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmToolEntrySHD";
            this.Load += new System.EventHandler(this.frmToolEntrySHD_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmToolEntrySHD_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ImageView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInputPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.PictureBox ImageView;
        private System.Windows.Forms.Label lblValueIndex;
        private System.Windows.Forms.TextBox txtEntry;
        private System.Windows.Forms.TextBox txtPathHidden;
    }
}

