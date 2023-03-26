namespace Homework3;

public class Urologist : Doctor
{
    public Urologist (string name, string surname, string specialization, int workExperience) : base(name, surname, specialization, workExperience)
    {
        specialization = "уролог";
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
    }
    public override void Cure (Patient ColoDis, Patient GynDis, Patient UroDis)
    {
        if (UroDis)
        {
            UroDis = false;
            Console.WriteLine("Проведено лечение урологической патологии");
        }
    }
}
