using System;

class RemoteControlCar
{

    public static int Battery = 100;
    
    public static int Distance = 0;

    public static RemoteControlCar Buy()
    {
        
    }


    public string DistanceDisplay() => Battery <= 0 ? "Battery empty" : $"Battery at {Battery}";

    public string BatteryDisplay() => $"Driven {Distance} meters";

    public void Drive()
    {
        if(Battery >= 0)
        {
            Distance += 20;
            Battery -= 1;
        }
    }
}
