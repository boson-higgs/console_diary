using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary
{
    class Database
    {
        private List<Record> records;

        public Database()
        {
            records = new List<Record>();
        }

        public void AddRecord (DateTime date_time, string text)
        {
            records.Add(new Record(date_time, text));
        }

        public void DeleteRecord (DateTime date)
        {
            List<Record> found = FindRecords(date, true);
            foreach (Record r in found)
            {
                records.Remove(r);
            }
        }

        public List<Record> FindRecords (DateTime date, bool according)
        {
            List<Record> found = new List<Record>();
            foreach(Record r in records)
            {
                if (((according) && (r.Date_Time == date))
                    ||
                    ((!according) && (r.Date_Time.Date == date.Date)))
                    found.Add(r);
            }
            return found;
        }
    }
}
