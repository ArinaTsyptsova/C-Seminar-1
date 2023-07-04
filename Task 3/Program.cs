// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Введите число N: ");
int number = int.Parse(Console.ReadLine());
number = Math.Abs(number);

Console.WriteLine("Целые числа в промежутке от -{0} до {0}:", number);

for (int i=-number; i<number; i++){
    Console.Write(i + ", ");
}
Console.Write(number);