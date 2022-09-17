using System;

class RemoteControlCar
{

    static int Battery { get; set; }
    static int Distance { get; set; }
    

    public static RemoteControlCar Buy()
    {
        Battery = 100;
        Distance = 0;
        return new RemoteControlCar();
    }

    public string DistanceDisplay() => $"Driven {Distance} meters";

    public string BatteryDisplay() => Battery <= 0 ? "Battery empty" : $"Battery at {Battery}%";

    public void Drive()
    {
        if(Battery >= 0)
        {
            Distance += 20;
            Battery --;
        }

    }
    
}
