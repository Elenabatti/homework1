//Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество четных чисел в массиве.
Console.Clear();
 Console.WriteLine("Введите размерность массива: ");
 int n = int.Parse(Console.ReadLine());
 int [] nums = new int [n];
 int sum = 0;
 for (int i =0; i <n; i++){
    nums[i] = new Random().Next(100, 999);
    Console.WriteLine($"{nums[i]},");
     if (nums [i]%2==0) sum++;
 
 Console.WriteLine($" -> {sum}");

 }
