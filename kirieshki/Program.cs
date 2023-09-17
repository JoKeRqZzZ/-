namespace кириешки1;

class Program
{
    static void Main()
    {
        double number1, number2;
        int vibordeystviya;

        do
        {
            Console.WriteLine("Выберите действие");
            Console.WriteLine("1 - Сложение 2-ух чисел");
            Console.WriteLine("2 - Вычитание первого числа из второго");
            Console.WriteLine("3 - Умножение 2-ух чисел");
            Console.WriteLine("4 - Деление первого числа на второе");
            Console.WriteLine("5 - Возвести в степень N первое число");
            Console.WriteLine("6 - Найти квадратный корень из числа");
            Console.WriteLine("7 - Найти 1 процент от числа");
            Console.WriteLine("8 - Найти факториал из числа");
            Console.WriteLine("9 - Выйти из программы");
            vibordeystviya = Convert.ToInt32(Console.ReadLine());

            switch (vibordeystviya)

            {
                case 1:
                    Console.WriteLine("Введите number1");
                    number1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите number2");
                    number2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Результат сложения двух чисел = " + (number1 + number2));
                    break;
                case 2:
                    Console.WriteLine("Введите number1");
                    number1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите number2");
                    number2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Результат вычитания первого числа из второго = " + (number2 - number1));
                    break;
                case 3:
                    Console.WriteLine("Введите number1");
                    number1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите number2");
                    number2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Результат умножения двух чисел двух чисел = " + (number1 * number2));
                    break;
                case 4:
                    Console.WriteLine("Введите number1");
                    number1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите number2");
                    number2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Результат деления первого числа на второе = " + (number1 / number2));
                    break;
                case 5:
                    Console.WriteLine("Введите number1");
                    number1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите степень в которую возвести первое число");
                    int stepen = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Результат возведения первого числа в степень = " + Math.Pow(number1, stepen));
                    break;
                case 6:
                    Console.WriteLine("Введите number1");
                    number1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Квадратный корень из первого числа = " + Math.Sqrt(number1));
                    break;
                case 7:
                    Console.WriteLine("Введите number1");
                    number1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(" 1% от первого числа = " + (number1 / 100));
                    break;
                case 8:
                    Console.WriteLine("Введите number1");
                    number1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Факториал первого числа = " + Factorial(number1));
                    break;
                case 9:
                    Console.WriteLine("КОНЕЦ");
                    break;
                default:
                    Console.WriteLine("неверно");
                    break;
            }
            Console.WriteLine();
        } while (vibordeystviya != 9);

    }
    static double Factorial(double num)
    {
        double result = 1;
        for (int i = 1; i <= num; i++)
        {
            result *= i;
        }
        return result;
    }
}

