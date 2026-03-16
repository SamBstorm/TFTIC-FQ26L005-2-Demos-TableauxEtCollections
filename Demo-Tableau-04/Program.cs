namespace Demo_Tableau_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] dayNames = [
                ["Dimanche","Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi"],
                ["Zondag","Mandag","Dinsdag","Woensdag","Donderdag","Vrijdag","Zaterdag"]
            ];

            int jourAujourdhui = (int)DateTime.Now.DayOfWeek;

            Console.WriteLine($"Aujourd'hui, nous sommes {dayNames[0][jourAujourdhui]}.");
            Console.WriteLine($"Vaandag, we zijn {dayNames[1][jourAujourdhui]}.");

            Console.WriteLine("Voici les jours de la semaine :");
            for (int langue = 0; langue < 2; langue++)
            {
                for (int jour = 0; jour < 7; jour++)
                {
                    Console.Write($"[{dayNames[langue][jour]}] ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Voici les jours de la semaine :");
            for (int jour = 0; jour < 7; jour++)
            {
                for (int langue = 0; langue < 2; langue++)
                {
                    Console.Write($"[{dayNames[langue][jour]}] ");
                }
                Console.WriteLine();
            }
        }
    }
}
