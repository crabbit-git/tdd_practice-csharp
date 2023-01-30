using System;
using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder formatted = new StringBuilder();

        for (int i = 0; i < identifier.Length; ++i) {
            switch (identifier[i]) {
                case ' ':
                    formatted.Append('_');
                    break;
                case '\0':
                    formatted.Append("CTRL");
                    break;
                case '-':
                // I don't consider " - a" kebab-case, but the final test does
                    ++i; // Skips to the character after the '-'
                    formatted.Append(Char.ToUpper(identifier[i]));
                    break;
                case char etruscanPurist when !Char.IsLetter(etruscanPurist):
                    break;
                case char hellenophobia when hellenophobia is >= 'α' and <= 'ω':
                    break;
                default:
                    formatted.Append(identifier[i]);
                    break;
            }
        }
        return formatted.ToString();
    }
}
