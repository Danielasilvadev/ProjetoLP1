using System;

namespace ProjectLP1
{
    class Program
    {
        /// <summary>
        /// Metodo que serve para gerar numeros aleatórios, foi criada porque a rnd seria chamada demasiada chamada
        /// </summary>
        /// <param name="x">Número minimo do gerador de números aleatório</param>
        /// <param name="y">Número maximo do gerador de números aleatório</param>
        /// <returns>Um número aleatório</returns>
        private static int RandNum(int x, int y)
        {
            Random rnd = new Random();
            int num =rnd.Next(x, y);
            return num;
        }

        /// <summary>
        /// Variável que serve como mapa de jogo
        /// </summary>
        private static int [][] board;

        /// <summary>
        /// Este metodo cria a board de jogo com todas as especificações de cada casa e verifica se que
        /// todas as casas não ficam sobrepostas 
        /// </summary>
        /// <returns>Nada, apenas altera a board</returns>
        private static int [][] BoardCreation()
        {
            board  = new int [5][];
            board [4] = new int [] {0, 0, 0, 0, 0};
            board [3] = new int [] {0, 0, 0, 0, 0};
            board [2] = new int [] {0, 0, 0, 0, 0};
            board [1] = new int [] {0, 0, 0, 0, 0};
            board [0] = new int [] {0, 0, 0, 0, 0};


            board[0][0] = 1;
            board[4][4] = 1;

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

        /// <summary>
        /// Metodo que é usado de cada vez que se quer lançar um dado
        /// </summary>
        /// <param name="player_pos">A posição atual do jogador</param>
        /// <returns></returns>
        private static int PlayerMovement(int player_pos)
        {
            int dice = RandNum(1, 7);
            player_pos += dice;
            return player_pos;
        }

        /// <summary>
        /// Metodo que é chamado de cada vez que se quer mostrar ao jogador o estado da board
        /// </summary>
        /// <param name="current_position">Posição atual do jogador</param>
        private static void PrintBoard (int current_position)
        {
            for (int i = 10; i > board.Length; i--)
            {
                int x = 0;

                for (int j = 0; j < board[x].Length; j++)
                {
                    Console.Write($"||{board[i][j]}||");
                }

                Console.WriteLine(" ");
                x++;
            }
        }

        private static void Main(string[] args)
        {

            Board board = new Board();
            //Criar a board de jogo
            Program.BoardCreation();
            //Os jogadores começam na posição 0
            int start_position = 0;
            //Um dado é lançado e a posição do jogador é atualizada
            int current_position = Program.PlayerMovement(start_position);
            //A board é imprimida para mostrar onde o jogador está neste turno
            Program.PrintBoard(current_position);


        }
    }
}
