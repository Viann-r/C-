
int[][] students = [[20, 40, 30], [50, 70, 60], [90, 85, 82]];
int sum = 0;
foreach (var s in students)
{
    for (int i = 0; i < s.Length; i++)
    {
        sum += s[i];
    }
    ;
    int res = sum / s.Length;
    Console.WriteLine($"{sum}");
}
;

//o

int[] passwords = new int[10];
for (int i = 0; i < passwords.Length; i++)
{
    Random random = new Random();
    int randomp = random.Next(1000, 9999);
    passwords[i] = randomp;
}
;
Console.WriteLine("enter password");
bool pp = int.TryParse(Console.ReadLine(), out int password);
bool isCorrect = false;
for (int i = 0; i < passwords.Length; i++)
{
    if (password == passwords[i])
    {
        isCorrect = true;
        break;
    }
    else
    {
        isCorrect = false;
    }
}
;
if (isCorrect)
{
    Console.WriteLine("Correct");
}
else
{
    Console.WriteLine("Wrong");
}

//o


int[] numbers = [2, 4, -2, 34, 64, -24, 94, 72, -43, -4, 68];
int min = numbers[0];
bool isMin = false;
bool minStop = false;
int max = numbers[0];
bool isMax = false;
bool maxStop = false;
for (int i = 0; i < numbers.Length; i++)
{
    for (int j = i+1; j < numbers.Length; j++)
    {
        if (numbers[i] < numbers[j])
        {
            min = numbers[i];
            isMin = true;
        }
        else
        {
            break;
        }
        if (isMin && j == 10)
        {
            minStop = true;
        }
    }
    ; 
    if (minStop)
    {
        break;
    }
};
for (int i = 0; i < numbers.Length; i++)
{
    for (int j = i + 1; j < numbers.Length; j++)
    {
        if (numbers[i] > numbers[j])
        {
            max = numbers[i];
            isMax = true;
        }
        else
        {
            break;
        }
        if (isMax && j == 10)
        {
            maxStop = true;
        }
    }
    ;
    if (maxStop)
    {
        break;
    }
}
;
Console.WriteLine($"min is: {min}");
Console.WriteLine($"max is: {max}");

//o

string[] letters = ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j"];
for (int i = 0; i < letters.Length; i++)
{
    Console.WriteLine(letters[i]);
}

//o

string[] emails = ["sfdid@gmail.com", "fhjdhjdshgmail.com", "jugyhgu@gmail.com", "gtyfcghgj@gmail.com"];
for (int i = 0; i < emails.Length; i++)
{
    if (emails[i].Contains("@"))
    {
        Console.WriteLine($"email {emails[i]} contain @");
    }
    else
    {
        Console.WriteLine($"email {emails[i]} does not contain @");
    }
}

//o