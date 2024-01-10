using System;
using System.Collections.Generic;

namespace Project
{
class Teacher
{
    private static int lastAssignedId = 2000; 
    public int TeacherID { get; set; }
    public string Password { get; set; } 
    public string Name { get; set; }
    public string Prenom { get; set; }
    public string Prof { get; set; }

    public static List<Teacher> TeachersList = new List<Teacher>();

    public void Add()
    {
        Console.WriteLine(" Entrez les détails de l'enseignant : ");
        Console.Write("Nom: ");
        Name = Console.ReadLine();
        Console.Write("Prenom: ");
        Prenom = Console.ReadLine();
        Console.Write("Prof de: ");
        Prof = Console.ReadLine();
        TeacherID = ++lastAssignedId;
        Console.WriteLine($"Votre nouvel identifiant est : {TeacherID}");
        Console.Write("mot de passe");
        Password = Console.ReadLine(); 


        TeachersList.Add(this);

        Console.WriteLine("Professeur ajouté avec succès !");
    }

    public void Edit()
    {
        Console.Write("Saisissez l'identifiant de l'enseignant à modifier :");
        int teacherIdToEdit = int.Parse(Console.ReadLine());

        Console.Write("Entrer le mot de passe:");
        string passwordToEdit = Console.ReadLine();

        Teacher teacherToEdit = TeachersList.Find(t => t.TeacherID == teacherIdToEdit && t.Password == passwordToEdit);

        if (teacherToEdit != null)
        {
            Console.WriteLine("Entrez de nouveaux détails :");
            Console.Write("Nom ");
            teacherToEdit.Name = Console.ReadLine();
            Console.Write("Prof de: ");
            teacherToEdit.Prof = Console.ReadLine();


            Console.WriteLine("Les détails de l'enseignant ont été mis à jour avec succès !");
        }
        else
        {
            Console.WriteLine("Professeur introuvable !");
        }
    }

    public void Delete()
    {
        Console.Write("Saisissez l'identifiant de l'enseignant à supprimer :");
        int teacherIdToDelete = int.Parse(Console.ReadLine());

        Teacher teacherToDelete = TeachersList.Find(t => t.TeacherID == teacherIdToDelete);

        if (teacherToDelete != null)
        {
            TeachersList.Remove(teacherToDelete);
            Console.WriteLine("Professeur supprimé avec succès !");
        }
        else
        {
            Console.WriteLine("Professeur introuvable !");
        }
    }

    public void ViewDetails()
    {
        Console.Write("Saisissez l'identifiant de l'enseignant pour afficher les détails :");
        int teacherIdToView = int.Parse(Console.ReadLine());

        Teacher teacherToView = TeachersList.Find(t => t.TeacherID == teacherIdToView);

        if (teacherToView != null)
        {
            Console.WriteLine("Détails de l'enseignant :");
            Console.WriteLine($"ID: {teacherToView.TeacherID}");
            Console.WriteLine($"Nom: {teacherToView.Name}");
            Console.WriteLine($"Prof de: {teacherToView.Prof}");
        }
        else
        {
            Console.WriteLine("Professeur introuvable !");
        }
    }

}
}