using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SiteSetting setting = SiteSetting.GetInstanceSetting();
            setting.SiteName = "877878787878";
            Console.WriteLine(setting.SiteName);
        }
    }
}
