namespace Homework3;

public class Urologist : Doctor
{
    public Urologist(string name, string surname, int workExperience, string specialization = "уролог") : base(name, surname, workExperience, specialization)
    {

    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
    }
    public override void Cure(Patient patient)
    {
        if (patient.UroDis == true)
        {
            patient.UroDis = false;
            Console.WriteLine($"Проведено лечение урологической патологии пациенту {patient.Name} {patient.Surname}");
        }
        else
        {
            Console.WriteLine($"Урологическое лечение пациенту {patient.Name} {patient.Surname} не требуется");
        }
    }
}
