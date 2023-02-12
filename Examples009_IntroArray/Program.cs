int FindMax(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] array = {11, 21, 31, 41, 15, 61, 17, 18 ,19};
array[0] = 12;


int max = FindMax(
    FindMax(array[0], array[1], array[2]),
    FindMax(array[3], array[4], array[5]),
    FindMax(array[6], array[7], array[8])
);
Console.WriteLine(max);