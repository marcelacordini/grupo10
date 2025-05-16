using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_CLUB_DEPORTIVO.vistas.registroCliente.controles
{
    [DefaultEvent(nameof(TextChanged))]
    public partial class FieldFormSmallControl : UserControl
    {
        [Browsable(true)]
        public new event EventHandler? TextChanged
        {
            add => txtInput.TextChanged += value;
            remove => txtInput.TextChanged -= value;
        }

        [Browsable(true)]
        public new event KeyPressEventHandler? KeyPress
        {
            add => txtInput.KeyPress += value;
            remove => txtInput.KeyPress -= value;
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public new string Text
        {
            get => txtInput.Text;
            set => txtInput.Text = value;
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Title
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }
        public FieldFormSmallControl()
        {
            InitializeComponent();
        }
    }
}
