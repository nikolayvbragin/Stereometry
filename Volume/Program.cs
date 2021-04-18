using System;

namespace Volume
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Создание куба-контейнера");
                Console.WriteLine("Введите высоту ребра куба:");
                   int boxHeight = UserInput.TryParseInput();
                Console.WriteLine($"Задана высота ребра куба-контейнера: {boxHeight}");
                   Box mainBox = new Box(boxHeight);
                Console.WriteLine($"Объем куба-контейнера {mainBox.Volume()}");
                Console.WriteLine();
            
            Console.WriteLine("Заполнение куба-контейнера");
            bool check=true;
            do
            {
               // Shape newShape;

                Console.WriteLine("Выберите фигуру: \n 1 - шар \n 2 - цилиндр \n 3 - пирамида \n 4 - куб");

                switch (UserInput.TryParseInput())
                {
                    case 1:
                        Console.WriteLine("ШАР, введите радиус:");
                           int _rBall = UserInput.TryParseInput();
                    //  newShape = new Ball(_r);
                          check = mainBox.Add(new Ball(_rBall));
                        Console.WriteLine($"Осталось места: {mainBox.FreeVolume()}");
                        break;
                    case 2:
                        Console.WriteLine("ЦИЛИНДР, введите высоту:");
                            int _cylinderH = UserInput.TryParseInput();
                        Console.WriteLine("Введите радиус основания:");
                            int _cylinderR = UserInput.TryParseInput();
                            check = mainBox.Add(new Cylinder(_cylinderR, _cylinderH));
                        Console.WriteLine($"Осталось места: {mainBox.FreeVolume()}");
                        break;
                    case 3:
                        Console.WriteLine("ПИРАМИДА, введите площадь основания:");
                            int _pyramidS = UserInput.TryParseInput();
                        Console.WriteLine("Введите высоту:");
                            int _pyramidH = UserInput.TryParseInput();
                            check = mainBox.Add(new Pyramid(_pyramidS, _pyramidH));
                        Console.WriteLine($"Осталось места: {mainBox.FreeVolume()}");
                        break;
                    case 4:
                        Console.WriteLine("КУБ, введите высоту ребра:");
                            int _boxEdge = UserInput.TryParseInput();
                            check = mainBox.Add(new Box(_boxEdge));
                        Console.WriteLine($"Осталось места: {mainBox.FreeVolume()}");
                        break;

                    default:
                        Console.WriteLine("Номер некорректен, повторите ввод");
                        break;
                }
                
            }
            

            while (check);

            Console.WriteLine("Для новой фигуры места недостаточно, заполнение завершено");
        }

    }
}
