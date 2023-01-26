using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Creating_Classes
{
    internal class Person
    {
        private int personId;
        private string firstName;
        private string lastName;
        private string favoriteColour;
        private int age;
        private bool isWorking;

        public int PersonId { get => personId; }
        public string FirstName { get => firstName; }
        public string LastName { get => lastName; }
        public string FavoriteColour { get => favoriteColour; }
        public int Age { get => age; }
        public bool IsWorking { get => isWorking; }

        public Person(int personId, string firstName, string lastName, string favoriteColour, int age, bool isWorking)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.favoriteColour = favoriteColour;
            this.age = age;
            this.isWorking = isWorking;
        }

        public static void DisplayPersonInfo(Person p)
        {

            Console.WriteLine($"{p.personId}: {p.firstName} {p.lastName}'s favorite colour is {p.favoriteColour}");
        }

        public void ChangeFavoriteColour()
        {
            this.favoriteColour = "white";
        }

        public int GetAgeInTenYears()
        {
            return this.age + 10;
        }

        public override string ToString()
        {
            return $"PersonID: {this.personId}\n" +
                $"FirstName: {this.firstName}\n" +
                $"LastName: {this.lastName}\n" +
                $"FavoriteColour: {this.favoriteColour}\n" +
                $"Age: {this.age}\n" +
                $"IsWorking: {this.isWorking}";
        }
    }
}
