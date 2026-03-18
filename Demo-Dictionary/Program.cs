namespace Demo_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> bibliotheques = new Dictionary<string, string>();

            bibliotheques.Add("978-2266155489", "Dune");
            bibliotheques.Add("978-2070360024", "L'étranger");
            bibliotheques.Add("978-2070408504", "Le petit prince");
            bibliotheques.Add("978-2070368228", "1984");
            bibliotheques.Add("978-2290135112", "Kilomètre zéro");

            foreach (KeyValuePair<string,string> ISBNplusTitle in bibliotheques)
            {
                Console.WriteLine($"ISBN : {ISBNplusTitle.Key} \tTitle : {ISBNplusTitle.Value}");
            }

            foreach (string ISBN in bibliotheques.Keys)
            {
                bibliotheques[ISBN] = "Toto";
                Console.WriteLine($"ISBN : {ISBN} \tTitle : {bibliotheques[ISBN]}");
            }
        }
    }
}
