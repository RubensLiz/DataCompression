namespace DataCompressionTest.src.algorithms
{
    public enum CompressionType
    {
        LZSS = 0
    }

    public static class CompressionFactory
    {
        public static CompressionIF CreateAlgorithm(CompressionType type)
        {
            switch (type)
            {
                case CompressionType.LZSS:
                    return new LzssCompression();
                default:
                    return null;
            }
        }
    }
}
