Console.WriteLine("num 1?");
bool n1 = int.TryParse(Console.ReadLine(), out int num1);
Console.WriteLine("num 2?");
bool n2 = int.TryParse(Console.ReadLine(), out int num2);
if (n1 && n2)
{
    numbers();
}
;
void numbers()
{
    double res = Math.Pow(num1, num2);
    Console.WriteLine(res);
}
;

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

Console.WriteLine("enter word");
string text1 = Console.ReadLine();
string text2 = new string(text1.Reverse().ToArray());
if (text1 == text2)
{
    Console.WriteLine("palindrome");
}
else
{
    Console.WriteLine("not palindrome");
}
;

//o

//4?

//x

Console.WriteLine("number?");
bool nn1 = int.TryParse(Console.ReadLine(), out int nnn);
Console.WriteLine("power?");
bool p = int.TryParse(Console.ReadLine(), out int power);
if (nn1 && p)
{
    numbers();
};
void numbers()
{
    double res = Math.Pow(nnn, power);
    Console.WriteLine(res);
};