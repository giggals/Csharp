using System;
using System.Collections.Generic;
using System.Text;


public class GraphicEditor
{
    public void DrawShape(IShape Shape)
    {
        Console.WriteLine($"I am {Shape.Shape}");
    }
}

