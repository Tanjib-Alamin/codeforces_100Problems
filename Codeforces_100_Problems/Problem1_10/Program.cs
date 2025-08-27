
// problem_1 : https://codeforces.com/problemset/problem/71/A


using System.Linq.Expressions;
Console.Write("Please give an Input :");
string input = Console.ReadLine();

int count = input.Length;
int c = count - 2;
Console.WriteLine(input.Substring(0,1)+count.ToString()+input.Substring(count-1));


char[] arr= new char[count];
for (int i = 0; i < count; i++)
{
    arr[i] = input[i];
}
for (int i = 0;i < count; i++)
{
   if(i==0) Console.Write(arr[i]);
   if(i==1) Console.Write(count);
   if (i == count-1) Console.Write(arr[i]);
}
Console.WriteLine();
for (int i = 0;i<input.Length ; i++)
{

    if (i == 0) Console.Write(input[i]);
    if (i == 1) Console.Write(count);
    if (i == count - 1) Console.Write(input[i]);
}