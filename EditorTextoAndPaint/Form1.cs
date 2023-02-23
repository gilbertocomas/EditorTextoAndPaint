using System;
using System.Windows.Forms;

namespace EditorTextoAndPaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdbEditorTexto_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEditorTexto.Checked)
            {
                frmEditorTexto miEditor = new frmEditorTexto();
                miEditor.Show();
            }           
            rdbEditorTexto.Checked = false;
        }

        private void rdbPaint_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPaint.Checked)
            {
                frmPaint miPaint = new frmPaint();
                miPaint.Show();
            }
            rdbPaint.Checked = false;
            
        }
    }
}
