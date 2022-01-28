using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace KartSkills.Global
{
    public class SqlHelper
    {
        static SqlConnection connection = new SqlConnection("Data Source=DESKTOP-A5KFUB3\\BUBOCHKA;Initial Catalog=Karting;Persist Security Info=True;User ID=sa;Password=1234567890");
        private static SqlDataAdapter dataAdapter;

        public static DataTable GetTableFromSql(string querry)
        {
            connection.Open();
            dataAdapter = new SqlDataAdapter(querry, connection);
            DataSet data = new DataSet();
            dataAdapter.Fill(data);
            DataTable table = data.Tables[0];
            connection.Close();

            return table;
        }
    }
}
