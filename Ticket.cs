using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ticketing_System
{
   public abstract class Ticket
    {
        public string ticketID {get; set;}
        public string summary {get; set;}
        public string status {get; set;}
        public string priority {get; set;}
        public string submitter {get; set;}
        public string assigned {get; set;}
        public int numberwatching {get; set;}
        public string[] watching {get; set;}

        public virtual void DefaultTicket (string resp)
        {
            if (resp == "Y")
            {
             Console.WriteLine("Enter the ticket ID.");

                        ticketID = Console.ReadLine();

                        Console.WriteLine("Enter the ticket summary.");

                        summary = Console.ReadLine();

                        Console.WriteLine("Enter the ticket status.");

                        status = Console.ReadLine();

                        Console.WriteLine("Enter Priority.");

                        priority = Console.ReadLine();

                        Console.WriteLine("Enter Submitter.");

                        submitter = Console.ReadLine();

                        Console.WriteLine("Enter who is Assigned.");

                        assigned = Console.ReadLine();

                        Console.WriteLine("How many are watching the ticket?");

                        numberwatching = Convert.ToInt32(Console.ReadLine());

                        watching = new string[numberwatching];
                        for (int j = 0; j < numberwatching; j++)
                        {
                            Console.WriteLine("Enter full name");
                            watching[j] = Console.ReadLine();
                       }          
             } else Console.WriteLine("Good Bye");
        }
         public virtual void AddTickettoFile (string file)   
         {
             StreamWriter sw = new StreamWriter(file);
             sw.WriteLine($"{ticketID},{summary},{status},{priority},{submitter},{assigned},{string.Join("|", watching)}");
                        
                         sw.Close();
         }
   
   
    }

}    
        
