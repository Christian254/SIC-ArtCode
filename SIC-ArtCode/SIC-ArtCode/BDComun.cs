using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SIC_ArtCode
{
    public class BDComun
    {
        public static MySqlConnection Conectar()
        {
            MySqlConnection conector = new MySqlConnection("server=localhost; Database=contables; Uid=root; Password=''; port=3306");
                conector.Open();            
                          
            return conector;
        }
        
    }
}
