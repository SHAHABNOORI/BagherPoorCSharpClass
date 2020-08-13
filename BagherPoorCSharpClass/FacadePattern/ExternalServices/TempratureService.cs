namespace FacadePattern.ExternalServices
{
    public class TempratureService
    {
        public double GetTemp(int zone) => zone * 1.3;
    }
}