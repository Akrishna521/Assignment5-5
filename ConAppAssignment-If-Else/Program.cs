using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your exam score as a percentage: ");
        string inputScore = Console.ReadLine();

        double score = Convert.ToDouble(inputScore);

        char letterGrade;
        if (score >= 90)
        {
            letterGrade = 'A';
        }
        else if (score >= 80)
        {
            letterGrade = 'B';
        }
        else if (score >= 70)
        {
            letterGrade = 'C';
        }
        else if (score >= 60)
        {
            letterGrade = 'D';
        }
        else
        {
            letterGrade = 'F';
        }

        double numericalGrade;
        switch (letterGrade)
        {
            case 'A':
                numericalGrade = 4.0;
                break;
            case 'B':
                numericalGrade = 3.0;
                break;
            case 'C':
                numericalGrade = 2.0;
                break;
            case 'D':
                numericalGrade = 1.0;
                break;
            default:
                numericalGrade = 0.0;
                break;
        }

        Console.WriteLine("Your letter grade is: " + letterGrade);
        Console.WriteLine("Your numerical grade is: " + numericalGrade);
    }
}