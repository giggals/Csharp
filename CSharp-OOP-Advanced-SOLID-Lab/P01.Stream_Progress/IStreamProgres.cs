using System;
using System.Collections.Generic;
using System.Text;


public interface IStreamProgres
{
    int BytesSent { get; }

    int Length { get; }
}

