using System;
using System.IO;

namespace _4._Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var image = new FileStream("copyMe.png", FileMode.Open)) 
            {
                using (FileStream copy = new FileStream("result.png", FileMode.Create))
                {
                    while (true)
                    {
                        double bufferLenght = image.Length;
                        byte[] bytes =new byte[4096];
                        int readBytes = image.Read(bytes, 0, bytes.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }
                        copy.Write(bytes,0,bytes.Length);

                    }
                }
            }

        }
    }
}
