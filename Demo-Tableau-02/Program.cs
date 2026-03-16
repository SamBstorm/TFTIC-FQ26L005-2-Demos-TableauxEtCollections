namespace Demo_Tableau_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            bool[] tab = new bool[10];

            ushort position = 0;
            tab[position] = true;

            string choix;
            do
            {
                #region Affichage
                Console.Clear();
                for (int i = 0; i < 10; i++)
                {
                    if (tab[i] == true)
                    {
                        Console.Write("😁");
                    }
                    else
                    {
                        Console.Write("⏹️");
                    }
                }
                Console.WriteLine();
                #endregion
                #region Menu utilisateur
                Console.WriteLine("Que voulez-vous faire?\n(G)auche-(D)roite-(Q)uitter");
                choix = Console.ReadLine()!;
                #endregion
                #region Déplacement pion
                tab[position] = false;
                if (choix == "G")
                {
                    //Déplacement vers la gauche
                    if(position > 0)
                    {
                        position--;
                    }
                }
                else if (choix == "D")
                {
                    //Déplacement vers la droite
                    if(position < 9)
                    {
                        position++;
                    }
                }
                tab[position] = true;
                #endregion
            } while (choix != "Q");
        }
    }
}
