using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17
{
    /*17.	Класс Покупатель: Фамилия, Имя, Отчество, Адрес, Номер кредитной карточки, Номер банковского счета; Конструктор; Методы: установка значений атрибутов, получение значений атрибутов, вывод информации. Создать массив объектов данного класса. Вывести список покупателей в алфавитном порядке и список покупателей, у которых номер кредитной карточки находится в заданном диапазоне.*/
    public static class T17
    {
        public static void DoIt()
        {
            List<Buyer> l = new List<Buyer>();
            l.Add(new Buyer("Хреново", "Гадя", "Петрович", "Незнаю", 123456791234567, 987654321987654321));
            l.Add(new Buyer("Cat", "Murka", "", "Home", 7561234895158793, 2158439752566478954));
            l.Add(new Buyer("Dog", "Tuzik", "Ovcharkovich", "Yard", 2234985264985219, 956654771564897521));
            l.Add(new Buyer("Death", "Death", "Death", "Hell", 6600214059872549, 201201365402598745));

            l = l.OrderBy(x => x.FirstName).ToList();
            foreach (Buyer buyer in l)
                buyer.Show();
            long a = 3333333333333333;
            long b = 7777777777777777;
            var l1 = l.Where(x => x.KreditKard >= a && x.KreditKard <= b).ToList();
            foreach (Buyer buyer in l1)
                buyer.Show();
        }
    }
    public class Buyer
    {
        long kreditKard;
        long bankAccount;
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string Patronymic { set; get; }
        public string Adres { set; get; }
        public long KreditKard
        {
            set
            {
                if (value > 0 && value.ToString().Length == 16)
                    kreditKard = value;
            }
            get { return kreditKard; }
        }
        public long BankAccount
        {
            set
            {
                if (value > 0 && value.ToString().Length == 16)
                    bankAccount = value;
            }
            get { return bankAccount; }
        }
        public Buyer(string n, string s, string p, string a, long k, long b)
        {
            FirstName = n;
            SecondName = s;
            Patronymic = p;
            Adres = a;
            KreditKard = k;
            BankAccount = b;
        }
        public void Show()
        {
            Console.WriteLine("{0} {1} {2} live on {3}, has kredit kard #{4} connected with bank account #{5}", FirstName, SecondName, Patronymic, Adres, kreditKard, bankAccount);
        }
    }
}
