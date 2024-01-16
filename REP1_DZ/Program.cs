task13();
//Упражнение 1
void task1 ()
{
    Console.WriteLine("Пользователь вводит 2 числа (A и B). Возвести число A в степень B.");
    Console.Write("Число A: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Число B: ");
    int b = Convert.ToInt32(Console.ReadLine());
    int result = 1;
    for (int i=0; i<b; i++)
    {
        result *= a;
    }
    Console.WriteLine("a^b= "+ result);
}


//Упражнение 2
void task2()
{
    Console.WriteLine("Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A.");
    Console.Write("Число A: ");
    int a = Convert.ToInt32(Console.ReadLine());
    for (int i = a; i <= 1000; i+=a)
    {
        /*if (i % a == 0)*/
            Console.WriteLine(i);
    }
}

//Упражнение 3
void task3()
{
    Console.WriteLine("Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A.");
    Console.Write("Число A: ");
    int a = Convert.ToInt32(Console.ReadLine());
    int result = 1;
    for (int i = 1; a >= (i*i); i ++)
    {
        result = i*i;

        Console.WriteLine(i);
    }
}


//Упражнение 4
void task4()
{
    Console.WriteLine("Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.");
    Console.Write("Число A: ");
    double a = Convert.ToDouble(Console.ReadLine());
    double i = a - 0.5;      // счётчик
    while (a % i != 0.00)
    {
        i--;
    }
    Console.WriteLine("Наибольший числитель числа А это " + i);
}



//Упражнение 5 
void task5()
{
    Console.WriteLine("Пользователь вводит 2 числа (A и B). Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7 (Учтите, что при вводе B может оказаться меньше A).");
    Console.WriteLine("Введите первое число");
    int first = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int second = Convert.ToInt32(Console.ReadLine());
    int min = Math.Min(first, second);
    int max = Math.Max(first, second);
    int del = 7;
    int sum = 0;
    min = min + 7 - (min % 7);
    for (int i = min; i < max; i+=7)
        {
            if (i % del == 0)
            {
                sum += i;
        }
            else
            {
            }
    }
    Console.WriteLine("Сумма: " + sum);
}


//Упражнение 6
void task6()
{
    Console.WriteLine("Пользователь вводит 1 положительное число (N). Выведите N-ое число ряда фибоначчи. В ряду фибоначчи каждое следующее число является суммой двух предыдущих. Первое и второе считаются равными 1");
    Console.WriteLine("Какой член ряда Фибоначчи Вы хотите увидеть?");
    int number = Convert.ToInt32(Console.ReadLine());

        int perv = 0;
        int vtor = 1;
        int sum = 0;

        int j = 2;
        while (j <= number)
        {
            sum = perv + vtor;
            perv = vtor;
            vtor = sum;
            j++;
        }
        Console.WriteLine("Под номером " + number + " в ряде Фибоначчи стоит число " + perv);
}

//Упражнение 7
void task7()
{
    Console.WriteLine("Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида.");
    Console.WriteLine("Число 1:");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Число 2:");
    int b = Convert.ToInt32(Console.ReadLine());

    while (b != 0)
    {
        if (a > b)
        {
            a = a - b;
        }
        else
        {
            b = b - a;
        }
    }
    int nod = a + b;
    Console.WriteLine("НОД: " + nod);

    Console.ReadKey();
}


//Упражнение 9
void task9()
{
    Console.WriteLine("Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.");
    Console.WriteLine("Число 1:");
    int a = Convert.ToInt32(Console.ReadLine());
    int del = 2;
    int sum = 0;
    for (int i = 0; i <= a; i++)
    {
        if (i % del != 0)
        {
            sum ++;
        }
        else
        {
        }
    }
    Console.WriteLine("Кол-во чисел: " + sum);
}

//Упражнение 10
void task10()
{
        int num, reverse = 0;
        Console.WriteLine("Введите число : ");
        num = int.Parse(Console.ReadLine());
        while (num != 0)
        {
            reverse = reverse * 10;
            reverse = reverse + num % 10;
            num = num / 10;
        }
        Console.WriteLine("Reverse введенных чисел : " + reverse);

        Console.ReadLine();
}

//Упражнение 12
void task12()
{
    static bool IsMatchWithDigit(int number, int digit)
    {
        do
        {
            if (number % 10 == digit)
                return true;
            number /= 10;
        }
        while (number != 0);
        Console.WriteLine("Числа нет");
        return false;
    }
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        List<int> result = new List<int>();
        do
        {
            if (IsMatchWithDigit(b, a % 10) && !result.Contains(a % 10))
            {
                result.Add(a % 10);
            }
            a /= 10;
            break;
        }
        while (a != 0);
        foreach (int item in result)
        {
            Console.WriteLine("Числа есть");
        }
    }
}

//Упражнение 13
void task13()
{
    /*    Console.WriteLine("Дано натуральное n. Вычислить:");
        Console.Write("Число: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double result = 0, a = 0;
        int i = 1;
        long fact = 0;
        do
        {
            a = (1+(1.0 / (i * i)));
            a * Factorial(a -1);
        result += a;
            i++;
        }
        while (a < b);
        Console.Write(result);*/
    int n = 4;
    {
        if (n == 1)
        {
        n= n * (n - 1);
    }
        Console.WriteLine($"Факториал числа 4 = {n}");
    }
}
//Упражнение 16
void task16()
{
    Console.WriteLine("16.Вычислить приближенно значение бесконечной суммы (справа от каждой\r\nсуммы дается ее точное значение, с которым можно сравнить\r\nполученный ответ):");
    Console.Write("Число: ");
    double b = Convert.ToDouble(Console.ReadLine());
    double result = 0 , a = 0;
    int i = 1;
    do
    {
        a = (1.0 / (i * i));
        result += a;
        i++;
    }
    while (a > b);
    Console.Write(result);
}

//Упражнение 16_2
void task16_2()
{
    Console.WriteLine("16.Вычислить приближенно значение бесконечной суммы (справа от каждой\r\nсуммы дается ее точное значение, с которым можно сравнить\r\nполученный ответ):");
    Console.Write("Число: ");
    double b = Convert.ToDouble(Console.ReadLine());
    double result = 0, a = 0;
    int i = 1;
    int j = 3;
    do
    {
        a = (1.0 / (i * j));
        result += a;
        i++;
        j++;
    }
    while (a > b);
    Console.Write(result);
}

//Упражнение 16_3
void task16_3()
{
    Console.WriteLine("16.Вычислить приближенно значение бесконечной суммы (справа от каждой\r\nсуммы дается ее точное значение, с которым можно сравнить\r\nполученный ответ):");
    Console.Write("Число: ");
    double b = Convert.ToDouble(Console.ReadLine());
    double result = 0, a = 0;
/*    int i = 1;
    int j = 3;
    do
    {
        a = (1.0 / (i * j));
        result += a;
        i++;
        j++;
    }
    while (a > b);
    Console.Write(result);*/
}