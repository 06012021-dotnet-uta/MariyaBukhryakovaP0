using System;

namespace RPS
{
    public class BasePlayerRPS : IRPSGameMessages

    // create constructor to initialize comp player?
    {
    //     // named the computer possibly not needed?
    //  public string computerPlayer = "The Machine";
    //     //Getter setter for player input name
        private string  firstName;
        private string lastName;
        public string FirstName { 
            get 
            {
                return firstName;
            }
            set 
            {
                if(value.Length >1 && value.Length < 20){
                   firstName = value;
                } System.Console.WriteLine("That is not a valid entry please try again.");
            }
            }
        public string LastName { 
            get 
            {
                return lastName;
            }
            set 
            {
                  if(value.Length >1 && value.Length < 20){
                    lastName = value;
                } System.Console.WriteLine("That is not a valid entry please try again.");
            } }
    public string askForFristNameMessage(){
        System.Console.WriteLine("Please enter your first name");
        FirstName = Console.ReadLine().Trim();
        return FirstName;
    }
    public string askForLastNameMessage(){
        System.Console.WriteLine("Please enter your last name");
        LastName = Console.ReadLine().Trim();
        return  LastName;
    }
    }//eo class
}//eo namespace