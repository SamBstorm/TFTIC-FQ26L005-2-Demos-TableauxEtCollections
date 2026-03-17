namespace Demo_Aleatoire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random RNG = new Random();

            const int MIN = 1;
            const int MAX = 10;

            int NbAleatoire = RNG.Next(MIN, MAX + 1); 
            //Minimum inclus donc de 1, mais maximum non inclus : 10 + 1

            string[] valeurs = ["Toto", "Titi"]; 
            //Les indices vont de 0 à 1

            int indiceAleatoire = RNG.Next(valeurs.Length); 
            //Donne une valeur de 0 à la taille du tableau non-inclus, donc ici, de 0 à 1
        }
    }
}
