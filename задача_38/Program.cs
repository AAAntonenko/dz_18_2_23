Console.Clear();

string elements = Console.ReadLine();
double[] array = GetArrayFromString(elements);

double[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    double[] res = new double[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = double.Parse(nums[i]);
    }
    return res;
}

double minFind (double[] array)
{
double min = array[0];
for (int j = 1; j < array.Length; j++)
    {
    if (min > array[j])
    {
        min = array[j];
    }
    }
return min;
}

double maxFind (double[] array)
{
double max = array[0];
for (int k = 1; k < array.Length; k++)
    {
    if (max < array[k])
    {
        max = array[k];
    }
    }
return max;
}

Console.WriteLine($"Макс. элемент = {maxFind (array)}, мин. элемент = {minFind (array)}, а их разгница равна {maxFind(array)-minFind(array)}");
