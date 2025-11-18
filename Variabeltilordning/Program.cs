

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

testingReadLine();
static void testingReadLine()
{
    Console.WriteLine("Type in some text to test ReadLine()");
    var testingReadLine = Console.ReadLine();
    Console.WriteLine($"This is ReadLine(): {testingReadLine}");

}

testingReadAndReadKey();
static void testingReadAndReadKey()
{
    Console.WriteLine("Press any key followed by enter");
    int testingRead = Console.Read();
    char character = (char)testingRead;
    Console.WriteLine($"This is Read(): {testingRead}");
    Console.WriteLine($"This is Read() converted with (char): {character}");

    Console.WriteLine("Press any key...");
    var testingReadKey = Console.ReadKey();
    Console.WriteLine($"\nThis is ReadKey(): {testingReadKey}");
    Console.WriteLine($"This is ReadKey() converted to the key pressed with built in method: {testingReadKey.Key}");

}

//Fra Rebecka exempel på bruk av ReadKey()
usingReadKey();
static void usingReadKey()
{
    Console.WriteLine("Press Enter to continue...");
    ConsoleKeyInfo userInput = Console.ReadKey();

    if (userInput.Key == ConsoleKey.Enter)
    {
        Console.WriteLine("You pressed Enter!");
    }
    else
    {
        Console.WriteLine("You pressed a different key.");
    }
}