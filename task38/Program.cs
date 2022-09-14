//Задайте массив вещественных чисел. Задайте разницу между максимальным и минимальным элементом массива
Console.Clear();
double[] FillArray()
{
    double [] mas = new double[10];
    Random r = new Random();
    for (int i = 0; i<mas.Length; i++){
        mas[i] = Convert.ToDouble(r.Next(0, 100)/10.0);
    }
    return mas;
}
void PrintArray(double[]mas){
    for(int i=0; i< mas.Length; i++){
        Console.WriteLine(mas[i]+ " ");
    }
    Console.WriteLine();
}
void DifMinMax(double[]mas){
    double max = mas[0];
    double min =mas[0];
     for (int i =0; i < mas.Length; i++){
        if (mas [i]> max) max = mas[i];
        if (mas [i]< min) min = mas[i];
}
Console.WriteLine($"Это максимальный элемент{max}");
Console.WriteLine($"Это минимальный элемент{min}");
Console.WriteLine($"Это разница между максимальным и минимальным значением{max - min}");
}
double [] array= FillArray();
PrintArray (array);
DifMinMax(array);