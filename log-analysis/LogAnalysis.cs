using System;

public static class LogAnalysis 
{
    public static string SubstringAfter(this string logLine, string delimiter)
        => logLine.Substring(logLine.IndexOf(delimiter) + delimiter.Length);

    public static string SubstringBetween(this string logLine, string openingDelimiter, string closingDelimiter)
    {
        int start = logLine.IndexOf(openingDelimiter) + openingDelimiter.Length;
        int length = logLine.IndexOf(closingDelimiter) - start;
        return logLine.Substring(start, length);
    }

    public static string Message(this string logLine)
        => logLine.Split("]: ")[1];
        // This assumes that "]: " never appears in the message itself, though.

    public static string LogLevel(this string logLine)
        => logLine.SubstringBetween("[", "]");
}
