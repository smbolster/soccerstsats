using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SoccerStats.Data;
using SoccerStats.DataModels;


namespace SoccerStats.Controllers
{
    [RoutePrefix("api/v1/team")]
    public class TeamController : ApiController
    {
        [Route("")]
        public HttpResponseMessage Get()
        {
            List<Team> teams  = new List<Team>();
            Team team1 = new Team() { Id = 1, TeamName = "Team 1" };
            team1.Players.Add(new Player() { FirstName = "Sean", Id = 1, LastName = "Test1", MiddleName = "", Number = "2" });
            team1.Players.Add(new Player() { FirstName = "Mike", Id = 2, LastName = "Tester", MiddleName = "", Number = "3" });
            team1.Players.Add(new Player() { FirstName = "Sean", Id = 3, LastName = "Test2", MiddleName = "", Number = "4" });
            Team team2 = new Team() { Id = 2, TeamName = "Team 2" };
            team1.Players.Add(new Player() { FirstName = "Sean", Id = 4, LastName = "Test1", MiddleName = "", Number = "2" });
            team1.Players.Add(new Player() { FirstName = "Mike", Id = 5, LastName = "Tester", MiddleName = "", Number = "3" });
            team1.Players.Add(new Player() { FirstName = "Sean", Id = 6, LastName = "Test2", MiddleName = "", Number = "4" });
            teams.Add(team1);
            teams.Add(team2);

            return Request.CreateResponse(HttpStatusCode.OK, teams);
        }
    }
}
