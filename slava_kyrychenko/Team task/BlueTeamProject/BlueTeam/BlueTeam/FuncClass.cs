using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueTeam
{
    class FuncClass
    {

        public void ProgramMethod()
        {
            int sw = 0;
            bool quit = false;
            Goods goods = new Goods();
            List<Goods> collection = new List<Goods>();
            do
            {
                Inform();
                sw = Convert.ToInt32(Console.ReadLine());
                switch (sw)
                {
                    case 1:
                        {
                            Console.WriteLine("");
                            //загрузка из файла     <<<<<------------------------
                            break;
                        }
                    case 2:
                        {
                            collection.Add(GoogsAdd());
                            break;
                        }
                    case 3:
                        {
                            collection = SortGoods(collection);
                        }
                        break;
                    case 4:
                        DisplayPrint(collection);
                        break;
                    case 5:
                      // <<<-----------------------Сохранение в файл 
                        break;
                    case 6:
                        {
                            collection = DelGoods(collection);
                            break;
                        }
                    case 7:
                        {
                            quit = true;
                            Console.WriteLine("******************************До свидания!!!*****************************");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Не корректный ввод, читайте инструкцию");
                            Inform();
                            break;
                        }
                }
            }
            while (!quit);
        }

        public static void Inform()
        {
            Console.WriteLine("************************  Иформационная таблица  *****************************");
            Console.WriteLine("1)  Загрузить данные о товарах из файла (БД):          кнопка 1  ");
            Console.WriteLine("2)  Добавить данные про товар в ручную:                кнопка 2  ");
            Console.WriteLine("3)  Сортировка товаров по названию, цене, рейтингу:    кнопка 3  ");
            Console.WriteLine("4)  Вывести остаток всего товара на экран:             кнопка 4  ");
            Console.WriteLine("5)  Сохранить в файл (БД):                             кнопка 5  ");
            Console.WriteLine("6)  Удалить единицу товара(Покупка):                            кнопка 6  ");
            Console.WriteLine("7)  Выйти из программы:                                кнопка 7 \n \r ");
        }

        public Goods GoogsAdd()       //  # case 2  
        {
            Console.WriteLine("------------------Добавление товара ");
            Console.WriteLine("Имя товара");
            Console.WriteLine("Описание");
            Console.WriteLine("ID ");
            Console.WriteLine("Цена");
            Goods goodsAdd = new Goods(Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()),
                                       Convert.ToDouble(Console.ReadLine()));
            return goodsAdd;
        }

        public List<Goods> SortGoods(List<Goods> list)  // case #3 
        {
            // List<Goods> sortList = new List<Goods>();
            Goods tempGoods = new Goods();
            int sortT = 0;
            Console.WriteLine("Сортировать по названию : 1" +
                                          "\n \r \t по цене  : 2" +
                                          " \n \r \t по рейтингу : 3");
            sortT = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------Сортировка товаров--------");

            switch (sortT)
            {
                case 1:
                    {
                        Console.WriteLine("-----------Выполнена сортировка по названию товара");
                        for (int i = 0; i < list.Count - 1; i++)
                        {
                            for (int j = list.Count - 1; j > 0; j--)
                            {
                                if (list[j].Name.CompareTo(list[j - 1].Name) == -1)
                                {
                                    tempGoods = list[j];
                                    list[j] = list[j - 1];
                                    list[j - 1] = tempGoods;
                                }
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("-----------Выполнена сортировка по цене товара");
                        for (int i = 0; i < list.Count - 1; i++)
                        {
                            for (int j = list.Count - 1; j > 0; j--)
                            {
                                if (list[j].Price > list[j - 1].Price)
                                {
                                    tempGoods = list[j];
                                    list[j] = list[j - 1];
                                    list[j - 1] = tempGoods;
                                }
                            }
                        }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("-----------Выполнена сортировка по рейтингу товара");
                        for (int i = 0; i < list.Count - 1; i++)
                        {
                            for (int j = list.Count - 1; j > 0; j--)
                            {
                                if (list[j].Rating > list[j - 1].Rating)
                                {
                                    tempGoods = list[j];
                                    list[j] = list[j - 1];
                                    list[j - 1] = tempGoods;
                                }
                            }
                        }
                        break;
                    }
            }
            return list;
        }
        public void DisplayPrint(List<Goods> list)  //case #4 
        {
            int count = 0;
            Console.WriteLine("--------------------Остаток на складе");
            Console.WriteLine("\t Name \t Descriptions \t Id \t Price \t Rating");
            foreach (var goods in list)
            {
                count++;
                Console.WriteLine(" {5} ) \t {0} \t {1} \t {2} \t {3} \t {4}", goods.Name, goods.Description, goods.Id, goods.Price, goods.Rating, count);
            }
        }
        public List<Goods> DelGoods(List<Goods> list) //case #6
        {
            bool quit = false;
            int flagAdd = 0;
            int numberGoodsSelect = 0;
            List<Goods> korzina = new List<Goods>();

            do
            {
                Console.WriteLine("Выберите номер товара из списка для добавления в корзину");
                DisplayPrint(list);
                numberGoodsSelect = Convert.ToInt32(Console.ReadLine()) - 1;
                flagAdd = 0;

                foreach (var g in korzina)
                {
                    if (g.Equals(list[numberGoodsSelect]))
                        flagAdd++;
                }
                if (flagAdd == 0)
                {
                    korzina.Add(list[numberGoodsSelect]);

                    Console.WriteLine("Товар  {0}  добавлен в корзину", list[numberGoodsSelect].Name);
                    list.RemoveAt(numberGoodsSelect);
                }
                Console.WriteLine("\n \t  Для выхода нажмите 'q'");
                if ("q" == Console.ReadLine())
                    quit = true;
            }
            while (!quit);
            Console.WriteLine("\n -------------------Список купленных товаров ");
            DisplayPrint(korzina);  /// не работает ??? вывод корзины ??

            return list;
        }
    }
}
