namespace frmExamen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.Show();
        }
    }
}
