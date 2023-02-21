void DevideByTwo(int x)
{
    if (x == 0) return;

    DevideByTwo(x/2);
    Console.Write(x%2);
}
Console.WriteLine("Введите  число:   ");
int A=Convert.ToInt32(Console.ReadLine());
DevideByTwo(A);

