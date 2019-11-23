using System;
using System.Collections.Generic;
using SpiritsCollectionExmample;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Spirit s1 = new Spirit("Wyborowa", 0.4, 40, 0.7);
            Spirit s2 = new Spirit("Belvedere", 0.4, 130, 0.5);
            Spirit s3 = new Spirit("Jack Daniels Honey", 0.375, 180, 1.5);
            Spirit s4 = new Spirit("Sliwowica dziadka", 0.6, 10, 5);
            Spirit s5 = new Spirit("Wyborowa", 0.4, 40, 0.7);

            List<Spirit> list = new List<Spirit>();
            list.Add(s1);
            list.Add(s2);
            list.Add(s3);
            list.Add(s4);
            list.Add(s5);
            
            list.FindAll(s => s.AlcPercentage <= 0.4 && s.Volume > 0.7).ForEach(Console.WriteLine);
        }
    }
}