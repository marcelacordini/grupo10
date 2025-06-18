namespace PI_CLUB_DEPORTIVO.vistas.listaSociosInactivos
{
    partial class socioInactivo
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
            components = new System.ComponentModel.Container();
            cuotaBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)cuotaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cuotaBindingSource
            // 
            cuotaBindingSource.DataSource = typeof(entidades.Cuota);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(64, 71, 100);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(96, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.Size = new Size(769, 339);
            dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(393, 45);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 3;
            label1.Text = "Lista de Socios Inactivos";
            // 
            // socioInactivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 71, 100);
            ClientSize = new Size(963, 530);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "socioInactivo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Socios Inactivos";
            ((System.ComponentModel.ISupportInitialize)cuotaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource cuotaBindingSource;
        private DataGridView dataGridView1;
        private Label label1;
    }
}