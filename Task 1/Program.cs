Console.WriteLine("Введите число a: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int number2 = int.Parse(Console.ReadLine());
int sqr = number2*number2;
if (sqr == number1) {
    Console.WriteLine($"{number1} является квадратом числа {number2}");
}
else {
    Console.WriteLine($"{number1} не является квадратом числа {number2}");
}