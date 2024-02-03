using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EventOrganiser
{
    private List<Events> TheEvents = new List<Events>();

    public void AddEvent()
    {
        Events NewEvent = new Events();
        Console.WriteLine(" ");
        Console.Write("Enter the Event Title (Case Sensitive): ");
        NewEvent.Title = Console.ReadLine();
        Console.WriteLine(" ");
        Console.WriteLine("Enter the Event Description: ");
        Console.WriteLine(" ");
        NewEvent.Description = Console.ReadLine();
        Console.WriteLine(" ");
        Console.WriteLine("Enter Date and Time in YYYY/MM/DD HH:MM : ");
        Console.WriteLine(" ");
        NewEvent.DueDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine(" ");
        TheEvents.Add(NewEvent);
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("SYSTEM: New event saved. ");
    }

    public void SearchEvent()
    {
        Console.WriteLine(" ");
        Console.Write("Enter Event Title (Case Sensitive): ");
        string SearchTitle = Console.ReadLine();
        bool searchfound = false;
        foreach(Events ferdi in TheEvents)
        {
            if(ferdi.Title == SearchTitle)
            {
                Console.WriteLine("SYSTEM: Event found. ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Event Title: {0}", ferdi.Title);
                Console.WriteLine(" ");
                Console.WriteLine("Event Description: ");
                Console.WriteLine(" ");
                Console.WriteLine(ferdi.Description);
                Console.WriteLine(" ");
                Console.WriteLine("Event Date and Time: ");
                Console.WriteLine(ferdi.DueDate);
                searchfound = true;
                break;
            }
        }
        if (searchfound == false)
        {
            Console.WriteLine("SYSTEM: Event with Title: '{0}' Cannot be found.", SearchTitle);
        }
    }

    public void DisplayEvent()                                          // Must display upcoming events in nearest date first
    {
        int ferdi = 1;                                                  // This is the "index" that will make it easy for the user to see position
        TheEvents = TheEvents.OrderByDescending(e => e.DueDate).ToList();         // This code sorts the list of events into nearest event first before displaying it
        foreach(Events ferdinand in TheEvents)
        {
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Event {0}. {1}", ferdi, ferdinand.Title);
            Console.WriteLine(" ");
            Console.WriteLine("Event Description: {0}", ferdinand.Description);
            Console.WriteLine(" ");
            Console.WriteLine("Event Date and Time: {0}", ferdinand.DueDate);
            ferdi++;                                                    // This increments the index for each event
        }
    }

    public void RemoveEvent()
    {
        Console.WriteLine(" ");
        Console.Write("Enter Event to be removed (Case Sensitive): ");
        string SearchTitle = Console.ReadLine();
        bool searchfound = false;
        int indextoberemoved = 0;
        foreach (Events ferdi in TheEvents)
        {
            if (ferdi.Title == SearchTitle)
            {
                Console.WriteLine("SYSTEM: Event found. ");
                TheEvents.RemoveAt(indextoberemoved);
                Console.WriteLine("SYSTEM: Event Removed. ");
                searchfound = true;
                break;
            }
            indextoberemoved++;
        }
        if (searchfound == false)
        {
            Console.WriteLine("SYSTEM: Event with Title: '{0}' Cannot be found.", SearchTitle);
        }
    }
}
