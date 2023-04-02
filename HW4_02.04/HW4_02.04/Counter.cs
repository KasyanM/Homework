namespace Homework4;

public class Counter // Класс для счета; источник/издатель события
{
    public delegate void CounterHandler(); // На методы void Message()
    // Делегат на основе сигнатуры метода:
    // delegate <выходной тип данных> ИмяДелегата <входной тип данных> 
    // <выходной тип данных> - в случае методов Message в классах Handler1/2 это void
    // <входной тип данных> - в случае методов Message в классах Handler1/2 пусто, они ничего не принимают
    public event CounterHandler CounterHandlerEvent; 
    // Событие, связанное с делегатом, а следовательно, и с методами с сигнатурой void(void)
    // public event <ИмяДелегата> <ИмяСобытия>

    public void Counting () // Метод-счетчик
    {
        for (int i = 0; i < 100; i++)
        {
            if (i == 77) // Условие для вызова события
            {
                CounterHandlerEvent?.Invoke(); // Вызов события в методе-счетчике
            }
        }
    }
}

