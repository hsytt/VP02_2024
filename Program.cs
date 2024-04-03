namespace _017_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            // (1) 원소를 모두 출력하시오
            // (1)-1 인덱스를 사용하기
            for (int i = 0; i < 10; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
            
            // (1)-2 foreach 사용
            foreach (var i in a)
                Console.Write(i + " ");
            Console.WriteLine();
            // (2) 원소의 합을 출력하시오
            // (2)-1 인덱스를 사용하기
            int sum = 0;
            for(int i=0; i<10; i++)
                sum += a[i];
            Console.WriteLine("합 = " + sum);
            
            // (2)-2 foreach 사용
            int sum2 = 0;
            foreach ( var value in a)
            {
                sum2 += value;
            }
            Console.WriteLine("합 = " + sum2);
            // (3) 가장 큰 값을 출력하시오
            int max = a[0];
            for (int i = 1; i < 10; i++)
                if (max < a[i])
                    max = a[i];
            Console.WriteLine("최대값 = " + max);
        }
    }
}