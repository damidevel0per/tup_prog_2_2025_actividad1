namespace ActividadAula
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
            this.txtListar = new System.Windows.Forms.TextBox();
            this.btnGenerarJson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtListar
            // 
            this.txtListar.Location = new System.Drawing.Point(12, 12);
            this.txtListar.Multiline = true;
            this.txtListar.Name = "txtListar";
            this.txtListar.Size = new System.Drawing.Size(776, 325);
            this.txtListar.TabIndex = 0;
            // 
            // btnGenerarJson
            // 
            this.btnGenerarJson.Location = new System.Drawing.Point(279, 374);
            this.btnGenerarJson.Name = "btnGenerarJson";
            this.btnGenerarJson.Size = new System.Drawing.Size(232, 46);
            this.btnGenerarJson.TabIndex = 1;
            this.btnGenerarJson.Text = "Generar text";
            this.btnGenerarJson.UseVisualStyleBackColor = true;
            this.btnGenerarJson.Click += new System.EventHandler(this.btnGenerarJson_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerarJson);
            this.Controls.Add(this.txtListar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtListar;
        private System.Windows.Forms.Button btnGenerarJson;
    }
}

