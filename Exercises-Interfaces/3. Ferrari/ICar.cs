using System;
using System.Collections.Generic;
using System.Text;


interface ICar
{
    string DriverName { get; }

    string Model { get; }

     string UseBreaks();

    string UseGaz();
}

