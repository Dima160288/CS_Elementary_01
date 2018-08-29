using System;


namespace Zadacha19
{
    class Program
    {

        static void Main(string[] args)
        {
            ClassHome[] cl1;
            cl1 = ClassHome.BuildArrayMethod(); // Создаем массив 
            cl1 = ClassHome.SortArray(cl1); // Сортируем
            ClassHome.PrintMetod(cl1);  // Выводим
        }



       
    }


}



