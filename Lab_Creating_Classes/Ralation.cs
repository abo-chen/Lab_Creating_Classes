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

        public Person FirstPerson { get => firstPerson; }
        public Person SecondPerson { get => secondPerson; }

        public Ralation(Person firstPerson, Person secondPerson, RelationshipType relationship)
        {
            this.firstPerson = firstPerson;
            this.secondPerson = secondPerson;
            this.relationship = relationship;
        }

        public string ShowRelationShip()
        {
            switch (this.relationship)
            {
                case RelationshipType.Sister:
                    return "Sisterhood";
                case RelationshipType.Brother:
                    return "Brotherhood";
                case RelationshipType.Mother:
                    return "Motherhood";
                case RelationshipType.Father:
                    return "Fatherhood";
                default:
                    return "Unknow";
            }
        }
    }
}
