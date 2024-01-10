using System;

namespace Project
{
    class Program
    {
        static CourseManager courseManager = new CourseManager();

        static void StudentMenu(Student student)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Gestion des Étudiants");
                Console.WriteLine("I Ajouter un Étudiant");
                Console.WriteLine("II Modifier un Étudiant");
                Console.WriteLine("III Voir les détails d'un Étudiant");
                Console.WriteLine("IV Supprimer un Étudiant");
                Console.WriteLine("V Retourner au menu principal");
                Console.Write("Choisi un nombre");

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
                            Console.WriteLine("Choix invalide. Veuillez entrer un nombre entre 1 et 5.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Saisie invalide. Veuillez entrer un nombre entre 1 et 5.");
                }

                Console.WriteLine();
                
            }
        }

        static void TeacherMenu(Teacher teacher)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Gestion des Enseignants");
                Console.WriteLine("I Ajouter un Enseignant");
                Console.WriteLine("II Modifier un Enseignant");
                Console.WriteLine("III Voir les détails d'un Enseignant");
                Console.WriteLine("IV Supprimer un Enseignant");
                Console.WriteLine("V Retourner au menu principal");
                Console.Write("Choisi un nombre");

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
                            Console.WriteLine("Choix invalide. Veuillez entrer un nombre entre 1 et 5.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Saisie invalide. Veuillez entrer un nombre entre 1 et 5.");
                }

                Console.WriteLine();
                
            }
        }

        static void AdminMenu(Administration admin, Calendar calendar)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Menu Administration");
                Console.WriteLine("I Gérer les Étudiants");
                Console.WriteLine("II Gérer les Enseignants");
                Console.WriteLine("III Gérer le Calendrier");
                Console.WriteLine("IV Gérer les Cours");
                Console.WriteLine("V Retourner au menu principal");
                Console.Write("Choisi un nombre");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            admin.ManageStudents();
                            break;
                        case 2:
                            admin.ManageTeachers();
                            break;
                        case 3:
                            admin.CalendarMenu(calendar, admin);
                            break;
                        case 4:
                            admin.CoursesMenu(courseManager);
                            break;
                        case 5:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Choix invalide. Veuillez entrer un nombre entre 1 et 5.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Saisie invalide. Veuillez entrer un nombre entre 1 et 5.");
                }

                Console.WriteLine();
                
            }
        }

        static void Main()
        {
            Student student = new Student();
            Teacher teacher = new Teacher();
            Calendar calendar = new Calendar();
            Administration admin = new Administration();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Système de Gestion Scolaire");
                Console.WriteLine("I Gestion des Étudiants");
                Console.WriteLine("II Gestion des Enseignants");
                Console.WriteLine("III Menu Administration");
                Console.WriteLine("IV Quitter");
                Console.Write("Entrez votre choix (1-4) : ");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            StudentMenu(student);
                            break;
                        case 2:
                            TeacherMenu(teacher);
                            break;
                        case 3:
                            AdminMenu(admin, calendar);
                            break;
                        case 4:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Choix invalide. Veuillez entrer un nombre entre 1 et 4.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Saisie invalide. Veuillez entrer un nombre entre 1 et 4.");
                }

                Console.WriteLine();
            
            }
        }
    }
}
