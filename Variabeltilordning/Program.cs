

int someNumber = 4;
int anotherNumber = 3;
static int AddTwoNumbers(int number1, int number2)
{
    return number1 + number2;
}

Console.WriteLine($"This is the sum of two numbers: {AddTwoNumbers(someNumber, anotherNumber)}");

DontReturn();
static void DontReturn()
{
    Console.WriteLine("Denne metoden returnerer ingenting");
}