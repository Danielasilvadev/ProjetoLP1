using System;

namespace ProjectLP1
{
    class Program
    {

        public int RandNum(int x, int y) => rnd.Next(x, y);

        public Perguntar ao stor BoardCreation()
        {
            int [][] board  = new int [5][];
            board [4] = new int [] {0, 0, 0, 0, 0};
            board [3] = new int [] {0, 0, 0, 0, 0};
            board [2] = new int [] {0, 0, 0, 0, 0};
            board [1] = new int [] {0, 0, 0, 0, 0};
            board [0] = new int [] {0, 0, 0, 0, 0};

            Random rnd = new Random();

            board[0][0] = 1;
            board[5][5] = 1;

            int snake_c = rnd.Next(0, 5);
            int snake_l = rnd.Next(1, 5);

            int ladders_c = rnd.Next(0, 5);
            int ladders_l = rnd.Next(0, 4);

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

            board [snake_c][snake_l] = 2;

            While (board [ladders_c][ladders_l] != 0)
            {
                ladders_c = rnd.Next(0, 5);
                ladders_l = rnd.Next(0, 4);
            }
            board [ladders_c][ladders_l] = 3;

            While (board [Cobra_c][Cobra_l] != 0)
            {
                Cobra_c = rnd.Next(0, 5);
                Cobra_l = rnd.Next(2, 5);
            }
            board [Cobra_c][Cobra_l] = 4;

            While (board [Boost_c][Boost_l] != 0)
            {
                Boost_c = rnd.Next(0, 5);
                Boost_l = rnd.Next(0, 4);
            }
            board [Boost_c][Boost_l] = 5;

            While (board [Boost_c][Boost_l] != 0)
            {
                UTurn_c = rnd.Next(0, 5);
                UTurn_l = rnd.Next(1, 5);
            }
            board [UTurn_c][UTurn_l] = 6;

            While (board [ExtraDie_c][ExtraDie_l] != 0)
            {
                ExtraDie_c = rnd.Next(0, 5);
                ExtraDie_l = rnd.Next(0, 5);
            }
            board [ExtraDie_c][ExtraDie_l] = 7;

            While (board [CheatDie_c][CheatDie_l] != 0)
            {
                CheatDie_c = rnd.Next(0, 5);
                CheatDie_l = rnd.Next(0, 5);
            }
            board [CheatDie_c][CheatDie_l] = 8;

            return board;
        }



        static void Main(string[] args)
        {
            BoardCreation();
            int player_pos = 0;
            int dice = rnd.Next(1, 7);
            player_pos += dice;
            Console.WriteLine($"{board}");

        }
    }
}
