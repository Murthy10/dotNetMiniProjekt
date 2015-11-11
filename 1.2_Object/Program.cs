using System;

namespace _1._2_Object
{
    class Program
    {
        // TODO: public static string GetStringRepresentation ...
        public static string GetStringRepresentation(Object obj)
        {
            return obj.ToString();
        }
        static void Main(string[] args)
        {
            // TODO: Test mit int / Ausgabe auf Konsole
            string s1 = GetStringRepresentation(123);
            string b1 = GetStringRepresentation(true);
            System.Console.WriteLine(s1);
            System.Console.WriteLine(b1);
            // TODO Test mit bool / Ausgabe auf Konsole


            Person person = new Person("Hans", "Muster");
            string p1 = GetStringRepresentation(person);
            System.Console.WriteLine(p1);

            // TODO Test mit System.Drawing.Point / Ausgabe auf Konsole

            // TODO Test mit Person (siehe unten) / Ausgabe auf Konsole 

            Console.ReadKey();
        }
    }

    public class Person
    {
        private string firstName;
        private string lastName;
        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        // TODO: public override string ToString ...
        public override string ToString()
        {
            return this.firstName + " " + this.lastName;
        }
    }

}
