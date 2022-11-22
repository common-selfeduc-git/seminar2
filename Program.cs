//Задача 1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//78 -> 8
//12-> 2
//85 -> 8
Console.Write("Введите левое число отрезка: ");
int leftboard = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите правое число отрезка: ");
int rightboard = Convert.ToInt32(Console.ReadLine());
void Randomizer(int leftboard, int rightboard){
    Random rand = new Random();
    int number = rand.Next(leftboard, rightboard);
    int stager = number;
    int digit = 0;
    while (stager > 0) {
        if (stager % 10 > digit) {
            digit = stager % 10;
        }
        stager = stager / 10;
    }
    int[] a = new int[2];
    a[0] = number;
    a[1] = digit;
    Console.WriteLine($"{a[0]}  -> {a[1]}");
}
Randomizer(leftboard, rightboard);