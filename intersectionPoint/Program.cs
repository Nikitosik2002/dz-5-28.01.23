System.Console.WriteLine("Нахождение точки пересечения между двумя прямыми");

System.Console.WriteLine("Введите коэффицент x первого уравнения");
int x1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите коэффицент x второго уравнения");
int x2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите коэффицент b первого уравнения");
int b1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите коэффицент b второго уравнения");
int b2 = Convert.ToInt32(Console.ReadLine());


int firstResultX = x1 - x2;
int resultB = b1 - b2;
float resultX = 0;

if(firstResultX == 0  || resultB == 0)
{
     resultX = 0;
}
else
{
     resultX = resultB / firstResultX;
}

System.Console.WriteLine(resultX + "X");

float resultY = x1 * resultX + b1;

System.Console.WriteLine("Точка пересечения двуъ прямых = " +"("+resultX+"; "+resultY+")");




