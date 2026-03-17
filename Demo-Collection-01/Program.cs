using System.Collections;

namespace Demo_Collection_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour, veuillez encoder le nom de vos élèves.");
            Console.WriteLine("Quand vous avez terminer, inscrivez 'FIN' ");

            ArrayList listEleves = new ArrayList();

            string studentName;
            do
            {
                Console.WriteLine("Veuillez introduire un nom :");
                studentName = Console.ReadLine()!;
                if(studentName != "FIN")
                {
                    listEleves.Add(studentName);
                }
            } while (studentName != "FIN");

            Console.WriteLine($"Vous avez encodé {listEleves.Count} élèves.");
            for (int i = 0; i < listEleves.Count; i++)
            {
                string name = (string)listEleves[i]!;
                Console.WriteLine($" - {name}");
            }
        }
    }
}
