using System;
using System.Drawing;
using System.Windows.Forms;

namespace EditorTextoAndPaint
{
    public partial class frmPaint : Form
    {
        public frmPaint()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cboColor.Items.Clear();
            string[] colores = Enum.GetNames(typeof(System.Drawing.KnownColor));
            cboColor.Items.AddRange(colores);
        }

        private void cboColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                string texto = cboColor.Items[e.Index].ToString();
                Brush border = new SolidBrush(e.ForeColor);
                Color color = Color.FromName(texto);
                Brush pincel = new SolidBrush(color);
                Pen boli = new Pen(e.ForeColor);
                Rectangle primerRectangulo;
                Rectangle segundoRectagulo;
                primerRectangulo = new Rectangle(e.Bounds.Left + 2, e.Bounds.Top+2,50,e.Bounds.Height-4);
                segundoRectagulo = new Rectangle(e.Bounds.Left + 3, e.Bounds.Top + 3, 48, e.Bounds.Height - 6);

                e.Graphics.DrawRectangle(boli, primerRectangulo);
                e.Graphics.FillRectangle(pincel, segundoRectagulo);
                e.Graphics.DrawString(texto, e.Font, border, e.Bounds.Left+65, e.Bounds.Top+2);
                e.DrawFocusRectangle();      
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAplicarColor_Click(object sender, EventArgs e)
        {
            string texto = cboColor.Text;
            Color color = Color.FromName(texto);
            pibColor.BackColor = color;
        }
    }
}
