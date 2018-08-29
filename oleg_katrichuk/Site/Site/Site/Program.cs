using System;

namespace Site
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Information
    {
        public string Author { get; set; }
        public DateTime date { get; }
        public void Write()
        {

        }

    }

    class ScientificInformation : Information
    {
        public string Data { get; set; }

        public void ShowFutureData()
        {
            
        }

    }

    class SportInformation : Information
    {
        public string KindOfSport { get; set; }

    }

    class EntertainingInformation : Information
    {
        public string FunnyStories { get; set; }
    }

    class Physics:ScientificInformation
    {
        
    }

    class Astronomy :ScientificInformation
    {
        
    }

    class Football:SportInformation
    {
        
    }

    class BasketBall:SportInformation
    {
        
    }

    class Anecdote:EntertainingInformation
    {
        
    }

    class Picture:EntertainingInformation
    {
        
    }
}
