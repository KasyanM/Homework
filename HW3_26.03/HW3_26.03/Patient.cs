namespace Homework3;

public class Patient
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public bool GynDis { get; set; }
    public bool UroDis { get; set; }
    public bool ColoDis { get; set; }

    public Patient(string name, string surname, int age, bool gynDis, bool uroDis, bool coloDis)
    {
        Name = name;
        Surname = surname;
        Age = age;
        GynDis = gynDis;
        UroDis = uroDis;
        ColoDis = coloDis;
    }
    public virtual void DisplayInfo ()
    {
        Console.WriteLine($"Пациент {Surname} {Name}, {Age}");
        if (GynDis == true)
        {
            Console.WriteLine("Заболевание: гинекологическая патология");
        }
        if (UroDis == true)
        {
            Console.WriteLine("Заболевание: урологическая патология");
        }
        if (ColoDis == true)
        {
            Console.WriteLine("Заболевание: колопроктологическая патология");
        }
    }
}   
