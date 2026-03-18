namespace Exo_Collection_ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choix;
            List<string> taches = new List<string>();
            List<string> tachesFinies = new List<string>();
            // Répétition :
            do
            {
                // 0. Nettoyer l'écran
                Console.Clear();
                // 1. Afficher titre
                Console.WriteLine("ToDoList :");
                Console.WriteLine("----------");
                // 2. Afficher la liste
                foreach (string t in taches)
                {
                    Console.WriteLine($" - {t}");
                }
                // 2.1 Afficher la liste des tâches finies
                if(tachesFinies.Count > 0)
                {
                    // 2.1.1 Afficher titre
                    Console.WriteLine("Tâches finies :");
                    Console.WriteLine("---------------");
                    // 2.1.2 Afficher la liste
                    foreach (string tf in tachesFinies)
                    {
                        Console.WriteLine($" - {tf}");
                    }
                }
                // 3. Afficher le menu
                if(taches.Count > 0)
                {
                    Console.WriteLine("(A)jouter une tâche | (S)upprimer une tâche | (F)inir une tâche | (Q)uitter");
                }
                else
                {
                    Console.WriteLine("(A)jouter une tâche | (Q)uitter");
                }
                // 4. Récupérer le choix
                choix = Console.ReadLine()!;
                // 5. Traiter le choix
                if(choix == "A")
                {
                    // 5.1 Ajouter une tache
                    Console.WriteLine("Quelle nouvelle tâche voulez-vous ajouter ?");
                    string tache = Console.ReadLine()!;
                    taches.Add(tache);
                }
                if (choix == "S" && taches.Count > 0)
                {
                    // 5.2 Supprimer une tache
                    Console.WriteLine("Quelle tâche voulez-vous supprimer ?");
                    string tache = Console.ReadLine()!;
                    bool estSupprime = taches.Remove(tache);
                    if (estSupprime)
                    {
                        Console.WriteLine("La tâche a été supprimée.");
                    }
                    else
                    {
                        Console.WriteLine($"La tâche '{tache}' ne figure pas dans la liste.");
                    }
                    // Console.ReadLine() seul permet de faire une pause tantque l'on appuie pas sur ENTER
                    Console.ReadLine();
                }
                if (choix == "F" && taches.Count > 0)
                {
                    // 5.3 Finaliser une tache
                    Console.WriteLine("Quelle tâche voulez-vous finaliser ?");
                    string tache = Console.ReadLine()!;
                    bool estSupprime = taches.Remove(tache);
                    if (estSupprime)
                    {
                        tachesFinies.Add(tache);
                        Console.WriteLine("La tâche a été finalisée.");
                    }
                    else
                    {
                        Console.WriteLine($"La tâche '{tache}' ne figure pas dans la liste.");
                    }
                    // Console.ReadLine() seul permet de faire une pause tantque l'on appuie pas sur ENTER
                    Console.ReadLine();
                }
                // TANTQUE vous ne voulez pas QUITTER
            } while (choix != "Q");
            // 5.4 Quitter le programme
            Console.WriteLine("Merci d'avoir utilisé le gestionnaire de tâche.");
        }
    }
}
