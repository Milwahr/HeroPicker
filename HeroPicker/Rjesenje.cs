using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroPicker
{
    //Staticke klase - klase koje se ne instanciraju
    public static class baze_put
    {
        //staticka varijabla - varijable koje zelimo uglavnom da se ne mjenjaju
        public static string datasource = "data source = C:\\Users\\Roberto\\source\\repos\\HeroPicker\\HeroPicker\\HeroPicker_DB.db";
    }
    public static class id_korisnik
    {
        //staticke varijeble
        public static int id_kor;
        public static string user_name;

        //staticke metoda/funkcija
        public static void login(int id)
        {
            id_kor = id;
        }
    }
}
