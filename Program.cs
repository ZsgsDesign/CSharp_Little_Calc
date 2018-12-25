using System;

namespace C_
{
    class Program
    {
        static int seqSum(int n)
        {
            int sum=0;
            for(int i=1;i<=n;i++)
            {
                sum+=i;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.Write("Please input a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please input b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            multi multipler=new multi();
            multipler.puts(a,b);
            Console.Write("\na*b = ");
            Console.WriteLine(multipler.gets());
            Console.WriteLine(seqSum(100));
        }
    }

    class multi
    {
        int a;
        int b;

        public void puts(int temp_a, int temp_b)
        {
            a = temp_a;
            b = temp_b;
        }

        public int gets()
        {
            return a * b;
        }
    }
}
