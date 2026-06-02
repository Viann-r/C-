

Console.WriteLine("your username?");
string username = Console.ReadLine();
Console.WriteLine("your password?");
string p= Console.ReadLine();
int password;
bool pw = int.TryParse(p, out password);
if (username == "admin" && password == 1234)
{
    Console.WriteLine("welcome");
}
else
{
    Console.WriteLine("access denied");
};

//o

Console.WriteLine("number 1?");
string n1 = Console.ReadLine();
int num1;
bool number1 = int.TryParse(n1, out num1);

Console.WriteLine("number 2?");
string n2 = Console.ReadLine();
int num2;
bool number2 = int.TryParse(n2, out num2);

Console.WriteLine("+-*/");
string op = Console.ReadLine();

if (op == "+")
{
    Console.WriteLine(num1 + num2);
} else if (op == "-")
{
    Console.WriteLine(num1 - num2);
} else if (op == "*")
{
    Console.WriteLine(num1 * num2);
} else if (op == "/")
{
    Console.WriteLine(num1 / num2);
};

//o

Console.WriteLine("your age?");
string ages = Console.ReadLine();
int age;
bool ag = int.TryParse(ages, out age);

if (age < 12)
{
    Console.WriteLine("kid");
}
else if (age < 19)
{
    Console.WriteLine("teenager");
}
else if (age < 64)
{
    Console.WriteLine("adult");
}
else
{
    Console.WriteLine("pensioner");
}

//o
