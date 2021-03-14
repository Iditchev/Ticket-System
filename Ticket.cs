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

        public virtual void AskUser () 
        
            
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
            }
        
         public virtual void AddTickettoFile (string file)   
         {
             StreamWriter sw = new StreamWriter(file);
             sw.WriteLine($"{ticketID},{summary},{status},{priority},{submitter},{assigned},{string.Join("|", watching)}");
                        
                         sw.Close();
         }
   
   
    }
public class Bug : Ticket
{
 public string Severity {get; set;}

 public override void AskUser ()
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
                       Console.WriteLine("Enter Severity of ticket");
                       Severity = Console.ReadLine();      
}
   public override void AddTickettoFile (string file)   
         {
             StreamWriter sw = new StreamWriter(file);
             sw.WriteLine($"{ticketID},{summary},{status},{priority},{submitter},{assigned},{string.Join("|", watching)},{Severity}");
                        
                         sw.Close();
         }
}
public class Enchancement : Ticket
{
    public string Software {get; set;}
    public string Cost {get; set;}
    public string Reason {get; set;}
    public string Estimate{get;set;}

        public override void AskUser()
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
                       Console.WriteLine("What is the Software");
                       Software = Console.ReadLine();

                       Console.WriteLine ("How much is the cost?");
                       Cost = Console.ReadLine();

                       Console.WriteLine("What is the reason?");
                       Reason = Console.ReadLine ();

                       Console.WriteLine("What is the estimate?");
                       Estimate = Console.ReadLine();

        }
        public override void AddTickettoFile (string file)   
         {
             StreamWriter sw = new StreamWriter(file);
             sw.WriteLine($"{ticketID},{summary},{status},{priority},{submitter},{assigned},{string.Join("|", watching)},{Software},{Cost},{Reason},{Estimate}");
                        
                         sw.Close();
         }
   }   
    public class Task : Ticket
    {
        public string ProjectName {get; set;}
        public string DueDate {get; set;}

         public override void AskUser ()
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
                       Console.WriteLine ("What is the Project Name?");
                       ProjectName = Console.ReadLine();

                       Console.WriteLine("What is the Due Date?");
                       DueDate = Console.ReadLine();

             }
              public override void AddTickettoFile (string file)   
         {
             StreamWriter sw = new StreamWriter(file);
             sw.WriteLine($"{ticketID},{summary},{status},{priority},{submitter},{assigned},{string.Join("|", watching)},{ProjectName},{DueDate}");
                        
                         sw.Close();
         }
         }    
}    
