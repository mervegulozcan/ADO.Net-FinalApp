﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NT_ADO.Net_Son_Proje
{
    class Tools
    {
        public static string Connectionstring
        {
            get
            {
                return @"Data Source=WISSEN\MSSQLSRV;Initial Catalog=Northwind;User ID=sa;Password=12345srv";
            }
            
        }
    }
}
