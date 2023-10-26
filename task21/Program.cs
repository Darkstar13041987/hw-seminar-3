// Задача 21: Напишите программу, которая принимает
// на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53       3D: d = sqrt (x2 — x1)^2 + (y2 — y1)^2 + (z2 — z1)^2).   
                                       // В этой формуле x1, y1 и z1 – это координаты первой точки, а x2, y2 и z2 – координаты второй точки. 
                                       // Таким образом, для вычисления расстояния между двумя точками в трехмерном пространстве 
                                       // необходимо вычислить разности координат по каждой оси, 
                                       // возвести в квадрат, просуммировать полученные значения и извлечь корень квадратный.




Console.Write("Введите координаты точки  x1: ");
int inputX1 =Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки  y1: ");
int inputY1 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки  z1: ");
int inputZ1=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки  bx: ");
int inputX2 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки  by: ");
int inputY2 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки  bz: ");
int inputZ2 =Convert.ToInt32(Console.ReadLine());


int A = inputX2 - inputX1 ;
int B = inputY2 - inputY2 ;
int C = inputZ2 - inputZ1;

double distance = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Растояние между точками {distance}");

