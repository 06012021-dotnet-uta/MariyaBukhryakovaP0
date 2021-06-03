using System;

namespace rockpaperscissorsGame
{
    public enum RPSChoices
    {
        //creates a variable that I set to values
        Rock = 1,
        Paper = 2,
        Scissors = 3
        
    }
    partial class Program
    { 
//put together RPS game
/**

1.Start game
-loop start
2. prompt for user choice
3. computer will play against user
4. print result of each rounds
--loop ends
5. Print the winner
**/
        static void Main(string[] args)
        {
            //Greet user , ask for name and store name 
            Console.WriteLine("Welcome to Rock Paper Scissors!\nPlease enter your username below.");
            string playerName = Console.ReadLine();
            //Start play again loop for the entire game
            bool playGame = true;
            int gameCount = 0;
            int playerPointCount = 0;
            int housePointCount = 0;
            while(playGame){
                while (gameCount <3){
                //Ask for user choice and provide the choices 
                Console.WriteLine("Choose your hand:\n1.Rock\n2.Paper\n3.Scissors");
                string playerChoice = Console.ReadLine();
                ///create int variable to catch converted choice
                int playerChoiceInt;
                //Create conversion from string to int via Int32.Tryparse(string, out int) must be set to boolean val
                // if input can convert to int then it will continue running if it doesn't then it won't do anything
                bool fromStriToIntConvers = Int32.TryParse(playerChoice, out playerChoiceInt);
                // tells you if your choice is valid/true and what you chose
                if(fromStriToIntConvers == true) Console.WriteLine($"The conversion was {fromStriToIntConvers} user {playerName} chose {playerChoiceInt}");
                // tells you if you chose an invalid command and returns the default value
                 else Console.WriteLine($"The conversion was {fromStriToIntConvers}user {playerName} chose {playerChoiceInt}");

                 // now for the computer portion
                 //Ramdom number generator
                 Random rand = new Random();
                 //chooses random number between 1-3
                 int playTheHouse = rand.Next(1, Enum.GetNames(typeof(RPSChoices)).Length + 1);

                // now to check who won- checks to see if computer won, tie or user won
                // contains incremental counter for house/player based on results
                if (playerChoiceInt == 1 && playTheHouse == 2){
                     Console.WriteLine("Computer Wins!"); 
                     housePointCount++;
                }
                else if (playerChoiceInt == 2 && playTheHouse == 3){
                    Console.WriteLine("Computer Wins!");
                    housePointCount++;
                }    
                else if (playerChoiceInt == 3 && playTheHouse == 1){
                    Console.WriteLine("Computer Wins!");
                    housePointCount++;
                } 
                else if (playerChoiceInt == playTheHouse){
                    Console.WriteLine("It's a Tie!");
                    housePointCount++;
                    playerPointCount++;
                }
                else {
                    Console.WriteLine($"Congrats {playerName}! You won!");
                    playerPointCount++;
                }
// game counter so that we stay at the 3 game max
        gameCount++;
                }//end of 3 game loop
                //now to check and see who won the 3 matches
                if (playerPointCount == housePointCount) Console.WriteLine("You tied this match!");
                else if (playerPointCount > housePointCount) Console.WriteLine($"Congrats {playerName} you won this match! ");
                else Console.WriteLine("The house won this round!");

            
//Offers the user a choice to play another game or to quit
     Console.WriteLine("Do you want to play another match?\nPlease type in y for yes and q to quit.");
    string playAnotherGame = Console.ReadLine();
//now it shows a thank you statement and ends game.
    if (playAnotherGame == "q") {
       Console.WriteLine($"Thank you for playing {playerName} you chose to quit the game.");
        playGame  = false;
    }
            }// end of play agian loop
        } // end of main
    }// end of class
}// end of namespace
