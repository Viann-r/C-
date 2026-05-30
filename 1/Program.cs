Console.WriteLine("You age?");
string userAge = Console.ReadLine();
int num;
bool age = int.TryParse(userAge, out num);
if (num == 18) {
    Console.WriteLine("Congratulations! You have the rignt to vote");
    } else if (num == 15)
{
    Console.WriteLine("Unfortunately, you are not yet eligible to vote");
}

//o

int num1 = 25;
int num2 = 63;
int num3 = 10;

int res1 = num1 > num2 ? num1 : num2;
int result = res1 > num3 ? res1 : num3;
Console.WriteLine("the largest number is " + result);

//o

Console.WriteLine("enter number");
string n1 = Console.ReadLine();
bool numberOne = int.TryParse(n1, out int number1);
Console.WriteLine("enter number two");
string n2 = Console.ReadLine();
bool numberTwo = int.TryParse(n2, out int number2);
int res = number1 == number2 ? number1 * 3 + number2 * 3 : number1 + number2 ;
Console.WriteLine(res);

//o