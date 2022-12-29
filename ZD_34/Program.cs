int[] array=new int[7];

for (int i=0; i<array.Length; i++)
{
    array[i]=new Random().Next(100,1000);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
int k=0;
for (int i=0; i<array.Length; i++)
{if(array[i]%2==0)
 k++;

}

Console.Write($"В массиве количество четных чисел равно: {k}");