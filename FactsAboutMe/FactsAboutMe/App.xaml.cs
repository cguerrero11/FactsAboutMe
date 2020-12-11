using System;
using System.Collections.Generic;
using Xamarin.Forms;
using FactsAboutMe.Models;
using FactsAboutMe.Data;
using Xamarin.Forms.Xaml;

namespace FactsAboutMe
{
    public partial class App : Application
    {
        static ChrisFactDatabase database;
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        public static ChrisFactDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new ChrisFactDatabase();
                    prefillDatabase();

                }
                return database;
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        static void prefillDatabase()
        {
            database.ClearAllAsync();
            List<ChrisFact> all = new List<ChrisFact>();
            all.Add(new ChrisFact() { TheFact = "I really love exploring open world games.", ShortFact = "Exploring", FactImage = "gimpact.png" });
            all.Add(new ChrisFact() { TheFact = "I love taking care of plants, and just looking at them in general.", ShortFact = "Nature", FactImage = "nature.png" });
            all.Add(new ChrisFact() { TheFact = "My favorite place to vacation is in Wisconsin Dells.", ShortFact = "Vacation", FactImage = "wisdells.jpg" });
            all.Add(new ChrisFact() { TheFact = "It's fun taking pictures of anything that looks nice or cool.", ShortFact = "Taking pictures", FactImage = "galaxy.png" });
            all.Add(new ChrisFact() { TheFact = "I really don't like watermelon despite people always saying it's good.", ShortFact = "About watermelons...", FactImage = "watermelon.jpg" });
            all.Add(new ChrisFact() { TheFact = "My favorite food is fettuccine alfredo!", ShortFact = "Favorite food", FactImage = "alfredo.jpeg" });

            database.InsertList(all);

        }
    }
}
