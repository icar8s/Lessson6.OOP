namespace Lesson6.OOP;
public class Phone
{
    public string number;
    public string model;
    public double weight;

    public void ReceiveCall(string name)
    {
        Console.WriteLine($"Звонит {name}");
    }
    public string GetNumber()
    {
        return number;
    }
   public Phone(string number, string model, double weight)
    {
        this.number = number;
        this.model = model;
        this.weight = weight;
    }
    public Phone(string number, string model)
    {
        this.number = number;
        this.model = model;
    }
    public Phone()
    {
        number = "";
        model = "";
        weight = 0;
    }

    public Phone(string number, double weight,string model): this(number,model)
    {
        this.weight = weight;
    }
    public void ReciveCall(string name, string number)
    {
        Console.WriteLine($"Звонок от {name} с номера {number}");
    }
    public void SendMessage(params string[] phoneNumbers)
    {
        Console.WriteLine("Отправка сообщения на следующие номера телефонов:");
        foreach (string phoneNumber in phoneNumbers)
        {
            Console.WriteLine(phoneNumber);
        }
    }
    }


