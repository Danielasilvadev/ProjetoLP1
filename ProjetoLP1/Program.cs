using System;

namespace ProjectLP1
{
    class Program
    {

        private int RandNum(int x, int y)
        {
            Random rnd = new Random();
            int num =rnd.Next(x, y);
            return num;
        }
        public int [][] board;

        private int[][] BoardCreation()
        {
            board  = new int [5][];
            board [4] = new int [] {0, 0, 0, 0, 0};
            board [3] = new int [] {0, 0, 0, 0, 0};
            board [2] = new int [] {0, 0, 0, 0, 0};
            board [1] = new int [] {0, 0, 0, 0, 0};
            board [0] = new int [] {0, 0, 0, 0, 0};


            board[0][0] = 1;
            board[5][5] = 1;

            int snake_c = RandNum(0, 5);
            int snake_l = RandNum(1, 5);

            int ladders_c = RandNum(0, 5);
            int ladders_l = RandNum(0, 4);

            int Cobra_c = RandNum(0, 5);
            int Cobra_l = RandNum(2, 5);

            int Boost_c = RandNum(0, 5);
            int Boost_l = RandNum(0, 4);

            int UTurn_c = RandNum(0, 5);
            int UTurn_l = RandNum(1, 5);
                
            int ExtraDie_c = RandNum(0, 5);
            int ExtraDie_l = RandNum(0, 5);

            int CheatDie_c = RandNum(0, 5);
            int CheatDie_l = RandNum(0, 5);

            board [snake_c][snake_l] = 2;

            while (board [ladders_c][ladders_l] != 0)
            {
                ladders_c = RandNum(0, 5);
                ladders_l = RandNum(0, 4);
            }
            board [ladders_c][ladders_l] = 3;

            while (board [Cobra_c][Cobra_l] != 0)
            {
                Cobra_c = RandNum(0, 5);
                Cobra_l = RandNum(2, 5);
            }
            board [Cobra_c][Cobra_l] = 4;

            while (board [Boost_c][Boost_l] != 0)
            {
                Boost_c = RandNum(0, 5);
                Boost_l = RandNum(0, 4);
            }
            board [Boost_c][Boost_l] = 5;

            while (board [Boost_c][Boost_l] != 0)
            {
                UTurn_c = RandNum(0, 5);
                UTurn_l = RandNum(1, 5);
            }
            board [UTurn_c][UTurn_l] = 6;

            while (board [ExtraDie_c][ExtraDie_l] != 0)
            {
                ExtraDie_c = RandNum(0, 5);
                ExtraDie_l = RandNum(0, 5);
            }
            board [ExtraDie_c][ExtraDie_l] = 7;

            while (board [CheatDie_c][CheatDie_l] != 0)
            {
                CheatDie_c = RandNum(0, 5);
                CheatDie_l = RandNum(0, 5);
            }
            board [CheatDie_c][CheatDie_l] = 8;

            return board;
        }



        private static void Main(string[] args)
        {

            //Board board = new Board();
            BoardCreation();
            int player_pos = 0;
            int dice = RandNum(1, 7);
            player_pos += dice;
            Console.WriteLine($"{board}");

        }
    }
}
