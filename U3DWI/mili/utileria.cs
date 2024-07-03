using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.IO.Ports;
using System.Security.Cryptography;
namespace mili
{
    public class utileria
    {
        public static DataSet Ejecutar(string com)
        {
            MySqlConnection con = new MySqlConnection("Server=127.0.0.1; Database = patito; Uid = root; Pwd = ; ");
            con.Open();
            DataSet ds = new DataSet();
            MySqlDataAdapter dp = new MySqlDataAdapter(com, con);
            dp.Fill(ds);
            con.Close();
            return ds;
        }

        public static DataSet Ejecutar(MySqlCommand cmd)
        {
            throw new NotImplementedException();
        }
    }
}
