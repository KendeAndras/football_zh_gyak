using System.Security.Cryptography.X509Certificates;

namespace football
{
    internal class Program
    {
        struct Match
        {
            public string home;
            public string guest;
            public int homeGoals;
            public int guestGoals;
        }

        static int inData()
        {
            int data;
            string inputText = Console.ReadLine();
            data = int.Parse(inputText);
            return data;
        }

        static string inStringData()
        {
            string data;
            string inputText = Console.ReadLine();
            data = inputText;
            return data;
        }
        static Match[] CreateMatchBlock(int count)
        {
            Match[] blockElements = new Match[count+1];
            string inputText;
            for (int i = 1; 1 <= count; i++)
            {
                inputText = Console.ReadLine();
                string[] row = inputText.Split(" ");
                blockElements[i].home = row[1];
                blockElements[i].guest = row[2];
                blockElements[i].homeGoals = Convert.ToInt32(row[3]);
                blockElements[i].guestGoals = Convert.ToInt32(row[4]);
            }
            return blockElements;
        }

        static string MaxGoals(Match[] match, int count)
        {
            string mg = "";
            for (int i = 1; i <= count; i++)
            {
                
            }
            return mg;
        }
        static void Main(string[] args)
        {
            //Beolvasas
            int length = inData();
            string team = inStringData();

            //Tomb deklaralas&beolvasas
            Match[] tournament = CreateMatchBlock(length);

            //1. feladat
            MaxGoals(tournament, length);
            
            
        }
    }
}