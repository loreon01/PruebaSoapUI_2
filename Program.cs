using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSoapUI_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SoapUI.CountryInfoService client = new SoapUI.CountryInfoService();

            var respuesta = client.FullCountryInfoAllCountries();

            Console.WriteLine(respuesta.First().sName);
            Console.WriteLine(respuesta.First().sContinentCode);
            Console.WriteLine(respuesta.First().sCurrencyISOCode);
            Console.Read();
        }
    }
}
