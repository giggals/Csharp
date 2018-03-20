namespace P01.Stream_Progress
{
    public class File : IStreamProgres
    {
        private string name;

        public File(string name, int length, int bytesSent)
        {
            this.name = name;
            this.BytesSent = bytesSent;
            this.Length = length;
        }
        
        public int BytesSent { get; }

        public int Length { get; }
    }
}
