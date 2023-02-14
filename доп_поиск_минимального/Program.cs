Console.Clear();
Console.WriteLine("Введите значение n: ");
int n = int.Parse(Console.ReadLine());

int[] array = GetRandomArray(10, 0, n);
Console.WriteLine(String.Join(" ", array));

int[] GetRandomArray(int size,int minValue,int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
        {
        result[i] = new Random().Next(minValue,maxValue+1);
        }
    return result;
}
    

int minFind (int[] array)
{
int min = array[0];
for (int j = 1; j < array.Length; j++)
    {
    if (min > array[j])
    {
        min = array[j];
    }
    }
return min;
}
Console.WriteLine($"Минимальное значение = {minFind (array)}"); 