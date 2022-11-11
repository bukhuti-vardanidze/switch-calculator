Console.WriteLine("Enter First number :");
double number1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter Second number :");
double number2 = double.Parse(Console.ReadLine());
Console.WriteLine("Choose One Of This : [+] [-] [*] [/] [%]");
string Operation = Console.ReadLine();

    switch(Operation)
    {
        case "+" :
            Console.WriteLine($"{number1} + {number2} = {number1 + number2} ");
            break;
        case "-" :
            Console.WriteLine($"{number1}  - {number2} = {number1 - number2} ");
            break;
        case "/" :
            Console.WriteLine($"{number1} / {number2} = {number1 / number2} ");
            break;
        case "*" :
            Console.WriteLine($"{number1} * {number2} = {number1 * number2} ");
            break;
        case "%" :
            Console.WriteLine($"{number1} % {number2} = {number1 % number2} ");
            break;
        default:
            Console.WriteLine("choose right operation!");
            break;
        
       
    }

