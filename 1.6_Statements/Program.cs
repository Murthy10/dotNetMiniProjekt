using System;

namespace _1._6_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: PromptHeight() verwenden, um Höhe des Baumes (ohne Stamm) einzulesen
            int height = 0;
            do
            {
                height = PromptHeight();
            } while (height == 0);

            drawTree(height);
            

            // TODO: Ungültige Eingabe behandeln

            // TODO: Nadelwerk zeichnen

            // TODO: Stamm zeichnen

            // TODO: Loop implementieren

            Console.ReadKey();
        }
    
        private static void drawTree(int height)
        {
            if(height > 0)
            {
                drawTree(height - 1);
            }
            String star = "";
            for(int i = 0; i < height; i++)
            {
                star += "*";
            }
            Console.WriteLine(star);
        }

        private static int PromptHeight()
        {
            Console.Write("Maximale Breite eingeben 2 - 20: ");

            string heightInput = Console.ReadLine();

            int height;
            if (int.TryParse(heightInput, out height))
            {
                if (height < 2 || height > 20)
                {
                    Console.WriteLine("Ungültiger Wert eingegeben! Die Zahl muss zwischen 2 und 20 liegen!");
                    return 0;
                }
            }
            else
            {
                Console.WriteLine("Ungültiger Wert eingegeben! Kann nicht interpretiert werden!");
                return 0;
            }

            return height;
        }

    }
}
