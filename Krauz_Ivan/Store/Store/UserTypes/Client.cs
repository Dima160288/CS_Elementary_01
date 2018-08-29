using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Client : Visitor
    {
        private int cardNumber;
        public bool RegisterStatus;

        public int CardNumber { get => cardNumber; set => cardNumber = value; }

        public void AddToCart()
        {
            //Занесение в List.Cart позиции из List.ShowCase (Витрина)
        }

        public void DelFromCart()
        {
            //Удаление из List.Cart позиции

        }

        public void OpenCart()
        {
            //Выводит на экран List.Cart
        }

        public void GoToCashbox()
        {
            //Вызывает метод подсчета стоимости покупки и ее оплаты
        }
    }
}
