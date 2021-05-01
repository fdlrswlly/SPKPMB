using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SPKPMB_Apps
{
    class Koneksi
    {
        public static SqlConnection Conn = new SqlConnection("Data Source = LAPTOP-VH6CET7D\\FADHLY; initial catalog = db_PMB; integrated security = true");
         public static SqlConnection Connect = new SqlConnection("Data Source = LAPTOP-VH6CET7D\\FADHLY; initial catalog = db_PMB; integrated security = true");
    }
}
