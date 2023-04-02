using Homework3;
using System.Data;

namespace Homework2;

public static class Program
{
    public static void Main()
    {
        Patient patient1 = new Patient("Инна", "Васильева", 30, false, true, true);
        patient1.DisplayInfo();

        Patient patient2 = new Patient("Мария", "Старовойтова", 45, true, false, false);
        patient2.DisplayInfo();

        Patient patient3 = new Patient("Максим", "Никитин", 52, false, true, false);
        patient3.DisplayInfo();

        Coloproctologist coloproctologist = new Coloproctologist("Иван", "Карлов", 5);
        coloproctologist.DisplayInfo();
        coloproctologist.Cure(patient1);
        coloproctologist.Cure(patient2);
        coloproctologist.Cure(patient3);
        Console.WriteLine("\n");

        Urologist urologist = new Urologist("Юрий", "Севостьянов", 12);
        urologist.DisplayInfo();
        urologist.Cure(patient1);
        urologist.Cure(patient2);
        urologist.Cure(patient3);
        Console.WriteLine("\n");

        Gynaecologist gynaecologist = new Gynaecologist("Надежда", "Плотникова", 3);
        gynaecologist.DisplayInfo();
        gynaecologist.Cure(patient1);
        gynaecologist.Cure(patient2);
        gynaecologist.Cure(patient3);
        Console.WriteLine("\n");
    }    
}
