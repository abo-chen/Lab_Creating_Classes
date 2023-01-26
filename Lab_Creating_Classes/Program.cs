using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Creating_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a
            Person ian = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person gina = new Person(2, "Gina", "James", "Green", 18, false);
            Person mike = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person mary = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            //b
            Person.DisplayPersonInfo(gina);

            //c
            Console.WriteLine(mike.ToString());

            //d
            ian.ChangeFavoriteColour();
            Console.WriteLine($"{ian.PersonId}: {ian.FirstName} {ian.LastName}'s " +
                $"favorite colour is: {ian.FavoriteColour}");

            //e
            Console.WriteLine($"{mary.FirstName} {mary.LastName}'s Age in 10 years is: {mary.GetAgeInTenYears()}");

            //f
            Ralation ralation1 = new Ralation(gina, mary, RelationshipType.Sister);
            Console.WriteLine($"Relationship between {ralation1.FirstPerson.FirstName} and {ralation1.SecondPerson.FirstName} " +
                $"is: {ralation1.ShowRelationShip()}");


            Ralation ralation2 = new Ralation(ian, mike, RelationshipType.Brother);
            Console.WriteLine($"Relationship between {ralation2.FirstPerson.FirstName} and {ralation2.SecondPerson.FirstName} " +
                $"is: {ralation2.ShowRelationShip()}");

            //g line1
            List<Person> personList = new List<Person> { ian, gina, mike };
            personList.Add(mary);
            int totalAge = 0;
            foreach (Person person in personList)
            {
                totalAge += person.Age;
            }
            Console.WriteLine($"Average age is: {(float)totalAge / (float)personList.Count:f2}");

            //g line2
            Person youngest = ian;
            foreach (Person person in personList)
            {
                if (youngest.Age > person.Age)
                {
                    youngest = person;
                }
            }
            Console.WriteLine($"The youngest person is: {youngest.FirstName}");

            Person oldest = ian;
            //foreach (Person person in personList)
            //{
            //    if (Convert.ToInt32(oldest.DisplayPersonInfo("age")) < Convert.ToInt32(person.DisplayPersonInfo("age")))
            //    {
            //        oldest = person;
            //    }
            //}
            for (int i = 0; i < personList.Count; i++)
            {
                if (oldest.Age < personList[i].Age)
                {
                    oldest = personList[i];
                }
            }
            Console.WriteLine($"The oldest person is: {oldest.FirstName}");

            //g line3
            Person[] personArry = { ian, gina, mike, mary };
            foreach (var item in personArry)
            {
                if (item.FirstName[0] == 'M')
                {
                    Console.WriteLine(item.ToString());
                }
            }

            //g line4
            for (int i = 0; i < personArry.Length; i++)
            {
                if (personArry[i].FavoriteColour == "Blue")
                {
                    Console.WriteLine(personArry[i].ToString());
                }
            }
        }
    }
}
