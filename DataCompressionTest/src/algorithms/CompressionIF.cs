namespace DataCompressionTest.src.algorithms
{
    public interface CompressionIF
    {
        int Compress(string inputURL, string outputURL);
        int Decompress(string inputURL, string outputURL);
    }
}
