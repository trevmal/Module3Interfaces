using System;

namespace EventApp
{
    public interface IWedding
    {
        void printEventInfo();
    }

    public interface IBirthday
    {
        void printEventInfo();
    }

    public interface IGraduation
    {
        void printEventInfo();
    }

    public class EventInfo
    {
        int id;
        string description;
        int cost;

        public EventInfo(int newID, string newDescription, int newCost)
        {
            id = newID;
            description = newDescription;
            cost = newCost;
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public override string ToString()
        {
            return "ID: " + ID.ToString() + " - Location: " + Description + " - Cost: " + cost.ToString();
        }
    }
    public class Event : IWedding, IBirthday, IGraduation
    {
        private EventInfo theEvent;

        public Event(int newID, string newDescription, int newCost)
        {
            theEvent = new EventInfo(newID, newDescription, newCost);
        }

        void IWedding.printEventInfo()
        {
            Console.WriteLine("Wedding is located at: " + theEvent.Description);
        }

        void IGraduation.printEventInfo()
        {
            Console.WriteLine("Graduation party is located at: " + theEvent.Description);
        }

        void IBirthday.printEventInfo()
        {
            Console.WriteLine("Birthday party is located at: " + theEvent.Description + ". The B-day party will cost: " + theEvent.Cost);
        }

        public void printEventInfo()
        {
            Console.WriteLine("Basic event is located at: " + theEvent.Description);
        }

        public override string ToString()
        {
            return theEvent.ToString();
        }

        // Exceptional level
        public void doDiscount()
        {
            
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            

            IWedding wedding = new Event(1, "Church", 400);
            IGraduation graduation = new Event(2, "Tuxedo Park", 150);
            IBirthday birthday = new Event(3, "Worlds of Fun", 200);
            Event myEvent = new Event(4, "Rodery Park", 80);
            wedding.printEventInfo();
            graduation.printEventInfo();
            birthday.printEventInfo();
            myEvent.printEventInfo();
            
            Console.WriteLine(wedding);
            Console.WriteLine(birthday);
            Console.WriteLine(graduation);
            Console.WriteLine(myEvent);

            Console.ReadKey();
        }
    }
}

