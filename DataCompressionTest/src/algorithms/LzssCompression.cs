using System.IO;

/*
   Original code by Haruhiko Okumura, 4/6/1989.
   12-2-404 Green Heights, 580 Nagasawa, Yokosuka 239, Japan.
   http://oku.edu.mie-u.ac.jp/~okumura/compression/lzss.c

   Modified for use in C# by Rubens Vicente de Liz Bomer.

   Use, distribute, and modify this code freely.
*/

namespace DataCompressionTest.src.algorithms
{
    class LzssCompression : CompressionIF
    {

        private ushort EI = 11; /* typically 10..13 */
        private ushort EJ = 4;  /* typically 4..5 */
        private uint P = 1;     /* If match length <= P then output one character */
        private uint N;         /* buffer size */
        private uint F;         /* lookahead buffer size */

        private int bit_buffer = 0;
        private int bit_mask = 128;
        private int codecount = 0;
        private int textcount = 0;
        byte[] buffer;

        private FileStream inFileStream;
        private FileStream outFileStream;

        static int bufStatic = 0;
        static int maskStatic = 0;

        public LzssCompression()
        {
            N = (uint)(1 << EI);
            F = ((uint)(1 << EJ) + 1);
            buffer = new byte[N * 2];
        }

        private void putbit1()
        {
            bit_buffer |= bit_mask;

            if ((bit_mask >>= 1) == 0)
            {
                outFileStream.WriteByte((byte)bit_buffer);

                bit_buffer = 0;
                bit_mask = 128;
                codecount++;
            }
        }

        private void putbit0()
        {
            if ((bit_mask >>= 1) == 0)
            {
                outFileStream.WriteByte((byte)bit_buffer);

                bit_buffer = 0;
                bit_mask = 128;
                codecount++;
            }
        }

        private void flush_bit_buffer()
        {
            if (bit_mask != 128)
            {
                outFileStream.WriteByte((byte)bit_buffer);
                codecount++;
            }
        }

        private void output1(uint c)
        {
            uint mask;

            putbit1();
            mask = 256;

            while ((mask >>= 1) != 0)
            {
                if ((c & mask) != 0) putbit1();
                else putbit0();
            }
        }

        private void output2(uint x, uint y)
        {
            uint mask;

            putbit0();
            mask = N;

            while ((mask >>= 1) != 0)
            {
                if ((x & mask) != 0) putbit1();
                else putbit0();
            }

            mask = (uint)(1 << EJ);

            while ((mask >>= 1) != 0)
            {
                if ((y & mask) != 0) putbit1();
                else putbit0();
            }
        }

        private int getbit(int n) /* get n bits */
        {
            int i, x;

            x = 0;

            for (i = 0; i < n; i++)
            {
                if (maskStatic == 0)
                {
                    bufStatic = inFileStream.ReadByte();
                    if (bufStatic == -1) return -1;

                    maskStatic = 128;
                }

                x <<= 1;

                if ((bufStatic & maskStatic) != 0) x++;

                maskStatic >>= 1;
            }
            return x;
        }

        public int Compress(string inputURL, string outputURL)
        {
            inFileStream = new FileStream(inputURL, FileMode.Open, FileAccess.Read);
            outFileStream = new FileStream(outputURL + Path.GetFileNameWithoutExtension(inFileStream.Name) + ".lzss", FileMode.Create, FileAccess.Write);

            uint j, f1, x, y, r, s, bufferend;
            int i, c = 0;

            for (i = 0; i < N - F; i++) buffer[i] = 0;

            for (i = (int)(N - F); i < N * 2; i++)
            {
                c = inFileStream.ReadByte();
                if (c == -1) break;

                buffer[i] = (byte)c;
                textcount++;
            }

            bufferend = (uint)i; r = N - F; s = 0;

            while (r < bufferend)
            {
                f1 = (F <= bufferend - r) ? F : bufferend - r;
                x = 0; y = 1; c = buffer[r];

                for (i = (int)(r - 1); i >= s; i--)
                    if (buffer[i] == (byte)c)
                    {
                        for (j = 1; j < f1; j++)
                            if (buffer[i + j] != buffer[r + j]) break;

                        if (j > y)
                        {
                            x = (uint)i; y = j;
                        }
                    }

                if (y <= P) { y = 1; output1((uint)c); }
                else output2(x & (N - 1), y - 2);

                r += y; s += y;

                if (r >= N * 2 - F)
                {
                    for (i = 0; i < N; i++) buffer[i] = buffer[i + N];

                    bufferend -= N; r -= N; s -= N;

                    while (bufferend < N * 2)
                    {
                        c = inFileStream.ReadByte();
                        if (c == -1) break;

                        buffer[bufferend++] = (byte)c;
                        textcount++;
                    }
                }
            }

            flush_bit_buffer();

            outFileStream.Close();
            inFileStream.Close();

            return codecount;
        }

        public int Decompress(string inputURL, string outputURL)
        {
            inFileStream = new FileStream(inputURL, FileMode.Open, FileAccess.Read);
            outFileStream = new FileStream(outputURL, FileMode.Create, FileAccess.Write);

            uint k, r;
            int i, j, c;

            for (i = 0; i < N - F; i++) buffer[i] = 0;

            r = N - F;

            while ((c = getbit(1)) != -1)
            {
                if (c != 0)
                {
                    if ((c = getbit(8)) == -1) break;

                    outFileStream.WriteByte((byte)c);
                    buffer[r++] = (byte)c;
                    r &= (N - 1);
                }
                else
                {
                    i = getbit(EI);
                    if (i == -1) break;

                    j = getbit(EJ);
                    if (j == -1) break;

                    for (k = 0; k <= j + 1; k++)
                    {
                        c = buffer[(i + k) & (N - 1)];
                        outFileStream.WriteByte((byte)c);
                        buffer[r++] = (byte)c;
                        r &= (N - 1);
                    }
                }
            }

            int size = (int)outFileStream.Length;

            outFileStream.Close();
            inFileStream.Close();

            return size;
        }
    }
}
