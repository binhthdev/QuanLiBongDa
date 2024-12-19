using System.Collections.Generic;
using DAL;
using DTO;

namespace BUS
{
    public class PlayerBUS
    {
        private PlayerDAL playerDAL = new PlayerDAL();
        private TeamBUS teamBUS = new TeamBUS();

        public bool AddPlayer(PlayerDTO player)
        {
            return playerDAL.InsertPlayer(player);
        }

        public bool UpdatePlayer(PlayerDTO player)
        {
            return playerDAL.UpdatePlayer(player);
        }

        public bool DeletePlayer(string playerID)
        {
            return playerDAL.DeletePlayer(playerID);
        }

        public List<PlayerDTO> GetPlayers()
        {
            return playerDAL.GetAllPlayers();
        }

        public List<PlayerDTO> SearchPlayers(string keyword)
        {
            return playerDAL.SearchPlayer(keyword);
        }

        public List<Team> GetTeams()
        {
            return teamBUS.GetTeams();
        }

    }
}
