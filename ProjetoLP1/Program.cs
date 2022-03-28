using System;

namespace ProjectLP1
{
    class Program
    {
            static void Main(string[] args)
        {
            //por funçao aparte
            Random rnd = new Random();

            int snake_c = rnd.Next(0, 5);
            int snake_l = rnd.Next(0, 5);

            int ladders_c = rnd.Next(0, 5);
            int ladders_l = rnd.Next(0, 5);

            int Cobra_c = rnd.Next(0, 5);
            int Cobra_l = rnd.Next(2, 5);

            int Boost_c = rnd.Next(0, 5);
            int Boost_l = rnd.Next(0, 4);

            int UTurn_c = rnd.Next(0, 5);
            int UTurn_l = rnd.Next(1, 5);
            
            int ExtraDie_c = rnd.Next(0, 5);
            int ExtraDie_l = rnd.Next(0, 5);

            int CheatDie_c = rnd.Next(0, 5);
            int CheatDie_l = rnd.Next(0, 5);

            
            //tbm funçao aparte
            int [][] matrix  = new int [5][];
            matrix [0] = new int [] {0, 0, 0, 0, 0};
            matrix [1] = new int [] {0, 0, 0, 0, 0};
            matrix [2] = new int [] {0, 0, 0, 0, 0};
            matrix [3] = new int [] {0, 0, 0, 0, 0};
            matrix [4] = new int [] {0, 0, 0, 0, 0};

            int dado = rnd.Next(1, 7);

            


        }
    }
}
