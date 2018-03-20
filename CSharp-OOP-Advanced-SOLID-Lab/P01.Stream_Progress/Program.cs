using System;

namespace P01.Stream_Progress
{
    public class Program
    {
        static void Main()
        {
            Music music = new Music("Lili Ivanova", "Vetrove", 53, 100);
            StreamProgressInfo musicStream = new StreamProgressInfo(music);

            File file = new File("text.txt", 45, 100);
            StreamProgressInfo fileStream = new StreamProgressInfo(file);
           
            
        }
    }
}
