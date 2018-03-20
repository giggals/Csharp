using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Stream_Progress
{
    public class StreamProgressInfo
    {
        private IStreamProgres Stream;

        // If we want to stream a music file, we can't
        public StreamProgressInfo(IStreamProgres stream)
        {
            this.Stream = stream;
        }

        public int CalculateCurrentPercent()
        {
            return (this.Stream.BytesSent * 100) / this.Stream.Length;
        }
    }
}
