﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace TPVF
{
    public class konekcija
    {

        static public SqlConnection Connect()
        {
            SqlConnection conn = new SqlConnection(
            WebConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
            return conn;
        }

        /*
        static string myServer = Environment.MachineName;
        static string CS = ("Data Source= " + myServer + " ;Initial Catalog= KB ;Integrated Security=True;MultipleActiveResultSets=True");
        static public SqlConnection Connect()
        {
            SqlConnection conn = new SqlConnection(CS);
            return conn;
        }
        */
    }
}