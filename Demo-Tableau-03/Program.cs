namespace Demo_Tableau_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Une seule dimension avec 7 valeurs
            //string[] dayNames = ["Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche"];

            //string[] dayNames = new string[7];

            //string[,] dayNames = new string[2, 7];
            string[,] dayNames = {
                    { "Dimanche","Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi"  },
                    { "Zondag","Mandag","Dinsdag","Woensdag","Donderdag","Vrijdag","Zaterdag" }
            };

            int jourAujourdhui = (int)DateTime.Now.DayOfWeek;

            Console.WriteLine($"Aujourd'hui, nous sommes {dayNames[0,jourAujourdhui]}.");
            Console.WriteLine($"Vaandag, we zijn {dayNames[1,jourAujourdhui]}.");
        }
    }
}
