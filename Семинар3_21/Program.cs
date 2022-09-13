// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите через пробел координаты точки A x1 y1 z1:");
string x1y1z1 = Console.ReadLine ()!;
string[] partsA = x1y1z1.Split (' ');
int x1 = int.Parse (partsA[0]);
int y1 = int.Parse (partsA[1]);
int z1 = int.Parse (partsA[2]);

Console.WriteLine("Введите через пробел координаты точки B x2 y2 z2:");
string x2y2z2 = Console.ReadLine ()!;
string[] partsB = x2y2z2.Split (' ');
int x2 = int.Parse (partsB[0]);
int y2 = int.Parse (partsB[1]);
int z2 = int.Parse (partsB[2]);

double distance = Math.Sqrt (Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1,2));

Console.WriteLine ($"Расстояние между точками А и В = {distance}");