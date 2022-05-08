using WordNamespace;
using GuessedWordNamespace;
using SelectedWordNamespace;
namespace KnockOffWordle
{
    class Game
    {
        static void Main(string[] args)
        {
            string[] Words = File.ReadAllLines("Words.txt");

            Random numberGenerator = new Random();
            int random = 0;

            for(int i=0;i<1;i++)
            {
                random = numberGenerator.Next(0,598);
            }

            string theSelectedWord = (Words[random]);
            SelectedWord selectedWordRef = new SelectedWord(theSelectedWord);

            Console.WriteLine("Type your guess (lowercase only)");

            for(int i=0;i<7;i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                //Console.WriteLine(selectedWordRef.WordValue);  TESTING PURPOSES
                string playerGuess = Convert.ToString(Console.ReadLine());  
                GuessedWord guessedWordRef = new GuessedWord(playerGuess);

                /*char letter0 = selectedWordRef.WordValue[0];
                char letter1 = selectedWordRef.WordValue[1];
                char letter2 = selectedWordRef.WordValue[2];
                char letter3 = selectedWordRef.WordValue[3];
                char letter4 = selectedWordRef.WordValue[4];

                char correctLetter0 = guessedWordRef.WordValue[0];
                char correctLetter1 = guessedWordRef.WordValue[1];
                char correctLetter2 = guessedWordRef.WordValue[2];
                char correctLetter3 = guessedWordRef.WordValue[3];
                char correctLetter4 = guessedWordRef.WordValue[4];*/

                for(int j=0;j<5;j++)
                {
                    if (guessedWordRef.WordValue[j]==selectedWordRef.WordValue[j])
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(guessedWordRef.WordValue[j]);
                    }

                    else if(selectedWordRef.WordValue.Contains(guessedWordRef.WordValue[j]))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(guessedWordRef.WordValue[j]);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(guessedWordRef.WordValue[j]);
                    }
                }

                Console.WriteLine("");

                /*//First Letter
                if (letter0 == correctLetter0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The First Letter Matches!");
                }
                else if (letter1 == correctLetter0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("The First Letter Is In The Wrong Position");
                }
                else if (letter2 == correctLetter0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("The First Letter Is In The Wrong Position");
                }
                else if (letter3 == correctLetter0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("The First Letter Is In The Wrong Position");
                }
                else if (letter4 == correctLetter0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("The First Letter Is In The Wrong Position");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The First Letter Does Not Match");
                }

                //Second Letter
                if (letter1 == correctLetter1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The Second Letter Matches!");
                }
                else if (letter0 == correctLetter1)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("The Second Letter Is In The Wrong Position");
                }
                else if (letter2 == correctLetter1)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("The Second Letter Is In The Wrong Position");
                }
                else if (letter3 == correctLetter1)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("The Second Letter Is In The Wrong Position");
                }
                else if (letter4 == correctLetter1)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("The Second Letter Is In The Wrong Position");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The Second Letter Does Not Match");
                }

                //Third Letter
                if (letter2 == correctLetter2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The Third Letter Matches!");
                }
                else if (letter0 == correctLetter2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("The Third Letter Is In The Wrong Position");
                }
                else if (letter1 == correctLetter2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("The Third Letter Is In The Wrong Position");
                }
                else if (letter3 == correctLetter2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("The Third Letter Is In The Wrong Position");
                }
                else if (letter4 == correctLetter2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("The Third Letter Is In The Wrong Position");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The Third Letter Does Not Match");
                }

                //Fourth Letter
                if (letter3 == correctLetter3)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The Fourth Letter Matches!");
                }
                else if (letter0 == correctLetter3)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("The Fourth Letter Is In The Wrong Position");
                }
                else if (letter1 == correctLetter3)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("The Fourth Letter Is In The Wrong Position");
                }
                else if (letter2 == correctLetter3)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("The Fourth Letter Is In The Wrong Position");
                }
                else if (letter4 == correctLetter3)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("The Fourth Letter Is In The Wrong Position");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The Fourth Letter Does Not Match");
                }

                //Fifth Letter
                if (letter4 == correctLetter4)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The Fifth Letter Matches!");
                    Console.WriteLine("");
                }
                else if (letter0 == correctLetter4)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("The Fifth Letter Is In The Wrong Position");
                    Console.WriteLine("");
                }
                else if (letter1 == correctLetter4)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("The Fifth Letter Is In The Wrong Position");
                    Console.WriteLine("");
                }
                else if (letter2 == correctLetter4)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("The Fifth Letter Is In The Wrong Position");
                    Console.WriteLine("");
                }
                else if (letter3 == correctLetter4)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("The Fifth Letter Is In The Wrong Position");
                    Console.WriteLine("");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The Fifth Letter Does Not Match");
                    Console.WriteLine("");
                }*/

                //Win
                if (guessedWordRef.WordValue==selectedWordRef.WordValue)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You guessed the word!");
                    i = 1000;
                }

            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("The Word Was: " + selectedWordRef.WordValue);
        }
    }

    

    

    
}