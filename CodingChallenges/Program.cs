using System;
using System.Collections.Generic;

namespace CodingChallenges
{
    class Program{
        static void Main(string[] args){
        // when creating and then adding object DO NOT FORGET to create a constructor to set the values!!!!!! it won't work otherwise
            List<Person> personInfos = new List<Person> {
            new Person("Bobby Joe", 23, 1234567890),
            new Person("Bucky Barnes", 90, 2234567890),
            new Person("Steve Rogers", 100, 1234517890),
            new Person("Agnes Roy", 68,1234767890),
            new Person("Zara Meyers", 14, 1234567890) 
            };

            foreach(var human in personInfos){
                System.Console.WriteLine("Person: {0}, {1}, {2}", human.PersonName, human.PersonAge, human.PersonPhone);
            }
            // personInfos.Sort();
            // System.Console.WriteLine("\n******sorting ICompare*****\n");

            //  foreach(var human in personInfos){
            //     System.Console.WriteLine("Person: {0}, {1}, {2}", human.PersonName, human.PersonAge, human.PersonPhone);
            // }

            // personInfos.Sort();
            // System.Console.WriteLine("\n******now I have created a whole new class in person*****\n");

            //    foreach(var human in personInfos){
            //     System.Console.WriteLine("Person: {0}, {1}, {2}", human.PersonName, human.PersonAge, human.PersonPhone);
            // }

            PersonComparison comparing = new PersonComparison();
                comparing.compareByFields = PersonComparison.sortBy.personAge;
                  foreach(var human in personInfos){
                System.Console.WriteLine("Person: {0}, {1}, {2}", human.PersonName, human.PersonAge, human.PersonPhone);
            }

            comparing.Compare();
                personInfos.();
                System.Console.WriteLine("\n******sorting by age*****\n");
            foreach(var human in personInfos){
                System.Console.WriteLine("Person: {0}, {1}, {2}", human.PersonName, human.PersonAge, human.PersonPhone);
            }
            //      comparing.compareByFields = PersonComparison.sortBy.personPhone;
            //      personInfos.Sort();
            //      System.Console.WriteLine("\n******sorting by phone#*****\n");
            // foreach(var human in personInfos){
            //     System.Console.WriteLine("Person: {0}, {1}, {2}", human.PersonName, human.PersonAge, human.PersonPhone);
            // }
            //      comparing.compareByFields = PersonComparison.sortBy.personName;
            //      personInfos.Sort();
            //      System.Console.WriteLine("\n******sorting by name*****\n");
            // foreach(var human in personInfos){
            //     System.Console.WriteLine("Person: {0}, {1}, {2}", human.PersonName, human.PersonAge, human.PersonPhone);
            // }
            






            

            //now to sort! by age!
        }//eo main

      
    }//eo class
         
         
     
            





        //     Dictionary<int, string> gameChoices = new Dictionary<int, string>();
        //     gameChoices.Add(1, "Left");
        //     gameChoices.Add(2, "Right");
        //     gameChoices.Add(3, "Up");
        //     gameChoices.Add(4, "Down");

        //     foreach(KeyValuePair<int, string> kvp in gameChoices){
        //         //the ={0} is for key and ={1} stand for value in print statement
        //         System.Console.WriteLine("Key = {0}, Value= {1} ", kvp.Key, kvp.Value); 
        //     }
        // //have to declare int and set to the count
        //    int dictionSize = gameChoices.Count;  
        //     System.Console.WriteLine($"The size of the dictionary is {dictionSize}");

        // di


        
//         {
//    var fibonacciNumbers = new List<int> {1, 1};
//  do {
//     int previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
//     var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
//     fibonacciNumbers.Add(previous + previous2);
//  } while(fibonacciNumbers.Count < 20);
//  foreach(var item in fibonacciNumbers)
//     Console.WriteLine(item);
//         }
    
}//eo namespace
