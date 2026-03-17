namespace Exo_Tableau_Temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int heureStart;
            do {
                Console.WriteLine("Indiquez l'heure de départ de l'encodage :");                
            } while (!int.TryParse(Console.ReadLine()!, out heureStart) || heureStart < 0 || heureStart > 23);


            int heureEnd;
            do
            {
                Console.WriteLine("Indiquez l'heure de fin de l'encodage :");
            } while (!int.TryParse(Console.ReadLine()!, out heureEnd) || heureEnd <= heureStart || heureEnd > 24);

            int nbHeures = (heureEnd - heureStart) +1;

            double[] temps = new double[nbHeures];

            for (int i = 0; i < temps.Length; i++)
            {
                do {
                    Console.WriteLine($"Quelle température à {heureStart + i}h ?");
                } while (!double.TryParse(Console.ReadLine()!.Replace('.', ','), out temps[i]));
            }

            double min, max, moy;
            min = max = moy = temps[0];

            for (int i = 1; i < temps.Length; i++)
            {
                if (temps[i] < min)
                {
                    min = temps[i];
                }
                else if (temps[i] > max)
                {
                    max = temps[i];
                }
                moy += temps[i];
            }

            moy /= temps.Length;

            Console.WriteLine($"La moyenne de température entre {heureStart}h et {heureEnd}h est de {moy}°C");
            Console.WriteLine($"Les températures sont comprises entre {min} et {max}°C");
        }
    }
}
