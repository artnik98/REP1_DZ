//1 Упражнение
/*Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите числа B: ");
int B = Convert.ToInt32(Console.ReadLine());
string c = Console.ReadLine();
if (A > B)
{
    Console.WriteLine("Получается А+В = " + (A + B));
}
else if (A == B)
{
    Console.WriteLine("Получается А*В = " + (A * B));
}
else if (A < B)
{
    Console.WriteLine("Получается А-В = " + (A - B));
}
else
{
    Console.WriteLine("Нужны цифры");
}*/

//Упражнение 2
/*Console.Write("Введите число X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите числа Y: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x >= 0 && y >= 0)
{
    Console.WriteLine("1 quarter");
}
else if (x <= 0 && y >= 0)
{
    Console.WriteLine("2 quarter");
}
else if (x <= 0 && y <= 0)
{
    Console.WriteLine("3 quarter");
}
else if (x >= 0 && y <= 0)
{
    Console.WriteLine("4 quarter");
}*/

//3 Упражнение
/*Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите числа B: ");
int B = int.Parse(Console.ReadLine());
Console.Write("Введите числа C: ");
int C = int.Parse(Console.ReadLine());
if (A >= B && B >= C) //a b c
{
    Console.WriteLine(C);
    Console.WriteLine(B);
    Console.WriteLine(A);
}
else if (A >= B && B <= C) //a c b
{
    Console.WriteLine(B);
    Console.WriteLine(C);
    Console.WriteLine(A);
}
else if (A <= B && A >= C) // b a c
{
    Console.WriteLine(C);
    Console.WriteLine(A);
    Console.WriteLine(B);
}
else if (C <= B && A <= C) // b c a
{
    Console.WriteLine(A);
    Console.WriteLine(C);
    Console.WriteLine(B);
}
else if (C >= B && A <= B) // c b a
{
    Console.WriteLine(A);
    Console.WriteLine(B);
    Console.WriteLine(C);
}
else if (C >= A && A >= B) // c a b 
{
    Console.WriteLine(B);
    Console.WriteLine(A);
    Console.WriteLine(C);
}
else
{
    Console.WriteLine("Не понятно");
}
*/

// 4 Упражнение

/*Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число C: ");
int C = Convert.ToInt32(Console.ReadLine());
int D = Convert.ToInt32(Math.Pow(B, 2)) - 4 * A * C;
if (D < 0)
{
    Console.WriteLine("Корней нет");
}
else if (D == 0)
{
    double X = -B / (2 * A);
    Console.WriteLine($"Два равных корня равны= {X}");
}
else
{
    double X1 = (-B + Math.Sqrt(D)) / (2 * A);
    double X2 = (-B - Math.Sqrt(D)) / (2 * A);
    Console.WriteLine($"Два разных корня равны= {X1} и {X2}");
}*/
/*A*x^2+BX+C=0*/


//Упражнение 5
/*Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ваше число: ");*/




//Console.WriteLine("wecwec");
//string age = (Console.ReadLine());
//int age1;
//if (int.TryParse(age,out age1))
//{
//    Console.WriteLine(Convert.ToInt32(age));
//}
//else
//{
//    Console.WriteLine("EFEFE");
//}
//Console.ReadLine();

//Console.WriteLine("Как тебя зовут?");
//string name = Console.ReadLine();