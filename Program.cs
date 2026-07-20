Console.WriteLine("=== Calculator Simulator ===");
Console.WriteLine("Operations: + (add), - (subtract), * (multiply), q (quit)");
Console.WriteLine();

HelloTest();
HelloTest2();
Console.WriteLine();

while (true)
{
    Console.Write("Enter first number: ");
    string? firstInput = Console.ReadLine();
    if (firstInput?.Trim().ToLower() == "q") break;

    if (!double.TryParse(firstInput, out double firstNumber))
    {
        Console.WriteLine("Invalid number. Please try again.\n");
        continue;
    }

    Console.Write("Enter operator (+ or - or *): ");
    string? op = Console.ReadLine()?.Trim();
    if (op?.ToLower() == "q") break;

    if (op != "+" && op != "-" && op != "*")
    {
        Console.WriteLine("Invalid operator. Please enter +, -, or *.\n");
        continue;
    }

    Console.Write("Enter second number: ");
    string? secondInput = Console.ReadLine();
    if (secondInput?.Trim().ToLower() == "q") break;

    if (!double.TryParse(secondInput, out double secondNumber))
    {
        Console.WriteLine("Invalid number. Please try again.\n");
        continue;
    }

    double result = op == "+" ? firstNumber + secondNumber : op == "-" ? firstNumber - secondNumber : firstNumber * secondNumber;
    Console.WriteLine($"Result: {firstNumber} {op} {secondNumber} = {result}\n");
}

Console.WriteLine("Goodbye!");
Console.WriteLine("Goodbye every0ne!");
Console.WriteLine("Goodbye every1!");
Console.WriteLine("Goodbye every2!");
Console.WriteLine("Goodbye every3!");

void HelloTest()
{
    Console.WriteLine("test");
}

void HelloTest2()
{
    Console.WriteLine("test2");
}

