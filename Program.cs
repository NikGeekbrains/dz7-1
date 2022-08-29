
void DoubleMassiveInitial()
{
    Console.WriteLine("Введите кол-во строк");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите кол-во столбцов");
    int n = Convert.ToInt32(Console.ReadLine());
    double [,] VechestvennyMassive = new double[m,n]; 

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            VechestvennyMassive[i,j] = new Random().NextDouble();
        }
    }

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(VechestvennyMassive[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void SearchElementPosition()
{
    Console.WriteLine("Введите кол-во строк");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите кол-во столбцов");
    int n = Convert.ToInt32(Console.ReadLine());

    int [,] NewMassive = new int[m,n]; 

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            NewMassive[i,j] = new Random().Next();
        }
    }

    Console.WriteLine("Введите строку");
    int Stroka = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите столбец");
    int Stolbets = Convert.ToInt32(Console.ReadLine());

    if (Stroka <= m && Stolbets <= n)
    {
    Console.WriteLine(NewMassive[Stroka, Stolbets]);
    }
    else 
    {
        Console.WriteLine("Такого элемента не существует!");
    }
}

void SredneeArifmeticheskoe()
{
    Console.WriteLine("Введите кол-во строк");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите кол-во столбцов");
    int n = Convert.ToInt32(Console.ReadLine());

    int [,] NewMassive = new int[m,n]; 

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            NewMassive[i,j] = new Random().Next(0, 10);
        }
    }

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(NewMassive[i, j] + "\t");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
    
    for (int i = 0; i < n; i++)
    {
        int summa = 0;
        for (int j = 0; j < m; j++)
        {
            summa =  summa + (NewMassive[j, i]);
        }

        float rezult = summa/m; // Почему число округляется?
        Console.WriteLine($"Среднне арифметическое {i} столбца = {rezult}");
    }
}

//DoubleMassiveInitial();
//SearchElementPosition();
//SredneeArifmeticheskoe();