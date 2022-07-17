using System.Linq;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => new int[] { 0, 2, 5, 3, 7, 8, 4 };

    public int Today() => this.birdsPerDay[6];

    public void IncrementTodaysCount()
    {
        this.birdsPerDay[6] += 1;
    }

    public bool HasDayWithoutBirds() => this.birdsPerDay.Contains(0);

    public int CountForFirstDays(int numberOfDays) =>
        this.birdsPerDay.Take(numberOfDays).Sum();

    public int BusyDays()
    {
        int busyDays = 0;
        foreach (int day in this.birdsPerDay) {
            if (day >= 5) {
                busyDays++;
            }
        }
        return busyDays;
    }
}
