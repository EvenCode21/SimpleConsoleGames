namespace GuessingGame;

class Game
{
    static Random random;
    public static void Start()
    {
        random = new Random();
        Console.WriteLine("Welcome to the guessing game\n");
        Console.Write("Please enter your name: ");
        var name = Console.ReadLine();
        int magicNum = random.Next(0,101);
        bool gameOver = false;
        int tries = 0;
        while(!gameOver)
        {
            Console.Write("Try to guess the number between 0 and 100: ");
            if(int.TryParse(Console.ReadLine(),out int number))
            {
                tries++;
                if(number == magicNum){
                    gameOver = true;
                    Console.WriteLine("Well done {2}!, the magic number was {0}. you completed the game with {1} tries!",magicNum,tries,name);
                }else if(number < magicNum){
                    Console.WriteLine("Too low!");
                }else{
                    Console.WriteLine("Too high!");
                }
            }
        }
    }
}