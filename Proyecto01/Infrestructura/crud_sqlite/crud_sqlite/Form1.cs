using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using crud_sqlite.modelo;
using crud_sqlite.logica;

namespace crud_sqlite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            persona objeto = new persona()
            {
                Nombre = txtnombre.Text,
                Apellido = txtapellido.Text,
            };
            bool respuesta = persona_logica.Instancia.guardar(objeto);
            if (respuesta)
            {
                limpiar();
                mostrar_personas();
                
            }
        }
        public void mostrar_personas()
        {
            dgwpersonas.DataSource = null;
            dgwpersonas.DataSource = persona_logica.Instancia.listar();
        }
        public void limpiar()
        {
            txtidpersona.Text = "";
            txtapellido.Text = "";
            txtnombre.Text = "";
            txtnombre.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            mostrar_personas();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            persona objeto = new persona()
            {
                id = int.Parse(txtidpersona.Text),
                Nombre = txtnombre.Text,
                Apellido = txtapellido.Text,
            };
            bool respuesta = persona_logica.Instancia.editar(objeto);
            if (respuesta)
            {
                limpiar();
                mostrar_personas();

            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            persona objeto = new persona()
            {
                id = int.Parse(txtidpersona.Text),              
            };
            bool respuesta = persona_logica.Instancia.eliminar(objeto);
            if (respuesta)
            {
                limpiar();
                mostrar_personas();

            }
        }
    }
}
