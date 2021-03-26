using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Ticketing_System
{
    public abstract class TicketFile
    {
        // public property
        public string filePath { get; set; }
        public List<Ticket> Tickets { get; set; }

        public override void TicketFile (string ticketfilepath)
        {
            filePath = ticketfilepath;
            Tickets = new List<Ticket>();

             
            
                StreamReader sr = new StreamReader(filePath);
                while (!sr.EndOfStream)
                {
                    // create instance of Movie class
                    Ticket ticket = new Bug();
                    string line = sr.ReadLine();

                    string[] ticketDetails = line.Split(',');
                        ticket.ticketID = ticketDetails[0];
                        ticket.summary = ticketDetails[1];
                        ticket.status = ticketDetails[2];
                        ticket.priority = ticketDetails[3];
                        ticket.submitter = ticketDetails[4];
                        ticket.assigned = ticketDetails[5];
                        ticket.watching = ticketDetails[6].Split('|').ToArray();
                        
                        Tickets.Add(ticket);

                }
                sr.Close();
            }  
        } 
    }         
    public class BugFile : TicketFile
    {

    }

    public class EnchancementFile : TicketFile
    {

    }

    public class TaskFile : TicketFile
    {

    }
}  
