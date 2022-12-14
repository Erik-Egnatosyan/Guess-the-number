int count = 0;
int number = 50;
int saveMax = 0;
int saveMin = 0;
int max = 100;
int min = 0;
Console.WriteLine("I'll try to guess your number on 7th try!");
while (count != 7)
{
    if (count == 0)
    {
        Console.WriteLine("50 is your number? yes/no");
        string check = Console.ReadLine();
        if (check == "yes")
        {
            Console.WriteLine($"Your number is {number}!");
            break;
        }
        if (check != "no" && check != "yes")
        {
            Console.WriteLine("I don't understand you ;(\nTry one more time!");
            break;
        }
    }
    Console.WriteLine("Write \">\" if bigger or \"<\" lesser!");
    string numberCheck = Console.ReadLine();
    if (numberCheck != ">" && numberCheck != "<")
    {
        Console.WriteLine("I don't understand you ;(\nTry one more time!");
        break;
    }
    switch (numberCheck)
    {
        case ">":
            min = number;
            saveMin = min;
            saveMax = max - number;
            saveMax /= 2;
            number += saveMax;
            if (min == 99)
            {
                number++;
            }
            break;
        case "<":
            max = number;
            min = (number + saveMin) / 2;
            number = min;
            break;
    }
    Console.WriteLine(number);
    Console.WriteLine("This is your number? yes/no");
    string isThatNumber = Console.ReadLine();
    if (isThatNumber == "yes")
    {
        Console.WriteLine($"Your number is {number}");
        break;
    }
    else if (isThatNumber != "no" && isThatNumber != "yes")
    {
        Console.WriteLine("I don't understand you ;(\nTry one more time!");
        break;
    }
    else if (count == 7)
    {
        Console.WriteLine("Are you hiding something from me?");
    }
    count++;
}