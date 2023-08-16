using System;

//ref link:https://www.youtube.com/watch?v=HVF3k_H171w&list=PL259BC2977085CF37&index=6
//

class MainClass
{
    static void Main()
    {
        string firstName = "Kulpot";
        string lastName = "King";

        //var person = new { firstName, lastName };
        var person = new { firstName, lastName, FullName = firstName + " " + lastName };
        Console.WriteLine(person.firstName);
        Console.WriteLine(person.lastName);
        Console.WriteLine(person);

        //var person = new { FirstName = "Kulpot", LastName = "King" };
    }
}