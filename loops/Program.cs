namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*String UserChoice = "";
            do
            {
                Console.WriteLine("Enter a number");
                int number = int.Parse(Console.ReadLine());
                int start = 0;
                while (start <= number)
                {
                    Console.Write(start + " ");
                    start += 2;
                }
                do
                {
                    Console.WriteLine("Do you want to continue say yes or no");
                    UserChoice = Console.ReadLine().ToUpper();
                    if (UserChoice != "YES" && UserChoice != "NO")
                    {
                        Console.WriteLine("Invalid Choice say yes or no");
                    }
                } while (UserChoice != "YES" && UserChoice != "NO");
            } while (UserChoice == "YES");*/
            /*int[] Number = new int[3];
            Number[0] = 1;
            Number[1] = 2;
            Number[2] = 3;
            foreach (int k in Number)
            {
                Console.WriteLine(k);
            }
            for (int i = 0; i < Number.Length; i++)
            {
                Console.WriteLine(Number[i]);
            }*/
            for (int i = 1; i <=20; i++)
            {
                //if(i==10)
                  //  break;
                if (i % 2 == 0)
                    continue;
                Console.WriteLine(i);
            }

        }
    }
}
