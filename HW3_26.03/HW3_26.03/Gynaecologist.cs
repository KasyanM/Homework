namespace Homework3;

public class Gynaecologist : Doctor
{
    public Gynaecologist (string name, string surname, string specialization, int workExperience) : base (name, surname, specialization, workExperience)
    {
        specialization = "гинеколог";
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
    }
    public override void Cure (Patient ColoDis, Patient GynDis, Patient UroDis)
    {
        if (GynDis)
        {
            GynDis = false;
            Console.WriteLine("Проведено лечение гинекологической патологии");
        }
    }
}
