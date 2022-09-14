// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечетных позиция
Console.Clear();
Console.Write("Введите размер массива: ");
int n = int.Parse(Console.ReadLine());
int [] array = new int [n];
int sum = 0;
for (int i=0; i<n;i++){
    array[i] = new Random().Next(1, 10);
    Console.Write($"{array [i]}");
    if (i%2!=0)
    sum+=array[i];
}
Console.WriteLine($" ->{sum++}");
