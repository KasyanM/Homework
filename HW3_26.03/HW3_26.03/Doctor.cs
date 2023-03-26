namespace Homework3;

public abstract class Doctor : ICure
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Specialization { get; set; }
    public int WorkExperience { get; set; }
    public Doctor (string name, string surname, string specialization, int workExperience)
    {
        Name = name;
        Surname = surname;
        Specialization = specialization;
        WorkExperience = workExperience;
    }
    public virtual void DisplayInfo ()
    {
        Console.WriteLine($"Врач-{Specialization} {Surname} {Name}, стаж работы - {WorkExperience}");
    }
    public virtual void Cure (Patient ColoDis, Patient GynDis, Patient UroDis)
    {

    }
}
