namespace ROBOTBETIS;

public class Robot
{
    public string Model{ get; set; }
    private string Manufacturer { get; set; }
    public float BatteryLevel { get; set; }
    public float Speed { get; set;}

    public Move()
    {
        Console.WriteLine(Model + " moves at " + speed + " km/h!");
    }

    void class Main()
    {

    }
    public class Robot (string model = "Puterrobot", private string manufacturer = "Chinese Temu Factory Workers", float batteryLevel = 100.00f, float speed = 15.00f)
    {
        Model= model;
        Manufacturer = manufacturer;
        BatteryLevel = batterylevel;
        Speed = speed;
    }

}
