using System;

class Program
{


    static void Main(string[] args)
    {
        Console.WriteLine(args.Length);
        PlayGame newGame = new PlayGame();
        newGame.Start();

    }


}