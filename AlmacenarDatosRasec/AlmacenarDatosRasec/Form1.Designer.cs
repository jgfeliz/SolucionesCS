namespace AlmacenarDatosRasec
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabClientes = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.Cerrar = new System.Windows.Forms.Button();
            this.buttonGuardarCliente = new System.Windows.Forms.Button();
            this.textLicencia = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textInicial = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.Licencia = new System.Windows.Forms.Label();
            this.Apellido = new System.Windows.Forms.Label();
            this.Inicial = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.tabVendedores = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonGuardarVendedores = new System.Windows.Forms.Button();
            this.textVendedoresApellido = new System.Windows.Forms.TextBox();
            this.textInicialVendedor = new System.Windows.Forms.TextBox();
            this.textNombreVendedor = new System.Windows.Forms.TextBox();
            this.ApellidoVendedor = new System.Windows.Forms.Label();
            this.InicialVendedor = new System.Windows.Forms.Label();
            this.NombreVendedor = new System.Windows.Forms.Label();
            this.tabCalibre = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textCalibre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabInventario = new System.Windows.Forms.TabPage();
            this.tabMarcas = new System.Windows.Forms.TabPage();
            this.tabModelos = new System.Windows.Forms.TabPage();
            this.tabOrdenes = new System.Windows.Forms.TabPage();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.textMarcas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textModelo = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabClientes.SuspendLayout();
            this.tabVendedores.SuspendLayout();
            this.tabCalibre.SuspendLayout();
            this.tabMarcas.SuspendLayout();
            this.tabModelos.SuspendLayout();
            this.tabOrdenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabClientes);
            this.tabControl1.Controls.Add(this.tabVendedores);
            this.tabControl1.Controls.Add(this.tabCalibre);
            this.tabControl1.Controls.Add(this.tabInventario);
            this.tabControl1.Controls.Add(this.tabMarcas);
            this.tabControl1.Controls.Add(this.tabModelos);
            this.tabControl1.Controls.Add(this.tabOrdenes);
            this.tabControl1.Location = new System.Drawing.Point(-2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(385, 435);
            this.tabControl1.TabIndex = 0;
            // 
            // tabClientes
            // 
            this.tabClientes.Controls.Add(this.label1);
            this.tabClientes.Controls.Add(this.Cerrar);
            this.tabClientes.Controls.Add(this.buttonGuardarCliente);
            this.tabClientes.Controls.Add(this.textLicencia);
            this.tabClientes.Controls.Add(this.textApellido);
            this.tabClientes.Controls.Add(this.textInicial);
            this.tabClientes.Controls.Add(this.textNombre);
            this.tabClientes.Controls.Add(this.Licencia);
            this.tabClientes.Controls.Add(this.Apellido);
            this.tabClientes.Controls.Add(this.Inicial);
            this.tabClientes.Controls.Add(this.Nombre);
            this.tabClientes.Location = new System.Drawing.Point(4, 22);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientes.Size = new System.Drawing.Size(377, 409);
            this.tabClientes.TabIndex = 0;
            this.tabClientes.Text = "Clientes";
            this.tabClientes.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Registro de nuevos Clientes";
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(293, 369);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 17;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // buttonGuardarCliente
            // 
            this.buttonGuardarCliente.Location = new System.Drawing.Point(11, 369);
            this.buttonGuardarCliente.Name = "buttonGuardarCliente";
            this.buttonGuardarCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardarCliente.TabIndex = 16;
            this.buttonGuardarCliente.Text = "Guardar";
            this.buttonGuardarCliente.UseVisualStyleBackColor = true;
            this.buttonGuardarCliente.Click += new System.EventHandler(this.buttonGuardarCliente_Click);
            // 
            // textLicencia
            // 
            this.textLicencia.Location = new System.Drawing.Point(116, 193);
            this.textLicencia.MaxLength = 7;
            this.textLicencia.Name = "textLicencia";
            this.textLicencia.Size = new System.Drawing.Size(100, 20);
            this.textLicencia.TabIndex = 7;
            this.textLicencia.TextChanged += new System.EventHandler(this.textLicencia_TextChanged);
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(116, 160);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(100, 20);
            this.textApellido.TabIndex = 6;
            // 
            // textInicial
            // 
            this.textInicial.Location = new System.Drawing.Point(116, 127);
            this.textInicial.MaxLength = 1;
            this.textInicial.Name = "textInicial";
            this.textInicial.Size = new System.Drawing.Size(100, 20);
            this.textInicial.TabIndex = 5;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(116, 94);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 20);
            this.textNombre.TabIndex = 4;
            // 
            // Licencia
            // 
            this.Licencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Licencia.AutoSize = true;
            this.Licencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Licencia.Location = new System.Drawing.Point(10, 184);
            this.Licencia.Margin = new System.Windows.Forms.Padding(2);
            this.Licencia.Name = "Licencia";
            this.Licencia.Size = new System.Drawing.Size(102, 29);
            this.Licencia.TabIndex = 3;
            this.Licencia.Text = "Licencia";
            // 
            // Apellido
            // 
            this.Apellido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Apellido.AutoSize = true;
            this.Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellido.Location = new System.Drawing.Point(10, 151);
            this.Apellido.Margin = new System.Windows.Forms.Padding(2);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(102, 29);
            this.Apellido.TabIndex = 2;
            this.Apellido.Text = "Apellido";
            this.Apellido.Click += new System.EventHandler(this.Apellido_Click);
            // 
            // Inicial
            // 
            this.Inicial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Inicial.AutoSize = true;
            this.Inicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inicial.Location = new System.Drawing.Point(10, 118);
            this.Inicial.Margin = new System.Windows.Forms.Padding(2);
            this.Inicial.Name = "Inicial";
            this.Inicial.Size = new System.Drawing.Size(75, 29);
            this.Inicial.TabIndex = 1;
            this.Inicial.Text = "Inicial";
            // 
            // Nombre
            // 
            this.Nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(10, 85);
            this.Nombre.Margin = new System.Windows.Forms.Padding(2);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(101, 29);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre";
            this.Nombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabVendedores
            // 
            this.tabVendedores.Controls.Add(this.label2);
            this.tabVendedores.Controls.Add(this.button2);
            this.tabVendedores.Controls.Add(this.buttonGuardarVendedores);
            this.tabVendedores.Controls.Add(this.textVendedoresApellido);
            this.tabVendedores.Controls.Add(this.textInicialVendedor);
            this.tabVendedores.Controls.Add(this.textNombreVendedor);
            this.tabVendedores.Controls.Add(this.ApellidoVendedor);
            this.tabVendedores.Controls.Add(this.InicialVendedor);
            this.tabVendedores.Controls.Add(this.NombreVendedor);
            this.tabVendedores.Location = new System.Drawing.Point(4, 22);
            this.tabVendedores.Name = "tabVendedores";
            this.tabVendedores.Padding = new System.Windows.Forms.Padding(3);
            this.tabVendedores.Size = new System.Drawing.Size(377, 409);
            this.tabVendedores.TabIndex = 1;
            this.tabVendedores.Text = "Vendedores";
            this.tabVendedores.UseVisualStyleBackColor = true;
            this.tabVendedores.Click += new System.EventHandler(this.tabVendedores_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Registro de nuevos Vendedores";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(293, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonGuardarVendedores
            // 
            this.buttonGuardarVendedores.Location = new System.Drawing.Point(11, 369);
            this.buttonGuardarVendedores.Name = "buttonGuardarVendedores";
            this.buttonGuardarVendedores.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardarVendedores.TabIndex = 17;
            this.buttonGuardarVendedores.Text = "Guardar";
            this.buttonGuardarVendedores.UseVisualStyleBackColor = true;
            this.buttonGuardarVendedores.Click += new System.EventHandler(this.button1_Click);
            // 
            // textVendedoresApellido
            // 
            this.textVendedoresApellido.Location = new System.Drawing.Point(116, 160);
            this.textVendedoresApellido.Name = "textVendedoresApellido";
            this.textVendedoresApellido.Size = new System.Drawing.Size(100, 20);
            this.textVendedoresApellido.TabIndex = 14;
            // 
            // textInicialVendedor
            // 
            this.textInicialVendedor.Location = new System.Drawing.Point(116, 127);
            this.textInicialVendedor.MaxLength = 1;
            this.textInicialVendedor.Name = "textInicialVendedor";
            this.textInicialVendedor.Size = new System.Drawing.Size(100, 20);
            this.textInicialVendedor.TabIndex = 13;
            // 
            // textNombreVendedor
            // 
            this.textNombreVendedor.Location = new System.Drawing.Point(116, 94);
            this.textNombreVendedor.Name = "textNombreVendedor";
            this.textNombreVendedor.Size = new System.Drawing.Size(100, 20);
            this.textNombreVendedor.TabIndex = 12;
            // 
            // ApellidoVendedor
            // 
            this.ApellidoVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ApellidoVendedor.AutoSize = true;
            this.ApellidoVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApellidoVendedor.Location = new System.Drawing.Point(10, 151);
            this.ApellidoVendedor.Margin = new System.Windows.Forms.Padding(2);
            this.ApellidoVendedor.Name = "ApellidoVendedor";
            this.ApellidoVendedor.Size = new System.Drawing.Size(102, 29);
            this.ApellidoVendedor.TabIndex = 10;
            this.ApellidoVendedor.Text = "Apellido";
            // 
            // InicialVendedor
            // 
            this.InicialVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.InicialVendedor.AutoSize = true;
            this.InicialVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InicialVendedor.Location = new System.Drawing.Point(10, 118);
            this.InicialVendedor.Margin = new System.Windows.Forms.Padding(2);
            this.InicialVendedor.Name = "InicialVendedor";
            this.InicialVendedor.Size = new System.Drawing.Size(75, 29);
            this.InicialVendedor.TabIndex = 9;
            this.InicialVendedor.Text = "Inicial";
            // 
            // NombreVendedor
            // 
            this.NombreVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NombreVendedor.AutoSize = true;
            this.NombreVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreVendedor.Location = new System.Drawing.Point(10, 85);
            this.NombreVendedor.Margin = new System.Windows.Forms.Padding(2);
            this.NombreVendedor.Name = "NombreVendedor";
            this.NombreVendedor.Size = new System.Drawing.Size(101, 29);
            this.NombreVendedor.TabIndex = 8;
            this.NombreVendedor.Text = "Nombre";
            // 
            // tabCalibre
            // 
            this.tabCalibre.Controls.Add(this.button3);
            this.tabCalibre.Controls.Add(this.button1);
            this.tabCalibre.Controls.Add(this.textCalibre);
            this.tabCalibre.Controls.Add(this.label4);
            this.tabCalibre.Controls.Add(this.label3);
            this.tabCalibre.Location = new System.Drawing.Point(4, 22);
            this.tabCalibre.Name = "tabCalibre";
            this.tabCalibre.Size = new System.Drawing.Size(377, 409);
            this.tabCalibre.TabIndex = 2;
            this.tabCalibre.Text = "Calibres";
            this.tabCalibre.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 369);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textCalibre
            // 
            this.textCalibre.Location = new System.Drawing.Point(116, 94);
            this.textCalibre.Name = "textCalibre";
            this.textCalibre.Size = new System.Drawing.Size(100, 20);
            this.textCalibre.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 29);
            this.label4.TabIndex = 21;
            this.label4.Text = "Calibre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Registro de nuevos Calibres";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tabInventario
            // 
            this.tabInventario.Location = new System.Drawing.Point(4, 22);
            this.tabInventario.Name = "tabInventario";
            this.tabInventario.Size = new System.Drawing.Size(377, 409);
            this.tabInventario.TabIndex = 3;
            this.tabInventario.Text = "Inventario";
            this.tabInventario.UseVisualStyleBackColor = true;
            this.tabInventario.Click += new System.EventHandler(this.tabInventario_Click);
            // 
            // tabMarcas
            // 
            this.tabMarcas.Controls.Add(this.button5);
            this.tabMarcas.Controls.Add(this.button4);
            this.tabMarcas.Controls.Add(this.label6);
            this.tabMarcas.Controls.Add(this.textMarcas);
            this.tabMarcas.Controls.Add(this.label5);
            this.tabMarcas.Location = new System.Drawing.Point(4, 22);
            this.tabMarcas.Name = "tabMarcas";
            this.tabMarcas.Size = new System.Drawing.Size(377, 409);
            this.tabMarcas.TabIndex = 4;
            this.tabMarcas.Text = "Marcas";
            this.tabMarcas.UseVisualStyleBackColor = true;
            // 
            // tabModelos
            // 
            this.tabModelos.Controls.Add(this.button7);
            this.tabModelos.Controls.Add(this.button6);
            this.tabModelos.Controls.Add(this.textModelo);
            this.tabModelos.Controls.Add(this.label8);
            this.tabModelos.Controls.Add(this.label7);
            this.tabModelos.Location = new System.Drawing.Point(4, 22);
            this.tabModelos.Name = "tabModelos";
            this.tabModelos.Size = new System.Drawing.Size(377, 409);
            this.tabModelos.TabIndex = 5;
            this.tabModelos.Text = "Modelos";
            this.tabModelos.UseVisualStyleBackColor = true;
            // 
            // tabOrdenes
            // 
            this.tabOrdenes.Controls.Add(this.label9);
            this.tabOrdenes.Controls.Add(this.comboBox1);
            this.tabOrdenes.Location = new System.Drawing.Point(4, 22);
            this.tabOrdenes.Name = "tabOrdenes";
            this.tabOrdenes.Size = new System.Drawing.Size(377, 409);
            this.tabOrdenes.TabIndex = 6;
            this.tabOrdenes.Text = "Ordenes";
            this.tabOrdenes.UseVisualStyleBackColor = true;
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Registro de nueva Marca";
            // 
            // textMarcas
            // 
            this.textMarcas.Location = new System.Drawing.Point(116, 94);
            this.textMarcas.Name = "textMarcas";
            this.textMarcas.Size = new System.Drawing.Size(100, 20);
            this.textMarcas.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 29);
            this.label6.TabIndex = 23;
            this.label6.Text = "Marca";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(11, 369);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "Guardar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(293, 369);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 25;
            this.button5.Text = "Cerrar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(297, 29);
            this.label7.TabIndex = 22;
            this.label7.Text = "Registro de nuevo Modelo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 29);
            this.label8.TabIndex = 23;
            this.label8.Text = "Modelo";
            // 
            // textModelo
            // 
            this.textModelo.Location = new System.Drawing.Point(116, 94);
            this.textModelo.Name = "textModelo";
            this.textModelo.Size = new System.Drawing.Size(100, 20);
            this.textModelo.TabIndex = 24;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(11, 369);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 25;
            this.button6.Text = "Guardar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(293, 369);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 26;
            this.button7.Text = "Cerrar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(133, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 29);
            this.label9.TabIndex = 1;
            this.label9.Text = "Cliente";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 438);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Formulario Armeria Rasec";
            this.tabControl1.ResumeLayout(false);
            this.tabClientes.ResumeLayout(false);
            this.tabClientes.PerformLayout();
            this.tabVendedores.ResumeLayout(false);
            this.tabVendedores.PerformLayout();
            this.tabCalibre.ResumeLayout(false);
            this.tabCalibre.PerformLayout();
            this.tabMarcas.ResumeLayout(false);
            this.tabMarcas.PerformLayout();
            this.tabModelos.ResumeLayout(false);
            this.tabModelos.PerformLayout();
            this.tabOrdenes.ResumeLayout(false);
            this.tabOrdenes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabClientes;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TabPage tabVendedores;
        private System.Windows.Forms.TabPage tabCalibre;
        private System.Windows.Forms.TabPage tabInventario;
        private System.Windows.Forms.TabPage tabMarcas;
        private System.Windows.Forms.TabPage tabModelos;
        private System.Windows.Forms.TabPage tabOrdenes;
        private System.Windows.Forms.Label Licencia;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.Label Inicial;
        private System.Windows.Forms.TextBox textLicencia;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textInicial;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textVendedoresApellido;
        private System.Windows.Forms.TextBox textInicialVendedor;
        private System.Windows.Forms.TextBox textNombreVendedor;
        private System.Windows.Forms.Label ApellidoVendedor;
        private System.Windows.Forms.Label InicialVendedor;
        private System.Windows.Forms.Label NombreVendedor;
        private System.Windows.Forms.Button buttonGuardarCliente;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.Button buttonGuardarVendedores;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider error1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textCalibre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textMarcas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textModelo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

