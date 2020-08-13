namespace SingletonPattern
{
    public class SiteSetting
    {
        private static readonly SiteSetting Instance = new SiteSetting();

        public static SiteSetting GetInstanceSetting()
        {
            return Instance;
        }


        public string SiteName { get; set; } = "Hello World";

        private SiteSetting()
        {

        }
    }
}