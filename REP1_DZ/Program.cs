//1 Упражнение
void task1()
{
    Console.Write("Введите число А: ");
    string A = Console.ReadLine();
    Console.Write("Введите числа B: ");
    string B = Console.ReadLine();
    if (int.TryParse(A, out int a))
    {
        if (int.TryParse(B, out int b))
        {
            if (a > b)
            {
                Console.WriteLine("Получается А+В = " + (a + b));
            }
            else if (a == b)
            {
                Console.WriteLine("Получается А*В = " + (a * b));
            }
            else if (a < b)
            {
                Console.WriteLine("Получается А-В = " + (a - b));
            }
        }
        else
        {
            Console.WriteLine("Нужны цифры");
        }
    }
    else
    {
        Console.WriteLine("Нужны цифры");
    }
}

//Упражнение 2
void task2()
{
    Console.Write("Введите число X: ");
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
    }
}

//3 Упражнение
void task3()
{
    Console.Write("Введите число А: ");
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
}

// 4 Упражнение
void task4()
{
    Console.Write("Введите число А: ");
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
    }
}

/*A*x^2+BX+C=0*/


//Упражнение 6 
void task6()
{
    /*    Console.Write("Введите число: ");
        string x= Console.ReadLine();
        if (int.TryParse(x, out int a))
        {
            if (a % 2 == 0)
            {
                Console.WriteLine($"ЧЕТНОЕ={a}");
            }
            else if (a % 2 != 0)
            {
                Console.WriteLine($"НЕЧЕТНОЕ={a}");
            }
        }
        else
        {
            Console.WriteLine($"Неизвестное имя={a}");
        }*/
    Console.Write("определить координату точки X0 центра окружности: ");
    double x0 = Convert.ToDouble (Console.ReadLine());
    Console.Write("определить координату точки Y0 центра окружности: ");
    double y0 = Convert.ToDouble(Console.ReadLine());
    Console.Write("определить координату точки Mx: ");
    double Mx = Convert.ToDouble(Console.ReadLine());
    Console.Write("определить координату точки My: ");
    double My = Convert.ToDouble(Console.ReadLine());
    Console.Write("определить радиус окружности: ");
    double r = Convert.ToDouble(Console.ReadLine());
    double RAD = Math.Sqrt(Math.Pow(Mx - x0, 2) + Math.Pow(My - y0, 2));
    if (RAD <= r)
    {
        Console.WriteLine("Точка М находится в круге.");
    }
    else
    {
        Console.WriteLine("Точка М находится не в круга.");
    }
Console.ReadKey();

    //(x - x0)^2 + (y - y0)^2 <= R^2
}


task5();
//Упражнение 5 
void task5 ()
{
    Console.Write("Введите двухзначное число:");
    int  a = Convert.ToInt32 (Console.ReadLine());
    if ( a >= 10 && a < 20)
    {
        switch (a)
        {
            case 11:
                Console.Write("Одинадцать ");
                break;
            case 12:
                Console.Write("Двенадцать ");
                break;
            case 13:
                Console.Write("Тринадцать ");
                break;
            case 14:
                Console.Write("Четырнадцать ");
                break;
            case 15:
                Console.Write("Пятнадцать ");
                break;
            case 16:
                Console.Write("Шеснадцать ");
                break;
            case 17:
                Console.Write("Семнадцать ");
                break;
            case 18:
                Console.Write("Восемнадцать ");
                break;
            case 19:
                Console.Write("Девятнадцать ");
                break;
        }
    }

    else if (a>=20 && a <= 99)
    {
        int number = a % 10;
        switch (number)
        {
            case 1:
                Console.Write("Один");
                break;
            case 2:
                Console.Write("Два");
                break;
            case 3:
                Console.Write("Три");
                break;
            case 4:
                Console.Write("Четыри");
                break;
            case 5:
                Console.Write("Пять");
                break;
            case 6:
                Console.Write("Шесть");
                break;
            case 7:
                Console.Write("Семь");
                break;
            case 8:
                Console.Write("Восемь");
                break;
            case 9:
                Console.Write("Девять");
                break;
        }
        int tens = (a / 10);
        switch (tens)
        {
            case 2:
                Console.Write("Двадцать ");
                break;
            case 3:
                Console.Write("Тридцать ");
                break;
            case 4:
                Console.Write("Сорок ");
                break;
            case 5:
                Console.Write("Пятьдесят");
                break;
            case 6:
                Console.Write("Шестьдесят ");
                break;
            case 7:
                Console.Write("Семьдесят ");
                break;
            case 8:
                Console.Write("Восемьдесят ");
                break;
            case 9:
                Console.Write("Девяносто ");
                break;
        }
    }
    else Console.WriteLine("Введите двузначное число корректно");
}





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