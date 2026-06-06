
Console.WriteLine("Number?");
string n = Console.ReadLine();
int num;
bool numb = int.TryParse(n, out num);
for (int i = 0; i < 11; i++) {
    Console.WriteLine($"{num} * {i} = {num*i}");
};

//o

Console.WriteLine("number of *?");
string ch = Console.ReadLine();
int chN;
bool CH = int.TryParse(ch, out chN);
for (int i = 0; i < chN + 1; i++)
{
    for (int j = 0; j < chN-i; j++)
    {
        for (int x=0; x < i; x++)
        {
            Console.WriteLine("*");
        }
    }
};

//o

Console.WriteLine("last number?");
string Nl = Console.ReadLine();
int nl;
bool nL = int.TryParse(Nl, out nl);

for (int i = 1; i < nl+1; i++)
{
    int count = 0;
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
};

//o

Console.WriteLine("guess the number (1-10)");
string g = Console.ReadLine();
int guess;
bool G = int.TryParse(g, out guess);

Random ran = new Random();
int r = ran.Next(0, 10);

while (guess != r) {
    Console.WriteLine("try again");
    Console.ReadLine();
}
;
