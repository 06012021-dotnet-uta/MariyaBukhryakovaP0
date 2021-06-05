using System;
namespace RPS
{
// I made this class inherit from the base player... not sure if that was a good idea...
    public class GameMovesRPS :BasePlayerRPS
    {
// this is the greeting:
        public void welcomeMessage()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors!.");
        }
// this is the getter and setter for the player choice and computer choice
        public int PlayerChoice { get; set; }
        public int ComputerChoice { get; set; }
//this is staring a game prompting user to pick one of the 3
        public int UserStartGame(){
            System.Console.WriteLine("Pick one!\n1.Rock\n2.Paper\n3.Scissors");
// takes in player choice, converts from string to int, validates that the choice is valid
            string playerInput = Console.ReadLine().Trim();
            int  _playerChoice = Convert.ToInt32(playerInput);
              if(_playerChoice < 1 && _playerChoice > 4){
                System.Console.WriteLine("That is not a valid entry try again.");
              } 
//how to handle the input of not a number? for player input?
             return _playerChoice;// returns the player choice int
        }
// computer play which is just random number generator 
         public int computerplayGame(){
            Random rNum = new Random();
           int _computerChoice = rNum.Next(1,4);
            return _computerChoice;
         }
    }//class end
}//namespace end