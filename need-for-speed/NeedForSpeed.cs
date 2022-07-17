using System;

class RemoteControlCar
{
    private int speed;
    private int batteryDrain;
    private int distanceDriven = 0;
    private int batteryLevel = 100;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public void Drive()
    {
        if (!BatteryDrained()) {
            distanceDriven += speed; batteryLevel -= batteryDrain;
        }
    }

    public int DistanceDriven() => distanceDriven;

    public bool BatteryDrained() => batteryLevel < batteryDrain ? true : false;

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    private int length;

    public RaceTrack(int length)
    {
        this.length = length;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (car.DistanceDriven() < this.length)
        {
            if (car.BatteryDrained()) return false;
            car.Drive();
        }
        return true;
    }
}
