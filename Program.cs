using System;
using System.IO;
namespace Ticketing_System
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "Tickets.csv";
           
                    
                    string resp;
                    do
                    {
                        // ask a question
                        Console.WriteLine("Enter a Ticket (Y/N)?");
                        // input the response
                        resp = Console.ReadLine().ToUpper();
                        // if the response is anything other than "Y", stop asking
                        if (resp != "Y") { break; }
                        Ticket newticket = new Ticket(resp);
                        newticket.AddTickettoFile(file); 
                        
                    } while (resp == "Y");

                   
                }
            
        }
    }
