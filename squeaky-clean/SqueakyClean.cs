using System;
using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder formatted = new StringBuilder(identifier)
                                      .Replace(' ', '_')
                                      .Replace("\0", "CTRL");
        
        for (int i = 0; i < formatted.Length; i++) {
            if (formatted[i] == '-') {
            // Note that this is only this simplistic because the final test requires it;
            // in my opinion, " -a" does not constitute kebab-case due to the space before the '-',
            // but the test specifies that it should be treated as such and converted to "_A".
                formatted.Remove(i, 1);
                formatted[i] = Char.ToUpper(formatted[i]); // Iterator is already on next character due to deletion, hence no i+1
                i--; // Repositions cursor for further checks, accounting for deletion of 1 char
            } else if (!Char.IsLetter(formatted[i]) && formatted[i] != '_') {
                formatted.Remove(i, 1);
                i--;
            } else if (Char.IsBetween(formatted[i], 'α', 'ω')) {
                formatted.Remove(i, 1);
                i--;
            }
        }
        return formatted.ToString();
    }
}
