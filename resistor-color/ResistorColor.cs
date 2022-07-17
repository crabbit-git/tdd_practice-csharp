using System;

public static class ResistorColor
{
    private static string[] resistanceValues = {
        "black",
        "brown",
        "red",
        "orange",
        "yellow",
        "green",
        "blue",
        "violet",
        "grey",
        "white"
    };

    public static int ColorCode(string color) =>
        Array.IndexOf(resistanceValues, color);

    public static string[] Colors() => resistanceValues;
}
