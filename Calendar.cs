using System;
using System.Collections.Generic;


namespace Project
{
class Calendar
{
    private Dictionary<string, DateTime> examDates;
    private Dictionary<string, DateTime> courseDeadlines;

    public Calendar()
    {
        examDates = new Dictionary<string, DateTime>();
        courseDeadlines = new Dictionary<string, DateTime>();
    }


    public void DisplayExamDates()
    {
        Console.WriteLine("Date d'examens :");
        foreach (var exam in examDates)
        {
            Console.WriteLine($"{exam.Key}: {exam.Value.ToShortDateString()}");
        }
    }

    public void DisplayCourseDeadlines()
    {
        Console.WriteLine("Date limite des cours: ");
        foreach (var deadline in courseDeadlines)
        {
            Console.WriteLine($"{deadline.Key}: {deadline.Value.ToShortDateString()}");
        }
    }


    public void ChangeExamDate(string examName, DateTime newDate, Administration admin)
    {
        if (admin != null)
        {
            examDates[examName] = newDate;
            Console.WriteLine($"date de l'examen {examName} Mis à jour ");
        }
        else
        {
            Console.WriteLine("Accès refusé. Seul l'administrateur peut modifier les dates d'examen.");
        }
    }

    public void ChangeCourseDeadline(string courseName, DateTime newDeadline, Administration admin)
    {
        if (admin != null)
        {
            courseDeadlines[courseName] = newDeadline;
            Console.WriteLine($"Date limite des cours pour {courseName} Mis à jour ");
        }
        else
        {
            Console.WriteLine("Accès refusé. Seul l'administrateur peut modifier les dates limites des cours.s");
        }
    }
    
}
}