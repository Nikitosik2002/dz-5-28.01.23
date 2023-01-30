var rnd = new Random();
System.Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

int length = array.Length;

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(100, 1000);
}
System.Console.WriteLine("Вывод исходного массива");

foreach (int j in array)
{
    System.Console.Write(j + " ");
}
System.Console.WriteLine();

int[] copyArray = new int[length];

for (int i = 0; i < length; i++)
{
    copyArray[i] = array[i];
}

System.Console.WriteLine("Вывод копии массива");
foreach (int j in copyArray)
{
    System.Console.Write(j + " ");
}