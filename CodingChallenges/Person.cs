using System;
using System.Collections.Generic;

namespace CodingChallenges
{
    public class Person 
    {
        public Person(string name, int age, long phone){

            this.PersonName = name;
            this.PersonAge = age;
            this.PersonPhone = phone;

        }
        public string PersonName { get; set; }
        public int PersonAge { get; set; }
        public long PersonPhone { get; set; }

        System.Console.WriteLine("\n");
    }//eo emp class
    public class PersonComparison  : IComparer<Person>
    {
        public enum sortBy
        {
            personAge,
            personPhone,
            personName
        }

        //sort ages
        public sortBy compareByFields = sortBy.personAge;

       
       
        public int Compare(Person x, Person y)
        {
            switch(compareByFields)
            {
                case sortBy.personAge:
                System.Console.WriteLine("age sort");
                return x.PersonAge.CompareTo(y.PersonAge);
                case sortBy.personPhone:
                System.Console.WriteLine("phone sort");
                return x.PersonPhone.CompareTo(y.PersonPhone);
                case sortBy.personName:
                System.Console.WriteLine("name sort");
                return x.PersonName.CompareTo(y.PersonName);
                default:break; 
            }
            return x.PersonAge.CompareTo(y.PersonAge);
        }
    }
}