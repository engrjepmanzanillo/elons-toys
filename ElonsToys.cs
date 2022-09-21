using System;

class RemoteControlCar
{

    int Battery;
    int Distance;
    

    public static RemoteControlCar Buy()
    {
        RemoteControlCar car = new RemoteControlCar(){
            Battery = 100,
            Distance = 0
        };
        return car;
    }

    public string DistanceDisplay() => $"Driven {Distance} meters";

    public string BatteryDisplay() => Battery <= 0 ? "Battery empty" : $"Battery at {Battery}%";

    public void Drive()
    {
        while(Battery >= 0)
        {
            Distance += 20;
            Battery -= 1;
        }
    }
    
}
