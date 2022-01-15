using System;

public class PlayGame
{
    public void Start()
    {
        Console.WriteLine("\n Choose which of the games you want to play ?");
        Console.WriteLine("\t1 - Higher or Lower");
        Console.WriteLine("\t2 - Heads or Tails");

        string? userChoice;
        userChoice = Console.ReadLine();
        switch (userChoice)
        {
            case "1":
                HigherOrLower();
                break;
            case "2":
                HeadsOrTails();
                break;
        }

    }

    void HeadsOrTails()
    {
        Console.WriteLine("\n Guess between Heads or Tails");

        string? userChoice;
        userChoice = Console.ReadLine()?.ToUpper();

        if (userChoice == PickAnswerHT())
        {
            Console.WriteLine("\n Congratulations, You guessed the right answer");
            PlayHTAgain();
        }
        else
        {
            Console.WriteLine("\n You guessed wrong");
            PlayHTAgain();
        }
    }

    void PlayHTAgain()
    {
        Console.WriteLine("\n Do you want to play Heads or tails again ?");
        Console.WriteLine("\n Y/N");
        string? answer;
        answer = Console.ReadLine()?.ToUpper();
        if (answer == "Y")
            HeadsOrTails();
        else
            Start();
    }

    string PickAnswerHT()
    {
        string[] ht = { "HEADS", "TAILS" };
        string answer;
        Random rnd = new Random();
        int index = rnd.Next(ht.Length);
        answer = ht[index];
        return answer;

    }

    void HigherOrLower()
    {
        Console.WriteLine("\n Guess a number between 1 and 10, you have 5 tries");
        int answer = PickAnswerHL();

        for (int i = 0; i <= 5; i++)
        {
            int userChoice;
            userChoice = Convert.ToInt32(Console.ReadLine());

            if (userChoice == answer)
            {
                Console.WriteLine("\n Congratulations, You guessed the right answer");
                PlayHLAgain();
            }
            else if (userChoice > answer)
            {
                Console.WriteLine("\n Guess lower");
            }
            else if (userChoice < answer)
            {
                Console.WriteLine("\n Guess Higher");
            }
        }
        Console.WriteLine("\n You've made 5 uesses without getting the number right");
        PlayHLAgain();
    }

    void PlayHLAgain()
    {
        Console.WriteLine("\n Do you want to play Higher or lower again ?");
        Console.WriteLine("\n Y/N");
        string? answer;
        answer = Console.ReadLine()?.ToUpper();
        if (answer == "Y")
            HigherOrLower();
        else
            Start();
    }

    int PickAnswerHL()
    {
        int answer;
        Random rnd = new Random();
        answer = rnd.Next(1, 10);
        return answer;
    }
}