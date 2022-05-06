using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int demo;
            int[] Array1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("请输入一个数字：");
            demo = int.Parse(Console.ReadLine());
            Console.WriteLine("你输入的值为："+ demo);

            if (demo % 2 == 0)
                Console.WriteLine("该值为偶数");
            else
                Console.WriteLine("该值为奇数");


            if (demo < 100)
                Console.WriteLine("低级");
            else if (demo < 200)
                Console.WriteLine("中级");
            else if (demo < 300)
                Console.WriteLine("高级");
            else
                Console.WriteLine("有挂");


            switch (demo)
            {
                case 100:
                    Console.WriteLine("低级");
                    break;

                case 200:
                    Console.WriteLine("中级");
                    break;

                case 300:
                    Console.WriteLine("高级");
                    break;
                default:
                    Console.WriteLine("有挂");
                    break;
            }
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write(Array1[i] + "\t");
                //Console.Write("\t");
                sum +=  Array1[i];
            }
            Console.WriteLine("sum=" + sum);

            for (int j = 1; j < 10; j++)
            {
                for (int k = 1; k <= j; k++)
                    Console.Write(k + "x" + j + "=" + j*k +"\t");
                Console.WriteLine();
            }
            int g = 0,sum1 = 0;
            while (g < 10)
            {
                sum1 += g;
                g++;
            }
            Console.WriteLine(sum1);
            int l = 0, sum2 = 0;
            do
            {
                sum2 += l;
                l++;
                
                if (l == 4)
                    continue;
                Console.WriteLine(l);
            } while (l < 10);
            Console.WriteLine(sum2);

        }
    }
}
