
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

namespace dr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter word: ");
            string word = Console.ReadLine();
            char[] duma = word.ToCharArray();
            int mid = duma.Length / 2;
            int i = 0;
            int j = duma.Length - 1;
            bool result = false;
            if (duma.Length % 2 == 1)
                
            for (i = 0; i < mid; i++)
            {
                    if (duma[i] == duma[duma.Length - 1 - i])
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
            }
            if (result)
            {
                Console.WriteLine(word);
            }
        }
    }
}


//if (duma.Length % 2 == 1)
//{
//    for (i = 0; i <= mid; i++)
//    {
//        for (j = duma.Length - 1; j >= mid; j--)
//        {

//        }
//    }
//}

//do
//{
//    for (i = 0; i < duma.Length; i++)
//    {


//        for (j = duma.Length - i; j <= 0; j++)
//        {
//            if (duma[i] == duma[j])
//            {

//            }
//        }
//    }

//}
//while (duma)