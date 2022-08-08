int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 31;
int b1 = 8761;
int c1 = 41;
int a2 = 187;
int b2 = 31;
int c2 = 167;
int a3 = 15;
int b3 = 1132;
int c3 = 1323;

int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));

Console.WriteLine(max);
