using System;
using System.Collections.Generic;
using System.Text;

namespace Zadacha19
{
    class ClassHome
    {

        string adress;
        int etagnost, kol_podezdov, kol_kvartir;
        public ClassHome() { }
        public ClassHome(string adress, int etagnost, int kol_podezdov, int kol_kvartir)
        {
            this.adress = adress;
            this.etagnost = etagnost;
            this.kol_podezdov = kol_podezdov;
            this.kol_kvartir = kol_kvartir;
        }


        public static ClassHome[] BuildArrayMethod()        
        {
            int arraySize;
            string input;   
            do
            {
                Console.WriteLine("Введите количество домов (int)"); // Проверка вводимых данных о количестве 
                input = Console.ReadLine();                           //домов на корректность
            } while (false == (Int32.TryParse(input, out arraySize))); //

            ClassHome[] arrayHomes = new ClassHome[arraySize];
            string adress = "", kolEtageiS = "", kolPodezdovS = "", kolKvartirS = "";
            int kolEtagei = 0, kolPodezdov = 0, kolKvartir = 0;

            for (int i = 0; i < arraySize; i++)
            {
            notCorrect:
                Console.WriteLine("Введите адрес дома {0} из {1} домов ",i+1,arraySize);
                adress = Console.ReadLine();
                Console.WriteLine("Этажность дома (int)");
                kolEtageiS = Console.ReadLine();
                Console.WriteLine("Количество подъездов(int)");
                kolPodezdovS = Console.ReadLine();
                Console.WriteLine("Количество квартир на этаже (int)");
                kolKvartirS = Console.ReadLine();
                if ((Int32.TryParse(kolEtageiS, out kolEtagei)) & (Int32.TryParse(kolPodezdovS, out kolPodezdov)) & (Int32.TryParse(kolKvartirS, out kolKvartir)))
                {
                    ClassHome home = new ClassHome(adress, kolEtagei, kolPodezdov, kolKvartir);
                    arrayHomes[i] = home;
                }
                else
                {
                    Console.WriteLine("Не корректный ввод данных, попробуйте снова");
                    goto notCorrect;
                }
            }
            return arrayHomes;
        }


        public static ClassHome[] SortArray(ClassHome[] array)  //Метод сортировки
        {

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i].etagnost < array[j].etagnost)
                    {
                        ClassHome b = new ClassHome();
                        b = array[i];

                        array[i] = array[j];
                        array[j] = b;
                    }

                }
            }
            return array;
        }
        public static void PrintMetod(ClassHome[] cl1)  //Метод выводящий всю итоговую информацию 
        {
            int i = 0;
            foreach (ClassHome element in cl1)
            {
                if (i <= cl1.Length)
                {

                    Console.WriteLine(" Дом по адресу {0} : Количество этажей {1}", cl1[i].adress, cl1[i].etagnost);
                    i++;
                }
            }

        }

    }
}





