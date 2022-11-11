namespace Classes;
class Program
{
    public static void Main()
    {
        #region task1 HelloWorld
        //Console.WriteLine("Hello World!");
        #endregion

        #region task2 Greeting

        /*Console.WriteLine("Enter Your Name: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello {name}, how are you?");*/

        #endregion

        #region task3 Special Greeting
        /*if (name == "Alica" || name == "Bob")
            Console.WriteLine($"Hello {name}, how are you?");*/
        #endregion

        #region task4 Sum
        /*int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"{1 + n}");*/
        #endregion Conditional Sum

        #region task5 Conditional Sum
        /*int m = int.Parse(Console.ReadLine());
        if (m % 3 == 0 || m % 5 == 0)
            Console.WriteLine($"{1 + n}");*/
        #endregion

        #region task6 Sum or Product
        /*Console.WriteLine("Enter the number: ");
        int f = int.Parse(Console.ReadLine());
        Console.WriteLine("1.Sum    2.Product");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            long Sum = (1 + f) * f / 2;
            Console.WriteLine(Sum);
        }
        else if (choice == 2)
        {
            long Product = Factorial(f);
            Console.WriteLine(Product);
        }*/
        #endregion

        #region task7 Multiplication Table
        /*for (int i = 1; i <= 12; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i}*{j}={i * j}");
            }
            Console.WriteLine();
        }*/
        #endregion

        #region task8 Prime numbers

        /*Console.WriteLine("Enter the limit: ");
        int a = int.Parse(Console.ReadLine());
        for (int i = 2; i <= a; i++)
        {
            if (IsPrime(i)) Console.WriteLine(i);
            else continue;
        }*/
        #endregion

        #region task9 Guessing the number
        /*int tries = GuessNumber();
        Console.WriteLine(tries);*/
        #endregion

        #region task10 Leap Year
        /*int firstLeapYear = 1752;
        int theNextLeapYear = 2024;
        for (int i = 1; i <= 20; i++)
        {
            int leapYear = theNextLeapYear + (i - 1) * 4;
            Console.WriteLine(leapYear);
        }*/
        #endregion

        #region task11 Two Sum
        /*Console.WriteLine("Enter the elements of an array.");
        string[] stringArr = Console.ReadLine().Split();
        int[] intArr = Array.ConvertAll(stringArr, s => int.Parse(s));
        Console.WriteLine("Enter the Target.");
        int target = int.Parse(Console.ReadLine());
        List<int> lst1 = new();
        for(int i=0; i<intArr.Length; i++)
        {
            for(int j=i+1; j<intArr.Length-1; j++)
            {
                if(intArr[i] + intArr[j] == target)
                {
                    if (!lst1.Contains(i) && !lst1.Contains(j))
                    {
                        lst1.Add(i);
                        lst1.Add(j);
                        Console.WriteLine($"[{i}, {j}]");
                    }
                    
                }
            }
        }*/
        #endregion

        #region Reverse Words in a String III

        /*Console.WriteLine("Enter the string sentence.");
        string str = Console.ReadLine()!;
        var reversedWords = string.Join(" ", str.Split(' ').Select(x => new String(x.Reverse().ToArray())));
        Console.WriteLine("The reverced string.");
        Console.WriteLine(reversedWords); */
        #endregion
    }
    public static long Factorial(int f)
    {
        if (f == 0)
            return 1;
        else
            return f * Factorial(f - 1);
    }
    public static bool IsPrime(int i)
    {
        for (int j = 2; j * j <= i; j++)
        {
            if (i % j == 0)
            {
                return false; break;
            }
        }
        return true;
    }
    public static int GuessNumber()
    {
        int tries = 0, randNum, guessedNum;
        List<int> lst = new();
        do
        {
            Console.WriteLine("Enter the guessed number between 1 and 10: ");
            guessedNum = int.Parse(Console.ReadLine());
            if (!lst.Contains(guessedNum))
            {
                tries++;
                lst.Add(guessedNum);
            }
            Random random = new Random();
            randNum = random.Next(1, 10);
            if (randNum > guessedNum) Console.WriteLine("Too Samll.");
            else if (randNum < guessedNum) Console.WriteLine("Too Large.");
        } while (randNum != guessedNum) ;
        return tries;
    }
}