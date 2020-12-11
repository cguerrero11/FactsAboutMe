using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace FactsAboutMe.Models
{
    public class ChrisFact
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string TheFact { get; set; }
        public string ShortFact { get; set; }
        public string FactImage { get; set; }
    }
}
