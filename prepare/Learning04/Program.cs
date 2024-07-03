using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assign1 = new Assignment("dallin", "csharp");
        Console.WriteLine(assign1.GetSummary());

        MathAssignment assign2 = new MathAssignment("dallin", "csharp","7.3", "8-9");
        Console.WriteLine(assign2.GetSummary());
        Console.WriteLine(assign2.GetHomeworkList());

        WritingAssignment assign3 = new WritingAssignment("dallin", "csharp", "BOM");
        Console.WriteLine(assign3.GetSummary());
        Console.WriteLine(assign3.GetWritingInformation());
    }
}