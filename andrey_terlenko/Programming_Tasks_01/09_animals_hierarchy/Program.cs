using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _09_animals_hierarchy
{
    class Program
    {   
        static void ShowList(List<BaseAnimal> Zoo)
        {
            foreach (var item in Zoo)
            {
                Console.WriteLine($"{item.Species} {item.Name} weights {item.Weight} kg and has activity ratio of {item.ActivityRatio}");
            }
        }

        static List<BaseAnimal> SortByFoodAmt(List<BaseAnimal> Zoo)
        {
            List<BaseAnimal> sortedZoo;
            foreach (var item in Zoo)
            {
                item.CalcFoodAmount();
            }
            sortedZoo = Zoo.OrderByDescending(x => x.FoodAmount).GroupBy(x => x.Name).SelectMany(x => x).ToList();
            return sortedZoo;
        }

        static void ShowFirstFive(List<BaseAnimal> Zoo)
        {
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"#{i + 1} - {Zoo[i].Species} {Zoo[i].Name} weights {Zoo[i].Weight} kg and has activity ratio of {Zoo[i].ActivityRatio}");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("No more elements");
            }
            
        }

        static void ShowLastThree(List<BaseAnimal> Zoo)
        {
            try
            {
                for (int i = Zoo.Count - 1; i > Zoo.Count - 4; i--)
                {
                    Console.WriteLine($"#{i + 1} - {Zoo[i].Species} {Zoo[i].Name} weights {Zoo[i].Weight} kg and has activity ratio of {Zoo[i].ActivityRatio}");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("No more elements");
            }            
        }

        static void WriteToFile(string path, List<BaseAnimal> Zoo)
        {
            if (File.Exists(path))
            {
                try
                {
                    using (StreamWriter sr = new StreamWriter(path))
                    {
                        foreach (BaseAnimal item in Zoo)
                        {
                            int animalType = 0;
                            if (item is Carnivore)
                            {
                                animalType = 1;
                            }
                            else if (item is Herbivore)
                            {
                                animalType = 2;
                            }
                            else if (item is Omnivore)
                            {
                                animalType = 3;
                            }
                            sr.WriteLine($"{animalType}>{item.Species}>{item.Name}>{item.Weight}>{item.ActivityRatio}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("File do not exist at specified location");
            }
        }

        static void ReadFromFile(string path, ref List<BaseAnimal> Zoo)
        {
            if (File.Exists(path))
            {
                try
                {
                    Zoo = new List<BaseAnimal>();
                    using (StreamReader sr = new StreamReader(path))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] lineToArr = line.Split('>');
                            switch (line[0])
                            {
                                case '1':
                                    Zoo.Add(new Carnivore(lineToArr[1], lineToArr[2], Convert.ToDouble(lineToArr[3]), Convert.ToDouble(lineToArr[4])));
                                    break;
                                case '2':
                                    Zoo.Add(new Herbivore(lineToArr[1], lineToArr[2], Convert.ToDouble(lineToArr[3]), Convert.ToDouble(lineToArr[4])));
                                    break;
                                case '3':
                                    Zoo.Add(new Omnivore(lineToArr[1], lineToArr[2], Convert.ToDouble(lineToArr[3]), Convert.ToDouble(lineToArr[4])));
                                    break;
                                default:
                                    Console.WriteLine("wtf man?");
                                    break;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("File do not exist at specified location");
            }
        }

        static void Main(string[] args)
        {
            string path = "zoo.txt";
            List<BaseAnimal> Zoo = new List<BaseAnimal>();
            Zoo.Add(new Carnivore("Fox", "Joe", 25, 2));
            Zoo.Add(new Herbivore("Cow", "Bob", 250, 0.5));
            Zoo.Add(new Omnivore("Mouse", "Steve", 0.3, 5));
            Zoo.Add(new Carnivore("Wolf", "Max", 55, 2.3));
            Zoo.Add(new Herbivore("Goat", "John", 12, 0.8));
            Zoo.Add(new Omnivore("Dog", "Alex", 25, 2.4));
            Zoo.Add(new Herbivore("Sheep", "Donald", 15, 0.7));
            Zoo.Add(new Omnivore("Rat", "Mike", 1.9, 2.8));
            Zoo.Add(new Omnivore("Bear", "Jason", 150, 1.3));
            Zoo.Add(new Omnivore("Racoon", "George", 7, 2.2));

            ShowList(Zoo);
            //Zoo = SortByFoodAmt(Zoo);
            //Console.WriteLine("--------------------------------------------------------------------------------");
            //ShowList(Zoo);
            //ShowFirstFive(Zoo);
            //ShowLastThree(Zoo);
            //WriteToFile(path, Zoo);
            Console.WriteLine("--------------------------------------------------------------------------------");

            //List<BaseAnimal> ZooRead = new List<BaseAnimal>();
            ReadFromFile(path, ref Zoo);
            ShowList(Zoo);
        }
    }
}
