using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary
{
    class Diary
    {
        private Database database;

        public Diary()
        {
            database = new Database();
        }

        private DateTime GetDateTime()
        {
            Console.WriteLine("Type date and time in format of your computer (written above).");
            DateTime date_time;
            while(!DateTime.TryParse(Console.ReadLine(), out date_time))
            {
                Console.WriteLine("Incorrect input, type date and time again: ");
            }
            return date_time;
        }

        public void PrintRecords(DateTime day)
        {
            List<Record> records = database.FindRecords(day, false);
            foreach (Record r in records)
            {
                Console.WriteLine(r);
            }
        }

        public void AddRecord()
        {
            DateTime date_time = GetDateTime();
            Console.WriteLine("Write text of the record: ");
            string text = Console.ReadLine();
            database.AddRecord(date_time, text);
        }

        public void FindRecords()
        {
            DateTime date_time = GetDateTime();
            List<Record> records = database.FindRecords(date_time, false);
            if(records.Count() > 0)
            {
                Console.WriteLine("Records found: ");
                foreach(Record r in records)
                {
                    Console.WriteLine(r);
                }
            }
            else { Console.WriteLine("No records found."); }
        }

        public void DeleteRecords()
        {
            Console.WriteLine("You want to delete records in certain day and hour.");
            DateTime date_time = GetDateTime();
            database.DeleteRecord(date_time);
        }

        public void PrintIndroductoryScreen()
        {
            Console.Clear();
            Console.WriteLine("Welcome to diary!");
            Console.WriteLine("Today is: {0}", DateTime.Now);
            Console.WriteLine();
            Console.WriteLine("Today:\n------------------");
            PrintRecords(DateTime.Today);
            Console.WriteLine();
            Console.WriteLine("Tomorrow:\n------------------");
            PrintRecords(DateTime.Now.AddDays(1));
            Console.WriteLine();
        }
    }
}
