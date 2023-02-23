namespace EditorTextoAndPaint
{
    partial class frmPaint
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
            this.pibColor = new System.Windows.Forms.PictureBox();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.btnAplicarColor = new System.Windows.Forms.Button();
            this.lblColor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pibColor)).BeginInit();
            this.SuspendLayout();
            // 
            // pibColor
            // 
            this.pibColor.Location = new System.Drawing.Point(12, 2);
            this.pibColor.Name = "pibColor";
            this.pibColor.Size = new System.Drawing.Size(795, 417);
            this.pibColor.TabIndex = 0;
            this.pibColor.TabStop = false;
            // 
            // cboColor
            // 
            this.cboColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboColor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Location = new System.Drawing.Point(12, 450);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(230, 33);
            this.cboColor.TabIndex = 1;
            this.cboColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboColor_DrawItem);
            // 
            // btnAplicarColor
            // 
            this.btnAplicarColor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicarColor.Location = new System.Drawing.Point(259, 439);
            this.btnAplicarColor.Name = "btnAplicarColor";
            this.btnAplicarColor.Size = new System.Drawing.Size(160, 44);
            this.btnAplicarColor.TabIndex = 2;
            this.btnAplicarColor.Text = "Aplicar Color";
            this.btnAplicarColor.UseVisualStyleBackColor = true;
            this.btnAplicarColor.Click += new System.EventHandler(this.btnAplicarColor_Click);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(7, 422);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(139, 25);
            this.lblColor.TabIndex = 3;
            this.lblColor.Text = "Elegir Color:";
            // 
            // frmPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 486);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.btnAplicarColor);
            this.Controls.Add(this.cboColor);
            this.Controls.Add(this.pibColor);
            this.Name = "frmPaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Paint";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pibColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pibColor;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.Button btnAplicarColor;
        private System.Windows.Forms.Label lblColor;
    }
}