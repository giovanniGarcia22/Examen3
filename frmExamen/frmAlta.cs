using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace frmExamen
{
    public partial class frmAlta : Form
    {
        public frmAlta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clase datos = new Clase();
            bool f = datos.comando("insert into producto values(" + textBox1.Text + ",'" +
            textBox2.Text + "','" + textBox3.Text + "'," + textBox4.Text + "," +
            textBox5.Text + ",'" + textBox6.Text + "')");
            if (f == true)
            {
                MessageBox.Show("Datos insertados", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al insertar", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
