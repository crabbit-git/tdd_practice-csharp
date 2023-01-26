using System;

public static class LogAnalysis 
{
    public static string SubstringAfter(this string logLine, string delimiter)
        => logLine.Split(delimiter, 2)[1];
        // Alternatively, could do it using Substring method by index:
        // => logLine.Substring(logLine.IndexOf(delimiter) + delimiter.Length);

    public static string SubstringBetween(this string logLine, string openingDelimiter, string closingDelimiter)

    // I can't decide which is actually more efficient here,
    // but I know which I find easier to read.

    // Could just chain a second Split() onto SubstringAfter():

        => logLine.SubstringAfter(openingDelimiter).Split(closingDelimiter)[0];

    // ... which avoids ambiguity about the index to be returned, because
    // the first Split() discards anything before the first delimiter, so
    // the index being kept after the second Split() is always 0.

    // To avoid doing Split() twice in a row, could instead do one Split()
    // with the two strings and keep the middle, but that means having to
    // determine whether the first delimiter occurs at the start or not:

        // => logLine.Split(
        //     new[] {openingDelimiter, closingDelimiter},
        //     StringSplitOptions.RemoveEmptyEntries
        // )[(logLine.IndexOf(openingDelimiter) == 0) ? 0:1];

    // Alternatively, can determine the delimiters' indices and use Substring():

    // {
    //     int start = logLine.IndexOf(openingDelimiter) + openingDelimiter.Length;
    //     int length = logLine.IndexOf(closingDelimiter) - start;
    //     return logLine.Substring(start, length);
    // }

    // All three work, but Occam's razor tells me to go with the double Split().

    public static string Message(this string logLine)
        => logLine.SubstringAfter("]: ");

    public static string LogLevel(this string logLine)
        => logLine.SubstringBetween("[", "]");
}
