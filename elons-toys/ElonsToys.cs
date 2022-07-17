using System;

class RemoteControlCar
{
    private int distanceDriven = 0;
    private int batteryLevel = 100;

    public static RemoteControlCar Buy() => new RemoteControlCar();

    public void Drive()
    {
        if (batteryLevel != 0) {distanceDriven += 20; batteryLevel--;}
    }

    public string DistanceDisplay() => $"Driven {distanceDriven} meters";

    public string BatteryDisplay() =>
        batteryLevel != 0 ? $"Battery at {batteryLevel}%" : "Battery empty";
}
