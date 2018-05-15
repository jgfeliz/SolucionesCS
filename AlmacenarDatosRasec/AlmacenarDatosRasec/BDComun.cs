using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AlmacenarDatosRasec
{
    class BDComun
    {
        private static SqlConnection Conn;
        public static SqlConnection ObtenerConexion()
        {
            try
            {
                //string Source = @"D-B4X1LK1\SQLEXPRESS";
                Conn = new SqlConnection("server= D-B4X1LK1\\SQLEXPRESS; database= RAbreu15; User Id= sa; Password = 1234; integrated security = false");
                Conn.Open();                            

            }
            catch (Exception EX)
            {

                MessageBox.Show("Error, "+ EX.Message, "Error...");
            }

            return Conn;
        }
    }
}
