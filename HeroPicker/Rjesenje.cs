using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroPicker
{
    public static class baze_put
    {
        public static string datasource = "data source = C:\\Users\\Roberto\\source\\repos\\HeroPicker\\HeroPicker\\HeroPicker_DB.db";
    }
    public static class id_korisnik
    {
        public static int id_kor;

        public static void login(int id)
        {
            id_kor = id;
        }
    }
}
