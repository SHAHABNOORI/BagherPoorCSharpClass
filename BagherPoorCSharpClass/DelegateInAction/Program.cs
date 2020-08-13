using System;
using DelegateSample;

namespace DelegateInAction
{
    class Program
    {
        static void Main(string[] args)
        {
            Image image = new Image("c:\\a.jpg");
            ImageProcessor imageProcessor = new ImageProcessor();
            imageProcessor.Process(image);
        }
    }
}
