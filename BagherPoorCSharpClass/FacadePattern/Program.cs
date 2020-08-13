using System;
using FacadePattern.ExternalServices;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //ZoneFinder zoneFinder = new ZoneFinder();
            //var zone = zoneFinder.GetZone("454545");
            //TempratureService service = new TempratureService();
            //var tempF = service.GetTemp(zone);
            //TempConvertor convertor = new TempConvertor();
            //var tempS = convertor.GetS(tempF);
            //Console.WriteLine(tempS);
            TempFacade facade = new TempFacade();
            facade.GetTempByS("12121212");
        }
    }
}
