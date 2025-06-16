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
    public partial class FieldFormControl : UserControl
    {
        [Browsable(true)]
        public new event EventHandler? TextChanged
        {
            add => txtCommon.TextChanged += value;
            remove => txtCommon.TextChanged -= value;
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public new string Text
        {
            get => txtCommon.Text;
            set => txtCommon.Text = value;
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Title
        {
            get => lblCommon.Text;
            set => lblCommon.Text = value;
        }
        public FieldFormControl()
        {
            InitializeComponent();
            lblCommon.ForeColor = Color.White;
        }
    }
}
