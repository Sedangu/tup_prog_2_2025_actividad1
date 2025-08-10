namespace Ejercicio1_solo
{
    partial class FormPrincipal
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
            this.Btn_ConsDescObj = new System.Windows.Forms.Button();
            this.Tbx_Descripcion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_ConsDescObj
            // 
            this.Btn_ConsDescObj.Location = new System.Drawing.Point(512, 256);
            this.Btn_ConsDescObj.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_ConsDescObj.Name = "Btn_ConsDescObj";
            this.Btn_ConsDescObj.Size = new System.Drawing.Size(200, 65);
            this.Btn_ConsDescObj.TabIndex = 0;
            this.Btn_ConsDescObj.Text = "&Construir y Describir Objetos";
            this.Btn_ConsDescObj.UseVisualStyleBackColor = true;
            this.Btn_ConsDescObj.Click += new System.EventHandler(this.Btn_ConsDescObj_Click);
            // 
            // Tbx_Descripcion
            // 
            this.Tbx_Descripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_Descripcion.Location = new System.Drawing.Point(12, 12);
            this.Tbx_Descripcion.Multiline = true;
            this.Tbx_Descripcion.Name = "Tbx_Descripcion";
            this.Tbx_Descripcion.Size = new System.Drawing.Size(482, 580);
            this.Tbx_Descripcion.TabIndex = 1;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 619);
            this.Controls.Add(this.Tbx_Descripcion);
            this.Controls.Add(this.Btn_ConsDescObj);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Figuras Geométricas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_ConsDescObj;
        private System.Windows.Forms.TextBox Tbx_Descripcion;
    }
}

