namespace Demo_Tableau_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0 && args[0] == "essential")
            {
                Console.WriteLine("Coucou les Essentials4IT!");
            }
            //int[] ints = { 1, 2, 3, 4 };
            //int[] ints = [ 1, 2, 3, 4 ];
            int[] ints = null;
            ints = new int[4];
            ints[0] = 1;
            ints[1] = 2;
            ints[2] = 3;
            ints[3] = 4;
            Console.WriteLine("Fin du programme");
            Console.ReadLine();
        }
    }
}
