namespace Lesson6.OOP2;

public class Patient
{
    public string name;
    public string surname;
    public int age;
    private Doctor? _doctor;

    public Patient(string name,
        string surname,
        int age)
    {
        this.name = name;
        this.surname = surname;
        this.age = age;
    }

    public void AppendDoctor(Treatment_method plan)
    {
        if(plan.code == 1)
        {
            _doctor = new Surgeon();
        }
        else if(plan.code == 2)
        {
            _doctor = new Dentist();
        } 
        else
        {
            _doctor = new Theraphist();
        }
    }
}
