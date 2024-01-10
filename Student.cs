using System;
using System.Collections.Generic;

namespace Project
{
class Student
{
    private static int lastAssignedId = 1000; 
    public int StudentID { get; set; }
    public string Password { get; set; } 
    public string Name { get; set; }
    public string Prenom { get; set; }
    public string CurrentClass { get; set; }

    public string Niveau { get; set; }

    public string Special { get; set; }


    public static List<Student> StudentsList = new List<Student>();

    public void Add()
    {
        Console.WriteLine("Entrez les détails de l'étudiant :");
        Console.Write("Nom: ");
        Name = Console.ReadLine();
        Console.Write("Prenom: ");
        Prenom = Console.ReadLine();
        Console.Write("Classe: ");
        CurrentClass = Console.ReadLine();
        Console.Write("Niveau: ");
        Niveau = Console.ReadLine();
        Console.Write("Specialité: ");
        Special = Console.ReadLine();
        StudentID = ++lastAssignedId;
        Console.WriteLine($"Votre Id: {StudentID}");
        Console.Write("Mot de pass: ");
        Password = Console.ReadLine(); 


        StudentsList.Add(this);

        Console.WriteLine("Étudiant ajouté avec succès !");
    }

    public void Edit()
    {
        Console.Write("Entrez votre carte d'étudiant :");
        int studentIdToEdit = int.Parse(Console.ReadLine());

        Console.Write("Entrer le mot de passe: ");
        string passwordToEdit = Console.ReadLine();

        Student studentToEdit = StudentsList.Find(s => s.StudentID == studentIdToEdit && s.Password == passwordToEdit);

        if (studentToEdit != null)
        {
            Console.WriteLine("Entrez de nouveaux détails :");
            Console.Write("Nom: ");
            studentToEdit.Name = Console.ReadLine();
            Console.Write("Prenom: ");
            studentToEdit.Prenom = Console.ReadLine();
            Console.Write("Classe: ");
            studentToEdit.CurrentClass = Console.ReadLine();
            Console.Write("Niveau: ");
            studentToEdit.Niveau = Console.ReadLine();
            Console.Write("Specialité: ");
            studentToEdit.Special = Console.ReadLine();

            Console.WriteLine("Les détails de l'étudiant ont été mis à jour avec succès !");
        }
        else
        {
            Console.WriteLine("Carte d'étudiant ou mot de passe invalide ! Échec de la modification.");
        }
    }

    public void Delete()
    {
        Console.Write("Entrez la carte d'étudiant : ");
        int studentIdToDelete = int.Parse(Console.ReadLine());

        Console.Write("Entrer le mot de passe: ");
        string passwordToDelete = Console.ReadLine();

        Student studentToDelete = StudentsList.Find(s => s.StudentID == studentIdToDelete && s.Password == passwordToDelete);

        if (studentToDelete != null)
        {
            StudentsList.Remove(studentToDelete);
            Console.WriteLine("Étudiant supprimé avec succès ! ");
        }
        else
        {
            Console.WriteLine("Carte d'étudiant ou mot de passe invalide ! La suppression a échoué.");
        }
    }

    public void ViewDetails()
    {
        Console.Write("Entrez votre carte d'étudiant :");
        int studentIdToView = int.Parse(Console.ReadLine());

        Console.Write("Entrer le mot de passe:");
        string passwordToView = Console.ReadLine();

        Student studentToView = StudentsList.Find(s => s.StudentID == studentIdToView && s.Password == passwordToView);

        if (studentToView != null)
        {
            Console.WriteLine("Détails de l'étudiant :");
            Console.WriteLine($"ID: {studentToView.StudentID}");
            Console.WriteLine($"Nom: {studentToView.Name}");
            Console.WriteLine($"Prenom: {studentToView.Prenom}");
            Console.WriteLine($"Class: {studentToView.CurrentClass}");
            Console.WriteLine($"Niveau: {studentToView.Niveau}");
            Console.WriteLine($"Special: {studentToView.Special}");
        }
        else
        {
            Console.WriteLine("Carte d'étudiant ou mot de passe invalide ! L'affichage des détails a échoué.");
        }
    }

}

}