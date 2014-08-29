using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Singletonprove
{
    class Catalog
    {
        //singleton instance
        private static Catalog catalog = new Catalog();
        private static Catalog cat2 = new Catalog();
        // private static Catalog catalog;



        private List<string> strenge = new List<string>();
        private int _size;

        public static Catalog GetIntance()
        {
            //if(catalog == null) catalog = new Catalog();
            return catalog;
        }



        private Catalog()
        {
            
        }



        public string skrivdb()
        {
            string datahentet = "";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\mikkel\documents\visual studio 2013\Projects\Singletonprove\Singletonprove\Database1.mdf;Integrated Security=True");
            SqlDataReader reader;
            SqlCommand command = new SqlCommand("SELECT name FROM data WHERE name ='jens'");
            command.CommandType = CommandType.Text;
            command.Connection = con;

            con.Open();
            reader = command.ExecuteReader();
            reader.Read();
            datahentet = reader.GetString(0);
            con.Close();

            return datahentet;


        }

        public void add(string s)
        {
            strenge.Add(s);
            _size = strenge.Count;
        }

        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }
    }
}
