﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Base
{
    public class Connection
    {

        public MySqlConnection Create()
        {
            string connectionString = "server=localhost; database=CatiorosDB; uid=root; password=1234; SslMode=none";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }

    }
}
