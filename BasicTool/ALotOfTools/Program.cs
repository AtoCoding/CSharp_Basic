namespace ALotOfTools
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Function 1: Summing Number Range ( 1 - 100 )");
            Console.WriteLine("Result: " + SumNumberRange(1, 100));

            Console.WriteLine("Function 2: Summing Odd Number Range ( 1 - 10000 )");
            Console.WriteLine("Result: " + SumOddNumberRange(1, 10000));

            Console.WriteLine("Function 3: Calculate combination ( n = 10, k = 8 )");
            Console.WriteLine("Result: " + CalculateCombination(10, 8));

            Console.WriteLine("Function 4: Compare a, b, c ( 5, 4, 8 )");
            Console.WriteLine("Result: " + CompareABC(5, 4, 8));

            Console.WriteLine("Function 5: Summing ASCII ( Text: FptUniversity )");
            Console.WriteLine("Result: " + SumASCII("FptUniversity"));


            Console.ReadLine();
        }

        static int SumNumberRange(int a, int b)
        {
            /*int result = 0;*/
            /*for(int i = a; i <= b; i++)
            {
                result += i;
            }*/
            if (b == a) return b;
            return SumNumberRange(a, b - 1) + b;
        }

        static int SumOddNumberRange(int a, int b)
        {
            int result = 0;
            for(int i = a; i <= b; i++)
            {
                if(i % 2 == 0)
                {
                    result += i;
                }
            }
            return result;
        }

        static double CalculateCombination(int n, int k)
        {
            double result = 0;
            result = Factorial(n);
            result /= (Factorial(k) * Factorial(n - k));
            return result;
        }

        static double Factorial(int x)
        {
            if (x == 1) return 1;
            return Factorial(x - 1) * x;
        }

        static String CompareABC(int a, int b, int c)
        {
            List<int> result = new List<int>();
            result.Add(a);
            result.Add(b);
            result.Add(c);
            result.Sort();
            result.Reverse();

            String resultStr = "";
            for(int i = 0; i < result.Count; i++)
            {
                if(a == result[i])
                {
                    if (i == result.Count - 1) resultStr += "a = ";
                    else resultStr += "a,";
                } 
                else if(b == result[i])
                {
                    if (i == result.Count - 1) resultStr += "b = ";
                    else resultStr += "b,";
                }
                else if(c == result[i])
                {
                    if (i == result.Count - 1) resultStr += "c = ";
                    else resultStr += "c,";
                }
            }
            for(int i = 0; i < result.Count; i++)
            {
                if (i == result.Count - 1) resultStr += result[i];
                else resultStr += result[i] + ",";
            }
            return resultStr;
        }
    
        static int SumASCII(String str)
        {
            char tmp;
            int result = 0;
            for(int i = 0; i < str.Length; i++)
            {
                tmp = Convert.ToChar(str[i]);
                result += (int)tmp;
            }
            return result;
        }
    }
}