Console.WriteLine("num 1?");
bool n1 = int.TryParse(Console.ReadLine(), out int num1);
Console.WriteLine("num 2?");
bool n2 = int.TryParse(Console.ReadLine(), out int num2);
int pow(int num1, int num2) {
    int result = num1;
    for (int i = 1; i < num2; i++) {
        result *= num1;
}
    return result;
}

//o

Console.WriteLine("enter number");
bool n = int.TryParse(Console.ReadLine(), out int num);
int count = 0;
for (int i = 0; i < num; i++)
{
    if (num % i == 0)
    {
        count++;
    }
    if (count > 1)
    {
        Console.WriteLine("not prime");
    }
    else
    {
        Console.WriteLine("prime");
    }
}

//x

bool isPailndrome(string pal)
{
    if(pal.Length < 2)
    {
        return true;
    }
    if (pal[0] != pal[pal.Length - 1])
    {
        return false;
    }
    string middle = pal.Substring(1, pal.Length-2);
    return isPailndrome(middle);
}

//o

//4?

//x

int Pow(int nnn, int powerer)
{
    if(powerer == 1)
    {
        return nnn;
    }
    return num * Pow(nnn, powerer - 1);
}

//o