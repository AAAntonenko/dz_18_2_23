Console.Clear();
Console.WriteLine("Введите значение n: ");
int n = int.Parse(Console.ReadLine());

int[] array = GetRandomArray(10, 1, n);
array[0]=1; 
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

Console.WriteLine("Введите диапазон элементов: ");
int r = int.Parse(Console.ReadLine());


int sum = 1;
for (int k = 1; k < r; k++)
{
        sum = sum+array[k];
}    

Console.WriteLine($"Сумма от 1 до {r} = {sum}");
    