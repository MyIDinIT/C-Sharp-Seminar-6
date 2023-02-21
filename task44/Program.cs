Console.WriteLine("Введите число N:   ");
int N = Convert.ToInt32(Console.ReadLine());

int[] FibArray = new int[N];
FibArray[0]=0;
FibArray[1]=1;
int count=2;
while (count<N)
{
    FibArray[count]=FibArray[count-2]+FibArray[count-1];
    count++;
}
Console.WriteLine(string.Join(",", FibArray));