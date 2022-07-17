using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
        double proximitySquared = x*x + y*y;
        /* Actual proximity from 0,0 would be the square root of the above,
        but that's not required for this exercise anyway, so the square root
        calculation would add more processing for no reason */
        if (proximitySquared <= 1*1) return 10;
        else if (proximitySquared <= 5*5) return 5;
        else if (proximitySquared <= 10*10) return 1;
        else return 0;
    }
}
