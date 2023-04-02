namespace Homework4;

public static class Program
{
    public static void Main()
    {
        Counter counter = new Counter(); // Создание экземпляра класса-источника
        Handler1 handler1 = new Handler1(); // Создание экземпляра класса-обработчика
        Handler2 handler2 = new Handler2();
        counter.CounterHandlerEvent += handler1.Message; 
        // Указание событию методов из класса-обработчика, которые должны запуститься в ответ на событие
        // <ОбъектКласса>.<ИмяСобытия> += <КлассОбработчикЧейМетодДолженЗапуститься>.<МетодПодходящийПоСигнатуре>
        counter.CounterHandlerEvent += handler2.Message;
        counter.Counting(); // Запуск счетчика
    }
}    
   
