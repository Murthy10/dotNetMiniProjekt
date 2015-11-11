using System;

namespace _1._4_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Definieren Sie folgenden String (Inhalt muss absolut identisch sein / gültiger Pfad!)
            string path = @"C:\Temp\Hello.txt"; //Inhalt: C:\Temp\Hello.txt

            // TODO: Geben Sie path auf die Konsole aus
            Console.WriteLine(path);

            // TODO: Geben Sie path in UPPERCASE auf die Konsole aus
            Console.WriteLine(path.ToUpper());
            // TODO: Ersetzen Sie \ durch / und geben Sie das Resultat auf die Konsole aus

            Console.WriteLine(path.Replace('\\','/'));
            // TODO: Zerlegen Sie den String in ein Array (Separator = \) und geben Sie die Elemente auf die Konsole aus
            string[] sArray = path.Split('\\');
            foreach(string s in sArray)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
