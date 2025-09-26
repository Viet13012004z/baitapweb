using System;
using ScoreLibrary;

class Program
{
    static void Main()
    {
        var score = new ScoreManager();
        score.Add(100);
        Console.WriteLine("Score: " + score.Score);
    }
}
