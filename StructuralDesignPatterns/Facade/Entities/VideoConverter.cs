namespace FacadePattern.Entities
{
    internal class VideoConverter
    {
        protected MPEG4CompressionCodec _mpeg4CompressionCodec;
        protected CodecFactory _codecFactory;

        public VideoConverter(MPEG4CompressionCodec mpeg4CompressionCodec, CodecFactory codecFactory)
        {
            this._mpeg4CompressionCodec = mpeg4CompressionCodec;
            this._codecFactory = codecFactory;
        }

        public string Convert(string fileName, string fileExtension)
        {
            string result = $"Convert file {fileName} to file type {fileExtension}\n";

            result += this._mpeg4CompressionCodec.MPEG4CompressionCodecOperationOne();
            result += this._codecFactory.CodecFactoryOperationOne();
            result += this._mpeg4CompressionCodec.MPEG4CompressionCodecOperationTwo();
            result += this._codecFactory.CodecFactoryOperationTwo();

            return result;
        }
    }
}
