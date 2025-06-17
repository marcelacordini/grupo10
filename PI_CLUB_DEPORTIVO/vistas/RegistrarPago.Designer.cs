namespace PI_CLUB_DEPORTIVO.vistas
{
    partial class RegistrarPago
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
            txtClienteID = new TextBox();
            btnBuscar = new Button();
            btnLimpiarBuscar = new Button();
            lblCliente = new Label();
            txtFecha = new TextBox();
            txtVencimiento = new TextBox();
            txtMonto = new TextBox();
            cmbFormaPago = new ComboBox();
            cmbPromocion = new ComboBox();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // txtClienteID
            // 
            txtClienteID.Location = new Point(83, 143);
            txtClienteID.Name = "txtClienteID";
            txtClienteID.Size = new Size(285, 30);
            txtClienteID.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(486, 143);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(178, 30);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiarBuscar
            // 
            btnLimpiarBuscar.Location = new Point(720, 143);
            btnLimpiarBuscar.Name = "btnLimpiarBuscar";
            btnLimpiarBuscar.Size = new Size(178, 30);
            btnLimpiarBuscar.TabIndex = 4;
            btnLimpiarBuscar.Text = "LIMPIAR";
            btnLimpiarBuscar.UseVisualStyleBackColor = true;
            btnLimpiarBuscar.Click += btnLimpiarBuscar_Click;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.ForeColor = SystemColors.ControlLight;
            lblCliente.Location = new Point(83, 107);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(85, 23);
            lblCliente.TabIndex = 5;
            lblCliente.Text = "Cliente ID";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(172, 227);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(188, 30);
            txtFecha.TabIndex = 6;
            // 
            // txtVencimiento
            // 
            txtVencimiento.Location = new Point(611, 226);
            txtVencimiento.Name = "txtVencimiento";
            txtVencimiento.Size = new Size(213, 30);
            txtVencimiento.TabIndex = 7;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(171, 303);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(189, 30);
            txtMonto.TabIndex = 8;
            // 
            // cmbFormaPago
            // 
            cmbFormaPago.FormattingEnabled = true;
            cmbFormaPago.Items.AddRange(new object[] { "Tarjeta", "Efectivo" });
            cmbFormaPago.Location = new Point(165, 373);
            cmbFormaPago.Name = "cmbFormaPago";
            cmbFormaPago.Size = new Size(190, 31);
            cmbFormaPago.TabIndex = 9;
            // 
            // cmbPromocion
            // 
            cmbPromocion.FormattingEnabled = true;
            cmbPromocion.Items.AddRange(new object[] { "3", "6" });
            cmbPromocion.Location = new Point(588, 373);
            cmbPromocion.Name = "cmbPromocion";
            cmbPromocion.Size = new Size(202, 31);
            cmbPromocion.TabIndex = 10;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(92, 462);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(196, 43);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "Registrar Pago";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(404, 464);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(214, 42);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // RegistrarPago
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            ClientSize = new Size(1029, 676);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistrar);
            Controls.Add(cmbPromocion);
            Controls.Add(cmbFormaPago);
            Controls.Add(txtMonto);
            Controls.Add(txtVencimiento);
            Controls.Add(txtFecha);
            Controls.Add(lblCliente);
            Controls.Add(btnLimpiarBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(txtClienteID);
            Name = "RegistrarPago";
            Controls.SetChildIndex(txtClienteID, 0);
            Controls.SetChildIndex(btnBuscar, 0);
            Controls.SetChildIndex(btnLimpiarBuscar, 0);
            Controls.SetChildIndex(lblCliente, 0);
            Controls.SetChildIndex(txtFecha, 0);
            Controls.SetChildIndex(txtVencimiento, 0);
            Controls.SetChildIndex(txtMonto, 0);
            Controls.SetChildIndex(cmbFormaPago, 0);
            Controls.SetChildIndex(cmbPromocion, 0);
            Controls.SetChildIndex(btnRegistrar, 0);
            Controls.SetChildIndex(btnLimpiar, 0);
            ResumeLayout(false);
            PerformLayout();
            // 

        }

        #endregion

        private TextBox txtClienteID;
        private Button btnBuscar;
        private Button btnLimpiarBuscar;
        private Label lblCliente;
        private TextBox txtFecha;
        private TextBox txtVencimiento;
        private TextBox txtMonto;
        private ComboBox cmbFormaPago;
        private ComboBox cmbPromocion;
        private Button btnRegistrar;
        private Button btnLimpiar;
    }
}