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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            btnCerrarSesion = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnRegistrarCliente = new Button();
            btnPagarCuotaoActividad = new Button();
            btnSociosConCuotaVencida = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCerrarSesion.Location = new Point(676, 316);
            btnCerrarSesion.Margin = new Padding(3, 4, 3, 4);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(121, 26);
            btnCerrarSesion.TabIndex = 3;
            btnCerrarSesion.Text = "CERRAR SESIÓN";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(btnRegistrarCliente, 0, 0);
            tableLayoutPanel2.Controls.Add(btnPagarCuotaoActividad, 0, 1);
            tableLayoutPanel2.Controls.Add(btnSociosConCuotaVencida, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(269, 72);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(260, 271);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.AutoSize = true;
            btnRegistrarCliente.Location = new Point(3, 4);
            btnRegistrarCliente.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(254, 29);
            btnRegistrarCliente.TabIndex = 0;
            btnRegistrarCliente.Text = "REGISTRAR CLIENTE";
            btnRegistrarCliente.UseVisualStyleBackColor = true;
            btnRegistrarCliente.Click += btnRegistrarCliente_Click;
            // 
            // btnPagarCuotaoActividad
            // 
            btnPagarCuotaoActividad.AutoSize = true;
            btnPagarCuotaoActividad.Location = new Point(3, 41);
            btnPagarCuotaoActividad.Margin = new Padding(3, 4, 3, 4);
            btnPagarCuotaoActividad.Name = "btnPagarCuotaoActividad";
            btnPagarCuotaoActividad.Size = new Size(254, 29);
            btnPagarCuotaoActividad.TabIndex = 1;
            btnPagarCuotaoActividad.Text = "PAGAR CUOTA O ACTIVIDAD";
            btnPagarCuotaoActividad.UseVisualStyleBackColor = true;
            btnPagarCuotaoActividad.Click += btnPagarCuotaoActividad_Click;
            // 
            // btnSociosConCuotaVencida
            // 
            btnSociosConCuotaVencida.AutoSize = true;
            btnSociosConCuotaVencida.Location = new Point(3, 78);
            btnSociosConCuotaVencida.Margin = new Padding(3, 4, 3, 4);
            btnSociosConCuotaVencida.Name = "btnSociosConCuotaVencida";
            btnSociosConCuotaVencida.Size = new Size(254, 29);
            btnSociosConCuotaVencida.TabIndex = 2;
            btnSociosConCuotaVencida.Text = "SOCIOS CON CUOTA VENCIDA";
            btnSociosConCuotaVencida.UseVisualStyleBackColor = true;
            btnSociosConCuotaVencida.Click += btnSociosConCuotaVencida_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(534, 348);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(264, 118);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 348);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Location = new Point(268, 0);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(262, 69);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Menú Principal";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(lblTitle, 1, 0);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 2);
            tableLayoutPanel1.Controls.Add(pictureBox2, 2, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(btnCerrarSesion, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 42);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 121F));
            tableLayoutPanel1.Size = new Size(800, 468);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4);
            Name = "MenuPrincipal";
            Text = "MENÚ PRINCIPAL";
            Load += MenuPrincipal_Load;
            Controls.SetChildIndex(tableLayoutPanel1, 0);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCerrarSesion;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnRegistrarCliente;
        private Button btnPagarCuotaoActividad;
        private Button btnSociosConCuotaVencida;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private TableLayoutPanel tableLayoutPanel1;
    }
}