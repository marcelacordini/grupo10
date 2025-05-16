namespace PI_CLUB_DEPORTIVO.vistas.registroCliente.controles
{
    partial class FieldFormControl
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
            lblCommon = new Label();
            txtCommon = new TextBox();
            SuspendLayout();
            // 
            // lblCommon
            // 
            lblCommon.AutoSize = true;
            lblCommon.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCommon.Location = new Point(3, 0);
            lblCommon.Name = "lblCommon";
            lblCommon.Size = new Size(70, 28);
            lblCommon.TabIndex = 0;
            lblCommon.Text = "label1";
            // 
            // txtCommon
            // 
            txtCommon.Location = new Point(0, 31);
            txtCommon.Name = "txtCommon";
            txtCommon.Size = new Size(526, 27);
            txtCommon.TabIndex = 1;
            // 
            // LabelCommon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtCommon);
            Controls.Add(lblCommon);
            Name = "LabelCommon";
            Size = new Size(526, 72);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblCommon;
        private TextBox txtCommon;
    }
}
