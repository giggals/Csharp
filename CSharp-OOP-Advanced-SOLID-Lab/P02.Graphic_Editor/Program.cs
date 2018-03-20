using P02.Graphic_Editor;
using System;


public class Program
{
    static void Main()
    {
        Rectangle rectangle = new Rectangle();
        Square square = new Square();
        Circle circle = new Circle();

        GraphicEditor graphicEditor = new GraphicEditor();

        graphicEditor.DrawShape(circle);

    }
}

