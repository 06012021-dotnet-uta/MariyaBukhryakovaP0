using System;

namespace RPS
{
    partial class Program : BasePlayerRPS
    {
        static void Main(string[] args){
//call a new game to start created instance of the moves
        GameMovesRPS game1 = new GameMovesRPS();
//created a user
        BasePlayerRPS user1 = new BasePlayerRPS();
//created the game tracking and scorekeeping 
        GamePlayScoreRPS playNow = new GamePlayScoreRPS();
//welcome message
            game1.welcomeMessage();
//Get user info
            user1.askForFristNameMessage();
            user1.askForLastNameMessage();
            System.Console.WriteLine($"Thanks {user1.FirstName} {user1.LastName}!");
//variable declaration for 1st loop 
            string playLoop;
//1st loop to repeat game
    do{
//do while loop to play game min of 2 times
        do{
//now to show and choose moves:
        game1.UserStartGame();
//comp plays
        game1.computerplayGame();
//compare ints to enums
        // string pChoiceEnum;
        // string cChoiceEnum;
//we print user and comp choices in enum string format
       // System.Console.WriteLine($"{user1.FirstName} {user1.LastName} chose {pChoiceEnum} and the comptuer chose {cChoiceEnum}");   
//now results are compared and declared
        playNow.playRound();
//now we check how many rounds and what the score is to declare overall winner
//check to make sure that a min of 2 games is played and that no one has already won two rounds
        } while (playNow.gamesPlayed < 2 || playNow.compWon >3);
//games have played and there is a winner, now to ask if they want to play again
        Console.WriteLine($"{user1.FirstName} {user1.LastName} game is over and {playNow.bestTwoOfThree()}\nDo you want to play again?\nEnter y for yes and n for no");
        playLoop = Console.ReadLine().Trim().ToLower();
// this is a validation step to check and make sure that they entered either letter
        if(playLoop != "y" && playLoop != "n")
        {
            System.Console.WriteLine("That is not one of choices please type in y or n.");
        }
    }while(playLoop != "n");        
        }//eo main
    }//eo class
}//eo namespace
