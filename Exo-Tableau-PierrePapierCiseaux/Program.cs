namespace Exo_Tableau_PierrePapierCiseaux
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-<= PIERRE PAPIER CISEAUX =>-");

            string[] valeurs = [ "Pierre", "Papier", "Ciseaux" ];

            Console.WriteLine("Que choisissez-vous ?");

            foreach (string valeur in valeurs)
            {
                Console.WriteLine($" - {valeur}");
            }

            string choix;
            bool estDansTableau = false;
            do
            {
                choix = Console.ReadLine()!;
                foreach (string valeur in valeurs)
                {
                    if (choix.ToLower() == valeur.ToLower())
                    {
                        estDansTableau = true;
                    }
                }
            } while (!estDansTableau);

            Random RNG = new Random();

            int indiceRandom = RNG.Next(valeurs.Length);

            string choixCPU = valeurs[indiceRandom];

            Console.WriteLine($"L'ordinateur a choisi : {choixCPU}");
            if(choix.ToUpper() == choixCPU.ToUpper())
            {
                Console.WriteLine("Égalité !");
            }
            else if(
                (choix.ToLower() == "papier" && choixCPU == "Pierre") || 
                (choix.ToLower() == "pierre" && choixCPU == "Ciseaux") || 
                (choix.ToLower() == "ciseaux" && choixCPU == "Papier")
                )
            {
                Console.WriteLine("Vous avez gagné !");
            }
            else
            {
                Console.WriteLine("Vous avez perdu...");
            }
        }
    }
}
