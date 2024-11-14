try
{
    Console.WriteLine("введите число D:");
    int D = int.Parse(Console.ReadLine());
    if (D <= 0)
    {
        Console.WriteLine("D должно быть больше 0!");
        return;
    }
    double A1 = 1;
    double A2 = 2;
    double AK = A2;
    double A3 = (A1 + A2) / 2;



    for (int k = 2; Math.Abs(AK - A2) < D; k++)
    {

        AK = (A1 + A2) / 2;
        A1 = A2;
        A2 = AK;
        Console.WriteLine($"k={k} Ak-1={A2} Ak= {A3} ");
        break;
    }
}

catch
{
    Console.WriteLine("ошибочка 404....");
}
