using System;

namespace GuessLetterGame
{
    class Program
    {
        static Random rand = new Random();

        static void Main(string[] args)
        {
            // Main loop: run while the user is willing to play.
            bool continuePlaying = true;
            while (continuePlaying)
            {
                // Generate a random number.
                char letter = (char)('a' + rand.Next() % 26);

                // Flag set when the user has found the correct letter.
                bool userHasWon = false;

                DateTimeOffset startTime = DateTimeOffset.UtcNow;

                int attemptsLeft = 10;
                // Game loop: run while the user has not yet guessed the correct answer and while it has some attempts left.
                for (; !userHasWon && attemptsLeft > 0; --attemptsLeft)
                {
                    Console.WriteLine("{0} more guess{1}.", attemptsLeft, attemptsLeft > 1 ? "es" : "");

                    // Read user guess loop: run until a single character has been provided.
                    string userInput;
                    while (true)
                    {
                        Console.Write("Your guess? ");

                        userInput = Console.ReadLine();

                        if (userInput.Length != 1)
                        {
                            Console.WriteLine("You must provide a single character, but you've provided {0}.", userInput.Length);
                        }
                        else if (userInput[0] < 'a' || userInput[0] > 'z')
                        {
                            Console.WriteLine("You must provide a character between 'a' and 'z'.");
                        }
                        else
                        {
                            // All seems fine.
                            break;
                        }
                    }

                    char userGuess = userInput[0];

                    // Check if the user's guess is correct.
                    if (userGuess == letter)
                    {
                        userHasWon = true;
                        Console.WriteLine("That was easy!");
                    }
                    else
                    {
                        Console.WriteLine("Nope! Try with a {0} letter.", userGuess < letter ? "bigger" : "smaller");
                    }
                }

                // The game loop has ended because the user has won...
                if (userHasWon)
                {
                    DateTimeOffset endTime = DateTimeOffset.UtcNow;

                    TimeSpan duration = endTime - startTime;

                    double hitRatio = 1.0 * (attemptsLeft + 1) / 10;
                    Console.WriteLine("You've won ... nothing!");
                    Console.WriteLine("Statistics:\n" +
                                      "\tHit ratio: {0:0.00}%\n" +
                                      "\tTotal time: {1:0.0}s", 100 * hitRatio, duration.TotalSeconds);
                }
                // ... or because he has exhausted all the attempts!
                else
                {
                    Console.WriteLine("Too bad! The anwser was '{0}'. Maybe next time...", letter);
                }

                bool continuePlayingAnswerIsValid = false;

                // Continue playing loop: run until the user answers "yes" or "no"
                while (!continuePlayingAnswerIsValid)
                {
                    Console.Write("Continue playing (yes or no)? ");

                    string continuePlayingAnswer = Console.ReadLine();

                    switch (continuePlayingAnswer)
                    {
                        case "yes":
                            continuePlayingAnswerIsValid = true;
                            continuePlaying = true;
                            break;
                        case "no":
                            continuePlayingAnswerIsValid = true;
                            continuePlaying = false;
                            break;
                        default:
                            continuePlayingAnswerIsValid = false;
                            break;
                    }
                }
            }

            Console.WriteLine("Bye!");
        }
    }
}
