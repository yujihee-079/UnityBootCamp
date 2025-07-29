using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number = 33;
            string result = "charlie";
            Console.WriteLine($"{result}의 나이는 {number}입니다.");
      
      

            string message = string.Format("{0}의 나이는, {1}입니다", "홍길동", "23살");
            Console.WriteLine(message);

            // 문제 87~94

            int a = 15;
            int b = 3;
            Console.WriteLine( a + b );

            int c = 43;
            int d = 15;
            Console.WriteLine(c % d );

            int e = 7;
            int f = 88;
            bool answer = e > f;
            Console.WriteLine(answer);

            bool aa = false;
            bool bb = true;
            bool cc = aa && bb;
            Console.WriteLine(cc);

            float g = 83.04f;
            float h = 79.03f;
            Console.WriteLine(g+h);

            string msg = string.Format("{0} + {1}", "banana", "engine");
            Console.WriteLine(msg);

            bool i = true;
            bool j = !i;
            Console.WriteLine(j);

            // 94번 문제
            int k = 21;
            float l = k;
            Console.WriteLine(l);

            /*int ib = 73;
            int ij = 13;
            Console.WriteLine(ib%ij);

            float tt = 66.6f;
            float gg = 83.01f;
            Console.WriteLine(tt+gg);*/





             
            







        }
    }
}