using System;

namespace _1._5_Identifiers_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSymbols();
            TestPrimitiveTypes();

            Console.ReadKey();
        }

        private static void TestSymbols()
        {
            // TODO: Erstellen Sie eine int-Variable mit dem Namen "null"
            int @null;
            @null = 1;
            // TODO: Weisen Sie der Variable den Wert 1 zu
            Console.WriteLine(@null);
            // TODO: Geben Sie den Wert auf die Konsole aus
        }

        private static void TestPrimitiveTypes()
        {
            char c = 'a';
            int i = 255;



            // TODO: Weisen Sie "c" einer neuen decimal-Variable "d" zu

            c = 'd';

            // TODO: Weisen Sie "i" einer neuen sbyte-Variable "s" zu

            i = 's';

            // TODO: Geben Sie den Wert auf die Konsole aus

            Console.WriteLine(i);

            // TODO: Optional / Überlegen Sie sich, wieso das gegebene Resultat entsteht (Hinweis: Bitlogik!)

        }
    }
}
