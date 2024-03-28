namespace _016_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // (43장) x에서 y까지 합, 홀수 합, 역수 합

            // 1에서 100까지의 합
            int sum = 0;
            for(int i = 1; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine("1에서 100까지의 합은 {0}", sum);

            // 1에서 100까지의 홀수의 합
            int sum2 = 0;
            for(int i = 1; i <= 100; i++)
            {
                if (i % 2 == 1)
                    sum2 += i;
            }
            Console.WriteLine("1에서 100까지의 홀수의 합은 {0}", sum2);


            // 1에서 100까지의 역수의 합
            double sum3 = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum3 += 1.0 / i;
             
            }
            Console.WriteLine("1에서 100까지의 역수의 합 = " + sum3);


            // x에서 y까지의 합
            int sum4 = 0;
            Console.Write("x :");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y :");
            int y = int.Parse(Console.ReadLine());
            for(int i = x; i <= y; i++)
            {
                sum4 += i;
            }
            Console.WriteLine("{0}~{1}까지의 합 {2}", x, y, sum4);

            //x에서 y까지의 홀수의 합
            int sum5 = 0;
            Console.Write("x1 :");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("y1 :");
            int y1 = int.Parse(Console.ReadLine());
            for (int i = x1; i <= y1; i++)
            {
                if (i % 2 == 1)
                    sum5 += i;  
            }
            Console.WriteLine("{0}~{1}까지의 홀수의 합 {2}", x1, y1, sum5);

            // x에서 y까지의 역수의 합
            double sum6 = 0;
            Console.Write("x2 :");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("y2 :");
            int y2 = int.Parse(Console.ReadLine());
            for (int i = x2; i <= y2; i++)
            {
                sum6 += 1.0 / i;
            }
            Console.WriteLine("{0}~{1}까지의 합 {2}", x, y, sum6);

            // (45장) 구구단 

            // (47장) a의 b승
            Console.Write("a를 입력하세요 :");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b를 입력하세요 :");
            int b = int.Parse(Console.ReadLine());

            int pow = 1;
            for (int i = 0; i < b; i++)
            {
                pow *= a;
            }
            Console.WriteLine("{0}의 {1}승의 값은 {2}입니다.", a, b, pow);
                



            // (53장) 팩토리얼
        }
    }
}