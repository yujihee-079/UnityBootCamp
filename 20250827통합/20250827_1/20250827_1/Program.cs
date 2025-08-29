namespace CSharp
{
    class Point
    {
        public int x;
        public int y;
    }

    class Program
    {


        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 1;
            p1.y = 2;

            Point p2 = p1;
            p2 = p1;
            p2.x = 5;
            p2.y = 6;



            Console.WriteLine($"{p1.x} {p1.y}\n{p2.x} {p2.y}");
        }
    }
}