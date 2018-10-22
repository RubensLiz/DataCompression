namespace DataCompressionTest.src.algorithms
{
    public enum CompressType
    {
        LZSS = 0
    }

    public static class CompressionFactory
    {
        public static CompressionIF CreateAlgorithm(CompressType type)
        {
            switch (type)
            {
                case CompressType.LZSS:
                    return new LzssCompression();
                default:
                    return null;
            }
        }
    }
}
