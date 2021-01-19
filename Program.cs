using System;

namespace FinalExamEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            human hr = new human();

        }
    }

    public class human
    {
        public void awake(object sender, ABCEvent ABC)
        {
            Console.WriteLine($"Hi The time is {ABC.Anydate}");
        }
    }

    public delegate void ABCdelegate(object sender, ABCEvent ABC);
    public class ABCEvent : EventArgs
    {
        public DateTime Anydate { get; set; }

        public ABCEvent(DateTime Anytime)
        {
            Anydate = Anytime;
        }
    }
}
