using static System.Console;
using static System.Convert;
using static System.Math;

string str = ReadLine();
var arr1 = str.Split(" ");
int[] arr2 = new int[4];
int mx = 0;
for(int i=0;i<4;i++)
{
    arr2[i] = ToInt32(arr1[i]);
}
for(int i = 0; i < 4; i++)
{
    int sum = 0;
    for(int j = i + 1; j < 4; j++)
    {
        if (arr2[j] == arr2[i])
        {
            sum++;
        }
    }
    if (sum >= 2)
    {
        mx = sum;
        break;
    }
    else
    {
        mx += sum;
    }
}
WriteLine(mx);