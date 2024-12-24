namespace TicTacToe;

class Program
{
    static string[,] table = {{" "," "," "},
                            {" "," "," "},
                            {" "," "," "}} ;

    static bool gameOver = false;
    static int turns = 0;
    static void Main(string[] args)
    {
        Random random = new Random();
        Console.WriteLine("Welcome to Tic Tac Toe");
        while(!gameOver)
        {


            Console.Write("Write the row (1 - 3): ");
            int.TryParse(Console.ReadLine(),out int row);
            Console.Write("Write the column (1 - 3): ");
            int.TryParse(Console.ReadLine(),out int column); 
            
            while(column > 3 || column < 0 || row > 3 || row < 0 || table[row - 1,column - 1] != " ")
            {
                Console.WriteLine("Invalid row or column");
                Console.Write("Write the row (1 - 3): ");
                int.TryParse(Console.ReadLine(),out row);
                Console.Write("Write the column (1 - 3): ");
                int.TryParse(Console.ReadLine(),out column); 
            }
            
            for (int i = 0; i < table.GetLength(0);i++)
            {
                for (int j = 0;j < table.GetLength(1);j++)
                {
                    if(table[row - 1,column - 1] == " ")
                    {
                        table[row - 1,column - 1] = "X";
                        turns++;
                    }
                    
                    Console.Write("|{0}| ",table[i,j]);
                }

                Console.WriteLine("");
            }
            CheckWinner();



            if(!gameOver)
                CheckDraw();
            else
                break;

            int computerRow = random.Next(1,4);
            int computerColumn = random.Next(1,4);

            while(table[computerRow - 1,computerColumn - 1] != " ")
            {
                computerRow = random.Next(1,4);
                computerColumn = random.Next(1,4);
            }
            Console.WriteLine("crow: {0}, ccolumn: {1}",computerRow,computerColumn);

            Thread.Sleep(2000);
            for (int i = 0; i < table.GetLength(0);i++)
            {
                for (int j = 0;j < table.GetLength(1);j++)
                {
                    if(table[computerRow - 1,computerColumn - 1] == " ")
                    {
                        table[computerRow - 1,computerColumn - 1] = "O";
                    }
                    Console.Write("|{0}| ",table[i,j]);
                }

                Console.WriteLine("");
            }
            if(!gameOver)
                CheckDraw();
            else
                break;

            CheckWinner();
            
        }

    }

    private static void CheckWinner()
    {
        if(table[0,0] == "X" && table[0,1] == "X" && table[0,2] == "X")
            {
                Console.WriteLine("You win!");
                gameOver = true;
            }
            else if(table[1,0] == "X" && table[1,1] == "X" && table[1,2] == "X")
            {
                Console.WriteLine("You win!");
                gameOver = true;
            }
            else if(table[2,0] == "X" && table[2,1] == "X" && table[2,2] == "X")
            {
                Console.WriteLine("You win!");
                gameOver = true;
            }
            else if(table[0,0] == "X" && table[1,0] == "X" && table[2,0] == "X")
            {
                Console.WriteLine("You win!");
                gameOver = true;
            }
            else if(table[0,1] == "X" && table[1,1] == "X" && table[2,1] == "X")
            {
                Console.WriteLine("You win!");
                gameOver = true;
            }
            else if(table[0,2] == "X" && table[1,2] == "X" && table[2,2] == "X")
            {
                Console.WriteLine("You win!");
                gameOver = true;
            }
            else if(table[0,0] == "X" && table[1,1] == "X" && table[2,2] == "X")
            {
                Console.WriteLine("You win!");
                gameOver = true;
            }
            else if(table[0,2] == "X" && table[1,1] == "X" && table[2,0] == "X")
            {
                Console.WriteLine("You win!");
                gameOver = true;
            }


            if(table[0,0] == "O" && table[0,1] == "O" && table[0,2] == "O")
            {
                Console.WriteLine("You Loose!");
                gameOver = true;
            }
            else if(table[1,0] == "O" && table[1,1] == "O" && table[1,2] == "O")
            {
                Console.WriteLine("You Loose!");
                gameOver = true;
            }
            else if(table[2,0] == "O" && table[2,1] == "O" && table[2,2] == "O")
            {
                Console.WriteLine("You Loose!");
                gameOver = true;
            }
            else if(table[0,0] == "O" && table[1,0] == "O" && table[2,0] == "O")
            {
                Console.WriteLine("You Loose!");
                gameOver = true;
            }
            else if(table[0,1] == "O" && table[1,1] == "O" && table[2,1] == "O")
            {
                Console.WriteLine("You Loose!");
                gameOver = true;
            }
            else if(table[0,2] == "O" && table[1,2] == "O" && table[2,2] == "O")
            {
                Console.WriteLine("You Loose!");
                gameOver = true;
            }
            else if(table[0,0] == "O" && table[1,1] == "O" && table[2,2] == "O")
            {
                Console.WriteLine("You Loose!");
                gameOver = true;
            }
            else if(table[0,2] == "O" && table[1,1] == "O" && table[2,0] == "O")
            {
                Console.WriteLine("You Loose!");
                gameOver = true;
            }
    }

    private static void CheckDraw(){
        int rooms = 0;
        for(int i = 0;i < table.GetLength(0);i++)
        {
            for(int j = 0;j < table.GetLength(1);j++)
            {
                if(table[i,j] != " ")
                {
                    rooms++;
                }

                if(rooms == table.Length)
                {
                    Console.WriteLine("Draw!");
                    gameOver = true;
                }
            }
        }
    }
}