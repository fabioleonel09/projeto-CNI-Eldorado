using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaCNIeldorado
{
    class Conexao
    {
        public SqlConnection cn = new SqlConnection();

        public void conectar()
        {
            cn.ConnectionString = @"Data Source=PARTICULAR;Initial Catalog=AgendaCNIeldorado;Integrated Security=True";
            cn.Open();
        }

        public void desconectar()
        {
            cn.Close();
        }
    }
}
