using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlmacenarDatosRasec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Apellido_Click(object sender, EventArgs e)
        {

        }

        private void tabVendedores_Click(object sender, EventArgs e)
        {

        }

        //private void Form1_Load(object sender, EventArgs e)
        //{

        //}

        private void buttonGuardarCliente_Click(object sender, EventArgs e)
        {

            //esta instruccion evalua si el campo textNombre esta vacio retornandonos un errorProvider
            if (textNombre.Text == "") 
            {
                error1.SetError(textNombre, "Debe ingresar un Nombre");
                textNombre.Focus();
                return;//es obligatorio el uso del return, de lo contrario continua con la ejecucion del programa pese a que muestra el error
            }
            error1.SetError(textNombre, "");//con esta instruccion quitamos el error una ver corregido

            //esta instruccion evalua si el campo textNombre esta vacio retornandonos un errorProvider
            int verificar;
            if(!int.TryParse(textLicencia.Text, out verificar))
            {
                error1.SetError(textLicencia, "Debe ingresar un Numero");
                textLicencia.Focus();
               return;//es obligatorio el uso del return, de lo contrario continua con la ejecucion del programa pese a que muestra el error
            }
            error1.SetError(textLicencia, "");//con esta instruccion quitamos el error una ver corregido


            cliente cliente = new cliente();            
            cliente.Clientes_Nombre = textNombre.Text;
            cliente.Clientes_Inicial = textInicial.Text;
            cliente.Clientes_Apellido = textApellido.Text;
            cliente.Clientes_LicendiaDeArmas = Convert.ToInt32(textLicencia.Text);

            int resultado = clienteDAL.Agregar_clientes(cliente);

            if (resultado > 0)
            {
                MessageBox.Show("Datos guardados correctamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textNombre.Text = "";
                textInicial.Text = "";
                textApellido.Text = "";
                textLicencia.Text = "";
            }
            else
            {
                MessageBox.Show("No se pudieron Guardar los datos", "Error Al guardar los datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vendedores vendedores = new vendedores();
            vendedores.Vendedores_Nombre = textNombreVendedor.Text;
            vendedores.Vendedores_Inicial = textInicialVendedor.Text;
            vendedores.Vendedores_Apellido = textVendedoresApellido.Text;
            
            int resultado = vendedoresDAL.Agregar_vendedores(vendedores);

            if (resultado > 0)
            {
                MessageBox.Show("Datos guardados correctamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudieron Guardar los datos", "Error Al guardar los datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabInventario_Click(object sender, EventArgs e)
        {    

        }

        private void textLicencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
