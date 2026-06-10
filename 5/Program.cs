Console.WriteLine("Hello, World!");

int[] arr1 = [1, 2, 3];
int[] arr2 = [4, 5, 6];
int[] resultArr = [arr1[0], arr1[1], arr1[2], arr2[0], arr2[1], arr2[2]];
Console.WriteLine(resultArr);
Console.WriteLine();

//x

int[] numij = [];
//int[][] RES = [numij];
//foreach (var item in RES)
//{
    int[] num = [3, 5, -4, 8, 11, 1, -1, 6];
    Console.WriteLine("choose target sum");
    bool sum = int.TryParse(Console.ReadLine(), out int targetSum);
    for (int i = 0; i < num.Length - 1; i++)
    {
        for (int j = 0; j < num.Length - 1; j++)
        {
            int isSum = num[i] + num[j];
            if (isSum == targetSum)
            {
                Console.Write($"[{num[i]}, {num[j]}], ");
                numij = [num[i], num[j]];
            }
        };
    };
//};

//o