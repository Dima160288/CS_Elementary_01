using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryInfo
{
    public class Interaction
    {
        public static void InformationMethod()
        {
            string infoTask = ("Программа Вячеслава Кириченко \n ЗАДАНИЕ \n Создайте структуру с именем student, содержащую поля: " +
                "\n фамилия и инициалы, номер группы, успеваемость (массив из пяти элементов)." +
                "\nСоздать массив из десяти элементов такого типа, упорядочить записи по \n возрастанию среднего балла." +
                "Добавить возможность вывода фамилий и номеров \n групп студентов, имеющих оценки, равные только 4 или 5.\n Для продолжения нажмите любую клавишу\n\n");
            Console.WriteLine(infoTask);
            Console.ReadLine();
        }
    }
}
