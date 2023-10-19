
using Lesson6.OOP;

Phone firstPhone = new Phone();
firstPhone.number = "111111";
firstPhone.model = "iPhone";
firstPhone.weight = 164.0;

Phone secondPhone = new Phone();
secondPhone.number = "222222";
secondPhone.model = "Samsung";
secondPhone.weight = 169.0;

Phone thirdPhone = new Phone();
thirdPhone.number = "333333";
thirdPhone.model = "Google Pixel";
thirdPhone.weight = 180.0;

Console.WriteLine("Phone 1:");
Console.WriteLine("Number: " + firstPhone.number);
Console.WriteLine("Model: " + firstPhone.model);
Console.WriteLine("Weight: " + firstPhone.weight);
Console.WriteLine("Phone 2:");
Console.WriteLine("Number: " + secondPhone.number);
Console.WriteLine("Model: " + secondPhone.model);
Console.WriteLine("Weight: " + secondPhone.weight);
Console.WriteLine("Phone 3:");
Console.WriteLine("Number: " + thirdPhone.number);
Console.WriteLine("Model: " + thirdPhone.model);
Console.WriteLine("Weight: " + thirdPhone.weight);

firstPhone.ReceiveCall("Влад");
Console.WriteLine($"--"+ firstPhone.GetNumber());
firstPhone.ReceiveCall("Илья");
Console.WriteLine($"--"+ secondPhone.GetNumber());
firstPhone.ReceiveCall("Саша");
Console.WriteLine($"--"+ thirdPhone.GetNumber());


