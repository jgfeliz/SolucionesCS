using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenarDatosRasec
{
    public class cliente
    {        
        public String Clientes_Nombre { get; set; }
        public String Clientes_Inicial { get; set; }
        public String Clientes_Apellido { get; set; }
        public int Clientes_LicendiaDeArmas { get; set; }

        public cliente() { }

        public cliente (String pClientes_Nombre, String pClientes_Inicial, String pClientes_Apellido, int pClientes_LicendiaDeArmas)
        {            
            this.Clientes_Nombre = pClientes_Nombre;
            this.Clientes_Inicial = pClientes_Inicial;
            this.Clientes_Apellido = pClientes_Apellido;
            this.Clientes_LicendiaDeArmas = pClientes_LicendiaDeArmas;
                     
        }
    }

    public class vendedores
    {
        public String Vendedores_Nombre { get; set; }
        public String Vendedores_Inicial { get; set; }
        public String Vendedores_Apellido { get; set; }        

        public vendedores() { }

        public vendedores(String pVendedores_Nombre, String pVendedores_Inicial, String pVendedores_Apellido)
        {            
            this.Vendedores_Nombre = pVendedores_Nombre;
            this.Vendedores_Inicial = pVendedores_Inicial;
            this.Vendedores_Apellido = pVendedores_Apellido;
                                   
        }
    }

    public class calibre
    {
        public String Calibres_Calibres { get; set; }
        
        public calibre() { }

        public calibre(String pCalibres_Calibres)
        {            
            this.Calibres_Calibres = pCalibres_Calibres;
            
        }
    }

    public class marcas
    {
        public String Marcas_Marcas { get; set; }

        public marcas() { }

        public marcas(String pMarcas_Marcas)
        {
            this.Marcas_Marcas = pMarcas_Marcas;

        }
    }

    public class modelos
    {
        public String Modelos_Modelos { get; set; }

        public modelos() { }

        public modelos(String pModelos_Modelos)
        {
            this.Modelos_Modelos = pModelos_Modelos;

        }
    }

    public class inventario
    {
        public String Inventario_Marcas_Id { get; set; }
        public String Inventario_Modelos_Id { get; set; }
        public String Inventario_Calibres_Id { get; set; }
        public String Inventario_NumeroDeSerie { get; set; }
        public String Inventario_Costo { get; set; }
        public String Inventario_Precio { get; set; }
        
        public inventario() { }

        public inventario(String pInventario_Marcas_Id, String pInventario_Modelos_Id, String pInventario_Calibres_Id, String pInventario_NumeroDeSerie,
            String pInventario_Costo, String pInventario_Precio)
        {
            this.Inventario_Marcas_Id = pInventario_Marcas_Id;
            this.Inventario_Modelos_Id = pInventario_Modelos_Id;
            this.Inventario_Calibres_Id = pInventario_Calibres_Id;
            this.Inventario_NumeroDeSerie = pInventario_NumeroDeSerie;
            this.Inventario_Costo = pInventario_Costo;
            this.Inventario_Precio = pInventario_Precio;

        }
    }
}
