namespace PI_CLUB_DEPORTIVO.vistas.baseForm
{
    partial class BaseForm
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
            panel = new TableLayoutPanel();
            lblTituloHeader = new Label();
            btnClose = new Button();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.ColumnCount = 3;
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 225F));
            panel.Controls.Add(lblTituloHeader, 0, 0);
            panel.Controls.Add(btnClose, 2, 0);
            panel.Dock = DockStyle.Top;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.RowCount = 1;
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panel.Size = new Size(800, 40);
            panel.TabIndex = 1;
            // 
            // lblTituloHeader
            // 
            lblTituloHeader.AutoSize = true;
            lblTituloHeader.Dock = DockStyle.Left;
            lblTituloHeader.ForeColor = Color.White;
            lblTituloHeader.Location = new Point(3, 0);
            lblTituloHeader.Name = "lblTituloHeader";
            lblTituloHeader.Size = new Size(121, 40);
            lblTituloHeader.TabIndex = 2;
            lblTituloHeader.Text = "CLUB DEPORTIVO";
            lblTituloHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(722, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 34);
            btnClose.TabIndex = 3;
            btnClose.Text = "<close>";
            btnClose.UseCompatibleTextRendering = true;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += Close_Click;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 71, 100);
            ClientSize = new Size(800, 500);
            Controls.Add(panel);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BaseForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BaseForm";
            Load += BaseForm_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel panel;
        private Label lblTituloHeader;
        private Button btnClose;
    }
}