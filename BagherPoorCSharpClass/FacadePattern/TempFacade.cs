using FacadePattern.ExternalServices;

namespace FacadePattern
{
    public class TempFacade
    {
        public double GetTempByS(string postalCode)
        {
            ZoneFinder zoneFinder = new ZoneFinder();
            var zone = zoneFinder.GetZone("454545");
            TempratureService service = new TempratureService();
            var tempF = service.GetTemp(zone);
            TempConvertor convertor = new TempConvertor();
            var tempS = convertor.GetS(tempF);
            return tempS;
        }
    }
}