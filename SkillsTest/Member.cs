using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTest
{
    public class Member
    {
        //dictionary - liste af dogs




        // instancer
        int Id { get; set; }
        string Name { get; set; }
        string Address { get; set; }
        public DateTime BirthDate { get; set; }
        string Phone { get; set; }
        string Email { get; set; }
        //int Age { get; set; }

        public List<Dog> Dogs { get; set; }



        // constructor
        public Member(int id, string name, string address, DateTime birthDate, string phone, string email)
        {
            Id = id;
            Name = name;
            Address = address;
            BirthDate = birthDate;
            Phone = phone;
            Email = email;
            Dogs = new List<Dog>();
            //Age = age;
        }
        //properties


        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}\nAddress: {Address}\nBirth Date: {BirthDate}\nPhone: {Phone}\nEmail: {Email}";
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

        public string _address
        {
            get { return Address; }
            set { Address = value; }
        }

        public DateTime _birthDate
        {
            get { return BirthDate; }
            set { BirthDate = value; }
        }

        public string _phone
        {
            get { return Phone; }
            set { Phone = value; }
        }

        public string _email
        {
            get { return Email; }
            set { Email = value; }
        }

        //public double _age
        //{
        //    get { return Age; }
        //    set { Age = value; }
        //}








        //RegistrerDog metoden på klassen Member, som skal tilføje en dog til listen af dogs.
        public void RegistrerDog(Dog dog)
        {
            Dogs.Add(dog);
        }

        //print dog metoden på klassen Member, som skriver alle reservationer ud  på skærmen på vha.en foreach løkke.

        public void PrintDogs()
        {
            foreach (var dog in Dogs)
            {
                Console.WriteLine(dog);
            }
        }

        //remove dog )metoden på klassen Member. Metoden skal fjerne dog.

        public void removeDog(Dog dog)
        {
            Dogs.Remove(dog);
        }

        public void RegisterDog(Dog dog)
        {
            Dogs.Add(dog);
        }

        public int Age
        {
            get
            {
                var age = DateTime.Now.Year - BirthDate.Year;
                if (DateTime.Now.DayOfYear < BirthDate.DayOfYear)
                    age--;
                return age;
            }
        }

        public double MemberFee(double baseFee)
        {
            double discount = 0;
            if (Dogs.Count > 1)
                discount += 0.10;
            if (Age > 65)
                discount += 0.15;
            return baseFee * (1 - discount);
        }

        public bool Validate()
        {
            if (Age < 18)
            {
                Console.WriteLine("Member er under 18 år gammel.");
                return false;
            }
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Address) || string.IsNullOrEmpty(Phone) || string.IsNullOrEmpty(Email))
            {
                Console.WriteLine(" navn addresse eller email mangler.");
                return false;
            }
            return true;


        }





    }
}

    

