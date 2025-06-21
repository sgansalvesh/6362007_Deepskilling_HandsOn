using System;

namespace ProxyPatternExample
{
    public interface IImage
    {
        void Display();
    }

    public class RealImage : IImage
    {
        private string _filename;

        public RealImage(string filename)
        {
            _filename = filename;
            LoadFromRemoteServer();
        }

        private void LoadFromRemoteServer()
        {
            Console.WriteLine($"Loading image '{_filename}' from remote server...");
        }

        public void Display()
        {
            Console.WriteLine($"Displaying image '{_filename}'");
        }
    }

    public class ProxyImage : IImage
    {
        private string _filename;
        private RealImage _realImage;

        public ProxyImage(string filename)
        {
            _filename = filename;
        }

        public void Display()
        {
            if (_realImage == null)
            {
                _realImage = new RealImage(_filename);
            }
            _realImage.Display();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IImage image1 = new ProxyImage("nature1.jpg");
            IImage image2 = new ProxyImage("nature2.jpg");

            image1.Display();
            image1.Display();

            image2.Display();
        }
    }
}
