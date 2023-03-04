// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
string proverka(int h5)
{
    string rez;
    int re1 = h5 / 1000;
    int re2 = h5 % 100;
    int re2_ = re2 % 10 * 10 + re2 / 10;
    if (re1 == re2_)
        rez = "да";
    else
        rez = "нет";
    return rez;
}
Console.WriteLine("Введите целое неотрицательное пятизначное число)");
int h5 = Convert.ToInt32(Console.ReadLine());
if (h5 >= 10000 && h5 <= 99999)
{
    string result = proverka(h5);
    Console.WriteLine(result);
}
else
    Console.WriteLine("Вы вели неправильное число)");


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
double GetDiff(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int _x = x2 - x1;
    int _y = y2 - y1;
    int _z = z2 - z1;

    double rez = Math.Sqrt(Math.Pow(_x, 2) + Math.Pow(_y, 2) + Math.Pow(_z, 2));

    return Math.Round(rez, 2); 
}

Console.WriteLine("Введите координату X точки A");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки A");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки A");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X точки B");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки B");
int z2 = Convert.ToInt32(Console.ReadLine());

double diff = GetDiff(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точками А и В {diff}");


// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
void kub(int N1)
{
    for (int i = 1; i <= N1; i++)
        Console.Write(i + " -> " + Math.Pow(i, 3) + ", ");
}
Console.WriteLine("Введите число N");
int N1 = Convert.ToInt32(Console.ReadLine());
kub(N1);


// Задача 21 - HARD необязательная
// Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в N-мерном пространстве. Сначала задается N с клавиатуры, 
// потом задаются координаты точек.
Console.WriteLine("Введите число N (N-мерное пространство)");
int N = Convert.ToInt32(Console.ReadLine());
int[] A = new int[N];
int[] B = new int[N];
int i = 0;
while (i < N)
{
    Console.WriteLine($"Введите координату {(i + 1)}-го измерения точки A");
    int a = Convert.ToInt32(Console.ReadLine());
    A[i] = a;
    i++;
}
int j = 0;
while (j < N)
{
    Console.WriteLine($"Введите координату {(j + 1)}-го измерения точки B");
    int b = Convert.ToInt32(Console.ReadLine());
    B[j] = b;
    j++;
}
int k = 0;
double diff2 = 0;
int sum = 0;
while (k < N)
{
    int d = B[k] - A[k];
    sum = sum + d * d; 
    k++;
}
diff2 = Math.Round(Math.Sqrt(sum), 2);
Console.WriteLine($"Расстояние между точками А и В равно {diff2}");


// Задача 19 - HARD необязательная
// Напишите программу, которая принимает на вход целое число любой разрядности 
// и проверяет, является ли оно палиндромом. Через строку нельзя решать само собой.
string zerkalo(int size)
{
    int number = size;
    int numberZerkalniy = 0;

    while (number > 0)
    {
        int numberLast = number % 10;
        numberZerkalniy = numberZerkalniy * 10 + numberLast;
        number = number / 10;
    }
    string znak = "";
    if (size == numberZerkalniy)
        znak = "Число является палиндромом";
    else
        znak = "Число не является палиндромом";
    return znak;
}
Console.WriteLine("Введите целое число любой разрядности)");
int size = Convert.ToInt32(Console.ReadLine());
string priznak = zerkalo(size);
Console.WriteLine(priznak);
//https://github.com/profimars/C_SharpSeminar3

