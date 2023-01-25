using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Creating_Classes
{
    public enum RelationshipType
    {
        Sister,
        Brother,
        Mother,
        Father
    }
    internal class Ralation
    {
        private Person firstPerson;
        private Person secondPerson;
        private RelationshipType relationship;


        public Ralation(Person firstPerson, Person secondPerson, RelationshipType relationship)
        {
            this.firstPerson = firstPerson;
            this.secondPerson = secondPerson;
            this.relationship = relationship;
        }

        public void ShowRelationShip()
        {
            string hood;
            switch (this.relationship)
            {
                case RelationshipType.Sister:
                    hood = "Sisterhood";
                    break;
                case RelationshipType.Brother:
                    hood = "Brotherhood";
                    break;
                case RelationshipType.Mother:
                    hood = "Motherhood";
                    break;
                case RelationshipType.Father:
                    hood = "Fatherhood";
                    break;
                default:
                    hood = "Unknow";
                    break;
            }
            Console.WriteLine($"Relationship between {firstPerson.DisplayPersonInfo("fName")} and {secondPerson.DisplayPersonInfo("fName")} is: {hood}");
        }
    }
}
