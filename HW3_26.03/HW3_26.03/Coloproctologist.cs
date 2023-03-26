namespace Homework3;

public class Coloproctologist : Doctor
{
    public Coloproctologist(string name, string surname, int workExperience, string specialization = "колопроктолог") : base(name, surname, workExperience, specialization)
    {
       
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
    }
    public override void Cure (Patient patient)
    {
        if (patient.ColoDis == true)
        {
            patient.ColoDis = false;
            Console.WriteLine($"Проведено лечение колопроктологической патологии пациенту {patient.Name} {patient.Surname}");
        }
        else
        {
            Console.WriteLine($"Колопроктологическое лечение пациенту {patient.Name} {patient.Surname} не требуется");
        }
    }
}
