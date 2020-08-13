using System;

namespace DelegateSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Image image = new Image("c:\\a.jpg");
            ImageProcessor imageProcessor = new ImageProcessor();
            //ImageProcessor.ImageFilterHandler filterHandler = SetBlackWithFilter;
            //filterHandler += SetShatranji;
            //filterHandler += SetGreenBackground;
            ImageProcessor.ImageFilterHandlerVersionTwo filterHandler = SetBlackWithFilterWithoutput;
            filterHandler += SetGreenBackgroundWithoutput;
            filterHandler += SetShatranjiWithoutput;
            var result = imageProcessor.Process(image, filterHandler);
            //imageProcessor.Process(image, SetBlackWithFilter);
            //var result = imageProcessor.Process(image, SetBlackWithFilterVersionTwo);
        }


        static void SetBlackWithFilter(Image image)
        {
            Console.WriteLine("Black White filter applied");
        }

        static void SetShatranji(Image image)
        {
            Console.WriteLine("Shatranji filter applied");
        }

        static void SetGreenBackground(Image image)
        {
            Console.WriteLine(" Green Background filter applied");
        }


        static string SetBlackWithFilterWithoutput(Image image)
        {
            return ("Black White filter applied");
        }

        static string SetShatranjiWithoutput(Image image)
        {
            return ("Shatranji filter applied");
        }

        static string SetGreenBackgroundWithoutput(Image image)
        {
            return (" Green Background filter applied");
        }



        static string SetBlackWithFilterVersionTwo(Image image)
        {
            return "Black White filter applied";
        }
    }

}
