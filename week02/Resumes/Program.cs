using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        person p1 = new person();
        p1._firstName = "Mary";
        p1._lastName = "Smith";
        p1._age = 25;

        person p2 new person();
        p2._firstName = "John";
        p2._lastName = "Watkins";
        p2._age = 30;

        List<person> people = new List<person>();
        people.Add(p1);
        people.Add(p2);

        foreach (person p in people)
        {
            Console.WriteLine(p._firstName);
        }
    }
}