﻿using System;
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

            //esta instruccion evalua si el campo textLicencia esta vacio retornandonos un errorProvider
            int verificar;
            if (!int.TryParse(textLicencia.Text, out verificar))
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
            //esta instruccion evalua si el campo textNombreVendedor.Text esta vacio retornandonos un errorProvider
            if (textNombreVendedor.Text == "")
            {
                error1.SetError(textNombreVendedor, "Debe ingresar un Nombre");
                textNombreVendedor.Focus();
                return;//es obligatorio el uso del return, de lo contrario continua con la ejecucion del programa pese a que muestra el error
            }
            error1.SetError(textNombreVendedor, "");//con esta instruccion quitamos el error una ver corregido

            //esta instruccion evalua si el campo textVendedoresApellido.Text esta vacio retornandonos un errorProvider
            if (textVendedoresApellido.Text == "")
            {
                error1.SetError(textVendedoresApellido, "Debe ingresar un Apellido");
                textVendedoresApellido.Focus();
                return;//es obligatorio el uso del return, de lo contrario continua con la ejecucion del programa pese a que muestra el error
            }
            error1.SetError(textVendedoresApellido, "");//con esta instruccion quitamos el error una ver corregido


            vendedores vendedores = new vendedores();
            vendedores.Vendedores_Nombre = textNombreVendedor.Text;
            vendedores.Vendedores_Inicial = textInicialVendedor.Text;
            vendedores.Vendedores_Apellido = textVendedoresApellido.Text;

            int resultado = vendedoresDAL.Agregar_vendedores(vendedores);

            if (resultado > 0)
            {
                MessageBox.Show("Datos guardados correctamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textVendedoresApellido.Text = "";
                textInicialVendedor.Text = "";
                textNombreVendedor.Text = "";
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

        private void button3_Click(object sender, EventArgs e)
        {
            //esta instruccion evalua si el campo textCalibre.Text esta vacio retornandonos un errorProvider
            if (textCalibre.Text == "")
            {
                error1.SetError(textCalibre, "Debe ingresar un Calibre");
                textCalibre.Focus();
                return;//es obligatorio el uso del return, de lo contrario continua con la ejecucion del programa pese a que muestra el error
            }
            error1.SetError(textCalibre, "");//con esta instruccion quitamos el error una ver corregido

            calibre calibre = new calibre();
            calibre.Calibres_Calibres = textCalibre.Text;

            int resultado = calibreDAL.Agregar_calibre(calibre);

            if (resultado > 0)
            {
                MessageBox.Show("Datos guardados correctamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textCalibre.Text = "";
            }
            else
            {
                MessageBox.Show("No se pudieron Guardar los datos", "Error Al guardar los datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //esta instruccion evalua si el campo textMarcas.Text esta vacio retornandonos un errorProvider
            if (textMarcas.Text == "")
            {
                error1.SetError(textMarcas, "Debe ingresar una Marca de Arma");
                textMarcas.Focus();
                return;//es obligatorio el uso del return, de lo contrario continua con la ejecucion del programa pese a que muestra el error
            }
            error1.SetError(textMarcas, "");//con esta instruccion quitamos el error una ver corregido

            marcas marcas = new marcas();
            marcas.Marcas_Marcas = textMarcas.Text;

            int resultado = marcasDAL.Agregar_marcas(marcas);

            if (resultado > 0)
            {
                MessageBox.Show("Datos guardados correctamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textMarcas.Text = "";
            }
            else
            {
                MessageBox.Show("No se pudieron Guardar los datos", "Error Al guardar los datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //esta instruccion evalua si el campo textModelo.Text esta vacio retornandonos un errorProvider
            if (textModelo.Text == "")
            {
                error1.SetError(textModelo, "Debe ingresar un Modelo de Arma");
                textModelo.Focus();
                return;//es obligatorio el uso del return, de lo contrario continua con la ejecucion del programa pese a que muestra el error
            }
            error1.SetError(textModelo, "");//con esta instruccion quitamos el error una ver corregido

            modelos modelos = new modelos();
            modelos.Modelos_Modelos = textModelo.Text;

            int resultado = modelosDAL.Agregar_modelos(modelos);

            if (resultado > 0)
            {
                MessageBox.Show("Datos guardados correctamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textModelo.Text = "";
            }
            else
            {
                MessageBox.Show("No se pudieron Guardar los datos", "Error Al guardar los datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rAbreu15DataSet3.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter1.Fill(this.rAbreu15DataSet3.Clientes);
            // TODO: This line of code loads data into the 'rAbreu15DataSet2.Calibres' table. You can move, or remove it, as needed.
            this.calibresTableAdapter.Fill(this.rAbreu15DataSet2.Calibres);
            // TODO: This line of code loads data into the 'rAbreu15DataSet2.Modelos' table. You can move, or remove it, as needed.
            this.modelosTableAdapter.Fill(this.rAbreu15DataSet2.Modelos);
            // TODO: This line of code loads data into the 'rAbreu15DataSet2.Inventario' table. You can move, or remove it, as needed.
            this.inventarioTableAdapter.Fill(this.rAbreu15DataSet2.Inventario);
            // TODO: This line of code loads data into the 'rAbreu15DataSet2.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.Fill(this.rAbreu15DataSet2.Marcas);
            // TODO: This line of code loads data into the 'rAbreu15DataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.rAbreu15DataSet.Clientes);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            inventario inventario = new inventario();
            inventario.Inventario_Marcas_Id = boxMarca.SelectedValue.ToString();
            inventario.Inventario_Modelos_Id = boxModelo.SelectedValue.ToString();
            inventario.Inventario_Calibres_Id = boxModelo.SelectedValue.ToString();
            inventario.Inventario_NumeroDeSerie = textSerie.Text;
            inventario.Inventario_Costo = textCosto.Text;
            inventario.Inventario_Precio = textPrecio.Text;
            //cliente.Clientes_LicendiaDeArmas = Convert.ToInt32(textLicencia.Text);

            int resultado = inventarioDAL.Agregar_inventario(inventario);

            if (resultado > 0)
            {
                MessageBox.Show("Datos guardados correctamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                boxMarca.Text = "";
                boxModelo.Text = "";
                boxCalibre.Text = "";
                textSerie.Text = "";
                textCosto.Text = "";
                textPrecio.Text = "";
            }
            else
            {
                MessageBox.Show("No se pudieron Guardar los datos", "Error Al guardar los datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

    }
      

}
