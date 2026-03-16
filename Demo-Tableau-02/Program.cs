namespace Demo_Tableau_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            bool[] tab = new bool[10];
            tab[0] = true;

            for (int i = 0; i < 10; i++)
            {
                if (tab[i] == true)
                {
                    Console.Write("P");
                }
                else
                {
                    Console.Write("-");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Que voulez-vous faire?\n(G)auche-(D)roite-(Q)uitter");
            string choix = Console.ReadLine()!;
        }
    }
}
