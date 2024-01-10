using System;
using System.Collections.Generic;
using System.IO;

namespace Project
{
class CourseManager
{
    private const string CoursesDirectory = "Cours";

    public void AddCourse(string courseName, string courseDetails)
    {
        string courseFileName = $"{CoursesDirectory}\\{courseName}.txt";

        if (!Directory.Exists(CoursesDirectory))
        {
            Directory.CreateDirectory(CoursesDirectory);
        }

        if (!File.Exists(courseFileName))
        {
            using (StreamWriter sw = File.CreateText(courseFileName))
            {
                sw.Write(courseDetails);
            }

            Console.WriteLine($"Cours '{courseName}' ajouté avec succès");
        }
        else
        {
            Console.WriteLine($"Cours '{courseName}' existe déja");
        }
    }

    public void UpdateCourse(string courseName, string newCourseDetails)
    {
        string courseFileName = $"{CoursesDirectory}\\{courseName}.txt";

        if (File.Exists(courseFileName))
        {
            File.WriteAllText(courseFileName, newCourseDetails);
            Console.WriteLine($"Cours '{courseName}' ajouté avec succès");
        }
        else
        {
            Console.WriteLine($"Cours '{courseName}' n'existe pas");
        }
    }

    public void DeleteCourse(string courseName)
    {
        string courseFileName = $"{CoursesDirectory}\\{courseName}.txt";

        if (File.Exists(courseFileName))
        {
            File.Delete(courseFileName);
            Console.WriteLine($"Cours '{courseName}' Effacé avec succès");
        }
        else
        {
            Console.WriteLine($"Cours '{courseName}' N'existe pas");
        }
    }
        public void ViewCourseContent(string courseName)
    {
        string courseFileName = $"{CoursesDirectory}\\{courseName}.txt";

        if (File.Exists(courseFileName))
        {
            string content = File.ReadAllText(courseFileName);
            Console.WriteLine($"Contenu du cours pour'{courseName}':");
            Console.WriteLine(content);
        }
        else
        {
            Console.WriteLine($"Cours '{courseName}' n'existe pas");
        }
    }
}
}