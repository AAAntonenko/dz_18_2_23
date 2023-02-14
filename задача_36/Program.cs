Console.Clear();

int[] array = GetRandomArray(5, 10, 100);
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
int findSum (int[] array)
{
int sum = 0;
for (int j = 1; j < array.Length; j=j+2)
{
    sum += array[j];
}
    return sum;
}
Console.WriteLine($"{findSum (array)}");
