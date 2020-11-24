using System;
using System.Collections.Generic;
using System.Text;

namespace FactsAboutMe
{
    class ChrisFactData
    {
        public ChrisFactData()
        {

        }
        public static IEnumerable<ChrisFactData> All { private set; get; }
        public string TheFact { get; set; }
        public string ShortFact { get; set; }
        public string FactImage { get; set; }
        static ChrisFactData()
        {
            List<ChrisFactData> all = new List<ChrisFactData>();
            all.Add(new ChrisFactData() { TheFact = "I really love exploring open world games.", ShortFact = "Exploring", FactImage = "gimpact.png"});
            all.Add(new ChrisFactData() { TheFact = "I love taking care of plants, and just looking at them in general.", ShortFact = "Nature", FactImage = "nature.png" });
            all.Add(new ChrisFactData() { TheFact = "My favorite place to vacation is in Wisconsin Dells.", ShortFact = "Vacation", FactImage = "wisdells.jpg" });
            all.Add(new ChrisFactData() { TheFact = "It's fun taking pictures of anything that looks nice or cool.", ShortFact = "Taking pictures", FactImage = "galaxy.png" });

            all.Add(new ChrisFactData() { TheFact = "I really don't like watermelon despite people always saying it's good.", ShortFact = "About watermelons...", FactImage = "watermelon.jpg" });
            all.Add(new ChrisFactData() { TheFact = "My favorite food is fettuccine alfredo!", ShortFact = "Favorite food", FactImage = "alfredo.jpeg" });

            All = all;

        }
    }
}
