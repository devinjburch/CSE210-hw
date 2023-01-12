using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("You must have at least a 70 to pass. What is your grade percentage?");
        string grade = Console.ReadLine() ?? "";
                int percent = int.Parse(grade);

        string assign = "";
        string pass = "";

        if (percent >= 97)
        {
            assign = "A+";
            pass = "You Passed!";
        }
        else if (percent >= 90)
        {
            assign = "A";
            pass = "You Passed!";
        }
        else if (percent >= 87)
        {
            assign = "B+";
            pass = "You Passed!";
        }
        else if (percent >= 80)
        {
            assign = "B";
            pass = "Passed Passed!";
            
        }
        else if (percent >= 77)
        {
            assign = "C+";
            pass = "You Passed!";
            
        }
        else if (percent >= 70)
        {
            assign = "C";
            pass = "Passed";
        }
        else if (percent >= 60)
        {
            assign = "D";
            pass = "You Failed, Better Luck Next Time!";
        }
        else
        {
            assign = "F";
            pass = "You Failed, Better Luck Next Time!";
        }
        Console.WriteLine($"Your grade is {assign}.");
        Console.WriteLine($"{pass}");
    }
}