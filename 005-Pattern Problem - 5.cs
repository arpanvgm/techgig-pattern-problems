using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class CandidateCode
{
    static void Main(String[] args)
    {
        //Write code here
        var input = int.Parse(Console.ReadLine());
        for (int i = 1; i <= input; i++)
        {
            for (int j = 1; j < 6; j++)
            {
                if (j > 1)
                {
                    Console.Write(' ');
                }
                Console.Write((char)(j + 64));
            }
            Console.WriteLine();
        }

    }
}
