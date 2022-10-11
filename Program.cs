using System;

namespace EventApp
{
    //Creating interfaces.
    public interface IWedding
    {
        void printEventInfo();
        double doDiscount(string str);

    }

    public interface IBirthday
    {
        void printEventInfo();
        double doDiscount(string str);
    }

    public interface IGraduation
    {
        void printEventInfo();
        double doDiscount(string str);

    }

    //Class to get and set id, description, and cost to newID, newDescription, newCost.
    public class EventInfo
    {
        int id;
        string description;
        double cost;

        public EventInfo(int newID, string newDescription, double newCost)
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

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public override string ToString()
        {
            return "ID: " + ID.ToString() + " - Location: " + Description + " - Cost: " + cost.ToString();
        }
    }

    //Event class implementing the three event interfaces.
    public class Event : IWedding, IBirthday, IGraduation
    {
        private EventInfo theEvent;

        public Event(int newID, string newDescription, double newCost)
        {
            theEvent = new EventInfo(newID, newDescription, newCost);
        }

        void IWedding.printEventInfo()
        {
            Console.WriteLine("Wedding is located at: " + theEvent.Description + ". The wedding will cost: " + theEvent.Cost);
        }

        void IGraduation.printEventInfo()
        {
            Console.WriteLine("Graduation party is located at: " + theEvent.Description + ". The graduation will cost: " + theEvent.Cost);
        }

        void IBirthday.printEventInfo()
        {
            Console.WriteLine("Birthday party is located at: " + theEvent.Description + ". The B-day party will cost: " + theEvent.Cost);
        }

        public void printEventInfo()
        {
            Console.WriteLine("Basic event is located at: " + theEvent.Description + ". The basic event will cost: " + theEvent.Cost);
        }

        public override string ToString()
        {
            return theEvent.ToString();
        }

        // Method that takes a single characted of code. E - employee 25% discount. D - 10% discount
        // L - 10% late fee. F - 100% discount. If nothing is passed original cost is passed.
        public double doDiscount(string str)
        {
            double x = 0;
            double newCost = 0;

            if (str.ToLower() == "l")
            {
                x = (theEvent.Cost * 10) / 100;
                newCost = theEvent.Cost + x;
                Console.WriteLine("Whoops! You have a late fee! The total cost is now: " + newCost);
                return newCost;
            }
            else if (str.ToLower() == "d")
            {
                x = (theEvent.Cost * 10) / 100;
                newCost = theEvent.Cost - x;
                Console.WriteLine("Nice! You have a discount! The total cost is now: " + newCost);
                return newCost;
            }
            else if (str.ToLower() == "f")
            {
                newCost = 0;
                Console.WriteLine("Free discount! You're total cost is now: " + newCost);
                return newCost;
            }
            else if (str.ToLower() == "e")
            {
                x = (theEvent.Cost * 25) / 100;
                newCost = theEvent.Cost - x;
                Console.WriteLine("You're an employee and get a 25% discount. The total cost is now: " + newCost);
                return newCost;
            }
            else
            {
                Console.WriteLine("You're total cost is: " + theEvent.Cost);
                return theEvent.Cost;
            }
        }


    }
    public class Program
    {
        static void Main(string[] args)
        {
            

            IWedding wedding = new Event(1, "Church", 400);
            IGraduation graduation = new Event(2, "Tuxedo Park", 150);
            IBirthday birthday = new Event(3, "Worlds of Fun", 100);
            Event myEvent = new Event(4, "Rodery Park", 80);
            Console.WriteLine();
            Console.WriteLine(wedding);
            Console.WriteLine(birthday);
            Console.WriteLine(graduation);
            Console.WriteLine(myEvent);
            Console.WriteLine();
            wedding.printEventInfo();
            graduation.printEventInfo();
            birthday.printEventInfo();
            myEvent.printEventInfo();
            Console.WriteLine();
            birthday.doDiscount("l");
            birthday.doDiscount("d");
            birthday.doDiscount("e");
            birthday.doDiscount("f");
            birthday.doDiscount("");

            Console.ReadKey();
        }
    }
}

