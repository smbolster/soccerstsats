using SoccerStats.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SoccerStats.Controllers
{
    [RoutePrefix("api/v1/player")]
    public class PlayerController : ApiController
    {
        [Route("")]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, GetMockPlayers());
        }
        [Route("{playerId}")]
        public HttpResponseMessage GetPlayer(int playerId)
        {
            List<Player> players = GetMockPlayers();
            Player player = players.Where(p => p.Id == playerId).FirstOrDefault();

            return Request.CreateResponse(HttpStatusCode.OK, player);
        }
        [Route("teams/{playerId}")]
        public HttpResponseMessage GetPlayerTeams(int playerId)
        {
            List<Player> players = GetMockPlayers();
            Player p = players[0];
            return Request.CreateResponse(HttpStatusCode.OK, p.TeamPlayers);
        }
        private List<Player> GetMockPlayers()
        {
            List<Player> players = new List<Player>();
            players.Add(new Player() { FirstName = "Sean", Id = 1, LastName = "Test1", MiddleName = "", Number = "2" });
            players.Add(new Player() { FirstName = "Mike", Id = 2, LastName = "Tester", MiddleName = "", Number = "3" });
            players.Add(new Player() { FirstName = "Sean", Id = 3, LastName = "Test2", MiddleName = "", Number = "4" });
            return players;
            
        }
    }
}
