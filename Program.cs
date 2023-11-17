using System;

namespace TicTacToe
{
    class Program
    {

        static char[] field = { '1', '2', '3',
                                '4', '5', '6', 
                                '7', '8', '9'};
        static int player = 1;
        static byte place;
        static char pr;

        static void Main(string[] args)
        {
            
            
            do {
                Console.Clear();
                Console.WriteLine("Крестики - Нолики");
                Console.WriteLine("---------------------\n");
                if (player % 2 == 0) {
                    Console.WriteLine("Ход игрока X\n");
                    pr = 'X';
                } else {
                    Console.WriteLine("Ход игрока O\n");
                         pr = 'O'; };
                Console.WriteLine("| {0} | {1} | {2} |", field[0], field[1], field[2]);
                Console.WriteLine("| {0} | {1} | {2} |", field[3], field[4], field[5]);
                Console.WriteLine("| {0} | {1} | {2} |", field[6], field[7], field[8]);
                Console.WriteLine("\n");
                Console.WriteLine("Выберите место");
                place = byte.Parse(Console.ReadLine());
                place--;
                if (field[place] != 'X' && field[place] != 'O') ActivePlayer();
                
            } while (!RowWinner());

            Console.WriteLine("Победил игрок {0} ", pr);

        }

        private static void ActivePlayer() {
            if (player % 2 == 0)
            {
                field[place] = 'X';
            }
            else field[place] = 'O';
            player++;
        }


        public static bool RowWinner() {

            if (field[0] == field[1] && field[1] == field[2]) { return true; 
            } 
            else if (field[3] == field[4] && field[4] == field[5]){ return true;
            }
            else if (field[6] == field[7] && field[7] == field[8]){ return true;
            } 
            else if (field[0] == field[3] && field[3] == field[6]){ return true;
            }
            else if (field[1] == field[4] && field[4] == field[7]){ return true;
            }
            else if (field[2] == field[5] && field[5] == field[8]){ return true;
            }
            else if (field[0] == field[4] && field[4] == field[8]){ return true;
            }
            else if (field[2] == field[4] && field[4] == field[6]){ return true;
            }

            return false;
        }
    }
}