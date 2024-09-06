using System;
using System.Text;

namespace CSharplight
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            int quantity;
            Console.WriteLine("Введите число,сколько раз будет выведена фраза:");
            quantity = Convert.ToInt32(Console.ReadLine());
            while (quantity-- > 0)
            {
                Console.WriteLine("Кратос бегает по горам");
            }
        }
    }
}