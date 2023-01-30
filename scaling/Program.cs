System.Console.WriteLine("Введите координату x первой точки");
float x1 = Convert.ToSingle(Console.ReadLine());
System.Console.WriteLine("Введите координату y первой точки");
float y1 = Convert.ToSingle(Console.ReadLine());

System.Console.WriteLine("Введите координату x второй точки");
float x2 = Convert.ToSingle(Console.ReadLine());
System.Console.WriteLine("Введите координату y второй точки");
float y2 = Convert.ToSingle(Console.ReadLine());

System.Console.WriteLine("Введите координату x третьей точки");
float x3 = Convert.ToSingle(Console.ReadLine());
System.Console.WriteLine("Введите координату y третьей точки");
float y3 = Convert.ToSingle(Console.ReadLine());

System.Console.WriteLine("Введите координату x четвертой точки");
float x4 = Convert.ToSingle(Console.ReadLine());
System.Console.WriteLine("Введите координату y четвертой точки");
float y4 = Convert.ToSingle(Console.ReadLine());

System.Console.WriteLine("Введите коэффицент масштабирования");
float k = Convert.ToSingle(Console.ReadLine());
x1 = x1 * k;
y1 = y1 * k;

x2 = x2 * k;
y2 = y2 * k;

x3 = x3 * k;
y3 = y3 * k;

x4 = x4 * k;
y4 = y4 * k;

System.Console.WriteLine("Производится масштабирование фигуры");

System.Console.WriteLine("Новые точки фигуры, первая координата " +"("+x1+"; "+y1+")");
System.Console.WriteLine("Новые точки фигуры, вторая координата = " +"("+x2+"; "+y2+")");
System.Console.WriteLine("Новые точки фигуры, третья координата = " +"("+x3+"; "+y3+")");
System.Console.WriteLine("Новые точки фигуры, четвертая координата = " +"("+x4+"; "+y4+")");