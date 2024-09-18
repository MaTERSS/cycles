using System;
using System.Text;

namespace CSharplight
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            int quantity;
            Console.WriteLine("Введите предлложение");
            string offer = Console.ReadLine();
            Console.WriteLine("Введите число,сколько раз будет выведена фраза:");
            quantity = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < quantity; i++)            
            {
                Console.WriteLine(offer);
            }
            
        }
    }
}
