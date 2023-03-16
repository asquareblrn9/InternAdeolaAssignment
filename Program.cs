class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the hour (0-12): ");
        int hour = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the minute (0-59): ");
        int minute = int.Parse(Console.ReadLine());

        // hour hand moves 30 degrees per hour
        double hourAngle = (hour % 12 + (double)minute / 60) * 30;

        // minute hand moves 6 degrees per minute
        double minuteAngle = minute * 6;

        // get the absolute difference between the two angles
        double angle = Math.Abs(hourAngle - minuteAngle); 

        // to check and make sure the angle is not greater than 180 degrees
        if (angle > 180)
        {
            angle = 360 - angle;
        }

        Console.WriteLine($"The lesser angle between the hour and minute hands is {angle} degrees.");
    }
}
