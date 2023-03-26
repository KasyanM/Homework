namespace Homework3;

public class Coloproctologist : Doctor
{
    public Coloproctologist (string name, string surname, string specialization, int workExperience) : base(name, surname, specialization, workExperience)
    {
        specialization = "колопроктолог";
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
    }
    public override void Cure (Patient ColoDis, Patient GynDis, Patient UroDis)
    {
        if (ColoDis == true)
        {
            ColoDis = false;
        }
        Console.WriteLine("Проведено лечение колопроктологической патологии");
    }
}
