using System;

namespace lab2a
{
    class Program
    {
        //15. Создать класс четырехугольник, члены класса – координаты 4-х точек. 
        //Предусмотреть в классе методы вычисления и вывода сведений о фигуре – длины сторон, диагоналей, периметр, площадь. 
        //Создать производный класс – ромб, предусмотреть в классе проверку, является ли фигура ромбом. 
        //Написать программу, демонстрирующую работу с этими классами: дано N четырехугольников и M ромбов, 
        //найти четырехугольник с минимальным периметром и среднюю площадь ромбов. 

        //*На сайте сказано сделать без наследования, так что как я понимаю без третьего пункта- ромба.*

        
        static void Main(string[] args)
        {
            double Ax, Ay, Bx, By, Cx, Cy, Dx, Dy;
            double AB, BC, CD, AD;
            double AC, BD;
            double perimetr, square;
            // длина стороны через координаты= √((X2-X1)²+(Y2-Y1)²)
            double N;
            Console.WriteLine("Enter a number of N");
            double.TryParse(Console.ReadLine(), out N);
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Enter x of point A");
                double.TryParse(Console.ReadLine(), out Ax);
                Console.WriteLine("Enter y of point A");
                double.TryParse(Console.ReadLine(), out Ay);
                Console.WriteLine("Enter x of point B");
                double.TryParse(Console.ReadLine(), out Bx);
                Console.WriteLine("Enter y of point B");
                double.TryParse(Console.ReadLine(), out By);
                Console.WriteLine("Enter x of point C");
                double.TryParse(Console.ReadLine(), out Cx);
                Console.WriteLine("Enter y of point C");
                double.TryParse(Console.ReadLine(), out Cy);
                Console.WriteLine("Enter x of point D");
                double.TryParse(Console.ReadLine(), out Dx);
                Console.WriteLine("Enter y of point D");
                double.TryParse(Console.ReadLine(), out Dy);
                AB = Math.Sqrt((Bx - Ax) * (Bx - Ax) + (By - Ay) * (By - Ay));
                Console.WriteLine("AB = " + AB);
                BC = Math.Sqrt((Cx - Bx) * (Cx - Bx) + (Cy - By) * (Cy - By));
                Console.WriteLine("BC = "+BC);
                CD = Math.Sqrt((Dx - Cx) * (Dx - Cx) + (Dy - Cy) * (Dy - Cy));
                Console.WriteLine("CD = "+CD);
                AD = Math.Sqrt((Dx - Ax) * (Dx - Ax) + (Dy - Ay) * (Dy - Ay));
                Console.WriteLine("AD = "+AD);
                AC = AB * AB + BC * BC;
                Console.WriteLine("AC = "+AC);
                BD = AB * AB + AD * AD;
                Console.WriteLine("BD = "+BD);
                perimetr = (AB + BC) * 2;
                Console.WriteLine("Perimetr = " + perimetr);
                square = AB * BC;
                Console.WriteLine("Square = "+ square);
            }
        }

    }
}
