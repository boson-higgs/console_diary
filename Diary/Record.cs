using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary
{
    class Record
    {
        public DateTime Date_Time { get; set; }
        public string Text { get; set; }

        public Record(DateTime date_time, string text)
        {
            this.Date_Time = date_time;
            this.Text = text;
        }

        public override string ToString()
        {
            return Date_Time + " " + Text;
        }
    }
}
