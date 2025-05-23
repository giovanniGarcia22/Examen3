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
    public partial class frmCambios : Form
    {
        public frmCambios(string id, string nom, string desc, string prc, string cant, string fec)
        {
            InitializeComponent();
            textBox1.Text = id;
            textBox2.Text = nom;
            textBox3.Text = desc;
            textBox4.Text = prc;
            textBox5.Text = cant;
            textBox6.Text = fec;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro de eliminar el registro?",
                "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                Clase x = new Clase();
                bool f = x.comando("delete from producto where id= " + textBox1.Text);
                if (f == true)
                {
                    MessageBox.Show("Datos Eliminados", "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al eliminar", "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clase x = new Clase();
            bool f = x.comando("update producto set " +
                "nombre='" + textBox2.Text + "', " +
                "descripcion='" + textBox3.Text + "', " +
                "precio=" + textBox4.Text +
                "cantidad=" + textBox5.Text +
                "fec_ingreso='" + textBox6.Text + "' " +
                "where id=" + textBox1.Text);
            if (f == true)
            {
                MessageBox.Show("Datos Actualizados", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al actualizar", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
