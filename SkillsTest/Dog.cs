using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTest
{
    public class Dog
    {
       

        int Id { get; set; }
        string Name { get; set; }
        string Race { get; set; }
        int YearOfBirth { get; set; }


        public Dog(int id, string name, string race, int yearofbirth)
        {
            Id = id;
            Name = name;    
            Race = race;
            YearOfBirth = yearofbirth;
        }

        public int _id
        {
            get { return Id; }
            set { Id = value; }
        }

        public string _name
        {
            get { return Name; }
            set { Name = value; }
        }

        public string _race
        { 
          get { return Race; }
          set {Race = value; }


        } 

        public int _yearofbirth
        {
            get { return YearOfBirth; }
            set { YearOfBirth = value; }
        }

        public override string ToString()
        {
            return $"id: {Id}, name:{Name}, race:{Race}, yearofbirth:{YearOfBirth}";
        }


    }
}
