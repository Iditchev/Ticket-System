using System;
using System.IO;
using System.Linq; 
using System.Collections.Generic;
namespace Ticketing_System
{
    class Program
    {
        static void Main(string[] args)
        {
            string Bugfile = "Tickets.csv";
            string EnchancementFile ="Enchancements.csv";
            string TaskFile = "Task.csv";
           
                    
                    string resp;
                    do
                    {
                        // ask a question
                        Console.WriteLine("1) Enter a Ticket");
                        Console.WriteLine("2) Search for Ticket");
                        Console.WriteLine("3) Display Tickets");
                        Console.WriteLine("Anything else to Exit");
                        // input the response
                        resp = Console.ReadLine();
                        if (resp == "1") 

                        {
                        Console.WriteLine("Choose the ticket type:");
                        Console.WriteLine("1. Bug/Defect");
                        Console.WriteLine("2. Enhancement");
                        Console.WriteLine("3. Task");
                        
                            string TicketType = Console.ReadLine();
                            if (TicketType == "1")
                            {
                            Bug newbug = new Bug();
                            newbug.AskUser();
                            newbug.AddTickettoFile(Bugfile);
                            }

                            if (TicketType == "2")
                            {
                            Enhancement newenhancement = new Enhancement();
                            newenhancement.AskUser();
                            newenhancement.AddTickettoFile(EnchancementFile);
                        
                            }
                        
                            if (TicketType == "3")
                            {
                            Task newtask = new Task ();
                            newtask.AskUser();
                            newtask.AddTickettoFile(TaskFile);
                            }
                        }
                       
                     else if (resp == "2")
                      {
                          Console.WriteLine("Search on:");
                          Console.WriteLine("1) Status");
                          Console.WriteLine("2) Priority");
                          Console.WriteLine("3) Submitter");

                          String searchtype = Console.ReadLine();
                            BugFile newbugfile = new BugFile();
                            EnchancementFile newEnhancementFile = new EnchancementFile();
                            TaskFile newtaskfile = new TaskFile();
                            newbugfile.FileRead(Bugfile);
                            newEnhancementFile.FileRead(EnchancementFile);
                            newtaskfile.FileRead(TaskFile);
                             if (searchtype =="1")  
                             {
                             Console.WriteLine("Enter Status you are searching for:");
                             string search = Console.ReadLine().ToLower();
                             var bugfilesearch =  newbugfile.Tickets.Where(m => m.status.ToLower().Contains((search)));
                             var enhancementfilesearch = newEnhancementFile.Tickets.Where(m => m.status.ToLower().Contains((search)));
                             var taskfilesearch = newtaskfile.Tickets.Where(m => m.status.ToLower().Contains((search)));
                                var Statuslist = bugfilesearch.Concat(enhancementfilesearch).Concat(taskfilesearch);
                            
                                // LINQ - Count aggregation method
                                 Console.WriteLine($"There are {Statuslist.Count()} tickets with \"{search}\" as the Status:");
                                    foreach(Ticket t in Statuslist)
                                     {
                                        Console.WriteLine(t.Display());
                                     }  
                             }         
                        }
                        else if (resp == "3")
                        {
                            Console.WriteLine("1) Display Bug Tickets");
                            Console.WriteLine("2) Display Enchancement Tickets");
                            Console.WriteLine("3) Display Task Tickets");
                            string TicketType = Console.ReadLine();
                            BugFile newbugfile = new BugFile();
                            EnchancementFile newEnhancementFile = new EnchancementFile();
                            TaskFile newtaskfile = new TaskFile();

                            newbugfile.FileRead(Bugfile);
                            newEnhancementFile.FileRead(EnchancementFile);
                            newtaskfile.FileRead(TaskFile);
                            if (TicketType == "1")
                            {
                                  
                                foreach(Ticket t in newbugfile.Tickets )
                                {
                                    Console.WriteLine(t.Display());
                                 }
                            }
                            else if (TicketType == "2")
                            {
                                foreach(Ticket t in newEnhancementFile.Tickets)
                                {
                                    Console.WriteLine(t.Display());
                                }
                            }
                            else if (TicketType == "3")
                            {
                                foreach(Ticket t in newtaskfile.Tickets)
                                {
                                    Console.WriteLine(t.Display());
                                }
                            }
                         }               

                    }while (resp == "1"|| resp == "2"|| resp == "3");
        } 

                        
                        
    } 

                   
    
            
}
    
