using System;
namespace alg_lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = "";//переменная для выбора действия
            do
            {
                try
                {
                    Console.WriteLine();
                    Console.Write("ВЫБЕРИТЕ НОМЕР НУЖНОГО ДЕЙСТВИЯ\n" +
                    "1. Решить 1 задачу\n" +
                    "2. Решить 2 задачу\n" +
                    "3. Решить 3 задачу\n" +
                    "4. Выход из программы\n" +
                    "ВВЕДИТЕ НОМЕР ДЕЙСТВИЯ: ");
                    num = Console.ReadLine();
                    switch (num)
                    {
                        case "1":
                            Zad1();
                            break;
                        case "2":
                            Zad2();
                            break;
                        case "3":
                            Zad3();
                            break;
                        case "4":
                            Console.WriteLine("ВЫХОД ИЗ ПРОГРАММЫ");
                            break;
                        default:
                            Console.WriteLine("НЕВЕРНЫЙ ВВОД");
                            Console.WriteLine();
                            break;
                    }
                }
                catch (FormatException) //проверка на некорректный ввод
                {
                    Console.WriteLine("ВВЕДЕНО НЕ ЧИСЛО");
                    //пустая строка для лучшей читаемости между строками
                    Console.WriteLine();
                    continue;
                }
            } while (num != "4");
            //цикл нужен для удобства, дабы не выходить постоянно из консоли
        }
        static void Zad1()
        {
            //пустая строка для лучшей читаемости между строками
            Console.WriteLine();
            Console.WriteLine("Решение задачи 1");

            Console.Write("ВВЕДИТЕ СТОИМОСТЬ: ");
            //ввод стоимости
            double stoimost = double.Parse(Console.ReadLine());

            Console.Write("ВВЕДИТЕ СКИДКУ В ПРОЦЕНТАХ: ");
            //ввод скидки
            double skidka = double.Parse(Console.ReadLine());

            //расчёт стоимости скидки
            double stskidka = stoimost * skidka / 100;

            //расчёт новой стоимости
            double newstoimost = stoimost - stskidka;

            //пустая строка для лучшей читаемости между строками
            Console.WriteLine();

            //вывод сообщения с результатами
            Console.WriteLine($"Таким образом, покупка со скидкой будет стоить: {newstoimost:F2}\n");

        }
        static void Zad2()
        {
            //пустая строка для лучшей читаемости между строками
            Console.WriteLine();
            Console.WriteLine("Решение задачи 2");

            Console.Write("ВВЕДИТЕ СТОИМОСТЬ: ");
            //ввод стоимости
            double stoimost = double.Parse(Console.ReadLine());

            Console.Write("ВВЕДИТЕ СКИДКУ В ПРОЦЕНТАХ: ");
            //ввод скидки
            double skidka = double.Parse(Console.ReadLine());

            //расчёт стоимости скидки
            double stskidka = stoimost * skidka / 100;

            //пустая строка для лучшей читаемости между строками
            Console.WriteLine();

            //вывод сообщения с результатами
            Console.WriteLine($"Сумма скидки будет составлять: {stskidka:f2}");
        }
        static void Zad3()
        {
            //пустая строка для лучшей читаемости между строками
            Console.WriteLine();
            Console.WriteLine("Решение задачи 3");

            Console.Write("ВВЕДИТЕ СТОИМОСТЬ: ");
            //ввод стоимости
            double stoimost = double.Parse(Console.ReadLine());

            Console.Write("ВВЕДИТЕ СКИДКУ В ПРОЦЕНТАХ: ");
            //ввод скидки
            double skidka = double.Parse(Console.ReadLine());

            //расчёт стоимости скидки
            double stskidka = stoimost * skidka / 100;

            //расчёт новой стоимости
            double newstoimost = stoimost - stskidka;

            //расчёт разницы между ценами в процентах
            double raznica = newstoimost / stoimost * 100;

            //расчёт количества товаров
            double tovar = stoimost / newstoimost;

            //пустая строка для лучшей читаемости между строками
            Console.WriteLine();

            //вывод сообщения с результатами
            Console.WriteLine($"Таким образом, новая цена будет составлять {raznica:f2}% от старой\n" +
                $"По скидочной цене на изначальную сумму можно будет купить товаров: {tovar:f2}");

        }
    }
}


