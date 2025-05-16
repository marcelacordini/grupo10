namespace PI_CLUB_DEPORTIVO.vistas.registroCliente.controles
{
    partial class LabelCommon
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblCommon = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lblCommon
            // 
            lblCommon.AutoSize = true;
            lblCommon.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCommon.Location = new Point(25, 44);
            lblCommon.Name = "lblCommon";
            lblCommon.Size = new Size(70, 28);
            lblCommon.TabIndex = 0;
            lblCommon.Text = "label1";
            // 
            // Label
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblCommon);
            Name = "Label";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblCommon;
    }
}
