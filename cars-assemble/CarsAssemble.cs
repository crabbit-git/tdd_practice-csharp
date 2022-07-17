using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if (speed == 0) return 0;
        else if (speed <= 4) return 1;
        else if (speed <= 8) return 0.9;
        else if (speed <= 9) return 0.8;
        else if (speed <= 10) return 0.77;
        else throw new NotImplementedException(
            @"Invalid value provided for assembly line speed.
            Please enter an integer between 0 and 10."
        );
    }
    
    public static double ProductionRatePerHour(int speed) =>
        SuccessRate(speed) * speed * 221;

    public static int WorkingItemsPerMinute(int speed) =>
        (int) ProductionRatePerHour(speed) / 60;
}
