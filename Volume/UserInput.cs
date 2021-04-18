using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volume
{
    public class UserInput
    {
        public static int TryParseInput()
        {
            int OutVal = 0;
            while (OutVal <= 0)
            {
                if (!int.TryParse(Console.ReadLine(), out OutVal))
                {
                    Console.WriteLine("Введенное значение не является целым числом, повторите ввод:");
                }
                else if (OutVal <= 0)
                {
                    Console.WriteLine("Введенное значение не является положительным числом, повторите ввод:");
                } 
            }
            return OutVal;
        }
    }
}
