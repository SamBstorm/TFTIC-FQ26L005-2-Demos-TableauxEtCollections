namespace Exo_Collection_CourseTortues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MIN = 2;
            const int MAX = 10;
            Random RNG = new Random();

            Console.WriteLine("Turtle race!");

            int nbTortue;
            bool estConverti;
            do
            {
                Console.WriteLine("Combien de tortues participantes ?");
                estConverti = int.TryParse(Console.ReadLine(), out nbTortue);
            } while (!estConverti || nbTortue < 2);

            Dictionary<string, ushort> listeTortues = new Dictionary<string, ushort>();

            for (int i = 0; i < nbTortue; i++)
            {
                string nomTortue;
                do
                {
                    Console.WriteLine("Veuillez indiquer le nom de votre tortue : ");
                    nomTortue = Console.ReadLine()!;
                } while (string.IsNullOrWhiteSpace(nomTortue) || listeTortues.ContainsKey(nomTortue));
                listeTortues.Add(nomTortue,0);
                Console.WriteLine($"La tortue '{nomTortue}' est bien inscrite!");
            }

            Console.WriteLine($"Bienvenue dans la course folle des tortues!");
            Console.WriteLine($"À vos marques! Prêt? GO! ");

            for (int phase = 0; phase < 4; phase++)
            {
                foreach (string nomTortue in listeTortues.Keys)
                {
                    //listeTortues[nomTortue] = (ushort)(listeTortues[nomTortue] + RNG.Next(MIN, MAX + 1));
                    listeTortues[nomTortue] += (ushort)RNG.Next(MIN, MAX + 1);
                }

                Console.WriteLine($"Podium de la phase {phase + 1} :");
                List<string> podium = new List<string>();

                for (int i = 0; i < 3; i++)
                {
                    string gagnanteActuelle = "";
                    ushort maxDistance = 0;
                    foreach (KeyValuePair<string, ushort> tortueDistance in listeTortues)
                    {
                        if(tortueDistance.Value > maxDistance && !podium.Contains(tortueDistance.Key))
                        {
                            maxDistance = tortueDistance.Value;
                            gagnanteActuelle = tortueDistance.Key;
                        }
                    }
                    podium.Add(gagnanteActuelle);
                }

                for(int i = 0; i < podium.Count; i++)
                {
                    Console.WriteLine($"{i+1}° place : {podium[i]}");
                }
            }
        }
    }
}
