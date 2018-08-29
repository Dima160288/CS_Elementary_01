using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task19
{
    /*19.	Задача на взаимодействие между классами. Разработать систему «Автобаза». Диспетчер распределяет заявки на Рейсы между Водителями и назначает для этого Автомобиль. Водитель может сделать заявку на ремонт. Диспетчер может отстранить Водителя от работы. Водитель делает отметку о выполнении Рейса и состоянии Автомобиля. */
    public class T19
    {

    }
    public class Worker
    {
        public string FirstName { get; }
        public string SecondName { get; }
    }
    public class Driver : Worker
    {
        Car car;
        public RequestRoute request;
        public void FixCar(string crashReport)
        {
            Dispatcher.requestFixes.Add(new RequestFix(car, crashReport));
        }
        public void TaskDone(string status)
        {
            car.status = status;
            request.status = true;
        }
    }
    public class Dispatcher : Worker
    {
        static List<Driver> drivers = new List<Driver>();
        static List<RequestRoute> requests = new List<RequestRoute>();
        public static List<RequestFix> requestFixes = new List<RequestFix>();
        public void DelegateRequest(Driver d, string task)
        {
            RequestRoute request = new RequestRoute(d, task);
            requests.Add(request);
            d.request = request;
        }
        public void SuspendDriver(Driver d)
        {
            foreach (RequestRoute r in requests)
            {
                if (r.driver == d)
                    r.driver = null;
            }
            d.request = null;
        }
    }
    public class RequestFix
    {
        Car c;
        string crashReport;
        public RequestFix(Car c, string cr)
        {
            this.c = c;
            crashReport = cr;
        }
    }
    public class RequestRoute
    {
        public bool status;
        public Driver driver;
        string task;
        public RequestRoute(Driver d, string task)
        {
            driver = d;
            this.task = task;
        }
    }
    public class Car
    {
        public string status;
    }
}
