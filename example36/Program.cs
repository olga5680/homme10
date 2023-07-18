Console.Clear();
Console.Write("Введите количество элементов массива: ");
int x = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[x];

void mas(int a)
{
for (int i = 0; i < a; i++)
{
randomArray[i] = new Random().Next(1,9);
Console.Write(randomArray[i] + "");
}

}

int kol(int[] randomArray)
{
int sum = 0;
int i = 0;
while (i < randomArray.Length)
{
sum = sum + randomArray[i];
i = i + 2;
}
return sum;
}

mas(x);
Console.Write($" Cумма элементов, стоящих на нечётных позициях: {kol(randomArray)}");

