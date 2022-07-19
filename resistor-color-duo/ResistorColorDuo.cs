using System;

public static class ResistorColorDuo
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

    public static int Value(string[] colors)
    {
        string values = "";
        foreach (string color in colors) {
            values += Array.IndexOf(resistanceValues, color);
        }
        return Int32.Parse(
            values.Substring(0, 2)
        );
    }
}
