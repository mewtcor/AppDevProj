using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistryIS
{
    class DrProfileClass
    {
        //===================================================================================
        SqlConnection conn;
        SqlCommand cmd;
        string connstr = ConfigurationManager.ConnectionStrings["DentistryDB"].ConnectionString;
        //===================================================================================

        public Tuple<string, string, string,string> DatProfile()
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("select * from Users where Username='" + Globals.CurrentUserName + "'", conn);

            conn.Open();
            var rd = cmd.ExecuteReader();
            
                while (rd.Read())
                {
                    string name = rd["Name"].ToString();
                    string contactno = rd["Contact"].ToString();
                    string address = rd["Address"].ToString();
                    string uaccess = rd["UAccess"].ToString();
                    conn.Close();
                    return Tuple.Create(name, contactno, address, uaccess);
                }
                conn.Close();
                return null;
            
        }
    }
}
