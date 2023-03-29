using System;
using System.Collections.Generic;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        { 
                string ss="Merhaba,bu bir testtir.";
                string ss2="test";

                Console.WriteLine(ss.ToUpper());
                Console.WriteLine(ss.ToLower());
                Console.WriteLine(ss.CompareTo(ss2));
                Console.WriteLine(ss.Contains(ss2));
                Console.WriteLine(String.Concat(ss,"--",ss2));
                Console.WriteLine(ss.IndexOf("st"));
                Console.WriteLine(ss2.PadRight(3,'*'));// ss2 karakter sayısından düşükse birşey yapmaz
                Console.WriteLine(ss2.PadRight(10,'*'));//karakter sayısından başlayıp yazılan değere kadar doldurur
                Console.WriteLine(ss2.PadRight(ss2.Length+1,'*'));
                Console.WriteLine(ss2.PadLeft(ss2.Length+1,'*'));
                Console.WriteLine(ss2.PadLeft(ss2.Length+10,'*'));
                Console.WriteLine(ss2.Remove(1));// index 1 den sona kadar sil
                Console.WriteLine(ss2.Remove(0,2));//0-2 arasını sil
                Console.WriteLine(ss.Replace('b','B'));
                Console.WriteLine(ss.Split(',')[0]);
                Console.WriteLine(ss.Split(',')[1]);
                Console.WriteLine(ss.Split(',')[2]);// , ayracından sonra 1 obje var Merhaba=0,bu bir testtir =1 
        }

    }

}