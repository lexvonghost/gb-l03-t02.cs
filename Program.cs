Console.WriteLine("Введите х1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z1");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите х2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y2");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z2");
int z2 = Convert.ToInt32(Console.ReadLine());

double l = Math.Sqrt((x2 - x1)^2 + (y2 - y1)^2 + (z2 - z1)^2);
Console.WriteLine(l);