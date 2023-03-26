namespace Homework3;

public class Gynaecologist : Doctor
{
    public Gynaecologist(string name, string surname, int workExperience, string specialization = "гинеколог") : base(name, surname, workExperience, specialization)
    {

    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
    }
    public override void Cure(Patient patient)
    {
        if (patient.GynDis == true)
        {
            patient.GynDis = false;
            Console.WriteLine($"Проведено лечение гинекологическое патологии пациентке {patient.Name} {patient.Surname}");
        }
        else
        {
            Console.WriteLine($"Гинекологическое ечение пациенту {patient.Name} {patient.Surname} не требуется");
        }
    }
}
