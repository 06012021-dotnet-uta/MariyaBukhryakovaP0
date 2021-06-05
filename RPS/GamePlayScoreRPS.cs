namespace RPS
{
    public class GamePlayScoreRPS : GameMovesRPS
    {
//Declare my variables, each player win, and rounds played
        public int compWon;
        public int playerWon;
        public int gamesPlayed;
//now we have a round, whic compares number values and decides who to point increment
        public int playRound(){
            gamesPlayed++;
            if( PlayerChoice == 1 && ComputerChoice ==2 
              ||PlayerChoice == 2 && ComputerChoice ==3
              ||PlayerChoice == 3 && ComputerChoice ==1 )
            {
            return compWon++;
            } 
            return playerWon++;
        }
        public string bestTwoOfThree(){
            if(compWon >=2 && gamesPlayed >=2 && playerWon != 2){
                return "The computer won this round" ;
            }
            else if (compWon == playerWon && gamesPlayed >3){
                return "You tied all 3 games! What are the odds?!";
            }
            return "You won!! Great job!!";
        }
    }
}