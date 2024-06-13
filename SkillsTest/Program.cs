namespace SkillsTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dog;");
            Console.WriteLine();
            Console.WriteLine("Opgave 2.opret klasse for Dog -> tilføj instancr-> consolewriteline ");
            Console.WriteLine();
            //id--- navn ---race---yearofbirth
            Dog dog1 = new Dog(1, "Fido", "Labrador", 2015);
            Dog dog2 = new Dog(2, "Bella", "Golden Retriever", 2016);
            Dog dog3 = new Dog(3, "Max", "Poodle", 2017);

            Console.WriteLine(dog1);
            Console.WriteLine(dog2);
            Console.WriteLine(dog3);
            Console.WriteLine("------------------------------------------------------------------------");


            Console.WriteLine("Member og informationer;");
            Console.WriteLine();
            Console.WriteLine("Opgave 3.opret klasse for Member -> tilføj instancr-> consolewriteline ");
            Console.WriteLine();

            //id--- navn ---address---birthdate---phone---email
            Member member1 = new Member(1, "John", "Hovedgade 1", new DateTime(1990, 1, 1), "12345678", "j@gmail.com");
            Member member2 = new Member(2, "isak", "Hovedgade 2", new DateTime(1991, 2, 2), "87654321", "I@gmail.com");
            Member member3 = new Member(3, "Mikkel", "Hovedgade 3", new DateTime(1992, 3, 3), "12348765", "M@gmail.com");

            Console.WriteLine(member1);
            Console.WriteLine(member2);
            Console.WriteLine(member3);
            Console.WriteLine("------------------------------------------------------------------------");


            // i dette stykke kode definere vi hvilke members vi har at gøre med 
            Console.WriteLine();
            Console.WriteLine("Opgave 4: CRUD metoder");
            Member member = new Member(1, "John", "Hovedgade 1", new DateTime(1990, 1, 1), "12345678", "j@gmail.com");
            //Member member1 = new Member(2, "isak", "Hovedgade 2", new DateTime(1991, 2, 2), "87654321", "i@gmail.com");
            //Member member2= new Member(3, "Mikkel", "Hovedgade 3", new DateTime(1992, 3, 3), "12348765", "M@gmail.com");

            //tilføjer hundene til members
            member1.RegistrerDog(dog1);
            member2.RegistrerDog(dog2);
            //member3.RegistrerDog(dog3);

            Console.WriteLine(member1);
            Console.WriteLine(member2);
            Console.WriteLine("------------------------------------------------------------------------");

            member1.PrintDogs();


            //member2.PrintDogs();
            //member3.PrintDogs();

            member1.removeDog(dog1);
            Console.WriteLine("EFTER AT REMOVE EN DOG");
            member1.PrintDogs();



            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("opgave 6");

            // her bliver jeg nødt til at lave en ny member for at kunne teste om validationen virker
            Member member4 = new Member(1, "John Doe", "Hovedgade 1", new DateTime(1990, 1, 1), "12345678", "j@gmail.com");

            Console.WriteLine($"Member Age: {member.Age}");
            Console.WriteLine($"Member Fee med base fee 500: {member.MemberFee(500)}");
            Console.WriteLine($"Member Fee med base fee 1000: {member.MemberFee(1000)}");

            // det samme skete her så jeg bliver jeg nødt til at lave en ny member for at kunne teste om validationen virker
            Member member5 = new Member(1, "John Doe", "Hovedgade 1", new DateTime(1990, 1, 1), "+12345678", "j@gmail.con");

            if (!member.Validate())
            {
                Console.WriteLine("Validation failed.");
            }
            else
            {
                Console.WriteLine("Validation passed.");
            }
            
            



        }
    }
}

