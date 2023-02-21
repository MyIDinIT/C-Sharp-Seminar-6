Console.WriteLine("Введите первое число:   ");
int A=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:   ");
int B=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число:   ");
int C=Convert.ToInt32(Console.ReadLine());

if (A+B<C || B+C<A || C+A<B)
{
    Console.WriteLine("Невозможный треугольник!");
}

else
{
    Console.WriteLine("Таким треугольник может быть :) ");
}  