using System;

namespace DelegateSample
{
    public class ImageProcessor
    {
        public delegate void ImageFilterHandler(Image image);
        public delegate string ImageFilterHandlerVersionTwo(Image image);

        public void Process(Image image, ImageFilterHandler filterHandler)
        {
            filterHandler.Invoke(image);
        }

        public string Process(Image image, ImageFilterHandlerVersionTwo filterHandler)
        {
            var result= filterHandler.Invoke(image);
            return result;
        }


        public void Process(Image image, Action<Image> handler)
        {
            handler.Invoke(image);
        }

        public string Process(Image image, Func<Image,string> handler)
        {
           var result= handler(image);
           return result;
        }


        public void Process(Image image)
        {
            ImageFilter filter = new ImageFilter();
            filter.ApplyBrightness(image);
            filter.ApplyContrast(image);
            filter.Resize(image);
            filter.RemoveRedEye(image);
        }
    }
}