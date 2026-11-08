int n = 10;
int[] array = {2, 6, 7, 4, 9, 5, 3, 8, 7, 10};
for (int i = 0; i < array.Length; i++)
{
    if(array[i]%2 == 0)
    {
        Console.Write($"{array[i]} ");
    }
}
