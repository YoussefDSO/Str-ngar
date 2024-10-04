class Program
{
    static void Main(string[] args)
    {
        // Claes textsträng som ska undersökas
        string input = "29535123p48723487597645723645";

        // Lista för delsträngar att markera
        string[] predefSubstrings = {
            "2953512", "535", "35123", "487234", "872348", "723487", "2348759764572",
            "3487597645723", "48759764", "7597", "597645", "76457", "6457236", "4572364", "5723645"
        };

        long totalSum = 0; // Variabel för summan

        // För att gå igenom varje delsträng i listan
        foreach (string substring in predefSubstrings)
        {
            // Kolla om delsträngen finns i inputsträngen
            int startIndex = input.IndexOf(substring);
            if (startIndex != -1)
            {
                // Denna kod används för att skriv ut hela inputsträngen och markera delsträngen
                PrintWithHighlight(input, startIndex, substring.Length);

                // Denna lägger till delsträngen till summan
                totalSum += long.Parse(substring);
            }
        }

        // Tom rad för separation som du ville ha och som det stod i instruktionen
        Console.WriteLine();

        // Skriver ut summan
        Console.WriteLine($"Summa = {totalSum}");
    }

    // Funktion för att markera de giltiga delsträngar i annan färg 
    static void PrintWithHighlight(string text, int startIndex, int length)
    {
        // Skriver ut texten före delsträngen
        Console.Write(text.Substring(0, startIndex));

        // Byt färg till grön för att markera delsträngen
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(text.Substring(startIndex, length));

        // Återställer färgen och skriver ut resten av strängen
        Console.ResetColor();
        Console.WriteLine(text.Substring(startIndex + length));
    }
}
