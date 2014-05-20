using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoccerStats.Data;
using SoccerStats.DataMod;

namespace SoccerStats.Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateDataBase();
        }

        private static void CreateDataBase()
        {
            var soocerLeague = new League() { Description = "Test League", Name = "Testers" };            
            var db = new Context();
            db.Leagues.Add(soocerLeague);
            db.SaveChanges();
            
        }
    }
}
