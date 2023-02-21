
void FillArrayRandom(int[] X)
{
   for (int i = 0; i < X.Length; i++)
   {
    X[i]=new Random().Next(0,100);
   } 
}

int[] array=new int[5];
FillArrayRandom(array);
Console.WriteLine(string.Join(",",array));

int[] Newarray=new int[5];
for (int i = 0; i < Newarray.Length; i++)
{
    Newarray[i]=array[i];
}
Console.WriteLine(string.Join(",",Newarray));
