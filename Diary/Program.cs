using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            char option = '0';
            while(option != '4')
            {
                diary.PrintIndroductoryScreen();
                Console.WriteLine();
                Console.WriteLine("Choose: ");
                Console.WriteLine("1 - Add record");
                Console.WriteLine("2 - Find record");
                Console.WriteLine("3 - Delete record");
                Console.WriteLine("4 - Quit");
                option = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (option)
                {
                    case '1':
                        diary.AddRecord();
                        break;
                    case '2':
                        diary.FindRecords();
                        break;
                    case '3':
                        diary.DeleteRecords();
                        break;
                    case '4':
                        Console.WriteLine("Press any key to quit...");
                        break;
                    default:
                        Console.WriteLine("Invalid option, press any key to continue");
                        break;
                }
                Console.ReadKey();
            }

        }
    }
}
