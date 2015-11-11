using System;

namespace _1._1_Enum
{
    // TODO: enum "Volume" implementieren
    public enum Volume { Unknown, Low, Medium, High };

    class Program
    {

        static void Main(string[] args)
        {
            // TODO: Volume-Variable erstellen

            // TODO: Ausgabe über PrintVolume

            // TODO: volumeString via ParseVolume(...) in Volume-Variable speichern
            string volumeString = "High";


            // TODO: Ausgabe über PrintVolume
            PrintVolume((Volume)Enum.Parse(typeof(Volume), volumeString));

            Console.ReadKey();
        }

        // TODO: public static void PrintVolume...
        public static void PrintVolume(Volume volume)
        {
            Console.WriteLine("The volume is {0} ", volume);
        }
        // Ausgabe: The volume is 'Low' / value '2'

        // TODO: public static Volume ParseVolume...

    }
}
