using EsLibrerie;
using MyStack;

namespace EsLibrerie
{
    class Program
    {
        static void Main(string[] args)
        {
            CStack<int> stack = new CStack<int>();
            int T, n;
            do { Console.Write("Numero di casi di test: ");
            } while (!Int32.TryParse(Console.ReadLine(), out T));
            do { Console.Write("Numero di torri: ");
            } while (!Int32.TryParse(Console.ReadLine(), out n));
            for(int i = 0; i < n; i++) {
                int s;
                do { Console.Write($"Altezza torre-{i}: ");
                } while (!Int32.TryParse(Console.ReadLine(), out s));
                stack.Push(s);
            }
            Console.WriteLine("\n");
            for (int i = 0; i < n; i++) // x ogni torre
            {
                CStack<int> newStack = new CStack<int>();
                int val = 1;
                int tmp = stack.Pop();
                bool ferma = false;
                while (!stack.IsEmpty())
                {
                    int nuovo = stack.Pop();
                    newStack.Push(nuovo);
                    if (nuovo <= tmp && !ferma) val++;
                    else ferma = true;
                }
                Console.WriteLine($"Range torre-{i}: {val}");
                while (!newStack.IsEmpty())
                {
                    int r = newStack.Pop();
                    stack.Push(r);
                }
            }
        }
    }
}
/*
namespace EsLibrerie
{
    using EsLibrerie;
    using MyStack;
    class P
    {
        static void Main(string[] args)
        {
            int T, n;
            Console.WriteLine("numero di casi di test");
            T = int.Parse(Console.ReadLine());
            for(int j=0; j<T; j++)
            {
                Console.WriteLine("numero di torri");
                n = int.Parse(Console.ReadLine());
                int[] heights = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                if(heights.Length != n)
                {

                }

                int[] ranges = new int[n];

                CStack<int> stack = new CStack<int>();
                for(int i = 0, i < n; i++)
                {
                    while(stack.GetSize() > 0 && heights[stack.Peek()] <= heights[i])
                        stack.Pop();
                    if(stack.GetSize() == 0)
                        ranges[i] = i + 1;
                    else
                        ranges[i] = i - stack.Peek();

                    stack.Push(i);

                    Console.WriteLine(string.Join(" ", ranges));
                }
            }
        }
    }
}
*/