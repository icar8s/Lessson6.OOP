namespace Lesson6.OOP2;

public class Dentist : Doctor
{
    public override void Heal()
    {
        Console.WriteLine("Поход к дантисту");
    }
}