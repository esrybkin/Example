﻿int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

//              0   1   2      3    4   5   6     7     8
int[] array = {121, 14, 211, 561, 561, 431, 137, 1879, 17875};


int max = Max(
    Max(array[0], array[1], array[3]),
    Max(array[4], array[5], array[6]),
    Max(array[6], array[7], array[8]));

Console.WriteLine(max);
