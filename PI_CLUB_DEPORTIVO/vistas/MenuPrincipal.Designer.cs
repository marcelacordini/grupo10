namespace PI_CLUB_DEPORTIVO.vistas
{
    partial class MenuPrincipal
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
            btnRegistrarCliente = new Button();
            btnPagarCuotaoActividad = new Button();
            btnSociosConCuotaVencida = new Button();
            btnCerrarSesion = new Button();
            SuspendLayout();
            // 
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.Location = new Point(124, 66);
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(121, 23);
            btnRegistrarCliente.TabIndex = 0;
            btnRegistrarCliente.Text = "REGISTRAR CLIENTE";
            btnRegistrarCliente.UseVisualStyleBackColor = true;
            btnRegistrarCliente.Click += btnRegistrarCliente_Click;
            // 
            // btnPagarCuotaoActividad
            // 
            btnPagarCuotaoActividad.Location = new Point(124, 116);
            btnPagarCuotaoActividad.Name = "btnPagarCuotaoActividad";
            btnPagarCuotaoActividad.Size = new Size(168, 23);
            btnPagarCuotaoActividad.TabIndex = 1;
            btnPagarCuotaoActividad.Text = "PAGAR CUOTA O ACTIVIDAD";
            btnPagarCuotaoActividad.UseVisualStyleBackColor = true;
            btnPagarCuotaoActividad.Click += btnPagarCuotaoActividad_Click;
            // 
            // btnSociosConCuotaVencida
            // 
            btnSociosConCuotaVencida.Location = new Point(124, 166);
            btnSociosConCuotaVencida.Name = "btnSociosConCuotaVencida";
            btnSociosConCuotaVencida.Size = new Size(185, 23);
            btnSociosConCuotaVencida.TabIndex = 2;
            btnSociosConCuotaVencida.Text = "SOCIOS CON CUOTA VENCIDA";
            btnSociosConCuotaVencida.UseVisualStyleBackColor = true;
            btnSociosConCuotaVencida.Click += btnSociosConCuotaVencida_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(124, 218);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(121, 23);
            btnCerrarSesion.TabIndex = 3;
            btnCerrarSesion.Text = "CERRAR SESIÓN";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnSociosConCuotaVencida);
            Controls.Add(btnPagarCuotaoActividad);
            Controls.Add(btnRegistrarCliente);
            Name = "MenuPrincipal";
            Text = "MENÚ PRINCIPAL";
            Load += MenuPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegistrarCliente;
        private Button btnPagarCuotaoActividad;
        private Button btnSociosConCuotaVencida;
        private Button btnCerrarSesion;
    }
}