using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LojahAbc
{
    internal class conectado
    {
        private static string stringConectado = "Server=localhost;port=3306;Database=dbTransformese;Uid=root;Pwd=''";
        private static MySqlConnection conec = null;

        public static MySqlConnection obterConexao()
        {
            conec = new MySqlConnection(stringConectado);
            try
            {
                conec.Open();
            }
            catch (Exception)
            {
                conec = null;
            }
            return conec;
        }
        public static void fechaConexao()
        {
            if (conec != null)
            {
                conec.Close();
            }
        }
    }
}
