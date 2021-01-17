using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DortIslem dortıslem = new DortIslem(); //Dortislem tipinde bir dortişlem tanımladık.Sonra dortişlemin bize verdiği özelliği kullandık
            dortıslem.Topla(2, 4);
        }
    }
}
