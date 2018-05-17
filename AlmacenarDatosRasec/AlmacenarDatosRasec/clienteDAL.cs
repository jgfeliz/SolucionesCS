using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AlmacenarDatosRasec
{
    public class clienteDAL
    {
        public static int Agregar_clientes(cliente pCliente)
        {
            int retorno = 0;

            using (SqlConnection Conn = BDComun.ObtenerConexion())
            {
               SqlCommand Comando = new SqlCommand(string.Format("Insert Into Ger.Clientes (Clientes_Nombre, Clientes_Inicial, Clientes_Apellido, Clientes_LicenciaDeArmas) values ('{0}', '{1}', '{2}', {3})", pCliente.Clientes_Nombre, pCliente.Clientes_Inicial, pCliente.Clientes_Apellido, pCliente.Clientes_LicendiaDeArmas), Conn );

               retorno = Comando.ExecuteNonQuery();                
                
            }

            return retorno;
                       
        }
    }

    public class vendedoresDAL
    {
        public static int Agregar_vendedores(vendedores pVendedores)
        {
            int retorno = 0;

            using (SqlConnection Conn = BDComun.ObtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into Ger.Vendedores (Vendedores_Nombre, Vendedores_Inicial, Vendedores_Apellido) values ('{0}', '{1}', '{2}')", pVendedores.Vendedores_Nombre, pVendedores.Vendedores_Inicial, pVendedores.Vendedores_Apellido), Conn);

                retorno = Comando.ExecuteNonQuery();

            }

            return retorno;

        }
    }

    public class calibreDAL
    {
        public static int Agregar_calibre(calibre pCalibre)
        {
            int retorno = 0;

            using (SqlConnection Conn = BDComun.ObtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into Inv.Calibres (Calibres_Calibres) values ('{0}')", pCalibre.Calibres_Calibres), Conn);

                retorno = Comando.ExecuteNonQuery();

            }

            return retorno;

        }
    }

    public class marcasDAL
    {
        public static int Agregar_marcas(marcas pMarcas)
        {
            int retorno = 0;

            using (SqlConnection Conn = BDComun.ObtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into Inv.Marcas (Marcas_Marcas) values ('{0}')", pMarcas.Marcas_Marcas), Conn);

                retorno = Comando.ExecuteNonQuery();

            }

            return retorno;

        }
    }

    public class modelosDAL
    {
        public static int Agregar_modelos(modelos pModelos)
        {
            int retorno = 0;

            using (SqlConnection Conn = BDComun.ObtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into Inv.Modelos (Modelos_Modelos) values ('{0}')", pModelos.Modelos_Modelos), Conn);

                retorno = Comando.ExecuteNonQuery();

            }

            return retorno;

        }
    }

    public class inventarioDAL
    {
        public static int Agregar_inventario(inventario pInventario)
        {
            int retorno = 0;

            using (SqlConnection Conn = BDComun.ObtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into Inv.Inventario (Inventario_Marcas_Id, Inventario_Modelos_Id, Inventario_Calibres_Id, Inventario_NumeroDeSerie, Inventario_Costo, Inventario_Precio ) values ({0},{1},{2},'{3}','{4}','{5}')", pInventario.Inventario_Marcas_Id, pInventario.Inventario_Modelos_Id, pInventario.Inventario_Calibres_Id, pInventario.Inventario_NumeroDeSerie, pInventario.Inventario_Costo, pInventario.Inventario_Precio), Conn);
                                
        retorno = Comando.ExecuteNonQuery();

            }

            return retorno;

        }
    }
}
