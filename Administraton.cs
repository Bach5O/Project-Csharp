using System;
using System.Collections.Generic;

namespace Project
{
class Administration
{

    public void ManageStudents()
    {
        Student student = new Student();

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("I Ajouter un étudiant");
            Console.WriteLine("II Modifier l'élève");
            Console.WriteLine("III Afficher les détails de l'étudiant");
            Console.WriteLine("IV Supprimer un élève");
            
            Console.WriteLine("V. Retour au menu Administration");
            Console.Write("Entrez votre choix (1-5) :");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        student.Add();
                        break;
                    case 2:
                        student.Edit();
                        break;
                    case 3:
                        student.ViewDetails();
                        break;
                    case 4:
                        student.Delete();
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Choix invalide. Veuillez saisir un chiffre compris entre 1 et 5.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrée invalide. Veuillez saisir un chiffre compris entre 1 et 5.");
            }

            Console.WriteLine(); 
        }
    }

    public void ManageTeachers()
    {
        Teacher teacher = new Teacher();

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("1. Ajouter un enseignant");
            Console.WriteLine("2. Modifier l'enseignant");
            Console.WriteLine("3. Afficher les détails de l'enseignant");
            Console.WriteLine("4. Supprimer l'enseignant");
            Console.WriteLine("5. Retour au menu Administration");
            Console.Write("Entrez votre choix (1-5) :");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        teacher.Add();
                        break;
                    case 2:
                        teacher.Edit();
                        break;
                    case 3:
                        teacher.ViewDetails();
                        break;
                    case 4:
                        teacher.Delete();
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Choix invalide. Veuillez saisir un chiffre compris entre 1 et 5.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrée invalide. Veuillez saisir un chiffre compris entre 1 et 5.");
            }

            Console.WriteLine(); 
        }
    }
        public void CalendarMenu(Calendar calendar, Administration admin)
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Gestion du calendrier");
            Console.WriteLine("I Changer la date de l'examen");
            Console.WriteLine("II Modifier la date limite du cours");
            Console.WriteLine("III Retour au menu principal");
            Console.Write("Enter your choice (1-3): ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Entrez le nom de l'examen :");
                        string examName = Console.ReadLine();
                        Console.Write("Entrez la date du nouvel examen (jj/mm/aaaa) :");
                        if (DateTime.TryParse(Console.ReadLine(), out DateTime newExamDate))
                        {
                            calendar.ChangeExamDate(examName, newExamDate, admin);
                        }
                        else
                        {
                            Console.WriteLine("Format de date invalide.");
                        }
                        break;
                    case 2:
                        Console.Write("Entrez le nom du cours :");
                        string courseName = Console.ReadLine();
                        Console.Write("Entrez la date limite du nouveau cours (jj/mm/aaaa) :");
                        if (DateTime.TryParse(Console.ReadLine(), out DateTime newDeadline))
                        {
                            calendar.ChangeCourseDeadline(courseName, newDeadline, admin);
                        }
                        else
                        {
                            Console.WriteLine("Format de date invalide.");
                        }
                        break;
                    case 3:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Choix invalide. Veuillez saisir un chiffre compris entre 1 et 3.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Saisie invalide. Veuillez saisir un nombre compris entre 1 et 3.");
            }

            Console.WriteLine(); 
            
        }
    }

        public void CoursesMenu(CourseManager courseManager)
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Gestion des cours");
            Console.WriteLine("I Ajouter un cours");
            Console.WriteLine("II Update Course");
            Console.WriteLine("III Supprimer un cours");
            Console.WriteLine("IV Afficher les détails du cours");
            Console.WriteLine("V Retour au menu Administration");
            Console.Write("Entrez votre choix :");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Entrez le nom du cours :");
                        string courseName = Console.ReadLine();
                        Console.Write("Entrez les détails du cours :");
                        string courseDetails = Console.ReadLine();
                        courseManager.AddCourse(courseName, courseDetails);
                        break;
                    case 2:
                        Console.Write("Entrez le nom du cours :");
                        string updateCourseName = Console.ReadLine();
                        Console.Write("Entrez les détails du cours mis à jour :");
                        string updatedCourseDetails = Console.ReadLine();
                        courseManager.UpdateCourse(updateCourseName, updatedCourseDetails);
                        break;
                    case 3:
                        Console.Write("Entrez le nom du cours à supprimer :");
                        string deleteCourseName = Console.ReadLine();
                        courseManager.DeleteCourse(deleteCourseName);
                        break;
                    case 4:
                        Console.Write("Entrez le nom du cours pour afficher le contenu :");
                        string viewContentCourseName = Console.ReadLine();
                        courseManager.ViewCourseContent(viewContentCourseName);
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Choix invalide. Veuillez saisir un chiffre compris entre 1 et 4.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrée invalide. Veuillez saisir un chiffre compris entre 1 et 4.");
            }

            Console.WriteLine(); 
        }
    }


}
}
