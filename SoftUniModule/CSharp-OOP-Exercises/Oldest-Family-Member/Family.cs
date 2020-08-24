using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oldest_Family_Member
{
    class Family
    {
        public List<Person> CurrentFamilly;

        public Family()
        {
            this.CurrentFamilly = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.CurrentFamilly.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.CurrentFamilly.OrderByDescending(p => p.Age).First();
        }


    }
}
