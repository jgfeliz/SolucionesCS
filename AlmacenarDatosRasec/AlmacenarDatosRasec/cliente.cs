using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenarDatosRasec
{
    public class cliente
    {
        //public Int16 Clientes_Id { get; set; }
        public String Clientes_Nombre { get; set; }
        public String Clientes_Inicial { get; set; }
        public String Clientes_Apellido { get; set; }
        public int Clientes_LicendiaDeArmas { get; set; }

        public cliente() { }

        public cliente (String pClientes_Nombre, String pClientes_Inicial, String pClientes_Apellido, int pClientes_LicendiaDeArmas)
        {
            //this.Clientes_Id = pClientes_id;
            this.Clientes_Nombre = pClientes_Nombre;
            this.Clientes_Inicial = pClientes_Inicial;
            this.Clientes_Apellido = pClientes_Apellido;
            this.Clientes_LicendiaDeArmas = pClientes_LicendiaDeArmas;
                     
        }
    }

    public class vendedores
    {
        //public Int16 Clientes_Id { get; set; }
        public String Vendedores_Nombre { get; set; }
        public String Vendedores_Inicial { get; set; }
        public String Vendedores_Apellido { get; set; }
        

        public vendedores() { }

        public vendedores(String pVendedores_Nombre, String pVendedores_Inicial, String pVendedores_Apellido)
        {
            //this.Clientes_Id = pClientes_id;
            this.Vendedores_Nombre = pVendedores_Nombre;
            this.Vendedores_Inicial = pVendedores_Inicial;
            this.Vendedores_Apellido = pVendedores_Apellido;
                       
        }
    }
}
