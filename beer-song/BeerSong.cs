using System;

public static class BeerSong
{
    public static string Recite(int startBottles, int takeDown)
    {
        string song = "";
        
        for (int i = takeDown; i > 0; i--) {

            string beer = $"bottle{(startBottles == 1 ? "":"s")} of beer",
                   start = $"{beer} on the wall,",
                   alcoholism = $"Take {(startBottles == 1 ? "it":"one")} down and pass it around,",
                   result = $"bottle{(startBottles == 2 ? "":"s")} of beer on the wall.",
                   verse;

            switch (startBottles) {
                case 0:
                    verse = $"No more {start} no more {beer}.\n" +
                    $"Go to the store and buy some more, 99 {result}";
                    break;
                case 1:
                    verse = $"{startBottles} {start} {startBottles} {beer}.\n{alcoholism} no more {result}";
                    break;
                default:
                    verse = $"{startBottles} {start} {startBottles} {beer}.\n{alcoholism} {startBottles - 1} {result}";
                    break;
            }

            song += verse;

            if (i > 1) {
                startBottles--;
                song += "\n\n";
            }
        }
        return song;
    }
}
