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
