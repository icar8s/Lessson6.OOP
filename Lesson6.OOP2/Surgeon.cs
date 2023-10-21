namespace Lesson6.OOP2;
public class Surgeon : Doctor
{
    public override void Heal()
    {
        Console.WriteLine("Поход к хирургу");
    }
}