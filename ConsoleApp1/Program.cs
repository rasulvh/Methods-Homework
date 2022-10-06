using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DivideInto3And7
            //Console.WriteLine(Divide(21));
            #endregion

            #region SumOfEvenNAndM
            //Sum(5, 8);
            #endregion

            #region CountOffOddNums
            //CountNums(15, 17);
            #endregion

            #region SumOfOddNums
            //SumOfEvenNums(1,5);
            #endregion

            #region SumOfOddNumsInArr
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 21, 32, 45, 52, 76, 75, 33, 66, 54 };
            //Console.WriteLine(SumOfOddNumsInArr(arr));
            #endregion

            #region CountOfEvenNumsInArr
            //int[] arr = { 3, 62, 124, 1, 43, 52, 31, 9 };
            //Console.WriteLine(CountOfEvenNumsInArr(arr));
            #endregion

            #region PrimeOrComplexNumber
            //Console.WriteLine(Answer(10));
            #endregion

            #region IsNPowerOf2
            //Console.WriteLine(Answer(32));
            #endregion

            #region FindSumOfElementsInArray
            //int[] arr = { 1, 4, 8, 123, 43, 32, 12 };
            //Console.WriteLine(Sum(arr));
            #endregion

            #region SquareOfEvenNumsInArray
            //int[] arr = { 4, 6, 1, 3 };
            //Console.WriteLine(SquareOfNums(arr));
            #endregion
        }

        #region DivideInto3And7
        //public static string Divide(int a)
        //{
        //    if (Check(a))
        //    {
        //        return "A ededi 3e ve 7e bolunur";
        //    }
        //    else
        //    {
        //        return "A ededi 3e ve 7e bolunmur";
        //    }
        //}

        //public static bool Check(int a)
        //{
        //    if (a % 3 == 0 && a % 7 == 0) 
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        #endregion

        #region SumOfEvenNAndM
        //public static void Sum(int m, int n)
        //{
        //    if (m % 2 == 0 && n % 2 == 0) 
        //    {
        //        int sum = m + n;
        //        Console.WriteLine(sum);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Duzgun ededler daxil edin");
        //    }
        //}
        #endregion

        #region CountOffOddNums
        //public static void CountNums(int n, int m)
        //{
        //    int count = 0;

        //    if (n > m)
        //    {
        //        Console.WriteLine("Zehmet olmasa duzgun ededler daxil edin");
        //    }
        //    else
        //    {
        //        for (int i = n; i < m; i++)
        //        {
        //            if (i % 2 == 1)
        //            {
        //                count++;
        //            }
        //        }
        //        Console.WriteLine(count);
        //    }
        //}
        #endregion

        #region SumOfEvenNums
        //public static void SumOfEvenNums(int n, int m)
        //{
        //    int sum = 0;

        //    if (n > m)
        //    {
        //        Console.WriteLine("Zehmet olmasa duzgun ededler daxil edin");
        //    }
        //    else
        //    {
        //        for (int i = n; i < m; i++)
        //        {
        //            if (i % 2 == 1)
        //            {
        //                sum+=i;
        //            }
        //        }
        //        Console.WriteLine(sum);
        //    }
        //}
        #endregion

        #region SumOfOddNumsInArr
        //public static int SumOfOddNumsInArr(int[] arr)
        //{
        //    int sum = 0;

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (Check(arr[i]))
        //        {
        //            sum += arr[i];
        //        }
        //    }
        //    return sum;
        //}

        //public static bool Check(int n)
        //{
        //    if (n % 2 == 1)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        #endregion

        #region CountOfEvenNumsInArr
        //public static int CountOfEvenNumsInArr(int[] arr)
        //{
        //    int count = 0;

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (Check(arr[i]))
        //        {
        //            count ++;
        //        }
        //    }
        //    return count;
        //}

        //public static bool Check(int n)
        //{
        //    if (n % 2 == 0)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        #endregion

        #region PrimeOrComplexNumber
        //public static string Answer(int num)
        //{
        //    if (num == 1 || num == 0) 
        //    {
        //        return $"{num} ne sade ne de murekkeb ededdir";
        //    }
        //    else if (Check(num))
        //    {
        //        return "Murekkeb ededdir";
        //    }
        //    return "Sade ededdir";
        //}

        //public static bool Check(int num)
        //{
        //    int count = 0;

        //    for (int i = 1; i < num; i++)
        //    {
        //        if (num % i == 0) 
        //        {
        //            count++;
        //        }
        //    }
        //    if (count >= 2) 
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        #endregion

        #region IsNPowerOf2
        //public static string Answer(int n)
        //{
        //    if (Check(n))
        //    {
        //        return $"{n} 2nin quvvetidir";
        //    }
        //    return $"{n} 2nin quvveti deyil";
        //}

        //public static bool Check(int n)
        //{
        //    int i = 2;

        //    while (i < n) 
        //    {
        //        i *= 2;
        //    }
        //    if (i == n)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        #endregion

        #region FindSumOfElementsInArray
        //public static int Sum(int[] arr)
        //{
        //    int sum = 0;

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] >= 1 && arr[i] <= 20)
        //        {
        //            sum += arr[i];
        //        }
        //    }
        //    return sum;
        //}
        #endregion

        #region SquareOfEvenNumsInArray
        //public static int SquareOfNums(int[] arr)
        //{
        //    int sum = 0;
        //    int square = 1;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] % 2 == 0)
        //        {
        //            sum += arr[i];
        //        }
        //    }
        //    square = sum * sum;
        //    return square;
        //}
        #endregion
    }
}