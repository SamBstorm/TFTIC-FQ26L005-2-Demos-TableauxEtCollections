using System.Collections;

namespace Demo_Collection_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour, veuillez encoder vos produits.");
            Console.WriteLine("Une fois terminé, écrivez 'FIN'");

            Hashtable listCourse = new Hashtable();

            //Ce Hashtable permet d'enregistrer les courses en paire : "Produit : Quantité"
            //Je dois donc demander le nom du produit qui se doit d'être unique
            //Ensuite la quantité.

            string product;
            do
            {
                ushort quantity;    //entre 0 et 65535
                Console.WriteLine("Veuillez entrer le nom du produit : ");
                product = Console.ReadLine()!;
                if(product != "FIN" && !listCourse.ContainsKey(product))
                {
                    Console.WriteLine($" Combien de {product} voulez-vous ?");
                    quantity = ushort.Parse(Console.ReadLine()!);
                    listCourse.Add(product, quantity);
                }
            }
            while (product != "FIN");

            Console.WriteLine($"Vous devez acheter {listCourse.Count} produits différents :");

            foreach (DictionaryEntry enregistrementCleValeur in listCourse)
            {
                Console.WriteLine($" - {enregistrementCleValeur.Key} X {enregistrementCleValeur.Value}");
            }
        }
    }
}
