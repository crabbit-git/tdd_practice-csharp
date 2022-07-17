using System.Linq;

public static class ScrabbleScore
{
    public static int Score(string input)
    {
        int points = 0;
        foreach(char character in input)
        {
            char letter = char.ToUpper(character);
            if ("QZ".Contains(letter)) points += 10;
            else if ("JX".Contains(letter)) points += 8;
            else if ('K' == letter) points += 5;
            else if ("FHVWY".Contains(letter)) points += 4;
            else if ("BCMP".Contains(letter)) points += 3;
            else if ("DG".Contains(letter)) points += 2;
            else points += 1;
        }
        return points;
    }
}
