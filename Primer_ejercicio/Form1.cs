using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Primer_ejercicio
{
    public partial class Form1 : Form
    {
        CEmpleado objempleado = null;

        public Form1()
        {
            InitializeComponent();
            llenarcombocategorias();
            configurarlistaempleados();

        }

        void llenarcombocategorias()
        {
            comboBoxLista.Items.Add("A");
            comboBoxLista.Items.Add("B");
            comboBoxLista.Items.Add("C");
            comboBoxLista.Items.Add("D");
        }
        void configurarlistaempleados()
        {
            listViewLista.View = View.Details;
            listViewLista.GridLines = true;
            listViewLista.Columns.Add("Empleado", 120);
            listViewLista.Columns.Add("Categoria", 80);
            listViewLista.Columns.Add("Minutos tardanza", 120);
            listViewLista.Columns.Add("Llamadas atencion", 120);
            listViewLista.Columns.Add("Pago", 120);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            objempleado = new CEmpleado();
            objempleado.Nombres = textBoxNombre.Text;

            objempleado.Categoria = comboBoxLista.Text;
            objempleado.Tardanza = Convert.ToInt32(textBoxTardanza.Text);
            objempleado.Atencion = Convert.ToInt32(textBoxAtencion.Text);
            ListViewItem fila = new ListViewItem(objempleado.Nombres);
            fila.SubItems.Add(objempleado.Categoria);
            fila.SubItems.Add(objempleado.Tardanza.ToString());
            fila.SubItems.Add(objempleado.Atencion.ToString());
            fila.SubItems.Add(objempleado.Calcular_pago().ToString());
            listViewLista.Items.Add(fila);
            labelEmpleados.Text = listViewLista.Items.Count.ToString();

        }
    }
}
