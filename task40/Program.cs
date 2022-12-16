// На вход программы подаются три целых положительных числа. 
// Определить , является ли это сторонами треугольника. 
// Если да, то вывести всю информацию по нему - площадь, периметр, значения углов треугольника в градусах, 
// является ли он прямоугольным, равнобедренным, равносторонним.

void CheckNums(double a, double b, double c)
{
    if (a < b + c && b < a + c && c < a + b)
    {
        Console.WriteLine("Треугольник с такими сторонами существует");
    }
    else Console.WriteLine("Такого треугольника не существует");
}

double FindArea(double a, double b, double c)
{
    double p = (a + b + c) / 2;
    double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    S=Math.Round(S,2);
    return S;
}

double FindPerimetr(double a, double b, double c)
{
    double P = (a + b + c);
    P = Math.Round(P,2);
    return P;
}

void FindAngles(double a, double b, double c)
{
    double alpha = Math.Acos(((c * c) + (b * b) - (a * a)) / (2 * c * b));
    alpha = Math.Round((alpha * 180 / Math.PI), 2);
    double betha = Math.Acos(((a * a) + (c * c) - (b * b)) / (2 * a * c));
    betha = Math.Round((betha * 180 / Math.PI), 2);
    double gamma = Math.Acos(((a * a) + (b * b) - (c * c)) / (2 * a * b));
    gamma = Math.Round((gamma * 180 / Math.PI), 2);
    Console.WriteLine($"Alpha = {alpha} градусов; Betha = {betha} градусов; Gamma = {gamma} градусов.");

    if (alpha == 90 || betha == 90 || gamma == 90) Console.WriteLine("Это прямоугольный треугольник");
    else if (alpha == betha && betha == gamma && alpha == gamma) Console.WriteLine("Это равностороний треугольник");
    else if (alpha == betha || betha == gamma || alpha == gamma) Console.WriteLine("Это равнобедренный треугольник");
}

try
{
    Console.WriteLine("Введите значение 1 стороны треугольника: ");
    double a = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите значение 2 стороны треугольника: ");
    double b = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите значение 3 стороны треугольника: ");
    double c = Convert.ToDouble(Console.ReadLine());

    CheckNums(a, b, c);
    double S = Convert.ToDouble(FindArea(a, b, c));
    Console.WriteLine($"Площадь = {S} ");
    double P = Convert.ToDouble(FindPerimetr(a, b, c));
    
    Console.WriteLine($"Периметр = {P} ");
    FindAngles(a, b, c);

}

catch
{
    Console.WriteLine("Ошибка ввода! Введите числовые значения");
}