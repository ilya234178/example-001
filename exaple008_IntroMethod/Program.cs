

int a1 = 15;
int b1 = 777;
int c1 = 39;
int a2 = 12;
int b2 = 666;
int c2 = 33;
int a3 = 13;
int b3 = 1500;
int c3 = 33;

int Max(int args1, int args2, int args3 )
{
    int result =  args1;
    if(args2 > result) result = args2;
    if(args3 > result) result = args3;
    return result;
}

// int max1 = Max(a1 , b1, c1);
// int max2 = Max(a2 , b2, c2);
// int max3 = Max(a3 , b3, c3);
// int max = Max(max1, max2, max3);

int max = Max(Max(a1 , b1, c1), Max(a2 , b2, c2), Max(a3 , b3, c3));
Console.WriteLine(max);