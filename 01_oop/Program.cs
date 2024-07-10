using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_oop;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How old are you? ");
        float age = float.Parse(Console.ReadLine());
        Console.WriteLine("Hello, World!");
        Console.WriteLine("I'm " + age + " years old.");
        Console.WriteLine(age);
    }
}