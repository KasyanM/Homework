using Homework3;
using System.Data;

namespace Homework2;

public static class Program
{
    public static void Main()
    {
        Patient patient1 = new Patient("Инна", "Васильева", 30, false, true, true);
        patient1.DisplayInfo();

        Coloproctologist col1 = new Coloproctologist("Иван", "Карлов", "Кто-то", 5);
        col1.DisplayInfo();
    }    
}
