using System;
using System.IO;
namespace Ticketing_System
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "Tickets.csv";
            //string choice;
            //do
            //{
                // ask user a question
                //Console.WriteLine("1) View tickets.");
                //Console.WriteLine("2) Add ticket record.");
                //Console.WriteLine("Enter any other key to exit.");
                //// input response
                //choice = Console.ReadLine();

                //if (choice == "1")
                //{
                //    // TODO: read data from file
                //}
                //else if (choice == "2")
                {
                    // create file from data
                    StreamWriter sw = new StreamWriter(file);
                    string resp;
                    do
                    {
                        // ask a question
                        Console.WriteLine("Enter a Ticket (Y/N)?");
                        // input the response
                        resp = Console.ReadLine().ToUpper();
                        // if the response is anything other than "Y", stop asking
                        if (resp != "Y") { break; }
                        Console.WriteLine("Enter the ticket ID.");

                        string ticketID = Console.ReadLine();

                        Console.WriteLine("Enter the ticket summary.");

                        string summary = Console.ReadLine();

                        Console.WriteLine("Enter the ticket status.");

                        string status = Console.ReadLine();

                        Console.WriteLine("Enter Priority.");

                        string priority = Console.ReadLine();

                        Console.WriteLine("Enter Submitter.");

                        string submitter = Console.ReadLine();

                        Console.WriteLine("Enter who is Assigned.");

                        string assigned = Console.ReadLine();

                        Console.WriteLine("How many are watching the ticket?");

                        int numberwatching = Convert.ToInt32(Console.ReadLine());

                        string[] watching = new string[numberwatching];
                        for (int j = 0; j < numberwatching; j++)
                        {
                            Console.WriteLine("Enter full name");
                            watching[j] = Console.ReadLine();
                        }
                        sw.WriteLine("{0},{1},{2},{3},{4},{5},", ticketID, summary, status, priority, submitter, assigned);
                        foreach (string watch in watching)
                        {
                            sw.Write("{0}|", watch);
                        }
                    } while (resp == "Y");

                    sw.Close();
                }
            //} while (choice == "1" || choice == "2");
        }
    }
}