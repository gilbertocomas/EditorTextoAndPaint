namespace EditorTextoAndPaint
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdbPaint = new System.Windows.Forms.RadioButton();
            this.rdbEditorTexto = new System.Windows.Forms.RadioButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbPaint
            // 
            this.rdbPaint.AutoSize = true;
            this.rdbPaint.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPaint.Location = new System.Drawing.Point(6, 121);
            this.rdbPaint.Name = "rdbPaint";
            this.rdbPaint.Size = new System.Drawing.Size(91, 29);
            this.rdbPaint.TabIndex = 0;
            this.rdbPaint.Text = "Paint";
            this.rdbPaint.UseVisualStyleBackColor = true;
            this.rdbPaint.CheckedChanged += new System.EventHandler(this.rdbPaint_CheckedChanged);
            // 
            // rdbEditorTexto
            // 
            this.rdbEditorTexto.AutoSize = true;
            this.rdbEditorTexto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEditorTexto.Location = new System.Drawing.Point(6, 43);
            this.rdbEditorTexto.Name = "rdbEditorTexto";
            this.rdbEditorTexto.Size = new System.Drawing.Size(205, 29);
            this.rdbEditorTexto.TabIndex = 0;
            this.rdbEditorTexto.Text = "Editor de Texto";
            this.rdbEditorTexto.UseVisualStyleBackColor = true;
            this.rdbEditorTexto.CheckedChanged += new System.EventHandler(this.rdbEditorTexto_CheckedChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(92, 48);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(525, 20);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "SELECCIONE UNA DE LAS SIGUIENTES APLICACIONES";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbPaint);
            this.groupBox1.Controls.Add(this.rdbEditorTexto);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(96, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 195);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aplicación";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla Principal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdbPaint;
        private System.Windows.Forms.RadioButton rdbEditorTexto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

