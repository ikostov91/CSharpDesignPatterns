using FacadePattern.Entities;

namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MPEG4CompressionCodec mpeg4CompressionCodec = new();
            CodecFactory codecFactory = new();

            // Facade class
            VideoConverter videoConverter = new(mpeg4CompressionCodec, codecFactory);
            
            Console.WriteLine(videoConverter.Convert("gameplay.ogg", "mp4"));
        }
    }
}