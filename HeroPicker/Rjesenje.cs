﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroPicker
{
    class Rjesenje
    {
        public int id_heroj;

        public void Hendlanje(int id2)
        {
            id_heroj = id2;
        }
    }
    public static class baze_put
    {
        public static string datasource = "data source = C:\\Users\\Roberto\\source\\repos\\HeroPicker\\HeroPicker\\HeroPicker_DB.db";
    }
}
