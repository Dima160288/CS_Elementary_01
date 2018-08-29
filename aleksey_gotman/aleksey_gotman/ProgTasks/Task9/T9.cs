using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task9
{
    /*Построить четыре класса (базовый и 3 потомка), описывающих некоторых хищных животных (один из потомков), всеядных(второй потомок) и травоядных (третий потомок). Описать в базовом классе абстрактный метод для расчета количества и типа пищи, необходимого для пропитания животного в зоопарке.
a) Упорядочить всю последовательность животных по убыванию количества пищи. При совпадении значений – упорядочивать данные по алфавиту по имени. Вывести идентификатор животного, имя, тип и количество потребляемой пищи для всех элементов списка.
b) Вывести первые 5 имен животных из полученного в пункте а) списка.
c) Вывести последние 3 идентификатора животных из полученного в пункте а) списка.
d) Организовать запись и чтение коллекции в/из файл.
e) Организовать обработку некорректного формата входного файла.
*/
    public static class T9
    {
        static string path = "zoo.txt";
        public static List<Animal> zoo = new List<Animal>();
        public static List<Animal> sortedZoo;
        public static void Sort()
        {
            foreach (Animal a in zoo)
                a.AmountOfFood();
            sortedZoo = zoo.OrderByDescending(x => x.AmountFood).GroupBy(x => x.Name).SelectMany(x => x).ToList();
            Show(sortedZoo);
        }
        public static void Show(List<Animal> z)
        {
            foreach (Animal animal in z)
            {
                Console.WriteLine("Animal is {0},name: {1}, kind: {2}, amount of food: {3}", animal.GetType(), animal.Name, animal.Kind, animal.AmountFood);
            }
        }
        public static void ShowTopFive()
        {
            for (int i = 0; i < 5; i++)
                Console.WriteLine(sortedZoo[i].Name);
        }
        public static void ShowTopThree()
        {
            for (int i = sortedZoo.Count - 1; i < sortedZoo.Count - 4; i--)
                Console.WriteLine(sortedZoo[i].Kind);
        }
        public static void ReadFrom()
        {
            if (File.Exists(path))
            {
                zoo = new List<Animal>();
                try
                {
                    StreamReader r = new StreamReader(path);
                    string line = r.ReadLine();
                    while (line != null)
                    {
                        string[] s = line.Split(' ');
                        switch (Convert.ToInt32(s[0]))
                        {
                            case 1:
                                {
                                    zoo.Add(new Predator(s[1], s[2], Convert.ToInt32(s[3]), Convert.ToDouble(s[4])));
                                    break;
                                }
                            case 2:
                                {
                                    zoo.Add(new Omnivorous(s[1], s[2], Convert.ToInt32(s[3]), Convert.ToDouble(s[4])));
                                    break;
                                }
                            case 3:
                                {
                                    zoo.Add(new Herbivore(s[1], s[2], Convert.ToInt32(s[3]), Convert.ToDouble(s[4])));
                                    break;
                                }
                        }
                        line = r.ReadLine();
                    }
                    r.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
                Console.WriteLine("Wrong path or file not exists");
        }
        public static void WriteTo()
        {
            File.Create(path).Close();
            try
            {
                StreamWriter w = new StreamWriter(path);
                foreach(Animal a in zoo)
                {
                    int cl = 0;
                    if (a is Predator)
                        cl = 1;
                    else if (a is Omnivorous)
                        cl = 2;
                    else if (a is Herbivore)
                        cl = 3;
                    w.WriteLine("{0} {1} {2} {3} {4}", cl, a.Kind, a.Name, a.Weight, a.RatioActivity);
                }
                w.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
