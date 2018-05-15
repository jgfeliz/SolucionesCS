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
                .
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
}
