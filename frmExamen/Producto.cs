using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmExamen
{
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }
        private void ActualizaGrid()
        {
            Clase obj = new Clase();
            DataSet ds = obj.Consulta("Select * From Producto");
            if (ds != null)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
        private void Producto_Load(object sender, EventArgs e)
        {
            ActualizaGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmCambios cambios = new frmCambios(
                dataGridView1[0, e.RowIndex].Value.ToString(),
                dataGridView1[1, e.RowIndex].Value.ToString(),
                dataGridView1[2, e.RowIndex].Value.ToString(),
                dataGridView1[3, e.RowIndex].Value.ToString(),
                dataGridView1[4, e.RowIndex].Value.ToString(),
                dataGridView1[5, e.RowIndex].Value.ToString());
            cambios.Show();
            ActualizaGrid();
        }

        private void Alta_Click(object sender, EventArgs e)
        {
            frmAlta alta = new frmAlta();
            alta.Show();
        }

        private void Producto_Activated(object sender, EventArgs e)
        {
            ActualizaGrid();
        }
    }
}
