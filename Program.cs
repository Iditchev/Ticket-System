using System;
using System.IO;
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
                        Console.WriteLine("Enter a Ticket (Y/N)?");
                        // input the response
                        resp = Console.ReadLine().ToUpper();
                        if (resp != "Y") { break; }
                        Console.WriteLine("Choose the ticket type:");
                        Console.WriteLine("1. Bug/Defect");
                        Console.WriteLine("2. Enhancement");
                        Console.WriteLine("3. Task");
                        
                        string TicketType = Console.ReadLine();
                        if (TicketType == "1")
                        {
                            Bug newbug = new Bug
                            newbug.Bugfile(Bugfile);
                        }

                        if (TicketType == "2")
                        {
                            Enhancement newenchanement = new Enhancement
                            newenchanement.EnchancementFile(EnchancementFile);
                        
                        }
                        
                        if (TicketType == "3")
                        {
                            Task newtask = new Task
                            newtask.TaskFile(TaskFile);
                        }

                        else (Console.Writeline("Invalid Input"))
                        
                    } while (resp == "Y");

                   
                }
            
        }
    }
