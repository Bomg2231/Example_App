using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Example2
{
    public class Link
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string link { get; set; }
        public string PDFName { get; set; }
        public bool Done { get; set; }
    }
}
