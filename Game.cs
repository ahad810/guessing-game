using System;

namespace GuessingGame
{
    public class Game
    {
        private readonly Random random = new Random();
        private int targetNumber;
        private int guessCount;
        private int gamesPlayed;
        private int bestScore = int.MaxValue;

        public Game()
        {
            NewGame();
        }

        public void NewGame()
        {
            targetNumber = random.Next(1, 1001);
            guessCount = 0;
            gamesPlayed++;
        }

        public (string message, bool isCorrect) CheckGuess(int guess)
        {
            guessCount++;
            
            if (guess == targetNumber)
            {
                if (guessCount < bestScore)
                {
                    bestScore = guessCount;
                }
                
                string performanceMessage = guessCount < 10 ? 
                    "\nI think you know the secret!" : 
                    "\nYou can do better!";
                    
                return ($"Excellent!{performanceMessage}", true);
            }
            
            string hint = guess < targetNumber ? "Too low" : "Too high";
            string encouragement = guessCount < 5 ? "You're doing great!" : 
                                 guessCount < 10 ? "Keep trying!" : 
                                 "Don't give up!";
            
            return ($"{hint}. {encouragement}", false);
        }

        public (int CurrentGuesses, int BestScore, int GamesPlayed) GetStatistics()
        {
            return (guessCount, bestScore == int.MaxValue ? 0 : bestScore, gamesPlayed);
        }

        public int GetTargetNumber() => targetNumber;
    }
}
