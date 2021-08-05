using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        
        static void Main(string[] args)
        {
        // randomArray();
        // TossCoin();
        Names();


        }
            // Random Array
        public static int[] randomArray()
        {
            Random rand = new Random();
            int [] array1 = new int [10];
            for(int val = 0; val < array1.Length; val++){
                array1[val] = rand.Next(5,26);
            }

            int i, max, min, n;
            n = 10;
            max = array1[0];
            min = array1[0];
            for(i = 1; i < n; i++) {
                if(array1[i]>max){
                    max = array1[i];
                }
                if(array1[i]<min){
                    min = array1[i];
                }
            }

            int sum = 0;
            for(int j = 0; j < array1.Length; j++){
                sum += array1[j];
            }
            Console.WriteLine("[{0}]", string.Join(", ", array1));
            Console.WriteLine("Max = {0}", max);
            Console.WriteLine("Min = {0}", min);
            Console.WriteLine("Sum = {0}", sum);
            return array1;
        }
        
        // Coin Toss
        public static void TossCoin()
        {
            Console.WriteLine("Tossing a Coin!");
            string[] choose = {"Heads", "Tails"};
            Console.WriteLine("Call it in the air, Heads or Tails");
            Random c = new Random();
            bool flipState = false;
            int i = c.Next(0, 2);
            int tries = 1;
            do
            {
                if (Console.ReadLine() != choose[i])
                {
                    Console.WriteLine($"Hmm, maybe next time. The coin landed on {choose[i]}");
                    tries++;
                    i = c.Next(0, 2);
                    Console.WriteLine("Choose: Heads or Tails");
                }
                else
                {
                    Console.WriteLine($"Good call, you got it right {tries} times");
                    flipState = true;
                }
                Console.WriteLine("");
            } while (flipState == false);
            Console.WriteLine("Hit a random key to end game");
            Console.ReadKey(true);
        }

        // Names

        public static void Names()
        {
            Random rand = new Random();
            List<string> peopleNames = new List<string>();
            peopleNames.Add("Todd");
            peopleNames.Add("Tiffany");
            peopleNames.Add("Charlie");
            peopleNames.Add("Geneva");
            peopleNames.Add("Sydney");
            for(int i = 0; i <= peopleNames.Count-1; i++){
                // Console.WriteLine(i);
                int j= rand.Next(peopleNames.Count);
            string temp = peopleNames[i];
            peopleNames[i] = peopleNames[j];
            peopleNames[j] = temp;
            peopleNames.Remove("Todd");
                // Console.WriteLine(j);
            }
            foreach (string people in peopleNames)
            {
                Console.WriteLine("-" + people);
            }
        }
    }
}
