namespace PI_CLUB_DEPORTIVO.vistas
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnIngresar = new Button();
            label1 = new Label();
            txtUsuario = new TextBox();
            txtPass = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(378, 243);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(266, 53);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(378, 70);
            label1.Name = "label1";
            label1.Size = new Size(146, 21);
            label1.TabIndex = 1;
            label1.Text = "INICIO DE SESIÓN";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(378, 132);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(266, 25);
            txtUsuario.TabIndex = 2;
            txtUsuario.Text = "Usuario";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(378, 179);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(266, 25);
            txtPass.TabIndex = 3;
            txtPass.Text = "Contraseña";
            txtPass.TextChanged += textBox1_TextChanged;
            txtPass.Enter += txtPass_Enter;
            txtPass.Leave += txtPass_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(331, 327);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 382);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Controls.Add(btnIngresar);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            Controls.SetChildIndex(pictureBox1, 0);
            Controls.SetChildIndex(btnIngresar, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(txtUsuario, 0);
            Controls.SetChildIndex(txtPass, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private Label label1;
        private TextBox txtUsuario;
        private TextBox txtPass;
        //private PictureBox pictureBox1;
        private PictureBox pictureBox1;
    }
}